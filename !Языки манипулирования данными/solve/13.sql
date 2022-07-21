-- Вывести все пары заказчиков имеющих один и тот же рейтинг (rating)

-- Подключемся в базе данных orders
USE orders;

SELECT one.cnum, one.cname, two.cnum, two.cname, one.rating
FROM customers AS one,
     customers AS two
WHERE one.rating = two.rating
    AND one.cnum < two.cnum;
