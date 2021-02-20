USE [Master]
GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Pistoladas')
BEGIN
	CREATE DATABASE [Pistoladas]
END
GO
