CREATE TABLE [dbo].[KinoSala](
	[idKinoSala] [int] NOT NULL,
	[brojSale] [int] NOT NULL,
	[brojMjesta] [int] NOT NULL,
	[tipMjesta] [varchar](20) NOT NULL,
	[TipMjestaId] [int] NOT NULL,
 CONSTRAINT [PK_KinoSala] PRIMARY KEY CLUSTERED 
(
	[idKinoSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[KinoSala]  WITH CHECK ADD  CONSTRAINT [FK_KinoSala_TipMjesta] FOREIGN KEY([TipMjestaId])
REFERENCES [dbo].[TipMjesta] ([idTipMjesta])
GO

ALTER TABLE [dbo].[KinoSala] CHECK CONSTRAINT [FK_KinoSala_TipMjesta]