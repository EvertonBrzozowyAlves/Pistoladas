USE Pistoladas
GO

CREATE OR ALTER PROC PROC_USERS_GetById 
(
    @UserId BIGINT
)
AS
    SELECT
        [UserId]
        ,[IsActive]
        ,[RegisterDate]
        ,[Name]
        ,[Email]
        ,[MobilePhone]
    FROM 
        [dbo].[Users]
    WHERE
        [UserId] = @UserId
GO