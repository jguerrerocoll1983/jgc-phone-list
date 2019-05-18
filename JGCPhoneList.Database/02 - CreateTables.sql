CREATE TABLE [Phone]
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
	CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED 
	(
		[PhoneId] ASC
	)
)

CREATE TABLE [OperativeSystem]
(
	[OperativeSystemId]	INT				NOT NULL	IDENTITY(1,1),
	[ManufacturerId]	INT				NOT NULL,
	[Description]		NTEXT			NOT NULL,
	[LogoPath]			NVARCHAR(MAX)	NULL,
	[Url]				NVARCHAR(255)	NULL
	CONSTRAINT [PK_OperativeSystem] PRIMARY KEY CLUSTERED 
	(
		[OperativeSystemId] ASC
	)
)

CREATE TABLE [Manufacturer]
(
	[ManufacturerId]			INT				NOT NULL	IDENTITY(1,1),
	[Description]		NTEXT			NOT NULL,
	[Year]				INT				NULL,
	[Country]			NVARCHAR(100)	NULL,
	[LogoPath]			NVARCHAR(MAX)	NULL,
	CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
	(
		[ManufacturerId] ASC
	)
)

CREATE TABLE [Color]
(
	[ColorId]			INT				NOT NULL	IDENTITY(1,1),
	[Name]				NVARCHAR(20)	NOT NULL,
	[RValue]			INT				NOT NULL,
	[GValue]			INT				NOT NULL,
	[BValue]			INT				NOT NULL,
	CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
	(
		[ColorId] ASC
	)
)

CREATE TABLE [Image]
(
	[ImageId]			INT				NOT NULL	IDENTITY(1,1),
	[ImageUrl]			NVARCHAR(MAX)	NOT NULL,
	[Priority]			INT				NULL
)
