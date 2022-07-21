-- Вывести все строки таблицы Заказов для продавцов в Лондоне

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы из orders
SELECT orders.*
-- Из таблиц salespeople и orders (с установлением внутреннего соединения)
FROM salespeople INNER JOIN orders
-- При этом поля snum должны быть равны друг другу
ON orders.snum = salespeople.snum
-- Где поле city из таблицы salespeople равно "London"
WHERE salespeople.city = N'London';
