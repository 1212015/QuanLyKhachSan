USE [QuanLyKhachHang]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/07/2016 9:14:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[Hoten] [varchar](50) NULL,
	[DiaChi] [varchar](100) NULL,
	[GioiTinh] [varchar](50) NULL,
	[SoThich] [varchar](50) NULL,
 CONSTRAINT [PK__KhachHan__2725CF1EBC1F5265] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
