USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_ANNOTATIONS_GetById 
(
    @AnnotationId UNIQUEIDENTIFIER
)
AS
    SELECT
        AnnotationId,
        IsActive,
        RegisterDate,
        VictimUserId,
        AccuserUserId,
        AnnotationLevel,
        Description
    FROM
        Annotations
    WHERE
        AnnotationId = @AnnotationId;
GO