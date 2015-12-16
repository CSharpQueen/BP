CREATE TABLE [dbo].[SpecijalnePonude](
	[idSpecPonude] [int] NOT NULL,
	[maxiComboPaket] [varchar](5) NULL,
	[midiComboPaket] [varchar](5) NULL,
	[miniComboPaket] [varchar](5) NULL,
	[ladyPaket] [varchar](5) NULL,
	[lovePaket] [varchar](5) NULL,
	[studentDay] [varchar](5) NULL,
	[familyDay] [varchar](5) NULL,
	[workDay] [varchar](5) NULL,
 CONSTRAINT [PK_SpecijalnePonude] PRIMARY KEY CLUSTERED 
(
	[idSpecPonude] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

