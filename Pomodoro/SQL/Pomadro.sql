USE [Pomadro]
GO
/****** Object:  Table [dbo].[Table_Hesaplar]    Script Date: 5.06.2023 12:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Hesaplar](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](20) NULL,
	[Soyad] [varchar](20) NULL,
	[KullanıcıAd] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Puan] [int] NULL,
	[Tag] [varchar](20) NULL,
 CONSTRAINT [PK_Table_Hesaplar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Hesaplar] ON 

INSERT [dbo].[Table_Hesaplar] ([id], [Ad], [Soyad], [KullanıcıAd], [Sifre], [Cinsiyet], [Puan], [Tag]) VALUES (13, N'Alp', N'Tester', N'alp123', N'123', N'ERKEK', 1830, NULL)
INSERT [dbo].[Table_Hesaplar] ([id], [Ad], [Soyad], [KullanıcıAd], [Sifre], [Cinsiyet], [Puan], [Tag]) VALUES (14, N'Mert', N'Test', N'mert123', N'123', N'ERKEK', 30, N'Çaylak')
SET IDENTITY_INSERT [dbo].[Table_Hesaplar] OFF
GO
ALTER TABLE [dbo].[Table_Hesaplar] ADD  CONSTRAINT [DF_Table_Hesaplar_Puan]  DEFAULT ((0)) FOR [Puan]
GO
ALTER TABLE [dbo].[Table_Hesaplar] ADD  CONSTRAINT [DF_Table_Hesaplar_Tag]  DEFAULT ('Çaylak') FOR [Tag]
GO
