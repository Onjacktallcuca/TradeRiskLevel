USE [Main]
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' 
    AND  TABLE_NAME = 'tblPortfolio')
)
BEGIN
	DROP TABLE [dbo].[tblPortfolio]
END
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
	WHERE TABLE_SCHEMA = 'dbo' 
    AND  TABLE_NAME = 'tblTrade')
)
BEGIN
	DROP TABLE [dbo].[tblTrade]
END
GO

IF (EXISTS (select o.name from dbo.sysobjects o 
			where (o.xtype = N'TF' or o.xtype = N'FN' or o.xtype = N'IF')
			and o.name = 'GetRisk')
)
BEGIN
	DROP FUNCTION GetRisk
END
GO

CREATE TABLE [dbo].[tblTrade](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[Value] [decimal](12, 2) NULL,
	[Sector] [varchar] (20) NULL,
	[RiskLevel] [varchar] (10) NULL,
	[dtInput] [datetime] NULL,
	PRIMARY KEY (Id)
) ON [PRIMARY]

CREATE TABLE [dbo].[tblPortfolio](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[IdTrade] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (IdTrade) REFERENCES tblTrade(id)
) ON [PRIMARY]

GO
--Function to return risk level
CREATE FUNCTION GetRisk(@value decimal(12, 2), @Sector varchar(20))
RETURNS varchar(10)
AS
BEGIN
	DECLARE @Ret VARCHAR(10);  

	BEGIN
		IF (@value < 1000000 AND @Sector = 'Public')
			SET @Ret = 'LOWRISK';

		IF (@value > 1000000 AND @Sector = 'Public')
			SET @Ret = 'MEDIUMRISK';

		IF (@value > 1000000 AND @Sector = 'Private')
			SET @Ret = 'HIGHRISK';
			
	END	

RETURN @Ret 
END



GO
