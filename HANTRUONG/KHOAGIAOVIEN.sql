Create table GIAOVIEN
(
	MAGV char(10),
	HOTEN nchar(50),
	PHAI char(10),
	NGSINH date,
	DIENTHOAI int,
	CMND int,
	DIACHI nchar(50),
	MABM char(10),
	MAKHOA char(10)
	constraint PK_GIAOVIEN
	primary key  (MAGV)
)
create table KHOA
(
	MAKHOA char(10),
	TENKHOA nchar(50),
	PHONG char(10),
	DIENTHOAI int,
	TRUONGKHOA char(10),
	constraint PK_KHOA
	primary key (MAKHOA)
)
