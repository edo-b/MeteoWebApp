
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2016 14:32:22
-- Generated from EDMX file: C:\Users\Edo\Desktop\Edo\Programming\Faks\MeteoWebApp\MeteoWebApp\MeteoWebApp.Data\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MeteoAppDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CityForecast]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Forecasts] DROP CONSTRAINT [FK_CityForecast];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Forecasts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Forecasts];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[WarningSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WarningSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Forecasts'
CREATE TABLE [dbo].[Forecasts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Temperature] int  NOT NULL,
    [GeneralState] int  NOT NULL,
    [WindDirection] int  NOT NULL,
    [WindSpeed] int  NOT NULL,
    [Date] datetimeoffset  NOT NULL,
    [RainChance] int  NOT NULL,
    [CityId] int  NOT NULL,
    [GeneralStateImageUrl] nvarchar(max)  NOT NULL,
    [GeneralStateCaption] nvarchar(max)  NOT NULL,
    [WindDirectionImageUrl] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Salt] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Warnings'
CREATE TABLE [dbo].[Warnings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TItle] nvarchar(max)  NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [PublishedOn] datetimeoffset  NOT NULL,
    [PublishedBy] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Forecasts'
ALTER TABLE [dbo].[Forecasts]
ADD CONSTRAINT [PK_Forecasts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Warnings'
ALTER TABLE [dbo].[Warnings]
ADD CONSTRAINT [PK_Warnings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CityId] in table 'Forecasts'
ALTER TABLE [dbo].[Forecasts]
ADD CONSTRAINT [FK_CityForecast]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityForecast'
CREATE INDEX [IX_FK_CityForecast]
ON [dbo].[Forecasts]
    ([CityId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------