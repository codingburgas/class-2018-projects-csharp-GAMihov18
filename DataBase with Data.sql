USE [master]
GO
/****** Object:  Database [GameDatabase]    Script Date: 03/06/2022 12:48:45 ******/
CREATE DATABASE [GameDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GameDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GameDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GameDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GameDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GameDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GameDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GameDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GameDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GameDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GameDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GameDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [GameDatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GameDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GameDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GameDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GameDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GameDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GameDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GameDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GameDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GameDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GameDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GameDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GameDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GameDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GameDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GameDatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GameDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GameDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GameDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [GameDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GameDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GameDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GameDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GameDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GameDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GameDatabase] SET QUERY_STORE = OFF
GO
USE [GameDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArmorDatas]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArmorDatas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArmorCommonDataId] [int] NOT NULL,
	[AssemblyArmor] [float] NOT NULL,
	[ArmorRarity] [int] NOT NULL,
	[ArmorType] [int] NOT NULL,
	[ArmorEquipSlot] [int] NOT NULL,
	[FirstProtectionArea] [int] NOT NULL,
	[SecondProtectionArea] [int] NOT NULL,
	[ThirdProtectionArea] [int] NOT NULL,
	[SlashingResistance] [float] NOT NULL,
	[PiercingResistance] [float] NOT NULL,
	[BluntResistance] [float] NOT NULL,
	[FireResistance] [float] NOT NULL,
	[WaterResistance] [float] NOT NULL,
	[EarthResistance] [float] NOT NULL,
	[AirResistance] [float] NOT NULL,
	[LuxResistance] [float] NOT NULL,
	[VoidResistance] [float] NOT NULL,
 CONSTRAINT [PK_ArmorDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CharacterDatas]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharacterDatas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MainHandId] [int] NULL,
	[HeadId] [int] NULL,
	[ShouldersId] [int] NULL,
	[ArmsId] [int] NULL,
	[HandsId] [int] NULL,
	[WaistId] [int] NULL,
	[ChestId] [int] NULL,
	[LegsId] [int] NULL,
	[FeetId] [int] NULL,
	[Health] [float] NOT NULL,
	[Stamina] [float] NOT NULL,
	[StaminaRegenerationRate] [float] NOT NULL,
	[Mana] [float] NOT NULL,
	[ManaRegenerationRate] [float] NOT NULL,
	[OffHandId] [int] NULL,
 CONSTRAINT [PK_CharacterDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ItemType] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCharacters]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCharacters](
	[CharacterId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_UserCharacters] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[CharacterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](24) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
	[Salt] [nvarchar](4) NOT NULL,
	[Email] [nvarchar](128) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeaponDatas]    Script Date: 03/06/2022 12:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeaponDatas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WeaponCommonDataId] [int] NOT NULL,
	[AssemblyDamage] [float] NOT NULL,
	[CritRate] [float] NOT NULL,
	[CritMult] [float] NOT NULL,
	[WeaponType] [int] NOT NULL,
	[WeaponRarity] [int] NOT NULL,
	[PhysicalDamageType] [int] NOT NULL,
	[MagicalDamageType] [int] NOT NULL,
	[MainDamageType] [int] NOT NULL,
 CONSTRAINT [PK_WeaponDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220517092827_Initial Migration', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220517093921_Add Users Table to Database', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220517103529_Add constraints to Users table', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220517111852_Add unique keys to User name and email', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220521182339_Add characted data and character link to users', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220521183928_Add Armor data', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220521200022_Update Armor Table', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220530163115_Add WeaponDatas table to the database', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601112229_Test new idea', N'6.0.5')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601124111_Return off hand field', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[ArmorDatas] ON 
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (1, 1, 3272.8235360140766, 5, 1, 0, 0, -1, -1, 0.015858154643191364, 0.0085092570317232552, 0.20538522984651242, 0.064022272484087608, 0.094408920735183074, 0.05774624578635193, 0.18992784100247709, 0.082666451608372826, 0.032126798511633629)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (2, 2, 2194.3864017681572, 2, 1, 1, 1, -1, -1, 0, 0, 0, 0.1458463129618548, 0.15797405678765336, 0.12258355510687681, 0.0746891139245134, 0.19828916348276079, 0.010897199065468544)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (3, 3, 2292.1332497100539, 3, 2, 3, 2, -1, -1, 0.0090435734291627878, 0.037432252116906158, 0.23142179549346786, 0.4659237494700218, 0.39340951740325114, 0.20502150487513166, 0.394782328439634, 0.24588198508565165, 0.28233579749536508)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (4, 4, 1921.5393141707427, 3, 1, 4, 3, -1, -1, 0.096736406239473036, 0.0071254371180796416, 0.15094870272758434, 0.20142994474558912, 0.15907248477943187, 0.10715137465840514, 0.19887977821956335, 0.069952630853756026, 0.050557098024920484)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (5, 5, 1926.8951077648376, 4, 2, 5, 4, -1, -1, 0.084518229153548563, 0.046791886907153718, 0.13567751768317543, 0.47803800616244441, 0.31167914645148087, 0.26101703862900605, 0.47287886905867371, 0.29787831177825108, 0.47170929628563507)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (6, 6, 2427.843776316734, 2, 1, 2, 5, 4, -1, 0, 0, 0, 0.098635211835695416, 0.1989522313039935, 0.090273100061599346, 0.087875962212520864, 0.053887368199280541, 0.18319994819297591)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (7, 7, 4585.8143275683342, 5, 1, 6, 6, 7, -1, 0.12420223283165575, 0.018255176323759531, 0.11273187282441231, 0.20030979788637987, 0.18614932260793329, 0.18278214940280696, 0.097869440604069838, 0.17800803205427257, 0.13375606069998677)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (8, 8, 1844.2404579346191, 3, 2, 7, 7, -1, -1, -0.072558692959892562, 0.10035964381258219, 0.13712795126587696, 0.16481563364054069, 0.15358709108218788, 0.34744341025704772, 0.40841118560266643, 0.16807377496692261, 0.16797014101445543)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (9, 10, 3408.0919603065895, 2, 1, 0, 0, 1, -1, 0, 0, 0, 0.191708761215374, 0.10825101258065642, 0.11136038372311354, 0.023057078579929249, 0.042195238237622647, 0.04271293739623002)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (10, 11, 4882.2196927986424, 4, 1, 1, 1, -1, -1, 0.14396656900751029, 0.10671998932749388, 0.198053227688042, 0.037002582254309711, 0.13887155230240519, 0.11926206147572614, 0.19991193414624789, 0.088514495053018852, 0.064917644402523511)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (11, 12, 1381.3750069104601, 0, 2, 3, 2, -1, -1, 0, 0, 0, 0.32241306322825525, 0.15188928879215674, 0.14565943370865009, 0.23215216549584669, 0.13126993342988769, 0.31188122113455941)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (12, 13, 3081.60345065682, 5, 0, 4, 3, -1, -1, 0.36124552012177963, 0.096581484079138136, -0.016312894595548244, 0.068606784048376, 0.0031160421279684426, 0.017831879550065467, 0.071585964005102934, 0.026809700414267348, 0.10127244468057384)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (13, 14, 4242.8737160367064, 5, 1, 5, 4, -1, -1, 0.15317328122773818, -0.041763174082970464, 0.16436030525073478, 0.16774547641490153, 0.077370346463898745, 0.04579768938542763, 0.060003066121782862, 0.10571408704561162, 0.16652898646281539)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (14, 15, 5052.916642034681, 4, 1, 2, 5, -1, -1, 0.056844329032205092, 0.017141675853659721, 0.14411551039002718, 0.013521835797997454, 0.061313424237958887, 0.12963961713172761, 0.18361464928987628, 0.12762934689718986, 0.15220177688271772)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (15, 16, 5043.2709890542355, 6, 0, 6, 6, 7, -1, 0.3968283616935071, 0.085776048338030542, -0.18378326192692848, 0.10154059949940664, 0.087058442651634191, 0.0073010679486070753, 0.0766591501722171, 0.0067437191518941956, 0.10074168572041711)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (16, 17, 2489.0747473621718, 3, 1, 7, 7, -1, -1, 0.14478928650385378, -0.033695706053983837, 0.041411507248923493, 0.066982016962700813, 0.14260037465168524, 0.034066024915340352, 0.17818145118031872, 0.0089764495743807609, 0.20295836851360843)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (17, 19, 1688.331113139287, 4, 2, 0, 0, -1, -1, 0.014928950701679405, 0.013262245299452009, 0.12120093918838701, 0.439734070788689, 0.11677165756939638, 0.3877433947614406, 0.48750515445595244, 0.41254516066641589, 0.11629255494379739)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (18, 20, 3304.4841189697859, 5, 0, 1, 1, -1, -1, 0.27077775163695378, -0.19967429611995324, -0.038826986588776674, 0.065281504264492557, 0.051352153325478156, 0.080257307463276015, 0.0407720156726737, 0.085825057221449369, 0.0061169907210590138)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (19, 21, 2870.6566927878503, 4, 0, 3, 2, 3, -1, 0.18436653123412197, -0.0037507062769885358, -0.16371038210765349, 0.086778371119653072, 0.025959064422653014, 0.084750758366184384, 0.021816552482294298, 0.10258621728312775, 0.09409669914592203)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (20, 22, 1240.4038404359958, 2, 2, 4, 3, -1, -1, 0, 0, 0, 0.46060575614317267, 0.37856909866936983, 0.29071859995088095, 0.30608549367354088, 0.38193044562678213, 0.1896272659865019)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (21, 23, 629.01112684301825, 2, 2, 5, 4, -1, -1, 0, 0, 0, 0.26030727749003557, 0.48113907143374723, 0.23412279059402288, 0.33875942785191826, 0.46039004659604588, 0.12997035034769658)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (22, 24, 1514.2257743378571, 2, 2, 2, 5, -1, -1, 0, 0, 0, 0.32351167494862454, 0.26915226693737393, 0.20428481445555416, 0.30022264697254447, 0.21369857706555945, 0.39907976136109158)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (23, 25, 1006.1375879896489, 0, 2, 6, 6, -1, -1, 0, 0, 0, 0.3549706094313535, 0.36532698308362588, 0.3928973582312314, 0.20062134966744294, 0.34520525048891704, 0.36648163909733467)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (24, 26, 3652.7711421523773, 6, 2, 7, 7, -1, -1, 0.06409235680015804, 0.086974307245876889, 0.15694467338449117, 0.19968084045627421, 0.33131600606859946, 0.30088634285838889, 0.42024497513342041, 0.1410462200301994, 0.3410135021170097)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (25, 28, 4053.4076494433489, 1, 0, 0, 0, 1, 5, 0, 0, 0, 0.052215480763869858, 0.093228138498041124, 0.0776420069396212, 0.04264540910340759, 0.049788968690075472, 0.010112997876501795)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (26, 29, 2425.6061850647816, 3, 1, 1, 1, -1, -1, 0.10044213899491117, -0.088123297485325644, 0.045524199343595827, 0.1219077639962781, 0.13015029235140749, 0.11687116196512666, 0.035102878292587618, 0.13153951136089015, 0.1544038765293973)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (27, 30, 2011.4827131421882, 3, 0, 3, 2, -1, -1, 0.17768257549270627, -0.029927322893059161, -0.078067656979207881, 0.081301898712576079, 0.10958082151986009, 0.03500268873008331, 0.092835417307532822, 0.013131655334845888, 0.097832054384095576)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (28, 31, 1061.1348687333577, 0, 0, 4, 3, -1, -1, 0, 0, 0, 0.076758947168845487, 0.086108075961182445, 0.044995065837881709, 0.10426821426228256, 0.054246245450004088, 0.0430075337203959)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (29, 32, 1070.2427653713812, 2, 1, 5, 4, -1, -1, 0, 0, 0, 0.014104532903633067, 0.026203630515791533, 0.11289513926753238, 0.15527009988155693, 0.10491670460464334, 0.19970847812458703)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (30, 33, 2458.3072046444236, 1, 1, 2, 5, -1, -1, 0, 0, 0, 0.17553295277225572, 0.14470808280554867, 0.2037148835389484, 0.088053601212816718, 0.19555288883387123, 0.098229477499590545)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (31, 34, 2399.7681517131127, 2, 2, 6, 6, -1, -1, 0, 0, 0, 0.20556974964305119, 0.13148692730289391, 0.44764497894211364, 0.50876043363607826, 0.20250667820951274, 0.12836319312178118)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (32, 35, 629.35544667416934, 0, 2, 7, 7, -1, -1, 0, 0, 0, 0.30308693830252764, 0.38261275767445291, 0.44176800703796837, 0.20249695000184412, 0.14138953825151174, 0.10912933185559998)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (33, 37, 4557.8210418522085, 6, 0, 0, 0, -1, -1, 0.20375650094460679, -0.028600672688702949, 0.027679974936906937, 0.084226980659133713, 0.037427572981520316, 0.0048915748469988028, 0.07899022711991098, 0.037368763660717445, 0.10768761263498433)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (34, 38, 651.796014822231, 0, 2, 1, 1, -1, -1, 0, 0, 0, 0.34162936216343032, 0.45622680998711673, 0.20912106257310642, 0.39254182560624484, 0.26966742411152855, 0.295161878135287)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (35, 39, 1514.3859323151698, 3, 2, 3, 2, 3, -1, 0.025228927396435563, 0.10404711183531272, 0.2173556355223987, 0.17098658942846595, 0.13921110578733736, 0.23990769522252806, 0.16153928046095048, 0.40894527170604822, 0.38870413314995911)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (36, 40, 2310.957499622798, 4, 1, 4, 3, -1, -1, 0.11589599058989865, 0.081179456191909971, 0.0085551153501074728, 0.13719565850488943, 0.17169273520290221, 0.17282641120684422, 0.052807872104369893, 0.027912161013199766, 0.10304715063145516)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (37, 41, 3208.4423413273962, 3, 0, 5, 4, -1, -1, 0.30152330037228092, -0.19965567674425755, 0.14457785108720411, 0.0164429684145006, 0.088575578663717111, 0.045273439728036637, 0.05174071869558982, 0.083192010091882443, 0.050931581684005488)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (38, 42, 3681.9616569698142, 4, 0, 2, 5, -1, -1, 0.34302304772264608, -0.10590349785512851, 0.13983934438546197, 0.0945713789868671, 0.029358991753553828, 0.08348893011081418, 0.07945425151084913, 0.067553555096255422, 0.013230448078164031)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (39, 43, 889.62061926309491, 0, 0, 6, 6, -1, -1, 0, 0, 0, 0.010616760044729556, 0.0047065144802626406, 0.039245615322497436, 0.040033115985014994, 0.029757476824323271, 0.054380278350007361)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (40, 44, 1122.8050330592539, 1, 0, 7, 7, -1, -1, 0, 0, 0, 0.056790435197295805, 0.042758925372715861, 0.087389913801155947, 0.002278830861965887, 0.0698455508131434, 0.057553342380277907)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (41, 46, 1077.2511281213926, 0, 0, 0, 0, -1, -1, 0, 0, 0, 0.10578845219770619, 0.00910620275873122, 0.077586198592875869, 0.10921213829406402, 0.10879335677502465, 0.038951287583362429)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (42, 47, 2824.5650983348523, 5, 2, 1, 1, -1, -1, -0.026857266980860051, 0.038259789448845373, 0.292792078697568, 0.32963423044931289, 0.24375562977932308, 0.11427158943612414, 0.41517704240067133, 0.10850741895794162, 0.10504237426682145)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (43, 48, 2213.0238794309666, 0, 0, 3, 2, -1, -1, 0, 0, 0, 0.041372364807150459, 0.021385782185757939, 0.024749762361771663, 0.0096778301861287167, 0.0034404511726800736, 0.054617598391422259)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (44, 49, 4505.4851503258224, 3, 0, 4, 3, -1, -1, 0.32932826540199761, -0.034505001178386674, -0.0032381733020505621, 0.076724094462658585, 0.087410003472215891, 0.01462053252776364, 0.089319325351512255, 0.10302764679542649, 0.056981312089036076)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (45, 50, 2490.22740581505, 2, 0, 5, 4, -1, -1, 0, 0, 0, 0.013104442236673827, 0.019911390690252578, 0.031263858560412694, 0.042697361147987493, 0.044806146348199766, 0.040351302342049915)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (46, 51, 6131.4149784463925, 5, 1, 2, 5, -1, -1, 0.045409257633338494, -0.099392002920065753, 0.010564620537867477, 0.035647953179068013, 0.086578885122267607, 0.0017313920638693358, 0.17455720324330484, 0.03539412554553454, 0.097928946320244972)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (47, 52, 2087.9970097635555, 0, 1, 6, 6, -1, -1, 0, 0, 0, 0.20012107333781057, 0.021968933013294754, 0.0036946311904745167, 0.2017929782099552, 0.13545146273031217, 0.10392887445355088)
GO
INSERT [dbo].[ArmorDatas] ([Id], [ArmorCommonDataId], [AssemblyArmor], [ArmorRarity], [ArmorType], [ArmorEquipSlot], [FirstProtectionArea], [SecondProtectionArea], [ThirdProtectionArea], [SlashingResistance], [PiercingResistance], [BluntResistance], [FireResistance], [WaterResistance], [EarthResistance], [AirResistance], [LuxResistance], [VoidResistance]) VALUES (48, 53, 809.60520241695735, 3, 2, 7, 7, -1, -1, 0.03646096422657, 0.10290311391213242, 0.1828851228913404, 0.20826926867135434, 0.39510053855561489, 0.12407351733354967, 0.44521749639377861, 0.1447824237010181, 0.17837446717246955)
GO
SET IDENTITY_INSERT [dbo].[ArmorDatas] OFF
GO
SET IDENTITY_INSERT [dbo].[CharacterDatas] ON 
GO
INSERT [dbo].[CharacterDatas] ([Id], [MainHandId], [HeadId], [ShouldersId], [ArmsId], [HandsId], [WaistId], [ChestId], [LegsId], [FeetId], [Health], [Stamina], [StaminaRegenerationRate], [Mana], [ManaRegenerationRate], [OffHandId]) VALUES (1, 2, 9, 10, 11, 12, 13, 14, 15, 16, 0, 0, 0, 0, 0, NULL)
GO
INSERT [dbo].[CharacterDatas] ([Id], [MainHandId], [HeadId], [ShouldersId], [ArmsId], [HandsId], [WaistId], [ChestId], [LegsId], [FeetId], [Health], [Stamina], [StaminaRegenerationRate], [Mana], [ManaRegenerationRate], [OffHandId]) VALUES (2, 3, 17, 18, 19, 20, 21, 22, 23, 24, 2268.5212365596244, 626.22597058684983, 67.244447404888319, 361.76180537616358, 31.592039079455571, NULL)
GO
INSERT [dbo].[CharacterDatas] ([Id], [MainHandId], [HeadId], [ShouldersId], [ArmsId], [HandsId], [WaistId], [ChestId], [LegsId], [FeetId], [Health], [Stamina], [StaminaRegenerationRate], [Mana], [ManaRegenerationRate], [OffHandId]) VALUES (3, 4, 25, 26, 27, 28, 29, 30, 31, 32, 1093.0291121363239, 403.75873862236108, 33.738704504468046, 594.88725015981368, 32.732499948340369, NULL)
GO
INSERT [dbo].[CharacterDatas] ([Id], [MainHandId], [HeadId], [ShouldersId], [ArmsId], [HandsId], [WaistId], [ChestId], [LegsId], [FeetId], [Health], [Stamina], [StaminaRegenerationRate], [Mana], [ManaRegenerationRate], [OffHandId]) VALUES (4, 5, 33, 34, 35, 36, 37, 38, 39, 40, 2468.662095071888, 321.87037829101064, 33.066881580333494, 877.88298491682906, 53.049079454379708, NULL)
GO
INSERT [dbo].[CharacterDatas] ([Id], [MainHandId], [HeadId], [ShouldersId], [ArmsId], [HandsId], [WaistId], [ChestId], [LegsId], [FeetId], [Health], [Stamina], [StaminaRegenerationRate], [Mana], [ManaRegenerationRate], [OffHandId]) VALUES (5, 6, 41, 42, 43, 44, 45, 46, 47, 48, 1102.935596651947, 347.61384215371146, 42.306138890294605, 687.736327390482, 56.425615456961637, NULL)
GO
SET IDENTITY_INSERT [dbo].[CharacterDatas] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (1, N'Mythic Medium Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (2, N'Rare Medium Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (3, N'Ultra Rare Light Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (4, N'Ultra Rare Medium Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (5, N'Legendary Light Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (6, N'Rare Medium Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (7, N'Mythic Medium Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (8, N'Ultra Rare Light Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (9, N'Legendary Hammer of Bludgeoning', 0)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (10, N'Rare Medium Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (11, N'Legendary Medium Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (12, N'Common Light Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (13, N'Mythic Heavy Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (14, N'Mythic Medium Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (15, N'Legendary Medium Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (16, N'Special Heavy Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (17, N'Ultra Rare Medium Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (18, N'Rare Rapier of Piercing', 0)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (19, N'Legendary Light Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (20, N'Mythic Heavy Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (21, N'Legendary Heavy Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (22, N'Rare Light Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (23, N'Rare Light Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (24, N'Rare Light Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (25, N'Common Light Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (26, N'Special Light Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (27, N'Mythic Bastard Sword of Slashing', 0)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (28, N'Uncommon Heavy Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (29, N'Ultra Rare Medium Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (30, N'Ultra Rare Heavy Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (31, N'Common Heavy Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (32, N'Rare Medium Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (33, N'Uncommon Medium Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (34, N'Rare Light Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (35, N'Common Light Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (36, N'Common Dagger of Piercing', 0)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (37, N'Special Heavy Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (38, N'Common Light Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (39, N'Ultra Rare Light Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (40, N'Legendary Medium Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (41, N'Ultra Rare Heavy Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (42, N'Legendary Heavy Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (43, N'Common Heavy Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (44, N'Uncommon Heavy Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (45, N'Special Battle Axe of Slashing', 0)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (46, N'Common Heavy Helmet', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (47, N'Mythic Light Shoulderplates', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (48, N'Common Heavy Sleeves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (49, N'Ultra Rare Heavy Gloves', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (50, N'Rare Heavy Belt', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (51, N'Mythic Medium Chestplate', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (52, N'Common Medium Leggings', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (53, N'Ultra Rare Light Shoes', 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [ItemType]) VALUES (54, N'Legendary Hammer of Bludgeoning', 0)
GO
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [Salt], [Email], [Age]) VALUES (4, N'admin', N'fe0b694be75bae17e371436c4d264257c04f3139584371ef991271d0b83a2108', N'7628', N'gamih@coddkka', 15)
GO
INSERT [dbo].[Users] ([Id], [Name], [Password], [Salt], [Email], [Age]) VALUES (6, N'gakak', N'098144e6f09ebc6e7804d140a74956e4c016b2ddaaa7c70cd70e4eafd3b73dee', N'0136', N'gami@coddkka', 15)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[WeaponDatas] ON 
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (1, 9, 733.08496348857682, 0.13320058366805263, 3.4431655662946654, 9, 4, 2, 8, 2)
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (2, 18, 606.381311730756, 0.013175986818750219, 2.9757138038755895, 13, 2, 1, 4, 1)
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (3, 27, 408.48627206333344, 0.055948273810108549, 3.5901556996618957, 4, 5, 0, 5, 0)
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (4, 36, 274.98139954088543, 0.048480034775548908, 1.4049348449600043, 1, 0, 1, 4, 1)
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (5, 45, 841.92166526282563, 0.10903118373451262, 3.364204089657846, 12, 6, 0, 3, 0)
GO
INSERT [dbo].[WeaponDatas] ([Id], [WeaponCommonDataId], [AssemblyDamage], [CritRate], [CritMult], [WeaponType], [WeaponRarity], [PhysicalDamageType], [MagicalDamageType], [MainDamageType]) VALUES (6, 54, 1108.5690747918779, 0.051170958832659472, 3.5680075912379663, 9, 4, 2, 7, 2)
GO
SET IDENTITY_INSERT [dbo].[WeaponDatas] OFF
GO
/****** Object:  Index [IX_ArmorDatas_ArmorCommonDataId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_ArmorDatas_ArmorCommonDataId] ON [dbo].[ArmorDatas]
(
	[ArmorCommonDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_ArmsId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_ArmsId] ON [dbo].[CharacterDatas]
(
	[ArmsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_ChestId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_ChestId] ON [dbo].[CharacterDatas]
(
	[ChestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_FeetId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_FeetId] ON [dbo].[CharacterDatas]
(
	[FeetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_HandsId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_HandsId] ON [dbo].[CharacterDatas]
(
	[HandsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_HeadId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_HeadId] ON [dbo].[CharacterDatas]
(
	[HeadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_LegsId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_LegsId] ON [dbo].[CharacterDatas]
(
	[LegsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_MainHandId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_MainHandId] ON [dbo].[CharacterDatas]
(
	[MainHandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_OffHandId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_OffHandId] ON [dbo].[CharacterDatas]
(
	[OffHandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_ShouldersId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_ShouldersId] ON [dbo].[CharacterDatas]
(
	[ShouldersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CharacterDatas_WaistId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_CharacterDatas_WaistId] ON [dbo].[CharacterDatas]
(
	[WaistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserCharacters_CharacterId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_UserCharacters_CharacterId] ON [dbo].[UserCharacters]
(
	[CharacterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Email]    Script Date: 03/06/2022 12:48:46 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Email] ON [dbo].[Users]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Name]    Script Date: 03/06/2022 12:48:46 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Name] ON [dbo].[Users]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_WeaponDatas_WeaponCommonDataId]    Script Date: 03/06/2022 12:48:46 ******/
CREATE NONCLUSTERED INDEX [IX_WeaponDatas_WeaponCommonDataId] ON [dbo].[WeaponDatas]
(
	[WeaponCommonDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ArmorDatas] ADD  DEFAULT ((0)) FOR [SecondProtectionArea]
GO
ALTER TABLE [dbo].[ArmorDatas] ADD  DEFAULT ((0)) FOR [ThirdProtectionArea]
GO
ALTER TABLE [dbo].[ArmorDatas]  WITH CHECK ADD  CONSTRAINT [FK_ArmorDatas_Items_ArmorCommonDataId] FOREIGN KEY([ArmorCommonDataId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArmorDatas] CHECK CONSTRAINT [FK_ArmorDatas_Items_ArmorCommonDataId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_ArmsId] FOREIGN KEY([ArmsId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_ArmsId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_ChestId] FOREIGN KEY([ChestId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_ChestId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_FeetId] FOREIGN KEY([FeetId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_FeetId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_HandsId] FOREIGN KEY([HandsId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_HandsId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_HeadId] FOREIGN KEY([HeadId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_HeadId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_LegsId] FOREIGN KEY([LegsId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_LegsId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_MainHandId] FOREIGN KEY([MainHandId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_MainHandId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_OffHandId] FOREIGN KEY([OffHandId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_OffHandId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_ShouldersId] FOREIGN KEY([ShouldersId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_ShouldersId]
GO
ALTER TABLE [dbo].[CharacterDatas]  WITH CHECK ADD  CONSTRAINT [FK_CharacterDatas_Items_WaistId] FOREIGN KEY([WaistId])
REFERENCES [dbo].[Items] ([Id])
GO
ALTER TABLE [dbo].[CharacterDatas] CHECK CONSTRAINT [FK_CharacterDatas_Items_WaistId]
GO
ALTER TABLE [dbo].[UserCharacters]  WITH CHECK ADD  CONSTRAINT [FK_UserCharacters_CharacterDatas_CharacterId] FOREIGN KEY([CharacterId])
REFERENCES [dbo].[CharacterDatas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserCharacters] CHECK CONSTRAINT [FK_UserCharacters_CharacterDatas_CharacterId]
GO
ALTER TABLE [dbo].[UserCharacters]  WITH CHECK ADD  CONSTRAINT [FK_UserCharacters_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserCharacters] CHECK CONSTRAINT [FK_UserCharacters_Users_UserId]
GO
ALTER TABLE [dbo].[WeaponDatas]  WITH CHECK ADD  CONSTRAINT [FK_WeaponDatas_Items_WeaponCommonDataId] FOREIGN KEY([WeaponCommonDataId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WeaponDatas] CHECK CONSTRAINT [FK_WeaponDatas_Items_WeaponCommonDataId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_Users_Age] CHECK  (([Age]>(13)))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_Users_Age]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_Users_Email] CHECK  (([Email] like '%@%'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_Users_Email]
GO
USE [master]
GO
ALTER DATABASE [GameDatabase] SET  READ_WRITE 
GO
