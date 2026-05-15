
# Lawyer Management System

A desktop-based Lawyer Management System developed using C# Windows Forms and MS SQL Server. The system provides a digital platform for managing legal cases efficiently through role-based access control.

---

## Project Overview

Traditional legal services often depend on manual paperwork and communication, which can lead to delays and poor case management. This project solves those problems by creating a centralized digital system for clients, lawyers, and administrators.

The system allows:
- Clients to hire lawyers and track cases
- Lawyers to manage assigned cases
- Admins to monitor activities
- SuperAdmins to control the entire system

---

## Features

### Authentication System
- Secure login system
- Role-based access control
- Password verification using database

### User Management
- Client registration
- Lawyer registration
- Profile management
- Lawyer verification by admin

### Case Management
- Create and submit legal cases
- Accept or reject requests
- Track case progress
- Complete case handling

### Dashboard System
Separate dashboards for:
- Client
- Lawyer
- Admin
- SuperAdmin

### Review and Rating System
- Clients can rate lawyers
- Improves transparency
- Helps future clients choose lawyers

### Notifications and Status Tracking
Case statuses:
- Pending
- Accepted
- In Progress
- Completed

### Administrative Control
- Manage users
- Monitor cases
- Control system settings

---

## Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application Development |
| Windows Forms | GUI Development |
| MS SQL Server | Database Management |
| ADO.NET | Database Connectivity |

---

## Database Tables

### Users
Stores login credentials and roles.

### LawyerProfiles
Stores lawyer information including:
- License Number
- Specialization
- Experience
- Ratings

### ClientProfiles
Stores client information.

### Cases
Stores legal case details and tracking information.

---

## SQL Schema

### Users Table

```sql
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Lawyer', 'Client', 'Admin'))
);
```

### LawyerProfiles Table

```sql
CREATE TABLE LawyerProfiles (
    LawyerId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT UNIQUE,

    FullName VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(255),

    LicenseNumber VARCHAR(50),
    Specialization VARCHAR(100),
    Experience INT,

    HourlyFee DECIMAL(10,2),
    TotalCases INT DEFAULT 0,
    Rating DECIMAL(3,2),
    Balance DECIMAL(12,2) DEFAULT 0,

    FOREIGN KEY (UserId)
    REFERENCES Users(UserID)
    ON DELETE CASCADE
);
```

### ClientProfiles Table

```sql
CREATE TABLE ClientProfiles (
    ClientId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT UNIQUE,

    FullName VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(255),

    FOREIGN KEY (UserId)
    REFERENCES Users(UserID)
    ON DELETE CASCADE
);
```

### Cases Table

```sql
CREATE TABLE Cases (
    CaseId INT IDENTITY(1,1) PRIMARY KEY,

    Status VARCHAR(50) DEFAULT 'Open',
    CreatedAt DATETIME DEFAULT GETDATE(),

    ClientUserId INT,
    LawyerUserId INT,

    IsCharged BIT DEFAULT 0,

    FOREIGN KEY (ClientUserId)
    REFERENCES Users(UserID),

    FOREIGN KEY (LawyerUserId)
    REFERENCES Users(UserID)
);
```

---

## System Workflow

1. Client registers and logs in
2. Client browses available lawyers
3. Client submits case request
4. Lawyer accepts or rejects request
5. Case status updates continuously
6. Admin monitors system activities
7. SuperAdmin controls the full platform

---

## Objectives

- Digitize legal case management
- Improve communication
- Increase transparency
- Reduce paperwork
- Automate administrative tasks

---

## Team Members

| Name | ID |
|---|---|
| AHNAF AZMAIN ANIK | 24-59604-3 |
| AHSAN KABIR ARANNA | 24-60365-3 |
| MD. NAHIAN HOSSAIN SIAM | 24-59572-3 |
| NASHID JAMIL KANCHON | 23-54572-3 |

---

## Course Information

**Course:** CSC2210 - Object Oriented Programming 2  
**University:** American International University-Bangladesh (AIUB)  
**Semester:** Spring 2025-2026  

---

## Supervisor

DR. MD. IFTEKHARUL MOBIN

---

## Future Improvements

- Online payment system
- Real-time messaging
- File upload support
- Video consultation
- Email notifications
- Analytics dashboard

---

## License

This project was developed for academic purposes.
