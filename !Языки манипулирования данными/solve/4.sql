-- Найти сумму заказов в таблице Заказов

-- Подключемся в базе данных orders
USE orders;

-- Получить сумму столбцов amt
SELECT SUM(amt)
-- Из таблицы orders
FROM orders
-- Где значение поля amt не равно NULL (с NULL нельзя складывать)
WHERE amt IS NOT NULL;
