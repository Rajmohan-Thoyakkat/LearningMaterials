
--We use SQL PARTITION BY to divide the result set into partitions and perform computation on each subset of partitioned data.


CREATE TABLE #Orders
(
    [orderid] INT,
    [Orderdate] DATE,
    [CustomerName] VARCHAR(100),
    [Customercity] VARCHAR(100), 
    [Orderamount] MONEY
)
SELECT * FROM #Orders AS O

INSERT #Orders  VALUES (1, CAST(N'1826-12-19' AS Date), N'Edward', N'Phoenix', 2)
INSERT #Orders  VALUES (2, CAST(N'1826-12-09' AS Date), N'Paul', N'San Francisco', 1)
INSERT #Orders  VALUES (3, CAST(N'1826-12-09' AS Date), N'smith', N'San Francisco', 2)
INSERT #Orders  VALUES (4, CAST(N'1826-12-19' AS Date), N'hira', N'San Francisco', 3)
INSERT #Orders  VALUES (5, CAST(N'1826-12-06' AS Date), N'avish', N'Phoenix', 2)
INSERT #Orders  VALUES (6, CAST(N'1826-12-07' AS Date), N'christine', N'Chicago', 5)
INSERT #Orders  VALUES (7, CAST(N'1826-12-08' AS Date), N'lika', N'Dellas', 4)
INSERT #Orders  VALUES (8, CAST(N'1826-12-09' AS Date), N'moris', N'Florida', 2)
INSERT #Orders  VALUES (9, CAST(N'1826-12-03' AS Date), N'lin', N'New york', 1)
INSERT #Orders  VALUES (10, CAST(N'1826-12-04' AS Date), N'chik', N'Washington', 3)


--We use SQL GROUP BY clause to group results by specified column and use aggregate functions such as Avg(), Min(), Max() to calculate required values.
--Once we execute this query, we get an error message. In the SQL GROUP BY clause, we can use a column in the select statement if it is used in Group by clause as well.
--It does not allow any column in the select clause that is not part of GROUP BY clause.

SELECT  O.Customercity,
COUNT(O.Customercity) AS counts,AVG(O.Orderamount) AS Average_Amount, MAX(O.Orderamount) AS Max_Amount, SUM(O.Orderamount) AS Total_Amount
FROM #Orders AS O
--GROUP BY O.Customercity


--We can use the SQL PARTITION BY clause with the OVER clause to specify the column on which we need to perform aggregation. 
--In the previous example, we used Group By with CustomerCity column and calculated average, minimum and maximum values.
SELECT O.CustomerName,O.Customercity,O.Orderamount
,AVG(O.Orderamount) OVER (PARTITION BY O.Customercity) AS Average
,MAX(O.Orderamount) OVER (PARTITION BY O.Customercity) AS Maximum
,SUM(O.Orderamount) OVER (PARTITION BY O.Customercity) AS Total
FROM #Orders AS O

SELECT O.CustomerName,O.Customercity,O.Orderamount
,AVG(O.Orderamount) OVER (PARTITION BY O.Customercity ORDER BY OrderAmount DESC ROWS UNBOUNDED PRECEDING) AS Average
,MAX(O.Orderamount) OVER (PARTITION BY O.Customercity) AS Maximum
,SUM(O.Orderamount) OVER (PARTITION BY O.Customercity) AS Total
FROM #Orders AS O

SELECT O.Customercity
,AVG(O.Orderamount) OVER (PARTITION BY O.Customercity ) AS avergae
,MAX(O.Orderamount) OVER (PARTITION BY o.Customercity) AS maximum
,SUM(O.Orderamount) OVER (PARTITION BY O.Customercity) AS total
FROM #Orders AS O

DELETE FROM #Orders
DROP table #Orders
