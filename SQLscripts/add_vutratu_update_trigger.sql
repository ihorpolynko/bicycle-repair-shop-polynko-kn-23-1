DELIMITER //
CREATE TRIGGER add_vutratu_update
    BEFORE UPDATE
    ON sklad
    FOR EACH ROW
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
//
DELIMITER ;