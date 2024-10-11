

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
    ProductCode VARCHAR(50) NOT NULL,
    Barcode VARCHAR(50) NOT NULL,
    Description VARCHAR(max) NULL,
    BrandID VARCHAR(50) NOT NULL,
    CategoryID VARCHAR(50) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    qty INT NULL,
    ReOrder INT NOT NULL
)


drop table Brand

drop table Category

drop table Product

select * from Brand

select * from Category

select * from Product


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
('A124', '123456789', 'Apple MacBook Pro 15-inch', 1, 1, 1799.99, 10, 5),
('A125', '123456789', 'Apple MacBook Air 13-inch', 1, 1, 999.99, 10, 5),
('S123', '123456789', 'Samsung Galaxy S9', 2, 2, 699.99, 10, 5),
('S124', '123456789', 'Samsung Galaxy S9 Plus', 2, 2, 799.99, 10, 5),
('S125', '123456789', 'Samsung Galaxy Note 9', 2, 2, 999.99, 10, 5),
('M123', '123456789', 'Microsoft Surface Pro 6', 3, 1, 899.99, 10, 5),
('M124', '123456789', 'Microsoft Surface Laptop 2', 3, 1, 999.99, 10, 5),
('M125', '123456789', 'Microsoft Surface Book 2', 3, 1, 1299.99, 10, 5),
('S123', '123456789', 'Sony Xperia XZ3', 4, 2, 799.99, 10, 5),
('S124', '123456789', 'Sony Xperia XZ2', 4, 2, 699.99, 10, 5),
('S125', '123456789', 'Sony Xperia XZ1', 4, 2, 599.99, 10, 5),
('G123', '123456789', 'Google Pixel 3', 5, 2, 799.99, 10, 5),
('G124', '123456789', 'Google Pixel 3 XL', 5, 2, 899.99, 10, 5);


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
('S126', '123456783', 'Samsung Galaxy Tab S8', 2, 3, 699.99, 20, 5),
('S127', '123456784', 'Samsung Galaxy Watch 4', 2, 5, 249.99, 30, 5),
('S128', '123456785', 'Samsung Galaxy Buds 2', 2, 4, 149.99, 50, 10),
('M126', '123456786', 'Microsoft Xbox Series X', 3, 4, 499.99, 15, 3),
('M127', '123456787', 'Microsoft Surface Duo 2', 3, 2, 1399.99, 10, 2),
('M128', '123456788', 'Microsoft Office Home & Student 2021', 3, 4, 149.99, 100, 20),
('S126', '1234567890', 'Sony PlayStation 5', 4, 4, 499.99, 20, 5),
('S127', '1234567891', 'Sony WH-XB910N', 4, 5, 349.99, 30, 5),
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


