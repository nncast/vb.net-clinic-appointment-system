<p align="center">
  <img src="ClinicSystem/ClinicSystem/Resources/logo%20green%20trim.png" alt="EverGreen Medical Clinic" width="250"/>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/version-0.1.1-2BB98A?style=flat-square" alt="version">
  <img src="https://img.shields.io/badge/status-complete-2BB98A?style=flat-square" alt="status">
  <img src="https://img.shields.io/badge/VB.NET-Windows_Forms-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="VB.NET">
  <img src="https://img.shields.io/badge/.NET_Framework-4.8.1-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET Framework">
  <img src="https://img.shields.io/badge/MySQL-XAMPP-4479A1?style=flat-square&logo=mysql&logoColor=white" alt="MySQL">
</p>

<p align="center">
  <b>Download v0.1.1:</b>
  <a href="https://github.com/nncast/vb.net-clinic-appointment-system/releases/download/v0.1.1/ClinicSystem-v0.1.1-Windows.zip">Windows (.zip)</a> ·
  <a href="https://github.com/nncast/vb.net-clinic-appointment-system/archive/refs/tags/v0.1.1.zip">Source (.zip)</a> ·
  <a href="https://www.youtube.com/watch?v=6MIb-sQymHw">Preview Video</a> |
  <a href="https://github.com/nncast/vb.net-clinic-appointment-system/releases">All releases</a>
</p>

# EverGreen Medical Clinic

**EverGreen Medical Clinic** is a desktop-based appointment and records management application developed in VB.NET.
It features user authentication for both admin and patient roles, and supports standard Create, Read, Update, and Delete (CRUD) operations with a MySQL backend.

> **Current version: v0.1.1** — security and bug-fix release: hashed passwords, a real admin account, parameterized queries, the connection settings in a config file, and a ready-to-run Windows build. See [Releases](https://github.com/nncast/vb.net-clinic-appointment-system/releases) for the release notes.

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
| MySQL .NET Connector (`MySql.Data.dll`) | Included in `lib/` (from [Connector/NET](https://dev.mysql.com/downloads/connector/net/)) |

## Setup and run instructions

**Windows build (no Visual Studio needed)**

1. Download [`ClinicSystem-v0.1.1-Windows.zip`](https://github.com/nncast/vb.net-clinic-appointment-system/releases/download/v0.1.1/ClinicSystem-v0.1.1-Windows.zip) from the [v0.1.1 release](https://github.com/nncast/vb.net-clinic-appointment-system/releases/tag/v0.1.1) and extract it.
2. Start MySQL (XAMPP, WAMP, or another server) and import `database/clinic.sql` from the extracted folder.
3. If your MySQL server, port, user or password differ from `localhost:3306` / `root` / no password, open `ClinicSystem.exe.config` in Notepad and edit the `ClinicDb` connection string.
4. Run `ClinicSystem.exe`.

**From source**

1. Clone the repository, or download the [source .zip](https://github.com/nncast/vb.net-clinic-appointment-system/archive/refs/tags/v0.1.1.zip).
   ```bash
   git clone https://github.com/nncast/vb.net-clinic-appointment-system.git
   ```
2. Start MySQL using XAMPP, WAMP, or another server stack.
3. Import `database/clinic.sql` with SQLYog or another MySQL client.
4. Open `ClinicSystem/ClinicSystem.sln` in Visual Studio.
5. If your MySQL settings differ from the defaults, edit the `ClinicDb` connection string in `ClinicSystem/ClinicSystem/App.config`. `MySql.Data.dll` ships in the repository's `lib` folder, so nothing else needs to be installed for the reference.
6. Build and run the project.

Sign in as admin with `admin` / `admin` (the account lives in the `tbladmin` table), or as one of the sample patients with `test` / `test`. Passwords are stored as salted hashes, and new ones need at least 8 characters.

**Upgrading from v0.1.0?** Keep your data: run `database/upgrade-v0.1.1.sql` on your existing `clinic` database instead of importing `clinic.sql`. It adds the admin table and widens the password column; old plain-text passwords keep working and are replaced by a hash at the next sign-in.

---

*EverGreen Medical Clinic · Clinic Appointment System · 2024 · VB.NET · Windows Forms · .NET Framework 4.8.1 · MySQL*
