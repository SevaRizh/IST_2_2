-- Подсчитать количество заказов каждого из продавцов, и вывести результаты в убывающем порядке

-- Подключемся в базе данных orders
USE orders;

-- Создаём "Обобщённое Табличое Выражение", грубо говоря временную таблицу, с именем sels
WITH sels AS (
    -- Содержимым sels является результат выполнения подзапроса:
    -- Получить столбцы snum и sname
    SELECT snum, sname
    --  Из salespeople
    FROM salespeople
)
-- Получить столбцы snum и sname из sels и количество записей, которому будет дано имя count
SELECT sels.snum, sels.sname, COUNT(*) as count
-- Из таблиц sels и orders
FROM sels INNER JOIN orders
-- При этом, поля snum в sels и orders должны быть равны
ON sels.snum = orders.snum
-- Сгруппированное по паре snum и sname из sels
GROUP BY sels.snum, sels.sname
-- Отсортированное по полю count в порядке убывания
ORDER BY count DESC;
