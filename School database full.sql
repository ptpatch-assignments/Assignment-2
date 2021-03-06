USE [School]
GO
/****** Object:  Table [dbo].[Assignments]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[AssID] [int] IDENTITY(1,1) NOT NULL,
	[Descript] [nvarchar](510) NULL,
	[SubDate] [date] NULL,
	[OralMark] [int] NULL,
	[TotalMark] [int] NULL,
 CONSTRAINT [PK_Ass] PRIMARY KEY CLUSTERED 
(
	[AssID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssPerCourse]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssPerCourse](
	[AssID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_APC] PRIMARY KEY CLUSTERED 
(
	[AssID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Stream] [nvarchar](255) NULL,
	[CourseType] [nvarchar](255) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[DateOfBirth] [date] NULL,
	[TuitionFees] [decimal](10, 2) NULL,
	[CourseID] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsPerCourse]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsPerCourse](
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_SPC] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainers]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainers](
	[TrainerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[Stream] [nvarchar](255) NULL,
 CONSTRAINT [PK_Trainers] PRIMARY KEY CLUSTERED 
(
	[TrainerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrainersPerCourse]    Script Date: 11/05/2020 09:37:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainersPerCourse](
	[TrainerID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_TPC] PRIMARY KEY CLUSTERED 
(
	[TrainerID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Assignments] ON 

INSERT [dbo].[Assignments] ([AssID], [Descript], [SubDate], [OralMark], [TotalMark]) VALUES (1, N'First thing', CAST(N'2018-10-01' AS Date), 100, 100)
INSERT [dbo].[Assignments] ([AssID], [Descript], [SubDate], [OralMark], [TotalMark]) VALUES (2, N'Second thing', CAST(N'2019-12-05' AS Date), 100, 100)
INSERT [dbo].[Assignments] ([AssID], [Descript], [SubDate], [OralMark], [TotalMark]) VALUES (3, N'Third thing', CAST(N'2020-04-15' AS Date), 100, 100)
SET IDENTITY_INSERT [dbo].[Assignments] OFF
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseID], [Title], [Stream], [CourseType], [StartDate], [EndDate]) VALUES (1, N'CB5', N'Java', N'Part Time', CAST(N'2016-12-05' AS Date), CAST(N'2017-05-05' AS Date))
INSERT [dbo].[Courses] ([CourseID], [Title], [Stream], [CourseType], [StartDate], [EndDate]) VALUES (2, N'CB6', N'C#', N'Full Time', CAST(N'2017-05-12' AS Date), CAST(N'2017-08-12' AS Date))
INSERT [dbo].[Courses] ([CourseID], [Title], [Stream], [CourseType], [StartDate], [EndDate]) VALUES (3, N'CB15', N'Python', N'Part Time', CAST(N'2023-10-01' AS Date), CAST(N'2024-04-01' AS Date))
INSERT [dbo].[Courses] ([CourseID], [Title], [Stream], [CourseType], [StartDate], [EndDate]) VALUES (4, N'CBT10', N'Java', N'Part Time', CAST(N'2019-10-20' AS Date), CAST(N'2020-04-22' AS Date))
INSERT [dbo].[Courses] ([CourseID], [Title], [Stream], [CourseType], [StartDate], [EndDate]) VALUES (5, N'CBT13', N'Python', N'Full Time', CAST(N'2022-09-15' AS Date), CAST(N'2022-12-15' AS Date))
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (2, N'Kostantinos', N'Marinatos', CAST(N'2000-11-01' AS Date), CAST(2500.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (3, N'Marina', N'Niarxou', CAST(N'2002-05-16' AS Date), CAST(2000.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (4, N'Ernesto', N'Liam', CAST(N'2005-10-23' AS Date), CAST(2500.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (11, N'Maria', N'Kalogeropoulou', CAST(N'2000-12-15' AS Date), CAST(2100.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (16, N'Xristos', N'Magoras', CAST(N'1995-05-12' AS Date), CAST(1950.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (17, N'Alekos', N'Baxantouridis', CAST(N'1998-12-25' AS Date), CAST(1900.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (18, N'Katerina', N'Vlaxaki', CAST(N'2001-04-07' AS Date), CAST(2500.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (21, N'Ion', N'Amigdalou', CAST(N'1999-01-11' AS Date), CAST(2500.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Students] ([StudentID], [FirstName], [LastName], [DateOfBirth], [TuitionFees], [CourseID]) VALUES (22, N'Antonis', N'Vrisis', CAST(N'1995-11-20' AS Date), CAST(2100.00 AS Decimal(10, 2)), 4)
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (2, 1)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (3, 2)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (4, 2)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (11, 5)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (16, 4)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (17, 3)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (18, 1)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (21, 2)
INSERT [dbo].[StudentsPerCourse] ([StudentID], [CourseID]) VALUES (22, 4)
SET IDENTITY_INSERT [dbo].[Trainers] ON 

INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (1, N'Pakos', N'Pakou', N'C#')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (2, N'Makis', N'Makou', N'Java')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (3, N'Natalia', N'Marika', N'Python')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (4, N'Maria', N'Mpaksevani', N'Java')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (5, N'Giorgos', N'Polixronis', N'C#')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (6, N'Xristos', N'Europoulos', N'Python')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (7, N'Marina', N'Tsanti', N'Java')
INSERT [dbo].[Trainers] ([TrainerID], [FirstName], [LastName], [Stream]) VALUES (8, N'Panagiota', N'Tsantali', N'C#')
SET IDENTITY_INSERT [dbo].[Trainers] OFF
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (1, 2)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (2, 1)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (3, 3)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (4, 4)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (5, 2)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (6, 5)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (7, 1)
INSERT [dbo].[TrainersPerCourse] ([TrainerID], [CourseID]) VALUES (8, 2)
ALTER TABLE [dbo].[AssPerCourse]  WITH CHECK ADD FOREIGN KEY([AssID])
REFERENCES [dbo].[Assignments] ([AssID])
GO
ALTER TABLE [dbo].[AssPerCourse]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[StudentsPerCourse]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[StudentsPerCourse]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[TrainersPerCourse]  WITH CHECK ADD FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([CourseID])
GO
ALTER TABLE [dbo].[TrainersPerCourse]  WITH CHECK ADD FOREIGN KEY([TrainerID])
REFERENCES [dbo].[Trainers] ([TrainerID])
GO
