SELECT * FROM Students;  -- List of all students

SELECT * FROM Trainers;  -- List of all trainers

SELECT * FROM Courses;   -- List of all courses

SELECT * FROM Assignments;  -- List of all Assignments

-- List of all students per course

SELECT * FROM Students as s
INNER JOIN StudentsPerCourse AS spc on s.CourseID = spc.CourseID  

-- List of all trainers per course

SELECT * FROM Trainers AS t
INNER JOIN TrainersPerCourse AS tpc ON t.TrainerID = tpc.CourseID

-- List of all assignments per course

SELECT * FROM Assignments AS a
INNER JOIN AssPerCourse AS apc ON a.AssID = apc.AssID

-- List of students that belong to more than one courses

SELECT FirstName, LastName FROM Students
INNER JOIN StudentsPerCourse AS spc ON Students.StudentID = spc.StudentID
GROUP BY FirstName, LastName, Students.StudentID HAVING COUNT(DISTINCT spc.CourseID) >= 2
