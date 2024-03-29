USE [master]
GO
/****** Object:  Database [CATALOGO_DB]    Script Date: 15/09/2019 23:30:27 ******/
CREATE DATABASE [CATALOGO_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CATALOGO_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FRGP_PROG\MSSQL\DATA\CATALOGO_DB.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CATALOGO_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.FRGP_PROG\MSSQL\DATA\CATALOGO_DB_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CATALOGO_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CATALOGO_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CATALOGO_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CATALOGO_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CATALOGO_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CATALOGO_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CATALOGO_DB] SET  MULTI_USER 
GO
ALTER DATABASE [CATALOGO_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CATALOGO_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CATALOGO_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CATALOGO_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CATALOGO_DB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CATALOGO_DB]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 15/09/2019 23:30:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[Imagen] [varchar](150) NULL,
	[Precio] [money] NULL,
	[Borrado] [bit] NOT NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 15/09/2019 23:30:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 15/09/2019 23:30:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ARTICULOS] ON 

INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (1, N's01', N'Galaxy S10', N'Una canoa cara', 1, 1, N'C:\Imagenes\s10.jfif', 14550.2500, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (2, N'M03', N'Moto G Play 7ma Gen', N'Ya siete de estos?', 1, 5, N'C:\Imagenes\MotoG7ma.jpg', 15699.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (3, N'S99', N'Play 4', N'Ya no se cuantas versiones hay', 3, 3, N'C:\Imagenes\play4.jpg', 35000.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (4, N'S5', N'Bravia 55', N'Alta tele', 3, 3, N'C:\Imagenes\tlsony.jpg', 49500.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (5, N'A2', N'Apple TV', N'lindo loro', 2, 2, N'C:\Imagenes\AppleTV.jpg', 7850.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (6, N'SSX10', N'Sony Shake X10', N'Potencia RMS: 1200W. Canales de Salida: 2 Canales', 3, 3, N'C:\Imagenes\Shake-X70D.jpg', 15000.5000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (7, N'AAir', N'Apple AirPods', N'Los AirPods cambiarán para siempre la forma en que usas los audífonos', 2, 4, N'C:\Imagenes\Airpods.jpg', 1000.5000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (8, N'IPH7', N'iPhone 7 Plus', N'Pantalla: 5.5", 1080 x 1920 pixels', 2, 2, N'C:\Imagenes\Ipone7.jpg', 30000.5000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (9, N'HBxPro', N'Huawei MateBook', N'Alta nave', 4, 3, N'C:\Imagenes\huaweimatebookjpg.jpg', 18000.0000, 0)
INSERT [dbo].[ARTICULOS] ([Id], [Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Imagen], [Precio], [Borrado]) VALUES (10, N'Celular', N'alguno', N'Prueba para baja logica', 3, 3, N'No tiene', 150.2000, 1)
SET IDENTITY_INSERT [dbo].[ARTICULOS] OFF
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON 

INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (1, N'Celulares')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (2, N'Televisores')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (3, N'Media')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (4, N'Audio')
SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
SET IDENTITY_INSERT [dbo].[MARCAS] ON 

INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (1, N'Samsung')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (2, N'Apple')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (3, N'Sony')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (4, N'Huawei')
INSERT [dbo].[MARCAS] ([Id], [Descripcion]) VALUES (5, N'Motorola')
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
USE [master]
GO
ALTER DATABASE [CATALOGO_DB] SET  READ_WRITE 
GO
