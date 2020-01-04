   SELECT [Status], IssueDate
     FROM Jobs
    WHERE [Status] = 'In Progress' OR [Status] = 'Pending'
 ORDER BY IssueDate, JobId