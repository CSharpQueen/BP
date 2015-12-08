CREATE TABLE [dbo].[Uloga] (
    [idUloga]       INT NOT NULL,
    [administrator] INT NULL,
    [upravnik]      INT NULL,
    [menadzer]      INT NULL,
    CONSTRAINT [PK_Uloga] PRIMARY KEY CLUSTERED ([idUloga] ASC)
);

