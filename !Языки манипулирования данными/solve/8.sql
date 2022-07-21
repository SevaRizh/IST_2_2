-- Найти  наибольшие заказы продавцов Serres и Rifkin

-- Подключемся в базе данных orders
USE orders;

-- Создаём "Обобщённое Табличое Выражение", грубо говоря временную таблицу, с именем sels
WITH sels AS (
    -- Содержимым sels является результат выполнения подзапроса:
    -- Получить столбцы snum и sname
    SELECT snum, sname
    --  Из salespeople
    FROM salespeople
    -- Где sname равно "Serres" или "Rifkin"
    WHERE sname = N'Serres' OR sname = N'Rifkin'
)
-- Получить столбцы snum и sname из sels и максимальное значение столбца amt из orders, которому будет дано имя max_amt
SELECT sels.snum, sels.sname, MAX(orders.amt) as max_amt
-- Из таблиц sels и orders
FROM sels INNER JOIN orders
-- При этом, поля snum в sels и orders должны быть равны
ON sels.snum = orders.snum
-- Сгруппированное по паре snum и sname из sels
GROUP BY sels.snum, sels.sname;
