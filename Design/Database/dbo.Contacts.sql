CREATE TABLE [dbo].[Contacts] (
    [MessageId]   INT            IDENTITY (1, 1) NOT NULL,
    [ContactDate] DATETIME2       NOT NULL,
    [FirstName]   NVARCHAR (MAX) NOT NULL,
    [LastName]    NVARCHAR (MAX) NOT NULL,
    [Email]       NVARCHAR (MAX) NOT NULL,
    [Topic]       INT            NOT NULL,
    [Subject]     NVARCHAR (MAX) NOT NULL,
    [Message]     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Contacts] PRIMARY KEY CLUSTERED ([MessageId] ASC)
);

