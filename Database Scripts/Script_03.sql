USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 26 Feb 2019 20:47:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeId] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[DateOfBirth] [nvarchar](max) NULL,
	[Sex] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DepartmentId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

INSERT INTO [dbo].[Employees](EmployeeId,FirstName,LastName,DateOfBirth,Sex,Email,DepartmentId)VALUES('020387512437','John','WICK','1987-03-02','M','jsnow@example.co.za','ADMN')
INSERT INTO [dbo].[Employees](EmployeeId,FirstName,LastName,DateOfBirth,Sex,Email,DepartmentId)VALUES('091176453489','Frank','Castle','1976-11-09','M','fcastle@example.co.za','SAL')
INSERT INTO [dbo].[Employees](EmployeeId,FirstName,LastName,DateOfBirth,Sex,Email,DepartmentId)VALUES('020566512445','Nicole','Grey','1966-05-02','M','jsnow@example.co.za','IT')

