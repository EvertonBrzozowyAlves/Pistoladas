USE [Pistoladas]
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' and xtype='U')
BEGIN
      CREATE TABLE Users 
      (
            UserId              UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      PK_Users_UserId         PRIMARY KEY         
                                                                CONSTRAINT      DF_Users_UserId         DEFAULT NEWSEQUENTIALID(),
            IsActive            BIT                 NOT NULL    CONSTRAINT      DF_Users_IsActive       DEFAULT(1),
            RegisterDate        DATETIME            NOT NULL    CONSTRAINT      DF_Users_RegisterDate   DEFAULT(GETDATE()),
            Name                NVARCHAR(100)       NOT NULL,
            Email               NVARCHAR(100)       NOT NULL,
            MobilePhone         NVARCHAR(11)        NULL
      )
END
GO