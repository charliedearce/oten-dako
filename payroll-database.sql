/*
Navicat SQL Server Data Transfer

Source Server         : LOCAL SQL SERVER
Source Server Version : 100000
Source Host           : CHARLIE-ASUS\SQLEXPRESS:1433
Source Database       : payroll
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 100000
File Encoding         : 65001

Date: 2018-05-03 09:11:21
*/


-- ----------------------------
-- Table structure for biometrics
-- ----------------------------
DROP TABLE [biometrics]
GO
CREATE TABLE [biometrics] (
[id] int NOT NULL IDENTITY(1,1) ,
[USERID] int NULL ,
[CHECKTIME] datetime NULL ,
[CHECKTYPE] varchar(1) NULL 
)


GO
DBCC CHECKIDENT(N'[biometrics]', RESEED, 280409)
GO

-- ----------------------------
-- Records of biometrics
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [biometrics] ON
GO
INSERT INTO [biometrics] ([id], [USERID], [CHECKTIME], [CHECKTYPE]) VALUES (N'280404', N'1', N'2018-04-02 08:19:41.000', N'I'), (N'280405', N'1', N'2018-04-02 12:19:41.000', N'I'), (N'280406', N'1', N'2018-04-02 12:00:41.000', N'O'), (N'280407', N'1', N'2018-04-02 17:00:41.000', N'O'), (N'280408', N'1', N'2018-04-04 08:19:41.000', N'I'), (N'280409', N'1', N'2018-04-04 12:19:41.000', N'O')
GO
GO
SET IDENTITY_INSERT [biometrics] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for deduction
-- ----------------------------
DROP TABLE [deduction]
GO
CREATE TABLE [deduction] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[deduction_type] varchar(255) NULL ,
[amount] float(53) NULL ,
[payroll_no] int NULL ,
[description] varchar(255) NULL ,
[misc_id] int NOT NULL DEFAULT '' 
)


GO
DBCC CHECKIDENT(N'[deduction]', RESEED, 1537)
GO

-- ----------------------------
-- Records of deduction
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [deduction] ON
GO
INSERT INTO [deduction] ([id], [emp_id], [deduction_type], [amount], [payroll_no], [description], [misc_id]) VALUES (N'1528', N'1', N'GVNMNT', N'100', N'3', N'PHILHEALTH', N'0'), (N'1529', N'1', N'GVNMNT', N'0', N'3', N'SSS', N'0'), (N'1530', N'1', N'GVNMNT', N'0', N'3', N'HTAX', N'0'), (N'1531', N'1', N'MISC', N'500', N'3', N'LOAN', N'1'), (N'1532', N'1', N'MISC', N'400', N'3', N'CA', N'2'), (N'1533', N'2', N'GVNMNT', N'30', N'3', N'PHILHEALTH', N'0'), (N'1534', N'2', N'GVNMNT', N'100', N'3', N'SSS', N'0'), (N'1535', N'2', N'GVNMNT', N'50', N'3', N'HTAX', N'0'), (N'1536', N'2', N'MISC', N'200', N'3', N'PAG-IBIG', N'3'), (N'1537', N'2', N'MISC', N'60', N'3', N'LOAN', N'4')
GO
GO
SET IDENTITY_INSERT [deduction] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for earnings
-- ----------------------------
DROP TABLE [earnings]
GO
CREATE TABLE [earnings] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[earning_type] varchar(255) NULL ,
[amount] float(53) NULL ,
[payroll_no] int NULL ,
[description] varchar(255) NULL ,
[date] date NULL 
)


GO
DBCC CHECKIDENT(N'[earnings]', RESEED, 1201)
GO

-- ----------------------------
-- Records of earnings
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [earnings] ON
GO
INSERT INTO [earnings] ([id], [emp_id], [earning_type], [amount], [payroll_no], [description], [date]) VALUES (N'885', N'1', N'WORK', N'1269.23076923077', N'4', N'Regular Work', N'2018-04-05'), (N'886', N'1', N'WORK', N'1650', N'4', N'Work on SH', N'2018-04-06'), (N'887', N'2', N'WORK', N'16.8269230769231', N'4', N'Regular Work', N'2018-04-05'), (N'888', N'2', N'WORK', N'50', N'4', N'Work on SH', N'2018-04-06'), (N'997', N'1', N'WORK', N'1269.23076923077', N'1', N'Regular Work', N'2018-04-05'), (N'998', N'1', N'WORK', N'1650', N'1', N'Work on SH', N'2018-04-06'), (N'999', N'2', N'WORK', N'16.8269230769231', N'1', N'Regular Work', N'2018-04-05'), (N'1000', N'2', N'WORK', N'50', N'1', N'Work on SH', N'2018-04-06'), (N'1001', N'1', N'WORK', N'1269.23076923077', N'2', N'Regular Work', N'2018-04-05'), (N'1002', N'1', N'WORK', N'1650', N'2', N'Work on SH', N'2018-04-06'), (N'1003', N'2', N'WORK', N'16.8269230769231', N'2', N'Regular Work', N'2018-04-05'), (N'1004', N'2', N'WORK', N'50', N'2', N'Work on SH', N'2018-04-06'), (N'1194', N'1', N'WORK', N'584.375', N'3', N'Regular Work', N'2018-04-04'), (N'1195', N'1', N'WORK', N'1269.23076923077', N'3', N'Leave', N'2018-04-05'), (N'1196', N'1', N'WORK', N'1269.23076923077', N'3', N'Special Holiday', N'2018-04-06'), (N'1197', N'1', N'WORK', N'0', N'3', N'Absent', N'2018-04-07'), (N'1198', N'2', N'WORK', N'0', N'3', N'Absent', N'2018-04-04'), (N'1199', N'2', N'WORK', N'0', N'3', N'Absent', N'2018-04-05'), (N'1200', N'2', N'WORK', N'38.4615384615385', N'3', N'Special Holiday', N'2018-04-06'), (N'1201', N'2', N'WORK', N'0', N'3', N'Absent', N'2018-04-07')
GO
GO
SET IDENTITY_INSERT [earnings] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for employees
-- ----------------------------
DROP TABLE [employees]
GO
CREATE TABLE [employees] (
[id] int NOT NULL IDENTITY(1,1) ,
[fname] varchar(255) NULL ,
[lname] varchar(255) NULL ,
[mname] varchar(255) NULL ,
[position] varchar(255) NULL ,
[address] varchar(255) NULL ,
[contact] varchar(255) NULL ,
[base_pay] varchar(255) NULL ,
[sick_leave] varchar(255) NULL ,
[vaca_leave] varchar(255) NULL ,
[status] varchar(255) NULL ,
[type] varchar(255) NULL ,
[ordinary_ns] float(53) NULL ,
[cola] float(53) NULL DEFAULT ((0)) 
)


GO
DBCC CHECKIDENT(N'[employees]', RESEED, 4)
GO

-- ----------------------------
-- Records of employees
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [employees] ON
GO
INSERT INTO [employees] ([id], [fname], [lname], [mname], [position], [address], [contact], [base_pay], [sick_leave], [vaca_leave], [status], [type], [ordinary_ns], [cola]) VALUES (N'1', N'charlie', N'de arce', N'salaber', N'Programmer', N'gensanville', N'09985767237', N'30000', N'10', N'10', N'Active', N'Daily', null, N'0'), (N'2', N'olita', N'olitapa', N'sigepa', N'TagaIlo', N'uhaw', N'09922312', N'1000', N'1', N'1', N'Active', N'Daily', null, N'0')
GO
GO
SET IDENTITY_INSERT [employees] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for holiday
-- ----------------------------
DROP TABLE [holiday]
GO
CREATE TABLE [holiday] (
[description] varchar(255) NULL ,
[date] date NULL ,
[type] varchar(255) NULL ,
[id] int NOT NULL IDENTITY(1,1) ,
[enable] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of holiday
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [holiday] ON
GO
INSERT INTO [holiday] ([description], [date], [type], [id], [enable]) VALUES (N'Ninoy Aquino', N'2018-04-06', N'Special', N'1', N'Y')
GO
GO
SET IDENTITY_INSERT [holiday] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for leave
-- ----------------------------
DROP TABLE [leave]
GO
CREATE TABLE [leave] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[from_leave] date NULL ,
[to_leave] date NULL ,
[description] varchar(255) NULL ,
[days] varchar(255) NULL ,
[approve] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of leave
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [leave] ON
GO
INSERT INTO [leave] ([id], [emp_id], [from_leave], [to_leave], [description], [days], [approve]) VALUES (N'1', N'1', N'2018-04-05', N'2018-04-05', N'test leave', N'1', N'Y')
GO
GO
SET IDENTITY_INSERT [leave] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for misc_deduction
-- ----------------------------
DROP TABLE [misc_deduction]
GO
CREATE TABLE [misc_deduction] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[date] datetime2(7) NULL ,
[description] varchar(255) NULL ,
[amount] varchar(255) NULL ,
[auto] varchar(255) NULL ,
[deduct_type] varchar(255) NULL ,
[amount_type] float(53) NULL 
)


GO
DBCC CHECKIDENT(N'[misc_deduction]', RESEED, 4)
GO

-- ----------------------------
-- Records of misc_deduction
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [misc_deduction] ON
GO
INSERT INTO [misc_deduction] ([id], [emp_id], [date], [description], [amount], [auto], [deduct_type], [amount_type]) VALUES (N'1', N'1', N'2018-05-01 14:27:03.0000000', N'LOAN', N'1000', N'Y', N'PERCENT', N'0.5'), (N'2', N'1', N'2018-05-01 14:34:22.0000000', N'CA', N'2000', N'Y', N'PERCENT', N'0.2'), (N'3', N'2', N'2018-05-01 14:35:33.0000000', N'PAG-IBIG', N'500', N'Y', N'FIX', N'200'), (N'4', N'2', N'2018-05-01 17:23:09.0000000', N'LOAN', N'200', N'Y', N'PERCENT', N'0.3')
GO
GO
SET IDENTITY_INSERT [misc_deduction] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for overtime
-- ----------------------------
DROP TABLE [overtime]
GO
CREATE TABLE [overtime] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[from_time] datetime NULL ,
[to_time] datetime NULL ,
[approve] varchar(255) NULL ,
[description] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of overtime
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [overtime] ON
GO
SET IDENTITY_INSERT [overtime] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for pagibig
-- ----------------------------
DROP TABLE [pagibig]
GO
CREATE TABLE [pagibig] (
[id] int NOT NULL IDENTITY(1,1) ,
[pagibig_from] float(53) NULL ,
[pagibig_to] float(53) NULL ,
[amount] float(53) NULL 
)


GO

-- ----------------------------
-- Records of pagibig
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [pagibig] ON
GO
SET IDENTITY_INSERT [pagibig] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for payroll_info
-- ----------------------------
DROP TABLE [payroll_info]
GO
CREATE TABLE [payroll_info] (
[id] int NOT NULL IDENTITY(1,1) ,
[from_date] date NULL ,
[to_date] date NULL ,
[status] varchar(255) NULL ,
[type] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[payroll_info]', RESEED, 4)
GO

-- ----------------------------
-- Records of payroll_info
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [payroll_info] ON
GO
INSERT INTO [payroll_info] ([id], [from_date], [to_date], [status], [type]) VALUES (N'1', N'2018-04-05', N'2018-04-07', N'Close', N'Regular'), (N'2', N'2018-04-05', N'2018-04-07', N'Close', N'Regular'), (N'3', N'2018-04-04', N'2018-04-07', N'Open', N'Regular')
GO
GO
SET IDENTITY_INSERT [payroll_info] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for philhealth
-- ----------------------------
DROP TABLE [philhealth]
GO
CREATE TABLE [philhealth] (
[id] int NOT NULL IDENTITY(1,1) ,
[phil_from] float(53) NULL ,
[phil_to] float(53) NULL ,
[amount] float(53) NULL 
)


GO
DBCC CHECKIDENT(N'[philhealth]', RESEED, 2)
GO

-- ----------------------------
-- Records of philhealth
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [philhealth] ON
GO
INSERT INTO [philhealth] ([id], [phil_from], [phil_to], [amount]) VALUES (N'1', N'1', N'5000', N'30'), (N'2', N'5001', N'40000', N'100')
GO
GO
SET IDENTITY_INSERT [philhealth] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for schedule
-- ----------------------------
DROP TABLE [schedule]
GO
CREATE TABLE [schedule] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[first_in] time(7) NULL ,
[first_out] time(7) NULL ,
[second_in] time(7) NULL ,
[second_out] time(7) NULL ,
[rest_day] varchar(255) NULL ,
[shift] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[schedule]', RESEED, 2)
GO

-- ----------------------------
-- Records of schedule
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [schedule] ON
GO
INSERT INTO [schedule] ([id], [emp_id], [first_in], [first_out], [second_in], [second_out], [rest_day], [shift]) VALUES (N'1', N'1', N'08:00:00.0000000', N'12:00:00.0000000', N'13:00:00.0000000', N'17:00:00.0000000', N'Sunday', N'Night'), (N'2', N'2', N'08:00:00.0000000', N'12:00:00.0000000', N'13:00:00.0000000', N'17:00:00.0000000', N'Sunday', N'Day')
GO
GO
SET IDENTITY_INSERT [schedule] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for settings
-- ----------------------------
DROP TABLE [settings]
GO
CREATE TABLE [settings] (
[work_days] int NULL 
)


GO

-- ----------------------------
-- Records of settings
-- ----------------------------
BEGIN TRANSACTION
GO
INSERT INTO [settings] ([work_days]) VALUES (N'26')
GO
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for sss
-- ----------------------------
DROP TABLE [sss]
GO
CREATE TABLE [sss] (
[id] int NOT NULL IDENTITY(1,1) ,
[sss_from] float(53) NULL ,
[sss_to] float(53) NULL ,
[amount] float(53) NULL 
)


GO

-- ----------------------------
-- Records of sss
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [sss] ON
GO
INSERT INTO [sss] ([id], [sss_from], [sss_to], [amount]) VALUES (N'1', N'1', N'5000', N'100')
GO
GO
SET IDENTITY_INSERT [sss] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for tax
-- ----------------------------
DROP TABLE [tax]
GO
CREATE TABLE [tax] (
[id] int NOT NULL IDENTITY(1,1) ,
[tax_from] float(53) NULL ,
[tax_to] float(53) NULL ,
[amount] float(53) NULL 
)


GO

-- ----------------------------
-- Records of tax
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [tax] ON
GO
INSERT INTO [tax] ([id], [tax_from], [tax_to], [amount]) VALUES (N'1', N'1', N'5000', N'50')
GO
GO
SET IDENTITY_INSERT [tax] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Table structure for work_time
-- ----------------------------
DROP TABLE [work_time]
GO
CREATE TABLE [work_time] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[payroll_no] int NULL ,
[hours] varchar(255) NULL ,
[date] date NULL 
)


GO
DBCC CHECKIDENT(N'[work_time]', RESEED, 185)
GO

-- ----------------------------
-- Records of work_time
-- ----------------------------
BEGIN TRANSACTION
GO
SET IDENTITY_INSERT [work_time] ON
GO
INSERT INTO [work_time] ([id], [emp_id], [payroll_no], [hours], [date]) VALUES (N'178', N'1', N'3', N'3.68333333333333', N'2018-04-04'), (N'179', N'1', N'3', N'8', N'2018-04-05'), (N'180', N'1', N'3', N'0', N'2018-04-06'), (N'181', N'1', N'3', N'0', N'2018-04-07'), (N'182', N'2', N'3', N'0', N'2018-04-04'), (N'183', N'2', N'3', N'0', N'2018-04-05'), (N'184', N'2', N'3', N'0', N'2018-04-06'), (N'185', N'2', N'3', N'0', N'2018-04-07')
GO
GO
SET IDENTITY_INSERT [work_time] OFF
GO
COMMIT TRANSACTION
GO

-- ----------------------------
-- Indexes structure for table biometrics
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table biometrics
-- ----------------------------
ALTER TABLE [biometrics] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table deduction
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table deduction
-- ----------------------------
ALTER TABLE [deduction] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table earnings
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table earnings
-- ----------------------------
ALTER TABLE [earnings] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table employees
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table employees
-- ----------------------------
ALTER TABLE [employees] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table holiday
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table holiday
-- ----------------------------
ALTER TABLE [holiday] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table leave
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table leave
-- ----------------------------
ALTER TABLE [leave] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table misc_deduction
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table misc_deduction
-- ----------------------------
ALTER TABLE [misc_deduction] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table overtime
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table overtime
-- ----------------------------
ALTER TABLE [overtime] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table pagibig
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table pagibig
-- ----------------------------
ALTER TABLE [pagibig] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table payroll_info
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table payroll_info
-- ----------------------------
ALTER TABLE [payroll_info] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table philhealth
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table philhealth
-- ----------------------------
ALTER TABLE [philhealth] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table schedule
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table schedule
-- ----------------------------
ALTER TABLE [schedule] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table sss
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table sss
-- ----------------------------
ALTER TABLE [sss] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table tax
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tax
-- ----------------------------
ALTER TABLE [tax] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table work_time
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table work_time
-- ----------------------------
ALTER TABLE [work_time] ADD PRIMARY KEY ([id])
GO
