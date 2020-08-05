USE master
IF EXISTS(select * from sys.databases where name='Airplanes')
DROP DATABASE Airplanes;

CREATE DATABASE Airplanes;

use Airplanes;

Create Table Countrys (
	Id int NOT NULL primary key identity(0, 1),
	Name Varchar(100) not null
);

Create Table Airlines (
	Id int not null primary key identity(0, 1),
	Name varchar(100) not null
);

Create Table Airports (
	Id int not null primary key identity(0, 1),
	Name varchar(100) not null,
	IATA varchar(4) not null,
	CountryId int not null
	foreign key(CountryId) references Countrys(Id)
);

Create Table Airplanes (
	Id int not null primary key identity(0, 1),
	OwnedById int not null,
	CurrentAirportId int,
	NextDestinationId int
	foreign key(OwnedById) references Airlines(Id),
	foreign key(CurrentAirportId) references Airports(Id),
	foreign key(NextDestinationId) references Airports(Id)
);

insert into Countrys (Name) VALUES
('Denmark'),
('Greenland'),
('USA'),
('Norway');

insert into Airlines (Name) VALUES
('Air China'),
('SAS'),
('Delta'),
('Nok Air');

insert into Airports (Name, IATA, CountryId) VALUES
('Copenhagen Aiport', 'CPH', 0),
('Qaanaaq', 'NAQ', 1),
('Bermuda Dunes Airport', 'UUD', 2),
('Notodden Airport', 'NTB', 3);

insert into Airplanes (OwnedById, CurrentAirportId, NextDestinationId) Values
(1, 0, 1),
(1, 1, 2),
(2, 0, 2),
(3, 2, 1),
(3, 0, 2),
(2, 2, 1),
(1, 3, 2),
(1, 2, 3),
(2, 3, 2),
(3, 3, 1);