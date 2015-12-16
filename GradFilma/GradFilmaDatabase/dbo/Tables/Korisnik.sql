CREATE TABLE [dbo].[Korisnik](
	[idKorisnik] [int] NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[jmbg] [varchar](13) NOT NULL,
	[telefon] [varchar](20) NOT NULL,
	[adresa] [varchar](50) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[ulogaId] [int] NOT NULL,
CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([idKorisnik] ASC)
)

GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [FK_Korisnik_Uloga] FOREIGN KEY([ulogaId])
REFERENCES [dbo].[Uloga] ([idUloga])
GO

ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [FK_Korisnik_Uloga]
