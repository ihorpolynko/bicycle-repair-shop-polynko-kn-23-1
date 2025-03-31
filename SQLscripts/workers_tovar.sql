SELECT DISTINCT LCASE(worker.worker_pib)             AS 'worker_pib',
                UCASE(tovar.type_of_tovar)           AS 'tovar_name',
                (CHAR_LENGTH(worker.worker_pib) - 2) AS 'Довжина ПІБ робітника'
FROM worker
         INNER JOIN zamov ON zamov.worker_id = worker.worker_id
         INNER JOIN tovar ON tovar.tovar_id = zamov.tovar_id
WHERE tovar.type_of_tovar = (SELECT type_of_tovar FROM Tovar WHERE tovar.tovar_id = zamov.tovar_id);