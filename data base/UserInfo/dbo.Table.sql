CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login_Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [LName] NVARCHAR(50) NULL, 
    [FName] NVARCHAR(50) NULL, 
    [Status ] NTEXT NULL, 
    [Last_Login_Date] DATE NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Location] INT NULL, 
    [Location_GPS] [sys].[geography] NULL
)
