

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

drop table Brand

select * from Brand
select * from Category