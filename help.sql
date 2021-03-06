USE [master]
GO
/****** Object:  Database [help]    Script Date: 2/19/2020 12:26:39 PM ******/
CREATE DATABASE [help]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'help', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\help.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'help_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\help_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [help] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [help].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [help] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [help] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [help] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [help] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [help] SET ARITHABORT OFF 
GO
ALTER DATABASE [help] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [help] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [help] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [help] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [help] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [help] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [help] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [help] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [help] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [help] SET  DISABLE_BROKER 
GO
ALTER DATABASE [help] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [help] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [help] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [help] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [help] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [help] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [help] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [help] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [help] SET  MULTI_USER 
GO
ALTER DATABASE [help] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [help] SET DB_CHAINING OFF 
GO
ALTER DATABASE [help] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [help] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [help] SET DELAYED_DURABILITY = DISABLED 
GO
USE [help]
GO
/****** Object:  Table [dbo].[req]    Script Date: 2/19/2020 12:26:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[req](
	[namee] [nvarchar](50) NULL,
	[des] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[area] [nvarchar](50) NULL,
	[town] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[phone] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[saved]    Script Date: 2/19/2020 12:26:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saved](
	[des] [nvarchar](max) NULL,
	[area] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[saved] ([des], [area], [email], [type], [phone]) VALUES (N'', N'', N'', N'', N'')
USE [master]
GO
ALTER DATABASE [help] SET  READ_WRITE 
GO
