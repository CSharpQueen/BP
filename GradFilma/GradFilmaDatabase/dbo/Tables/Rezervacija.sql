CREATE TABLE [dbo].[Rezervacija](
	[idRezervacije] [int] NOT NULL,
	[brojMjesta] [int] NOT NULL,
	[cijena] [decimal](10, 0) NOT NULL,
	[specijalnaPonudaId] [int] NOT NULL,
	[projekcijaId] [int] NOT NULL,
	[uposlenikId] [int] NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[idRezervacije] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Uposlenik] FOREIGN KEY([uposlenikId])
REFERENCES [dbo].[Korisnik] ([idKorisnik])
GO

ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Uposlenik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Specponuda] FOREIGN KEY([specijalnaPonudaId])
REFERENCES [dbo].[SpecijalnePonude] ([idSpecPonude])
GO

ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Specponuda]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Projekcija] FOREIGN KEY([projekcijaId])
REFERENCES [dbo].[Projekcija] ([idProjekcija])
GO

ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Projekcija]