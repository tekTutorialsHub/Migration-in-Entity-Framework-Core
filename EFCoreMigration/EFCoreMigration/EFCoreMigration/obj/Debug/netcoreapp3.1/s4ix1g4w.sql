ALTER TABLE [Products] ADD [Rate] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200413070847_v2', N'3.1.3');

GO

