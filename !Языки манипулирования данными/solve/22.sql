-- Подсчитать количество заказчиков в San Jose с оценками (rating) выше среднего

-- Подключемся в базе данных orders
USE orders;

-- Создаём "Обобщённое Табличое Выражение", грубо говоря временную таблицу, с именем avg
WITH avg as (
    -- Содержимым avg является результат выполнения подзапроса:
    -- Получить среднее значение столбца rating и записать под именем rank
    SELECT AVG(rating) as rank
    -- Из таблицы customers
    FROM customers
)
-- Получить количество записей
SELECT COUNT(*)
-- Из таблиц customers и avg ("временная таблица") (с использованием внутреннего связывания)
FROM customers INNER JOIN avg
-- При этом поле rating из customers должно быть больше поля rank из avg
ON customers.rating > avg.rank
-- Где поле city из customers равно "San Jose"
WHERE customers.city = N'San Jose';
