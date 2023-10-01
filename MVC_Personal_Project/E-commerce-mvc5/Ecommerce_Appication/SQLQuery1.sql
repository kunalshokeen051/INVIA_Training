create Database DbeMarketing

use DbeMarketing

create table tbl_admin(
ad_id int identity primary key,
ad_username nvarchar(50) not null unique,
ad_password nvarchar(50) not null,
)

insert into tbl_admin values
('root','admin123'),
('admin','admin123'),
('kunalshokeen99','admin123')

select * from tbl_admin
-------------------------------------------

create table tbl_category
(
cat_id int identity primary key,
cat_name nvarchar(50) not null unique,
cat_image nvarchar(max) not null,
cat_fk_ad int foreign key references tbl_admin(ad_id)
)

ALTER TABLE tbl_category
ADD cat_status int not null

select * from tbl_category
--------------------------------------------

create table tbl_user
(
u_id int identity primary key,
u_name nvarchar(50) not null,
u_email nvarchar(50) not null unique,
u_passowrd nvarchar(50) not null,
u_image nvarchar(max) not null,
u_contact nvarchar(50) not null unique
)

----------------------------------------

create table tbl_product
(
pro_id int identity primary key,
pro_name nvarchar(50) not null unique,
pro_image nvarchar(max) not null,
pro_des nvarchar(max) not null,
pro_price int,
pro_fk_user int foreign key references tbl_user(u_id),
pro_fk_cat int foreign key references tbl_category(cat_id)
)

ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Department] FOREIGN KEY([DepartmentId])REFERENCES [dbo].[Department] ([DepartmentId])ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Department]