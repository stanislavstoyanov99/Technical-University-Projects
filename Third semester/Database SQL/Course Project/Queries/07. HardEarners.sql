SELECT TOP (3) CONCAT(m.FirstName, ' ', m.LastName) AS Mechanic, 
               COUNT(j.JobId) AS Jobs
FROM Mechanics AS m
     LEFT JOIN Jobs AS j ON m.MechanicId = j.MechanicId
GROUP BY m.FirstName, 
         m.LastName, 
         m.MechanicId, 
         j.[Status]
HAVING COUNT(j.JobId) > 1
       AND j.[Status] <> 'Finished'
ORDER BY Jobs DESC, 
         m.MechanicId

