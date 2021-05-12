USE Pistoladas;
GO

CREATE OR ALTER PROC PROC_SYS_GetProcFirstResultSet 
(
    @ProcedureName NVARCHAR(MAX)
)
AS
BEGIN;
	DECLARE @ProcedureNameWithoutProcWord NVARCHAR(MAX);
	DECLARE @TableName NVARCHAR(MAX);

    SELECT @ProcedureNameWithoutProcWord = REPLACE(@ProcedureName, 'PROC_', '');
    SELECT @TableName = LEFT(@ProcedureNameWithoutProcWord,  CHARINDEX('_', @ProcedureNameWithoutProcWord) - 1);

    BEGIN TRAN;

	SET @SQL = 'ALTER TABLE ' + @TableName + ' DISABLE TRIGGER ALL;';
    EXEC(@SQL);

    EXEC sp_describe_first_result_set @tsql = @ProcedureName;

	SET @SQL = 'ALTER TABLE ' + @TableName + ' ENABLE TRIGGER ALL;';
    EXEC(@SQL);

    COMMIT;
END;
GO