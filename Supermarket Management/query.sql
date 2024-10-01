create database POS
go
use POS
go

create table Brand(
	BrandID int primary key identity(1,1),
	BrandName nvarchar(50) not null
)

create table test
(
	test int
)

insert into test values(1)

select * from Brand
select * from test

insert into Brand (BrandName) values ('Brand2');