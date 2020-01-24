
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/24/2020 18:38:31
-- Generated from EDMX file: C:\Users\Rewolt\source\repos\BiometriaApp\BioMApp\BioMApp\Database\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BiomAppDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Filament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filament];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Filaments'
CREATE TABLE [dbo].[Filaments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RectangleCollor] nchar(10)  NOT NULL,
    [BtnString1] nchar(20)  NOT NULL,
    [BtnBackColor1] nchar(10)  NOT NULL,
    [BtnStringColor1] nchar(10)  NOT NULL,
    [BtnString2] nchar(20)  NOT NULL,
    [BtnBackColor2] nchar(10)  NOT NULL,
    [BtnStringColor2] nchar(10)  NOT NULL,
    [BtnString3] nchar(20)  NOT NULL,
    [BtnBackColor3] nchar(10)  NOT NULL,
    [BtnStringColor3] nchar(10)  NOT NULL,
    [BtnString4] nchar(20)  NOT NULL,
    [BtnBackColor4] nchar(10)  NOT NULL,
    [BtnStringColor4] nchar(10)  NOT NULL,
    [Answer] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Filaments'
ALTER TABLE [dbo].[Filaments]
ADD CONSTRAINT [PK_Filaments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------