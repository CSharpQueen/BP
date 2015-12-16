CREATE TABLE [dbo].[StavkePrivilegije](
	[idStavkePrivilegije] [int] NOT NULL,
	[privilegijaId] [int] NOT NULL,
	[naziv] [varchar](30) NULL,
 CONSTRAINT [PK_StavkePrivilegije] PRIMARY KEY CLUSTERED 
(
	[idStavkePrivilegije] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
ALTER TABLE [dbo].[StavkePrivilegije]  WITH CHECK ADD  CONSTRAINT [FK_StavkePrivilegije_Privilegija] FOREIGN KEY([privilegijaId])
REFERENCES [dbo].[Privilegije] ([idPrivilegije])
GO

ALTER TABLE [dbo].[StavkePrivilegije] CHECK CONSTRAINT [FK_StavkePrivilegije_Privilegija]