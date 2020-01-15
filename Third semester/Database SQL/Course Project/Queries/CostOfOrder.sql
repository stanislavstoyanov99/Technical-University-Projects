CREATE FUNCTION udf_GetCost(@jobId INT)
RETURNS DECIMAL(8, 2)
AS
  BEGIN
      DECLARE @totalCost DECIMAL(8, 2);

      SELECT @totalCost = SUM(p.Price * op.Quantity)
      FROM Jobs AS j
           LEFT JOIN Orders AS o ON o.JobId = j.JobId
           LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
           LEFT JOIN Parts AS p ON p.PartId = op.PartId
	  WHERE j.JobId = @jobId
      IF(@totalCost IS NULL)
          BEGIN
              SET @totalCost = 0;
		  END;
      RETURN @totalCost;
  END

SELECT dbo.udf_GetCost(1) AS [Result]