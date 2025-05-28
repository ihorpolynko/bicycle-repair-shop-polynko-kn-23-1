DELIMITER //
CREATE TRIGGER before_order_delete
BEFORE DELETE ON `order`
FOR EACH ROW
BEGIN
    DELETE FROM order_detail WHERE order_id = OLD.order_id;
END //
DELIMITER ;