create table Users(
	u_id int primary key ,
	u_first_name varchar(50) not null,
	u_sur_name varchar(50) not null,
	u_email varchar(100) not null,
)
create table Products(
	p_id int primary key ,
	p_name varchar(50) not null,
	p_description varchar(1000) not null,
	p_company_name varchar(50) not null,
	p_price decimal(18,2) not null,
)
create table Reviews(
	r_id int primary key  not null,
	r_description varchar(50) not null,
	r_grade decimal(3,1) not null,
	r_p_id int not null, 
	r_u_id int not null,
	foreign key(r_p_id) references Products(p_id),
	foreign key(r_u_id) references Users(u_id),
	constraint r_un unique(r_p_id,r_u_id),
)
create table Categories(
	c_id int primary key ,
	c_name varchar(50),
)
create table ProductsCategories(
	pc_id int primary key ,
	pc_p_id int not null,
	pc_c_id int not null,
	foreign key(pc_p_id) references Products(p_id),
	foreign key(pc_c_id) references Categories(c_id),
)

insert into Users (u_id,u_first_name,u_sur_name,u_email) values
															(1,'Ermin','Roman','romanermin@gmail.com'),
															(2,'Clarke', 'Haley','clarkehaley@gmail.com'),
															(3,'Arnold', 'Wilkins','a_wilkins23@gmail.com'),
															(4,'Cynthia', 'Buchanan','cynthiabuchanan@yahoo.com'),
															(5,'Kira', 'Bowden','kirri_bow234@gmail.com'),
															(6,'Cody', 'Reynolds','coddy_y348@yahoo.com'),
															(7,'Jennifer', 'Teagan','jennifer_teagan@icloud.com'),
															(8,'Brad', 'Sullivan','b_sullivan3654@yahoo.com'),
															(9,'Jared', 'Lawrence','lawrence.jared@gmail.com'),
															(10,'Mary', 'Hansen','mary_hansenyahoo.com')
insert into Products(p_id,p_name,p_company_name,p_description,p_price) values 
																						(1,'Asus Rog Laptop','Asus','dasdas',999.99),
																						(2,'LG TV-999','LG','asdas',529.99),
																						(3,'Samsung TV-32','Samsung','dasdas',629.99),
																						(4,'Samsung TV-42','Samsung','dasdasdas',719.99),
																						(5,'LG Laptop','LG','dasdasa',899.99),
																						(6,' McBook','Macintosh','dasdasdasdas',1999.99),
																						(7,'Samsung Smart Fridge','Samsung','dasdafasdasfas',899.99),
																						(8,'Philips Smart Firdge','Philips','dasfasfasd',899.99),
																						(9,'T-Shirt Guess','Guess','dsafasdsafa',49.99),
																						(10,'Dress Guess','Guess','gadsfa',99.99)
insert into Reviews(r_id,r_description,r_grade,r_p_id,r_u_id) values 
																	(1,'aa',9.2,1,1),
																	(2,'bb',8.3,2,1),
																	(3,'cc',9.5,3,1),
																	(4,'dd',9.3,3,2),
																	(5,'ee',7.6,5,3),
																	(6,'ff',5.5,5,2),
																	(7,'gg',9.3,6,5),
																	(8,'hh',9.4,6,3),
																	(9,'ii',9.6,1,4),
																	(10,'jj',10,1,7)
insert into Categories(c_id,c_name) values
										(1,'Electronics'),
										(2,'Laptops'),
										(3,'TVs'),
										(4,'Fridges'),
										(5,'Appliances'),
										(6,'Big Electronics'),
										(7,'Portable Electronics'),
										(8,'Clothes'),
										(9,'T-Shirts'),
										(10,'Dresses')

insert into ProductsCategories(pc_id,pc_p_id,pc_c_id) values
															(1,1,1),
															(2,1,2),
															(3,2,1),
															(4,2,3),
															(5,3,1),
															(6,3,3),
															(7,4,1),
															(8,4,3),
															(9,5,1),
															(10,5,2),
															(11,6,1),
															(12,6,2),
															(13,7,5),
															(14,7,4),
															(15,8,5),
															(16,8,4),
															(17,9,8),
															(18,9,9),
															(19,10,10),
															(20,10,8)

select cast(sum(p_price)/count(*)as decimal(18,2)) as AvreageLaptopPrice from Products join ProductsCategories on p_id=pc_p_id join Categories on c_id=pc_c_id where c_name='Laptops';
select cast(AVG(p_price) as decimal(18,2)) as AvreageLaptopPrice from Products join ProductsCategories on p_id=pc_p_id join Categories on c_id=pc_c_id where c_name='Laptops';
select p_name,c_name from Products join ProductsCategories on p_id=pc_p_id join Categories on c_id=pc_c_id order by c_name,p_name;
select c_name,count(*) as Number_of_Appliances from Products join ProductsCategories on p_id=pc_p_id join Categories on c_id=pc_c_id group by c_name having c_name='Appliances';
select concat(u_first_name,' ',u_sur_name) as FullName from Users;
select u_first_name,r_grade,p_name from Users full join Reviews on u_id=r_u_id full join Products on p_id=r_p_id;
select u_first_name,r_grade from Users right join Reviews on u_id=r_u_id;
select cast(sum(p_price) as decimal(18,2)) as SamsungProductPrice from Products where p_name like 'Samsung%';
select cast(avg(p_price) as decimal(18,2)) as GuessPrice from Products where p_company_name='GUESS';
select u_first_name from Users where u_email  not like '%@%.%';

begin try
    begin transaction

    update Users
    set u_first_name = 'Alex'
    where u_first_name like 'Ermin'

    update Products
    set p_description = 'Ermin'
    where p_id =2 

    update Reviews
    set r_grade = 5
    where r_p_id = 2

    delete from Products 
    where p_id = 1

    delete from Reviews
    where r_id = 1000

    commit transaction
end try

begin catch
rollback transaction
end catch