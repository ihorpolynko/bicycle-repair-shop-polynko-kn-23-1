CREATE VIEW zamov_counts AS
SELECT client_id AS client_id, COUNT(zamov_id) AS `zamov_count`
FROM zamov
GROUP BY client_id;