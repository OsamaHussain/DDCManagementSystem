USE [master]
GO
/****** Object:  Database [DDCManagementSystem]    Script Date: 5/23/2023 3:22:22 AM ******/
CREATE DATABASE [DDCManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DDCManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\DDCManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DDCManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\DDCManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DDCManagementSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DDCManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DDCManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DDCManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DDCManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DDCManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DDCManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DDCManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [DDCManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DDCManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DDCManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DDCManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DDCManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DDCManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DDCManagementSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [DDCManagementSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DDCManagementSystem]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 5/23/2023 3:22:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[service_name] [nvarchar](100) NULL,
	[service_price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 5/23/2023 3:22:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[email] [nvarchar](100) NULL,
	[address] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrders]    Script Date: 5/23/2023 3:22:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_number] [nvarchar](max) NULL,
	[customer_id] [int] NULL,
	[unit_price] [float] NULL,
	[quantity] [int] NULL,
	[service_id] [int] NULL,
	[order_date] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 5/23/2023 3:22:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[full_name] [nvarchar](100) NULL,
	[role] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spAddCustomerData]    Script Date: 5/23/2023 3:22:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddCustomerData]
    @name nvarchar(50),
    @phone nvarchar(50),
    @email nvarchar(100),
    @address nvarchar(10)
AS
BEGIN
    DECLARE @user int;
    SET @user = 0;

    SELECT @user = id FROM tblCustomer WHERE phone = @phone;

    IF (@user = 0)
    BEGIN
        INSERT INTO tblCustomer (name, phone, email, address)
        VALUES (@name, @phone, @email, @address);
        
        select @user = @@identity;
    END

	SELECT @user as CustomerId;
END
GO
USE [master]
GO
ALTER DATABASE [DDCManagementSystem] SET  READ_WRITE 
GO
