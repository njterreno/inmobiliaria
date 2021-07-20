
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/19/2021 21:51:17
-- Generated from EDMX file: C:\Users\nata_\Desktop\Proyectos CV\2018\Inmobiliaria\Property\Datos\ModeloBDProperty.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDProperty];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Alquiler_Garante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquiler] DROP CONSTRAINT [FK_Alquiler_Garante];
GO
IF OBJECT_ID(N'[dbo].[FK_Alquiler_Garante1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquiler] DROP CONSTRAINT [FK_Alquiler_Garante1];
GO
IF OBJECT_ID(N'[dbo].[FK_Alquiler_Inquilino]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquiler] DROP CONSTRAINT [FK_Alquiler_Inquilino];
GO
IF OBJECT_ID(N'[dbo].[FK_Alquiler_Propiedad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquiler] DROP CONSTRAINT [FK_Alquiler_Propiedad];
GO
IF OBJECT_ID(N'[dbo].[FK_Alquiler_Propiedad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquiler] DROP CONSTRAINT [FK_Alquiler_Propiedad1];
GO
IF OBJECT_ID(N'[dbo].[FK_Barrio_Localidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Barrio] DROP CONSTRAINT [FK_Barrio_Localidad];
GO
IF OBJECT_ID(N'[dbo].[FK_CuotaMensual_Alquiler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CuotaMensual] DROP CONSTRAINT [FK_CuotaMensual_Alquiler];
GO
IF OBJECT_ID(N'[dbo].[FK_Garante_Localidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Garante] DROP CONSTRAINT [FK_Garante_Localidad];
GO
IF OBJECT_ID(N'[dbo].[FK_Inquilino_Localidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inquilino] DROP CONSTRAINT [FK_Inquilino_Localidad];
GO
IF OBJECT_ID(N'[dbo].[FK_Localidad_Provincia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Localidad] DROP CONSTRAINT [FK_Localidad_Provincia];
GO
IF OBJECT_ID(N'[dbo].[FK_Propiedad_Barrio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propiedad] DROP CONSTRAINT [FK_Propiedad_Barrio];
GO
IF OBJECT_ID(N'[dbo].[FK_Propiedad_Edificio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propiedad] DROP CONSTRAINT [FK_Propiedad_Edificio];
GO
IF OBJECT_ID(N'[dbo].[FK_Propiedad_Estado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propiedad] DROP CONSTRAINT [FK_Propiedad_Estado];
GO
IF OBJECT_ID(N'[dbo].[FK_Propiedad_Propietario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propiedad] DROP CONSTRAINT [FK_Propiedad_Propietario];
GO
IF OBJECT_ID(N'[dbo].[FK_Propiedad_Tipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propiedad] DROP CONSTRAINT [FK_Propiedad_Tipo];
GO
IF OBJECT_ID(N'[dbo].[FK_Propietario_Localidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Propietario] DROP CONSTRAINT [FK_Propietario_Localidad];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Alquiler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alquiler];
GO
IF OBJECT_ID(N'[dbo].[Barrio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Barrio];
GO
IF OBJECT_ID(N'[dbo].[CuotaMensual]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuotaMensual];
GO
IF OBJECT_ID(N'[dbo].[Edificio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Edificio];
GO
IF OBJECT_ID(N'[dbo].[Estado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estado];
GO
IF OBJECT_ID(N'[dbo].[Garante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Garante];
GO
IF OBJECT_ID(N'[dbo].[Inquilino]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inquilino];
GO
IF OBJECT_ID(N'[dbo].[Localidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Localidad];
GO
IF OBJECT_ID(N'[dbo].[Propiedad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Propiedad];
GO
IF OBJECT_ID(N'[dbo].[Propietario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Propietario];
GO
IF OBJECT_ID(N'[dbo].[Provincia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Provincia];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Alquiler'
CREATE TABLE [dbo].[Alquiler] (
    [IDAlquiler] bigint  NOT NULL,
    [IDPropiedad] bigint  NOT NULL,
    [IDInquilino] bigint  NOT NULL,
    [MontoAlquiler] int  NOT NULL,
    [IDGarante1] bigint  NOT NULL,
    [IDGarante2] bigint  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [FechaInicioContrato] datetime  NOT NULL,
    [FechaFinContrato] datetime  NOT NULL
);
GO

-- Creating table 'CuotaMensual'
CREATE TABLE [dbo].[CuotaMensual] (
    [IDCuotaMensual] bigint  NOT NULL,
    [IDAlquiler] bigint  NOT NULL,
    [Monto] int  NULL,
    [Periodo] datetime  NULL,
    [Pago] nvarchar(2)  NULL,
    [FechaPago] nvarchar(50)  NULL,
    [MontoRecargo] int  NULL,
    [MontoTotal] int  NULL,
    [Numero] int  NOT NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [IDEstado] bigint  NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'Garante'
CREATE TABLE [dbo].[Garante] (
    [IDGarante] bigint  NOT NULL,
    [NombreYApellido] nvarchar(50)  NULL,
    [DNI] varchar(8)  NULL,
    [FechaNac] datetime  NULL,
    [Telefono] bigint  NULL,
    [CorreoElectronico] nvarchar(50)  NULL,
    [Direccion] nvarchar(50)  NULL,
    [MontoSueldo] bigint  NULL,
    [IDLocalidad] bigint  NOT NULL
);
GO

-- Creating table 'Inquilino'
CREATE TABLE [dbo].[Inquilino] (
    [IDInquilino] bigint  NOT NULL,
    [IDLocalidad] bigint  NOT NULL,
    [NombreYApellido] varchar(50)  NULL,
    [DNI] varchar(8)  NULL,
    [FechaNac] datetime  NULL,
    [Telefono] bigint  NULL,
    [CorreoElectronico] varchar(50)  NULL,
    [Direccion] varchar(50)  NULL
);
GO

-- Creating table 'Localidad'
CREATE TABLE [dbo].[Localidad] (
    [IDLocalidad] bigint IDENTITY(1,1) NOT NULL,
    [IDProvincia] bigint  NOT NULL,
    [Nombre] nvarchar(50)  NULL,
    [CodigoPostal] int  NULL
);
GO

-- Creating table 'Propietario'
CREATE TABLE [dbo].[Propietario] (
    [IDPropietario] bigint  NOT NULL,
    [IDLocalidad] bigint  NOT NULL,
    [NombreYApellido] varchar(50)  NULL,
    [DNI] varchar(8)  NULL,
    [FechaNac] datetime  NULL,
    [Telefono] bigint  NULL,
    [CorreoElectronico] nvarchar(50)  NULL,
    [Direccion] varchar(50)  NULL
);
GO

-- Creating table 'Provincia'
CREATE TABLE [dbo].[Provincia] (
    [IDProvincia] bigint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NULL
);
GO

-- Creating table 'Tipo'
CREATE TABLE [dbo].[Tipo] (
    [IDTipo] bigint IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Edificio'
CREATE TABLE [dbo].[Edificio] (
    [IDEdificio] bigint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NULL,
    [Direccion] nvarchar(50)  NULL,
    [MontoExpensas] int  NULL,
    [IDLocalidad] bigint  NOT NULL,
    [IDBarrio] bigint  NULL
);
GO

-- Creating table 'Barrio'
CREATE TABLE [dbo].[Barrio] (
    [IDBarrio] bigint IDENTITY(1,1) NOT NULL,
    [IDLocalidad] bigint  NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'Propiedad'
CREATE TABLE [dbo].[Propiedad] (
    [IDPropiedad] bigint IDENTITY(1,1) NOT NULL,
    [IDPropietario] bigint  NOT NULL,
    [IDBarrio] bigint  NULL,
    [IDTipo] bigint  NOT NULL,
    [IDEstado] bigint  NOT NULL,
    [IDEdificio] bigint  NULL,
    [IDLocalidad] bigint  NOT NULL,
    [Direccion] varchar(50)  NOT NULL,
    [Tamaño] nvarchar(50)  NULL,
    [CantBaños] nvarchar(50)  NULL,
    [Patio] varchar(2)  NULL,
    [Cochera] varchar(2)  NULL,
    [Garage] varchar(2)  NULL,
    [Cocina] varchar(2)  NULL,
    [Comedor] varchar(2)  NULL,
    [VistaCalle] varchar(2)  NULL,
    [GasNatural] varchar(2)  NULL,
    [Pileta] varchar(2)  NULL,
    [Asador] varchar(2)  NULL,
    [PisoNro] nvarchar(50)  NULL,
    [CantHabitac] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDAlquiler] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [PK_Alquiler]
    PRIMARY KEY CLUSTERED ([IDAlquiler] ASC);
GO

-- Creating primary key on [IDCuotaMensual] in table 'CuotaMensual'
ALTER TABLE [dbo].[CuotaMensual]
ADD CONSTRAINT [PK_CuotaMensual]
    PRIMARY KEY CLUSTERED ([IDCuotaMensual] ASC);
GO

-- Creating primary key on [IDEstado] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([IDEstado] ASC);
GO

-- Creating primary key on [IDGarante] in table 'Garante'
ALTER TABLE [dbo].[Garante]
ADD CONSTRAINT [PK_Garante]
    PRIMARY KEY CLUSTERED ([IDGarante] ASC);
GO

-- Creating primary key on [IDInquilino] in table 'Inquilino'
ALTER TABLE [dbo].[Inquilino]
ADD CONSTRAINT [PK_Inquilino]
    PRIMARY KEY CLUSTERED ([IDInquilino] ASC);
GO

-- Creating primary key on [IDLocalidad] in table 'Localidad'
ALTER TABLE [dbo].[Localidad]
ADD CONSTRAINT [PK_Localidad]
    PRIMARY KEY CLUSTERED ([IDLocalidad] ASC);
GO

-- Creating primary key on [IDPropietario] in table 'Propietario'
ALTER TABLE [dbo].[Propietario]
ADD CONSTRAINT [PK_Propietario]
    PRIMARY KEY CLUSTERED ([IDPropietario] ASC);
GO

-- Creating primary key on [IDProvincia] in table 'Provincia'
ALTER TABLE [dbo].[Provincia]
ADD CONSTRAINT [PK_Provincia]
    PRIMARY KEY CLUSTERED ([IDProvincia] ASC);
GO

-- Creating primary key on [IDTipo] in table 'Tipo'
ALTER TABLE [dbo].[Tipo]
ADD CONSTRAINT [PK_Tipo]
    PRIMARY KEY CLUSTERED ([IDTipo] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [IDEdificio] in table 'Edificio'
ALTER TABLE [dbo].[Edificio]
ADD CONSTRAINT [PK_Edificio]
    PRIMARY KEY CLUSTERED ([IDEdificio] ASC);
GO

-- Creating primary key on [IDBarrio] in table 'Barrio'
ALTER TABLE [dbo].[Barrio]
ADD CONSTRAINT [PK_Barrio]
    PRIMARY KEY CLUSTERED ([IDBarrio] ASC);
GO

-- Creating primary key on [IDPropiedad] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [PK_Propiedad]
    PRIMARY KEY CLUSTERED ([IDPropiedad] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDAlquiler] in table 'CuotaMensual'
ALTER TABLE [dbo].[CuotaMensual]
ADD CONSTRAINT [FK_CuotaMensual_Alquiler]
    FOREIGN KEY ([IDAlquiler])
    REFERENCES [dbo].[Alquiler]
        ([IDAlquiler])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuotaMensual_Alquiler'
CREATE INDEX [IX_FK_CuotaMensual_Alquiler]
ON [dbo].[CuotaMensual]
    ([IDAlquiler]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Inquilino'
ALTER TABLE [dbo].[Inquilino]
ADD CONSTRAINT [FK_Inquilino_Localidad]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidad]
        ([IDLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Inquilino_Localidad'
CREATE INDEX [IX_FK_Inquilino_Localidad]
ON [dbo].[Inquilino]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDProvincia] in table 'Localidad'
ALTER TABLE [dbo].[Localidad]
ADD CONSTRAINT [FK_Localidad_Provincia]
    FOREIGN KEY ([IDProvincia])
    REFERENCES [dbo].[Provincia]
        ([IDProvincia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Localidad_Provincia'
CREATE INDEX [IX_FK_Localidad_Provincia]
ON [dbo].[Localidad]
    ([IDProvincia]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Garante'
ALTER TABLE [dbo].[Garante]
ADD CONSTRAINT [FK_Garante_Localidad]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidad]
        ([IDLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Garante_Localidad'
CREATE INDEX [IX_FK_Garante_Localidad]
ON [dbo].[Garante]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Propietario'
ALTER TABLE [dbo].[Propietario]
ADD CONSTRAINT [FK_Propietario_Localidad]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidad]
        ([IDLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propietario_Localidad'
CREATE INDEX [IX_FK_Propietario_Localidad]
ON [dbo].[Propietario]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Barrio'
ALTER TABLE [dbo].[Barrio]
ADD CONSTRAINT [FK_Barrio_Localidad]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidad]
        ([IDLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Barrio_Localidad'
CREATE INDEX [IX_FK_Barrio_Localidad]
ON [dbo].[Barrio]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDPropiedad] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [FK_Alquiler_Propiedad]
    FOREIGN KEY ([IDPropiedad])
    REFERENCES [dbo].[Propiedad]
        ([IDPropiedad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquiler_Propiedad'
CREATE INDEX [IX_FK_Alquiler_Propiedad]
ON [dbo].[Alquiler]
    ([IDPropiedad]);
GO

-- Creating foreign key on [IDPropiedad] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [FK_Alquiler_Propiedad1]
    FOREIGN KEY ([IDPropiedad])
    REFERENCES [dbo].[Propiedad]
        ([IDPropiedad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquiler_Propiedad1'
CREATE INDEX [IX_FK_Alquiler_Propiedad1]
ON [dbo].[Alquiler]
    ([IDPropiedad]);
GO

-- Creating foreign key on [IDBarrio] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [FK_Propiedad_Barrio]
    FOREIGN KEY ([IDBarrio])
    REFERENCES [dbo].[Barrio]
        ([IDBarrio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propiedad_Barrio'
CREATE INDEX [IX_FK_Propiedad_Barrio]
ON [dbo].[Propiedad]
    ([IDBarrio]);
GO

-- Creating foreign key on [IDEdificio] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [FK_Propiedad_Edificio]
    FOREIGN KEY ([IDEdificio])
    REFERENCES [dbo].[Edificio]
        ([IDEdificio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propiedad_Edificio'
CREATE INDEX [IX_FK_Propiedad_Edificio]
ON [dbo].[Propiedad]
    ([IDEdificio]);
GO

-- Creating foreign key on [IDEstado] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [FK_Propiedad_Estado]
    FOREIGN KEY ([IDEstado])
    REFERENCES [dbo].[Estado]
        ([IDEstado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propiedad_Estado'
CREATE INDEX [IX_FK_Propiedad_Estado]
ON [dbo].[Propiedad]
    ([IDEstado]);
GO

-- Creating foreign key on [IDPropietario] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [FK_Propiedad_Propietario]
    FOREIGN KEY ([IDPropietario])
    REFERENCES [dbo].[Propietario]
        ([IDPropietario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propiedad_Propietario'
CREATE INDEX [IX_FK_Propiedad_Propietario]
ON [dbo].[Propiedad]
    ([IDPropietario]);
GO

-- Creating foreign key on [IDTipo] in table 'Propiedad'
ALTER TABLE [dbo].[Propiedad]
ADD CONSTRAINT [FK_Propiedad_Tipo]
    FOREIGN KEY ([IDTipo])
    REFERENCES [dbo].[Tipo]
        ([IDTipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Propiedad_Tipo'
CREATE INDEX [IX_FK_Propiedad_Tipo]
ON [dbo].[Propiedad]
    ([IDTipo]);
GO

-- Creating foreign key on [IDGarante1] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [FK_Alquiler_Garante]
    FOREIGN KEY ([IDGarante1])
    REFERENCES [dbo].[Garante]
        ([IDGarante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquiler_Garante'
CREATE INDEX [IX_FK_Alquiler_Garante]
ON [dbo].[Alquiler]
    ([IDGarante1]);
GO

-- Creating foreign key on [IDGarante2] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [FK_Alquiler_Garante1]
    FOREIGN KEY ([IDGarante2])
    REFERENCES [dbo].[Garante]
        ([IDGarante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquiler_Garante1'
CREATE INDEX [IX_FK_Alquiler_Garante1]
ON [dbo].[Alquiler]
    ([IDGarante2]);
GO

-- Creating foreign key on [IDInquilino] in table 'Alquiler'
ALTER TABLE [dbo].[Alquiler]
ADD CONSTRAINT [FK_Alquiler_Inquilino]
    FOREIGN KEY ([IDInquilino])
    REFERENCES [dbo].[Inquilino]
        ([IDInquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquiler_Inquilino'
CREATE INDEX [IX_FK_Alquiler_Inquilino]
ON [dbo].[Alquiler]
    ([IDInquilino]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------