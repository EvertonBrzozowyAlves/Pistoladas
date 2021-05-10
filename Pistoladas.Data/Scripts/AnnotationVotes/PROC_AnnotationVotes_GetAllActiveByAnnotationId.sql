USE Pistoladas
GO

CREATE OR ALTER PROC PROC_AnnotationVotes_GetAllActiveByAnnotationId
(
    @AnnotationId UNIQUEIDENTIFIER
)
AS
    SELECT
        AnnotationVoteId,
        IsActive,
        RegisterDate,
        AnnotationId,
        VotingUserId
    FROM
        AnnotationVotes
    WHERE
        AnnotationId = @AnnotationId AND
        IsActive = 1
GO