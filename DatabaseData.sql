USE [master]
GO
/****** Object:  Database [DBProject]    Script Date: 2019-06-27 20:12:09 ******/
CREATE DATABASE [DBProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBProject', FILENAME = N'D:\Programusy\Microsoft SQL Server\MSSQL12.DEBIL\MSSQL\DATA\DBProject.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBProject_log', FILENAME = N'D:\Programusy\Microsoft SQL Server\MSSQL12.DEBIL\MSSQL\DATA\DBProject_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBProject] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBProject] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBProject] SET RECOVERY FULL 
GO
ALTER DATABASE [DBProject] SET  MULTI_USER 
GO
ALTER DATABASE [DBProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBProject] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBProject', N'ON'
GO
USE [DBProject]
GO
/****** Object:  Table [dbo].[Budynki]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Budynki](
	[id_budynku] [int] IDENTITY(1,1) NOT NULL,
	[adres_budynku] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_budynku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dozorcy]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dozorcy](
	[id_dozorcy] [int] IDENTITY(1,1) NOT NULL,
	[nr_telefonu] [varchar](12) NULL,
	[Imie] [varchar](20) NOT NULL,
	[Nazwisko] [varchar](20) NOT NULL,
	[PESEL] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dozorcy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dozorowania]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dozorowania](
	[data_rozpoczecia] [datetime] NULL,
	[data_zakonczenia] [datetime] NULL,
	[id_dozorcy] [int] NULL,
	[id_budynku] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FakturyNapraw]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FakturyNapraw](
	[id_faktury] [int] IDENTITY(1,1) NOT NULL,
	[id_naprawy] [int] NULL,
	[cena] [real] NOT NULL,
	[numer_faktury] [int] NOT NULL,
	[data_platnosci] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_faktury] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FakturyWynajem]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FakturyWynajem](
	[id_faktury] [int] IDENTITY(1,1) NOT NULL,
	[id_wynajem] [int] NULL,
	[cena] [real] NOT NULL,
	[numer_faktury] [int] NOT NULL,
	[data_platnosci] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_faktury] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firmy]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmy](
	[id_firmy] [int] IDENTITY(1,1) NOT NULL,
	[NIP] [varchar](10) NOT NULL,
	[nr_telefonu] [varchar](12) NULL,
	[nazwa_firmy] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_firmy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mieszkania]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mieszkania](
	[id_mieszkania] [int] IDENTITY(1,1) NOT NULL,
	[id_budynku] [int] NULL,
	[numer] [int] NOT NULL,
	[metraz] [real] NULL,
	[opis] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mieszkania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Najemcy]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Najemcy](
	[id_najemcy] [int] IDENTITY(1,1) NOT NULL,
	[nr_telefonu] [varchar](12) NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](20) NOT NULL,
	[PESEL] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_najemcy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Naprawy]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Naprawy](
	[id_naprawy] [int] IDENTITY(1,1) NOT NULL,
	[id_usterki] [int] NULL,
	[id_firmy] [int] NULL,
	[nr_telefonu] [varchar](12) NULL,
	[stan] [varchar](30) NULL,
	[data_zlecenia] [datetime] NULL,
	[data_rozpoczecia] [datetime] NULL,
	[data_ukonczenia] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_naprawy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Platnosci]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Platnosci](
	[id_platnosci] [int] IDENTITY(1,1) NOT NULL,
	[id_wynajmu] [int] NULL,
	[data_platnosci] [datetime] NULL,
	[cena] [real] NOT NULL,
	[tytul] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_platnosci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StanyNapraw]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StanyNapraw](
	[stan] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StanyUsterek]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StanyUsterek](
	[stan] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usterki]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usterki](
	[id_usterki] [int] IDENTITY(1,1) NOT NULL,
	[id_mieszkania] [int] NULL,
	[opis] [varchar](500) NULL,
	[stan] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usterki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wynajmy]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wynajmy](
	[id_wynajmu] [int] IDENTITY(1,1) NOT NULL,
	[id_mieszkania] [int] NULL,
	[data_rozpoczecia] [datetime] NULL,
	[data_zakonczenia] [datetime] NULL,
	[id_najemcy] [int] NULL,
	[cena_miesieczna] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_wynajmu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[FaultsDataView]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FaultsDataView]
AS
SELECT        dbo.Usterki.opis, dbo.Usterki.stan, dbo.Budynki.adres_budynku, dbo.Mieszkania.numer, dbo.Usterki.id_usterki, dbo.Mieszkania.id_mieszkania, 
                         dbo.Budynki.id_budynku
FROM            dbo.StanyUsterek INNER JOIN
                         dbo.Usterki ON dbo.StanyUsterek.stan = dbo.Usterki.stan INNER JOIN
                         dbo.Mieszkania ON dbo.Usterki.id_mieszkania = dbo.Mieszkania.id_mieszkania INNER JOIN
                         dbo.Budynki ON dbo.Mieszkania.id_budynku = dbo.Budynki.id_budynku
GO
/****** Object:  View [dbo].[RentalDataView]    Script Date: 2019-06-27 20:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RentalDataView]
AS
SELECT        dbo.Najemcy.imie, dbo.Najemcy.nazwisko, dbo.Mieszkania.numer, dbo.Budynki.adres_budynku, dbo.Wynajmy.data_rozpoczecia, dbo.Wynajmy.data_zakonczenia, 
                         dbo.Najemcy.id_najemcy, dbo.Budynki.id_budynku, dbo.Mieszkania.id_mieszkania, dbo.Wynajmy.id_wynajmu, dbo.Wynajmy.cena_miesieczna
FROM            dbo.Budynki INNER JOIN
                         dbo.Mieszkania ON dbo.Budynki.id_budynku = dbo.Mieszkania.id_budynku INNER JOIN
                         dbo.Wynajmy ON dbo.Mieszkania.id_mieszkania = dbo.Wynajmy.id_mieszkania INNER JOIN
                         dbo.Najemcy ON dbo.Wynajmy.id_najemcy = dbo.Najemcy.id_najemcy
GO
SET IDENTITY_INSERT [dbo].[Budynki] ON 

INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (1, N'Konarskiego 11')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (2, N'Konarskiego 12')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (3, N'Konarskiego 13')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (4, N'Wniebowstąpienia 23')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (5, N'Wniebowstąpienia 24')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (6, N'Armii Krajowej 2')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (7, N'Armii Krajowej 3')
SET IDENTITY_INSERT [dbo].[Budynki] OFF
SET IDENTITY_INSERT [dbo].[Dozorcy] ON 

INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (1, N'000000000', N'Jan', N'Kozuchowski', N'00000000000')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (2, N'000000001', N'Zbigniew', N'Matuskełkowski', N'00000000001')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (3, N'000000002', N'Janusz', N'Pietrkowski', N'00000000002')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (4, N'000000003', N'Bolesław', N'Jagódkowski', N'00000000003')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (5, N'000000004', N'Marian', N'Krzaczek', N'00000000004')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (6, N'000000005', N'Donald', N'Kfakowski', N'00000000005')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (7, N'000000006', N'Michał', N'Ledwoński', N'00000000006')
SET IDENTITY_INSERT [dbo].[Dozorcy] OFF
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 1, 1)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 2, 2)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 3, 3)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 4, 4)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 5, 5)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 6, 6)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 7, 7)
SET IDENTITY_INSERT [dbo].[FakturyNapraw] ON 

INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (1, 2, 2000, 321232123, CAST(N'2019-05-01T14:09:29.357' AS DateTime))
INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (2, 1, 2000, 321232124, CAST(N'2019-05-01T14:09:29.363' AS DateTime))
INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (3, 2, 2004, 321232125, CAST(N'2019-05-01T14:09:29.363' AS DateTime))
SET IDENTITY_INSERT [dbo].[FakturyNapraw] OFF
SET IDENTITY_INSERT [dbo].[FakturyWynajem] ON 

INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (2, 1, 12, 12, CAST(N'2019-02-04T03:13:03.000' AS DateTime))
INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (5, 7, 32, 1, CAST(N'1987-12-13T21:03:01.000' AS DateTime))
INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (1002, 1, 677, 3, CAST(N'1999-07-31T02:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[FakturyWynajem] OFF
SET IDENTITY_INSERT [dbo].[Firmy] ON 

INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (1, N'0000000000', N'000000000', N'DIM')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (2, N'0000000001', N'000000001', N'DIMA')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (3, N'0000000002', N'000000002', N'ANIMA')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (4, N'0000000003', N'000000003', N'LIBERA')
SET IDENTITY_INSERT [dbo].[Firmy] OFF
SET IDENTITY_INSERT [dbo].[Mieszkania] ON 

INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (1, 1, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (2, 1, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (3, 1, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (4, 1, 4, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (5, 1, 5, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (6, 1, 6, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (7, 1, 7, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (8, 1, 8, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (9, 1, 9, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (10, 1, 10, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (11, 1, 11, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (12, 1, 12, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (13, 1, 13, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (14, 2, 14, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (15, 2, 15, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (16, 2, 16, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (17, 2, 17, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (18, 2, 18, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (19, 2, 19, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (20, 2, 20, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (21, 2, 21, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (22, 2, 22, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (23, 2, 23, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (24, 2, 24, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (25, 2, 25, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (26, 2, 26, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (27, 3, 27, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (28, 3, 28, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (29, 3, 29, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (30, 3, 30, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (31, 3, 31, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (32, 3, 32, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (33, 3, 33, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (34, 3, 34, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (35, 3, 35, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (36, 3, 36, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (37, 3, 37, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (38, 3, 38, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (39, 3, 39, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (40, 4, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (41, 4, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (42, 4, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (43, 4, 4, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (44, 4, 5, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (45, 4, 6, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (46, 5, 7, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (47, 5, 8, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (48, 5, 9, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (49, 5, 10, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (50, 5, 11, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (51, 5, 12, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (52, 6, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (53, 6, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (54, 6, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (55, 6, 4, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (56, 6, 5, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (57, 6, 6, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (58, 7, 7, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (59, 7, 8, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (60, 7, 9, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (61, 7, 10, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (62, 7, 11, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (63, 7, 12, 45, NULL)
SET IDENTITY_INSERT [dbo].[Mieszkania] OFF
SET IDENTITY_INSERT [dbo].[Najemcy] ON 

INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (1, N'000000010', N'Janina', N'Kozuchowska', N'00000000010')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (2, N'000000011', N'Zbigniewa', N'Matuskełkowska', N'00000000011')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (3, N'000000012', N'Janusza', N'Pietrkowska', N'00000000012')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (4, N'000000013', N'Bolesława', N'Jagódkowska', N'00000000013')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (5, N'000000014', N'Marianna', N'Krzaczek', N'00000000014')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (6, N'000000015', N'Donalda', N'Kfakowska', N'00000000015')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (7, N'000000016', N'Michalina', N'Ledwońska', N'00000000016')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (8, N'123456789', N'Kartofel', N'Ziemniak', N'12345678901')
SET IDENTITY_INSERT [dbo].[Najemcy] OFF
SET IDENTITY_INSERT [dbo].[Naprawy] ON 

INSERT [dbo].[Naprawy] ([id_naprawy], [id_usterki], [id_firmy], [nr_telefonu], [stan], [data_zlecenia], [data_rozpoczecia], [data_ukonczenia]) VALUES (1, 2, 1, N'000000000', N'W trakcie', CAST(N'2019-05-01T14:09:29.350' AS DateTime), NULL, NULL)
INSERT [dbo].[Naprawy] ([id_naprawy], [id_usterki], [id_firmy], [nr_telefonu], [stan], [data_zlecenia], [data_rozpoczecia], [data_ukonczenia]) VALUES (2, 3, 2, N'000000001', N'W trakcie', CAST(N'2019-05-01T14:09:29.350' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Naprawy] OFF
SET IDENTITY_INSERT [dbo].[Platnosci] ON 

INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (1, 1, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 80, N'Marzec. Sorki, że tak mało, ale mnie nie stać')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (2, 2, CAST(N'2019-05-01T14:09:29.000' AS DateTime), 150, N'Marzec i zaległość za luty')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (3, 3, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 120, N'Marzec Yolo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (4, 4, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 130, N'Płatność za luty, marzec lleci następnym przelewem')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (5, 5, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 140, N'Marzec elo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (6, 6, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 150, N'Marzec elo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (7, 7, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 160, N'Marzec trolololo')
SET IDENTITY_INSERT [dbo].[Platnosci] OFF
INSERT [dbo].[StanyNapraw] ([stan]) VALUES (N'Gotowa')
INSERT [dbo].[StanyNapraw] ([stan]) VALUES (N'W trakcie')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Realizowana')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Rozpatrzona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zakonczona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zgloszona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zlecona')
SET IDENTITY_INSERT [dbo].[Usterki] ON 

INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (1, 56, N'Przebita rura kanalizacyjna', N'Zgloszona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (2, 58, N'Brak prądu', N'Realizowana')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (3, 51, N'Nieszczelne okno', N'Zlecona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (4, 56, N'Urwała się lampa i  wisi 20 centymetrów nad ziemią, uniemożliwiając psu swobodne przemieszczanie się tam i ówdzie', N'Zlecona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (5, 57, N'Wyrwało toaletę z zamocowania', N'Rozpatrzona')
SET IDENTITY_INSERT [dbo].[Usterki] OFF
SET IDENTITY_INSERT [dbo].[Wynajmy] ON 

INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (1, 1, CAST(N'1913-05-01T14:09:29.357' AS DateTime), CAST(N'2077-05-01T14:09:29.357' AS DateTime), 1, 122)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (2, 2, NULL, NULL, 2, 110)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (3, 3, NULL, NULL, 3, 120)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (4, 4, NULL, NULL, 4, 130)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (5, 5, NULL, NULL, 5, 140)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (6, 6, NULL, NULL, 6, 150)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (7, 7, NULL, NULL, 7, 160)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (8, 10, NULL, NULL, 1, 130)
SET IDENTITY_INSERT [dbo].[Wynajmy] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Dozorcy__4F16EE7F8585238E]    Script Date: 2019-06-27 20:12:10 ******/
ALTER TABLE [dbo].[Dozorcy] ADD UNIQUE NONCLUSTERED 
(
	[PESEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Najemcy__4F16EE7F4F94E793]    Script Date: 2019-06-27 20:12:10 ******/
ALTER TABLE [dbo].[Najemcy] ADD UNIQUE NONCLUSTERED 
(
	[PESEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Dozorowania] ADD  DEFAULT (getdate()) FOR [data_rozpoczecia]
GO
ALTER TABLE [dbo].[FakturyNapraw] ADD  DEFAULT (getdate()) FOR [data_platnosci]
GO
ALTER TABLE [dbo].[FakturyWynajem] ADD  DEFAULT (getdate()) FOR [data_platnosci]
GO
ALTER TABLE [dbo].[Naprawy] ADD  DEFAULT (getdate()) FOR [data_zlecenia]
GO
ALTER TABLE [dbo].[Platnosci] ADD  DEFAULT (getdate()) FOR [data_platnosci]
GO
ALTER TABLE [dbo].[Dozorowania]  WITH CHECK ADD FOREIGN KEY([id_budynku])
REFERENCES [dbo].[Budynki] ([id_budynku])
GO
ALTER TABLE [dbo].[Dozorowania]  WITH CHECK ADD FOREIGN KEY([id_dozorcy])
REFERENCES [dbo].[Dozorcy] ([id_dozorcy])
GO
ALTER TABLE [dbo].[FakturyNapraw]  WITH CHECK ADD FOREIGN KEY([id_naprawy])
REFERENCES [dbo].[Naprawy] ([id_naprawy])
GO
ALTER TABLE [dbo].[FakturyWynajem]  WITH CHECK ADD FOREIGN KEY([id_wynajem])
REFERENCES [dbo].[Wynajmy] ([id_wynajmu])
GO
ALTER TABLE [dbo].[Mieszkania]  WITH CHECK ADD FOREIGN KEY([id_budynku])
REFERENCES [dbo].[Budynki] ([id_budynku])
GO
ALTER TABLE [dbo].[Naprawy]  WITH CHECK ADD FOREIGN KEY([id_firmy])
REFERENCES [dbo].[Firmy] ([id_firmy])
GO
ALTER TABLE [dbo].[Naprawy]  WITH CHECK ADD FOREIGN KEY([id_usterki])
REFERENCES [dbo].[Usterki] ([id_usterki])
GO
ALTER TABLE [dbo].[Naprawy]  WITH CHECK ADD FOREIGN KEY([stan])
REFERENCES [dbo].[StanyNapraw] ([stan])
GO
ALTER TABLE [dbo].[Platnosci]  WITH CHECK ADD FOREIGN KEY([id_wynajmu])
REFERENCES [dbo].[Wynajmy] ([id_wynajmu])
GO
ALTER TABLE [dbo].[Usterki]  WITH CHECK ADD FOREIGN KEY([id_mieszkania])
REFERENCES [dbo].[Mieszkania] ([id_mieszkania])
GO
ALTER TABLE [dbo].[Usterki]  WITH CHECK ADD FOREIGN KEY([stan])
REFERENCES [dbo].[StanyUsterek] ([stan])
GO
ALTER TABLE [dbo].[Wynajmy]  WITH CHECK ADD FOREIGN KEY([id_mieszkania])
REFERENCES [dbo].[Mieszkania] ([id_mieszkania])
GO
ALTER TABLE [dbo].[Wynajmy]  WITH CHECK ADD FOREIGN KEY([id_najemcy])
REFERENCES [dbo].[Najemcy] ([id_najemcy])
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Budynki"
            Begin Extent = 
               Top = 30
               Left = 0
               Bottom = 125
               Right = 170
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Usterki"
            Begin Extent = 
               Top = 22
               Left = 329
               Bottom = 151
               Right = 499
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StanyUsterek"
            Begin Extent = 
               Top = 34
               Left = 541
               Bottom = 112
               Right = 711
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mieszkania"
            Begin Extent = 
               Top = 177
               Left = 147
               Bottom = 306
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
    ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FaultsDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FaultsDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FaultsDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Budynki"
            Begin Extent = 
               Top = 24
               Left = 564
               Bottom = 119
               Right = 734
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mieszkania"
            Begin Extent = 
               Top = 17
               Left = 277
               Bottom = 146
               Right = 447
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Najemcy"
            Begin Extent = 
               Top = 175
               Left = 334
               Bottom = 304
               Right = 504
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Wynajmy"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 231
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RentalDataView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RentalDataView'
GO
USE [master]
GO
ALTER DATABASE [DBProject] SET  READ_WRITE 
GO
