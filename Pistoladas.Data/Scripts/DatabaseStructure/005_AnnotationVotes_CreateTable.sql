use Pistoladas
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AnnotationVotes' and xtype='U')
BEGIN
    CREATE TABLE AnnotationVotes
    (
        VoteId			UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      PK_Votes_VoteId			PRIMARY KEY
                                                        CONSTRAINT      DF_Votes_VoteId			DEFAULT(NEWSEQUENTIALID()),
        IsActive        BIT                 NOT NULL    CONSTRAINT      DF_Votes_IsActive       DEFAULT(1),
        RegisterDate    DATETIME            NOT NULL    CONSTRAINT      DF_Votes_RegisterDate   DEFAULT(GETDATE()),
        AnnotationId	UNIQUEIDENTIFIER    NOT NULL    CONSTRAINT      FK_Votes_AnnotationId   FOREIGN KEY  REFERENCES Annotations(AnnotationId),
        VotingUserId	UNIQUEIDENTIFIER	NOT NULL	CONSTRAINT		FK_Votes_VotingUserId	FOREIGN	KEY  REFERENCES Users(UserId),
    )
END
GO