create database DangKyHocLai
go
use DangKyHocLai
go

create table TaiKhoanDangNhap
(
	TaiKhoan varchar(100) primary key,
	MatKhau varchar(50),
	Quyen varchar(50) 
)

create table GiangVien
(
	MaGV nvarchar(50) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3),
	DienThoai varchar(20),
	Email varchar(150)
)

create table SinhVien
(
	MaSV nvarchar(50) primary key, 
	HoTen nvarchar(50),
	GioiTinh nvarchar(3),
	NgaySinh date,
	DiaChi nvarchar(150),
	DienThoai varchar(20),
	Email varchar(150),
	TaiKhoan varchar(100)
)

create table Lop
(
	MaKiemSoat varchar(100) primary key,
	MaLop varchar(100),
	MaSV nvarchar(50)
)

Create table MonHoc
(
	MaMH nvarchar(50) primary key, 
	TenMH nvarchar(50),
	TinChi int
)

create table DSDangKy
(
	MaKiemSoat nvarchar(50) primary key,
	MaMH nvarchar(50),
	MaGV nvarchar(50)
)

create table DangKyMon
(
	MaDK varchar(50) primary key,
	MaMH nvarchar(50),
	MaGV nvarchar(50),
	MaSV nvarchar(50),
	NgayDK date

	CONSTRAINT FK_DangKyMon_MonHoc FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH),
	CONSTRAINT FK_DangKyMon_SinhVien FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
)

Create table Diem
(
	MaDiem nvarchar(50) primary key,
	MaMH nvarchar(50),
	MaGV nvarchar(50),
	MaSV nvarchar(50),
	DiemQT float,
	DiemThi float,
)

-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------

-- tạo tài khoản
insert into TaiKhoanDangNhap (TaiKhoan, MatKhau, Quyen) values
('ad','123','admin'),
('sv','123','sinhvien'),
('sv2','123','sinhvien'),
('sv3','123','sinhvien'),
('sv4','123','sinhvien')


-- tạo giảng viên
insert into GiangVien(MaGV, HoTen, NgaySinh, GioiTinh, DienThoai, Email) values
('GV001', N'Nguyễn Mỹ Tuyến', '1987/10/5', N'Nữ', '090000001', '001@gmail.com'),
('GV002', N'Trần Minh Thanh', '1982/1/25', N'Nam', '090000002', '002@gmail.com'),
('GV003', N'Phạm Hữu Trang Nhã', '1990/7/12', N'Nữ', '090000003', '003@gmail.com'),
('GV004', N'Trần Thị Bích Trâm', '1985/5/22', N'Nữ', '090000004', '004@gmail.com'),
('GV005', N'Trần Trung Định', '1979/11/5', N'Nam', '090000005', '005@gmail.com'),
('GV006', N'Báo Tăng Tuy', '1983/4/17', N'Nam', '090000006', '006@gmail.com'),
('GV007', N'Trần Văn Thanh', '1988/10/2', N'Nam', '090000007', '007@gmail.com'),
('GV008', N'Đoàn Thị Mai Uyên', '1987/1/30', N'Nữ', '090000008', '008@gmail.com'),
('GV009', N'Phạm Thị Xuân Mai', '1986/9/28', N'Nữ', '090000009', '009@gmail.com'),
('GV010', N'Nguyễn Bao Công', '1981/8/19', N'Nam', '090000010', '010@gmail.com'),
('GV011', N'Phùng Anh Đức', '1990/2/1', N'Nam', '090000011', '011@gmail.com'),
('GV012', N'Huỳnh Phan Nguyên', '1986/6/6', N'Nam', '090000012', '012@gmail.com'),
('GV013', N'Nguyễn Thị Minh Thanh', '1984/4/4', N'Nữ', '090000013', '013@gmail.com'),
('GV014', N'Từ Ngọc Trí', '1985/9/27', N'Nam', '090000014', '014@gmail.com'),
('GV015', N'Vũ Khánh Tình Vân', '1989/3/3', N'Nữ', '090000015', '015@gmail.com'),
('GV016', N'Hà Tiến Dũng', '1991/11/11', N'Nam', '090000016', '016@gmail.com'),
('GV017', N'Khư Lam Cảnh', '1984/2/24', N'Nam', '090000017', '017@gmail.com'),
('GV018', N'Đặng Văn Trung', '1988/12/8', N'Nam', '090000018', '018@gmail.com')


-- Tạo sinh viên có sẵn
insert into SinhVien(MaSV, HoTen, GioiTinh, NgaySinh , DiaChi, DienThoai, Email, TaiKhoan) values
('085008001', N'Nhan Quốc Phương',  N'Nam', '2001/2/28', N'6 Tân Sơn, Phường 15, Tân Bình', '091000001', 'SV001@gmail.com', 'sv'),
('085008002', N'Châu Hải Long',  N'Nam', '2001/1/1', N'2 Hải Triều, Bến Nghé, Quận 1', '092000002', 'SV002@gmail.com', 'sv2'),
('085008003', N'Mai Tuyết Hân',  N'Nữ', '2001/12/31', N'772 Điện Biên Phủ, Phường 1, Bình Thạnh', '093000003', 'SV003@gmail.com', 'sv3'),
('085008004', N'Lưu Xuân Uyên',  N'Nữ', '2001/12/31', N'262 Lạc Long Quân, Phường 5, Quận 11', '094000004', 'SV004@gmail.com', 'sv4')


-- Tạo dữ liệu có sẵn
insert into Lop(MaKiemSoat, MaLop, MaSV) values
('2CNTT1', '08_CNTT_02', '085008001'),
('1CNTT1', '08_CNTT_01', '085008002'),
('3CNTT1', '08_CNTT_03', '085008003')


-- Tạo môn học có sẵn
insert into MonHoc(MaMH, TenMH, TinChi) values
('111313006', N'Anh văn 1', 3),
('170113004', N'Kiến trúc máy tính', 2),
('121113010', N'Triết học Mác - Lênin', 3),
('111113008', N'Toán cao cấp 1', 2),
('17031070', N'Anh văn chuyên ngành', 3),
('17031005', N'Mạch số', 3),
('17011032', N'Xử lý ảnh', 2),
('17031112', N'Lập trình cơ bản', 3),
('11111006', N'Phương pháp tính', 2),
('17031009', N'Lý thuyết đồ thị', 2),
('11111009', N'Toán cao cấp 2', 3),
('17011024', N'Phân tích và thiết kế hệ thống', 3),
('17011030', N'Quản trị mạng', 3),
('17011026', N'Thiết kế web', 2),
('17011019', N'Hệ quản trị cơ sở dữ liệu', 2),
('17011014', N'Ngôn ngữ Java', 2),
('17011062', N'Cơ sở dữ liệu nâng cao', 3),
('17011033', N'Lập trình đồ họa máy tính', 2)


-- Tạo dữ liệu có sẵn
insert into DSDangKy(MaKiemSoat, MaMH, MaGV) values
('AV1GV1', '111313006', 'GV001'), 
('KTMTGV2', '170113004', 'GV002'), 
('THMLNGV3', '121113010', 'GV003'), 
('TCC1GV4', '111113008', 'GV004'), 
('AVCNGV5', '17031070', 'GV005'), 
('MSGV6', '17031005', 'GV006'), 
('XLAGV7', '17011032', 'GV007'), 
('LTCBGV8', '17031112', 'GV008'), 
('PPTGV9', '11111006', 'GV009'),
('LTDTGV10', '17031009', 'GV010'), 
('TCC2GV11', '11111009', 'GV011'), 
('PTTKHTGV12', '17011024', 'GV012'), 
('QTMGV13', '17011030', 'GV013'), 
('TKWGV14', '17011026', 'GV014'),
('HQTCSDLGV15', '17011019', 'GV015'), 
('NNJVGV16', '17011014', 'GV016'),
('CSDLNCGV17', '17011062', 'GV017'),
('LTDHHMTGV18', '17011033', 'GV018') 


-- Tạo dữ liệu có sẵn
insert into DangKyMon(MaDK, MaMH, MaGV, MaSV, NgayDK) values
('DK001', '111313006','GV001', '085008001', '2021/02/25'),
('DK002', '170113004','GV002', '085008001', '2021/02/25'),
('DK003', '121113010','GV003', '085008001', '2021/02/25'),
('DK004', '111113008','GV004', '085008001', '2021/02/25'),
('DK005', '17031070','GV005', '085008001', '2021/02/25'),
('DK006', '17031005','GV006', '085008001', '2021/02/25'),
('DK007', '17011032','GV007', '085008001', '2021/02/25'),
('DK008', '17031112','GV008', '085008001', '2021/02/27'),
('DK009', '11111006','GV009', '085008001', '2021/02/27'),
('DK010', '17031009','GV010', '085008001', '2021/03/01'),
('DK011', '11111009','GV011', '085008002', '2021/02/25'),
('DK012', '17011024','GV012', '085008003', '2021/02/25'),
('DK013', '17011030','GV013', '085008004', '2021/02/25'),
('DK014', '111313006','GV001', '085008002', '2021/02/25'),
('DK015', '111313006','GV001', '085008003', '2021/02/25'),
('DK016', '170113004','GV002', '085008003', '2021/02/25'),
('DK017', '170113004','GV002', '085008004', '2021/02/25')


-- Tạo dữ liệu có sẵn
insert into Diem(MaDiem, MaMH, MaGV, MaSV, DiemQT, DiemThi) values
('D1', '111313006', 'GV001', '085008001', 7, 7),
('D2', '170113004', 'GV002', '085008001', 3, 5),
('D3', '121113010', 'GV003', '085008001', 5, 2),
('D4', '111113008', 'GV004', '085008001', 9, 4),
('D5', '17031070', 'GV005', '085008001', 7, 2),
('D6', '17031005', 'GV006', '085008001', 6, 4),
('D7', '17011032', 'GV007', '085008001', 6, 3),
('D8', '17031112', 'GV008', '085008001', 8, 8),
('D9', '11111006', 'GV009', '085008001', 6, 6),
('D10', '17031009', 'GV010', '085008001', 5, 7)

-- Select * from GiangVien
-- Select * from SinhVien
-- Select * from Lop
-- Select * from MonHoc
-- Select * from DangKyMon
-- Select * from PhanCong
-- Select * from Diem
-- Select * from DangNhap
-- Tô đen bỏ phần --  rồi nhấn Ctrl E để hiện bảng