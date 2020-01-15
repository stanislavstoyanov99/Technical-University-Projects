CREATE PROCEDURE usp_PlaceOrder
(
	@jobId INT,
    @partSerialNumber VARCHAR(50),
    @quantity INT
)
AS
BEGIN
	DECLARE @partId INT = (SELECT PartId FROM Parts WHERE SerialNumber = @partSerialNumber);
	DECLARE @orderId INT = (SELECT TOP (1) OrderId FROM Orders WHERE JobId = @jobId AND IssueDate IS NULL);

	IF((SELECT JobId FROM Jobs WHERE JobId = @jobId AND [Status] = 'Finished') IS NOT NULL)
	BEGIN
		;THROW 50011, 'The job is not active', 1
	END

	-- TODO
END