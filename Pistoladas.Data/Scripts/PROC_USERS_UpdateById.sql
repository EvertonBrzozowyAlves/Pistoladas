USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_USERS_Update 
(
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @MobilePhone NVARCHAR(11),
    @UserId UNIQUEIDENTIFIER
)
AS
    UPDATE
        Users
    SET
        Name = @Name,
        Email = @Email,
        MobilePhone = @MobilePhone
    WHERE 
        UserId = @UserId;
GO