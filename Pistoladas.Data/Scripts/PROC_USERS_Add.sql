USE Pistoladas
GO

CREATE OR ALTER PROC PROC_USERS_Add 
(
    @Name NVARCHAR(50),
    @Email NVARCHAR(50),
    @MobilePhone NVARCHAR(50)
)
AS
    INSERT INTO 
		[dbo].[Users] ([Name], [Email], [MobilePhone])
    VALUES 
		(@Name,@Email,@MobilePhone)
GO