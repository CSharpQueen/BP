CREATE TABLE [dbo].[Karta] (
    [idKarta]       INT          NOT NULL,
    [RezervacijaId] INT          NOT NULL,
    [barkod]        VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Karta] PRIMARY KEY CLUSTERED ([idKarta] ASC),
    CONSTRAINT [FK_Karta_Rezervacija] FOREIGN KEY ([RezervacijaId]) REFERENCES [dbo].[Rezervacija] ([idRezervacije])
);

