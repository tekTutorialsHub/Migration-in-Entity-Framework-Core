﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200413041856_V1')
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200413041856_V1')
BEGIN
    CREATE TABLE [Vendors] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Vendors] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200413041856_V1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200413041856_V1', N'3.1.3');
END;

GO

