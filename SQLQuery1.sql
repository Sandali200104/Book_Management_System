create table tblUsers (Id int IDENTITY(1,1) PRIMARY KEY, UserName varchar(255), Password varchar(255));

select * from tblUsers;

create table tblCustomers (Id int IDENTITY(1,1) PRIMARY KEY, FirstName varchar(255), LastName varchar(255), Gender varchar(255), Address varchar(255));

select * from tblCustomers;
Select FirstName,LastName,Gender,Address From tblCustomers Where Id = 1;

create table tblBooks (Id int IDENTITY(1,1) PRIMARY KEY, BookName varchar(255), BookType varchar(255));

create table tblIssuedBooks (Id int IDENTITY(1,1) PRIMARY KEY, BookType varchar(255), BookName varchar(255),
IssuedDate datetime, CustomerId int, foreign key(CustomerId) references tblCustomers(Id));

