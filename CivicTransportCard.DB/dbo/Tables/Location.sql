CREATE TABLE [dbo].[Location] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [LocationName] NVARCHAR (100)   NOT NULL,
    [Description]  NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Id] ASC)
);

