USE [EmployeeDB]
GO

/****** Object:  StoredProcedure [dbo].[Get_Departments]    Script Date: 26 Feb 2019 20:47:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Get_Departments]
@Dept nvarchar(MAX) = NULL
AS
BEGIN
SELECT * FROM dbo.Departments a WITH(NOLOCK)
WHERE (DepartmentId = @Dept OR @Dept IS NULL)
ORDER BY SeqNo
END
GO


