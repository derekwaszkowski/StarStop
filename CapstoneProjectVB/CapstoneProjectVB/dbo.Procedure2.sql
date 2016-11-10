CREATE PROCEDURE dbo.StoredProcedure2
	@param1 int = 0,
	@param2 date = null
AS
	SELECT Date, DayOfYear, Day, Week, Month, Year, KindOfDay
	From Auxiliary.Calendar
	Where Date BETWEEN @param2 And DATEADD(week, @param1, @param2)

Return
