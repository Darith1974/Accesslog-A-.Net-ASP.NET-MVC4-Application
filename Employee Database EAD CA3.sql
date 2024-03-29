USE [master]
GO
/****** Object:  Database [Employee]    Script Date: 02/17/2013 15:45:12 ******/
CREATE DATABASE [Employee] ON  PRIMARY 
( NAME = N'Employee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Employee.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Employee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Employee_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Employee] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Employee] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Employee] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Employee] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Employee] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Employee] SET ARITHABORT OFF
GO
ALTER DATABASE [Employee] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Employee] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Employee] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Employee] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Employee] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Employee] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Employee] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Employee] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Employee] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Employee] SET  DISABLE_BROKER
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Employee] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Employee] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Employee] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Employee] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Employee] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Employee] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Employee] SET  READ_WRITE
GO
ALTER DATABASE [Employee] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Employee] SET  MULTI_USER
GO
ALTER DATABASE [Employee] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Employee] SET DB_CHAINING OFF
GO
USE [Employee]
GO
/****** Object:  Table [dbo].[CompanyPosition]    Script Date: 02/17/2013 15:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyPosition](
	[GradeID] [int] IDENTITY(1,1) NOT NULL,
	[JobDescription] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Salary] [money] NOT NULL,
 CONSTRAINT [PK_CompanyPosition] PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CompanyPosition] ON
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (1, N'Engineer', N'Engineering', 24000.0000)
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (2, N'Clerk', N'Admin', 23000.0000)
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (3, N'Manager', N'Admin', 26000.0000)
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (4, N'Manager', N'Engineering', 25000.0000)
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (5, N'Clerk', N'Engineering', 20000.0000)
INSERT [dbo].[CompanyPosition] ([GradeID], [JobDescription], [Department], [Salary]) VALUES (6, N'test11', N'test11', 10000.0000)
SET IDENTITY_INSERT [dbo].[CompanyPosition] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 02/17/2013 15:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Town] [nvarchar](50) NOT NULL,
	[County] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[GradeID] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (2, N'David', N'Flynn', N'Drumcondra', N'Dublin', N'Dublin', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (4, N'Sandra', N'Flynn', N'Drumcndra', N'Dublin`', N'Ireland', 2)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (5, N'PAul', N'Flynn', N'Finglas', N'Dublin', N'Ireland', 3)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (6, N'Gary', N'Murphy', N'Santry', N'Dublin', N'Ireland', 4)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (7, N'Matthew', N'Gogarty', N'Phibsboro', N'Dublin', N'Ireland', 5)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (8, N'Niall', N'Byrne', N'Templelogue', N'Dublin', N'Ireland', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (9, N'Sean', N'Fox', N'Finglas', N'Dublin', N'Ireland', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (10, N'Sarah', N'Cox', N'Raheny', N'Dublin', N'Ireland', 3)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (16, N'DetailsTest', N'DetailsTest', N'DetailsTest', N'DetailsTest', N'DetailsTest', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (17, N'DetailsTest', N'DetailsTest', N'DetailsTest', N'DetailsTest', N'DetailsTest', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (18, N'EditTest', N'EditTest', N'EditTest', N'EditTest', N'EditTest', 1)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Surname], [Town], [County], [Country], [GradeID]) VALUES (19, N'EditTest', N'EditTest', N'EditTest', N'EditTest', N'EditTest', 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  Table [dbo].[Log]    Script Date: 02/17/2013 15:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[LogId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[EnterDateTime] [datetime] NULL,
	[LeaveDateTime] [datetime] NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Log] ON
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (1, 2, CAST(0x00009FCF00F8ABC4 AS DateTime), CAST(0x00009FCF0119A144 AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (12, 5, CAST(0x00009FCF00FE2A04 AS DateTime), CAST(0x00009FCF0100E924 AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (13, 6, CAST(0x00009FCF00B6C0C4 AS DateTime), CAST(0x00009FCF00C73B84 AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (14, 7, CAST(0x00009FCF0095CB44 AS DateTime), CAST(0x00009FCF00A79658 AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (15, 8, CAST(0x00009FCF00855084 AS DateTime), CAST(0x00009FCF0095CB44 AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (16, 8, CAST(0x00009FEC00840ABC AS DateTime), CAST(0x00009FEC0094857C AS DateTime))
INSERT [dbo].[Log] ([LogId], [EmployeeId], [EnterDateTime], [LeaveDateTime]) VALUES (18, 16, CAST(0x0000A04900000000 AS DateTime), CAST(0x0000A04A00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Log] OFF
/****** Object:  ForeignKey [FK_Employee_CompanyPosition]    Script Date: 02/17/2013 15:45:16 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_CompanyPosition] FOREIGN KEY([GradeID])
REFERENCES [dbo].[CompanyPosition] ([GradeID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_CompanyPosition]
GO
/****** Object:  ForeignKey [FK_Log_Employee]    Script Date: 02/17/2013 15:45:16 ******/
ALTER TABLE [dbo].[Log]  WITH CHECK ADD  CONSTRAINT [FK_Log_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Log] CHECK CONSTRAINT [FK_Log_Employee]
GO
