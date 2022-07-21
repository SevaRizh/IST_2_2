-- Найти продавцов, заказчики которых имеют более чем один заказ.

-- Подключемся в базе данных orders
USE orders;

WITH ords AS (
    SELECT cnum, COUNT(*) as count
    FROM orders
    GROUP BY cnum
), custs AS (
    SELECT customers.snum
    FROM customers INNER JOIN ords
    ON ords.cnum = customers.cnum
    WHERE ords.count > 1
)
SELECT salespeople.*
FROM salespeople INNER JOIN custs
ON salespeople.snum = custs.snum;