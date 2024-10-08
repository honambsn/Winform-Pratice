

create table Brand
(
	id int primary key identity(1,1),
	BrandName varchar(255) not null
)

create table Category
(
	id int primary key identity(1,1),
	CategoryName varchar(255) not null
)

CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY(1,1),  -- Assuming you want a unique ID for each product
    ProductCode NVARCHAR(50) NOT NULL,
    Barcode NVARCHAR(50) NOT NULL,
    Description NVARCHAR(max) NULL,
    BrandID INT NOT NULL,
    CategoryID INT NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    qty INT NULL,
    ReOrder INT NOT NULL
)


drop table Brand
drop table Product
select * from Brand
select * from Category
select * from Product
INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder)
VALUES 
    ('P001', '1234567890123', 'Sample Product 1', 1, 2, 19.99, 100, 5),
    ('P002', '1234567890124', 'Sample Product 2', 1, 2, 29.99, 200, 10),
    ('P003', '1234567890125', 'Sample Product 3', 2, 3, 39.99, 150, 8);

INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder)
VALUES 
    ('P004', '1234567890126', 'Sample Product 4', 1, 2, 25.99, 50, 3),
    ('P005', '1234567890127', 'Sample Product 5', 2, 3, 15.99, 75, 5),
    ('P006', '1234567890128', 'Sample Product 6', 1, 1, 45.50, 120, 10),
    ('P007', '1234567890129', 'Sample Product 7', 3, 2, 30.00, 90, 7),
    ('P008', '1234567890130', 'Sample Product 8', 2, 3, 12.99, 110, 6),
    ('P009', '1234567890131', 'Sample Product 9', 1, 1, 22.50, 130, 4),
    ('P010', '1234567890132', 'Sample Product 10', 3, 2, 35.99, 80, 8),
    ('P011', '1234567890133', 'Sample Product 11', 1, 3, 40.00, 200, 15),
    ('P012', '1234567890134', 'Sample Product 12', 2, 1, 27.49, 60, 5),
    ('P013', '1234567890135', 'Sample Product 13', 3, 2, 50.00, 140, 12);



