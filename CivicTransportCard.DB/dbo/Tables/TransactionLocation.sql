CREATE TABLE [dbo].[TransactionLocation] (
    [Id]                   UNIQUEIDENTIFIER NOT NULL,
    [TransactionId]        UNIQUEIDENTIFIER NOT NULL,
    [EntryPointLocationId] UNIQUEIDENTIFIER NOT NULL,
    [ExitPointLocationId]  UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TransactionFare] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TransactionFare_EntryLocation] FOREIGN KEY ([EntryPointLocationId]) REFERENCES [dbo].[Location] ([Id]),
    CONSTRAINT [FK_TransactionFare_ExitLocation] FOREIGN KEY ([ExitPointLocationId]) REFERENCES [dbo].[Location] ([Id]),
    CONSTRAINT [FK_TransactionFare_Transaction] FOREIGN KEY ([TransactionId]) REFERENCES [dbo].[Transaction] ([Id])
);


GO
ALTER TABLE [dbo].[TransactionLocation] NOCHECK CONSTRAINT [FK_TransactionFare_Transaction];

