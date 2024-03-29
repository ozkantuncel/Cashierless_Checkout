USE [C96F4BB4B4423E2334809E79ABE475BC_F\NTP\DERS KODLARı\CASHIERLESS_CHECKOUT\CASHIERLESS_CHECKOUT\BIN\DEBUG\CASHIERLESSCHECKOUT .MDF]
GO
/****** Object:  Table [dbo].[TBL_Admin]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Admin](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[admin_nick] [varchar](20) NOT NULL,
	[admin_password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Barcode]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Barcode](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[barcode] [varchar](20) NOT NULL,
	[produceID] [smallint] NOT NULL,
 CONSTRAINT [PK_TBL_Barcode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Category]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Category](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Product]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Product](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](30) NOT NULL,
	[producerID] [smallint] NOT NULL,
	[categoryID] [tinyint] NOT NULL,
	[price] [int] NOT NULL,
	[tax] [int] NOT NULL,
 CONSTRAINT [PK_TBL_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Producter]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Producter](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[producterName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_Producter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Sales_History]    Script Date: 9.01.2023 14:28:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Sales_History](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productID] [smallint] NOT NULL,
	[dateSales] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_Sales_History] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Admin] ON 

INSERT [dbo].[TBL_Admin] ([id], [admin_nick], [admin_password]) VALUES (1, N'özkan', N'123456789')
INSERT [dbo].[TBL_Admin] ([id], [admin_nick], [admin_password]) VALUES (5, N'Ahmet', N'NlEpODp4yB')
INSERT [dbo].[TBL_Admin] ([id], [admin_nick], [admin_password]) VALUES (6, N'Ali', N'c-EATH5JN')
SET IDENTITY_INSERT [dbo].[TBL_Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Barcode] ON 

INSERT [dbo].[TBL_Barcode] ([id], [barcode], [produceID]) VALUES (1, N'484852542', 2)
INSERT [dbo].[TBL_Barcode] ([id], [barcode], [produceID]) VALUES (2, N'937932703', 4)
INSERT [dbo].[TBL_Barcode] ([id], [barcode], [produceID]) VALUES (3, N'330253981', 5)
SET IDENTITY_INSERT [dbo].[TBL_Barcode] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Category] ON 

INSERT [dbo].[TBL_Category] ([id], [CategoryName]) VALUES (1, N'Akıllı Bileklik')
INSERT [dbo].[TBL_Category] ([id], [CategoryName]) VALUES (2, N'Kulaklık ')
SET IDENTITY_INSERT [dbo].[TBL_Category] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Product] ON 

INSERT [dbo].[TBL_Product] ([id], [productName], [producerID], [categoryID], [price], [tax]) VALUES (2, N'Xiaomi Mi Band 6', 1, 1, 564, 42)
INSERT [dbo].[TBL_Product] ([id], [productName], [producerID], [categoryID], [price], [tax]) VALUES (4, N'Samsung Galaxy Fit2 Kırmızı', 1, 3, 604, 45)
INSERT [dbo].[TBL_Product] ([id], [productName], [producerID], [categoryID], [price], [tax]) VALUES (5, N'Qcy T5 Bluetooth 5.0', 2, 2, 298, 60)
SET IDENTITY_INSERT [dbo].[TBL_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Producter] ON 

INSERT [dbo].[TBL_Producter] ([id], [producterName]) VALUES (1, N'Xiaomi')
INSERT [dbo].[TBL_Producter] ([id], [producterName]) VALUES (2, N'Qcy')
INSERT [dbo].[TBL_Producter] ([id], [producterName]) VALUES (3, N'Samsung')
SET IDENTITY_INSERT [dbo].[TBL_Producter] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Sales_History] ON 

INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (28, 1, N'12.21.202218:05')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (29, 2, N'12.21.202218:05')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (30, 3, N'12.21.202218:05')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (31, 3, N'12.21.202218:18')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (32, 2, N'12.21.202218:38')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (33, 3, N'12.22.202209:12')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (34, 2, N'12.22.202209:12')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (35, 1, N'12.22.202209:45')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (36, 2, N'12.22.202209:51')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (37, 3, N'12.22.202209:51')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (38, 1, N'12.22.202212:21')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (39, 2, N'12.22.202212:21')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (40, 3, N'12.22.202212:21')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (41, 1, N'12.22.202212:35')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (42, 2, N'12.22.202214:48')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (43, 2, N'12.22.202214:48')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (44, 1, N'12.22.202215:07')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (45, 3, N'12.22.202215:07')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (46, 2, N'12.22.202215:07')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (47, 2, N'12.23.202221:54')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (48, 2, N'12.23.202221:54')
INSERT [dbo].[TBL_Sales_History] ([id], [productID], [dateSales]) VALUES (49, 2, N'12.23.202221:54')
SET IDENTITY_INSERT [dbo].[TBL_Sales_History] OFF
GO
ALTER TABLE [dbo].[TBL_Barcode]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Barcode_TBL_Product] FOREIGN KEY([produceID])
REFERENCES [dbo].[TBL_Product] ([id])
GO
ALTER TABLE [dbo].[TBL_Barcode] CHECK CONSTRAINT [FK_TBL_Barcode_TBL_Product]
GO
ALTER TABLE [dbo].[TBL_Product]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Product_TBL_Category] FOREIGN KEY([categoryID])
REFERENCES [dbo].[TBL_Category] ([id])
GO
ALTER TABLE [dbo].[TBL_Product] CHECK CONSTRAINT [FK_TBL_Product_TBL_Category]
GO
ALTER TABLE [dbo].[TBL_Product]  WITH CHECK ADD  CONSTRAINT [FK_TBL_Product_TBL_Producter] FOREIGN KEY([producerID])
REFERENCES [dbo].[TBL_Producter] ([id])
GO
ALTER TABLE [dbo].[TBL_Product] CHECK CONSTRAINT [FK_TBL_Product_TBL_Producter]
GO
