USE [master]
GO
/****** Object:  Database [BDProperty]    Script Date: 13/6/2018 17:55:12 ******/
CREATE DATABASE [BDProperty]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDProperty', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BDProperty.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDProperty_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BDProperty_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDProperty] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDProperty].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDProperty] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDProperty] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDProperty] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDProperty] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDProperty] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDProperty] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDProperty] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BDProperty] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDProperty] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDProperty] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDProperty] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDProperty] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDProperty] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDProperty] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDProperty] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDProperty] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDProperty] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDProperty] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDProperty] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDProperty] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDProperty] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDProperty] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDProperty] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDProperty] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDProperty] SET  MULTI_USER 
GO
ALTER DATABASE [BDProperty] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDProperty] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDProperty] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDProperty] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BDProperty]
GO
/****** Object:  Table [dbo].[Alquiler]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquiler](
	[IDAlquiler] [bigint] NOT NULL,
	[IDPropiedad] [bigint] NOT NULL,
	[IDInquilino] [bigint] NOT NULL,
	[FechaInicioAlquiler] [date] NULL,
	[FechaHastaAlquiler] [date] NULL,
	[MontoDeposito] [int] NULL,
	[Contrato] [nvarchar](50) NULL,
	[FechaContrato] [date] NULL,
 CONSTRAINT [PK_Alquiler] PRIMARY KEY CLUSTERED 
(
	[IDAlquiler] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cobro](
	[IDCobro] [bigint] NOT NULL,
	[Monto] [int] NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Cobro] PRIMARY KEY CLUSTERED 
(
	[IDCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Concepto]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Concepto](
	[IDConcepto] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Monto] [int] NULL,
 CONSTRAINT [PK_Concepto] PRIMARY KEY CLUSTERED 
(
	[IDConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuotaMensual]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuotaMensual](
	[IDCuotaMensual] [bigint] NOT NULL,
	[IDAlquiler] [bigint] NOT NULL,
	[IDNroCuota] [bigint] NOT NULL,
	[Fecha] [date] NULL,
	[Monto] [int] NULL,
 CONSTRAINT [PK_CuotaMensual] PRIMARY KEY CLUSTERED 
(
	[IDCuotaMensual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleLiquidacion]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleLiquidacion](
	[IDDetalleLiquidacion] [bigint] NOT NULL,
	[IDConcepto] [bigint] NOT NULL,
	[IDLiquidacion] [bigint] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_DetalleLiquidacion] PRIMARY KEY CLUSTERED 
(
	[IDDetalleLiquidacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dueño]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dueño](
	[IDDueño] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[FechaNac] [date] NULL,
	[Telefono] [int] NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[IDLocalidad] [bigint] NOT NULL,
 CONSTRAINT [PK_Dueño] PRIMARY KEY CLUSTERED 
(
	[IDDueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DueñoXPropiedad]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DueñoXPropiedad](
	[IDDueñoXPropiedad] [bigint] NOT NULL,
	[IDPropiedad] [bigint] NOT NULL,
	[IDDueño] [bigint] NOT NULL,
	[FechaDesde] [date] NULL,
	[FechaHasta] [date] NULL,
 CONSTRAINT [PK_DueñoXPropiedad_1] PRIMARY KEY CLUSTERED 
(
	[IDDueñoXPropiedad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificio](
	[IDEdificio] [bigint] NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Ubicacion] [nchar](10) NULL,
	[MontoExpensas] [int] NULL,
 CONSTRAINT [PK_Edificio] PRIMARY KEY CLUSTERED 
(
	[IDEdificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estado]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[IDEstado] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[IDEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inquilino]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inquilino](
	[IDInquilino] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[FechaNac] [date] NULL,
	[Telefono] [int] NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[IDLocalidad] [int] NOT NULL,
 CONSTRAINT [PK_Inquilino] PRIMARY KEY CLUSTERED 
(
	[IDInquilino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InquilinoXAlquiler]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InquilinoXAlquiler](
	[IDInquilinoXAlquiler] [bigint] NOT NULL,
	[IDAlquiler] [bigint] NOT NULL,
	[IDInquilino] [bigint] NOT NULL,
 CONSTRAINT [PK_InquilinoXAlquiler] PRIMARY KEY CLUSTERED 
(
	[IDInquilinoXAlquiler] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Liquidacion]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Liquidacion](
	[IDLiquidacion] [bigint] NOT NULL,
	[IDAlquiler] [bigint] NOT NULL,
	[Mes] [varchar](50) NULL,
	[Fecha] [date] NULL,
	[Monto] [int] NULL,
 CONSTRAINT [PK_Liquidacion] PRIMARY KEY CLUSTERED 
(
	[IDLiquidacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LiquidacionXCobro]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidacionXCobro](
	[IDLiquidacionXCobro] [bigint] NOT NULL,
	[IDLiquidacion] [bigint] NOT NULL,
	[IDCobro] [bigint] NOT NULL,
	[MontoAlquiler] [int] NULL,
	[MontoExpensas] [int] NULL,
	[MontoTasaMunicipal] [int] NULL,
	[MontoMulta] [int] NULL,
	[MontoCochera] [int] NULL,
	[MontoIntereses] [int] NULL,
	[MontoImpuestos] [int] NULL,
	[Otros] [int] NULL,
 CONSTRAINT [PK_LiquidacionXCobro] PRIMARY KEY CLUSTERED 
(
	[IDLiquidacionXCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Propiedad]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Propiedad](
	[IDPropiedad] [bigint] NOT NULL,
	[IDZona] [bigint] NOT NULL,
	[IDTipo] [bigint] NOT NULL,
	[IDEdificio] [bigint] NOT NULL,
	[IDEstado] [bigint] NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Tamaño] [int] NULL,
	[CantHab] [int] NULL,
	[CantBaños] [int] NULL,
	[Patio] [varchar](50) NULL,
	[Cochera] [varchar](50) NULL,
	[Garage] [varchar](50) NULL,
	[CocinaComedor] [varchar](50) NULL,
	[Cocina] [varchar](50) NULL,
	[Comedor] [varchar](50) NULL,
	[VistaCalle] [varchar](50) NULL,
	[GasNatural] [varchar](50) NULL,
	[Pileta] [varchar](50) NULL,
	[Asador] [varchar](50) NULL,
 CONSTRAINT [PK_Propiedad] PRIMARY KEY CLUSTERED 
(
	[IDPropiedad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo](
	[IDTipo] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Zona]    Script Date: 13/6/2018 17:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Zona](
	[IDZona] [bigint] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Zona] PRIMARY KEY CLUSTERED 
(
	[IDZona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Propiedad] FOREIGN KEY([IDPropiedad])
REFERENCES [dbo].[Propiedad] ([IDPropiedad])
GO
ALTER TABLE [dbo].[Alquiler] CHECK CONSTRAINT [FK_Alquiler_Propiedad]
GO
ALTER TABLE [dbo].[CuotaMensual]  WITH CHECK ADD  CONSTRAINT [FK_CuotaMensual_Alquiler] FOREIGN KEY([IDAlquiler])
REFERENCES [dbo].[Alquiler] ([IDAlquiler])
GO
ALTER TABLE [dbo].[CuotaMensual] CHECK CONSTRAINT [FK_CuotaMensual_Alquiler]
GO
ALTER TABLE [dbo].[DetalleLiquidacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleLiquidacion_Concepto] FOREIGN KEY([IDConcepto])
REFERENCES [dbo].[Concepto] ([IDConcepto])
GO
ALTER TABLE [dbo].[DetalleLiquidacion] CHECK CONSTRAINT [FK_DetalleLiquidacion_Concepto]
GO
ALTER TABLE [dbo].[DetalleLiquidacion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleLiquidacion_Liquidacion] FOREIGN KEY([IDLiquidacion])
REFERENCES [dbo].[Liquidacion] ([IDLiquidacion])
GO
ALTER TABLE [dbo].[DetalleLiquidacion] CHECK CONSTRAINT [FK_DetalleLiquidacion_Liquidacion]
GO
ALTER TABLE [dbo].[DueñoXPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_DueñoXPropiedad_Dueño] FOREIGN KEY([IDDueño])
REFERENCES [dbo].[Dueño] ([IDDueño])
GO
ALTER TABLE [dbo].[DueñoXPropiedad] CHECK CONSTRAINT [FK_DueñoXPropiedad_Dueño]
GO
ALTER TABLE [dbo].[DueñoXPropiedad]  WITH CHECK ADD  CONSTRAINT [FK_DueñoXPropiedad_Propiedad] FOREIGN KEY([IDPropiedad])
REFERENCES [dbo].[Propiedad] ([IDPropiedad])
GO
ALTER TABLE [dbo].[DueñoXPropiedad] CHECK CONSTRAINT [FK_DueñoXPropiedad_Propiedad]
GO
ALTER TABLE [dbo].[InquilinoXAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_InquilinoXAlquiler_Alquiler] FOREIGN KEY([IDAlquiler])
REFERENCES [dbo].[Alquiler] ([IDAlquiler])
GO
ALTER TABLE [dbo].[InquilinoXAlquiler] CHECK CONSTRAINT [FK_InquilinoXAlquiler_Alquiler]
GO
ALTER TABLE [dbo].[InquilinoXAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_InquilinoXAlquiler_Inquilino] FOREIGN KEY([IDInquilino])
REFERENCES [dbo].[Inquilino] ([IDInquilino])
GO
ALTER TABLE [dbo].[InquilinoXAlquiler] CHECK CONSTRAINT [FK_InquilinoXAlquiler_Inquilino]
GO
ALTER TABLE [dbo].[Liquidacion]  WITH CHECK ADD  CONSTRAINT [FK_Liquidacion_Alquiler] FOREIGN KEY([IDAlquiler])
REFERENCES [dbo].[Alquiler] ([IDAlquiler])
GO
ALTER TABLE [dbo].[Liquidacion] CHECK CONSTRAINT [FK_Liquidacion_Alquiler]
GO
ALTER TABLE [dbo].[LiquidacionXCobro]  WITH CHECK ADD  CONSTRAINT [FK_LiquidacionXCobro_Cobro] FOREIGN KEY([IDCobro])
REFERENCES [dbo].[Cobro] ([IDCobro])
GO
ALTER TABLE [dbo].[LiquidacionXCobro] CHECK CONSTRAINT [FK_LiquidacionXCobro_Cobro]
GO
ALTER TABLE [dbo].[LiquidacionXCobro]  WITH CHECK ADD  CONSTRAINT [FK_LiquidacionXCobro_Liquidacion] FOREIGN KEY([IDLiquidacion])
REFERENCES [dbo].[Liquidacion] ([IDLiquidacion])
GO
ALTER TABLE [dbo].[LiquidacionXCobro] CHECK CONSTRAINT [FK_LiquidacionXCobro_Liquidacion]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_Propiedad_Edificio] FOREIGN KEY([IDEdificio])
REFERENCES [dbo].[Edificio] ([IDEdificio])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_Propiedad_Edificio]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_Propiedad_Estado] FOREIGN KEY([IDEstado])
REFERENCES [dbo].[Estado] ([IDEstado])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_Propiedad_Estado]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_Propiedad_Tipo] FOREIGN KEY([IDTipo])
REFERENCES [dbo].[Tipo] ([IDTipo])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_Propiedad_Tipo]
GO
ALTER TABLE [dbo].[Propiedad]  WITH CHECK ADD  CONSTRAINT [FK_Propiedad_Zona] FOREIGN KEY([IDZona])
REFERENCES [dbo].[Zona] ([IDZona])
GO
ALTER TABLE [dbo].[Propiedad] CHECK CONSTRAINT [FK_Propiedad_Zona]
GO
USE [master]
GO
ALTER DATABASE [BDProperty] SET  READ_WRITE 
GO
