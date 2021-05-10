USE Pistoladas
GO

CREATE OR ALTER PROC PROC_AnnotationVotes_GetAllActiveCountByAnnotationId
(
    @AnnotationId UNIQUEIDENTIFIER
)
AS
    SELECT
        COUNT(AnnotationVoteId) AS ValidVotes
    FROM
        AnnotationVotes
    WHERE
        AnnotationId = @AnnotationId AND
        IsActive = 1
GO