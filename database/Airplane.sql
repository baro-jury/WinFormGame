USE [master]
GO
DROP DATABASE [Airplane]
GO
CREATE DATABASE [Airplane]
GO
USE [Airplane]
GO
CREATE TABLE [Account](
	[userName] [nvarchar](255) NOT NULL,
	CONSTRAINT [account_pk] PRIMARY KEY ([userName])
);
GO
INSERT [Account] ([userName]) VALUES (N'Admin')
GO
CREATE TABLE [Score](
	[score_id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](255) NOT NULL FOREIGN KEY ([userName]) REFERENCES [Account]([userName]),
	[score] [int] NOT NULL,
	[order_date] [datetime] NOT NULL,
	CONSTRAINT [score_pk] PRIMARY KEY ([score_id])
);
GO
INSERT [Score] ([userName], [score], [order_date]) VALUES (N'Admin', 100, GETDATE())
------------------------------------------------------------------------------------------