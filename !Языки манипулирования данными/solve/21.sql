-- Вывести комиссионные всех продавцов обслуживающих заказчиков в Лондоне

-- Подключемся в базе данных orders
USE orders;

-- Получить столбцы snum, sname и comm из salespeople
-- Но выбрать только РАЗЛИЧАЮЩИЕСЯ записи (дубли отбрасываются)
SELECT DISTINCT salespeople.snum, salespeople.sname, salespeople.comm
-- Из таблиц salespeople и customers (с установлением внутреннего соединения)
FROM salespeople INNER JOIN customers
-- При этом поля snum должны быть равны друг другу
ON customers.snum = salespeople.snum
-- Где поле city из таблицы customers равно "London"
WHERE customers.city = N'London';
