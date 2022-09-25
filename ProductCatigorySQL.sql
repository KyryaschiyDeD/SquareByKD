CREATE TABLE [dbo].[Category] (
    [Id]          INT         NOT NULL,
    [name]        CHAR (50)   NULL,
    [information] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Product] (
    [Id]          INT         NOT NULL,
    [name]        NCHAR (50)  NOT NULL,
    [information] NCHAR (100) NULL,
    [CategotyID]  INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CategotyID]) REFERENCES [dbo].[Category] ([Id])
);

INSERT INTO [dbo].[Category] ([Id], [name], [information]) VALUES (1, N'Cat1', N'NO')
INSERT INTO [dbo].[Category] ([Id], [name], [information]) VALUES (2, N'Cat2', NULL)
INSERT INTO [dbo].[Category] ([Id], [name], [information]) VALUES (3, N'Cat3', NULL)
INSERT INTO [dbo].[Category] ([Id], [name], [information]) VALUES (4, N'Cat4', NULL)

INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (1, N'Pr1', NULL, 1)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (2, N'Pr2', NULL, 2)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (3, N'Pr3', NULL, 3)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (4, N'Pr4', NULL, 4)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (5, N'Pr5', NULL, NULL)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (6, N'Pr6', NULL, 2)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (7, N'Pr7', NULL, 3)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (8, N'Pr8', NULL, 3)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (9, N'Pr9', NULL, 3)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (10, N'Pr10', NULL, 2)
INSERT INTO [dbo].[Product] ([Id], [name], [information], [CategotyID]) VALUES (11, N'Pr11', NULL, 1)

SELECT
  name,
  (SELECT name FROM category WHERE id = Product.CategotyID)
FROM
  Product