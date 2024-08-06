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
