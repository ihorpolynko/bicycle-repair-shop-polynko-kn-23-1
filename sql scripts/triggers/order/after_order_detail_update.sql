DELIMITER //
CREATE TRIGGER after_order_detail_update
AFTER UPDATE ON order_detail
FOR EACH ROW
BEGIN
    DECLARE total_amount DECIMAL(15,2);

    SELECT SUM(d.price * od.quantity_details) INTO total_amount
    FROM order_detail od
    JOIN details d ON od.detail_id = d.detail_id
    WHERE od.order_id = NEW.order_id;

    UPDATE `order`
    SET payment_amount = total_amount
    WHERE order_id = NEW.order_id;
END //
DELIMITER ;