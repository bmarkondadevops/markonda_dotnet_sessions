
-- This is a comment
/* 
 Creating a product table

*/

/* DDL */
Create table Product(
  id int primary key identity(1,1),
  name varchar(100),
  quantity int,
  price money
)
-- DQL
select * from product
-- DML
insert into Product(name,quantity,price)
           values('Mobile',10,1000);

insert into Product(name,quantity,price)
values('Laptop',5,50000);

insert into Product(name,quantity,price)
           values('Tablet',1,15000);

-- update
declare @newQuanity int
set @newQuanity=20

update product
set quantity = @newQuanity
where id =3

select * from Product 
where name='Tablet'

delete product where id=3

-- This is a comment
/* 
 Creating a product table

*/

/* DDL */
Create table Product(
  id int primary key identity(1,1),
  name varchar(100),
  quantity int,
  price money
)
-- DQL
select * from product
-- DML
insert into Product(name,quantity,price)
           values('Mobile',10,1000);

insert into Product(name,quantity,price)
values('Laptop',5,50000);

insert into Product(name,quantity,price)
           values('Tablet',1,15000);

-- update
declare @newQuanity int
set @newQuanity=20

update product
set quantity = @newQuanity
where id =3

select * from Product 
where name='Tablet'

delete product where id=3

select * from product where quantity = 1001 or quantity=1

select * from product where id=10001 or 0<1
select * from product where id = 3
go

select * from product where id = 4
go

select * from product where id = 12345 or 1=1
go

select * from product where name='abc' and quantity=1001 or 1=1

exec sp_executesql N'select * from product where id = @paramProductId',N'@paramProductId nvarchar(1)',@paramProductId=N'2'
go

sp_helptext 'sp_executesql'


/* Relationsal DB--> relationship */
/* Customer and Order */

create table customer(
id int primary key identity(1,1),
name varchar(20) not null ,
location varchar(50)  ,

)

create table [order](
id int primary key identity(1,1),
title varchar(20) not null,
cost money not null,
customer_id int references customer(id) -- belongs to
)

select * from customer where id=1
insert into customer (name,location) values('Makonda','Chennai');
insert into [order] (title,cost,customer_id) values ('books po',1000,1);




