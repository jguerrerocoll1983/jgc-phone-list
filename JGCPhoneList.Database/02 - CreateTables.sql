CREATE TABLE [dbo].[Manufacturer]
(
	[ManufacturerId]	INT				NOT NULL	IDENTITY(1,1),
	[Name]				NVARCHAR(50)	NOT NULL,
	[Description]		NTEXT			NOT NULL,
	[Year]				INT				NULL,
	[Country]			NVARCHAR(100)	NULL,
	[LogoPath]			NVARCHAR(MAX)	NULL,
	CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED ([ManufacturerId] ASC)
);

CREATE TABLE [dbo].[OperativeSystem]
(
	[OperativeSystemId]	INT				NOT NULL	IDENTITY(1,1),
	[Name]				NVARCHAR(50)	NOT NULL,
	[ManufacturerId]	INT				NOT NULL,
	[Description]		NTEXT			NOT NULL,
	[LogoPath]			NVARCHAR(MAX)	NULL,
	[Url]				NVARCHAR(255)	NULL
	CONSTRAINT [PK_OperativeSystem] PRIMARY KEY CLUSTERED ([OperativeSystemId] ASC),
	CONSTRAINT [FK_OperativeSystem_ManufacturerId] FOREIGN KEY ([ManufacturerId]) REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
);

CREATE TABLE [dbo].[Phone]
(
	[PhoneId]			INT				NOT NULL	IDENTITY(1,1),
	[Model]				NVARCHAR(120)	NOT NULL,
	[Description]		NTEXT			NOT NULL,
	[ManufacturerId]	INT				NOT NULL,
	[Year]				INT				NULL,
	[Weight]			INT				NULL,
	[Battery]			INT				NULL,
	[RAM]				INT				NULL,
	[Storage]			INT				NULL,
	[Resolution]		NVARCHAR(50)	NULL,
	[Price]				DECIMAL(10, 2)	NOT NULL,
	[OperativeSystemId]	INT				NOT NULL,
	CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED ([PhoneId] ASC),
    CONSTRAINT [FK_Phone_ManufacturerId] FOREIGN KEY ([ManufacturerId]) REFERENCES [dbo].[Manufacturer] ([ManufacturerId]),
	CONSTRAINT [FK_Phone_OperativeSystemId] FOREIGN KEY ([OperativeSystemId]) REFERENCES [dbo].[OperativeSystem] (OperativeSystemId)
);

CREATE TABLE [dbo].[Color]
(
	[ColorId]			INT				NOT NULL	IDENTITY(1,1),
	[Name]				NVARCHAR(20)	NOT NULL,
	[RValue]			INT				NOT NULL,
	[GValue]			INT				NOT NULL,
	[BValue]			INT				NOT NULL,
	CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);

CREATE TABLE [dbo].[PhoneColors]
(
	[PhoneId]			INT				NOT NULL,
	[ColorId]			INT				NOT NULL,
	CONSTRAINT [PK_PhoneColors] PRIMARY KEY CLUSTERED ([PhoneId] ASC, [ColorId] ASC),
    CONSTRAINT [FK_PhoneColors_PhoneId] FOREIGN KEY ([PhoneId]) REFERENCES [dbo].[Phone] ([PhoneId]),
	CONSTRAINT [FK_PhoneColors_ColorId] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Color] (ColorId)
);

CREATE TABLE [dbo].[Image]
(
	[ImageId]			INT				NOT NULL	IDENTITY(1,1),
	[ImageUrl]			NVARCHAR(MAX)	NOT NULL,
	[Priority]			INT				NULL,
	CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED ([ImageId] ASC)
);

CREATE TABLE [dbo].[PhoneImages]
(
	[PhoneId]			INT				NOT NULL,
	[ImageId]			INT				NOT NULL,
	CONSTRAINT [PK_PhoneImages] PRIMARY KEY CLUSTERED ([PhoneId] ASC, [ImageId] ASC),
    CONSTRAINT [FK_PhoneImages_PhoneId] FOREIGN KEY ([PhoneId]) REFERENCES [dbo].[Phone] ([PhoneId]),
	CONSTRAINT [FK_PhoneImages_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [dbo].[Image] (ImageId)
);