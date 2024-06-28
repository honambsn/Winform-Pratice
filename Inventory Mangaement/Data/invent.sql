create table users
(
	id int  primary key identity(1,1),
	username varchar(max) null,
	password varchar(max) null,
	role varchar(max) null,
	status varchar(max) null,
	date date null
)
