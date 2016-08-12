USE TelerikAcademy

SELECT

	SELECT *
	FROM Departments

	SELECT DepartmentID, Name
	FROM Departments

	SELECT LastName, Salary, Salary + 300
	FROM Employees

	SELECT FirstName, LastName, Salary, Salary * 0.2 AS Bonus
	FROM Employees

	SELECT FirstName + ' ' + LastName AS [Full Name], EmployeeID AS [No.]
	FROM Employees

	SELECT FirstName + '''s last name is ' + LastName AS [Our Employees]
	FROM Employees

	SELECT DepartmentID
	FROM Employees

	-- Eliminating duplicate rows
	SELECT
	DISTINCT DepartmentID
	FROM Employees

	-- UNION takes all from the two columns. INTERSECT - common things. EXCEPT - different ones
	SELECT FirstName AS Name
	FROM Employees
	UNION
	SELECT LastName AS Name
	FROM Employees

	SELECT LastName, DepartmentID
	FROM Employees
	WHERE DepartmentID = 1

	SELECT FirstName, LastName, DepartmentID
	FROM Employees
	WHERE LastName = 'Sullivan'

	SELECT LastName, Salary
	FROM Employees
	WHERE Salary <= 20000

	SELECT LastName, Salary
	FROM Employees
	WHERE Salary BETWEEN 20000 AND 22000

	-- IN filters by concret values. NOT IN filters by every other vales except the passing ones
	SELECT FirstName, LastName, ManagerID
	FROM Employees
	WHERE ManagerID IN (109, 3, 16)

	-- LIKE is for searching in text by some pattern. % means zero or more chars. _ means one char
	SELECT FirstName
	FROM Employees
	WHERE FirstName LIKE 'S%'

	SELECT LastName, ManagerId
	FROM Employees
	WHERE ManagerId IS NULL

	SELECT LastName, ManagerId
	FROM Employees
	WHERE ManagerId IS NOT NULL

	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >= 20000 AND LastName LIKE 'C%'

	SELECT LastName
	FROM Employees
	WHERE ManagerID IS NOT NULL OR LastName LIKE '%so_'

	SELECT LastName
	FROM Employees
	WHERE NOT (ManagerID = 3 OR ManagerID = 4)

	SELECT FirstName, LastName
	FROM Employees
	WHERE
		(ManagerID = 3 OR ManagerID = 4)
		AND
		(Salary >= 20000 OR ManagerID IS NULL)

	-- When more than one thing is enumerated in ORDER BY, it means THEN BY
	SELECT LastName, HireDate
	FROM Employees
	ORDER BY HireDate, LastName

	SELECT LastName, HireDate
	FROM Employees
	ORDER BY HireDate DESC

	SELECT LastName, Name AS DepartmentName
	FROM Employees, Departments

	-- INNER can be skipped, because the default JOIN is INNER
	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e
	INNER JOIN Departments d
    ON e.DepartmentID = d.DepartmentID

	-- INNER JOIN with WHERE clause
	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	-- Returns all rows, which matched condition, plus those from the LEFT table, which didn't match
	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	RIGHT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employee e
	FULL OUTER JOIN Employee m
	ON e.ManagerID = m.EmployeeID

	-- The second JOIN will execute over the result from the first one
	SELECT e.FirstName, e.LastName, t.Name AS Towns, a.AddressText
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID

	-- Self-join
	SELECT e.FirstName + ' ' + e.LastName + ' is managed by ' + m.LastName AS Message
	FROM Employees e
	JOIN Employees m
	ON e.ManagerId = m.EmployeeId

	-- The result is Decart multiplication
	SELECT LastName [Last Name], Name [Department Name]
	FROM Employees
	CROSS JOIN Departments

	-- The commented code below can be used instead of the WHERE clause
	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e 
	INNER JOIN Departments d 
	ON e.DepartmentID = d.DepartmentID -- AND d.Name = 'Sales'
	WHERE d.Name = 'Sales'

	SELECT e.FirstName, e.LastName, d.Name AS DepartmentName
	FROM Employees e
	INNER JOIN Departments d
	ON (e.DepartmentId = d.DepartmentId
		AND e.HireDate > '1/1/1999'
		AND d.Name IN ('Sales', 'Finance'))

INSERT

	-- INSERT values into the columns. They have to match the column type
	INSERT INTO EmployeesProjects
	VALUES ('Sofia', 'Mladost', 1)

	-- INSERT values into selected columns from "Projects" table
	INSERT INTO Projects(Name, StartDate)
	VALUES ('New project', GETDATE())

	-- INSERT the data from the SELECT clause into these columns form the "Projects" table
	INSERT INTO Projects(Name, StartDate)
	SELECT Name + ' Restructuring', GETDATE()
	FROM Departments

	-- Bulk INSERT
	INSERT INTO EmployeesProjects VALUES
	(229, 1),
	(229, 2),
	(229, 3),
	(229, 4),
	(229, 5),
	(229, 55)

UPDATE

	-- UPDATE [table] SET [column] WHERE condition. WHERE IS MANDATORY!!!
	UPDATE Employees
	SET LastName = 'Brown'
	WHERE EmployeeID = 1

	UPDATE Employees
	SET Salary = Salary * 1.10, JobTitle = 'Senior ' + JobTitle
	WHERE DepartmentID = 3

	UPDATE Employees
	SET JobTitle = 'Senior ' + JobTitle
	FROM Employees e 
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

DELETE

	DELETE FROM Employees
	WHERE EmployeeID = 1

	DELETE FROM Employees
	WHERE LastName LIKE 'S%'

	DELETE FROM Employees
	FROM Employees e 
		JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

	-- Delete all rows from a table at once
	TRUNCATE TABLE Users