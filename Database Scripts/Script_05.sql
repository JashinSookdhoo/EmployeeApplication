USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[EmployeeByDept]    Script Date: 26 Feb 2019 20:47:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EmployeeByDept]
@Dept nvarchar(MAX) = NULL
AS
BEGIN
SELECT a.EmployeeId,a.FirstName,a.LastName,a.DateOfBirth, Sex = CASE WHEN a.Sex = 'M' THEN 'Male' ELSE 'Female' END,a.Email,a.DepartmentId, b.[Description]  FROM dbo.Employees a WITH(NOLOCK)
INNER JOIN dbo.Departments b WITH(NOLOCK) ON a.DepartmentId = b.DepartmentID
WHERE (a.DepartmentId = @Dept OR @Dept IS NULL)
END
GO


