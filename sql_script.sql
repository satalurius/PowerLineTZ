CREATE TABLE IF NOT EXISTS Customers (
	id INTEGER NOT NULL PRIMARY KEY,
	name VARCHAR(70) NOT NULL
);

CREATE TABLE IF NOT EXISTS Orders (
	id INTEGER NOT NULL PRIMARY KEY,
	customer_id INTEGER NOT NULL REFERENCES Customers (id)
);

INSERT INTO Customers VALUES
(1, 'Max'),
(2, 'Pavel'),
(3, 'Ivan'),
(4, 'Leonid');

INSERT INTO Orders VALUES 
(1, 2),
(2, 4);

SELECT name as Customers
FROM Customers
WHERE id NOT IN (SELECT customer_id FROM Orders)




