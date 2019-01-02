USE [DevOps]
GO

INSERT INTO [dbo].[ST_Mocked_Project_List]
           ([Name]
           ,[Project_To_Access_Group]
           ,[Created_By]
           ,[Updated_By]
           ,[Created_Date]
           ,[Updated_Date]
           ,[Description])
     VALUES
           ('ACReditPlus',
		   1,
		   'cxu',
		   'cxu',
		   GETDATE(),
		   GETDATE(),
		   'Test No.1')
GO


