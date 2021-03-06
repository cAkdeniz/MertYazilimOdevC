USE [MertYazilimOdev]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 12.05.2022 14:25:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Method] [nvarchar](20) NULL,
	[Path] [nvarchar](200) NULL,
	[Query] [nvarchar](50) NULL,
	[CreatedTime] [datetime] NULL,
 CONSTRAINT [PK_Logs_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (1, N'GET', N'/category/getall', NULL, CAST(N'2022-05-11T16:08:00.000' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (2, N'GET', N'/category/getall', N'', CAST(N'2022-05-12T09:51:27.347' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (3, N'GET', N'/category/getall', N'', CAST(N'2022-05-12T09:52:24.153' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (4, N'GET', N'/Customer/GetAll', N'', CAST(N'2022-05-12T10:25:16.767' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (5, N'DELETE', N'/Customer/Delete', N'/?id=AROUT', CAST(N'2022-05-12T10:25:28.443' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (6, N'GET', N'/Customer/GetAll', N'', CAST(N'2022-05-12T10:25:29.150' AS DateTime))
INSERT [dbo].[Logs] ([Id], [Method], [Path], [Query], [CreatedTime]) VALUES (7, N'GET', N'/category/GetAll', N'', CAST(N'2022-05-12T10:39:21.730' AS DateTime))
SET IDENTITY_INSERT [dbo].[Logs] OFF
