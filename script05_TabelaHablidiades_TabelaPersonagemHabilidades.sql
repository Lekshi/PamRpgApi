BEGIN TRANSACTION;
GO

CREATE TABLE [Habilidades] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Dano] int NOT NULL,
    [Disputas] int NOT NULL,
    [Vitorias] int NOT NULL,
    [Derrotas] int NOT NULL,
    CONSTRAINT [PK_Habilidades] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PersonagemHabilidades] (
    [PersonagemId] int NOT NULL,
    [HabilidadeId] int NOT NULL,
    CONSTRAINT [PK_PersonagemHabilidades] PRIMARY KEY ([PersonagemId], [HabilidadeId]),
    CONSTRAINT [FK_PersonagemHabilidades_Habilidades_HabilidadeId] FOREIGN KEY ([HabilidadeId]) REFERENCES [Habilidades] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PersonagemHabilidades_Personagens_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [Personagens] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Derrotas', N'Disputas', N'Nome', N'Vitorias') AND [object_id] = OBJECT_ID(N'[Habilidades]'))
    SET IDENTITY_INSERT [Habilidades] ON;
INSERT INTO [Habilidades] ([Id], [Dano], [Derrotas], [Disputas], [Nome], [Vitorias])
VALUES (1, 39, 0, 0, N'Adormecer', 0),
(2, 41, 0, 0, N'Congelar', 0),
(3, 37, 0, 0, N'Hipnotizar', 0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Derrotas', N'Disputas', N'Nome', N'Vitorias') AND [object_id] = OBJECT_ID(N'[Habilidades]'))
    SET IDENTITY_INSERT [Habilidades] OFF;
GO

UPDATE [Usuarios] SET [PasswordHash] = 0xA416C406F966F9AF9D2FE54C6CC22105BA3B5CE1C25B2B1BC0AC53762CE468A3B50976005BEC7DAF48741F3F5C181CC721852AF59CBD8433B5D47575F4A1C66F, [PasswordSalt] = 0xA31BF6029B82AD047A9B3FB01B060BC2DA79652ABAE2E53D622A99036DB650DA5E53690F2DF14B469215E05968CD0BBFAD444BFA32C154A54E2F0DAFA94FEE4ABC8EE999AFCAA4B5AF82C4C4C2F8C0169C80446D31B822EDEDC57DB0E48A3F9D0D24E292BB8AE6EE78272DF7859CA354436D120EBE577E2CA33104D32772377F
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'HabilidadeId', N'PersonagemId') AND [object_id] = OBJECT_ID(N'[PersonagemHabilidades]'))
    SET IDENTITY_INSERT [PersonagemHabilidades] ON;
INSERT INTO [PersonagemHabilidades] ([HabilidadeId], [PersonagemId])
VALUES (1, 1),
(2, 1),
(2, 2),
(2, 3),
(3, 3),
(3, 4),
(1, 5),
(2, 6),
(3, 7);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'HabilidadeId', N'PersonagemId') AND [object_id] = OBJECT_ID(N'[PersonagemHabilidades]'))
    SET IDENTITY_INSERT [PersonagemHabilidades] OFF;
GO

CREATE INDEX [IX_PersonagemHabilidades_HabilidadeId] ON [PersonagemHabilidades] ([HabilidadeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230814114124_MigracaoMuitosParaMuitos', N'7.0.4');
GO

COMMIT;
GO

