-- First exercise
GO
CREATE VIEW AverageGradeForStudents
AS
     SELECT CAST(AVG(se.Grade) AS DECIMAL(4, 3)) AS [AverageGrade]
     FROM StudentsExams AS se
GO

SELECT * FROM AverageGradeForStudents

-- Second exercise
GO
CREATE OR ALTER PROCEDURE usp_AverageGradeForCurrentStudent(@FacultyNumber INT)
AS
  SELECT s.FirstName, 
         s.LastName, 
         CAST(AVG(se.Grade) AS DECIMAL(4, 3)) AS [AverageGrade]
    FROM StudentsExams AS se
          JOIN Students AS s ON se.StudentId = s.Id
   WHERE s.FacultyNumber = @FacultyNumber
GROUP BY s.Id, 
         s.FirstName, 
         s.LastName

exec dbo.usp_AverageGradeForCurrentStudent 471218066

GO

-- Third exercise
GO
CREATE OR ALTER FUNCTION ufn_AverageGrade(@FacultyNumber INT)
RETURNS DECIMAL(4,3)
BEGIN
	DECLARE @averageGrade DECIMAL(4, 3);

	SELECT @averageGrade = CAST(AVG(se.Grade) AS DECIMAL(4, 3))  
      FROM StudentsExams AS se
           JOIN Students AS s ON se.StudentId = s.Id
     WHERE s.FacultyNumber = @FacultyNumber
  GROUP BY s.Id

	RETURN @averageGrade;
END
GO

SELECT dbo.ufn_AverageGrade(471218066) AS Result
SELECT dbo.ufn_AverageGrade(471218055) AS Result