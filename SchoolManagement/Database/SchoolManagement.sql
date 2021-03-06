USE [SchoolManagement]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/20/2021 12:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Malayalam] [int] NOT NULL,
	[English] [int] NOT NULL,
	[Maths] [int] NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](10) NOT NULL,
	[Color] [varchar](20) NULL,
	[Top] [int] NULL,
	[Left] [int] NULL,
 CONSTRAINT [PK__Student__3214EC07605D5295] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Malayalam], [English], [Maths], [Username], [Password], [Color], [Top], [Left]) VALUES (1, N'Arya', 80, 70, 65, N'arya', N'arya1996', N'-16776961', 223, 217)
INSERT [dbo].[Student] ([Id], [Name], [Malayalam], [English], [Maths], [Username], [Password], [Color], [Top], [Left]) VALUES (2, N'Manu', 90, 80, 70, N'manu', N'manu1996', N'-65536', 0, 0)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF__Student__Color__32E0915F]  DEFAULT ('-65536') FOR [Color]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF__Student__TopOfse__33D4B598]  DEFAULT ('0') FOR [Top]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF__Student__LeftOf__34C8D9D1]  DEFAULT ('0') FOR [Left]
GO
/****** Object:  StoredProcedure [dbo].[SetColor]    Script Date: 3/20/2021 12:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SetColor]
	@Id	INT
	,	@Color VARCHAR(20)
AS
BEGIN
UPDATE [dbo].[Student]
	SET [Color]=@Color
	WHERE [Id]=@Id
	
END
GO
/****** Object:  StoredProcedure [dbo].[StudentLogin]    Script Date: 3/20/2021 12:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StudentLogin]
	@Username VARCHAR(20)
	,	@Password	VARCHAR(10)
AS
BEGIN
SELECT*
FROM	[dbo].[Student]
WHERE [Username]=@Username and [Password]=@Password
	
END
GO
/****** Object:  StoredProcedure [dbo].[StudentRegister]    Script Date: 3/20/2021 12:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[StudentRegister]
	@Name	VARCHAR(20)
	,	@Malayalam	INT
	,	@English	INT
	,	@Maths		INT
	,	@Username	VARCHAR(20)
	,	@Password	VARCHAR(10)
AS
BEGIN
INSERT INTO [dbo].[Student]
(
	[Name]
	,	[Malayalam]
	,	[English]
	,	[Maths]
	,	[Username]
	,	[Password]
)
VALUES
(
	@Name
	,	@Malayalam
	,	@English
	,	@Maths
	,	@Username
	,	@Password
	)
	
	
		
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWindowPosition]    Script Date: 3/20/2021 12:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateWindowPosition]
	@Id INT
	,	@Top INT
	,	@Left INT
AS
BEGIN
UPDATE 	[dbo].[Student]
SET [Top]=@Top,
[Left]=@Left
WHERE [Id]=@Id

END
GO
