USE Pistoladas
GO

CREATE OR ALTER PROC PROC_Users_Update
(
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @MobilePhone NVARCHAR(11),
    @UserId UNIQUEIDENTIFIER
)
AS
BEGIN
    SET NOCOUNT ON

    UPDATE
        Users
    SET
        Name = @Name,
        Email = @Email,
        MobilePhone = @MobilePhone
    WHERE
        UserId = @UserId

    SELECT @@ROWCOUNT AS AffectedRows
END
GO