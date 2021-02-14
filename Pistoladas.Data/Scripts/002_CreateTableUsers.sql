USE [Pistoladas]
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' and xtype='U')
BEGIN
      CREATE TABLE Users (
            UserId BIGINT PRIMARY KEY IDENTITY (1, 1),
            IsActive BIT DEFAULT(1) NOT NULL,
            RegisterDate DATETIME DEFAULT(GETDATE()) NOT NULL,
            Name NVARCHAR(50) NOT NULL,
            Email NVARCHAR(50) NOT NULL,
            MobilePhone NVARCHAR(50) NULL
      )
END
GO
--
USE [Pistoladas]
GO

INSERT INTO 
	[dbo].[Users](
            [Name], [Email] ,[MobilePhone]
      )
VALUES
    ('Test Name' ,'test@mail.com' ,'5511911111111'),
    ('Test Name' ,'test@mail.com' ,'5511911111111'),
    ('Test Name' ,'test@mail.com' ,'5511911111111'),
    ('Test Name' ,'test@mail.com' ,'5511911111111'),
    ('Test Name' ,'test@mail.com' ,'5511911111111'),
    ('Test Name' ,'test@mail.com' ,'5511911111111')
GO
--
CREATE OR ALTER PROC PROC_USERS_LST 
AS
	SELECT 
            [UserId]
            ,[IsActive]
            ,[RegisterDate]
            ,[Name]
            ,[Email]
            ,[MobilePhone]
	  FROM [dbo].[Users]
GO