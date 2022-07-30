USE [master]
GO
DROP DATABASE [RacingMaster]
GO
CREATE DATABASE [RacingMaster]
GO
USE [RacingMaster]
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
	[highscore] [int] NOT NULL,
	[time] [datetime] NOT NULL,
	CONSTRAINT [score_pk] PRIMARY KEY ([score_id])
);
GO
INSERT [Score] ([userName], [highscore], [time]) VALUES (N'Admin', 100, GETDATE())
------------------------------------------------------------------------------------------