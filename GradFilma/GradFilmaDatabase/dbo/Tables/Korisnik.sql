CREATE TABLE [dbo].[Korisnik] (
    [idKorisnik] INT          NOT NULL,
    [ime]        VARCHAR (20) NOT NULL,
    [prezime]    VARCHAR (30) NOT NULL,
    [jmbg]       VARCHAR (13) NOT NULL,
    [telefon]    VARCHAR (20) NOT NULL,
    [adresa]     VARCHAR (50) NOT NULL,
    [username]   VARCHAR (10) NOT NULL,
    [password]   VARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([idKorisnik] ASC)
);

