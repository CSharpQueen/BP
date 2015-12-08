CREATE TABLE [dbo].[Film] (
    [idFilm]  INT            NOT NULL,
    [naziv]   VARCHAR (100)  NOT NULL,
    [reziser] VARCHAR (100)  NOT NULL,
    [glumci]  VARCHAR (100)  NOT NULL,
    [opis]    VARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED ([idFilm] ASC)
);

