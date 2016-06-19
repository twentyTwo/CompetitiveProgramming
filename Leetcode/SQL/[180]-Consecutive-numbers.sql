/* DISTINCT because at least 3 numbers */
SELECT DISTINCT n1.Num AS ConsecutiveNums
FROM Logs AS n1 
INNER JOIN Logs AS n2 ON n1.Num = n2.Num
INNER JOIN Logs AS n3 ON n1.Num = n3.Num
WHERE n1.id+1 = n2.id AND n2.id+1 = n3.id 
