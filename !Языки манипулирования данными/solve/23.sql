-- Вывести имена и номера всех продавцов которые имеют более одного заказчика

-- Подключемся в базе данных orders
USE orders;

-- Создаём "Обобщённое Табличое Выражение", грубо говоря временную таблицу, с именем clients
WITH clients as (
    -- Содержимым avg является результат выполнения подзапроса:
    -- Получить столбец snum и количество записей под именем count
    SELECT snum, COUNT(*) as count
    -- Из таблицы customers
    FROM customers
    -- Сгруппированное по столбцу snum
    GROUP BY snum
)
-- Получить количество записей
SELECT salespeople.snum, salespeople.sname
-- Из таблиц salespeople и clients ("временная таблица") (с использованием внутреннего связывания)
FROM salespeople INNER JOIN clients
-- При этом поля snum из salespeople и clients должны быть равны
ON clients.snum = salespeople.snum
-- Где поле count из clients больше 1
WHERE clients.count > 1;
