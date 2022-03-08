create database CartellDatabase;

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

create table Reservations (
	Id int identity (1,1) primary key not null,
	Reservation_Number nvarchar(50) unique not null,
	Reservation_Date date not null,
	Customer_Id int not null,
	Barber_Id int,
	foreign key (Customer_Id) references Customers(Id),
	foreign key (Barber_Id) references Barbers(Id)
);

create table Prices (
	Id int identity (1,1) primary key not null,
	Price float not null,
	Active_Date date not null,
);

create table Services (
	Id int identity(1,1) primary key not null,
	Service_Name nvarchar(50) unique not null,
	Description nvarchar(200),
	Price_Id int,
	foreign key (Price_Id) references Prices(Id)
);

create table Reservation_Service (
	Reservation_Id int not null,
	Service_Id int not null,
	primary key (Reservation_Id, Service_Id),
	foreign key(Reservation_Id) references Reservations(Id),
	foreign key(Service_Id) references Services(Id)
);