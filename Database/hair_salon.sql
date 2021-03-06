CREATE DATABASE [hair_salon]
GO
USE [hair_salon]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 2/24/2017 4:57:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[phone] [varchar](255) NULL,
	[address] [varchar](255) NULL,
	[stylist_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stylists]    Script Date: 2/24/2017 4:57:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[stylists] ON 

INSERT [dbo].[stylists] ([id], [name]) VALUES (6, N'Jiwon')
SET IDENTITY_INSERT [dbo].[stylists] OFF
