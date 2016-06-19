# Write your MySQL query statement below
SELECT d.Name AS Department, e.Name AS Employee, e.Salary AS Salary  
FROM Employee AS e
INNER JOIN Department AS d ON e.DepartmentId = d.Id
INNER JOIN (SELECT MAX(Salary) AS maxSalary, DepartmentId FROM Employee GROUP BY DepartmentId) AS emp ON emp.maxSalary = e.Salary
WHERE emp.DepartmentId = e.DepartmentId
