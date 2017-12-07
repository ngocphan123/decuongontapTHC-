/*Tạo cơ  sở dữ liệu*/
CREATE DATABASE SINHVIEN_05
/*Tạo bảng sinh viên*/
CREATE TABLE sinhvien(masv nvarchar(50) primary key, ten nvarchar(50), gioitinh nvarchar(50),lop nvarchar(50))
/*Tạo dữ liệu cho bảng sinh viên*/
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV01',N'Phan Thị Ngọc', N'Nữ','D8CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV02',N'Nguyễn Thị A', N'Nam','D8CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV03',N'Trần Thị K', N'Nữ','D9CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV04',N'Phan Thị M', N'Nữ','D9CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV05',N'Nguyễn Văn X', N'Nam','D8CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV06',N'Trần Văn N', N'Nam','D9CPM')
INSERT INTO sinhvien(masv,ten, gioitinh, lop ) Values('SV07',N'Nguyễn Văn A', N'Nam','D8CPM')

/*Hiển thị danh sách lớp theo yêu cầu*/
 SELECT 
t1.lop, Nữ, Nam, Nữ+Nam as Tổng
FROM
(SELECT lop, count(gioitinh) AS Nữ
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nữ' GROUP BY lop) t1 
INNER JOIN
(SELECT lop, count(gioitinh) AS Nam
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nam' GROUP BY lop) t2
ON t1.lop = t2.lop

/*Tìm lớp có tổng số nam ít nhất*/
 SELECT 
t1.lop, Nữ, Nam, Nữ+Nam as Tổng
FROM
(SELECT lop, count(gioitinh) AS Nữ
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nữ' GROUP BY lop) t1 
INNER JOIN
(SELECT lop, count(gioitinh) AS Nam
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nam' GROUP BY lop) t2
ON t1.lop = t2.lop WHERE Nam = (SELECT 
Min(Nam)
FROM
(SELECT lop, count(gioitinh) AS Nữ
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nữ' GROUP BY lop) t1 
INNER JOIN
(SELECT lop, count(gioitinh) AS Nam
  FROM [SINHVIEN_05].[dbo].[sinhvien] WHERE gioitinh=N'Nam' GROUP BY lop) t2
ON t1.lop = t2.lop)