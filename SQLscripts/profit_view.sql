CREATE VIEW profit_view AS
SELECT profit.period,
       (profit.profit_kilkist - profit.vutraru - sum_zarplata_worker.sum_zarplata - sum_zarplata_master.sum_zarplata) AS 'Чистий прибуток за кожний місяць'
FROM profit
CROSS JOIN (SELECT SUM(worker.zarplata_worker) AS sum_zarplata FROM worker) AS sum_zarplata_worker
CROSS JOIN (SELECT (14000 * COUNT(master.master_id)) AS sum_zarplata FROM master) AS sum_zarplata_master
GROUP BY profit.period,
         profit.profit_kilkist,
         profit.vutraru,
         sum_zarplata_worker.sum_zarplata,
         sum_zarplata_master.sum_zarplata;