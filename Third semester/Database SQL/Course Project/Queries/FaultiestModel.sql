SELECT TOP (1) WITH TIES m.[Name] AS [Model], 
                         COUNT(j.JobId) AS [Times Serviced], 
(
    SELECT ISNULL(SUM(p.Price * op.Quantity), 0)
    FROM Orders AS o
         LEFT JOIN Jobs AS j ON j.JobId = o.JobId
         LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
         LEFT JOIN Parts AS p ON p.PartId = op.PartId
    WHERE j.ModelId = m.ModelId
) AS [Parts Total]
FROM Models AS m
     LEFT JOIN Jobs AS j ON j.ModelId = m.ModelId
GROUP BY m.ModelId, 
         m.[Name]
ORDER BY [Times Serviced] DESC