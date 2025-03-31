DELIMITER //
CREATE TRIGGER add_vutratu_insert
    BEFORE INSERT
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

    -- Якщо кількість товару більша за 0, обчислюємо витрати
    IF NEW.kilkist_tovar > 0 THEN
        UPDATE profit
        INNER JOIN tovar ON NEW.tovar_id = tovar.tovar_id
        SET profit.vutraru = IFNULL(profit.vutraru, 0) + (NEW.kilkist_tovar * tovar.prise_of_tovar * 0.5)
        WHERE profit.period = last_period
          AND tovar.tovar_id = NEW.tovar_id;
    END IF;
END;
//
DELIMITER ;