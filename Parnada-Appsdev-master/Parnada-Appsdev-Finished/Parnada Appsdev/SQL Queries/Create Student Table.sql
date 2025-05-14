USE [SigmaDb]
GO

/****** Object:  Table [dbo].[StudentsPrins]    Script Date: 14/03/2025 4:04:29 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentsPrins](
	[ID] [int] NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[MiddleName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Course] [varchar](100) NOT NULL,
	[CurriculumYear] [varchar](50) NOT NULL,
	[YearLevel] [int] NOT NULL,
	[Semester] [int] NOT NULL,
	[Remarks] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StudentsPrins] ADD  DEFAULT (abs(checksum(newid()))%(90000000)+(10000000)) FOR [ID]
GO


