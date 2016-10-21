CREATE PROCEDURE dbo.StoredProcedure1
	@param1 int = 0,
	@param2 date = 0
AS
	SELECT Date, DayOfYear, Day, Week, Month, Year, KindOfDay
	From Auxiliary.Calendar
	Where Date = @param2

Return 0