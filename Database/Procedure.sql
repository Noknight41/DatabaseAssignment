USE Ass2
GO

CREATE OR ALTER PROCEDURE i12 @MMH AS varchar(10)
AS
BEGIN
	TRUNCATE TABLE ti12
	DECLARE @MyCursor CURSOR;
	DECLARE @MyField INT;
	BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT TOP(3) D.Trich_Lan_thi FROM DE_THI AS D WHERE Trich_Mon_hoc = @MMH ORDER BY Trich_Lan_thi ASC    

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		INSERT INTO ti12 SELECT TOP(1) WITH TIES * FROM i8 (@MMH, @MyField) ORDER BY Ratio ASC
		FETCH NEXT FROM @MyCursor 
		INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
	END;
END;
GO

CREATE OR ALTER PROCEDURE SuaNoteDeThi @DT AS varchar(10), @Note AS varchar(2048)
AS
BEGIN
	UPDATE DE_THI SET Note = @Note
	WHERE Ma_de_thi = @DT
END;
GO

