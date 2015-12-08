CREATE TABLE [dbo].[KinoSala] (
    [idKinoSala]  INT          NOT NULL,
    [brojSale]    INT          NOT NULL,
    [brojMjesta]  INT          NOT NULL,
    [tipMjesta]   VARCHAR (20) NOT NULL,
    [TipMjestaId] INT          NOT NULL,
    CONSTRAINT [PK_KinoSala] PRIMARY KEY CLUSTERED ([idKinoSala] ASC),
    CONSTRAINT [FK_KinoSala_TipMjesta] FOREIGN KEY ([TipMjestaId]) REFERENCES [dbo].[TipMjesta] ([idTipMjesta])
);

