CREATE TABLE [dbo].[TipMjesta] (
    [idTipMjesta]        INT NOT NULL,
    [mjestoZaParove]     INT NULL,
    [mjestoZaOsobeSaInv] INT NULL,
    [mjesto]             INT NULL,
    CONSTRAINT [PK_TipMjesta] PRIMARY KEY CLUSTERED ([idTipMjesta] ASC)
);

