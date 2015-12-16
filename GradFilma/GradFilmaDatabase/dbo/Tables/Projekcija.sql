CREATE TABLE [dbo].[Projekcija](
	[idProjekcija] [int] NOT NULL,
	[vrijemePrikazivanja] [datetime] NOT NULL,
	[tipProjekcijeId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[kinoSalaId] [int] NOT NULL,
 CONSTRAINT [PK_Projekcija] PRIMARY KEY CLUSTERED 
(
	[idProjekcija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Projekcija]  WITH CHECK ADD  CONSTRAINT [FK_Projekcija_TipProjekcije] FOREIGN KEY([tipProjekcijeId])
REFERENCES [dbo].[TipProjekcije] ([idTipProjekcije])
GO

ALTER TABLE [dbo].[Projekcija] CHECK CONSTRAINT [FK_Projekcija_TipProjekcije]
GO
ALTER TABLE [dbo].[Projekcija]  WITH CHECK ADD  CONSTRAINT [FK_Projekcija_KinoSala] FOREIGN KEY([kinoSalaId])
REFERENCES [dbo].[KinoSala] ([idKinoSala])
GO

ALTER TABLE [dbo].[Projekcija] CHECK CONSTRAINT [FK_Projekcija_KinoSala]
GO
ALTER TABLE [dbo].[Projekcija]  WITH CHECK ADD  CONSTRAINT [FK_Projekcija_Film] FOREIGN KEY([filmId])
REFERENCES [dbo].[Film] ([idFilm])
GO

ALTER TABLE [dbo].[Projekcija] CHECK CONSTRAINT [FK_Projekcija_Film]