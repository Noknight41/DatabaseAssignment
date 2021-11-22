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
    SELECT TOP(3) D.Trich_Lan_thi FROM DE_THI AS D WHERE Trich_Mon_hoc = @MMH ORDER BY Trich_Lan_thi DESC    

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

CREATE OR ALTER PROCEDURE setUpLamBai @DT AS varchar(10), @MSSV AS varchar(10)
AS
BEGIN
	DECLARE @check INT;
	SET @check = dbo.checkLamBai(@MSSV, @DT);
	IF @check = 0 
	BEGIN
		DECLARE @MDT varchar(10);
		DECLARE @STT int;
		DECLARE @MCH varchar(10);
		DECLARE cursorLB CURSOR FOR  SELECT * FROM DE_THI_BAO_GOM_CAU_HOI WHERE Ma_de_thi = @DT

		OPEN cursorLB        
		FETCH NEXT FROM cursorLB  INTO @MDT, @MCH, @STT

		WHILE @@FETCH_STATUS = 0          
		BEGIN           
			INSERT INTO LAM_BAI VALUES (@MSSV, @MDT, @STT, @MCH, 0)
			FETCH NEXT FROM cursorLB INTO @MDT, @MCH, @STT
		END
		CLOSE cursorLB            
		DEALLOCATE cursorLB
	END;
END;
GO