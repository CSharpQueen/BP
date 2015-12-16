CREATE TABLE [dbo].[Film](
	[idFilm] [int] NOT NULL,
	[naziv] [varchar](100) NOT NULL,
	[reziser] [varchar](100) NOT NULL,
	[glumci] [varchar](100) NOT NULL,
	[opis] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[idFilm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

