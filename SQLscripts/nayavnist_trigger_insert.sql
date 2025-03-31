delimiter //

CREATE TRIGGER nayavnist_trigger_insert
BEFORE INSERT ON sklad
FOR EACH ROW
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
END//