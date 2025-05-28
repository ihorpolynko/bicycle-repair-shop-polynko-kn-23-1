CREATE VIEW expanded_order_detail AS
SELECT od.order_id, w.pib AS worker_pib, c.pib AS client_pib, o.order_date, d.name AS detail_name,
       SUM(od.quantity_details) AS quantity,
       SUM(d.price * od.quantity_details) AS total_price
FROM order_detail od
JOIN `order` o ON od.order_id = o.order_id
JOIN workers w ON o.worker_id = w.worker_id
JOIN clients c ON o.client_id = c.client_id
JOIN details d ON od.detail_id = d.detail_id
WHERE o.payment_date IS NOT NULL
GROUP BY od.order_id, w.pib, c.pib, o.order_date, d.name;
