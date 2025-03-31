DELIMITER //
CREATE TRIGGER add_profit
    AFTER INSERT
    ON zamov
    FOR EACH ROW
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
END; //
DELIMITER ;