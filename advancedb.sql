Create Database AvansDatabase
GO
USE [AvansDatabase]
GO
/****** Object:  Table [dbo].[Advance]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Advance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Advance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdvanceAmount] [money] NULL,
	[AdvanceDescription] [nvarchar](max) COLLATE Turkish_CI_AS NULL,
	[ProjectID] [int] NULL,
	[DesiredDate] [datetime] NULL,
	[StatusID] [int] NULL,
	[RequestDate] [datetime] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Advance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Advance] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[AdvanceHistory]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AdvanceHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StatusID] [int] NULL,
	[AdvanceID] [int] NULL,
	[TransactorID] [int] NULL,
	[ApprovedAmount] [money] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_AdvanceHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[AdvanceHistory] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Authorization]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Authorization]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Authorization](
	[AuthorizationID] [int] IDENTITY(1,1) NOT NULL,
	[AuthroizationName] [nvarchar](max) COLLATE Turkish_CI_AS NULL,
 CONSTRAINT [PK_Authorization] PRIMARY KEY CLUSTERED 
(
	[AuthorizationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Authorization] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[BusinessUnit]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BusinessUnit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BusinessUnit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitName] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[BusinessUnitDescription] [nvarchar](max) COLLATE Turkish_CI_AS NULL,
 CONSTRAINT [PK_BusinessUnit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[BusinessUnit] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[Surname] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[PhoneNumber] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[Email] [nvarchar](100) COLLATE Turkish_CI_AS NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL,
	[BusinessUnitID] [int] NULL,
	[TitleID] [int] NULL,
	[UpperEmployeeID] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Employee] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[EmployeeProject]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeProject]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EmployeeProject](
	[EmployeeID] [int] NOT NULL,
	[ProjectID] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeProject] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[EmployeeProject] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Page]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Page]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Page](
	[PageID] [int] IDENTITY(1,1) NOT NULL,
	[PageName] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[Path] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
 CONSTRAINT [PK_Page] PRIMARY KEY CLUSTERED 
(
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Page] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Payment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Payment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DeterminedPaymentDate] [datetime] NULL,
	[FinanceManagerID] [int] NULL,
	[AdvanceID] [int] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Payment] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Project]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Project](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[ProjectDescription] [nvarchar](max) COLLATE Turkish_CI_AS NULL,
	[EndDate] [datetime] NULL,
	[StartingDate] [datetime] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Project] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Receipt]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Receipt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptNo] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[isRefundReceipt] [bit] NULL,
	[AdvanceID] [int] NULL,
	[Date] [datetime] NULL,
	[AccountantID] [int] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Receipt] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Rule]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rule]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Rule](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaxAmount] [money] NULL,
	[MinAmount] [money] NULL,
	[Date] [datetime] NULL,
	[TitleID] [int] NULL,
 CONSTRAINT [PK_Rule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Rule] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Status]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Status]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Status] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Title]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Title]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Title](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](50) COLLATE Turkish_CI_AS NULL,
	[TitleDescription] [nvarchar](max) COLLATE Turkish_CI_AS NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[Title] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[TitleAuthorization]    Script Date: 12/15/2023 4:41:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TitleAuthorization](
	[TitleID] [int] NOT NULL,
	[AuthorizationID] [int] NOT NULL,
	[PageID] [int] NOT NULL,
 CONSTRAINT [PK_TitleAuthorization] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC,
	[AuthorizationID] ASC,
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
ALTER AUTHORIZATION ON [dbo].[TitleAuthorization] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[Advance] ON 

INSERT [dbo].[Advance] ([ID], [AdvanceAmount], [AdvanceDescription], [ProjectID], [DesiredDate], [StatusID], [RequestDate], [EmployeeID]) VALUES (3, 2500.0000, N'Avans ödemesi yapıldı.', 3, CAST(N'2023-12-12T00:00:00.000' AS DateTime), 102, CAST(N'2023-12-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Advance] ([ID], [AdvanceAmount], [AdvanceDescription], [ProjectID], [DesiredDate], [StatusID], [RequestDate], [EmployeeID]) VALUES (4, 1400.0000, N'Avans maddi imkansızlıklardan reddedildi', 4, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 103, CAST(N'2022-10-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Advance] ([ID], [AdvanceAmount], [AdvanceDescription], [ProjectID], [DesiredDate], [StatusID], [RequestDate], [EmployeeID]) VALUES (5, 10000.0000, N'Avans ödemesi yüksek miktarda yapıldı', 5, CAST(N'2020-06-20T00:00:00.000' AS DateTime), 207, CAST(N'2020-10-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Advance] ([ID], [AdvanceAmount], [AdvanceDescription], [ProjectID], [DesiredDate], [StatusID], [RequestDate], [EmployeeID]) VALUES (12, 4444.0000, N'hfggf', 3, CAST(N'2023-12-14T10:26:36.603' AS DateTime), 101, CAST(N'2023-12-14T13:26:46.577' AS DateTime), 5)
INSERT [dbo].[Advance] ([ID], [AdvanceAmount], [AdvanceDescription], [ProjectID], [DesiredDate], [StatusID], [RequestDate], [EmployeeID]) VALUES (13, 5444.0000, N'jhhkj', 5, CAST(N'2023-02-21T00:00:00.000' AS DateTime), 102, CAST(N'2023-12-14T15:25:37.070' AS DateTime), 17)
SET IDENTITY_INSERT [dbo].[Advance] OFF
GO
SET IDENTITY_INSERT [dbo].[AdvanceHistory] ON 

INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (3, 201, 3, 8, 2500.0000, CAST(N'2023-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (4, 202, 3, 8, 2500.0000, CAST(N'2023-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (5, 203, 3, 7, 2500.0000, CAST(N'2023-12-13T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (6, 204, 3, 5, 2500.0000, CAST(N'2023-12-14T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (7, 205, 3, 4, 2500.0000, CAST(N'2023-12-15T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (8, 206, 3, 6, 2500.0000, CAST(N'2023-12-16T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (9, 207, 3, 9, 2500.0000, CAST(N'2023-12-20T00:00:00.000' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (14, 201, 12, 5, 0.0000, CAST(N'2023-12-14T13:26:46.690' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (15, 201, 13, 17, 0.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (16, 202, 13, 26, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (17, 203, 13, 25, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (18, 204, 13, 24, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (19, 205, 13, 23, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (20, 206, 13, 22, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
INSERT [dbo].[AdvanceHistory] ([ID], [StatusID], [AdvanceID], [TransactorID], [ApprovedAmount], [Date]) VALUES (21, 207, 13, 28, 15000.0000, CAST(N'2023-12-14T15:25:37.080' AS DateTime))
SET IDENTITY_INSERT [dbo].[AdvanceHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[Authorization] ON 

INSERT [dbo].[Authorization] ([AuthorizationID], [AuthroizationName]) VALUES (1, N'Create')
INSERT [dbo].[Authorization] ([AuthorizationID], [AuthroizationName]) VALUES (2, N'Select')
INSERT [dbo].[Authorization] ([AuthorizationID], [AuthroizationName]) VALUES (3, N'Update')
INSERT [dbo].[Authorization] ([AuthorizationID], [AuthroizationName]) VALUES (4, N'Delete')
SET IDENTITY_INSERT [dbo].[Authorization] OFF
GO
SET IDENTITY_INSERT [dbo].[BusinessUnit] ON 

INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (4, N'Yazılımcı', N'Tech ekibi')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (5, N'Muhasebe', N'Finansal işlemler')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (6, N'İnsan Kaynakları', N'Çalışan memnuniyeti')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (7, N'Teknik Destek', N'Yardım')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (8, N'İdari İşler', N'Yoğun bölüm')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (9, N'Danışma', N'Yardım')
INSERT [dbo].[BusinessUnit] ([ID], [BusinessUnitName], [BusinessUnitDescription]) VALUES (10, N'Analiz', N'Analistler')
SET IDENTITY_INSERT [dbo].[BusinessUnit] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (4, N'Semih', N'Kaya', N'5531106991', N'semihhky@outlook.com', NULL, NULL, 4, 1, 4)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (5, N'Enez', N'Ay', N'5551106547', N'menezay@gmail.com', NULL, NULL, 5, 2, 4)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (6, N'Furkan', N'Gökırmak', N'1455789515', N'furkan@mail.com', NULL, NULL, 6, 3, 5)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (7, N'İhsan', N'Kuzuuuu', N'1452475585', N'ihssanss@gmail.com', NULL, NULL, 7, 4, 6)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (8, N'Burak', N'Çoban', N'5513246556', N'burakcoban@hotmail.com', NULL, NULL, 8, 5, 7)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (9, N'Esma', N'Bediz', N'5465321454', N'esma@gmail.com', NULL, NULL, 9, 6, 8)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (10, N'Fatih', N'Çatal', N'5423546545', N'fcatal@gmail.com', NULL, NULL, 10, 7, 9)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (13, N'deneme1', N'deneme1', NULL, N'deneme1', 0xE517773987AC78411AACD163EEACEB8B3C9FAED06E776BFE1B45F8088F403A0622A2E6AF018A0661EC1E0528D559464CC8005F28153D2B85787BA97DB6C0D1E8, 0x2E9C57DAC7EC41C142F8A21A212302C9B597D5F7AE5CA3A164232B9244F416068B29E36DBB1B8D250D5F3FF908D9C81812C8C5F5F9164E0B6C402A60CB9D46AB6AEDA4081F4C02C638128FD60F6C2CC93E66A3623714E295E671F6ECB18F3392ECE499C062DC0E4F99BEAEC89CF53F367F347DDA5FE5C66CCD174BD123AD779F, 4, 4, 4)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (17, N'furkann', N'furkann', NULL, N'furkann', 0xD188D5AD87C05A89087E187ABFCB11B1CCD714486306616820A9D811AFADE0BE528065021E128F1C9CB2FEECB3D24F78527839E660EC9B169C8935AB5DFE6146, 0x733E2E987B378696F32E4B571C50BBC0E5DBD816682DC30AB8FD46A216E0E6EABC161574960D003D9F60D4AB2D419F050F0AB032A225C75411EDCB72BBD0E6F6B24DE0F33B90EE9059922393D8367702F38B5484CEF23F70357D8AC0B6759C860EE874A6BF66167B4B6C1FA9277E00B98F35A061CCFE9D26DE1678F712A26C69, 5, 5, 26)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (21, N'furkand', N'furkand', NULL, N'furkand', 0xE7790D0499D3B6FA722CFB51F53B9EA97C88E33769DE46975A39C5DB71947D0AC97C30CD1F350B126FDEDC4CF3AC67436E8CA94DAF82BAF86ADEC08C6D17F286, 0xF0B56F37604C8F6AF29862F351CB917D56F7EE717E6970A1A99BA809DACD051566DD4E9239C1B1C89246CAEBACABE6B82E5EE03BDDD074871A636B4A769FA5BC46EB3C9C141B4B6E627A9E266AD267C56646E5099EC79514484A62CF9B5027192F0D44E909BEFB80C53557BB08327FEF1F2C5A2A9D47530BDBCDB505D8284689, 4, 1, 8)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (22, N'Seda', N's', N'5456464', N'asdsad', NULL, NULL, 6, 1, 26)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (23, N'Sibel', N's', N'465645', N'fgfd', NULL, NULL, 6, 2, 23)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (24, N'Ahmet', N'a', N'45646', N'sdasda', NULL, NULL, 6, 3, 23)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (25, N'Mehmet', N'm', N'45654', N'adsas', NULL, NULL, 6, 4, 24)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (26, N'Nejdet', N'n', N'456', N'sadsda', NULL, NULL, 6, 5, 25)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (27, N'Gizem', N'Akgün', N'5466', N'dsadas', NULL, NULL, 6, 6, 26)
INSERT [dbo].[Employee] ([ID], [Name], [Surname], [PhoneNumber], [Email], [PasswordHash], [PasswordSalt], [BusinessUnitID], [TitleID], [UpperEmployeeID]) VALUES (28, N'Test', N'Muhasebeci', N'4564', N'asddsa', NULL, NULL, 6, 7, 26)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[EmployeeProject] ([EmployeeID], [ProjectID]) VALUES (7, 3)
INSERT [dbo].[EmployeeProject] ([EmployeeID], [ProjectID]) VALUES (8, 4)
INSERT [dbo].[EmployeeProject] ([EmployeeID], [ProjectID]) VALUES (9, 5)
INSERT [dbo].[EmployeeProject] ([EmployeeID], [ProjectID]) VALUES (10, 6)
GO
SET IDENTITY_INSERT [dbo].[Page] ON 

INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (2, N'Yeni Avans Talebi', N'/Advance/AdvanceRequest')
INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (3, N'Geçmiş Avans Taleplerim', N'/Advance/MyAdvanceRequests')
INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (4, N'Onay Bekleyen Talepler', N'/Advance/PendingAdvanceRequests')
INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (5, N'Ödeme Tarihi Bekleyen Talepler', N'/Advance/PendingAdvanceRequests')
INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (6, N'Avans Raporlama', N'/Advance/AdvanceReport')
INSERT [dbo].[Page] ([PageID], [PageName], [Path]) VALUES (7, N'Avans Listesi', N'/Advance/AdvanceList')
SET IDENTITY_INSERT [dbo].[Page] OFF
GO
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([ID], [DeterminedPaymentDate], [FinanceManagerID], [AdvanceID]) VALUES (3, CAST(N'2023-12-12T00:00:00.000' AS DateTime), 6, NULL)
INSERT [dbo].[Payment] ([ID], [DeterminedPaymentDate], [FinanceManagerID], [AdvanceID]) VALUES (4, CAST(N'2022-11-24T00:00:00.000' AS DateTime), 6, NULL)
INSERT [dbo].[Payment] ([ID], [DeterminedPaymentDate], [FinanceManagerID], [AdvanceID]) VALUES (5, CAST(N'2020-06-10T00:00:00.000' AS DateTime), 6, NULL)
INSERT [dbo].[Payment] ([ID], [DeterminedPaymentDate], [FinanceManagerID], [AdvanceID]) VALUES (6, CAST(N'2019-07-18T00:00:00.000' AS DateTime), 6, NULL)
INSERT [dbo].[Payment] ([ID], [DeterminedPaymentDate], [FinanceManagerID], [AdvanceID]) VALUES (7, CAST(N'2019-07-18T00:00:00.000' AS DateTime), 22, 13)
SET IDENTITY_INSERT [dbo].[Payment] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([ID], [ProjectName], [ProjectDescription], [EndDate], [StartingDate]) VALUES (3, N'Turkcell Varlık Zimmet Projesi', N'Bu projede varlıkların zimmete atanma durumları kontrol edilir.', CAST(N'2023-12-12T00:00:00.000' AS DateTime), CAST(N'2022-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Project] ([ID], [ProjectName], [ProjectDescription], [EndDate], [StartingDate]) VALUES (4, N'Avans Projesi', N'Proje avans yönetimi gerçekleştirir', CAST(N'2022-11-24T00:00:00.000' AS DateTime), CAST(N'2019-10-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Project] ([ID], [ProjectName], [ProjectDescription], [EndDate], [StartingDate]) VALUES (5, N'Fineksus FM projesi', N'FM Tech', CAST(N'2022-05-20T00:00:00.000' AS DateTime), CAST(N'2020-05-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Project] ([ID], [ProjectName], [ProjectDescription], [EndDate], [StartingDate]) VALUES (6, N'Bilge Adam .NET Dönüşümü', N'Enes yapacak dönüşümü 2 tane log kullansın', CAST(N'2019-10-12T00:00:00.000' AS DateTime), CAST(N'2017-10-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
SET IDENTITY_INSERT [dbo].[Receipt] ON 

INSERT [dbo].[Receipt] ([ID], [ReceiptNo], [isRefundReceipt], [AdvanceID], [Date], [AccountantID]) VALUES (2, N'1452156', 1, 3, CAST(N'2023-05-12T00:00:00.000' AS DateTime), 9)
INSERT [dbo].[Receipt] ([ID], [ReceiptNo], [isRefundReceipt], [AdvanceID], [Date], [AccountantID]) VALUES (3, N'5666355', 1, 4, CAST(N'2022-05-20T00:00:00.000' AS DateTime), 9)
INSERT [dbo].[Receipt] ([ID], [ReceiptNo], [isRefundReceipt], [AdvanceID], [Date], [AccountantID]) VALUES (4, N'6544532', 0, 5, CAST(N'2023-02-02T00:00:00.000' AS DateTime), 9)
INSERT [dbo].[Receipt] ([ID], [ReceiptNo], [isRefundReceipt], [AdvanceID], [Date], [AccountantID]) VALUES (5, N'1231125', 0, 13, CAST(N'2023-02-02T00:00:00.000' AS DateTime), 28)
INSERT [dbo].[Receipt] ([ID], [ReceiptNo], [isRefundReceipt], [AdvanceID], [Date], [AccountantID]) VALUES (6, N'1231126', 1, 13, CAST(N'2023-02-02T00:00:00.000' AS DateTime), 28)
SET IDENTITY_INSERT [dbo].[Receipt] OFF
GO
SET IDENTITY_INSERT [dbo].[Rule] ON 

INSERT [dbo].[Rule] ([ID], [MaxAmount], [MinAmount], [Date], [TitleID]) VALUES (1, 1000.0000, 0.0000, CAST(N'2023-12-11T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Rule] ([ID], [MaxAmount], [MinAmount], [Date], [TitleID]) VALUES (2, 5000.0000, 1001.0000, CAST(N'2023-12-11T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Rule] ([ID], [MaxAmount], [MinAmount], [Date], [TitleID]) VALUES (3, 10000.0000, 5001.0000, CAST(N'2023-12-11T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Rule] ([ID], [MaxAmount], [MinAmount], [Date], [TitleID]) VALUES (4, NULL, 10001.0000, CAST(N'2023-12-11T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Rule] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (101, N'Bekliyor')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (102, N'Onaylandı')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (103, N'Reddedildi')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (201, N'Talep Oluşturuldu')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (202, N'BM Onayladı')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (203, N'Direktör Onayladı')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (204, N'GMY Onaylandı')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (205, N'GM Onayladı')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (206, N'FM Tarih Belirledi')
INSERT [dbo].[Status] ([ID], [StatusName]) VALUES (207, N'Avans Teslim Edildi')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Title] ON 

INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (1, N'Finans Müdürü', N'FM')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (2, N'Genel Müdür', N'GM')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (3, N'Genel Müdür Yardımcısı', N'GMY')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (4, N'Direktör', N'D')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (5, N'Birim Müdürü', N'BM')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (6, N'İşçi', N'i')
INSERT [dbo].[Title] ([ID], [TitleName], [TitleDescription]) VALUES (7, N'Muhasebeci', N'M')
SET IDENTITY_INSERT [dbo].[Title] OFF
GO
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 1, 2)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 1, 3)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 2, 2)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 2, 3)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 3, 2)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 3, 3)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 4, 2)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (1, 4, 3)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (2, 1, 4)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (2, 2, 4)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (2, 3, 4)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (2, 4, 4)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (3, 1, 5)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (3, 2, 5)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (3, 3, 5)
INSERT [dbo].[TitleAuthorization] ([TitleID], [AuthorizationID], [PageID]) VALUES (3, 4, 5)
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Project] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Project]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Advance_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[Advance]'))
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Status]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvanceHistory_Advance] FOREIGN KEY([AdvanceID])
REFERENCES [dbo].[Advance] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory] CHECK CONSTRAINT [FK_AdvanceHistory_Advance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvanceHistory_Employee] FOREIGN KEY([TransactorID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory] CHECK CONSTRAINT [FK_AdvanceHistory_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvanceHistory_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AdvanceHistory_Status]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdvanceHistory]'))
ALTER TABLE [dbo].[AdvanceHistory] CHECK CONSTRAINT [FK_AdvanceHistory_Status]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_BusinessUnit]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_BusinessUnit] FOREIGN KEY([BusinessUnitID])
REFERENCES [dbo].[BusinessUnit] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_BusinessUnit]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_BusinessUnit]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([UpperEmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Title]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeProject_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeProject]'))
ALTER TABLE [dbo].[EmployeeProject]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProject_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeProject_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeProject]'))
ALTER TABLE [dbo].[EmployeeProject] CHECK CONSTRAINT [FK_EmployeeProject_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeProject_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeProject]'))
ALTER TABLE [dbo].[EmployeeProject]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProject_Project] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeProject_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeProject]'))
ALTER TABLE [dbo].[EmployeeProject] CHECK CONSTRAINT [FK_EmployeeProject_Project]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Advance] FOREIGN KEY([AdvanceID])
REFERENCES [dbo].[Advance] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Advance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Employee] FOREIGN KEY([FinanceManagerID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Receipt_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[Receipt]'))
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Advance] FOREIGN KEY([AdvanceID])
REFERENCES [dbo].[Advance] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Receipt_Advance]') AND parent_object_id = OBJECT_ID(N'[dbo].[Receipt]'))
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Advance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Receipt_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Receipt]'))
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Employee] FOREIGN KEY([AccountantID])
REFERENCES [dbo].[Employee] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Receipt_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[Receipt]'))
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Rule_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[Rule]'))
ALTER TABLE [dbo].[Rule]  WITH CHECK ADD  CONSTRAINT [FK_Rule_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Rule_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[Rule]'))
ALTER TABLE [dbo].[Rule] CHECK CONSTRAINT [FK_Rule_Title]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Authorization]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization]  WITH CHECK ADD  CONSTRAINT [FK_TitleAuthorization_Authorization] FOREIGN KEY([AuthorizationID])
REFERENCES [dbo].[Authorization] ([AuthorizationID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Authorization]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization] CHECK CONSTRAINT [FK_TitleAuthorization_Authorization]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization]  WITH CHECK ADD  CONSTRAINT [FK_TitleAuthorization_Page] FOREIGN KEY([PageID])
REFERENCES [dbo].[Page] ([PageID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization] CHECK CONSTRAINT [FK_TitleAuthorization_Page]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization]  WITH CHECK ADD  CONSTRAINT [FK_TitleAuthorization_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TitleAuthorization_Title]') AND parent_object_id = OBJECT_ID(N'[dbo].[TitleAuthorization]'))
ALTER TABLE [dbo].[TitleAuthorization] CHECK CONSTRAINT [FK_TitleAuthorization_Title]
GO
