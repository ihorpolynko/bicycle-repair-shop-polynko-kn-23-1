DELIMITER //
CREATE TRIGGER before_sign_up_repairs_insert
BEFORE INSERT ON sign_up_repairs
FOR EACH ROW
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Master' THEN
        SET NEW.worker_id = NULL;
    END IF;
END //
DELIMITER ;