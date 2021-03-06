CREATE DATABASE LibMan
GO
USE LibMan
GO

CREATE TABLE Role
(
	ID INT CONSTRAINT PK_RoleID PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(50)
)

INSERT Role(Name) VALUES
(N'Đọc giả'),
(N'Thủ thư'),
(N'Quản trị viên')

CREATE TABLE Account
(
	Username VARCHAR(30) CONSTRAINT PK_Username PRIMARY KEY NOT NULL,
	Password VARCHAR(30) NOT NULL,
	RoleID INT CONSTRAINT FK_RoleID FOREIGN KEY REFERENCES Role(ID) NOT NULL,
	Fullname NVARCHAR(60),
	Birthday DATE,
	Gender BIT,
	ID VARCHAR(12) CONSTRAINT UN_ID UNIQUE,
	Address NVARCHAR(255),
	Status BIT
)

INSERT Account(Username, Password, RoleID, Fullname, Birthday, Gender, ID, Address, Status) VALUES
	('admin', 'admin', '3', N'Phạm Văn Vinh', '1/1/2002', '1', '4351050443', N'Trường Đại học Quy Nhơn', '1'),
	('lib', 'lib', '2', N'Hồ Quý', '1/12/2000', '0', '987654321111', N'23 Bùi Thị Xuân, Đống Đa, Hà Nội', '1'),
	('johnweak', 'doeg123', '1', N'John Wick', '12/10/2002', '1', '123456789000', N'123 Wal Shrek, New York', '1'),
	('jasonmama', 'seaman', '1', N'Jason Mamoa', '8/1/1999', '1', '123456789001', N'123 Shrimpon, Alaska', '1'),
	('thiLan', 'vanDiep', '2', N'Nguyễn Thị Lan', '10/12/2002', '0', '987654321000', N'67 Bạch Đằng, Đống Đa, Hà Nội', '0'),
	('hoaiLam123', 'doilabekho', '2', N'Trần Hoài Lâm', '1/12/2000', '1', '987654321101', N'23 Bùi Thị Xuân, Đống Đa, Hà Nội', '1')

CREATE TABLE Catalog
(
	ID INT CONSTRAINT PK_CatalogID PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name NVARCHAR(50) CONSTRAINT UN_CatalogName UNIQUE NOT NULL,
)

INSERT Catalog(Name) VALUES
	(N'Động vật'),
	(N'Khoa học'),
	(N'Toán học'),
	(N'Võ thuật'),
	(N'Văn học')

CREATE TABLE Book
(
	ID INT CONSTRAINT PK_MaSach PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title NVARCHAR(255),
	CatalogID INT CONSTRAINT FK_CatalogID FOREIGN KEY REFERENCES Catalog(ID) ON DELETE SET NULL,
	Author NVARCHAR(100),
	Publisher NVARCHAR(150)
)

INSERT Book(Title, CatalogID, Author, Publisher) VALUES
	(N'Mười vạn câu hỏi vì sao', '2', N'Phạm Hoài', N'Thanh Niên'),
	(N'Ngựa vằn kỳ thú', '1', N'Lê Bôn', N'Kim Nguyên'),
	(N'Xác suất và sự thành công', '3', N'Thomas Edinsone', N'Kim Đồng'),
	(N'Cuộc đời của huyền thoại Muhammad Ali', '4', N'Mike Tyson', N'Kungfu BL'),
	(N'Biển bạc', '5', N'Thanh Thảo', N'Kim Nguyên')

CREATE TABLE Loan
(
	ID INT CONSTRAINT PK_LoanID PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Username VARCHAR(30) CONSTRAINT FK_Username FOREIGN KEY REFERENCES Account(Username) ON DELETE CASCADE NOT NULL,
	BookID INT CONSTRAINT FK_BookID FOREIGN KEY REFERENCES Book(ID) ON DELETE CASCADE NOT NULL,
	LoanDate DATE NOT NULL,
	DueDate DATE NOT NULL
)

INSERT Loan(Username, BookID, LoanDate, DueDate) VALUES
	('jasonmama', '4', '6/24/2022', '6/29/2022'),
	('jasonmama', '3', '6/24/2022', '6/29/2022'),
	('johnweak', '1', '6/25/2022', '6/30/2022'),
	('johnweak', '5', '6/25/2022', '7/1/2022')


CREATE TABLE Returned
(
	ID INT CONSTRAINT PK_ReturnedID PRIMARY KEY IDENTITY(1,1) NOT NULL,
	LoanID INT CONSTRAINT FK_LoanID FOREIGN KEY REFERENCES Loan(ID) ON DELETE CASCADE NOT NULL,
	Date DATE,
	Fee FLOAT
)

INSERT Returned(LoanID, Date, Fee) VALUES
	('1', '6/29/2022', '0'),
	('2', '6/30/2022', '5000'),
	('3', '6/26/2022', '0'),
	('4', '6/29/2022', '0')