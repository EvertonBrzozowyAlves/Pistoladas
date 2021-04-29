USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_USERS_Add 
(
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @MobilePhone NVARCHAR(11)
)
AS
    INSERT INTO Users 
    (
        Name, 
        Email, 
        MobilePhone
    )
    OUTPUT Inserted.UserId
    VALUES 
    (
        @Name,
        @Email,
        @MobilePhone
    );
GO