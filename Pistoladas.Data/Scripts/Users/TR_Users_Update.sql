USE Pistoladas;
GO
CREATE TRIGGER TR_USERS_Update ON Users
FOR UPDATE AS
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
        (SELECT * FROM Deleted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
        (SELECT * FROM Inserted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER),
        'UPDATE',
        GETDATE(),
        SUSER_NAME()
    );
END