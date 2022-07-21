-- Вывести для каждого заказчика имя продавца который его обслуживает

-- Подключемся в базе данных orders
USE orders;

-- Получить столбец cname из таблицы customers и столбец sname из таблицы salespeople
SELECT customers.cname, salespeople.sname
-- Из таблиц customers и salespeople (утсановление внутреннего соединения)
FROM customers INNER JOIN salespeople
-- При этом snum из customers должно быть равно snum из salespeople
ON customers.snum = salespeople.snum;
