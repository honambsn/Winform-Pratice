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