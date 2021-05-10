USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_USERS_GetActiveCount
AS
    SELECT
        COUNT(UserId) AS ActiveUsersCount
    FROM
        Users
    WHERE
        IsActive = 1;
GO