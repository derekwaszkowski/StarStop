﻿CREATE PROCEDURE dbo.StoredProcedure1
	@param1 int = 0,
	@param2 date = null
AS
	SELECT Date, DayOfYear, Day, Week, Month, Year, KindOfDay
	From Auxiliary.Calendar
	Where Date Between @param2 AND (@param2 + (@param1 * 7))

Return