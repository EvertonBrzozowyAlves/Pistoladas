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
            VictimUserId        UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      FK_Annotations_VictimUserId     FOREIGN  KEY        REFERENCES Users(UserId),
            AccuserUserId       UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      FK_Annotations_AccuserUserId    FOREIGN  KEY        REFERENCES Users(UserId),
            AnnotationLevel     TINYINT             NOT NULL    CONSTRAINT      DF_Annotations_AnnotationLevel  DEFAULT(1),
            Description         NVARCHAR(1000)      NOT NULL    CONSTRAINT      CK_Annotations_Description      CHECK               (LEN(Description) > 10 AND LEN(Description) < 1000),
            Votes               INT                 NOT NULL    CONSTRAINT      DF_Annotations_Votes            DEFAULT(0),
            IsValidated         BIT                 NOT NULL    CONSTRAINT      DF_Annotations_IsValidated      DEFAULT(0)             
      )
END
GO