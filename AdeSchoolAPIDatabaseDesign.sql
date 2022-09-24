CREATE TABLE [Students] (
  [StudentId] uniqueidentifier PRIMARY KEY,
  [FirstName] varchar(50),
  [MiddleName] varchar(50),
  [LastName] varchar(50),
  [DateOfBirth] datetime,
  [StateOfOrigin] integer,
  [ClassroomId] uniqueidentifier
)
GO

CREATE TABLE [Classrooms] (
  [ClassroomId] uniqueidentifier PRIMARY KEY,
  [Name] varchar(50)
)
GO

CREATE TABLE [Teachers] (
  [TeacherId] uniqueidentifier PRIMARY KEY,
  [FirstName] varchar(50),
  [MiddleName] varchar(50),
  [LastName] nvarchar(255),
  [Title] integer,
  [SubjectId] uniqueidentifier
)
GO

CREATE TABLE [Subjects] (
  [SubjectId] uniqueidentifier PRIMARY KEY,
  [Name] varchar(50)
)
GO

CREATE TABLE [Results] (
  [ResultId] uniqueidentifier PRIMARY KEY,
  [StudentId] uniqueidentifier,
  [TeacherId] uniqueidentifier,
  [Grade] integer,
  [SubjectId] uniqueidentifier
)
GO
ALTER TABLE [Students] ADD FOREIGN KEY ([ClassroomId]) REFERENCES [Classrooms] ([ClassroomId])
GO

CREATE TABLE [Students_Teachers] (
  [Students_Teachers] uniqueidentifier NOT NULL,
  [Teachers_Students] uniqueidentifier NOT NULL,
  PRIMARY KEY ([Students_Teachers], [Teachers_Students])
);
GO

ALTER TABLE [Students_Teachers] ADD FOREIGN KEY ([Students_Teachers]) REFERENCES [Students] ([StudentId]);
GO

ALTER TABLE [Students_Teachers] ADD FOREIGN KEY ([Teachers_Students]) REFERENCES [Teachers] ([TeacherId]);
GO


CREATE TABLE [Students_Subjects] (
  [Students_Subjects] uniqueidentifier NOT NULL,
  [Subjects_Students] uniqueidentifier NOT NULL,
  PRIMARY KEY ([Students_Subjects], [Subjects_Students])
);
GO

ALTER TABLE [Students_Subjects] ADD FOREIGN KEY ([Students_Subjects]) REFERENCES [Students] ([StudentId]);
GO

ALTER TABLE [Students_Subjects] ADD FOREIGN KEY ([Subjects_Students]) REFERENCES [Subjects] ([SubjectId]);
GO


ALTER TABLE [Results] ADD FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId])
GO

CREATE TABLE [Teachers_Classrooms] (
  [Teachers_Classrooms] uniqueidentifier NOT NULL,
  [Classrooms_Teachers] uniqueidentifier NOT NULL,
  PRIMARY KEY ([Teachers_Classrooms], [Classrooms_Teachers])
);
GO

ALTER TABLE [Teachers_Classrooms] ADD FOREIGN KEY ([Teachers_Classrooms]) REFERENCES [Teachers] ([TeacherId]);
GO

ALTER TABLE [Teachers_Classrooms] ADD FOREIGN KEY ([Classrooms_Teachers]) REFERENCES [Classrooms] ([ClassroomId]);
GO


ALTER TABLE [Results] ADD FOREIGN KEY ([TeacherId]) REFERENCES [Teachers] ([TeacherId])
GO

ALTER TABLE [Teachers] ADD FOREIGN KEY ([SubjectId]) REFERENCES [Subjects] ([SubjectId])
GO

ALTER TABLE [Results] ADD FOREIGN KEY ([SubjectId]) REFERENCES [Subjects] ([SubjectId])
GO
