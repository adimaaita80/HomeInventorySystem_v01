Create Database PersonalShopping
Go

Use PersonalShopping
Go

Create Table SystemUsers
(
	UserId int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Username nvarchar(50),
	Password nvarchar(50)
)
Go

Create Table Items
(
	ItemId int PRIMARY KEY IDENTITY(1,1),
	ItemName nvarchar(200),
	Unit nvarchar(50),
	Quantity float,
	UserId int

	FOREIGN KEY (UserId) REFERENCES SystemUsers(UserId)
)
Go

