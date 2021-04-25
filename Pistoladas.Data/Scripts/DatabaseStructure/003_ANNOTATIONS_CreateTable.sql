USE [Pistoladas]
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Annotations' and xtype='U')
BEGIN
      CREATE TABLE Annotations 
      (
            AnnotationId        UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      PK_Annotations_AnnotationId     PRIMARY KEY
                                                                CONSTRAINT      DF_Annotations_AnnotationId     DEFAULT NEWSEQUENTIALID(),
            IsActive            BIT                 NOT NULL    CONSTRAINT      DF_Annotations_IsActive         DEFAULT(1),
            RegisterDate        DATETIME            NOT NULL    CONSTRAINT      DF_Annotations_RegisterDate     DEFAULT(GETDATE()),
            UserId              UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      FK_Annotations_UserId           FOREIGN  KEY        REFERENCES Users(UserId),
            AnnotationLevel     TINYINT             NOT NULL    CONSTRAINT      DF_Annotations_AnnotationLevel  DEFAULT(1),
            Description         NVARCHAR(1000)      NULL,
            Votes               INT                 NOT NULL    CONSTRAINT      DF_Annotations_Votes            DEFAULT(0),
            IsValidated         BIT                 NOT NULL    CONSTRAINT      DF_Annotations_IsValidated      DEFAULT(0)             
      )
END
GO