# Contributing to EverGreen Medical Clinic

Thanks for helping out. Bug reports, fixes and small improvements are all welcome.

## Reporting bugs and ideas

Open an [issue](https://github.com/nncast/vb.net-clinic-appointment-system/issues) with:

- what you did, what you expected, and what happened instead
- the version (see [Releases](https://github.com/nncast/vb.net-clinic-appointment-system/releases)) and whether you ran the Windows build or built from source
- your MySQL/MariaDB setup (XAMPP, WAMP, other) if the problem involves the database

Security problems do not go in issues; see [SECURITY.md](SECURITY.md).

## Setting up

Follow **From source** in the [README](README.md#setup-and-run-instructions): import `database/clinic.sql`, open `ClinicSystem/ClinicSystem.sln` in Visual Studio, and set the `ClinicDb` connection string in `App.config` if your MySQL settings differ from the defaults.

## Making a change

1. Fork the repository and create a branch from `main` (for example `fix-appointment-date`).
2. Keep each pull request to one fix or feature.
3. Build and try your change as both the **admin** and a **patient** account.
4. Open a pull request that says what changed and how you tested it. Screenshots help for form changes.

## Code guidelines

- **Database access** goes through the helpers in `Conn.vb` (`GetQuery`, `SetQuery`, `GetValue`, `Execute`). Pass every value with `P("@name", value)`; never build SQL by joining strings with user input.
- **Multi-step writes** (for example signing up a patient) go inside `BeginTransaction` / `CommitTransaction`, with `RollbackTransaction` on failure.
- **Passwords** are stored only through `PasswordHasher.HashPassword` and checked with `VerifyPassword`, with at least 8 characters for new ones. Never store, log or display a plain-text password.
- **Connection settings** stay in `App.config`. Do not hard-code server names, users or passwords.
- **Schema changes** go into `database/clinic.sql` so a fresh import matches the code, plus an upgrade script (like `database/upgrade-v0.1.1.sql`) for existing databases.
- Match the style of the surrounding code: one form per screen, named like `PatientForm`.
- Do not commit `bin/`, `obj/` or personal `App.config` changes such as your local database password.
