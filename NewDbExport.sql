CREATE DATABASE  IF NOT EXISTS `db_hospitalproject` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_hospitalproject`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: db_hospitalproject
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_admin`
--

DROP TABLE IF EXISTS `tbl_admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_admin` (
  `admin_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `admin_name` varchar(45) DEFAULT NULL,
  `admin_address` varchar(45) DEFAULT NULL,
  `admin_contact` int DEFAULT NULL,
  PRIMARY KEY (`admin_id`),
  KEY `fk_tbl_admin_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user1` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_admin`
--

LOCK TABLES `tbl_admin` WRITE;
/*!40000 ALTER TABLE `tbl_admin` DISABLE KEYS */;
INSERT INTO `tbl_admin` VALUES (2,22,'aaaaa','ccccc',3223);
/*!40000 ALTER TABLE `tbl_admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_appointment`
--

DROP TABLE IF EXISTS `tbl_appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_appointment` (
  `appointment_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  `doctor_id` int NOT NULL,
  `appointment_reason` varchar(45) DEFAULT NULL,
  `appointment_date` varchar(45) DEFAULT NULL,
  `appointment_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`appointment_id`),
  KEY `fk_tbl_appointment_tbl_patient1_idx` (`patient_id`),
  KEY `fk_tbl_appointment_tbl_doctor1_idx` (`doctor_id`),
  CONSTRAINT `fk_tbl_appointment_tbl_doctor1` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctor` (`doctor_id`),
  CONSTRAINT `fk_tbl_appointment_tbl_patient1` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patient` (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_appointment`
--

LOCK TABLES `tbl_appointment` WRITE;
/*!40000 ALTER TABLE `tbl_appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_audit`
--

DROP TABLE IF EXISTS `tbl_audit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_audit` (
  `audit_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `audit_log` varchar(45) DEFAULT NULL,
  `audit_date` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`audit_id`),
  KEY `fk_tbl_audit_tbl_user_idx` (`user_id`),
  CONSTRAINT `fk_tbl_audit_tbl_user` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_audit`
--

LOCK TABLES `tbl_audit` WRITE;
/*!40000 ALTER TABLE `tbl_audit` DISABLE KEYS */;
INSERT INTO `tbl_audit` VALUES (53,19,'Registered','2023-11-22 21:31:52'),(54,19,'Logged In','2023-11-22 21:33:02'),(55,20,'Registered','2023-11-22 21:35:57'),(56,21,'Registered','2023-11-22 21:36:06'),(57,19,'Logged In','2023-11-22 21:40:32'),(58,19,'Logged In','2023-11-22 22:01:07'),(59,19,'Logged In','2023-11-23 00:38:10'),(60,19,'Logged In','2023-11-23 00:38:35'),(61,20,'Logged In','2023-11-23 00:38:49'),(62,20,'Logged In','2023-11-23 00:39:16'),(63,20,'Logged In','2023-11-23 00:40:34'),(64,19,'Logged In','2023-11-23 15:56:05'),(65,19,'Logged In','2023-11-23 15:57:36'),(66,19,'Logged In','2023-11-23 16:34:08'),(67,19,'Logged In','2023-11-23 16:35:31'),(68,19,'Logged In','2023-11-23 16:37:53'),(69,19,'Logged In','2023-11-23 16:38:11'),(70,22,'Registered','2023-11-23 16:39:24'),(71,19,'Logged In','2023-11-23 16:39:32'),(72,22,'Logged In','2023-11-23 16:39:45'),(73,22,'Logged In','2023-11-23 16:41:30'),(74,22,'Logged In','2023-11-23 16:42:57');
/*!40000 ALTER TABLE `tbl_audit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctor`
--

DROP TABLE IF EXISTS `tbl_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctor` (
  `doctor_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `doctor_name` varchar(45) DEFAULT NULL,
  `doctor_address` varchar(45) DEFAULT NULL,
  `doctor_contact` int DEFAULT NULL,
  PRIMARY KEY (`doctor_id`),
  KEY `fk_tbl_admin_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user10` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctor`
--

LOCK TABLES `tbl_doctor` WRITE;
/*!40000 ALTER TABLE `tbl_doctor` DISABLE KEYS */;
INSERT INTO `tbl_doctor` VALUES (4,20,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tbl_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_patient`
--

DROP TABLE IF EXISTS `tbl_patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_patient` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `patient_name` varchar(45) DEFAULT NULL,
  `patient_address` varchar(45) DEFAULT NULL,
  `patient_contact` int DEFAULT NULL,
  PRIMARY KEY (`patient_id`),
  KEY `fk_tbl_admin_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user100` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_patient`
--

LOCK TABLES `tbl_patient` WRITE;
/*!40000 ALTER TABLE `tbl_patient` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pay`
--

DROP TABLE IF EXISTS `tbl_pay`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pay` (
  `pay_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  `doctor_id` int NOT NULL,
  `pay_total` int DEFAULT NULL,
  `pay_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pay_id`),
  KEY `fk_tbl_pay_tbl_patient1_idx` (`patient_id`),
  KEY `fk_tbl_pay_tbl_doctor1_idx` (`doctor_id`),
  CONSTRAINT `fk_tbl_pay_tbl_doctor1` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctor` (`doctor_id`),
  CONSTRAINT `fk_tbl_pay_tbl_patient1` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patient` (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pay`
--

LOCK TABLES `tbl_pay` WRITE;
/*!40000 ALTER TABLE `tbl_pay` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pay` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `isactive` int DEFAULT NULL,
  `userrole` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (19,'adminn','3225cb195fc2b6c5fd8d1fce48994e6c',1,'Admin'),(20,'doctor','6ce4be7607d13b0bf3119d47b62404c1',1,'Doctor'),(21,'patient','f71b03b9710c39949ed6770bf601fa83',0,'Patient'),(22,'admin','3225cb195fc2b6c5fd8d1fce48994e6c',1,'Admin');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_hospitalproject'
--

--
-- Dumping routines for database 'db_hospitalproject'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-23 19:35:58
