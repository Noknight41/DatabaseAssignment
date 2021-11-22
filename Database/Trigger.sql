USE Ass2
GO

CREATE OR ALTER TRIGGER verify_de_thi ON DE_THI_BAO_GOM_CAU_HOI INSTEAD OF INSERT AS
BEGIN
	DECLARE loop_cursor CURSOR FOR
		SELECT Ma_cau_hoi, Ma_de_thi FROM inserted
	OPEN loop_cursor;

	DECLARE @question_id VARCHAR(10), @so_cau INT, @mdt VARCHAR(10);

	FETCH NEXT FROM loop_cursor INTO @question_id, @mdt;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @so_cau = COUNT (*)
		FROM TAP_DE_THI_BAO_GOM_CAU_HOI AS T JOIN DE_THI AS D ON (T.Lan_thi = D.Trich_Lan_thi AND T.Ma_mon_hoc_TDT = D.Trich_Mon_hoc)
		WHERE @question_id = Ma_cau_hoi AND D.Ma_de_thi = @mdt
		IF (@so_cau >= 1)
			INSERT INTO DE_THI_BAO_GOM_CAU_HOI(Ma_de_thi, Ma_cau_hoi, STTCH) 
				SELECT Ma_de_thi, Ma_cau_hoi, STTCH
				FROM inserted
		ELSE
			PRINT('Question must have in Tap_de_thi')
		FETCH NEXT FROM loop_cursor INTO @question_id , @mdt
	END;

	CLOSE loop_cursor;
	DEALLOCATE loop_cursor;
END;
GO

CREATE OR ALTER TRIGGER tang_so_cau_hoi ON DE_THI_BAO_GOM_CAU_HOI AFTER INSERT AS
BEGIN
	DECLARE loop_cursor1 CURSOR FOR
		SELECT Ma_de_thi FROM inserted
	OPEN loop_cursor1;

	DECLARE @test_id VARCHAR(10);

	FETCH NEXT FROM loop_cursor1 INTO @test_id;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE DE_THI
		SET So_luong_cau_hoi = So_luong_cau_hoi + 1
		WHERE DE_THI.Ma_de_thi = @test_id
		
		FETCH NEXT FROM loop_cursor1 INTO @test_id
	END;

	CLOSE loop_cursor1;
	DEALLOCATE loop_cursor1;
END;
GO



