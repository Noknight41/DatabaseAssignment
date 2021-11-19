USE Ass2
GO

--i4
SELECT * FROM i4 (1,'CO2012');
--i5
SELECT * FROM i5(1,'CO2012','1812438') ORDER BY STTCH;
--i6
SELECT * FROM i6 (1,'CO2012');
--i7
SELECT dbo.i7d ('CH10102020', 1);
SELECT dbo.i7s ('CH10102020', 1);

SELECT * FROM CHi8 ('CO2012', 1, 1);
SELECT * FROM CHi8 ('CO2012', 2, 1);
SELECT * FROM CHi8 ('CO2012', 3, 1);
SELECT * FROM CDRi8 ('CO2012',1);
--i8
SELECT * FROM i8 ('CO2012',1);

--i9
SELECT * FROM i9 ('CO2012', 1);
SELECT TOP(5) * FROM i9 ('CO2012', 1) ORDER BY Sno DESC;

--i10
SELECT * FROM i10 ('CO2012');

SELECT M.Trich_Lan_thi, Ma_cau_hoi, M.Sno
FROM i10 ('CO2012') AS M JOIN (SELECT Trich_Lan_thi, MAX(Sno) AS SM FROM i10 ('CO2012') GROUP BY Trich_Lan_thi) AS N ON M.Trich_Lan_thi = N.Trich_Lan_thi
WHERE M.Sno = N.SM

--i11
SELECT TOP(1) WITH TIES * FROM i8 ('CO2012', 1) ORDER BY Ratio ASC;

--i12
EXEC i12 @MMH = 'CO2012';
SELECT * FROM ti12;

--ii10
SELECT * FROM ii10all (1);
SELECT TOP(1) WITH TIES * FROM ii10(1) ORDER BY AVGrade ASC;

--iii3
SELECT * FROM iii3('CO12A1101') ORDER BY STTCH;

--iii4
SELECT * FROM iii4('CO12A1101', '1812438') ORDER BY STTCH;

--iii5
SELECT * FROM iii5 (1,'CO2012', '1812438');

--iii6
SELECT * FROM iii6 (1, '1812438');

--iii7
SELECT *, (Correct * 10.0 / Total) AS Grade
FROM iii7 ('CO12A1101', '1812438');


-- Them Sua Note, Xem Note
EXEC SuaNoteDeThi @DT = 'CO12A1101', @Note = 'Nope';
SELECT dbo.NoteDethi('CO12A1101');

SELECT dbo.PassGVPT('PT1001');
SELECT dbo.PassGVQL('QL1002');
SELECT dbo.PassSV('1812438');

