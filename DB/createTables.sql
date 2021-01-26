/* Create database */
CREATE DATABASE Waitlistme;
GO

/* Create tables */
CREATE TABLE PartyStatus (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name nvarchar(50) NOT NULL
);

CREATE TABLE PartyTableLog (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    partyId int NOT NULL,
    tableId int NOT NULL,
    tableStatusId int NOT NULL,
    actionMsg nvarchar(50) NULL,
    dateCreated DATE NOT NULL
);

/* Create tables */
CREATE TABLE PartyType (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name nvarchar(50) NOT NULL
);

CREATE TABLE TableStatus (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name nvarchar(50) NOT NULL
);

CREATE TABLE FloorTable (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name nvarchar(50) NOT NULL,
    tableStatusId int NOT NULL,
    partyId int NOT NULL,
    capacity int NULL,
    dateCreated DATE NOT NULL
);

CREATE TABLE Party (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    firstName nvarchar(50)  NULL,
    lastName nvarchar(50)  NULL,
    emailAddress nvarchar(50)  NULL,
    phoneNumber nvarchar(50) NULL,
    quoteTime int NULL,
    partyTypeid int NOT NULL,
    partySize int NULL,
    floorTableId int NOT NULL,
    partyStatusId int NOT NULL,
    reservationTime DATE NULL,
    reservationConfirmed BIT NULL,
    dateCreated DATE NOT NULL
);

