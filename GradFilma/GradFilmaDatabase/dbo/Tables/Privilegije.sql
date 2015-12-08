CREATE TABLE [dbo].[Privilegije] (
    [idPrivilegije]             INT NOT NULL,
    [ulogaId]                   INT NOT NULL,
    [manipulacijaKorisnicima]   INT NULL,
    [manipulacijaPodacima]      INT NULL,
    [manipulacijaRezervacijama] INT NULL,
    [manipulacijaSadrzajem]     INT NULL,
    [manipulacijaUposlenicima]  INT NULL,
    [registracija]              INT NULL,
    CONSTRAINT [PK_Privilegije] PRIMARY KEY CLUSTERED ([idPrivilegije] ASC),
    CONSTRAINT [FK_Privilegije_StavkePriv] FOREIGN KEY ([idPrivilegije]) REFERENCES [dbo].[Privilegije] ([idPrivilegije]),
    CONSTRAINT [FK_Privilegije_Uloga] FOREIGN KEY ([ulogaId]) REFERENCES [dbo].[Uloga] ([idUloga])
);

