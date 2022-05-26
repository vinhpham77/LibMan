CREATE DATABASE LibMan
GO
USE LibMan
GO

CREATE TABLE AccountType
(
	AccountTypeID INT CONSTRAINT PK_AccountTypeID PRIMARY KEY NOT NULL,
	AccountTypeName NVARCHAR(60) NOT NULL
)

INSERT AccountType VALUES
('0', N'Đọc giả'),
('1', N'Thủ thư'),
('2', N'Quản lý')

CREATE TABLE Account
(
	Username VARCHAR(30) CONSTRAINT PK_TenTK PRIMARY KEY NOT NULL,
	Password VARCHAR(30) NOT NULL,
	AccountTypeID INT CONSTRAINT FK_AccountTypeID FOREIGN KEY REFERENCES AccountType(AccountTypeID) ON UPDATE CASCADE ON DELETE CASCADE NOT NULL,
	Fullname NVARCHAR(60),
	Birthday DATE,
	Gender BIT,
	UserID CHAR(12) CONSTRAINT UN_ID UNIQUE,
	Address NVARCHAR(200)
)

INSERT Account VALUES
('admin', 'admin', '2', NULL, NULL, NULL, NULL, NULL),
('johnweak', 'dog123', '0', N'John Wick', '12/10/2002', '1', '123456789000', N'123 Wal Shrek, New York'),
('thiLan', 'vanDiep', '1', N'Nguyễn Thị Lan', '10/12/2002', '0', '987654321000', N'67 Bạch Đằng, Đống Đa, Hà Nội')

CREATE TABLE BookType
(
	BookTypeID INT CONSTRAINT PK_BookTypeID PRIMARY KEY IDENTITY(1,1) NOT NULL,
	BookTypeName NVARCHAR(100) CONSTRAINT UN_BookTypeName UNIQUE,
)

INSERT BookType(BookTypeName) VALUES
(N'Khoa học'),
(N'Thiên nhiên'),
(N'Toán học'),
(N'Võ thuật'),
(N'Văn học')

CREATE TABLE Book
(
	BookID INT CONSTRAINT PK_MaSach PRIMARY KEY NOT NULL IDENTITY(1,1),
	BookName NVARCHAR(150),
	BookTypeID INT CONSTRAINT FK_BookTypeID REFERENCES BookType(BookTypeID) ON UPDATE CASCADE ON DELETE SET NULL,
	Authors NVARCHAR(150),
	Publisher NVARCHAR(150),
	Price FLOAT,
	Quantity INT
)

INSERT Book(BookName, BookTypeID, Authors, Publisher, Price, Quantity) VALUES
(N'Mười vạn câu hỏi vì sao', '1', N'Phạm Hoài', N'Thanh Niên', '150000', '10'),
(N'Ngựa vằn kỳ thú', '2', N'Lê Bôn', N'Kim Nguyên', '100000', '20'),
(N'Xác suất và sự thành công', '3', N'Thomas Edinsone', N'Kim Đồng', '250000', '20'),
(N'Cuộc đời của huyền thoại Muhammad Ali', '4', N'Mike Tyson', N'Kungfu BL', '350000', '20'),
(N'Biển bạc', '5', N'Thanh Thảo', N'Kim Nguyên', '120000', '20')