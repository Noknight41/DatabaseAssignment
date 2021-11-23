CREATE DATABASE Ass2
GO
USE Ass2
GO

	CREATE TABLE MON_HOC (
		Ma_mon_hoc varchar(10) NOT NULL,
		Ten varchar(256) NOT NULL,
		CONSTRAINT MH_PK PRIMARY KEY (Ma_mon_hoc)
	); 
	GO

	CREATE TABLE GIANG_VIEN_PHU_TRACH (
		MSCB varchar(10) NOT NULL,
		Mon_hoc_phu_trach varchar(10) NOT NULL,
		Pass varchar(100) default '1',

		CONSTRAINT GVPT_FK FOREIGN KEY (Mon_hoc_phu_trach) REFERENCES 
			MON_HOC(Ma_mon_hoc) on delete no action on update cascade, 
		CONSTRAINT GVPT_PK PRIMARY KEY (MSCB)
	); 
	GO

	CREATE TABLE GIANG_VIEN_QUAN_LY (
		MSCB varchar(10) NOT NULL,
		Mon_hoc_quan_ly varchar(10) UNIQUE NOT NULL,
		Pass varchar(100) default '1',

		CONSTRAINT GVQL_FK FOREIGN KEY (Mon_hoc_quan_ly) REFERENCES 
			MON_HOC(Ma_mon_hoc) on delete no action on update cascade, 
		CONSTRAINT GVQL_PK PRIMARY KEY (MSCB)
	); 
	GO

	CREATE TABLE CHUAN_DAU_RA (
		STT int NOT NULL,
		Ten nvarchar(256) NOT NULL,
		Ma_mon_hoc varchar(10) NOT NULL,

		CONSTRAINT MHCDR FOREIGN KEY (Ma_mon_hoc) REFERENCES 
			MON_HOC(Ma_mon_hoc) on delete no action on update cascade,
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

		CONSTRAINT MHTDT FOREIGN KEY (Ma_mon_hoc_TDT) REFERENCES 
			MON_HOC(Ma_mon_hoc) on delete no action on update cascade,
		CONSTRAINT LT FOREIGN KEY (Lan_thi) REFERENCES 
			LAN_THI(Lan_thi) on delete no action on update cascade,
		CONSTRAINT GVTDT FOREIGN KEY (MSCB_xay_dung) REFERENCES GIANG_VIEN_PHU_TRACH(MSCB),
		CONSTRAINT IDTT PRIMARY KEY (Lan_thi, Ma_mon_hoc_TDT)
	); 
	GO

	CREATE TABLE DE_THI (
		Ma_de_thi varchar(10) NOT NULL,
		So_luong_cau_hoi int DEFAULT 0,
		Thoi_gian_lam_bai int NOT NULL,
		Trich_Lan_thi int NOT NULL,
		Trich_Mon_hoc varchar(10) NOT NULL,
		MSCB_ra_de varchar(10) NOT NULL,
		MSCB_duyet varchar(10),
		Ngay_xac_nhan_ra_de date,
		Ngay_duyet_de date,
		Ngay_thi date,
		Note nvarchar(2048) default '',

		CONSTRAINT TDTDT FOREIGN KEY (Trich_Lan_thi, Trich_Mon_hoc) REFERENCES 
			TAP_DE_THI(Lan_thi, Ma_mon_hoc_TDT) on delete no action on update cascade,
		CONSTRAINT GVPTDT FOREIGN KEY (MSCB_ra_de) REFERENCES 
			GIANG_VIEN_PHU_TRACH(MSCB),
		CONSTRAINT GVQLDT FOREIGN KEY (MSCB_duyet) REFERENCES 
			GIANG_VIEN_QUAN_LY(MSCB),
		CONSTRAINT IDDT PRIMARY KEY (Ma_de_thi)
	);
	GO

	CREATE TABLE SINH_VIEN(
		MSSV varchar(10) NOT NULL,
		Pass varchar(100) DEFAULT '1',
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

		CONSTRAINT GVtao FOREIGN KEY (MSCB_GV_tao) REFERENCES 
			GIANG_VIEN_PHU_TRACH(MSCB),
		CONSTRAINT CDR_thuoc FOREIGN KEY (STTCDR, Ma_mon_hoc_thuoc) REFERENCES 
			CHUAN_DAU_RA(STT, Ma_mon_hoc),
		CONSTRAINT key_cau_hoi PRIMARY KEY (Ma_cau_hoi)
	);
	GO

	CREATE TABLE LAM_BAI(
		MSSV varchar(10) NOT NULL,
		Ma_de_thi varchar(10) NOT NULL,
		STTCH int NOT NULL,
		Tra_loi int NOT NULL default 0,

		CONSTRAINT LamDE_THI FOREIGN KEY (Ma_de_thi) REFERENCES 
			DE_THI(Ma_de_thi) on delete no action on update cascade,
		CONSTRAINT SVlamde FOREIGN KEY (MSSV) REFERENCES 
			SINH_VIEN(MSSV) on delete no action on update cascade,
		CONSTRAINT Lamde PRIMARY KEY (MSSV, Ma_de_thi, STTCH)
	);
	GO

	CREATE TABLE NOTE(
		MSSV varchar(10) NOT NULL,
		Ma_de_thi varchar(10) NOT NULL,
		Note varchar(2048) default '',
		CONSTRAINT NoteDT FOREIGN KEY (Ma_de_thi) REFERENCES 
			DE_THI(Ma_de_thi) on delete no action on update cascade,
		CONSTRAINT NoteSV FOREIGN KEY (MSSV) REFERENCES 
			SINH_VIEN(MSSV) on delete no action on update cascade,
		CONSTRAINT NoteDe PRIMARY KEY (MSSV, Ma_de_thi)
	);
	GO

	CREATE TABLE TAP_DE_THI_BAO_GOM_CAU_HOI(
		Lan_thi int NOT NULL,
		Ma_mon_hoc_TDT varchar(10) NOT NULL,
		Ma_cau_hoi varchar(10) NOT NULL,

		CONSTRAINT TDT FOREIGN KEY (Lan_thi,Ma_mon_hoc_TDT) REFERENCES 
			TAP_DE_THI(Lan_thi, Ma_mon_hoc_TDT) on delete no action on update cascade,
		CONSTRAINT CHTDT FOREIGN KEY (Ma_cau_hoi) REFERENCES 
			CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
		CONSTRAINT TDTCH_PK PRIMARY KEY (Lan_thi,Ma_mon_hoc_TDT, Ma_cau_hoi)
	);
	GO

	CREATE TABLE DE_THI_BAO_GOM_CAU_HOI(
		Ma_de_thi				varchar(10) NOT NULL,
		Ma_cau_hoi				varchar(10) NOT NULL,
		STTCH					int NOT NULL,

		CONSTRAINT DT FOREIGN KEY (Ma_de_thi) REFERENCES 
			DE_THI(Ma_de_thi),
		CONSTRAINT CHDT FOREIGN KEY (Ma_cau_hoi) REFERENCES 
			CAU_HOI(Ma_cau_hoi),
		CONSTRAINT DTCH_PK PRIMARY KEY (Ma_de_thi, STTCH)
	);
	GO

	create table PHAN_TRA_LOI (
		Ma_cau_hoi				varchar(10)		NOT NULL,
		STT						int CHECK (STT >= 1 AND STT <= 5),
		Noi_dung				nvarchar(2048),

		CONSTRAINT PTL_FK FOREIGN KEY (Ma_cau_hoi) REFERENCES 
			CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
		CONSTRAINT PTL_PK PRIMARY KEY (Ma_cau_hoi, STT)
	);

	create table PHAN_CAU_HOI (
		Ma_cau_hoi				varchar(10)		NOT NULL UNIQUE,
		Noi_dung				nvarchar(2048),

		CONSTRAINT PCH_FK FOREIGN KEY (Ma_cau_hoi) references 
			CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
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
		CONSTRAINT PTL FOREIGN KEY (Ma_cau_hoi, STT) REFERENCES 
			PHAN_TRA_LOI(Ma_cau_hoi, STT) on delete no action on update cascade,
		CONSTRAINT PTLFMT FOREIGN KEY (ID_FMT) REFERENCES 
			FILE_MO_TA(ID_FMT) on delete no action on update cascade,
		CONSTRAINT PTLchuaPK PRIMARY KEY (Ma_cau_hoi, STT, ID_FMT)	
	);

	create table PCH_CHUA_FMT (
		Ma_cau_hoi				varchar(10) NOT NULL,
		ID_FMT					varchar(10) NOT NULL,
		CONSTRAINT PCH FOREIGN KEY (Ma_cau_hoi) REFERENCES 
			PHAN_CAU_HOI(Ma_cau_hoi) on delete no action on update cascade,
		CONSTRAINT PCHFMT FOREIGN KEY (ID_FMT) REFERENCES 
			FILE_MO_TA(ID_FMT) on delete no action on update cascade,
		CONSTRAINT PCHchuaPK PRIMARY KEY (Ma_cau_hoi, ID_FMT)
	);

	create table PMTC_CHUA_FMT (
		ID_phan_mo_ta			varchar(10) NOT NULL,
		ID_FMT					varchar(10) NOT NULL,
		CONSTRAINT PMTC FOREIGN KEY (ID_phan_mo_ta) REFERENCES 
			PHAN_MO_TA_CHUNG(ID_phan_mo_ta) on delete no action on update cascade,
		CONSTRAINT PMTCFMT FOREIGN KEY (ID_FMT) REFERENCES 
			FILE_MO_TA(ID_FMT) on delete no action on update cascade,
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

