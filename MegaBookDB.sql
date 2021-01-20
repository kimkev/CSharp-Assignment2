GO
USE MegaBookDB



GO
CREATE TABLE [dbo].[BOOKS](
	[Name]			[nvarchar](50)		NOT NULL,
	[Author]		[nvarchar](50)		NOT NULL,
	[PublishDate]   [date]				NOT NULL,
	[ISBN]			[nvarchar](20)		NOT NULL,
	[Id]			[smallint]			IDENTITY(1,1)		PRIMARY KEY NOT NULL)


CREATE TABLE [dbo].[REVIEWS](
	[Reviewer]		[nvarchar](50)		NOT NULL,
	[Review]		[nvarchar](50)		NOT NULL,
	[Id]			[smallint]			IDENTITY(1,1)		NOT NULL,
	[Date]			[date]				NOT NULL,
	[Rating]		[smallint]			NULL,
	[BookID]		[smallint]			FOREIGN KEY REFERENCES [dbo].[BOOKS](Id) NOT NULL)
