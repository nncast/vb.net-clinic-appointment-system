# Security Policy

## Supported versions

| Version | Supported |
| --- | --- |
| 0.1.1 | Yes |
| 0.1.0 | No (stores plain-text passwords and builds SQL from user input; upgrade to 0.1.1) |

## Reporting a vulnerability

Please **do not** open a public issue for security problems.

Report it privately through GitHub: go to the repository's **Security** tab and click **Report a vulnerability** ([direct link](https://github.com/nncast/vb.net-clinic-appointment-system/security/advisories/new)).

Include:

- the version and whether you used the Windows build or built from source
- the steps to reproduce, and which screen or file is affected
- what an attacker could do with it (for example sign in as admin, read another patient's appointments, change records)

You should get a reply within 7 days. Once the problem is confirmed, a fix is released as a new version and you are credited in the release notes unless you prefer not to be.

## Deployment notes

EverGreen is a desktop app that talks directly to MySQL, and the database holds patients' personal and appointment details:

- Change the default `admin` / `admin` password before real use: with a MySQL client, set a new password (at least 8 characters) in the `tbladmin` table. It is replaced by a hash the next time the admin signs in.
- Delete the sample patients (`test` / `test`) before real use.
- Do not use the MySQL `root` account with an empty password outside a local test machine. Create a dedicated MySQL user with access only to `clinic` and put it in the `ClinicDb` connection string.
- Do not expose the MySQL port (3306) to the internet. Anyone who can reach the database with the credentials in `ClinicSystem.exe.config` can read and change all records.
- Keep `ClinicSystem.exe.config` readable only by the people who run the app, since it holds the database password.
