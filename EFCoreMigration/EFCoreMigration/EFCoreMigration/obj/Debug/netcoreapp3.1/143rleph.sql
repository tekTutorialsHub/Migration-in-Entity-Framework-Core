ALTER TABLE [Products] ADD [Rate] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200413052346_V2', N'3.1.3');

GO

ALTER TABLE [Products] ADD [VendorID] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200413052552_V3', N'3.1.3');

GO

