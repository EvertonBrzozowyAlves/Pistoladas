USE Pistoladas
GO

CREATE OR ALTER PROC PROC_USERS_List 
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