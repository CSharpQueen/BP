CREATE TABLE [dbo].[Rezervacija] (
    [idRezervacije]      INT          NOT NULL,
    [brojMjesta]         INT          NOT NULL,
    [cijena]             DECIMAL (10) NOT NULL,
    [specijalnaPonudaId] INT          NOT NULL,
    [projekcijaId]       INT          NOT NULL,
    [uposlenikId]        INT          NULL,
    [korisnikId]         INT          NULL,
    CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED ([idRezervacije] ASC),
    CONSTRAINT [FK_Rezervacija_Korisnik] FOREIGN KEY ([korisnikId]) REFERENCES [dbo].[Korisnik] ([idKorisnik]),
    CONSTRAINT [FK_Rezervacija_Projekcija] FOREIGN KEY ([projekcijaId]) REFERENCES [dbo].[Projekcija] ([idProjekcija]),
    CONSTRAINT [FK_Rezervacija_Specponuda] FOREIGN KEY ([specijalnaPonudaId]) REFERENCES [dbo].[SpecijalnePonude] ([idSpecPonude]),
    CONSTRAINT [FK_Rezervacija_Uposlenik] FOREIGN KEY ([uposlenikId]) REFERENCES [dbo].[Uposlenik] ([idUposlenik])
);

