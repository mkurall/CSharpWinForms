USE [btk_kurs_db]
GO
/****** Object:  Table [dbo].[TblKullanicilar]    Script Date: 10.03.2024 14:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKullanicilar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[EPosta] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblKullanicilar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKursiyerler]    Script Date: 10.03.2024 14:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKursiyerler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TcKimlikNo] [char](11) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[Cinsiyet] [tinyint] NULL,
	[EPosta] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblKursiyerler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKursKatilim]    Script Date: 10.03.2024 14:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKursKatilim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KursId] [int] NOT NULL,
	[KursiyerId] [int] NOT NULL,
 CONSTRAINT [PK_TblKursKatilim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKurslar]    Script Date: 10.03.2024 14:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKurslar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KursAdi] [nvarchar](100) NOT NULL,
	[KursTarihi] [datetime] NOT NULL,
	[EgitmenBilgisi] [nvarchar](30) NULL,
 CONSTRAINT [PK_TblKurslar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblKullanicilar] ON 
GO
INSERT [dbo].[TblKullanicilar] ([Id], [Ad], [Soyad], [EPosta], [Parola]) VALUES (1, N'Mustafa', N'KURAL', N'mustafakural@outlook.com', N'1234')
GO
INSERT [dbo].[TblKullanicilar] ([Id], [Ad], [Soyad], [EPosta], [Parola]) VALUES (3, N'Sinan', N'ÜRÜN', N'sinan@urun.com', N'1234')
GO
INSERT [dbo].[TblKullanicilar] ([Id], [Ad], [Soyad], [EPosta], [Parola]) VALUES (8, N'Pınar', N'Can', N'pinar@pinar.com', N'1234')
GO
INSERT [dbo].[TblKullanicilar] ([Id], [Ad], [Soyad], [EPosta], [Parola]) VALUES (9, N'Hasan', N'Can', N'hasan@pinar.com', N'1234')
GO
SET IDENTITY_INSERT [dbo].[TblKullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[TblKurslar] ON 
GO
INSERT [dbo].[TblKurslar] ([Id], [KursAdi], [KursTarihi], [EgitmenBilgisi]) VALUES (1, N'Temel Python', CAST(N'2024-04-15T00:00:00.000' AS DateTime), N'Sinan ÜRÜN')
GO
SET IDENTITY_INSERT [dbo].[TblKurslar] OFF
GO
ALTER TABLE [dbo].[TblKursKatilim]  WITH CHECK ADD  CONSTRAINT [FK_TblKursKatilim_TblKursiyerler] FOREIGN KEY([KursiyerId])
REFERENCES [dbo].[TblKursiyerler] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblKursKatilim] CHECK CONSTRAINT [FK_TblKursKatilim_TblKursiyerler]
GO
ALTER TABLE [dbo].[TblKursKatilim]  WITH CHECK ADD  CONSTRAINT [FK_TblKursKatilim_TblKurslar] FOREIGN KEY([KursId])
REFERENCES [dbo].[TblKurslar] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblKursKatilim] CHECK CONSTRAINT [FK_TblKursKatilim_TblKurslar]
GO
