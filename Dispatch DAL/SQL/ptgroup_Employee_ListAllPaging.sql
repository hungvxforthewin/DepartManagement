use [Dispatch]
go
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ptgroup_Employee_ListAllPaging]') and ObjectProperty(id, N'IsProcedure') = 1)
	drop procedure [dbo].[ptgroup_Employee_ListAllPaging]
go

-- =============================================
-- Author: Auto Generator
-- Create date: 2/16/2017
-- Description:	The procedure select all record with paging for Employee table.
-- =============================================
create procedure [dbo].[ptgroup_Employee_ListAllPaging]

(
@pageIndex int,
@pageSize int,
@totalRow int output
)

as

set nocount on

DECLARE @UpperBand int, @LowerBand int

SELECT @totalRow = COUNT(*) FROM Employee

SET @LowerBand  = (@pageIndex - 1) * @PageSize
SET @UpperBand  = (@pageIndex * @PageSize)

SELECT  [Id],
	[DepartmentId],
	[FirstName],
	[LastName],
	[Address],
	[Phone],
	[PictureId],
	[IsActive],
	[IsDel],
	[CreatedDate],
	[ModifiedDate]
 FROM(SELECT *, ROW_NUMBER() OVER(ORDER BY Id ASC) AS RowNumber FROM Employee WITH (NOLOCK)) AS temp
WHERE RowNumber > @LowerBand AND RowNumber <= @UpperBand
go
