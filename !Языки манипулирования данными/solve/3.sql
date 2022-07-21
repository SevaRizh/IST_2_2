-- Найти все записи в таблице Заказчиков  с NULL-значениями в столбце city

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы
SELECT *
-- Из таблицы customers
FROM customers
-- Где значение поля city составляет NULL
WHERE city IS NULL;
