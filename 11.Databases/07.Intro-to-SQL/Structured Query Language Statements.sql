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

	SELECT
	DISTINCT DepartmentID
	FROM Employees

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

	SELECT FirstName, LastName, ManagerID
	FROM Employees
	WHERE ManagerID IN (109, 3, 16)

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

	SELECT LastName, HireDate
	FROM Employees
	ORDER BY HireDate

	SELECT LastName, HireDate
	FROM Employees
	ORDER BY HireDate DESC

	SELECT LastName, Name AS DepartmentName
	FROM Employees, Departments

	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e 
	INNER JOIN Departments d 
    ON e.DepartmentID = d.DepartmentID

	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e, Departments d 
	WHERE e.DepartmentID = d.DepartmentID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM Employees e
	RIGHT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID

	SELECT e.LastName EmpLastName, m.EmployeeID MgrID, m.LastName MgrLastName
	FROM employee e
	FULL OUTER JOIN employee m
	ON e.ManagerID = m.EmployeeID

	SELECT e.FirstName, e.LastName, t.Name AS Towns, a.AddressText
	FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID

	// Self-join
	SELECT e.FirstName + ' ' + e.LastName + ' is managed by ' + m.LastName AS Message
	FROM Employees e
	JOIN Employees m
	ON (e.ManagerId = m.EmployeeId)

	SELECT LastName [Last Name], Name [Dept Name]
	FROM Employees
	CROSS JOIN Departments

	SELECT e.EmployeeID, e.LastName, e.DepartmentID, d.DepartmentID, d.Name AS DepartmentName
	FROM Employees e 
	INNER JOIN Departments d 
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

	SELECT e.FirstName, e.LastName, d.Name AS DeptName
	FROM Employees e
	INNER JOIN Departments d
	ON (e.DepartmentId = d.DepartmentId
		AND e.HireDate > '1/1/1999'
		AND d.Name IN ('Sales', 'Finance'))

INSERT

	INSERT INTO EmployeesProjects VALUES (229, 25)

	INSERT INTO Projects(Name, StartDate)
	VALUES ('New project', GETDATE())

	INSERT INTO Projects(Name, StartDate)
	SELECT Name + ' Restructuring', GETDATE()
	FROM Departments

	// Bulk INSERT
	INSERT INTO EmployeesProjects VALUES
	(229, 1),
	(229, 2),
	(229, 3),
	(229, 4),
	(229, 5),
	(229, 55)

UPDATE

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

	// Delete all rows from a table at once
	TRUNCATE TABLE Users