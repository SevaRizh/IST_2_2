-- Вывести все тройки заказчиков: один с рейтингом (rating) 100, второй 200, третий 300

-- Подключемся в базе данных orders
USE orders;

WITH one AS (
    SELECT cnum, cname, rating
    FROM customers
    WHERE rating = 100
), two AS (
    SELECT cnum, cname, rating
    FROM customers
    WHERE rating = 200
), three AS (
    SELECT cnum, cname, rating
    FROM customers
    WHERE rating = 300
)
SELECT *
FROM one, two, three;
