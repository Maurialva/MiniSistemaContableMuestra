USE [master]
GO


/****** Object:  Database [FinalEconomia]    Script Date: 12/12/2021 00:00:54 ******/
CREATE DATABASE [FinalEconomia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalEconomia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FinalEconomia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalEconomia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FinalEconomia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalEconomia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FinalEconomia] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FinalEconomia] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FinalEconomia] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FinalEconomia] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FinalEconomia] SET ARITHABORT OFF 
GO

ALTER DATABASE [FinalEconomia] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FinalEconomia] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FinalEconomia] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FinalEconomia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FinalEconomia] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FinalEconomia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FinalEconomia] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FinalEconomia] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FinalEconomia] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FinalEconomia] SET  DISABLE_BROKER 
GO

ALTER DATABASE [FinalEconomia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FinalEconomia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FinalEconomia] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FinalEconomia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FinalEconomia] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FinalEconomia] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FinalEconomia] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FinalEconomia] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [FinalEconomia] SET  MULTI_USER 
GO

ALTER DATABASE [FinalEconomia] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FinalEconomia] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FinalEconomia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FinalEconomia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FinalEconomia] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FinalEconomia] SET QUERY_STORE = OFF
GO

ALTER DATABASE [FinalEconomia] SET  READ_WRITE 
GO







USE [FinalEconomia]
GO



CREATE TABLE [dbo].[ExistenciaInicial](
	[ExistenciaInicial_Id] [int] IDENTITY(1,1) NOT NULL,
	[Existencia_estado] [bit] NOT NULL,
	[Existencia_Cantidad] [bigint] NOT NULL,
	[Existencia_Precio] [real] NOT NULL,
	[Existencia_Total] [real] NOT NULL,
 CONSTRAINT [PK_ExistenciaInicial] PRIMARY KEY CLUSTERED 
(
	[ExistenciaInicial_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Libro_Diario](
	[Libro_Id] [int] IDENTITY(1,1) NOT NULL,
	[Libro_Estado] [bit] NOT NULL,
	[Libro_Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Libro_Diario] PRIMARY KEY CLUSTERED 
(
	[Libro_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TiposDeCuenta](
	[TipoCuenta_Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoCuenta_Nombre] [varchar](50) NOT NULL,
	[TipoCuenta_Cod] [varchar](5) NOT NULL,
 CONSTRAINT [PK_TiposDeCuenta] PRIMARY KEY CLUSTERED 
(
	[TipoCuenta_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Mayores](
	[Mayor_Id] [int] IDENTITY(1,1) NOT NULL,
	[Mayor_LibroId] [int] NOT NULL,
	[Mayor_Nombre] [varchar](50) NOT NULL,
	[Mayor_Debe] [real] NOT NULL,
	[Mayor_Haber] [real] NOT NULL,
 CONSTRAINT [PK_Mayores] PRIMARY KEY CLUSTERED 
(
	[Mayor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Mayores]  WITH CHECK ADD  CONSTRAINT [FK_Mayores_Libro] FOREIGN KEY([Mayor_LibroId])
REFERENCES [dbo].[Libro_Diario] ([Libro_Id])
GO

ALTER TABLE [dbo].[Mayores] CHECK CONSTRAINT [FK_Mayores_Libro]
GO


CREATE TABLE [dbo].[Stocks](
	[Stock_Id] [int] IDENTITY(1,1) NOT NULL,
	[Stock_LibroId] [int] NOT NULL,
 CONSTRAINT [PK_Stocks] PRIMARY KEY CLUSTERED 
(
	[Stock_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Stocks]  WITH CHECK ADD  CONSTRAINT [FK_Stocks_Libro] FOREIGN KEY([Stock_LibroId])
REFERENCES [dbo].[Libro_Diario] ([Libro_Id])
GO

ALTER TABLE [dbo].[Stocks] CHECK CONSTRAINT [FK_Stocks_Libro]
GO
CREATE TABLE [dbo].[Asientos_Libro](
	[Asiento_Id] [int] IDENTITY(1,1) NOT NULL,
	[Asiento_LibroId] [int] NOT NULL,
	[Asiento_Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Asientos_Libro] PRIMARY KEY CLUSTERED 
(
	[Asiento_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Asientos_Libro]  WITH CHECK ADD  CONSTRAINT [FK_Asientos_Libro] FOREIGN KEY([Asiento_LibroId])
REFERENCES [dbo].[Libro_Diario] ([Libro_Id])
GO

ALTER TABLE [dbo].[Asientos_Libro] CHECK CONSTRAINT [FK_Asientos_Libro]
GO



CREATE TABLE [dbo].[AsientoStock](
	[AsientoF_Id] [int] IDENTITY(1,1) NOT NULL,
	[AsientoF_StockId] [int] NOT NULL,
	[AsientoF_Fecha] [datetime] NOT NULL,
	[AsientoF_Concepto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AsientoStock] PRIMARY KEY CLUSTERED 
(
	[AsientoF_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AsientoStock]  WITH CHECK ADD  CONSTRAINT [FK_Asientos_Stock] FOREIGN KEY([AsientoF_StockId])
REFERENCES [dbo].[Stocks] ([Stock_Id])
GO

ALTER TABLE [dbo].[AsientoStock] CHECK CONSTRAINT [FK_Asientos_Stock]
GO



CREATE TABLE [dbo].[Cuentas](
	[Cuenta_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta_AsientoId] [int] NOT NULL,
	[Cuenta_Nombre] [varchar](50) NOT NULL,
	[Cuenta_Debe] [real] NOT NULL,
	[Cuenta_Haber] [real] NOT NULL,
	[Cuenta_Tipo][varchar](5) NOT NULL,
 CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[Cuenta_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Asiento] FOREIGN KEY([Cuenta_AsientoId])
REFERENCES [dbo].[Asientos_Libro] ([Asiento_Id])
GO

ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Cuentas_Asiento]
GO

CREATE TABLE [dbo].[Saldo_Stock](
	[Saldo_Id] [int] IDENTITY(1,1) NOT NULL,
	[Saldo_AsientoId] [int] NOT NULL,
	[Saldo_Precio] [real] NOT NULL,
	[Saldo_Cantidad] [bigint] NOT NULL,
	[Saldo_Total][real] NOT NULL,
 CONSTRAINT [PK_Saldo_Stock] PRIMARY KEY CLUSTERED 
(
	[Saldo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Saldo_Stock]  WITH CHECK ADD  CONSTRAINT [FK_Saldo_AsientoFicha] FOREIGN KEY([Saldo_AsientoId])
REFERENCES [dbo].[AsientoStock] ([AsientoF_Id])
GO

ALTER TABLE [dbo].[Saldo_Stock] CHECK CONSTRAINT [FK_Saldo_AsientoFicha]
GO

CREATE TABLE [dbo].[Salidas_Ficha](
	[Salida_Id] [int] IDENTITY(1,1) NOT NULL,
	[Salida_AsientoId] [int] NOT NULL,
	[Salida_Precio] [real] NOT NULL,
	[Salida_Cantidad] [bigint] NOT NULL,
	[Salida_Total] [real] NOT NULL,
 CONSTRAINT [PK_Salidas_Ficha] PRIMARY KEY CLUSTERED 
(
	[Salida_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Salidas_Ficha]  WITH CHECK ADD  CONSTRAINT [FK_Salidas_AsientoFicha] FOREIGN KEY([Salida_AsientoId])
REFERENCES [dbo].[AsientoStock] ([AsientoF_Id])
GO

ALTER TABLE [dbo].[Salidas_Ficha] CHECK CONSTRAINT [FK_Salidas_AsientoFicha]
GO
--------------------------------------------------------------


CREATE TABLE [dbo].[Entrada_Ficha](
	[Entrada_Id] [int] IDENTITY(1,1) NOT NULL,
	[Entrada_AsientoId] [int] NOT NULL,
	[Entrada_Precio] [real] NOT NULL,
	[Entrada_Cantidad] [bigint] NOT NULL,
	[Entrada_Total] [real] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Entrada_Ficha]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_AsientoFicha] FOREIGN KEY([Entrada_AsientoId])
REFERENCES [dbo].[AsientoStock] ([AsientoF_Id])
GO

ALTER TABLE [dbo].[Entrada_Ficha] CHECK CONSTRAINT [FK_Entrada_AsientoFicha]
GO


INSERT INTO [dbo].[TiposDeCuenta]
           ([TipoCuenta_Nombre]
           ,[TipoCuenta_Cod])
     VALUES ('Documentos a cobrar','A'),
	 ('Caja','A'),('Banco cta. cte','A'),('Banco cta. de ahorro','A'),('Valores a depositar','A'),('Anticipo a proveedores','A'),
('Anticipos de sueldos','A'),('Mercaderia','A'),('Materia prima','A'),('Instalaciones','A'),('Rodados','A'),('Maquinaria','A'),('Moneda extranjera','A'),
('Deudores por ventas','A'),('Iva Credito Fiscal','A'),
('Equipos de Computacion','A'),
('Iva Saldo a Favor','A'),
('Muebles y utiles','A'),
('Acciones','A'),
('Proveedores','P'),
('Acreedores','P'),
('Iva Debito Fiscal','P'),
('Anticipo de clientes','P'),
('Señas recibidas','P'),
('Fletes a pagar','P'),
('Luz a pagar','P'),
('Gas a pagar','P'),
('Telefono a pagar','P'),
('Sueldos a pagar','P'),
('Iva a pagar','P'),
('Ventas','PN'),
('CMV','PN'),
('Sobrante de Mercaderia','PN'),
('Faltante de Mercaderia','PN'),
('Sueldos y jornales','PN'),
('Gastos flete','PN'),
('Gastos de Luz','PN'),('Res. por Vta BS Uso','PN'),
('Gastos de Gas','PN'),
('Documentos a Cobrar','A'),
('Gastos de Telefono','PN'),
('Capital Social','PN')


GO


select * from [TiposDeCuenta]


select * from Libro_Diario
select * from Asientos_Libro
select * from Cuentas
select * from Mayores
select * from Stocks
select * from AsientoStock
select * from Entrada_Ficha
select * from Salidas_Ficha
select * from Saldo_Stock

select * from ExistenciaInicial

--select * from Mayores where Mayor_LibroId=1 and Mayor_Nombre="Iva Credito Fiscal" order by Mayor_Id desc