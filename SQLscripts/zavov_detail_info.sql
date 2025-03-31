SELECT zamov.zamov_id,
       client.client_pib,
       worker.worker_pib,
       tovar.type_of_tovar,
       kilkist_tovar,
       DAY(date_of_zamov) AS day_of_zamov
FROM zamov
         LEFT JOIN client ON zamov.client_id = client.client_id
         LEFT JOIN worker ON zamov.worker_id = worker.worker_id
         LEFT JOIN tovar ON zamov.tovar_id = tovar.tovar_id;
