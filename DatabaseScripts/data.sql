USE [Giberson]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([personID], [lastName], [givenMiddleName], [dateOfBirth], [gender]) VALUES (1, N'Doe', N'John', CAST(0x62240B00 AS Date), N'male')
SET IDENTITY_INSERT [dbo].[Person] OFF
INSERT [dbo].[Employee] ([employeeID], [hireDate], [userName], [password]) VALUES (1, CAST(0x87370B00 AS Date), N'jdoe', N'password')
