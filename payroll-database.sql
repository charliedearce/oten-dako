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

Date: 2018-07-13 07:53:03
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
DBCC CHECKIDENT(N'[biometrics]', RESEED, 307615)
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
[amount] numeric(38,2) NULL ,
[payroll_no] int NULL ,
[description] varchar(255) NULL ,
[misc_id] int NOT NULL DEFAULT '' 
)


GO
DBCC CHECKIDENT(N'[deduction]', RESEED, 3476)
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
[amount] numeric(38,2) NULL ,
[payroll_no] int NULL ,
[description] varchar(255) NULL ,
[date] date NULL 
)


GO
DBCC CHECKIDENT(N'[earnings]', RESEED, 6524)
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
[base_pay] numeric(38,2) NULL DEFAULT ((0)) ,
[sick_leave] float(53) NULL ,
[vaca_leave] float(53) NULL ,
[status] varchar(255) NULL ,
[type] varchar(255) NULL ,
[ordinary_ns] float(53) NULL ,
[relation] varchar(255) NULL ,
[dependent] numeric(18) NULL ,
[cola] numeric(18) NULL ,
[emp_id] int NULL ,
[bypass] int NULL DEFAULT ((0)) ,
[philhealth] int NULL DEFAULT ((0)) ,
[sss] int NULL DEFAULT ((0)) ,
[pagibig] int NULL DEFAULT ((0)) ,
[tax] int NULL DEFAULT ((0)) 
)


GO
DBCC CHECKIDENT(N'[employees]', RESEED, 45)
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
DBCC CHECKIDENT(N'[holiday]', RESEED, 12)
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
[days] float(53) NULL ,
[approve] varchar(255) NULL ,
[type] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[leave]', RESEED, 22)
GO

-- ----------------------------
-- Table structure for misc_deduction
-- ----------------------------
DROP TABLE [misc_deduction]
GO
CREATE TABLE [misc_deduction] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[date] date NULL ,
[description] varchar(255) NULL ,
[amount] numeric(38,2) NULL ,
[auto] varchar(255) NULL ,
[deduct_type] varchar(255) NULL ,
[amount_type] numeric(38,2) NULL 
)


GO
DBCC CHECKIDENT(N'[misc_deduction]', RESEED, 8)
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
DBCC CHECKIDENT(N'[overtime]', RESEED, 14)
GO

-- ----------------------------
-- Table structure for pagibig
-- ----------------------------
DROP TABLE [pagibig]
GO
CREATE TABLE [pagibig] (
[id] int NOT NULL IDENTITY(1,1) ,
[pagibig_from] numeric(38,2) NULL ,
[pagibig_to] numeric(38,2) NULL ,
[amount] numeric(38,2) NULL 
)


GO
DBCC CHECKIDENT(N'[pagibig]', RESEED, 3)
GO

-- ----------------------------
-- Table structure for pay_emp
-- ----------------------------
DROP TABLE [pay_emp]
GO
CREATE TABLE [pay_emp] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[payroll_no] int NULL 
)


GO
DBCC CHECKIDENT(N'[pay_emp]', RESEED, 58)
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
-- Table structure for philhealth
-- ----------------------------
DROP TABLE [philhealth]
GO
CREATE TABLE [philhealth] (
[id] int NOT NULL IDENTITY(1,1) ,
[phil_from] numeric(38,2) NULL ,
[phil_to] numeric(38,2) NULL ,
[amount] numeric(38,2) NULL 
)


GO
DBCC CHECKIDENT(N'[philhealth]', RESEED, 2)
GO

-- ----------------------------
-- Table structure for position
-- ----------------------------
DROP TABLE [position]
GO
CREATE TABLE [position] (
[id] int NOT NULL IDENTITY(1,1) ,
[info] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[position]', RESEED, 3)
GO

-- ----------------------------
-- Table structure for restday
-- ----------------------------
DROP TABLE [restday]
GO
CREATE TABLE [restday] (
[id] int NOT NULL IDENTITY(1,1) ,
[emp_id] int NULL ,
[restday] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[restday]', RESEED, 145)
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
[shift] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[schedule]', RESEED, 33)
GO

-- ----------------------------
-- Table structure for settings
-- ----------------------------
DROP TABLE [settings]
GO
CREATE TABLE [settings] (
[work_days] int NULL ,
[comp_name] varchar(255) NULL ,
[com_address] varchar(255) NULL ,
[comp_contact] varchar(255) NULL 
)


GO

-- ----------------------------
-- Table structure for sss
-- ----------------------------
DROP TABLE [sss]
GO
CREATE TABLE [sss] (
[id] int NOT NULL IDENTITY(1,1) ,
[sss_from] numeric(38,2) NULL ,
[sss_to] numeric(38,2) NULL ,
[amount] numeric(38,2) NULL 
)


GO
DBCC CHECKIDENT(N'[sss]', RESEED, 3)
GO

-- ----------------------------
-- Table structure for tax
-- ----------------------------
DROP TABLE [tax]
GO
CREATE TABLE [tax] (
[id] int NOT NULL IDENTITY(1,1) ,
[tax_from] numeric(38,2) NULL ,
[tax_to] numeric(38,2) NULL ,
[amount] numeric(38,2) NULL 
)


GO
DBCC CHECKIDENT(N'[tax]', RESEED, 3)
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
[hours] numeric(38,2) NULL ,
[date] date NULL 
)


GO
DBCC CHECKIDENT(N'[work_time]', RESEED, 2175)
GO

-- ----------------------------
-- Procedure structure for payslip
-- ----------------------------
DROP PROCEDURE [payslip]
GO
CREATE PROCEDURE [payslip]
@payroll_no as INT
AS
BEGIN
  SELECT
	payroll_info.id as payroll_no,
	earnings.emp_id,
	Sum(dbo.earnings.amount) as gross,
	employees.fname,
	employees.lname,
	deduction.amount as de_amount,
	deduction.description as de_desc,
	deduction.deduction_type

	FROM
	payroll_info ,
	earnings ,
	employees,
	deduction
	WHERE
	payroll_info.id = @payroll_no AND
	payroll_info.id = dbo.earnings.payroll_no AND
	earnings.emp_id = dbo.employees.id AND
	payroll_info.id = dbo.deduction.payroll_no AND
	earnings.emp_id = dbo.deduction.emp_id
	GROUP BY
	payroll_info.id,
	earnings.emp_id,
	employees.fname,
	employees.lname,
	deduction.amount,
	deduction.description,
	deduction_type 
END
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
-- Uniques structure for table employees
-- ----------------------------
ALTER TABLE [employees] ADD UNIQUE ([emp_id] ASC)
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
-- Indexes structure for table pay_emp
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table pay_emp
-- ----------------------------
ALTER TABLE [pay_emp] ADD PRIMARY KEY ([id])
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
-- Indexes structure for table position
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table position
-- ----------------------------
ALTER TABLE [position] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table restday
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table restday
-- ----------------------------
ALTER TABLE [restday] ADD PRIMARY KEY ([id])
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
