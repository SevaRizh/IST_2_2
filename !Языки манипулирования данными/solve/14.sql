-- Вывести все пары заказчиков: один с рейтингом (rating) 100, второй 200

-- Подключемся в базе данных orders
USE orders;

WITH one AS (
    SELECT cnum, cname, rating
    FROM customers
    WHERE rating = 100
)
SELECT one.*, customers.cnum, customers.cname, customers.rating
FROM one INNER JOIN customers
ON customers.rating = 200;
