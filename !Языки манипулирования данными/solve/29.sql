-- Выбрать заказчиков, сделавших заказы 3 октября 1990 года

-- Подключемся в базе данных orders
USE orders;

-- Получить столбец cname таблицы orders
SELECT customers.cname
-- Из таблиц orders и customers (с установлением внутреннего соединения)
FROM orders INNER JOIN customers
-- При этом cnum из orders должно быть равно cnum из customers
ON orders.cnum = customers.cnum
-- Где odate из orders равно 3 октября 1990 года
WHERE orders.odate = '10/03/1990';

