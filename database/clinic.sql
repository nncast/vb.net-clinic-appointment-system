/*
SQLyog Ultimate - MySQL GUI v8.22 
MySQL - 5.5.27 : Database - clinic
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`clinic` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `clinic`;

/*Table structure for table `tblappointment` */

DROP TABLE IF EXISTS `tblappointment`;

CREATE TABLE `tblappointment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` int(11) DEFAULT NULL,
  `doctorid` int(11) DEFAULT NULL,
  `appointmenttype` varchar(100) DEFAULT NULL,
  `procedurereq` varchar(100) DEFAULT NULL,
  `appointmentdate` varchar(10) DEFAULT NULL,
  `appointmenttime` varchar(8) DEFAULT NULL,
  `reason` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_patient_appointment` (`patientid`),
  KEY `fk_doctor_appointment` (`doctorid`),
  CONSTRAINT `fk_doctor_appointment` FOREIGN KEY (`doctorid`) REFERENCES `tbldoctor` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_patient_appointment` FOREIGN KEY (`patientid`) REFERENCES `tblpatient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tblappointment` */

insert  into `tblappointment`(`id`,`patientid`,`doctorid`,`appointmenttype`,`procedurereq`,`appointmentdate`,`appointmenttime`,`reason`) values (1,1,1,'Check-Up','None','2024-12-18','02:30 PM','experiencing back pain'),(2,1,1,'Follow-Up','X-Ray','2024-12-25','03:30 PM','worsening symptoms');

/*Table structure for table `tbldoctor` */

DROP TABLE IF EXISTS `tbldoctor`;

CREATE TABLE `tbldoctor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `docname` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tbldoctor` */

insert  into `tbldoctor`(`id`,`docname`) values (1,'Dr. John Doe'),(2,'Dr. Jane Smith');

/*Table structure for table `tblpatient` */

DROP TABLE IF EXISTS `tblpatient`;

CREATE TABLE `tblpatient` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(50) DEFAULT NULL,
  `lname` varchar(50) DEFAULT NULL,
  `dob` varchar(10) DEFAULT NULL,
  `sex` enum('Male','Female') DEFAULT NULL,
  `phonenum` varchar(13) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tblpatient` */

insert  into `tblpatient`(`id`,`fname`,`lname`,`dob`,`sex`,`phonenum`,`email`,`password`) values (1,'test','test','2024-12-10','Male','0934-271-8247','test','test'),(2,'test2','test2','2024-12-12','Male','0932-178-6421','test2','test2'),(3,'Charles','Darwin','1809-02-12','Female','0975-486-5788','charlesdarwin@email.com','charlesdarwin'),(4,'Marie','Curie','1934-07-04','Female','0942-378-1244','mariecurie@email.com','mariecurie'),(5,'abc','abc','2004-12-12','Male','0238-578-2194','abc@email.com','abc');

/*Table structure for table `tblpatientaddress` */

DROP TABLE IF EXISTS `tblpatientaddress`;

CREATE TABLE `tblpatientaddress` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` int(11) DEFAULT NULL,
  `street` varchar(100) DEFAULT NULL,
  `barangay` varchar(100) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL,
  `province` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_patient_id` (`patientid`),
  CONSTRAINT `fk_patient_address` FOREIGN KEY (`patientid`) REFERENCES `tblpatient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tblpatientaddress` */

insert  into `tblpatientaddress`(`id`,`patientid`,`street`,`barangay`,`city`,`province`) values (1,1,'aa','ab','ac','ad'),(2,2,'ba','bb','bc','bd'),(3,3,'ca','cb','cc','cd'),(4,4,'da','db','dc','dd'),(5,5,'abc','def','ghi','jklm');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
