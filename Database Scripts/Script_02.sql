USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Departments]    Script Date: 26 Feb 2019 20:46:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Departments](
	[DepartmentId] [nvarchar](128) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[SeqNo] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

INSERT INTO [dbo].[Departments]([DepartmentId],[Description],[SeqNo])VALUES('ALL','All Departments',1)
INSERT INTO [dbo].[Departments]([DepartmentId],[Description],[SeqNo])VALUES('ADMN','Administration',2)
INSERT INTO [dbo].[Departments]([DepartmentId],[Description],[SeqNo])VALUES('IT','IT',3)
INSERT INTO [dbo].[Departments]([DepartmentId],[Description],[SeqNo])VALUES('SAL','Sales',4)
