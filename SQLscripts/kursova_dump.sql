create schema kursova_polynko_kn_23_1;

use kursova_polynko_kn_23_1;

create table if not exists client
(
    client_id     int         not null
        primary key,
    client_pib    varchar(45) null,
    type_of_zamov varchar(45) null
);

create table if not exists master
(
    master_id  int         not null
        primary key,
    master_pib varchar(45) null
);

create table if not exists profit
(
    period int not null
        primary key,
    profit_kilkist double null,
    vutraru        int    null
);

create table if not exists sklad
(
    place_id      int         not null
        primary key,
    tovar_id      int         null,
    nayavnist     varchar(4)  null,
    kilkist_tovar int         null
);

create trigger add_vutratu_insert
    before insert
    on sklad
    for each row
BEGIN
    DECLARE last_period INT;

    -- Отримуємо останній період
    SELECT period
    INTO last_period
    FROM profit
    ORDER BY period DESC
    LIMIT 1;

    -- Якщо кількість товару більша за 0, обчислюємо витрати
    IF NEW.kilkist_tovar > 0 THEN
        UPDATE profit
        INNER JOIN tovar ON NEW.tovar_id = tovar.tovar_id
        SET profit.vutraru = IFNULL(profit.vutraru, 0) + (NEW.kilkist_tovar * tovar.prise_of_tovar * 0.5)
        WHERE profit.period = last_period
          AND tovar.tovar_id = NEW.tovar_id;
    END IF;
END;

create trigger add_vutratu_update
    before update
    on sklad
    for each row
BEGIN
    DECLARE last_period INT;

    -- Отримуємо останній період
    SELECT period
    INTO last_period
    FROM profit
    ORDER BY period DESC
    LIMIT 1;

    -- Оновлюємо витрати, якщо кількість товару збільшилась
    IF OLD.kilkist_tovar IS NOT NULL AND NEW.kilkist_tovar > OLD.kilkist_tovar THEN
        UPDATE profit
            INNER JOIN tovar ON NEW.tovar_id = tovar.tovar_id
        SET profit.vutraru = IFNULL(profit.vutraru, 0) +
                             (NEW.kilkist_tovar - OLD.kilkist_tovar) * (tovar.prise_of_tovar * 0.5)
        WHERE profit.period = last_period
          AND tovar.tovar_id = NEW.tovar_id;
    END IF;
END;

create trigger nayavnist_trigger_insert
    before insert
    on sklad
    for each row
BEGIN
    IF NEW.kilkist_tovar = 0 OR NEW.kilkist_tovar IS NULL THEN
        SET NEW.nayavnist = "нема";
    END IF;

    IF NEW.kilkist_tovar >= 1 THEN
       SET NEW.nayavnist = "є";
    END IF;

    IF NEW.kilkist_tovar < 0 THEN
        SET NEW.nayavnist = "нема";
        SET NEW.kilkist_tovar = 0;
    END IF;
END;

create trigger nayavnist_trigger_update
    before update
    on sklad
    for each row
BEGIN
    IF NEW.kilkist_tovar = 0 OR NEW.kilkist_tovar IS NULL THEN
        SET NEW.nayavnist = "нема";
    END IF;

    IF NEW.kilkist_tovar >= 1 THEN
       SET NEW.nayavnist = "є";
    END IF;

    IF NEW.kilkist_tovar < 0 THEN
        SET NEW.nayavnist = "нема";
        SET NEW.kilkist_tovar = 0;
    END IF;
END;

create table if not exists tovar
(
    tovar_id       int         not null
        primary key,
    type_of_tovar  varchar(45) null,
    prise_of_tovar double      null
);

alter table sklad
    add constraint tovar_id
        foreign key (tovar_id) references tovar (tovar_id);

create table if not exists worker
(
    worker_id       int         not null
        primary key,
    worker_pib      varchar(45) null,
    worker_posada   varchar(45) null,
    zarplata_worker double      null
);

create table if not exists zamov
(
    zamov_id      int  not null
        primary key,
    client_id     int  null,
    worker_id     int  null,
    tovar_id      int  null,
    kilkist_tovar int  null,
    date_of_zamov date null,
    constraint client_id_zamov
        foreign key (client_id) references client (client_id),
    constraint tovar_id_for_zamov
        foreign key (tovar_id) references tovar (tovar_id),
    constraint worker_id
        foreign key (worker_id) references worker (worker_id)
);

create trigger add_profit
    after insert
    on zamov
    for each row
BEGIN
    -- Перевіряємо, чи достатньо товару на складі
    DECLARE available_quantity INT;

    -- Отримуємо кількість доступного товару на складі
    SELECT kilkist_tovar
    INTO available_quantity
    FROM sklad
    WHERE sklad.tovar_id = NEW.tovar_id
    LIMIT 1;

    -- Якщо товару недостатньо або його немає на складі, генеруємо помилку
    IF available_quantity IS NULL OR available_quantity < NEW.kilkist_tovar THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Недостатньо товару на складі для замовлення';
    ELSE
        -- Оновлюємо таблицю profit
        UPDATE profit
            INNER JOIN tovar ON NEW.tovar_id = tovar.tovar_id
            INNER JOIN zamov
        SET profit_kilkist = profit_kilkist + (tovar.prise_of_tovar * NEW.kilkist_tovar)
        WHERE tovar.tovar_id = NEW.tovar_id
          AND profit.period = MONTH(NEW.date_of_zamov);

        -- Віднімаємо кількість товару на складі
        UPDATE sklad
        SET sklad.kilkist_tovar = sklad.kilkist_tovar - NEW.kilkist_tovar
        WHERE tovar_id = NEW.tovar_id;
    END IF;
END;

create table if not exists zapus_na_remont
(
    zapus_na_remont_id int         not null
        primary key,
    client_id          int         null,
    master_id          int         null,
    reason_of_remont   varchar(45) null,
    remont_date        date        null,
    oplata             double      null,
    constraint client_id_zapus
        foreign key (client_id) references client (client_id),
    constraint master_id
        foreign key (master_id) references master (master_id)
);

create trigger add_profit_remont
    after insert
    on zapus_na_remont
    for each row
BEGIN
    UPDATE profit
    SET profit_kilkist = COALESCE(profit_kilkist, 0) + (NEW.oplata - 100)
    WHERE profit.period = MONTH(NEW.remont_date);
END;

create view profit_view as
select `lr5poylnko`.`profit`.`period`                                                            AS `period`,
       (((sum(`lr5poylnko`.`profit`.`profit_kilkist`) - sum(`lr5poylnko`.`profit`.`vutraru`)) -
         sum(`sum_zarplata_worker`.`sum_zarplata`)) -
        sum(`sum_zarplata_master`.`sum_zarplata`))                                               AS `Чистий прибуток за кожний місяць`
from ((`lr5poylnko`.`profit` join (select sum(`lr5poylnko`.`worker`.`zarplata_worker`) AS `sum_zarplata`
                                   from `lr5poylnko`.`worker`) `sum_zarplata_worker`) join (select (7000 * count(`lr5poylnko`.`master`.`master_id`)) AS `sum_zarplata`
                                                                                            from `lr5poylnko`.`master`) `sum_zarplata_master`)
group by `lr5poylnko`.`profit`.`period`;

create view zamov_avg as
select avg(`lr5poylnko`.`zamov`.`kilkist_tovar`) AS `AVG(kilkist_tovar)`
from `lr5poylnko`.`zamov`;

create view zamov_counts as
select `lr5poylnko`.`zamov`.`client_id` AS `client_id`, count(`lr5poylnko`.`zamov`.`zamov_id`) AS `zamov_count`
from `lr5poylnko`.`zamov`
group by `lr5poylnko`.`zamov`.`client_id`;


