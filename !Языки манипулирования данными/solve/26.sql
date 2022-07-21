-- Найти всех продавцов, проживающих в Барселоне или Лондоне

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы
SELECT *
-- Из таблицы salespeople
FROM salespeople
-- Где city равно "Barcelona" или "London"
WHERE city = N'Barcelona' OR city = N'London';
