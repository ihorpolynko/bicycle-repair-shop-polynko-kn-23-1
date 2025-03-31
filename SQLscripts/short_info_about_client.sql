SELECT CONCAT(SUBSTRING_INDEX(UCASE(client.client_pib), ' ', 1), '-',
              client.type_of_zamov)     AS "Короткі відомості клієнта",
       tovar.type_of_tovar              AS "Назва товару",
       zapus_na_remont.reason_of_remont AS "Причина ремонту"
FROM client
         LEFT JOIN zamov ON zamov.client_id = client.client_id
         LEFT JOIN tovar ON zamov.tovar_id = tovar.tovar_id
         LEFT JOIN zapus_na_remont ON zapus_na_remont.client_id = client.client_id;