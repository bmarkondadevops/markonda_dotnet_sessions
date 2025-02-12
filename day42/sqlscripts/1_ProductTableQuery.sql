
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



