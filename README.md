CREATE TABLE [dbo].[Products] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NULL,
    [Brand]        NVARCHAR (50) NULL,
    [Quantity]     INT           NULL,
    [Model]        NVARCHAR (50) NULL,
    [SerialNumber] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NULL,
    [LastName] NVARCHAR (50) NULL,
    [Mail]     NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

