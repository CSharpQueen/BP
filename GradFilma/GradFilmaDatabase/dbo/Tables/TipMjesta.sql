CREATE TABLE [dbo].[TipMjesta](
	[idTipMjesta] [int] NOT NULL,
	[mjestoZaParove] [int] NULL,
	[mjestoZaOsobeSaInv] [int] NULL,
	[mjesto] [int] NULL,
 CONSTRAINT [PK_TipMjesta] PRIMARY KEY CLUSTERED 
(
	[idTipMjesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

