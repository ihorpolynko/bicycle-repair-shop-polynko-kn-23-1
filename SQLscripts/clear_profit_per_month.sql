SELECT period,
       (`Чистий прибуток за кожний місяць` -
        FLOOR(`Чистий прибуток за кожний місяць` / 1.5)) AS "Витрати на розвиток бізнесу з чистого прибутку за останній місяць"
FROM profit_view
ORDER BY period DESC LIMIT 1;