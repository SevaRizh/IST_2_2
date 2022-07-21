-- Вывести пары продавцов - заказчиков живущих в одном городе

-- Подключемся в базе данных orders
USE orders;

-- Получить столбец sname из таблицы salespeople и столбец cname из таблицы customers
SELECT salespeople.sname, customers.cname
-- Из таблиц customers и salespeople (утсановление внутреннего соединения)
FROM customers INNER JOIN salespeople
-- При этом city из customers должно быть равно city из salespeople
ON customers.city = salespeople.city;
