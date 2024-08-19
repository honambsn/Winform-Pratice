create table users
(
	id int  primary key identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	role varchar(max) null,
	status varchar(max) null,
	date date null
)



create table categories
(
	id int primary key identity(1,1),
	category varchar(max) null,
	date DATE null
)

create table products
(
	id int primary key identity(1,1),
	prod_id varchar(max) null,
	prod_name varchar(max) null,
	category varchar(max) null,
	price float null,
	stock int null,
	image_path varchar(max) null,
	status varchar(max) null,
	insert_date date null
)

create table test
(
	id int primary key identity(1,1),
	val varchar(max) null
)

create table orders
(
	id int primary key identity(1,1),
	prod_id varchar(max) null,
	prod_name varchar(max) null,
	category varchar(max) null,
	qty int null,
	orig_price float null,
	total_price float null,
	order_date date null
)

create table customers
(
	id int primary key identity(1,1),
	customer_id int null,
	prod_id varchar(max) null,
	total_price float null,
	amount float null,
	change float null,
	order_date date null
)
ALTER TABLE customers
ADD order_code varchar(max) null

select * from products
select * from users
select * from categories
select * from orders
select * from customers

alter table orders
add customer_id int null

TRUNCATE TABLE users;

INSERT INTO users VALUES('aa', '1', 'Admin','Active', '2024-08-02');
insert into categories values ('cate4','')

INSERT INTO categories (category, date)
VALUES ('Electronics', '2023-01-01');

INSERT INTO categories (category, date)
VALUES ('Accessories', '2023-01-04');

INSERT INTO categories (category, date)
VALUES ('Storage', '2023-01-11');

INSERT INTO categories (category, date)
VALUES ('Home Appliances', '2023-01-02');

INSERT INTO categories (category, date)
VALUES ('Furniture', '2023-01-03');

INSERT INTO categories (category, date)
VALUES ('Toys', '2023-01-04');

INSERT INTO categories (category, date)
VALUES ('Books', '2023-01-05');


INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P001', 'Laptop', 'Electronics', 999.99, 50, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-01');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P002', 'Smartphone', 'Electronics', 699.99, 150, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-02');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P003', 'Tablet', 'Electronics', 399.99, 80, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-03');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P004', 'Headphones', 'Accessories', 49.99, 200, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-04');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P005', 'Smartwatch', 'Accessories', 199.99, 70, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-05');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P006', 'Monitor', 'Electronics', 299.99, 60, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-06');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P007', 'Keyboard', 'Accessories', 29.99, 120, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-07');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P008', 'Mouse', 'Accessories', 19.99, 180, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-08');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P009', 'Printer', 'Electronics', 149.99, 40, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-09');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P010', 'Router', 'Electronics', 99.99, 90, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-10');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P011', 'External Hard Drive', 'Storage', 89.99, 100, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-11');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P012', 'USB Flash Drive', 'Storage', 19.99, 250, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-12');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P013', 'Camera', 'Electronics', 499.99, 30, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-13');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P014', 'Microphone', 'Accessories', 79.99, 80, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-14');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P015', 'Speaker', 'Accessories', 59.99, 110, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-15');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P016', 'Projector', 'Electronics', 399.99, 25, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-16');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P017', 'Gaming Console', 'Electronics', 299.99, 45, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-17');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P018', 'VR Headset', 'Accessories', 349.99, 35, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-18');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P019', 'Smart Glasses', 'Accessories', 249.99, 20, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-19');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date)
VALUES ('P020', 'Smart Home Hub', 'Electronics', 129.99, 55, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2023-01-20');

INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P001', 'Product 1', 'Home Appliances', 99.99, 10, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P002', 'Product 2', 'Furniture', 199.99, 5, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P003', 'Product 3', 'Toys', 29.99, 15, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P004', 'Product 4', 'Books', 15.99, 20, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P005', 'Product 5', 'Home Appliances', 79.99, 8, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P006', 'Product 6', 'Furniture', 249.99, 3, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P007', 'Product 7', 'Toys', 49.99, 12, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P008', 'Product 8', 'Books', 9.99, 30, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P009', 'Product 9', 'Home Appliances', 129.99, 7, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P010', 'Product 10', 'Furniture', 299.99, 2, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P011', 'Product 11', 'Toys', 19.99, 25, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P012', 'Product 12', 'Books', 12.99, 18, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P013', 'Product 13', 'Home Appliances', 89.99, 11, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P014', 'Product 14', 'Furniture', 179.99, 6, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P015', 'Product 15', 'Toys', 39.99, 14, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P016', 'Product 16', 'Books', 17.99, 22, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P017', 'Product 17', 'Home Appliances', 149.99, 4, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P018', 'Product 18', 'Furniture', 209.99, 3, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P019', 'Product 19', 'Toys', 59.99, 9, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');
INSERT INTO products (prod_id, prod_name, category, price, stock, image_path, status, insert_date) VALUES ('P020', 'Product 20', 'Books', 13.99, 16, 'D:\Ba Nam\Own project\Practice\c#\Winform Pratice\Inventory Mangaement\bin\Debug\Product_Directory\1.jpg', 'Available', '2024-08-01');


UPDATE products SET prod_name = 'Blender' WHERE prod_id = 'P001';
UPDATE products SET prod_name = 'Sofa' WHERE prod_id = 'P002';
UPDATE products SET prod_name = 'Lego Set' WHERE prod_id = 'P003';
UPDATE products SET prod_name = 'Harry Potter Book' WHERE prod_id = 'P004';
UPDATE products SET prod_name = 'Microwave' WHERE prod_id = 'P005';
UPDATE products SET prod_name = 'Dining Table' WHERE prod_id = 'P006';
UPDATE products SET prod_name = 'Action Figure' WHERE prod_id = 'P007';
UPDATE products SET prod_name = 'Cookbook' WHERE prod_id = 'P008';
UPDATE products SET prod_name = 'Toaster' WHERE prod_id = 'P009';
UPDATE products SET prod_name = 'Bookshelf' WHERE prod_id = 'P010';
UPDATE products SET prod_name = 'Toy Car' WHERE prod_id = 'P011';
UPDATE products SET prod_name = 'Science Book' WHERE prod_id = 'P012';
UPDATE products SET prod_name = 'Air Conditioner' WHERE prod_id = 'P013';
UPDATE products SET prod_name = 'Coffee Table' WHERE prod_id = 'P014';
UPDATE products SET prod_name = 'Dollhouse' WHERE prod_id = 'P015';
UPDATE products SET prod_name = 'Mystery Novel' WHERE prod_id = 'P016';
UPDATE products SET prod_name = 'Vacuum Cleaner' WHERE prod_id = 'P017';
UPDATE products SET prod_name = 'Office Chair' WHERE prod_id = 'P018';
UPDATE products SET prod_name = 'Puzzle Set' WHERE prod_id = 'P019';
UPDATE products SET prod_name = 'Historical Book' WHERE prod_id = 'P020';


UPDATE products SET stock = 25 WHERE prod_id = 'P001';
UPDATE products SET stock = 22 WHERE prod_id = 'P002';
UPDATE products SET stock = 28 WHERE prod_id = 'P003';
UPDATE products SET stock = 30 WHERE prod_id = 'P004';
UPDATE products SET stock = 24 WHERE prod_id = 'P005';
UPDATE products SET stock = 27 WHERE prod_id = 'P006';
UPDATE products SET stock = 26 WHERE prod_id = 'P007';
UPDATE products SET stock = 23 WHERE prod_id = 'P008';
UPDATE products SET stock = 29 WHERE prod_id = 'P009';
UPDATE products SET stock = 31 WHERE prod_id = 'P010';
UPDATE products SET stock = 32 WHERE prod_id = 'P011';
UPDATE products SET stock = 33 WHERE prod_id = 'P012';
UPDATE products SET stock = 34 WHERE prod_id = 'P013';
UPDATE products SET stock = 35 WHERE prod_id = 'P014';
UPDATE products SET stock = 36 WHERE prod_id = 'P015';
UPDATE products SET stock = 37 WHERE prod_id = 'P016';
UPDATE products SET stock = 38 WHERE prod_id = 'P017';
UPDATE products SET stock = 39 WHERE prod_id = 'P018';
UPDATE products SET stock = 40 WHERE prod_id = 'P019';
UPDATE products SET stock = 41 WHERE prod_id = 'P020';

update products set stock = 100 where prod_id = '2';
update products set stock = 100 where prod_id = '1';
update products set stock = 100 where prod_id = '4';
update products set stock = 100 where prod_id = '5';

update products set price = 1000 where prod_id = '2';
update products set price = 1000 where prod_id = '1';
update products set price = 1000 where prod_id = '4';
update products set price = 1000 where prod_id = '5';

select * from products

delete from orders where id =2
delete from orders where id =3
delete from orders where id =6



ALTER TABLE orders
ADD status VARCHAR(10);

ALTER TABLE orders
ADD CONSTRAINT DF_orders_status DEFAULT 'pending' FOR status;

UPDATE orders
SET status = 'paid' where id =1

select * from orders

truncate table orders
select * from customers
select count(id) from customers
select * from users