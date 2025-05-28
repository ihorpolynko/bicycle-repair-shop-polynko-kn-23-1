create schema 'bicycle-repair-shop-kursova-polynko-kn-23-1';
use `bicycle-repair-shop-kursova-polynko-kn-23-1`;

create table clients
(
    client_id    int auto_increment
        primary key,
    pib          varchar(255) not null,
    phone_number varchar(20)  not null
);

create table details
(
    detail_id int auto_increment
        primary key,
    name      varchar(255)   not null,
    price     decimal(15, 2) not null
);

create table users
(
    user_id  int auto_increment
        primary key,
    login    varchar(100) not null,
    password varchar(100) not null,
    role     varchar(50)  not null,
    constraint login
        unique (login)
);

create table workers
(
    worker_id    int auto_increment
        primary key,
    pib          varchar(255)   not null,
    position     varchar(255)   not null,
    phone_number varchar(20)    not null,
    salary       decimal(15, 2) not null
);

create table `order`
(
    order_id       int auto_increment
        primary key,
    client_id      int            not null,
    worker_id      int            not null,
    order_date     datetime       not null,
    payment_amount decimal(15, 2) null,
    payment_date   datetime       null,
    constraint order_clients_client_id_fk
        foreign key (client_id) references clients (client_id),
    constraint order_workers_worker_id_fk
        foreign key (worker_id) references workers (worker_id)
);

create definer = root@localhost trigger before_order_delete
    before delete
    on `order`
    for each row
BEGIN
    DELETE FROM order_detail WHERE order_id = OLD.order_id;
END;

create definer = root@localhost trigger before_order_insert
    before insert
    on `order`
    for each row
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Manager' THEN
        SET NEW.worker_id = NULL;
    END IF;
END;

create definer = root@localhost trigger before_order_update
    before update
    on `order`
    for each row
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Manager' THEN
        SET NEW.worker_id = NULL;
    END IF;
END;

create table order_detail
(
    order_id         int not null,
    detail_id        int not null,
    quantity_details int not null,
    primary key (order_id, detail_id),
    constraint order_detail_details_detail_id_fk
        foreign key (detail_id) references details (detail_id),
    constraint order_detail_order_order_id_fk
        foreign key (order_id) references `order` (order_id)
);

create definer = root@localhost trigger after_order_detail_insert
    after insert
    on order_detail
    for each row
BEGIN
    DECLARE total_amount DECIMAL(15,2);

    SELECT SUM(d.price * od.quantity_details) INTO total_amount
    FROM order_detail od
    JOIN details d ON od.detail_id = d.detail_id
    WHERE od.order_id = NEW.order_id;

    UPDATE `order`
    SET payment_amount = total_amount
    WHERE order_id = NEW.order_id;
END;

create definer = root@localhost trigger after_order_detail_update
    after update
    on order_detail
    for each row
BEGIN
    DECLARE total_amount DECIMAL(15,2);

    SELECT SUM(d.price * od.quantity_details) INTO total_amount
    FROM order_detail od
    JOIN details d ON od.detail_id = d.detail_id
    WHERE od.order_id = NEW.order_id;

    UPDATE `order`
    SET payment_amount = total_amount
    WHERE order_id = NEW.order_id;
END;

create table sign_up_repairs
(
    sign_up_repairs_id int auto_increment
        primary key,
    worker_id          int            not null,
    client_id          int            not null,
    repair_reason      varchar(255)   not null,
    sign_up_date       datetime       not null,
    payment_amount     decimal(15, 2) null,
    payment_date       datetime       null,
    constraint sign_up_repairs_clients_client_id_fk
        foreign key (client_id) references clients (client_id),
    constraint sign_up_repairs_workers_worker_id_fk
        foreign key (worker_id) references workers (worker_id)
);

create definer = root@localhost trigger before_sign_up_repairs_insert
    before insert
    on sign_up_repairs
    for each row
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Master' THEN
        SET NEW.worker_id = NULL;
    END IF;
END;

create definer = root@localhost trigger before_sign_up_repairs_update
    before update
    on sign_up_repairs
    for each row
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Master' THEN
        SET NEW.worker_id = NULL;
    END IF;
END;

create definer = root@localhost view expanded_order_detail as
select `od`.`order_id`                              AS `order_id`,
       `w`.`pib`                                    AS `worker_pib`,
       `c`.`pib`                                    AS `client_pib`,
       `o`.`order_date`                             AS `order_date`,
       `d`.`name`                                   AS `detail_name`,
       sum(`od`.`quantity_details`)                 AS `quantity`,
       sum((`d`.`price` * `od`.`quantity_details`)) AS `total_price`
from ((((`bicycle-repair-shop-kursova-polynko-kn-23-1`.`order_detail` `od` join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`order` `o`
         on ((`od`.`order_id` = `o`.`order_id`))) join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`workers` `w`
        on ((`o`.`worker_id` = `w`.`worker_id`))) join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`clients` `c`
       on ((`o`.`client_id` = `c`.`client_id`))) join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`details` `d`
      on ((`od`.`detail_id` = `d`.`detail_id`)))
where (`o`.`payment_date` is not null)
group by `od`.`order_id`, `w`.`pib`, `c`.`pib`, `o`.`order_date`, `d`.`name`;

create definer = root@localhost view expanded_sign_up_repairs as
select `sur`.`sign_up_repairs_id` AS `sign_up_repairs_id`,
       `w`.`pib`                  AS `worker_pib`,
       `c`.`pib`                  AS `client_pib`,
       `sur`.`sign_up_date`       AS `sign_up_date`,
       `sur`.`payment_amount`     AS `payment_amount`
from ((`bicycle-repair-shop-kursova-polynko-kn-23-1`.`sign_up_repairs` `sur` join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`workers` `w`
       on ((`sur`.`worker_id` = `w`.`worker_id`))) join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`clients` `c`
      on ((`sur`.`client_id` = `c`.`client_id`)))
where (`sur`.`payment_date` is not null);

create definer = root@localhost view product_demand as
select `d`.`detail_id`                           AS `detail_id`,
       `d`.`name`                                AS `name`,
       `d`.`price`                               AS `price`,
       coalesce(sum(`od`.`quantity_details`), 0) AS `total_sold`
from (`bicycle-repair-shop-kursova-polynko-kn-23-1`.`details` `d` left join `bicycle-repair-shop-kursova-polynko-kn-23-1`.`order_detail` `od`
      on ((`d`.`detail_id` = `od`.`detail_id`)))
group by `d`.`detail_id`, `d`.`name`, `d`.`price`
order by `total_sold` desc;

