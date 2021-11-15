USE Ass2
GO

CREATE OR ALTER FUNCTION i4 (@LT AS int, @MH AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DISTINCT L.MSSV
	FROM LAM_BAI AS L JOIN DE_THI AS D ON L.Ma_de_thi = D.Ma_de_thi
	WHERE D.Trich_Lan_thi = @LT AND D.Trich_Mon_hoc = @MH
GO

CREATE OR ALTER FUNCTION i5 (@LT AS int, @MH AS varchar(10), @MSSV AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DT.STTCH, L.Tra_loi
	FROM (LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi) JOIN DE_THI_BAO_GOM_CAU_HOI AS DT ON DT.Ma_cau_hoi = L.Ma_cau_hoi
	WHERE L.MSSV = @MSSV AND D.Trich_Mon_hoc = @MH AND D.Trich_Lan_thi = @LT
GO

CREATE OR ALTER FUNCTION i6d (@LT AS int, @MH AS varchar(10), @MSSV AS varchar(10))
RETURNS	FLOAT AS
BEGIN
	DECLARE @total FLOAT
	DECLARE @correct FLOAT
	DECLARE @grade FLOAT
	SELECT @total = COUNT(*)
	FROM (LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi)
	WHERE D.Trich_Mon_hoc = @MH AND D.Trich_Lan_thi = @LT AND L.MSSV = @MSSV

	SELECT @correct = COUNT(*)
	FROM (LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi) JOIN CAU_HOI AS C ON C.Ma_cau_hoi = L.Ma_cau_hoi
	WHERE D.Trich_Mon_hoc = @MH AND D.Trich_Lan_thi = @LT AND L.MSSV = @MSSV AND C.Vi_tri_dap_an_dung = L.Tra_loi

	SELECT @grade = @correct * 10.0 / @total
	RETURN @grade
END;
GO

CREATE OR ALTER FUNCTION i6 (@LT AS int, @MH AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DISTINCT L.MSSV, (SELECT dbo.i6d (@LT,@MH,L.MSSV)) AS GRADE
	FROM LAM_BAI AS L JOIN DE_THI AS D ON L.Ma_de_thi = D.Ma_de_thi
	WHERE D.Trich_Lan_thi = @LT AND D.Trich_Mon_hoc = @MH
GO

CREATE OR ALTER FUNCTION i7d (@CH AS varchar(10), @LT AS int)
RETURNS	INT AS
BEGIN
	DECLARE @answer varchar(4)
	SELECT @answer = Vi_tri_dap_an_dung
	FROM CAU_HOI
	WHERE Ma_cau_hoi = @CH


	DECLARE @correct INT
	SELECT @correct = COUNT(*)
	FROM (LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi)
	WHERE L.Ma_cau_hoi = @CH AND D.Trich_Lan_thi = @LT AND L.Tra_loi = @answer
	RETURN @correct
END;
GO

CREATE OR ALTER FUNCTION i7s (@CH AS varchar(10), @LT AS int)
RETURNS	INT AS
BEGIN
	DECLARE @answer varchar(4)
	SELECT @answer = Vi_tri_dap_an_dung
	FROM CAU_HOI
	WHERE Ma_cau_hoi = @CH

	DECLARE @correct INT
	SELECT @correct = COUNT(*)
	FROM (LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi)
	WHERE L.Ma_cau_hoi = @CH AND D.Trich_Lan_thi = @LT AND L.Tra_loi != @answer
	RETURN @correct
END;
GO

CREATE OR ALTER FUNCTION CHi8 (@MH AS varchar(10), @STT AS INT, @LT AS INT)
RETURNS	TABLE AS
RETURN
	SELECT C.Ma_cau_hoi, D.Trich_Lan_thi AS Lanthi, (SELECT dbo.i7d (C.Ma_cau_hoi, @LT)) AS Dno,(SELECT dbo.i7s (C.Ma_cau_hoi, @LT)) AS Sno
	FROM (DE_THI AS D JOIN DE_THI_BAO_GOM_CAU_HOI AS DT ON D.Ma_de_thi = DT.Ma_de_thi) JOIN CAU_HOI AS C ON C.Ma_cau_hoi = DT.Ma_cau_hoi
	WHERE C.Ma_mon_hoc_thuoc = @MH AND C.STTCDR = @STT AND D.Trich_Lan_thi = @LT
GO

CREATE OR ALTER FUNCTION CHi8d (@MH AS varchar(10), @STT AS INT, @LT AS INT)
RETURNS INT AS
BEGIN
	DECLARE @correct INT
	SELECT @correct = SUM(D.Dno)
	FROM (SELECT * FROM CHi8 (@MH, @STT, @LT)) AS D
	RETURN @correct
END;
GO

CREATE OR ALTER FUNCTION CHi8t (@MH AS varchar(10), @STT AS INT, @LT AS INT)
RETURNS INT AS
BEGIN
	DECLARE @total INT
	SELECT @total = SUM(D.Dno) + SUM(D.Sno)
	FROM (SELECT * FROM CHi8 (@MH, @STT, @LT)) AS D
	RETURN @total
END;
GO

CREATE OR ALTER FUNCTION CDRi8 (@MH AS varchar(10), @LT AS INT)
RETURNS	TABLE AS
RETURN
	SELECT Ma_mon_hoc, STT, (SELECT dbo.CHi8d(Ma_mon_hoc, STT, @LT)) AS Dno,  (SELECT dbo.CHi8t(Ma_mon_hoc, STT, @LT)) AS Tno
	FROM CHUAN_DAU_RA
	WHERE Ma_mon_hoc = @MH 
GO

CREATE OR ALTER FUNCTION i8 (@MH AS varchar(10), @LT AS INT)
RETURNS	TABLE AS
RETURN
	SELECT Ma_mon_hoc, STT, (Dno * 1.0 / Tno) AS Ratio, @LT AS Lanthi
	FROM (SELECT * FROM CDRi8 (@MH, @LT)) AS D
	WHERE Ma_mon_hoc = @MH AND Tno != 0
GO

CREATE OR ALTER FUNCTION i9 (@MH AS varchar(10), @LT AS INT)
RETURNS	TABLE AS
RETURN
	SELECT DISTINCT DT.Ma_cau_hoi, (SELECT dbo.i7s (DT.Ma_cau_hoi, @LT)) AS Sno
	FROM (DE_THI AS D JOIN DE_THI_BAO_GOM_CAU_HOI AS DT ON D.Ma_de_thi = DT.Ma_de_thi)
	WHERE D.Trich_Mon_hoc = @MH  AND D.Trich_Lan_thi = @LT
GO

CREATE OR ALTER FUNCTION i10 (@MH AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT D.Trich_Lan_thi, DT.Ma_cau_hoi, (SELECT dbo.i7s (DT.Ma_cau_hoi,D.Trich_Lan_thi)) AS Sno
	FROM (DE_THI AS D JOIN DE_THI_BAO_GOM_CAU_HOI AS DT ON D.Ma_de_thi = DT.Ma_de_thi)
	WHERE D.Trich_Mon_hoc = @MH
GO

--ii10
CREATE OR ALTER FUNCTION ii10all (@LT AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DISTINCT L.MSSV, D.Trich_Mon_hoc, L.Ma_de_thi, (SELECT dbo.i6d (@LT, D.Trich_Mon_hoc, L.MSSV)) AS GRADE
	FROM LAM_BAI AS L JOIN DE_THI AS D ON D.Ma_de_thi = L.Ma_de_thi
	WHERE D.Trich_Lan_thi = @LT
GO

CREATE OR ALTER FUNCTION ii10 (@LT AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT T.Trich_Mon_hoc, AVG(GRADE) AS AVGrade
	FROM (SELECT * FROM ii10all (@LT)) AS T
	GROUP BY T.Trich_Mon_hoc
GO

CREATE OR ALTER FUNCTION iii3 (@DT AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT Ma_de_thi, DTCH.STTCH, PCH.Noi_dung AS Noi_dung_cau_hoi, CH.Ma_cau_hoi, CH.Vi_tri_dap_an_dung, PTL.Noi_dung AS Noi_dung_dap_an
	FROM ((DE_THI_BAO_GOM_CAU_HOI AS DTCH JOIN CAU_HOI AS CH ON DTCH.Ma_cau_hoi = CH.Ma_cau_hoi) JOIN PHAN_TRA_LOI AS PTL ON (PTL.Ma_cau_hoi = CH.Ma_cau_hoi AND PTL.STT = CH.Vi_tri_dap_an_dung)) JOIN PHAN_CAU_HOI AS PCH ON PCH.Ma_cau_hoi = CH.Ma_cau_hoi
	WHERE DTCH.Ma_de_thi = @DT
GO

CREATE OR ALTER FUNCTION iii4 (@DT AS varchar(10), @MSSV AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DTCH.Ma_de_thi, DTCH.Ma_cau_hoi, DTCH.STTCH, LB.Tra_loi, LB.MSSV
	FROM (DE_THI_BAO_GOM_CAU_HOI AS DTCH LEFT JOIN LAM_BAI AS LB ON (DTCH.Ma_cau_hoi = LB.Ma_cau_hoi AND DTCH.Ma_de_thi = LB.Ma_de_thi))
	WHERE DTCH.Ma_de_thi = @DT AND LB.MSSV = @MSSV
GO


CREATE OR ALTER FUNCTION iii5 (@LT AS int, @MH AS varchar(10), @MSSV AS varchar(10))
RETURNS	TABLE AS
RETURN
	SELECT DISTINCT L.MSSV, (SELECT dbo.i6d (@LT,@MH,L.MSSV)) AS GRADE
	FROM LAM_BAI AS L JOIN DE_THI AS D ON L.Ma_de_thi = D.Ma_de_thi
	WHERE D.Trich_Lan_thi = @LT AND D.Trich_Mon_hoc = @MH AND L.MSSV = @MSSV
GO





