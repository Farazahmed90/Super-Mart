create database inbasemgm;
create table users
(
u_id int primary key identity(1,1),
pw varchar(25),
name varchar(25),
DOJ date
);
create table products
(
pid int primary key identity(0,1),
batch int,
name varchar(25),
price float
);
--DML languages
select * from users; -- read the data
insert into users(pw,name,DOJ) values ('123abc','Ali','2017-12-03');
insert into users(pw,name,DOJ) values ('456def','faraz','2017-11-03');
insert into users(pw,name,DOJ) values ('789ghi','Imran','2016-11-03');
insert into users(pw,name,DOJ) values ('123','Faraz','2016-11-03');

insert into products (batch,name,price)values(2017,'HP Laptops',3000.29);
insert into products (batch,name,price)values(2018,'DELL Laptops',3100.29);
insert into products (batch,name,price)values(2017,'HP Laptops',3000.29);
select * from products;

--select where, and, or
select * from products where pid=2;
select * from products where pid>2;
select * from products where pid>2 and name='HP Laptops';
select price,pid from products where pid=2 and name='HP Laptops';
--select avg, max
select AVG(price) as avg_price from products;
select max(price) as avg_price from products;
--update
update products set price=50000 where name='HP Laptops';
update products set name='Toshiba' where pid=4;
--delete
delete from products where pid=3;
delete from products;