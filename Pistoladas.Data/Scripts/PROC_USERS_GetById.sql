USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_USERS_GetById 
(
    @UserId UNIQUEIDENTIFIER
)
AS
    SELECT
        UserId,
        IsActive,
        RegisterDate,
        Name,
        Email,
        MobilePhone
    FROM 
        Users
    WHERE
        UserId = @UserId;
GO