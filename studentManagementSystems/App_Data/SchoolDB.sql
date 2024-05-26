
CREATE DATABASE SchoolDB;
GO


USE SchoolDB;
GO


CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY IDENTITY,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentID)
        REFERENCES Students(StudentID),
    CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseID)
        REFERENCES Courses(CourseID)
);
GO

INSERT INTO Students (Name) VALUES
('John Doe'),
('Jane Smith'),
('Michael Johnson');
GO


INSERT INTO Courses (Title) VALUES
('Mathematics'),
('Science'),
('History');
GO

INSERT INTO Enrollments (StudentID, CourseID) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 1);
GO
