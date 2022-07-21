-- Найти наибольшую сумму приобретений (amt) получаемую каждым продавцом каждый день

USE orders;

SELECT snum, odate, MAX(amt) as max_amt
FROM orders
GROUP BY snum, odate
ORDER BY snum, odate;
