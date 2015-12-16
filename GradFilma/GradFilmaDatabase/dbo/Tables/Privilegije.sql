CREATE TABLE [dbo].[Privilegije](
	[idPrivilegije] [int] NOT NULL,
	[ulogaId] [int] NOT NULL,
	[naziv] [varchar](30) NULL,
 CONSTRAINT [PK_Privilegije] PRIMARY KEY CLUSTERED 
(
	[idPrivilegije] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[Privilegije]  WITH CHECK ADD  CONSTRAINT [FK_Privilegije_Uloga] FOREIGN KEY([ulogaId])
REFERENCES [dbo].[Uloga] ([idUloga])
GO

ALTER TABLE [dbo].[Privilegije] CHECK CONSTRAINT [FK_Privilegije_Uloga]
GO
ALTER TABLE [dbo].[Privilegije]  WITH CHECK ADD  CONSTRAINT [FK_Privilegije_StavkePriv] FOREIGN KEY([idPrivilegije])
REFERENCES [dbo].[Privilegije] ([idPrivilegije])
GO

ALTER TABLE [dbo].[Privilegije] CHECK CONSTRAINT [FK_Privilegije_StavkePriv]