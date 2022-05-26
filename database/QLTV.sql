CREATE DATABASE QLTV
GO
USE QLTV
GO

CREATE TABLE TaiKhoan
(
	TenTK VARCHAR(30) CONSTRAINT PK_TenTK PRIMARY KEY NOT NULL,
	MatKhau VARCHAR(30) NOT NULL,
	LoaiTK BIT NOT NULL,
	HoTen NVARCHAR(60),
	NgaySinh DATE,
	GioiTinh BIT,
	CCCD CHAR(12),
	QueQuan NVARCHAR(200)
)

INSERT TaiKhoan VALUES
('admin', 'admin', '1', NULL, NULL, NULL, NULL, NULL),
('johnweak', 'dog123', '0', N'John Wick', '12/10/2002', '1', '123456789000', N'123 Wal Shrek, New York'),
('thiLan', 'vanDiep', '1', N'Nguyễn Thị Lan', '10/12/2002', '0', '987654321000', N'67 Bạch Đằng, Đống Đa, Hà Nội')

CREATE TABLE Sach
(
	MaSach INT CONSTRAINT PK_MaSach PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenSach NVARCHAR(150),
	TacGia NVARCHAR(150),
	NXB NVARCHAR(150),
	Gia FLOAT,
	SoLuong INT
)

INSERT Sach(TenSach, TacGia, NXB, Gia, SoLuong) VALUES
(N'Mười vạn câu hỏi vì sao', N'Phạm Hoài', N'Thanh Niên', '150000', '10'),
(N'Ngựa vằn kỳ thú', N'Lê Bôn', N'Kim Nguyên', '100000', '20'),
(N'Xác suất và sự thành công', N'Thomas Edinsone', N'Kim Đồng', '250000', '20'),
(N'Cuộc đời của huyền thoại Muhammad Ali', N'Mike Tyson', N'Kungfu BL', '350000', '20'),
(N'Biển bạc', N'Thanh Thảo', N'Kim Nguyên', '120000', '20')