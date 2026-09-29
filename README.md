# Mini Clinic Management System

A desktop application built with **C# Windows Forms** to manage doctors, patients, and appointments in a small clinic. Built as a university final project using a simple **N-Tier Architecture**.

## Technology Stack

- C# / .NET
- Windows Forms
- Entity Framework Core
- SQL Server

## Architecture

The project follows a simple N-Tier structure with 4 projects in the solution:

```
MiniClinic.UI            (Presentation Layer - Windows Forms)
        ↓
MiniClinic.BLL            (Business Logic Layer - Services)
        ↓
MiniClinic.DAL             (Data Access Layer - EF Core + Repositories)
        ↓
SQL Server

MiniClinic.Domain          (Entities - referenced by DAL and BLL)
```

- **Presentation (MiniClinic.UI):** Windows Forms only. Never accesses the database or repositories directly — only calls BLL services.
- **Business Logic (MiniClinic.BLL):** Services that coordinate operations and enforce business rules.
- **Data Access (MiniClinic.DAL):** EF Core `DbContext`, entity configurations, and simple repositories.
- **Domain (MiniClinic.Domain):** The core entities (`Doctor`, `Patient`, `Appointment`) with basic validation.

## Main Entities

**Doctor**
- Id, Name, Specialty

**Patient**
- Id, Name, Phone, DateOfBirth

**Appointment**
- Id, DoctorId, PatientId, AppointmentDate, Notes

**Relationships**
- One Doctor → many Appointments
- One Patient → many Appointments

## Features

**Doctors**
- Add / Edit / Delete / View Doctors

**Patients**
- Add / Edit / Delete / View Patients
- Search Patients by name

**Appointments**
- Add / Edit / Delete / View Appointments
- Filter Appointments by Doctor and/or Patient
- View a patient's appointment history

## Business Rules

1. A doctor cannot have two appointments at the same date and time.
2. An appointment cannot be created for a date/time in the past.
3. Required fields are validated before saving.
4. An appointment must reference an existing Doctor and an existing Patient.

## Project Structure

```
MiniClinicManagementSystem/
├── MiniClinic.Domain/
│   └── Entities/            (Doctor.cs, Patient.cs, Appointment.cs)
├── MiniClinic.DAL/
│   ├── Data/                 (AppDbContext.cs)
│   ├── Configurations/       (EF Core entity configurations)
│   ├── Migrations/
│   └── Repositories/         (DoctorRepository, PatientRepository, AppointmentRepository)
├── MiniClinic.BLL/
│   └── Services/              (DoctorService, PatientService, AppointmentService)
└── MiniClinic.UI/
    └── Forms/                 (MainForm, DoctorForm, PatientForm, AppointmentForm)
```

## Getting Started

### Prerequisites
- Visual Studio (2022 or later recommended)
- .NET 8.0 SDK
- SQL Server (Express or full) with an instance you can connect to

### Setup

1. Clone the repository:
   ```
   git clone https://github.com/USERNAME/MiniClinicManagementSystem.git
   ```
2. Open `MiniClinicManagementSystem.sln` in Visual Studio.
3. Update the SQL Server connection string in
   `MiniClinic.DAL/Data/AppDbContext.cs` (inside `OnConfiguring`) to match your own SQL Server instance name:
   ```csharp
   optionsBuilder.UseSqlServer(@"Server=YOUR_SERVER_NAME;Database=MiniClinicDb;Trusted_Connection=True;TrustServerCertificate=True;");
   ```
4. Open the **Package Manager Console** (with `MiniClinic.DAL` set as the Default project) and run:
   ```
   Update-Database
   ```
   This creates the `MiniClinicDb` database and applies the existing migrations.
5. Set `MiniClinic.UI` as the Startup Project.
6. Press `F5` to build and run.

