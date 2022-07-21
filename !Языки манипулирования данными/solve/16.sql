-- Вывести из таблицы Заказов все заказы продавца Motika

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы таблицы orders
SELECT orders.*
-- Из таблиц orders и salespeople (с установлением внутреннего соединения)
FROM orders INNER JOIN salespeople
-- При этом snum из orders должно быть равно snum из salespeople
ON orders.snum = salespeople.snum
-- Где sname из salespeople равно "Motika"
WHERE salespeople.sname = N'Motika';
