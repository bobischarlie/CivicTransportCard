CREATE TABLE [dbo].[Transaction] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [TransportCardId] UNIQUEIDENTIFIER NOT NULL,
    [Description]     NVARCHAR (MAX)   NOT NULL,
    [DateCreated]     DATETIME         NOT NULL,
    [Amount]          DECIMAL (7, 2)   NOT NULL,
    [EndingBalance]   DECIMAL (7, 2)   NOT NULL,
    [TransactionType] INT              NOT NULL,
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Transaction_TransportCard] FOREIGN KEY ([TransportCardId]) REFERENCES [dbo].[TransportCard] ([Id]) ON DELETE CASCADE
);

