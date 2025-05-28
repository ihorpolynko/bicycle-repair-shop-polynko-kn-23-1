CREATE VIEW expanded_sign_up_repairs AS
SELECT sur.sign_up_repairs_id, w.pib AS worker_pib, c.pib AS client_pib,
       sur.sign_up_date, sur.payment_amount
FROM sign_up_repairs sur
JOIN workers w ON sur.worker_id = w.worker_id
JOIN clients c ON sur.client_id = c.client_id
WHERE sur.payment_date IS NOT NULL;