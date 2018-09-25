CREATE DATABASE [Library];

USE [Library];


CREATE TABLE [Authors]
(
	[Id_Author] INT IDENTITY(1,1),
	[Name] VARCHAR (30),
	[Last_Name] VARCHAR(30),
	[Email] VARCHAR(30)

	CONSTRAINT PK_Author PRIMARY KEY (Id_Author),
);

CREATE TABLE [Books]
( 
	[Id_Book] INT IDENTITY(1,1),
	[Id_Author] INT NULL,
	[Title] VARCHAR(30),
	[Description] VARCHAR(200),
	[Section] VARCHAR(20),
	[Genre] VARCHAR(30),
	[Year] INT, 
	[Publisher] VARCHAR(30),
	

	CONSTRAINT PK_Book PRIMARY KEY (Id_Book),
	CONSTRAINT FK_BooksAuthors FOREIGN KEY ([Id_Author]) REFERENCES [Authors]([Id_Author])
);

drop database Library;