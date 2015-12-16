CREATE TABLE [dbo].[Karta](
	[idKarta] [int] NOT NULL,
	[RezervacijaId] [int] NOT NULL,
	[barkod] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Karta] PRIMARY KEY CLUSTERED 
(
	[idKarta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [FK_Karta_Rezervacija] FOREIGN KEY([RezervacijaId])
REFERENCES [dbo].[Rezervacija] ([idRezervacije])
GO

ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [FK_Karta_Rezervacija]