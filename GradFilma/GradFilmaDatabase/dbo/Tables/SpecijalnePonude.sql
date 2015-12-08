CREATE TABLE [dbo].[SpecijalnePonude] (
    [idSpecPonude]   INT         NOT NULL,
    [maxiComboPaket] VARCHAR (5) NULL,
    [midiComboPaket] VARCHAR (5) NULL,
    [miniComboPaket] VARCHAR (5) NULL,
    [ladyPaket]      VARCHAR (5) NULL,
    [lovePaket]      VARCHAR (5) NULL,
    [studentDay]     VARCHAR (5) NULL,
    [familyDay]      VARCHAR (5) NULL,
    [workDay]        VARCHAR (5) NULL,
    CONSTRAINT [PK_SpecijalnePonude] PRIMARY KEY CLUSTERED ([idSpecPonude] ASC)
);

