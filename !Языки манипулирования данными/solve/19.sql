-- Найти среднее значение комиссионных продавцов в Лондоне

-- Подключемся в базе данных orders
USE orders;

-- Получить среднее значение столбца comm
SELECT AVG(comm)
-- Из таблицы salespeople
FROM salespeople
-- Где поле city равно "London"
WHERE city = N'London';
