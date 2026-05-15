-- ============================================================
--  LawyerDB - Full Database Setup Script
--  Project: Lawyer Management System
--  Course:  CSC2210 - Object Oriented Programming 2
--  University: American International University-Bangladesh (AIUB)
--  Semester: Spring 2025-2026
-- ============================================================

-- Step 1: Create the database
CREATE DATABASE LawyerDB;
GO

USE LawyerDB;
GO

-- ============================================================
-- TABLE: Users
-- Stores login credentials and roles for all system users.
-- ============================================================
CREATE TABLE Users (
    UserId   INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50)  NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role     VARCHAR(20)  NOT NULL CHECK (Role IN ('Lawyer', 'Client', 'Admin', 'Superadmin'))
);
GO

-- ============================================================
-- TABLE: ClientProfiles
-- Stores personal information for clients.
-- ============================================================
CREATE TABLE ClientProfiles (
    ClientId  INT IDENTITY(1,1) PRIMARY KEY,
    UserId    INT UNIQUE,
    FullName  VARCHAR(100),
    Email     VARCHAR(100),
    Phone     VARCHAR(20),
    Address   VARCHAR(255),
    FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE
);
GO

-- ============================================================
-- TABLE: LawyerProfiles
-- Stores professional and financial information for lawyers.
-- ============================================================
CREATE TABLE LawyerProfiles (
    LawyerId       INT IDENTITY(1,1) PRIMARY KEY,
    UserId         INT UNIQUE,
    FullName       VARCHAR(100),
    Email          VARCHAR(100),
    Phone          VARCHAR(20),
    Address        VARCHAR(255),
    LicenseNumber  VARCHAR(50),
    Specialization VARCHAR(100),
    Experience     INT,
    HourlyFee      DECIMAL(10,2),
    TotalCases     INT DEFAULT 0,
    Rating         DECIMAL(3,2),
    Balance        DECIMAL(12,2) DEFAULT 0,
    FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE
);
GO

-- ============================================================
-- TABLE: Cases
-- Stores legal case records linking clients and lawyers.
-- ============================================================
CREATE TABLE Cases (
    CaseId       INT IDENTITY(1,1) PRIMARY KEY,
    Status       VARCHAR(50) DEFAULT 'Pending',
    CreatedAt    DATETIME DEFAULT GETDATE(),
    ClientUserId INT,
    LawyerUserId INT,
    IsCharged    BIT DEFAULT 0,
    FOREIGN KEY (ClientUserId) REFERENCES Users(UserId),
    FOREIGN KEY (LawyerUserId) REFERENCES Users(UserId)
);
GO

-- ============================================================
-- SEED DATA: Default Superadmin Account
-- Login: admin / admin123
-- ============================================================
INSERT INTO Users (Username, Password, Role)
VALUES ('superadmin', 'superadmin123', 'Superadmin');
GO

-- ============================================================
-- SEED DATA: Sample Admin Account
-- ============================================================
INSERT INTO Users (Username, Password, Role)
VALUES ('admin1', 'admin123', 'Admin');
GO

-- ============================================================
-- VERIFY: Check all tables were created
-- ============================================================
SELECT * FROM Users;
SELECT * FROM ClientProfiles;
SELECT * FROM LawyerProfiles;
SELECT * FROM Cases;
GO
