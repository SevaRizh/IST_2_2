-- Найти все пары заказчиков обслуживаемых одним продавцом.

USE orders;

SELECT * FROM customers;

SELECT one.snum, one.cnum, one.cname, two.cnum, two.cname
FROM customers AS one,
     customers AS two
WHERE one.snum = two.snum
    AND one.cnum < two.cnum;
