CREATE TABLE [dbo].[Uposlenik] (
    [idUposlenik] INT          NOT NULL,
    [ime]         VARCHAR (20) NOT NULL,
    [prezime]     VARCHAR (30) NOT NULL,
    [jmbg]        VARCHAR (13) NOT NULL,
    [telefon]     VARCHAR (20) NOT NULL,
    [adresa]      VARCHAR (50) NOT NULL,
    [username]    VARCHAR (10) NOT NULL,
    [password]    VARCHAR (20) NOT NULL,
    [ulogaId]     INT          NOT NULL,
    CONSTRAINT [PK_Uposlenik] PRIMARY KEY CLUSTERED ([idUposlenik] ASC),
    CONSTRAINT [FK_Uposlenik_Uloga] FOREIGN KEY ([ulogaId]) REFERENCES [dbo].[Uloga] ([idUloga])
);

