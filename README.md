# ClinicSystem  
(2024)

**ClinicSystem** is a desktop-based appointment and records management application developed in VB.NET.  
It features user authentication for both admin and patient roles, and supports standard Create, Read, Update, and Delete (CRUD) operations with a MySQL backend.

[Preview Video](https://www.youtube.com/watch?v=6MIb-sQymHw)

<img src="https://github.com/user-attachments/assets/b0ef62a7-9969-4477-9770-40528ea2c88e" width="400"/>  
<img src="https://github.com/user-attachments/assets/ef117bb6-77a3-4b42-8c0a-7478fe70361e" width="400"/>  
<img src="https://github.com/user-attachments/assets/e998522e-cc70-4b1d-89fa-7a1281b15d7d" width="400"/>  
<img src="https://github.com/user-attachments/assets/f23f7feb-d554-43c9-abcd-7d10952970a1" width="400"/>

## Features
- Login and registration for admin and patient roles
- Role-based access with separate views
- CRUD functionality for managing appointments and records
- Windows Forms interface

## Requirements
- Visual Studio 2012 or later  
  [Download Visual Studio](https://visualstudio.microsoft.com/downloads/)
- .NET Framework 4.8.1 or later  
  [Download .NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- XAMPP or WAMP (for MySQL)  
  [Download XAMPP](https://www.apachefriends.org/index.html)  
  [Download WAMP](https://www.wampserver.com/en/)
- SQLYog or any MySQL client  
  [Download SQLYog](https://github.com/webyog/sqlyog-community/wiki/Downloads)
- MySQL .NET Connector (`MySql.Data.dll`)  
  [Download Connector/NET](https://dev.mysql.com/downloads/connector/net/)

## Installation
1. Download and extract the project `.zip` file.
2. Start MySQL using XAMPP, WAMP, or another server stack.
3. Open your MySQL client and import the `.sql` file located in the `sql` folder.
4. Open `ClinicSystem.sln` in Visual Studio.
5. Ensure the following before running the application:  
   - The project targets .NET Framework 4.8.1 or later.  
   - `MySql.Data.dll` is added and referenced in the project.
6. Build and run the project.

---

**Developer:** Janelle Ann Castillo ([nncast](https://github.com/nncast))
