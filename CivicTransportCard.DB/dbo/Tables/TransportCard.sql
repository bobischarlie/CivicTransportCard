CREATE TABLE [dbo].[TransportCard] (
    [Id]                  UNIQUEIDENTIFIER NOT NULL,
    [FirstName]           NVARCHAR (50)    NOT NULL,
    [LastName]            NVARCHAR (50)    NOT NULL,
    [CardNo]              NVARCHAR (100)   NOT NULL,
    [Balance]             DECIMAL (7, 2)   NOT NULL,
    [CardType]            INT              NOT NULL,
    [IdNo]                NVARCHAR (12)    NULL,
    [LastTransactionDate] DATETIME         NOT NULL,
    [DateExpire]          DATETIME         NOT NULL,
    CONSTRAINT [PK_TransportCard] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UK_TransportCard_CardNo] UNIQUE NONCLUSTERED ([CardNo] ASC)
);

