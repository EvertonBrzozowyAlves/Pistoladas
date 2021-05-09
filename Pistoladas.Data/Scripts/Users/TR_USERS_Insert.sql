USE Pistoladas;
GO
CREATE TRIGGER TR_USERS_Insert ON Users
FOR INSERT AS
BEGIN
    INSERT INTO AuditLog
    (
        TableName,
        ObjectId,
        OldRowData,
        NewRowData,
        OperationType,
        OperationDate,
        CreatedBy
    )
    VALUES
    (
        'Users',
        (SELECT UserId FROM Inserted),
        null,
        (SELECT * FROM Inserted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
        'INSERT',
        GETDATE(),
        SUSER_NAME()
    );
END
GO