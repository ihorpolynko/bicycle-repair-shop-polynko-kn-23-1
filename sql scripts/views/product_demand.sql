CREATE VIEW product_demand AS
SELECT d.detail_id, d.name, d.price,
       COALESCE(SUM(od.quantity_details), 0) AS total_sold
FROM details d
LEFT JOIN order_detail od ON d.detail_id = od.detail_id
GROUP BY d.detail_id, d.name, d.price
ORDER BY total_sold DESC;