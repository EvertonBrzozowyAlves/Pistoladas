USE Pistoladas
GO

CREATE OR ALTER PROC PROC_ANNOTATIONS_Add
(
    @VictimUserId UNIQUEIDENTIFIER,
    @AccuserUserId UNIQUEIDENTIFIER,
    @AnnotationLevel TINYINT,
    @Description NVARCHAR(1000)
)
AS

INSERT INTO Annotations
(
    VictimUserId,
    AccuserUserId,
    AnnotationLevel,
    Description
)
OUTPUT inserted.AnnotationId
VALUES
(
    @VictimUserId,
    @AccuserUserId,
    @AnnotationLevel,
    @Description
)
GO