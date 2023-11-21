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
  PRIMARY KEY (`admin_id`),
  KEY `fk_tbl_admin_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user1` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_admin`
--

LOCK TABLES `tbl_admin` WRITE;
/*!40000 ALTER TABLE `tbl_admin` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_audit`
--

LOCK TABLES `tbl_audit` WRITE;
/*!40000 ALTER TABLE `tbl_audit` DISABLE KEYS */;
INSERT INTO `tbl_audit` VALUES (18,12,'Registered','2023-11-15 16:44:04'),(19,13,'Registered','2023-11-15 16:45:47'),(20,13,'Logged In','2023-11-15 16:46:30'),(21,14,'Registered','2023-11-15 17:43:22'),(22,13,'Logged In','2023-11-15 17:43:56'),(23,12,'Logged In','2023-11-15 17:45:42'),(24,15,'Registered','2023-11-15 18:01:21'),(25,13,'Logged In','2023-11-15 18:01:57'),(26,13,'Logged In','2023-11-15 19:16:03'),(27,13,'Logged In','2023-11-15 19:17:06'),(28,13,'Logged In','2023-11-15 22:13:11'),(29,13,'Logged In','2023-11-15 22:13:45'),(30,15,'Logged In','2023-11-15 22:14:12'),(31,15,'Logged In','2023-11-15 22:34:23'),(32,15,'Logged In','2023-11-15 22:48:34'),(33,16,'Registered','2023-11-17 15:28:15'),(34,13,'Logged In','2023-11-17 15:28:50'),(35,13,'Logged In','2023-11-17 15:31:44'),(36,13,'Logged In','2023-11-17 15:40:54'),(37,13,'Logged In','2023-11-17 15:51:39'),(38,13,'Logged In','2023-11-17 15:52:20'),(39,17,'Registered','2023-11-18 00:06:23'),(40,13,'Logged In','2023-11-18 00:07:06'),(41,13,'Logged In','2023-11-18 00:07:59'),(42,17,'Logged In','2023-11-18 00:08:36'),(43,17,'Logged In','2023-11-18 00:13:02'),(44,13,'Logged In','2023-11-19 22:17:44'),(45,15,'Logged In','2023-11-19 22:32:53'),(46,15,'Logged In','2023-11-19 22:34:54'),(47,15,'Logged In','2023-11-19 22:37:14'),(48,15,'Logged In','2023-11-19 22:40:01'),(49,15,'Logged In','2023-11-19 22:41:39'),(50,18,'Registered','2023-11-20 15:12:32'),(51,13,'Logged In','2023-11-20 15:13:00'),(52,18,'Logged In','2023-11-20 15:13:24');
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
  PRIMARY KEY (`doctor_id`),
  KEY `fk_tbl_admin_tbl_user1_idx` (`user_id`),
  CONSTRAINT `fk_tbl_admin_tbl_user10` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctor`
--

LOCK TABLES `tbl_doctor` WRITE;
/*!40000 ALTER TABLE `tbl_doctor` DISABLE KEYS */;
INSERT INTO `tbl_doctor` VALUES (1,12),(2,14),(3,18);
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
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `mi` varchar(45) DEFAULT NULL,
  `barangay` varchar(45) DEFAULT NULL,
  `municipal` varchar(45) DEFAULT NULL,
  `province` varchar(45) DEFAULT NULL,
  `contactnumber` varchar(45) DEFAULT NULL,
  `age` varchar(45) DEFAULT NULL,
  `birthday` varchar(45) DEFAULT NULL,
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
INSERT INTO `tbl_patient` VALUES (2,17,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tbl_patient` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (12,'donna','6ce4be7607d13b0bf3119d47b62404c1',1,'Doctor'),(13,'admin','3225cb195fc2b6c5fd8d1fce48994e6c',1,'Admin'),(14,'sean','335894592eddcee58af8df0c7539ede8',1,'Doctor'),(15,'mad','f71b03b9710c39949ed6770bf601fa83',1,'Patient'),(16,'seanti','335894592eddcee58af8df0c7539ede8',0,'Admin'),(17,'shane','335894592eddcee58af8df0c7539ede8',1,'Patient'),(18,'camille','ce62bba6f67c4378b0b1e17b0aaf1355',1,'Doctor');
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

-- Dump completed on 2023-11-21 20:44:16
