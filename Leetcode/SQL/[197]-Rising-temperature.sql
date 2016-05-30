# 197. Rising Temperature

SELECT w1.Id
FROM Weather w1, Weather w2
WHERE w1.Date = w2.Date  + INTERVAL 1 DAY 
AND w1.Temperature > w2.Temperature
