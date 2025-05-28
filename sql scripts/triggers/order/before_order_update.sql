DELIMITER //
CREATE TRIGGER before_order_update
BEFORE UPDATE ON `order`
FOR EACH ROW
BEGIN
    IF (SELECT position FROM workers WHERE worker_id = NEW.worker_id) NOT LIKE 'Manager' THEN
        SET NEW.worker_id = NULL;
    END IF;
END //