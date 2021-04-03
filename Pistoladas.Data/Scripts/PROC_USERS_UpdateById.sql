USE Pistoladas
GO

CREATE OR ALTER PROC PROC_USERS_Update 
(
    @Name NVARCHAR(50),
    @Email NVARCHAR(50),
    @MobilePhone NVARCHAR(50),
    @UserId BIGINT
)
AS
    UPDATE
        [dbo].[Users]
    SET
        [Name] = @Name
        ,[Email] = @Email
        ,[MobilePhone] = @MobilePhone
    WHERE 
        [UserId] = @UserId
GO