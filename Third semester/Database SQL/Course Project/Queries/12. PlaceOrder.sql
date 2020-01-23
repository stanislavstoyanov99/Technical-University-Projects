CREATE PROCEDURE usp_PlaceOrder
(
	@jobId INT,
    @partSerialNumber VARCHAR(50),
    @quantity INT
)
AS
BEGIN
	-- Намираме дадената поръчка и част.
	DECLARE @partId INT = (SELECT PartId FROM Parts WHERE SerialNumber = @partSerialNumber);
	DECLARE @orderId INT = (SELECT TOP (1) OrderId FROM Orders WHERE JobId = @jobId AND IssueDate IS NULL);

	-- Проверяваме дали количеството е в допустимите стойности.
    IF(@quantity <= 0)
	BEGIN
		;THROW 50012, 'Количеството на частта не може да бъде по-малко или равно на нула!', 1
	END

	-- Проверяваме дали има такъв работен казус със статус 'Завършен'
	IF((SELECT JobId FROM Jobs WHERE JobId = @jobId AND [Status] = 'Finished') IS NOT NULL) 
	BEGIN
		;THROW 50011, 'Работният казус не е активен!', 1
	END

	-- Проверяваме дали съществува такъв работен казус в базата
	IF((SELECT JobId FROM Jobs WHERE JobId = @jobId) IS NULL)
	BEGIN
		;THROW 50013, 'Не е намерен работен казус в базата!', 1
	END

	-- Проверяваме дали съществува такава част в базата
	IF(@partId IS NULL)
	BEGIN
		;THROW 50014, 'Не е намерена част в базата!', 1
	END

	-- Ако няма такава поръчка, я създаваме. След това я добавяме в Orders и OrderParts.
	IF(@orderId IS NULL)
	BEGIN
		-- Delivered има стойност по подразбиране. За начална дата задаваме NULL стойност.
		INSERT INTO Orders(JobId, IssueDate) VALUES
		(@jobId, NULL)

		-- Взимаме поредния номер на вече добавената поръчка
		DECLARE @id INT = (SELECT TOP 1 OrderId FROM Orders WHERE JobId = @jobId);

		INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES
		(@id, @partId, @quantity)
	END
	ELSE
	BEGIN
		-- Ако съществува такава поръчка за дадения работен казус, т.е имаме @orderId и @partId в OrderParts, трябва да ъпдейтнем нейното количество.
		IF((SELECT OrderId FROM OrderParts WHERE OrderId = @orderId AND PartId = @partId) IS NOT NULL)
		BEGIN
			UPDATE OrderParts
			SET Quantity += @quantity
			WHERE OrderId = @orderId AND PartId = @partId
		END
		ELSE
		-- Ако съществува такъв @orderId в базата, но не съществува такава част, съответно добавяме поръчката отново в OrderParts.
		BEGIN
			INSERT INTO OrderParts(OrderId, PartId, Quantity) VALUES
			(@orderId, @partId, @quantity)
		END
	END
END

-- Тестване на процедурата
DECLARE @err_msg AS NVARCHAR(MAX);

BEGIN TRY
-- Изпълнение на процедурата
EXEC usp_PlaceOrder 1, 'ZeroQuantity', 0
END TRY

BEGIN CATCH
SET @err_msg = ERROR_MESSAGE();
SELECT @err_msg AS [Result]
END CATCH