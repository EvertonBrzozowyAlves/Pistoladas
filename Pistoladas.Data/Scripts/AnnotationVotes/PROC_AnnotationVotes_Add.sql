USE Pistoladas
GO

CREATE OR ALTER PROC PROC_AnnotationVotes_Add
(
    @AnnotationId UNIQUEIDENTIFIER,
    @VotingUserId UNIQUEIDENTIFIER
)
AS
    INSERT INTO AnnotationVotes
    (
        AnnotationId,
        VotingUserId
    )
    OUTPUT Inserted.AnnotationVoteId
    VALUES
    (
        @AnnotationId,
        @VotingUserId
    )
GO