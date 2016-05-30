# Leetcode database solutions 
# Write a SQL query to delete all duplicate email entries in a table named Person, keeping only unique emails based on its smallest Id.

DELETE p2.*
FROM Person AS p1, Person AS p2
WHERE p2.Email = p1.Email AND p2.Id > p1.Id
