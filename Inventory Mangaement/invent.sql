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

select * from products
select * from test
select * from users
select * from categories

TRUNCATE TABLE users;

INSERT INTO users VALUES('aa', '1', 'Admin','Active', '2024-08-02');
insert into categories values ('cate4','')
