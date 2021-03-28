USE Pistoladas
GO

CREATE OR ALTER PROC PROC_USERS_GetAllActive
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
GO