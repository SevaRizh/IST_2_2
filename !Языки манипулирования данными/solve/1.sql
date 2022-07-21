-- Выбрать всех заказчиков чьи имена попали в алфавитный диапазон 'A' - 'G'
-- Будем считать, что надо выбрать всех включая граничных

-- Подключемся в базе данных orders
USE orders;

-- Получить все столбцы
SELECT *
-- Из таблицы customers
FROM customers
-- Где значение поля cname при лексикографическом сравнении больше либо равно A и меньше H
WHERE cname >= N'A' AND cname < N'H';

-- Другой вариант:
SELECT * FROM customers
-- Где значение cname лексикографически между A и H
WHERE cname BETWEEN N'A' AND N'H';

-- Другой вариант:
SELECT * FROM customers
-- Где значение cname совпадает с шаблоном "А%"
WHERE cname LIKE N'A%'
-- или значение cname совпадает с шаблоном "B%"
OR    cname LIKE N'B%'
-- или значение cname совпадает с шаблоном "C%"
OR    cname LIKE N'C%'
-- или значение cname совпадает с шаблоном "D%"
OR    cname LIKE N'D%'
-- или значение cname совпадает с шаблоном "E%"
OR    cname LIKE N'E%'
-- или значение cname совпадает с шаблоном "F%"
OR    cname LIKE N'F%'
-- или значение cname совпадает с шаблоном "G%"
OR    cname LIKE N'G%';
-- Знак "%" в шаблоне означает "ноль и более символов"

-- Другой вариант:
SELECT * FROM customers
-- Где значение cname совпадает с шаблоном "[ABCDEFG]%"
WHERE cname LIKE N'[ABCDEFG]%';
-- Шаблон читается, как "Любой символ из списка (A, B, C, D, E, F, G) и ноль или более символов после него"
