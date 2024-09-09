
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/27/2023 13:30:09
-- Generated from EDMX file: C:\Users\An\Desktop\DotNet\Lab6\Exercise2\EF-ModelFirst\EF-ModelFirst\EF_ModelFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [lab6];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Manufactures'
CREATE TABLE [dbo].[Manufactures] (
    [ID] nvarchar(450)  NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Employee] int  NOT NULL
);
GO

-- Creating table 'Phones'
CREATE TABLE [dbo].[Phones] (
    [ID] nvarchar(450)  NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Price] int  NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Quantity] int  NOT NULL,
    [ManufactureId] nvarchar(450)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Manufactures'
ALTER TABLE [dbo].[Manufactures]
ADD CONSTRAINT [PK_Manufactures]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Phones'
ALTER TABLE [dbo].[Phones]
ADD CONSTRAINT [PK_Phones]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManufactureId] in table 'Phones'
ALTER TABLE [dbo].[Phones]
ADD CONSTRAINT [FK_Phones_Manufactures_ManufactureId]
    FOREIGN KEY ([ManufactureId])
    REFERENCES [dbo].[Manufactures]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Phones_Manufactures_ManufactureId'
CREATE INDEX [IX_FK_Phones_Manufactures_ManufactureId]
ON [dbo].[Phones]
    ([ManufactureId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------