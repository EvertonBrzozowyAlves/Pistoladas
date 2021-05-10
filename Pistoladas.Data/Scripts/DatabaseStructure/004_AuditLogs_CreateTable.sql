USE Pistoladas
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AuditLog' and xtype='U')
BEGIN
    CREATE TABLE AuditLog 
    (
        AuditLogId		UNIQUEIDENTIFIER	NOT NULL	CONSTRAINT PK_AuditLog_AuditLogId		PRIMARY KEY
                                                        CONSTRAINT DF_AuditLog_AuditLogId		DEFAULT NEWSEQUENTIALID(),
        TableName		VARCHAR(100)		NOT NULL,
        ObjectId		UNIQUEIDENTIFIER	NOT NULL,
        OldRowData		NVARCHAR(1000)					CONSTRAINT CK_AuditLog_OldRowData		CHECK(ISJSON(OldRowData) = 1),
        NewRowData		NVARCHAR(1000)					CONSTRAINT CK_AuditLog_NewRowData		CHECK(ISJSON(NewRowData) = 1),
        OperationType	VARCHAR(10)			NOT NULL	CONSTRAINT CK_AuditLog_OperationType	CHECK (OperationType IN ('INSERT', 'UPDATE', 'DELETE')),
        OperationDate	DATETIME			NOT NULL	CONSTRAINT DF_AuditLog_OperationDate	DEFAULT GETDATE(),
        CreatedBy		VARCHAR(255)		NOT NULL
    )
GO

