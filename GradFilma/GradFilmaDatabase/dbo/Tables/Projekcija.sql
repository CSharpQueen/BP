CREATE TABLE [dbo].[Projekcija] (
    [idProjekcija]        INT      NOT NULL,
    [vrijemePrikazivanja] DATETIME NOT NULL,
    [tipProjekcijeId]     INT      NOT NULL,
    [filmId]              INT      NOT NULL,
    [kinoSalaId]          INT      NOT NULL,
    CONSTRAINT [PK_Projekcija] PRIMARY KEY CLUSTERED ([idProjekcija] ASC),
    CONSTRAINT [FK_Projekcija_Film] FOREIGN KEY ([filmId]) REFERENCES [dbo].[Film] ([idFilm]),
    CONSTRAINT [FK_Projekcija_KinoSala] FOREIGN KEY ([kinoSalaId]) REFERENCES [dbo].[KinoSala] ([idKinoSala]),
    CONSTRAINT [FK_Projekcija_TipProjekcije] FOREIGN KEY ([tipProjekcijeId]) REFERENCES [dbo].[TipProjekcije] ([idTipProjekcije])
);

