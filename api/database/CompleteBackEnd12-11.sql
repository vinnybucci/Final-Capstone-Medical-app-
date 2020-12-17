USE [master]
GO

--drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

/****** Object:  Database [final_capstone]    Script Date: 12/11/2020 4:17:28 PM ******/
CREATE DATABASE [final_capstone]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'final_capstone', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\final_capstone.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'final_capstone_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\final_capstone_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [final_capstone] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [final_capstone].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [final_capstone] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [final_capstone] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [final_capstone] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [final_capstone] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [final_capstone] SET ARITHABORT OFF 
GO
ALTER DATABASE [final_capstone] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [final_capstone] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [final_capstone] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [final_capstone] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [final_capstone] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [final_capstone] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [final_capstone] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [final_capstone] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [final_capstone] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [final_capstone] SET  ENABLE_BROKER 
GO
ALTER DATABASE [final_capstone] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [final_capstone] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [final_capstone] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [final_capstone] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [final_capstone] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [final_capstone] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [final_capstone] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [final_capstone] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [final_capstone] SET  MULTI_USER 
GO
ALTER DATABASE [final_capstone] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [final_capstone] SET DB_CHAINING OFF 
GO
ALTER DATABASE [final_capstone] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [final_capstone] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [final_capstone] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [final_capstone] SET QUERY_STORE = OFF
GO
USE [final_capstone]
GO
/****** Object:  Table [dbo].[addresses]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addresses](
	[addressId] [int] IDENTITY(1,1) NOT NULL,
	[streetAddress] [varchar](100) NOT NULL,
	[streetAddress2] [varchar](50) NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zip] [int] NOT NULL,
 CONSTRAINT [PK_addresses] PRIMARY KEY CLUSTERED 
(
	[addressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointments]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointments](
	[apptId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[doctorId] [int] NOT NULL,
	[officeId] [int] NOT NULL,
	[date] [date] NOT NULL,
	[time] [time](7) NOT NULL,
	[message] [varchar](300) NULL,
	[virtual] [bit] NOT NULL,
	[status] [varchar](10) NOT NULL,
 CONSTRAINT [PK_appointments] PRIMARY KEY CLUSTERED 
(
	[apptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[daysOfTheWeek]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[daysOfTheWeek](
	[dayId] [int] IDENTITY(1,1) NOT NULL,
	[day] [varchar](15) NOT NULL,
 CONSTRAINT [PK_daysOfTheWeek] PRIMARY KEY CLUSTERED 
(
	[dayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[userId] [int] NOT NULL,
	[hourlyRate] [decimal](19, 2) NULL,
	[firstName] [varchar](35) NULL,
	[lastName] [varchar](50) NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor_day]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_day](
	[doc_day_id] [int] NOT NULL,
	[doctorId] [int] NOT NULL,
	[dayId] [int] IDENTITY(1,1) NOT NULL,
	[officeId] [int] NOT NULL,
	[availability] [time](7) NOT NULL,
 CONSTRAINT [PK_doctor_office_1] PRIMARY KEY CLUSTERED 
(
	[doc_day_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[office]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[office](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[phone] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_office] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[office_address]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[office_address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[officeId] [int] NOT NULL,
	[addressId] [int] NOT NULL,
 CONSTRAINT [PK_office_address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[office_day]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[office_day](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[officeId] [int] NOT NULL,
	[dayId] [int] NOT NULL,
	[startTime] [time](0) NOT NULL,
	[endTime] [time](0) NOT NULL,
 CONSTRAINT [PK_office_day] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[officeReviews]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[officeReviews](
	[reviewId] [int] NOT NULL,
	[officeId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[message] [varchar](300) NOT NULL,
	[rating] [int] NOT NULL,
	[anonymous] [bit] NOT NULL,
 CONSTRAINT [PK_officeReviews] PRIMARY KEY CLUSTERED 
(
	[reviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_address]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_address](
	[Id] [int] NOT NULL,
	[addressId] [int] NOT NULL,
	[patientId] [int] NOT NULL,
 CONSTRAINT [PK_patient_address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[patientId] [int] NOT NULL,
	[firstName] [varchar](30) NULL,
	[lastName] [varchar](50) NULL,
	[phone] [int] NULL,
	[email] [varchar](75) NULL,
	[dateOfBirth] [datetime] NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviewResponses]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviewResponses](
	[responseId] [int] NOT NULL,
	[reviewId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[message] [varchar](300) NULL,
 CONSTRAINT [PK_reviewResponses] PRIMARY KEY CLUSTERED 
(
	[responseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/11/2020 4:17:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password_hash] [varchar](200) NOT NULL,
	[salt] [varchar](200) NOT NULL,
	[user_role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD  CONSTRAINT [FK_appointments_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([userId])
GO
ALTER TABLE [dbo].[appointments] CHECK CONSTRAINT [FK_appointments_doctor]
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD  CONSTRAINT [FK_appointments_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO
ALTER TABLE [dbo].[appointments] CHECK CONSTRAINT [FK_appointments_office]
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD  CONSTRAINT [FK_appointments_patients] FOREIGN KEY([patientId])
REFERENCES [dbo].[patients] ([patientId])
GO
ALTER TABLE [dbo].[appointments] CHECK CONSTRAINT [FK_appointments_patients]
GO
ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_users]
GO
ALTER TABLE [dbo].[doctor_day]  WITH CHECK ADD  CONSTRAINT [FK_doctor_day_daysOfTheWeek] FOREIGN KEY([dayId])
REFERENCES [dbo].[daysOfTheWeek] ([dayId])
GO
ALTER TABLE [dbo].[doctor_day] CHECK CONSTRAINT [FK_doctor_day_daysOfTheWeek]
GO
ALTER TABLE [dbo].[doctor_day]  WITH CHECK ADD  CONSTRAINT [FK_doctor_day_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([userId])
GO
ALTER TABLE [dbo].[doctor_day] CHECK CONSTRAINT [FK_doctor_day_doctor]
GO
ALTER TABLE [dbo].[doctor_day]  WITH CHECK ADD  CONSTRAINT [FK_doctor_day_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO
ALTER TABLE [dbo].[doctor_day] CHECK CONSTRAINT [FK_doctor_day_office]
GO
ALTER TABLE [dbo].[office_address]  WITH CHECK ADD  CONSTRAINT [FK_office_address_addresses] FOREIGN KEY([addressId])
REFERENCES [dbo].[addresses] ([addressId])
GO
ALTER TABLE [dbo].[office_address] CHECK CONSTRAINT [FK_office_address_addresses]
GO
ALTER TABLE [dbo].[office_address]  WITH CHECK ADD  CONSTRAINT [FK_office_address_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO
ALTER TABLE [dbo].[office_address] CHECK CONSTRAINT [FK_office_address_office]
GO
ALTER TABLE [dbo].[office_day]  WITH CHECK ADD  CONSTRAINT [FK_office_day_daysOfTheWeek] FOREIGN KEY([dayId])
REFERENCES [dbo].[daysOfTheWeek] ([dayId])
GO
ALTER TABLE [dbo].[office_day] CHECK CONSTRAINT [FK_office_day_daysOfTheWeek]
GO
ALTER TABLE [dbo].[office_day]  WITH CHECK ADD  CONSTRAINT [FK_office_day_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO
ALTER TABLE [dbo].[office_day] CHECK CONSTRAINT [FK_office_day_office]
GO
ALTER TABLE [dbo].[officeReviews]  WITH CHECK ADD  CONSTRAINT [FK_officeReviews_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO
ALTER TABLE [dbo].[officeReviews] CHECK CONSTRAINT [FK_officeReviews_office]
GO
ALTER TABLE [dbo].[officeReviews]  WITH CHECK ADD  CONSTRAINT [FK_officeReviews_patients] FOREIGN KEY([userId])
REFERENCES [dbo].[patients] ([patientId])
GO
ALTER TABLE [dbo].[officeReviews] CHECK CONSTRAINT [FK_officeReviews_patients]
GO
ALTER TABLE [dbo].[patient_address]  WITH CHECK ADD  CONSTRAINT [FK_patient_address_addresses] FOREIGN KEY([addressId])
REFERENCES [dbo].[addresses] ([addressId])
GO
ALTER TABLE [dbo].[patient_address] CHECK CONSTRAINT [FK_patient_address_addresses]
GO
ALTER TABLE [dbo].[patient_address]  WITH CHECK ADD  CONSTRAINT [FK_patient_address_patients] FOREIGN KEY([patientId])
REFERENCES [dbo].[patients] ([patientId])
GO
ALTER TABLE [dbo].[patient_address] CHECK CONSTRAINT [FK_patient_address_patients]
GO
ALTER TABLE [dbo].[patients]  WITH CHECK ADD  CONSTRAINT [FK_patients_users] FOREIGN KEY([patientId])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[patients] CHECK CONSTRAINT [FK_patients_users]
GO
ALTER TABLE [dbo].[reviewResponses]  WITH CHECK ADD  CONSTRAINT [FK_reviewResponses_doctor] FOREIGN KEY([userId])
REFERENCES [dbo].[doctor] ([userId])
GO
ALTER TABLE [dbo].[reviewResponses] CHECK CONSTRAINT [FK_reviewResponses_doctor]
GO
ALTER TABLE [dbo].[reviewResponses]  WITH CHECK ADD  CONSTRAINT [FK_reviewResponses_officeReviews] FOREIGN KEY([reviewId])
REFERENCES [dbo].[officeReviews] ([reviewId])
GO
ALTER TABLE [dbo].[reviewResponses] CHECK CONSTRAINT [FK_reviewResponses_officeReviews]
GO
USE [master]
GO
ALTER DATABASE [final_capstone] SET  READ_WRITE 
GO







--*****************RUN THESE AFTER INSTAllING DB******************

--populate default data
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');

--populate daysOfTheWeek
INSERT INTO daysOfTheWeek (day) VALUES ('Monday');
INSERT INTO daysOfTheWeek (day) VALUES ('Tuesday');
INSERT INTO daysOfTheWeek (day) VALUES ('Wednesday');
INSERT INTO daysOfTheWeek (day) VALUES ('Thursday');
INSERT INTO daysOfTheWeek (day) VALUES ('Friday');
INSERT INTO daysOfTheWeek (day) VALUES ('Saturday');
INSERT INTO daysOfTheWeek (day) VALUES ('Sunday');