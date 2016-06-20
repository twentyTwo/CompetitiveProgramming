SELECT 
Score,
(SELECT COUNT(DISTINCT(Score))+1 FROM Scores AS s2 WHERE s2.Score > s.score) AS Rank
FROM Scores AS s ORDER BY s.Score DESC
