CREATE TABLE [dbo].[StavkePrivilegije] (
    [idStavkePrivilegije]         INT NOT NULL,
    [privilegijaId]               INT NOT NULL,
    [dodavanjeKorisnika]          INT NULL,
    [brisanjeKorisnika]           INT NULL,
    [rezervacija]                 INT NULL,
    [otkazivanjeRezervacije]      INT NULL,
    [rezervacijaDodatnogSadrzaja] INT NULL,
    [dodavanjeUposlenika]         INT NULL,
    [brisanjeUposlenika]          INT NULL,
    [registracija]                INT NULL,
    [dodavanjeSadrzaja]           INT NULL,
    [brisanjeSadrzaja]            INT NULL,
    CONSTRAINT [PK_StavkePrivilegije] PRIMARY KEY CLUSTERED ([idStavkePrivilegije] ASC),
    CONSTRAINT [FK_StavkePrivilegije_Privilegija] FOREIGN KEY ([privilegijaId]) REFERENCES [dbo].[Privilegije] ([idPrivilegije])
);

