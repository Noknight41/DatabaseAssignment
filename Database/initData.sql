CREATE DATABASE Ass2
GO
USE Ass2
GO

CREATE TABLE MON_HOC (
    Ma_mon_hoc varchar(10) NOT NULL,
	Ten varchar(256),
    CONSTRAINT MH_PK PRIMARY KEY (Ma_mon_hoc)
); 
GO

CREATE TABLE GIANG_VIEN_PHU_TRACH (
    MSCB varchar(10) NOT NULL,
	Mon_hoc_phu_trach varchar(10),
	Pass varchar(100),

	CONSTRAINT GVPT_FK FOREIGN KEY (Mon_hoc_phu_trach) REFERENCES MON_HOC(Ma_mon_hoc) on delete no action on update cascade, 
	CONSTRAINT GVPT_PK PRIMARY KEY (MSCB)
); 
GO

CREATE TABLE GIANG_VIEN_QUAN_LY (
    MSCB varchar(10) NOT NULL,
    Mon_hoc_quan_ly varchar(10) UNIQUE,
	Pass varchar(100),

	CONSTRAINT GVQL_FK FOREIGN KEY (Mon_hoc_quan_ly) REFERENCES MON_HOC(Ma_mon_hoc) on delete no action on update cascade, 
	CONSTRAINT GVQL_PK PRIMARY KEY (MSCB)
); 
GO

CREATE TABLE CHUAN_DAU_RA (
    STT int NOT NULL,
    Ten nvarchar(256),
	Ma_mon_hoc varchar(10) NOT NULL,

	CONSTRAINT MHCDR FOREIGN KEY (Ma_mon_hoc) REFERENCES MON_HOC(Ma_mon_hoc) on delete no action on update cascade,
    CONSTRAINT IDCDR PRIMARY KEY (STT, Ma_mon_hoc)
); 
GO

CREATE TABLE LAN_THI (
	Lan_thi int NOT NULL,
	Hoc_ky varchar(10) NOT NULL,
	Nam_hoc int NOT NULL,
	CONSTRAINT LTPK PRIMARY KEY (Lan_thi)
);
GO

CREATE TABLE TAP_DE_THI (
    Lan_thi int NOT NULL,
	Ma_mon_hoc_TDT varchar(10) NOT NULL,
	MSCB_xay_dung varchar(10) NOT NULL,

	CONSTRAINT MHTDT FOREIGN KEY (Ma_mon_hoc_TDT) REFERENCES MON_HOC(Ma_mon_hoc) on delete no action on update cascade,
	CONSTRAINT LT FOREIGN KEY (Lan_thi) REFERENCES LAN_THI(Lan_thi) on delete no action on update cascade,
	CONSTRAINT GVTDT FOREIGN KEY (MSCB_xay_dung) REFERENCES GIANG_VIEN_PHU_TRACH(MSCB),
    CONSTRAINT IDTT PRIMARY KEY (Lan_thi, Ma_mon_hoc_TDT)
); 
GO

CREATE TABLE DE_THI (
	Ma_de_thi varchar(10) NOT NULL,
    So_luong_cau_hoi int DEFAULT 0,
    Thoi_gian_lam_bai int,
	Trich_Lan_thi int,
	Trich_Mon_hoc varchar(10),
	MSCB_ra_de varchar(10),
	MSCB_duyet varchar(10),
	Ngay_xac_nhan_ra_de date,
	Ngay_duyet_de date,
	Ngay_thi date,
	Note nvarchar(2048),

	CONSTRAINT TDTDT FOREIGN KEY (Trich_Lan_thi, Trich_Mon_hoc) REFERENCES TAP_DE_THI(Lan_thi, Ma_mon_hoc_TDT) on delete no action on update cascade,
	CONSTRAINT GVPTDT FOREIGN KEY (MSCB_ra_de) REFERENCES GIANG_VIEN_PHU_TRACH(MSCB),
	CONSTRAINT GVQLDT FOREIGN KEY (MSCB_duyet) REFERENCES GIANG_VIEN_QUAN_LY(MSCB),
	CONSTRAINT IDDT PRIMARY KEY (Ma_de_thi)
);
GO

CREATE TABLE SINH_VIEN(
	MSSV varchar(10) NOT NULL,
	Pass varchar(100),

    CONSTRAINT IDSV PRIMARY KEY (MSSV)
);
GO

CREATE TABLE CAU_HOI (
	Ma_cau_hoi				varchar(10)	not null,
	Vi_tri_dap_an_dung		int not null default 0,
	MSCB_GV_tao				varchar(10)	not null,
	Thoi_gian_tao			date,
	Ma_mon_hoc_thuoc		varchar(10),
	STTCDR					int,
	ID_phan_mo_ta			varchar(10),

	CONSTRAINT GVtao FOREIGN KEY (MSCB_GV_tao) REFERENCES GIANG_VIEN_PHU_TRACH(MSCB),
	CONSTRAINT CDR_thuoc FOREIGN KEY (STTCDR, Ma_mon_hoc_thuoc) REFERENCES CHUAN_DAU_RA(STT, Ma_mon_hoc),
	CONSTRAINT key_cau_hoi PRIMARY KEY (Ma_cau_hoi)
);
GO

CREATE TABLE LAM_BAI(
	MSSV varchar(10) NOT NULL,
	Ma_de_thi varchar(10) NOT NULL,
	Ma_cau_hoi varchar(10) NOT NULL,
	Tra_loi int NOT NULL default 0,
	Note nvarchar(2048) DEFAULT '',

	CONSTRAINT LamDE_THI FOREIGN KEY (Ma_de_thi) REFERENCES DE_THI(Ma_de_thi) on delete no action on update cascade,
	CONSTRAINT LamCAU_HOI FOREIGN KEY (Ma_cau_hoi) REFERENCES CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
	CONSTRAINT SVlamde FOREIGN KEY (MSSV) REFERENCES SINH_VIEN(MSSV) on delete no action on update cascade,
	CONSTRAINT Lamde PRIMARY KEY (MSSV, Ma_de_thi, Ma_cau_hoi)
);
GO

CREATE TABLE TAP_DE_THI_BAO_GOM_CAU_HOI(
	Lan_thi int NOT NULL,
	Ma_mon_hoc_TDT varchar(10) NOT NULL,
	Ma_cau_hoi varchar(10) NOT NULL,

	CONSTRAINT TDT FOREIGN KEY (Lan_thi,Ma_mon_hoc_TDT) REFERENCES TAP_DE_THI(Lan_thi, Ma_mon_hoc_TDT) on delete no action on update cascade,
	CONSTRAINT CHTDT FOREIGN KEY (Ma_cau_hoi) REFERENCES CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
	CONSTRAINT TDTCH_PK PRIMARY KEY (Lan_thi,Ma_mon_hoc_TDT, Ma_cau_hoi)
);
GO

CREATE TABLE DE_THI_BAO_GOM_CAU_HOI(
	Ma_de_thi				varchar(10) NOT NULL,
	Ma_cau_hoi				varchar(10) NOT NULL,
	STTCH					int NOT NULL,

	CONSTRAINT DT FOREIGN KEY (Ma_de_thi) REFERENCES DE_THI(Ma_de_thi),
	CONSTRAINT CHDT FOREIGN KEY (Ma_cau_hoi) REFERENCES CAU_HOI(Ma_cau_hoi),
	CONSTRAINT DTCH_PK PRIMARY KEY (Ma_de_thi, Ma_cau_hoi)
);
GO

create table PHAN_TRA_LOI (
	Ma_cau_hoi				varchar(10)		NOT NULL,
	STT						int CHECK (STT >= 1 AND STT <= 5),
	Noi_dung				nvarchar(2048),

	CONSTRAINT PTL_FK FOREIGN KEY (Ma_cau_hoi) REFERENCES CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
	CONSTRAINT PTL_PK PRIMARY KEY (Ma_cau_hoi, STT)
);

create table PHAN_CAU_HOI (
	Ma_cau_hoi				varchar(10)		NOT NULL UNIQUE,
	Noi_dung				nvarchar(2048),

	CONSTRAINT PCH_FK FOREIGN KEY (Ma_cau_hoi) references CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
	CONSTRAINT PCH_PK PRIMARY KEY (Ma_cau_hoi),
);

create table PHAN_MO_TA_CHUNG (
	ID_phan_mo_ta			varchar(10) NOT NULL,
	Noi_dung				nvarchar(2048),
	CONSTRAINT PMTC_PK PRIMARY KEY (ID_phan_mo_ta),
);

alter table CAU_HOI
	add foreign key (ID_phan_mo_ta)	references PHAN_MO_TA_CHUNG (ID_phan_mo_ta)
		on delete no action on update cascade

CREATE TABLE FILE_MO_TA (
	ID_FMT			varchar(10) NOT NULL,
	URL_hinh_anh	varchar(4096) NOT NULL,
	CONSTRAINT FMT_PK PRIMARY KEY (ID_FMT),
);

create table PTL_CHUA_FMT (
	Ma_cau_hoi				varchar(10) NOT NULL,
	STT						int NOT NULL,
	ID_FMT					varchar(10) NOT NULL,
	
	CONSTRAINT PTL FOREIGN KEY (Ma_cau_hoi, STT) REFERENCES PHAN_TRA_LOI(Ma_cau_hoi, STT) on delete no action on update cascade,
	CONSTRAINT PTLFMT FOREIGN KEY (ID_FMT) REFERENCES FILE_MO_TA(ID_FMT) on delete no action on update cascade,
	CONSTRAINT PTLchuaPK PRIMARY KEY (Ma_cau_hoi, STT, ID_FMT)
			
);

create table PCH_CHUA_FMT (
	Ma_cau_hoi				varchar(10) NOT NULL,
	ID_FMT					varchar(10) NOT NULL,

	CONSTRAINT PCH FOREIGN KEY (Ma_cau_hoi) REFERENCES PHAN_CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
	CONSTRAINT PCHFMT FOREIGN KEY (ID_FMT) REFERENCES FILE_MO_TA(ID_FMT) on delete no action on update cascade,
	CONSTRAINT PCHchuaPK PRIMARY KEY (Ma_cau_hoi, ID_FMT)
);

create table PMTC_CHUA_FMT (
	ID_phan_mo_ta			varchar(10) NOT NULL,
	ID_FMT					varchar(10) NOT NULL,
	
	CONSTRAINT PMTC FOREIGN KEY (ID_phan_mo_ta) REFERENCES PHAN_MO_TA_CHUNG(ID_phan_mo_ta) on delete no action on update cascade,
	CONSTRAINT PMTCFMT FOREIGN KEY (ID_FMT) REFERENCES FILE_MO_TA(ID_FMT) on delete no action on update cascade,
	CONSTRAINT PMTCchuaPK PRIMARY KEY (ID_phan_mo_ta, ID_FMT)
);
GO

CREATE TABLE ti12(
	Ma_mon_hoc varchar(10),
	STT INT,
	Ratio FLOAT(10),
	Lanthi INT
);
GO

--Mon hoc
INSERT INTO MON_HOC(Ma_mon_hoc, Ten) VALUES
('CO2012', 'Toan roi rac'), 
('CO2013', 'XS Thong Ke'), 
('CO2014', 'Giai Tich');
GO

--GV phutrach
INSERT INTO GIANG_VIEN_PHU_TRACH(MSCB, Mon_hoc_phu_trach, Pass) VALUES
('PT1001', 'CO2012', '1'), 
('PT1002', 'CO2012', '1'), 
('PT1003', 'CO2012', '1'), 

('PT1011', 'CO2013', '1'), 
('PT1012', 'CO2013', '1'), 
('PT1013', 'CO2013', '1'), 

('PT1021', 'CO2014', '1'), 
('PT1022', 'CO2014', '1'), 
('PT1023', 'CO2014', '1');
GO

--GVQuanly
INSERT INTO GIANG_VIEN_QUAN_LY(MSCB, Mon_hoc_quan_ly, Pass) VALUES 
('QL1002', 'CO2012', '1'), 
('QL1003', 'CO2013', '1'), 
('QL1004', 'CO2014', '1');
GO

--Chuandaura
INSERT INTO CHUAN_DAU_RA(STT, Ten, Ma_mon_hoc) VALUES 
(1, 'Toan Roi Rac' , 'CO2012'), 
(2, 'Toan Roi Rac' , 'CO2012'), 
(3, 'Toan Roi Rac' , 'CO2012'), 

(1, 'XS Thong Ke',  'CO2013'), 
(2, 'XS Thong Ke',  'CO2013'), 
(3, 'XS Thong Ke',  'CO2013'), 

(1, 'Giai tich',  'CO2014'), 
(2, 'Giai tich',  'CO2014'), 
(3, 'Giai tich',  'CO2014');
GO

--Lanthi
INSERT INTO LAN_THI(Lan_thi, Hoc_ky, Nam_hoc) VALUES
(1, 'HK1', 2019),
(2, 'HK2', 2019),
(3, 'HK3', 2019),
(4, 'HK1', 2020),
(5, 'HK2', 2020),
(6, 'HK3', 2020),
(7, 'HK1', 2021),
(8, 'HK2', 2021),
(9, 'HK3', 2021);
GO

--Tapdethi
	INSERT INTO TAP_DE_THI(Lan_thi, Ma_mon_hoc_TDT, MSCB_xay_dung) VALUES 
(1, 'CO2012', 'PT1001'), (1, 'CO2013', 'PT1011'), (1, 'CO2014', 'PT1021'),
(2, 'CO2012', 'PT1002'), (2, 'CO2013', 'PT1012'), (2, 'CO2014', 'PT1022'),
(3, 'CO2012', 'PT1003'), (3, 'CO2013', 'PT1013'), (3, 'CO2014', 'PT1023'),

(4, 'CO2012', 'PT1001'), (4, 'CO2013', 'PT1011'), (4, 'CO2014', 'PT1021'),
(5, 'CO2012', 'PT1002'), (5, 'CO2013', 'PT1012'), (5, 'CO2014', 'PT1022'),
(6, 'CO2012', 'PT1003'), (6, 'CO2013', 'PT1013'), (6, 'CO2014', 'PT1023'),

(7, 'CO2012', 'PT1001'), (7, 'CO2013', 'PT1011'), (7, 'CO2014', 'PT1021'),
(8, 'CO2012', 'PT1002'), (8, 'CO2013', 'PT1012'), (8, 'CO2014', 'PT1022'),
(9, 'CO2012', 'PT1003'), (9, 'CO2013', 'PT1013'), (9, 'CO2014', 'PT1023');

--Dethi
INSERT INTO DE_THI(Ma_de_thi, So_luong_cau_hoi, Thoi_gian_lam_bai, Trich_Lan_thi, Trich_Mon_hoc, MSCB_ra_de, MSCB_duyet, Ngay_xac_nhan_ra_de, Ngay_duyet_de, Ngay_thi, Note) VALUES
('CO12A1101', 40, 60 , 1, 'CO2012', 'PT1001', 'QL1002', '2018-08-10', '2018-08-10', '2018-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1102', 40, 60 , 2, 'CO2012', 'PT1002', 'QL1002', '2018-09-11', '2018-09-11', '2018-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1103', 40, 60 , 3, 'CO2012', 'PT1003', 'QL1002', '2018-10-12', '2018-10-12', '2018-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1104', 40, 60 , 4, 'CO2012', 'PT1001', 'QL1002', '2019-08-10', '2019-08-10', '2019-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1105', 40, 60 , 5, 'CO2012', 'PT1002', 'QL1002', '2019-09-11', '2019-09-11', '2019-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1106', 40, 60 , 6, 'CO2012', 'PT1003', 'QL1002', '2019-10-12', '2019-10-12', '2019-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1107', 40, 60 , 7, 'CO2012', 'PT1001', 'QL1002', '2020-08-10', '2020-08-10', '2020-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1108', 40, 60 , 8, 'CO2012', 'PT1002', 'QL1002', '2020-09-11', '2020-09-11', '2020-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO12A1109', 40, 60 , 9, 'CO2012', 'PT1003', 'QL1002', '2020-10-12', '2020-10-12', '2020-10-12', 'Thi sinh khong duoc su dung tai lieu'),

('CO13A1101', 40, 60 , 1, 'CO2013', 'PT1011', 'QL1003', '2018-08-10', '2018-08-10', '2018-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1102', 40, 60 , 2, 'CO2013', 'PT1012', 'QL1003', '2018-09-11', '2018-09-11', '2018-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1103', 40, 60 , 3, 'CO2013', 'PT1013', 'QL1003', '2018-10-12', '2018-10-12', '2018-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1104', 40, 60 , 4, 'CO2013', 'PT1011', 'QL1003', '2019-08-10', '2019-08-10', '2019-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1105', 40, 60 , 5, 'CO2013', 'PT1012', 'QL1003', '2019-09-11', '2019-09-11', '2019-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1106', 40, 60 , 6, 'CO2013', 'PT1013', 'QL1003', '2019-10-12', '2019-10-12', '2019-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1107', 40, 60 , 7, 'CO2013', 'PT1011', 'QL1003', '2020-08-10', '2020-08-10', '2020-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1108', 40, 60 , 8, 'CO2013', 'PT1012', 'QL1003', '2020-09-11', '2020-09-11', '2020-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO13A1109', 40, 60 , 9, 'CO2013', 'PT1013', 'QL1003', '2020-10-12', '2020-10-12', '2020-10-12', 'Thi sinh khong duoc su dung tai lieu'),

('CO14A1101', 40, 60 , 1, 'CO2014', 'PT1021', 'QL1004', '2018-08-10', '2018-08-10', '2018-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1102', 40, 60 , 2, 'CO2014', 'PT1022', 'QL1004', '2018-09-11', '2018-09-11', '2018-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1103', 40, 60 , 3, 'CO2014', 'PT1023', 'QL1004', '2018-10-12', '2018-10-12', '2018-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1104', 40, 60 , 4, 'CO2014', 'PT1021', 'QL1004', '2019-08-10', '2019-08-10', '2019-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1105', 40, 60 , 5, 'CO2014', 'PT1022', 'QL1004', '2019-09-11', '2019-09-11', '2019-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1106', 40, 60 , 6, 'CO2014', 'PT1023', 'QL1004', '2019-10-12', '2019-10-12', '2019-10-12', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1107', 40, 60 , 7, 'CO2014', 'PT1021', 'QL1004', '2020-08-10', '2020-08-10', '2020-08-10', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1108', 40, 60 , 8, 'CO2014', 'PT1022', 'QL1004', '2020-09-11', '2020-09-11', '2020-09-11', 'Thi sinh khong duoc su dung tai lieu'),
('CO14A1109', 40, 60 , 9, 'CO2014', 'PT1023', 'QL1004', '2020-10-12', '2020-10-12', '2020-10-12', 'Thi sinh khong duoc su dung tai lieu');
GO

--Sinhvien
INSERT INTO SINH_VIEN(MSSV, Pass) VALUES ('1812438', '1'), ('1812439', '1'), ('1812440', '1'), ('1912438', '1'), ('1912439', '1'), ('1912440', '1'), ('2012438', '1'), ('2012439', '1'), ('2012440', '1');
GO

--Cauhoi
INSERT INTO CAU_HOI(Ma_cau_hoi, Vi_tri_dap_an_dung, MSCB_GV_tao, Thoi_gian_tao ,Ma_mon_hoc_thuoc, STTCDR, ID_phan_mo_ta) VALUES 
('CH20120001', 3, 'PT1001', '2018-08-09', 'CO2012', 1, NULL),
('CH20120002', 2, 'PT1002', '2018-08-09', 'CO2012', 1, NULL),
('CH20120003', 1, 'PT1003', '2018-08-09', 'CO2012', 1, NULL),
('CH20120004', 1, 'PT1001', '2018-08-09', 'CO2012', 2, NULL),
('CH20120005', 2, 'PT1002', '2018-08-09', 'CO2012', 2, NULL),
('CH20120006', 3, 'PT1003', '2018-08-09', 'CO2012', 2, NULL),
('CH20120007', 3, 'PT1001', '2018-08-09', 'CO2012', 3, NULL),
('CH20120008', 2, 'PT1002', '2018-08-09', 'CO2012', 3, NULL),
('CH20120009', 1, 'PT1003', '2018-08-09', 'CO2012', 3, NULL),

('CH20130001', 3, 'PT1011', '2018-08-09', 'CO2013', 1, NULL),
('CH20130002', 2, 'PT1012', '2018-08-09', 'CO2013', 1, NULL),
('CH20130003', 1, 'PT1013', '2018-08-09', 'CO2013', 1, NULL),
('CH20130004', 1, 'PT1011', '2018-08-09', 'CO2013', 2, NULL),
('CH20130005', 2, 'PT1012', '2018-08-09', 'CO2013', 2, NULL),
('CH20130006', 3, 'PT1013', '2018-08-09', 'CO2013', 2, NULL),
('CH20130007', 3, 'PT1011', '2018-08-09', 'CO2013', 3, NULL),
('CH20130008', 2, 'PT1012', '2018-08-09', 'CO2013', 3, NULL),
('CH20130009', 1, 'PT1013', '2018-08-09', 'CO2013', 3, NULL),

('CH20140001', 3, 'PT1021', '2018-08-09', 'CO2014', 1, NULL),
('CH20140002', 2, 'PT1022', '2018-08-09', 'CO2014', 1, NULL),
('CH20140003', 1, 'PT1023', '2018-08-09', 'CO2014', 1, NULL),
('CH20140004', 1, 'PT1021', '2018-08-09', 'CO2014', 2, NULL),
('CH20140005', 2, 'PT1022', '2018-08-09', 'CO2014', 2, NULL),
('CH20140006', 3, 'PT1023', '2018-08-09', 'CO2014', 2, NULL),
('CH20140007', 3, 'PT1021', '2018-08-09', 'CO2014', 3, NULL),
('CH20140008', 2, 'PT1022', '2018-08-09', 'CO2014', 3, NULL),
('CH20140009', 1, 'PT1023', '2018-08-09', 'CO2014', 3, NULL);
GO

--Lambai
INSERT INTO LAM_BAI(MSSV, Ma_de_thi, Ma_cau_hoi, Tra_loi, Note) VALUES 
('1812438', 'CO12A1101', 'CH20120001', 2, NULL),
('1812438', 'CO12A1101', 'CH20120002', 1, NULL),
('1812438', 'CO13A1101', 'CH20130001', 3, NULL),
('1812438', 'CO13A1102', 'CH20130002', 3, NULL),
('1812438', 'CO14A1101', 'CH20140001', 2, NULL),
('1812438', 'CO14A1102', 'CH20140002', 1, NULL);
GO

--TDTchuaCauhoi
INSERT INTO TAP_DE_THI_BAO_GOM_CAU_HOI(Lan_thi, Ma_mon_hoc_TDT, Ma_cau_hoi) VALUES 
(1, 'CO2012', 'CH20120001'),
(1, 'CO2012', 'CH20120004'),
(1, 'CO2012', 'CH20120007'),
(2, 'CO2012', 'CH20120002'),
(2, 'CO2012', 'CH20120005'),
(2, 'CO2012', 'CH20120008'),
(3, 'CO2012', 'CH20120003'),
(3, 'CO2012', 'CH20120006'),
(3, 'CO2012', 'CH20120009'),

(1, 'CO2013', 'CH20130001'),
(1, 'CO2013', 'CH20130004'),
(1, 'CO2013', 'CH20130007'),
(2, 'CO2013', 'CH20130002'),
(2, 'CO2013', 'CH20130005'),
(2, 'CO2013', 'CH20130008'),
(3, 'CO2013', 'CH20130003'),
(3, 'CO2013', 'CH20130006'),
(3, 'CO2013', 'CH20130009'),

(1, 'CO2014', 'CH20140001'),
(1, 'CO2014', 'CH20140004'),
(1, 'CO2014', 'CH20140007'),
(2, 'CO2014', 'CH20140002'),
(2, 'CO2014', 'CH20140005'),
(2, 'CO2014', 'CH20140008'),
(3, 'CO2014', 'CH20140003'),
(3, 'CO2014', 'CH20140006'),
(3, 'CO2014', 'CH20140009');


GO

--DTchuaCauhoi
INSERT INTO DE_THI_BAO_GOM_CAU_HOI(Ma_de_thi, Ma_cau_hoi, STTCH) VALUES 
('CO12A1101', 'CH20120001', 1), 
('CO12A1101', 'CH20120004', 2), 
('CO12A1101', 'CH20120007', 3), 
('CO12A1102', 'CH20120002', 1),
('CO12A1102', 'CH20120005', 2),
('CO12A1102', 'CH20120008', 3),
('CO12A1103', 'CH20120003', 1),
('CO12A1103', 'CH20120006', 2),
('CO12A1103', 'CH20120009', 3),

('CO13A1101', 'CH20130001', 1), 
('CO13A1101', 'CH20130004', 2), 
('CO13A1101', 'CH20130007', 3), 
('CO13A1102', 'CH20130002', 1),
('CO13A1102', 'CH20130005', 2),
('CO13A1102', 'CH20130008', 3),
('CO13A1103', 'CH20130003', 1),
('CO13A1103', 'CH20130006', 2),
('CO13A1103', 'CH20130009', 3),

('CO13A1101', 'CH20120001', 1), 
('CO13A1101', 'CH20120004', 2), 
('CO13A1101', 'CH20120007', 3), 
('CO13A1102', 'CH20120002', 1),
('CO13A1102', 'CH20120005', 2),
('CO13A1102', 'CH20120008', 3),
('CO13A1103', 'CH20120003', 1),
('CO13A1103', 'CH20120006', 2),
('CO13A1103', 'CH20120009', 3);

GO

--Phantraloi
INSERT INTO PHAN_TRA_LOI(Ma_cau_hoi, STT, Noi_dung) VALUES  
('CH20120001', 1, '1 + 2'), 
('CH20120001', 2, '2 + 3'), 
('CH20120001', 3, '3 + 4'), 
('CH20120001', 4, '4 + 5'),
('CH20120002', 1, '1 + 2'), 
('CH20120002', 2, '2 + 3'), 
('CH20120002', 3, '3 + 4'), 
('CH20120002', 4, '4 + 5'),
('CH20120003', 1, '1 + 2'),
('CH20120003', 2, '2 + 3'),
('CH20120003', 3, '3 + 4'),
('CH20120003', 4, '4 + 5'),
('CH20120004', 1, '1 + 2'), 
('CH20120004', 2, '2 + 3'), 
('CH20120004', 3, '3 + 4'), 
('CH20120004', 4, '4 + 5'),
('CH20120007', 1, '1 + 2'), 
('CH20120007', 2, '2 + 3'), 
('CH20120007', 3, '3 + 4'), 
('CH20120007', 4, '4 + 5'),

('CH20130001', 1, '1 + 2'), 
('CH20130001', 2, '2 + 3'), 
('CH20130001', 3, '3 + 4'), 
('CH20130001', 4, '4 + 5'),
('CH20130002', 1, '1 + 2'), 
('CH20130002', 2, '2 + 3'), 
('CH20130002', 3, '3 + 4'), 
('CH20130002', 4, '4 + 5'),
('CH20130003', 1, '1 + 2'),
('CH20130003', 2, '2 + 3'),
('CH20130003', 3, '3 + 4'),
('CH20130003', 4, '4 + 5'),

('CH20140001', 1, '1 + 2'), 
('CH20140001', 2, '2 + 3'), 
('CH20140001', 3, '3 + 4'), 
('CH20140001', 4, '4 + 5'),
('CH20140002', 1, '1 + 2'), 
('CH20140002', 2, '2 + 3'), 
('CH20140002', 3, '3 + 4'), 
('CH20140002', 4, '4 + 5'),
('CH20140003', 1, '1 + 2'),
('CH20140003', 2, '2 + 3'),
('CH20140003', 3, '3 + 4'),
('CH20140003', 4, '4 + 5');
GO

--Phancauhoi
INSERT INTO PHAN_CAU_HOI(Ma_cau_hoi, Noi_dung) VALUES 
('CH20120001' , '1 con vit xoe ra 1 cai canh'), ('CH20120002', '2 con vit xoe ra 2 cai canh'),
('CH20120003' , '3 con vit xoe ra 3 cai canh'), ('CH20120004', '4 con vit xoe ra 4 cai canh'),
('CH20120005' , '5 con vit xoe ra 5 cai canh'), ('CH20120006', '6 con vit xoe ra 6 cai canh'),
('CH20120007' , '7 con vit xoe ra 7 cai canh'), ('CH20120008', '8 con vit xoe ra 8 cai canh'),
('CH20120009' , '9 con vit xoe ra 9 cai canh'),

('CH20130001' , '1 con vit xoe ra 1 cai canh'), ('CH20130002', '2 con vit xoe ra 2 cai canh'),
('CH20130003' , '4 con vit xoe ra 8 cai canh'), ('CH20130004', '8 con vit xoe ra 4 cai canh'),
('CH20130005' , '4 con vit xoe ra 2 cai canh'), ('CH20130006', '2 con vit xoe ra 1 cai canh'),
('CH20130007' , '4 con vit xoe ra 2 cai canh'), ('CH20130008', '2 con vit xoe ra 1 cai canh'),
('CH20130009' , '4 con vit xoe ra 2 cai canh'),

('CH20140001' , '1 con vit xoe ra 2 cai canh'), ('CH20140002', '2 con vit xoe ra 4 cai canh'),
('CH20140003' , '4 con vit xoe ra 8 cai canh'), ('CH20140004', '8 con vit xoe ra 4 cai canh'),
('CH20140005' , '4 con vit xoe ra 2 cai canh'), ('CH20140006', '2 con vit xoe ra 1 cai canh'),
('CH20140007' , '4 con vit xoe ra 2 cai canh'), ('CH20140008', '2 con vit xoe ra 1 cai canh'),
('CH20140009' , '4 con vit xoe ra 2 cai canh');
GO

--Phanmotachung
INSERT INTO PHAN_MO_TA_CHUNG(ID_phan_mo_ta, Noi_dung) VALUES 
('20120102', 'Day se la noi dung cho 2 cau hoi tiep theo'), 
('20120304', 'Day se la noi dung cho 2 cau hoi tiep theo'),
('20130102', 'Day se la noi dung cho 2 cau hoi tiep theo'), 
('20130304', 'Day se la noi dung cho 2 cau hoi tiep theo'),
('20140102', 'Day se la noi dung cho 2 cau hoi tiep theo'), 
('20140304', 'Day se la noi dung cho 2 cau hoi tiep theo');
GO

--Filemota
INSERT INTO FILE_MO_TA(ID_FMT, URL_hinh_anh) VALUES  
('20120012', 'thisisURL'), ('20120034', 'thisisURL'),
('20130012', 'thisisURL'), ('20130034', 'thisisURL'),
('20140012', 'thisisURL'), ('20140034', 'thisisURL');
GO

--PTLchuaFMT
INSERT INTO PTL_CHUA_FMT(Ma_cau_hoi, STT, ID_FMT) VALUES 
('CH20120001', 1, '20120012'), ('CH20120002', 2, '20120012'),
('CH20120003', 3, '20120034'), ('CH20120003', 4, '20120034'),
('CH20130001', 1, '20130012'), ('CH20130002', 2, '20130012'),
('CH20130003', 3, '20130034'), ('CH20130003', 4, '20130034'),
('CH20140001', 1, '20140012'), ('CH20140002', 2, '20140012'),
('CH20140003', 3, '20140034'), ('CH20140003', 4, '20140034');
GO

--PCHchuaFMT
INSERT INTO PCH_CHUA_FMT(Ma_cau_hoi, ID_FMT) VALUES  
('CH20120001', '20120012'), ('CH20120002', '20120012'),
('CH20120003', '20120034'), ('CH20120004', '20120034');
GO

--PMTCchuaFMT
INSERT INTO PMTC_CHUA_FMT(ID_phan_mo_ta, ID_FMT) VALUES 
('20120102', '20120012'), ('20120304', '20120034'),
('20130102', '20130012'), ('20130304', '20130034'),
('20140102', '20140012'), ('20140304', '20140034');
GO



