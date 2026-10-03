<p align="center">
  <img src="ClinicSystem/ClinicSystem/Resources/logo%20green.png" alt="EverGreen Medical Clinic" width="250"/>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/version-0.1.0-2BB98A?style=flat-square" alt="version">
  <img src="https://img.shields.io/badge/status-complete-2772BD?style=flat-square" alt="status">
  <img src="https://img.shields.io/badge/VB.NET-Windows_Forms-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="VB.NET">
  <img src="https://img.shields.io/badge/.NET_Framework-4.8.1-5C2D91?style=flat-square&logo=dotnet&logoColor=white" alt=".NET Framework">
  <img src="https://img.shields.io/badge/MySQL-XAMPP-4479A1?style=flat-square&logo=mysql&logoColor=white" alt="MySQL">
</p>

<p align="center">
  <b>Download v0.1.0:</b>
  <a href="https://github.com/nncast/vb.net-clinic-appointment-system/archive/refs/tags/v0.1.0.zip">Source (.zip)</a> ·
  <a href="https://www.youtube.com/watch?v=6MIb-sQymHw">Preview Video</a> |
  <a href="https://github.com/nncast/vb.net-clinic-appointment-system/releases">All releases</a>
</p>

# ClinicSystem

**ClinicSystem** is a desktop-based appointment and records management application developed in VB.NET.
It features user authentication for both admin and patient roles, and supports standard Create, Read, Update, and Delete (CRUD) operations with a MySQL backend.

> **Current version: v0.1.0** — first tagged release. See [Releases](https://github.com/nncast/vb.net-clinic-appointment-system/releases) for the project timeline.

## Screenshots

<p align="center">
  <img src="https://github.com/user-attachments/assets/b0ef62a7-9969-4477-9770-40528ea2c88e" width="400"/>
  <img src="https://github.com/user-attachments/assets/ef117bb6-77a3-4b42-8c0a-7478fe70361e" width="400"/>
  <img src="https://github.com/user-attachments/assets/e998522e-cc70-4b1d-89fa-7a1281b15d7d" width="400"/>
  <img src="https://github.com/user-attachments/assets/f23f7feb-d554-43c9-abcd-7d10952970a1" width="400"/>
</p>

## Features

- Login and registration for admin and patient roles
- Role-based access with separate views
- CRUD functionality for managing appointments and records
- Windows Forms interface

## Development environment

| Category | Details |
| --- | --- |
| Language | Visual Basic .NET |
| UI | Windows Forms |
| Framework | .NET Framework 4.8.1 |
| Database | MySQL / MariaDB (XAMPP or WAMP) — database `clinic` |
| Driver | MySql.Data (MySQL Connector/NET) |
| IDE | Visual Studio 2012 or later |

## Requirements

| Tool | Download |
| --- | --- |
| Visual Studio 2012 or later | [visualstudio.microsoft.com](https://visualstudio.microsoft.com/downloads/) |
| .NET Framework 4.8.1 or later | [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481) |
| XAMPP or WAMP (for MySQL) | [XAMPP](https://www.apachefriends.org/index.html) · [WAMP](https://www.wampserver.com/en/) |
| SQLYog or any MySQL client | [SQLYog](https://github.com/webyog/sqlyog-community/wiki/Downloads) |
| MySQL .NET Connector (`MySql.Data.dll`) | [Connector/NET](https://dev.mysql.com/downloads/connector/net/) |

## Setup and run instructions

1. Clone the repository, or download the [source .zip](https://github.com/nncast/vb.net-clinic-appointment-system/archive/refs/tags/v0.1.0.zip).
   ```bash
   git clone https://github.com/nncast/vb.net-clinic-appointment-system.git
   ```
2. Start MySQL using XAMPP, WAMP, or another server stack.
3. Import `database/clinic.sql` with your MySQL client.
4. Open `ClinicSystem/ClinicSystem.sln` in Visual Studio.
5. Make sure the project targets .NET Framework 4.8.1 or later and that `MySql.Data.dll` is referenced.
6. Build and run the project.

Sign in as admin with `admin` / `admin`, or as one of the sample patients with `test` / `test`.

## Developer

Janelle Ann Castillo ([nncast](https://github.com/nncast))

---

*ClinicSystem · 2024 · VB.NET · Windows Forms · .NET Framework 4.8.1 · MySQL*
