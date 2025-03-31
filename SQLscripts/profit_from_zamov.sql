SELECT SUM(tovar.prise_of_tovar * zamov.kilkist_tovar) AS 'Сума усіх замовлень'
FROM zamov
         INNER JOIN tovar ON tovar.tovar_id = zamov.tovar_id;