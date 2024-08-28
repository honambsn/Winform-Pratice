create table users(
	id int primary key  identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	date date null
)


select * from users
truncate table users