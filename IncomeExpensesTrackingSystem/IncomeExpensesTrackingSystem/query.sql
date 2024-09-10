create table users(
	id int primary key  identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	date date null
)


select * from users
truncate table users

create table categories(
	id int primary key identity(1,1),
	category varchar(max) null,
	type varchar(max) null,
	status varchar(max) null,
	date date null
)

select * from categories
truncate table categories

create table income(
	id int primary key identity(1,1),
	category varchar(max) null,
	item varchar(max) null,
	income float null,
	description text null,
	date_income date null,
	date_insert date null
)

select * from income

create table expenses(
	id int primary key identity(1,1),
	category varchar(max) null,
	item varchar(max) null,
	cost float null,
	description varchar(max) null,
	date_expense date null,
	date_insert date null
)

select * from expenses

truncate table income
truncate table expenses