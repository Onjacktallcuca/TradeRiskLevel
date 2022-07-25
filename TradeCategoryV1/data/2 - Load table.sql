USE [Main]
GO

INSERT INTO DBO.tblTrade VALUES (2000000, 'Private', NULL, GetDate())
INSERT INTO DBO.tblTrade VALUES (400000, 'Public', NULL, GetDate())
INSERT INTO DBO.tblTrade VALUES (500000, 'Public', NULL, GetDate())
INSERT INTO DBO.tblTrade VALUES (3000000, 'Public', NULL, GetDate())

UPDATE DBO.tblTrade SET RiskLevel = dbo.GetRisk(value, sector)

