USE [LibraryDB]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BooksAuthors]') AND type in (N'U'))
ALTER TABLE [dbo].[BooksAuthors] DROP CONSTRAINT IF EXISTS [FK_BooksAuthors_Book]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BooksAuthors]') AND type in (N'U'))
ALTER TABLE [dbo].[BooksAuthors] DROP CONSTRAINT IF EXISTS [FK_BooksAuthors_Author]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND type in (N'U'))
ALTER TABLE [dbo].[Book] DROP CONSTRAINT IF EXISTS [FK_BookCategory]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
ALTER TABLE [dbo].[Author] DROP CONSTRAINT IF EXISTS [FK_MainCategory]
GO
/****** Object:  Index [PK_BooksAuthors]    Script Date: 6/2/2020 3:25:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BooksAuthors]') AND type in (N'U'))
ALTER TABLE [dbo].[BooksAuthors] DROP CONSTRAINT IF EXISTS [PK_BooksAuthors]
GO
/****** Object:  Index [UQ__Book__447D36EAA69B517F]    Script Date: 6/2/2020 3:25:54 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND type in (N'U'))
ALTER TABLE [dbo].[Book] DROP CONSTRAINT IF EXISTS [UQ__Book__447D36EAA69B517F]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP TABLE IF EXISTS [dbo].[Login]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP TABLE IF EXISTS [dbo].[Category]
GO
/****** Object:  Table [dbo].[BooksAuthors]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP TABLE IF EXISTS [dbo].[BooksAuthors]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP TABLE IF EXISTS [dbo].[Book]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP TABLE IF EXISTS [dbo].[Author]
GO
USE [master]
GO
/****** Object:  Database [LibraryDB]    Script Date: 6/2/2020 3:25:54 PM ******/
DROP DATABASE IF EXISTS [LibraryDB]
GO
/****** Object:  Database [LibraryDB]    Script Date: 6/2/2020 3:25:54 PM ******/
CREATE DATABASE [LibraryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LibraryDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LibraryDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryDB] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryDB] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryDB', N'ON'
GO
ALTER DATABASE [LibraryDB] SET QUERY_STORE = OFF
GO
USE [LibraryDB]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 6/2/2020 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](25) NOT NULL,
	[MiddleName] [varchar](25) NULL,
	[LastName] [varchar](25) NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[Award] [varchar](100) NULL,
	[ContactNumber] [varchar](13) NOT NULL,
	[NumOfBooks] [int] NOT NULL,
	[MainCategory] [int] NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 6/2/2020 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [bigint] NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[Edition] [varchar](100) NOT NULL,
	[PublicateDate] [datetime] NOT NULL,
	[Publisher] [varchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[Available] [bit] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BooksAuthors]    Script Date: 6/2/2020 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BooksAuthors](
	[BookId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/2/2020 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/2/2020 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (1, N'Joel', NULL, N'Grus', N'M', NULL, N'012-345-6789', 3, 11)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (2, N'Sona', NULL, N'Charaipotra', N'F', NULL, N'143-253-2342', 2, 9)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (3, N'Adam', NULL, N'Silvera', N'M', NULL, N'423-231-2454', 10, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (4, N'Becky', NULL, N'Albertalli', N'F', N'2017 German Youth Literature Prize', N'221-423-1152', 3, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (5, N'Dhonielle', NULL, N'Clayton', N'F', N'2019 Lodestar Award for Best Young Adult Book', N'215-234-1234', 4, 9)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (6, N'Cassandra', NULL, N'Clare', N'F', N'2010 Georgia Peach Book Awards for Teen Readers', N'153-483-8786', 23, 10)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (7, N'Sarah', N'Rees', N'Brennan', N'F', N'A 2018 finalist for the World Science Fiction Society Award', N'875-346-1952', 16, 10)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (8, N'Maureen', NULL, N'Johnson', N'F', N'13 Little Blue Envelopes - ALA Teens'' Top Ten 2006', N'946-142-6485', 32, 9)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (9, N'Stephen', N'Edwin', N'King', N'M', N'2007 Mystery Writers of America - Grand Master Award', N'532-168-4357', 61, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (10, N'Evelyn', NULL, N'Walters', N'F', NULL, N'221-231-1252', 3, 1)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (11, N'Woody', NULL, N'Allen', N'M', NULL, N'532-124-6434', 1, 1)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (12, N'Mike', NULL, N'Majlak', N'M', NULL, N'512-151-5352', 1, 2)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (13, N'Riley', N'J.', N'Ford', N'F', NULL, N'872-351-2572', 21, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (14, N'Geri', NULL, N'Foster', N'F', NULL, N'125-124-6245', 62, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (15, N'Cathryn ', NULL, N'Fox', N'F', NULL, N'910-579-8627', 50, 8)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (16, N'Susan', NULL, N'Verde', N'F', NULL, N'645-124-1512', 12, 4)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (17, N'Brad', NULL, N'Meltzer', N'M', NULL, N'739-182-8193', 24, 2)
GO
INSERT [dbo].[Author] ([AuthorId], [FirstName], [MiddleName], [LastName], [Gender], [Award], [ContactNumber], [NumOfBooks], [MainCategory]) VALUES (18, N'Josh', NULL, N'Mensch', N'M', N'Audie Award for History/Biography', N'487-132-4822', 2, 2)
GO
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (1, 9781492041139, N'Data Science from Scratch', N'To really learn data science, you should not only master the tools—data science libraries, frameworks, modules, and toolkits—but also understand the ideas and principles underlying them.', N'second edition', CAST(N'2019-05-16T00:00:00.000' AS DateTime), N'O''Reilly Media', 55.1200, 1, 11)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (2, 9780062342409, N'Tiny Pretty Things', N'Black Swan meets Pretty Little Liars in this soapy, drama-packed novel featuring diverse characters who will do anything to be the prima at their elite ballet school.', N'Reprint edition', CAST(N'2016-06-12T00:00:00.000' AS DateTime), N'HarperTeen', 13.3700, 1, 9)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (3, 9780062795250, N'What If It''s Us', N'Becky Albertalli''s and Aisha Saeed''s heartwarming and hilarious new novel, or Infinity Son, the first book in Adam Silvera’s epic new fantasy series', N'First edition', CAST(N'2018-10-09T00:00:00.000' AS DateTime), N'HarperTeen', 18.9900, 1, 8)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (4, 9781481443258, N'Tales from the Shadowhunter Academy', N'Simon Lewis has been a human and a vampire, and now he is becoming a Shadowhunter. The events of City of Heavenly Fire left him stripped of his memories, and Simon isn’t sure who he is anymore. ', N'Kindle Edition', CAST(N'2016-11-15T00:00:00.000' AS DateTime), N'Margaret K. McElderry Books', 29.3600, 1, 10)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (5, 9780060541439, N'13 Little Blue Envelopes', N'Everything about Ginny will change this summer, and it''s all because of the 13 little blue envelopes.', N'Hardcover edition', CAST(N'2005-08-23T00:00:00.000' AS DateTime), N'HarperTeen', 11.0000, 0, 5)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (6, 9781982137977, N'If It Bleeds', N'If It Bleeds is a 2020 collection of four previously unpublished novellas by American writer Stephen King. The stories in the collection are titled "If It Bleeds", "Mr. Harrigan''s Phone", "The Life of Chuck" and "Rat".', N'Hardcover edition', CAST(N'2020-04-21T00:00:00.000' AS DateTime), N'Scribner', 22.9900, 1, 8)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (7, 9780606257619, N'The Shining', N'Danny is only five years old but in the words of old Mr Hallorann he is a ''shiner'', aglow with psychic voltage. When his father becomes caretaker of the Overlook Hotel his visions grow frighteningly out of control.', N'Library Binding', CAST(N'2012-06-26T00:00:00.000' AS DateTime), N'Turtle Back Books', 46.2500, 1, 8)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (8, 9781501182099, N'It: A Novel', N'They were seven teenagers when they first stumbled upon the horror. Now they are grown-up men and women who have gone out into the big world to gain success and happiness. ', N'Hardcover edition', CAST(N'2017-07-11T00:00:00.000' AS DateTime), N'Scribner', 46.5300, 1, 8)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (10, 9781459737761, N'The Beaver Hall Group and Its Legacy', N'Founded in 1920 like the Group of Seven, the Beaver Hall Group was in the vanguard of bringing Modernism to Canada', N'Hardcover Edition', CAST(N'2017-02-11T00:00:00.000' AS DateTime), N'Dundurn', 60.0000, 1, 1)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (11, 9781951627348, N'Apropos of Nothing', N'n this candid and often hilarious memoir, the celebrated director, comedian, writer, and actor offers a comprehensive, personal look at his tumultuous life.', N'Hardcover Edition', CAST(N'2020-03-23T00:00:00.000' AS DateTime), N'Arcade', 39.5900, 0, 1)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (12, 9798639873775, N'The Fifth Vita', N'Mike Majlak was a seventeen-year-old from a loving, middle-class family in Milford, Connecticut, when he got caught up in the opioid epidemic that swept the nation.', N'Paperback', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'Independently published', 33.4600, 1, 2)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (13, 9781514825334, N'Write to Success', N'Eight New York Times and USA Today bestselling authors share how to build a successful writing career.', N'Paperback', CAST(N'2015-07-04T00:00:00.000' AS DateTime), N'CreateSpace Independent Publishing Platform', 816.9500, 1, 13)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (14, 9781419731655, N'I Am Human: A Book of Empathy', N'From the picture book dream team behind I Am Yoga and I Am Peace comes the third book in their wellness series', N'Hardcover Edition', CAST(N'2018-10-02T00:00:00.000' AS DateTime), N'Harry N. Abrams', 8.3900, 1, 4)
GO
INSERT [dbo].[Book] ([BookId], [ISBN], [Title], [Description], [Edition], [PublicateDate], [Publisher], [Price], [Available], [CategoryId]) VALUES (15, 9781250317476, N'The Lincoln Conspiracy', N'Everyone knows the story of Abraham Lincoln’s assassination in 1865, but few are aware of the original conspiracy to kill him four years earlier in 1861, literally on his way to Washington, D.C., for his first inauguration.', N'Hardcover Edition', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'Flatiron Books', 17.9900, 0, 2)
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (1, 1)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (2, 2)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (2, 3)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (3, 4)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (3, 5)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (4, 6)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (4, 7)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (4, 8)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (5, 8)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (6, 9)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (7, 9)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (8, 9)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (10, 10)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (11, 11)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (12, 12)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (12, 13)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (13, 13)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (13, 14)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (13, 15)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (14, 16)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (15, 17)
GO
INSERT [dbo].[BooksAuthors] ([BookId], [AuthorId]) VALUES (15, 18)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Arts & Photography')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Biographies & Memoirs')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Business & Investing')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Comics & Graphic Novels')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (5, N'Children''s Book')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (6, N'Cookbooks & Crafts')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (7, N'History')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (8, N'Literature & Fiction')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (9, N'Mystery & Suspense')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (10, N'Sci-Fi & Fantasy')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (11, N'Computer & Technology')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (12, N'Self-Help')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (13, N'Reference')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 
GO
INSERT [dbo].[Login] ([Id], [UserName], [Password]) VALUES (1, N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
/****** Object:  Index [UQ__Book__447D36EAA69B517F]    Script Date: 6/2/2020 3:25:54 PM ******/
ALTER TABLE [dbo].[Book] ADD UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_BooksAuthors]    Script Date: 6/2/2020 3:25:54 PM ******/
ALTER TABLE [dbo].[BooksAuthors] ADD  CONSTRAINT [PK_BooksAuthors] PRIMARY KEY NONCLUSTERED 
(
	[BookId] ASC,
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD  CONSTRAINT [FK_MainCategory] FOREIGN KEY([MainCategory])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Author] CHECK CONSTRAINT [FK_MainCategory]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_BookCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_BookCategory]
GO
ALTER TABLE [dbo].[BooksAuthors]  WITH CHECK ADD  CONSTRAINT [FK_BooksAuthors_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
GO
ALTER TABLE [dbo].[BooksAuthors] CHECK CONSTRAINT [FK_BooksAuthors_Author]
GO
ALTER TABLE [dbo].[BooksAuthors]  WITH CHECK ADD  CONSTRAINT [FK_BooksAuthors_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[BooksAuthors] CHECK CONSTRAINT [FK_BooksAuthors_Book]
GO
USE [master]
GO
ALTER DATABASE [LibraryDB] SET  READ_WRITE 
GO
