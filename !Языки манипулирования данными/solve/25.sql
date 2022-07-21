-- Найти всех заказчиков размещенных в городах где продавец Serres ( snum 1002 ) имеет заказчиков.

USE orders;

WITH towns AS (
    SELECT city
    FROM customers
    WHERE snum = 1002
    GROUP BY city
)
SELECT customers.*
FROM towns INNER JOIN customers
ON towns.city = customers.city;
