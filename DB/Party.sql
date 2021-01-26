SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Party](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[emailAddress] [nvarchar](50) NULL,
	[phoneNumber] [nvarchar](50) NULL,
	[quoteTime] [int] NULL,
	[partyTypeid] [int] NOT NULL,
	[partySize] [int] NULL,
	[partyStatusId] [int] NOT NULL,
	[reservationTime] [date] NULL,
	[reservationConfirmed] [bit] NULL,
	[dateCreated] [date] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Party] ADD PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
