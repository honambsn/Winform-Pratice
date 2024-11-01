

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
    ProductID INT IDENTITY(1,1),  -- Assuming you want a unique ID for each product
    ProductCode VARCHAR(255) PRIMARY KEY not NULL,
    Barcode VARCHAR(50) NULL,
    Description VARCHAR(max) NULL,
    BrandID VARCHAR(50) NULL,
    CategoryID VARCHAR(50) NULL,
    Price DECIMAL(18, 2) NULL,
    qty INT NULL,
    ReOrder INT NOT NULL
)

ALTER TABLE Product
ALTER COLUMN BrandID INT NULL;

select * from Product

create table Supplier
(
    id int primary key identity(1,1),
	supplierName varchar(255) not null,
    address text not null,
    contact varchar(255) not null,
    phone varchar(255) not null,
    email varchar(255) not null,
    fax varchar(255) not null,
)


CREATE TABLE Users (
    username VARCHAR(255) PRIMARY KEY,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(255) NOT NULL,
    name VARCHAR(255) NOT NULL,
    isactive VARCHAR(50) NOT NULL DEFAULT 'true' -- Default value set to 'true'
);

create table Cart
(
    id int primary key identity(1,1),
    transno varchar(255) null,
    ProductCode varchar(255) null,
    Price decimal(18,2) null,
    qty int null,
    disc_percent decimal(18,2) null default 0,
    disc decimal(18,2) null default 0,
    total decimal(18,2) null,
    sdate date null,
    status varchar(255) null default 'Pending',
    cashier varchar(255) null,
)


INSERT INTO Brand (BrandName) VALUES
('Apple'),
('Samsung'),
('Microsoft'),
('Sony'),
('Google');


INSERT INTO Category (CategoryName) VALUES
('Laptops'),
('Smartphones'),
('Tablets'),
('Accessories'),
('Wearables');


INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder) VALUES
('A123', '123456789', 'Apple MacBook Pro 13-inch', 1, 1, 1299.99, 10, 5),
('A124', '123456790', 'Apple MacBook Pro 15-inch', 1, 1, 1799.99, 10, 5),
('A125', '123456791', 'Apple MacBook Air 13-inch', 1, 1, 999.99, 10, 5),
('S123', '123456792', 'Samsung Galaxy S9', 2, 2, 699.99, 10, 5),
('S124', '123456793', 'Samsung Galaxy S9 Plus', 2, 2, 799.99, 10, 5),
('S125', '123456794', 'Samsung Galaxy Note 9', 2, 2, 999.99, 10, 5),
('M123', '123456795', 'Microsoft Surface Pro 6', 3, 1, 899.99, 10, 5),
('M124', '123456796', 'Microsoft Surface Laptop 2', 3, 1, 999.99, 10, 5),
('M125', '123456797', 'Microsoft Surface Book 2', 3, 1, 1299.99, 10, 5),
('S126', '123456798', 'Sony Xperia XZ3', 4, 2, 799.99, 10, 5),
('S127', '123456799', 'Sony Xperia XZ2', 4, 2, 699.99, 10, 5),
('S128', '123456800', 'Sony Xperia XZ1', 4, 2, 599.99, 10, 5),
('G123', '123456801', 'Google Pixel 3', 5, 2, 799.99, 10, 5),
('G124', '123456802', 'Google Pixel 3 XL', 5, 2, 899.99, 10, 5);

INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder) VALUES
('AP-LT-2023', '0123456789012', 'Apple MacBook Pro 2023', 1, 1, 1999.99, 50, 5),
('SS-GA-2023', '0123456789013', 'Samsung Galaxy S23', 2, 2, 999.99, 100, 10),
('MS-SF-2023', '0123456789014', 'Microsoft Surface Pro 9', 3, 1, 1299.99, 30, 5),
('SO-WH-2023', '0123456789015', 'Sony WH-1000XM5', 4, 4, 349.99, 75, 10),
('GO-FH-2023', '0123456789016', 'Google Pixel Buds A-Series', 5, 4, 99.99, 200, 20);

INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder) VALUES
('A126', '123456780', 'Apple iPad Pro 11-inch', 1, 3, 799.99, 25, 5),
('A127', '123456781', 'Apple AirPods Pro', 1, 4, 249.99, 60, 10),
('A128', '123456782', 'Apple Watch Series 8', 1, 5, 399.99, 40, 7),
('S129', '123456783', 'Samsung Galaxy Tab S8', 2, 3, 699.99, 20, 5),
('S130', '123456784', 'Samsung Galaxy Watch 4', 2, 5, 249.99, 30, 5),
('S131', '123456785', 'Samsung Galaxy Buds 2', 2, 4, 149.99, 50, 10),
('M126', '123456786', 'Microsoft Xbox Series X', 3, 4, 499.99, 15, 3),
('M127', '123456787', 'Microsoft Surface Duo 2', 3, 2, 1399.99, 10, 2),
('M128', '123456788', 'Microsoft Office Home & Student 2021', 3, 4, 149.99, 100, 20),
('S132', '1234567890', 'Sony PlayStation 5', 4, 4, 499.99, 20, 5),
('S133', '1234567891', 'Sony WH-XB910N', 4, 5, 349.99, 30, 5),
('G125', '1234567892', 'Google Nest Hub Max', 5, 4, 229.99, 40, 10),
('G126', '1234567893', 'Google Nest Audio', 5, 4, 99.99, 80, 15);

INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder) VALUES
('AP-IPH-001', '123456830', 'Apple iPhone 14', 1, 2, 999.99, 50, 10),
('AP-IMC-001', '123456831', 'Apple iMac 24-inch', 1, 1, 1299.99, 20, 5),
('AP-TVK-001', '123456832', 'Apple TV 4K', 1, 4, 179.99, 30, 8),
('SM-GZF-001', '123456833', 'Samsung Galaxy Z Flip 4', 2, 2, 999.99, 25, 5),
('SM-STH-001', '123456834', 'Samsung SmartThings Hub', 2, 4, 99.99, 60, 10),
('SM-GWA-001', '123456835', 'Samsung Galaxy Watch Active 2', 2, 5, 249.99, 40, 7),
('MS-SGO-001', '123456836', 'Microsoft Surface Go 3', 3, 1, 399.99, 30, 5),
('MS-XBS-001', '123456837', 'Microsoft Xbox Series S', 3, 4, 299.99, 15, 3),
('MS-SHP-001', '123456838', 'Microsoft Surface Headphones 2', 3, 5, 249.99, 20, 5),
('SO-PSV-001', '123456839', 'Sony PlayStation VR2', 4, 4, 549.99, 12, 2),
('SO-CAM-001', '123456840', 'Sony A7 III Camera', 4, 4, 1999.99, 5, 1),
('GO-CGT-001', '123456841', 'Google Chromecast with Google TV', 5, 4, 49.99, 70, 15),
('GO-NMI-001', '123456842', 'Google Nest Mini', 5, 4, 49.99, 100, 20),
('GO-PSL-001', '123456843', 'Google Pixel Slate', 5, 1, 599.99, 15, 3),
('AP-MKY-001', '123456844', 'Apple Magic Keyboard', 1, 4, 99.99, 50, 10),
('AP-PEN-001', '123456845', 'Apple Pencil (2nd Generation)', 1, 4, 129.99, 40, 5),
('SM-TAB-001', '123456846', 'Samsung Galaxy Tab A7', 2, 3, 229.99, 35, 5),
('MS-HUB-001', '123456847', 'Microsoft Surface Hub 2S', 3, 1, 8999.99, 2, 1),
('SO-PSP-001', '123456848', 'Sony PlayStation Plus Subscription', 4, 4, 59.99, 100, 50),
('GO-NWR-001', '123456849', 'Google Nest Wifi Router', 5, 4, 149.99, 25, 5);

go
create trigger [dbo].[ComputTotal]
on [dbo].[Cart]
after insert, delete, update

as 
begin
set nocount on
update Cart set disc = ((Price * qty) * disc_percent)
update Cart set total = (Price * qty) - disc
end
go


create table StockIn
(
	id int primary key identity(1,1),
	refno varchar(255) null,
	ProductCode varchar(255) null,
	qty int null default 0,
	sdate date null,
	stockinby varchar(255) null,
	status varchar(255) null default 'Pending',
	supplierID varbinary(255) null
)

select * from StockIn

alter table StockIn
alter column supplierID varbinary(255) null

ALTER TABLE StockIn
ADD CONSTRAINT FK_StockIn_Supplier FOREIGN KEY (supplierID)
REFERENCES Supplier(Id);  -- Use the correct column name here


ALTER TABLE StockIn
ADD CONSTRAINT FK_StockIn_Supplier FOREIGN KEY (supplierID)
REFERENCES Supplier(id);



INSERT INTO Supplier (supplierName, address, contact, phone, email, fax)
VALUES 
('Supplier A', '123 Main St, City, Country', 'John Doe', '123-456-7890', 'contact@suppliera.com', '123-456-7891'),
('Supplier B', '456 Elm St, City, Country', 'Jane Smith', '098-765-4321', 'contact@supplierb.com', '098-765-4322'),
('Supplier C', '789 Oak St, City, Country', 'Jim Brown', '555-123-4567', 'contact@supplierc.com', '555-123-4568');

INSERT INTO Supplier (supplierName, address, contact, phone, email, fax)
VALUES 
('Supplier D', '101 Pine St, City, Country', 'Alice Green', '111-222-3333', 'contact@supplierd.com', '111-222-3334'),
('Supplier E', '202 Maple St, City, Country', 'Bob White', '222-333-4444', 'contact@suppliere.com', '222-333-4445'),
('Supplier F', '303 Birch St, City, Country', 'Carol Black', '333-444-5555', 'contact@supplierf.com', '333-444-5556'),
('Supplier G', '404 Cedar St, City, Country', 'Dave Yellow', '444-555-6666', 'contact@supplierg.com', '444-555-6667'),
('Supplier H', '505 Willow St, City, Country', 'Eva Gray', '555-666-7777', 'contact@supplierh.com', '555-666-7778'),
('Supplier I', '606 Spruce St, City, Country', 'Frank Blue', '666-777-8888', 'contact@supplieri.com', '666-777-8889'),
('Supplier J', '707 Fir St, City, Country', 'Gina Pink', '777-888-9999', 'contact@supplierj.com', '777-888-0000'),
('Supplier K', '808 Poplar St, City, Country', 'Hank Purple', '888-999-0000', 'contact@supplierk.com', '888-999-0001'),
('Supplier L', '909 Chestnut St, City, Country', 'Ivy Orange', '999-000-1111', 'contact@supplierl.com', '999-000-1112'),
('Supplier M', '1010 Ash St, City, Country', 'Jack Teal', '000-111-2222', 'contact@supplierm.com', '000-111-2223'),
('Supplier N', '1111 Walnut St, City, Country', 'Karen Brown', '111-222-3333', 'contact@suppliern.com', '111-222-3334'),
('Supplier O', '1212 Maple St, City, Country', 'Leo Silver', '222-333-4444', 'contact@suppliero.com', '222-333-4445'),
('Supplier P', '1313 Oak St, City, Country', 'Mona Gold', '333-444-5555', 'contact@supplierp.com', '333-444-5556'),
('Supplier Q', '1414 Pine St, City, Country', 'Nina Red', '444-555-6666', 'contact@supplierq.com', '444-555-6667'),
('Supplier R', '1515 Birch St, City, Country', 'Oscar White', '555-666-7777', 'contact@supplierr.com', '555-666-7778'),
('Supplier S', '1616 Cedar St, City, Country', 'Paul Black', '666-777-8888', 'contact@suppliers.com', '666-777-8889'),
('Supplier T', '1717 Spruce St, City, Country', 'Quinn Green', '777-888-9999', 'contact@suppliert.com', '777-888-0000'),
('Supplier U', '1818 Fir St, City, Country', 'Rita Blue', '888-999-0000', 'contact@supplieru.com', '888-999-0001'),
('Supplier V', '1919 Poplar St, City, Country', 'Steve Yellow', '999-000-1111', 'contact@supplierv.com', '999-000-1112'),
('Supplier W', '2020 Chestnut St, City, Country', 'Tina Pink', '000-111-2222', 'contact@supplierw.com', '000-111-2223'),
('Supplier X', '2121 Ash St, City, Country', 'Ursula Purple', '111-222-3333', 'contact@supplierx.com', '111-222-3334');

select * from Supplier

ALTER TABLE StockIn
ADD CONSTRAINT FK_StockIn_Supplier FOREIGN KEY (supplierID) REFERENCES Supplier(id);

ALTER TABLE StockIn
ADD CONSTRAINT FK_StockIn_Product FOREIGN KEY (ProductCode) REFERENCES Product(ProductCode);

DROP TABLE IF EXISTS StockIn;
DROP TABLE IF EXISTS Product;

select * from StockIn
select * from Product


-- Insert a product
INSERT INTO Product (ProductCode, Barcode, Description, BrandID, CategoryID, Price, qty, ReOrder)
VALUES ('test', '123456789', 'Product A Description', 1, 1, 1299.99, 100, 5);

-- Insert stock in data referencing the product
INSERT INTO StockIn (refno, ProductCode, qty, sdate, stockinby, status, supplierID)
VALUES ('REF001', 'test', 5, '2024-10-01', 'Alice', 'Pending', NULL);




SELECT DISTINCT ProductCode
FROM StockIn
WHERE ProductCode IS NOT NULL
AND ProductCode NOT IN (SELECT ProductCode FROM Product);


select * from StockIn

select * from Product


ALTER TABLE Product
ADD CONSTRAINT FK_Product_Brand FOREIGN KEY (BrandID) REFERENCES Brand(id);


ALTER TABLE Cart
ADD CONSTRAINT FK_Cart_Product FOREIGN KEY (ProductCode) REFERENCES Product(ProductCode);


select * from StockIn

select * from Product


create table test
(
    id int
)

insert into test values (1)


select * from Product

SELECT 
    CONSTRAINT_NAME, 
    TABLE_NAME 
FROM 
    INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
WHERE 
    CONSTRAINT_TYPE = 'FOREIGN KEY';


select * from StockIn

select * from Product


SELECT * FROM StockIn 
WHERE refno LIKE 'REF001'
AND status = 'Pending';


INSERT INTO StockIn (refno, ProductCode, qty, sdate, stockinby, status, supplierID)
VALUES 
('REF002', 'A123', 1, '2024-10-01', 'Alice', 'Pending', NULL),
('REF003', 'A124', 2, '2024-10-02', 'Bob', 'Pending', NULL),
('REF004', 'A125', 3, '2024-10-03', 'Charlie', 'Pending', NULL),
('REF005', 'A126', 4, '2024-10-04', 'Diana', 'Pending', NULL),
('REF006', 'A127', 5, '2024-10-05', 'Ethan', 'Pending', NULL),
('REF007', 'A128', 6, '2024-10-06', 'Fiona', 'Pending', NULL),
('REF008', 'A123', 7, '2024-10-07', 'George', 'Pending', NULL),
('REF009', 'A124', 8, '2024-10-08', 'Hannah', 'Pending', NULL),
('REF010', 'A125', 9, '2024-10-09', 'Ian', 'Pending', NULL),
('REF011', 'A126', 10, '2024-10-10', 'Jack', 'Pending', NULL),
('REF012', 'A127', 11, '2024-10-11', 'Kathy', 'Pending', NULL),
('REF013', 'A128', 12, '2024-10-12', 'Liam', 'Pending', NULL),
('REF014', 'A123', 13, '2024-10-13', 'Mia', 'Pending', NULL),
('REF015', 'A124', 14, '2024-10-14', 'Noah', 'Pending', NULL),
('REF016', 'A125', 15, '2024-10-15', 'Olivia', 'Pending', NULL),
('REF017', 'A126', 16, '2024-10-16', 'Peter', 'Pending', NULL),
('REF018', 'A127', 17, '2024-10-17', 'Quinn', 'Pending', NULL),
('REF019', 'A128', 18, '2024-10-18', 'Ryan', 'Pending', NULL),
('REF020', 'A123', 19, '2024-10-19', 'Sophia', 'Pending', NULL),
('REF021', 'A124', 20, '2024-10-20', 'Thomas', 'Pending', NULL);


select * from vwStockIn


select * from Supplier