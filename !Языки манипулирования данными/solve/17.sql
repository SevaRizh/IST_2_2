-- Вывести все заказы продавца, который обслуживает Hoffman'а.

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы из orders
SELECT orders.*
-- Из таблиц customers и orders (с установлением внутреннего соединения)
FROM customers INNER JOIN orders
-- При этом поля snum должны быть равны друг другу
ON orders.snum = customers.snum
-- Где поле cname из таблицы customers равно "Hoffman"
WHERE customers.cname = N'Hoffman';
