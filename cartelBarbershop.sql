--create database CartellDatabase;

create table Customers (
	Id int identity (1,1) primary key not null,
	First_Name nvarchar(50) not null,
	Last_Name nvarchar(50) not null,
	Phone_Number nvarchar(50) unique not null,
);

create table Barbers (
	Id int identity (1,1) primary key not null,
	Nickname nvarchar(50) unique not null
);

create table Services (
	Id int identity(1,1) primary key not null,
	Service_Name nvarchar(50) unique not null,
	Description nvarchar(200),
	Price float not null
);

create table Reservations (
	Id int identity (1,1) primary key not null,
	Reservation_Number nvarchar(50) unique not null,
	Reservation_Date date not null,
	Customer_Id int not null,
	Barber_Id int,
	Service_Id int,
	foreign key (Customer_Id) references Customers(Id),
	foreign key (Barber_Id) references Barbers(Id),
	foreign key (Service_Id) references Services(Id)
);
