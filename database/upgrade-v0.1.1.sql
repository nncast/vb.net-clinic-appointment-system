-- ============================================================================
--  ClinicSystem v0.1.1 upgrade for an existing `clinic` database.
--  Run once:  mysql -u root -p < database/upgrade-v0.1.1.sql
--
--  - Adds tbladmin: the admin login is no longer hard-coded in the app.
--    Default account: admin / admin (stored as a PBKDF2 hash).
--  - Widens tblpatient.password for hashed passwords. Existing plain-text
--    patient passwords keep working and are hashed automatically the next
--    time each patient logs in.
-- ============================================================================

USE `clinic`;

CREATE TABLE IF NOT EXISTS `tbladmin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_admin_username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT IGNORE INTO `tbladmin` (`username`, `password`) VALUES
  ('admin', 'PBKDF2$100000$7xGME57O/PslB4O9JPh0ag==$v/tRxY3/CcsMrRSgTfWvQdkYrZf+a0uKGiYnIzzn1a4=');

ALTER TABLE `tblpatient` MODIFY `password` varchar(255) DEFAULT NULL;
