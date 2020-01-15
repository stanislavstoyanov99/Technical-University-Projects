SELECT SUM(p.Price * op.Quantity) AS [Parts Total]
FROM Parts AS p
     LEFT JOIN OrderParts AS op ON p.PartId = op.PartId
     LEFT JOIN Orders AS o ON op.OrderId = o.OrderId
WHERE DATEDIFF(WEEK, o.IssueDate, '2017-04-24') <= 3