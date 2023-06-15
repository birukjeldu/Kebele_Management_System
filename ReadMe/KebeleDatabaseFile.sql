-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: kebele_management_system
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `email` varchar(55) NOT NULL,
  `password` varchar(45) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
INSERT INTO `admin` VALUES (1,'admin@gmail.com','admin','Biruk Jeldu'),(3,'abe@gmail.com','123','Abebe Balchacha'),(5,'natty@gmail.com','nati','Natty Man'),(6,'mahlet@gmail.com','123','Mahlet Daniel');
UNLOCK TABLES;

--
-- Table structure for table `birth_card`
--

DROP TABLE IF EXISTS `birth_card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `birth_card` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `placeofbirth` varchar(100) NOT NULL,
  `fullfathername` varchar(100) NOT NULL,
  `fullmothername` varchar(100) NOT NULL,
  `fathernationality` varchar(100) NOT NULL,
  `mothernationality` varchar(100) NOT NULL,
  `dateofissue` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`),
  CONSTRAINT `user_card_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `location` (
  `LocationID` int NOT NULL AUTO_INCREMENT,
  `Region` varchar(50) DEFAULT NULL,
  `Zone` varchar(50) DEFAULT NULL,
  `Wereda` varchar(50) DEFAULT NULL,
  `Kebele` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`LocationID`)
) ENGINE=InnoDB AUTO_INCREMENT=514 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `location`
--

LOCK TABLES `location` WRITE;
INSERT INTO `location` VALUES (1,'Afar','Awsi Rasu (Zone 1)','Ada\'ar','Kebele 01'),(2,'Afar','Awsi Rasu (Zone 1)','Afambo','Kebele 02'),(3,'Afar','Awsi Rasu (Zone 1)','Asayita','Kebele 03'),(4,'Afar','Awsi Rasu (Zone 1)','Chifra','Kebele 04'),(5,'Afar','Awsi Rasu (Zone 1)','Dubti','Kebele 05'),(6,'Afar','Kilbet Rasu (Zone 2)','Abala','Kebele 01'),(7,'Afar','Kilbet Rasu (Zone 2)','Afdera','Kebele 02'),(8,'Afar','Kilbet Rasu (Zone 2)','Berhale','Kebele 03'),(9,'Afar','Kilbet Rasu (Zone 2)','Bidu','Kebele 04'),(10,'Afar','Kilbet Rasu (Zone 2)','Dallol','Kebele 05'),(11,'Afar','Gabi Rasu (Zone 3)','Amibara','Kebele 01'),(12,'Afar','Gabi Rasu (Zone 3)','Awash Fentale','Kebele 02'),(13,'Afar','Gabi Rasu (Zone 3)','Bure Mudaytu','Kebele 03'),(14,'Afar','Gabi Rasu (Zone 3)','Dulecha','Kebele 04'),(15,'Afar','Gabi Rasu (Zone 3)','Gewane','Kebele 05'),(16,'Afar','Fantí Rasu (Zone 4)','Aura','Kebele 01'),(17,'Afar','Fantí Rasu (Zone 4)','Ewa','Kebele 02'),(18,'Afar','Fantí Rasu (Zone 4)','Gulina','Kebele 03'),(19,'Afar','Fantí Rasu (Zone 4)','Teru','Kebele 04'),(20,'Afar','Fantí Rasu (Zone 4)','Yalo','Kebele 05'),(21,'Afar','Hari Rasu (Zone 5)','Dalifage','Kebele 01'),(22,'Afar','Hari Rasu (Zone 5)','Dewe','Kebele 02'),(23,'Afar','Hari Rasu (Zone 5)','Hadele Ele','Kebele 03'),(24,'Afar','Hari Rasu (Zone 5)','Simurobi Gele\'alo','Kebele 04'),(25,'Afar','Hari Rasu (Zone 5)','Telalak','Kebele 05'),(26,'Amhara','Agew Awi Zone','Ankasha Guagusa','Kebele 01'),(27,'Amhara','Agew Awi Zone','Ankasha Guagusa','Kebele 02'),(28,'Amhara','Agew Awi Zone','Ankasha Guagusa','Kebele 03'),(29,'Amhara','Agew Awi Zone','Ankasha Guagusa','Kebele 04'),(30,'Amhara','Agew Awi Zone','Banja Shekudad','Kebele 01'),(31,'Amhara','Agew Awi Zone','Banja Shekudad','Kebele 02'),(32,'Amhara','Agew Awi Zone','Banja Shekudad','Kebele 03'),(33,'Amhara','Agew Awi Zone','Banja Shekudad','Kebele 04'),(34,'Amhara','East Gojjam Zone','Aneded','Kebele 01'),(35,'Amhara','East Gojjam Zone','Aneded','Kebele 02'),(36,'Amhara','East Gojjam Zone','Aneded','Kebele 03'),(37,'Amhara','East Gojjam Zone','Aneded','Kebele 04'),(38,'Amhara','East Gojjam Zone','Awabel','Kebele 01'),(39,'Amhara','East Gojjam Zone','Awabel','Kebele 02'),(40,'Amhara','East Gojjam Zone','Awabel','Kebele 03'),(41,'Amhara','East Gojjam Zone','Awabel','Kebele 04'),(42,'Amhara','North Gondar Zone','Addi Arkay','Kebele 01'),(43,'Amhara','North Gondar Zone','Addi Arkay','Kebele 02'),(44,'Amhara','North Gondar Zone','Addi Arkay','Kebele 03'),(45,'Amhara','North Gondar Zone','Addi Arkay','Kebele 04'),(46,'Amhara','North Gondar Zone','Alefa','Kebele 01'),(47,'Amhara','North Gondar Zone','Alefa','Kebele 02'),(48,'Amhara','North Gondar Zone','Alefa','Kebele 03'),(49,'Amhara','North Gondar Zone','Alefa','Kebele 04'),(50,'Amhara','North Shewa Zone','Angolalla Tera','Kebele 01'),(51,'Amhara','North Shewa Zone','Angolalla Tera','Kebele 02'),(52,'Amhara','North Shewa Zone','Angolalla Tera','Kebele 03'),(53,'Amhara','North Shewa Zone','Angolalla Tera','Kebele 04'),(54,'Amhara','North Shewa Zone','Ankober','Kebele 01'),(55,'Amhara','North Shewa Zone','Ankober','Kebele 02'),(56,'Amhara','North Shewa Zone','Ankober','Kebele 03'),(57,'Amhara','North Shewa Zone','Ankober','Kebele 04'),(58,'Amhara','North Wollo Zone','Bugna','Kebele 01'),(59,'Amhara','North Wollo Zone','Bugna','Kebele 02'),(60,'Amhara','North Wollo Zone','Bugna','Kebele 03'),(61,'Amhara','North Wollo Zone','Bugna','Kebele 04'),(62,'Amhara','North Wollo Zone','Dawunt','Kebele 01'),(63,'Amhara','North Wollo Zone','Dawunt','Kebele 02'),(64,'Amhara','North Wollo Zone','Dawunt','Kebele 03'),(65,'Amhara','North Wollo Zone','Dawunt','Kebele 04'),(66,'Amhara','South Gondar Zone','Debre Tabor Town','Kebele 01'),(67,'Amhara','South Gondar Zone','Debre Tabor Town','Kebele 02'),(68,'Amhara','South Gondar Zone','Debre Tabor Town','Kebele 03'),(69,'Amhara','South Gondar Zone','Debre Tabor Town','Kebele 04'),(70,'Amhara','South Gondar Zone','Dera','Kebele 01'),(71,'Amhara','South Gondar Zone','Dera','Kebele 02'),(72,'Amhara','South Gondar Zone','Dera','Kebele 03'),(73,'Amhara','South Gondar Zone','Dera','Kebele 04'),(74,'Oromia','Borena Zone','Abaya','Arero'),(75,'Oromia','Borena Zone','Abaya','Bule Hora'),(76,'Oromia','Borena Zone','Abaya','Dillo'),(77,'Oromia','Borena Zone','Abaya','Dire'),(78,'Oromia','Borena Zone','Abaya','Dugda Dawa'),(79,'Oromia','Borena Zone','Abaya','Gelana'),(80,'Oromia','Borena Zone','Abaya','Gomole'),(81,'Oromia','Borena Zone','Abaya','Malka Soda'),(82,'Oromia','Borena Zone','Abaya','Miyu'),(83,'Oromia','Borena Zone','Abaya','Moyale'),(84,'Oromia','Borena Zone','Abaya','Teltele'),(85,'Oromia','Buno Bedele Zone','Bedele','Kebele 01'),(86,'Oromia','Buno Bedele Zone','Bedele','Kebele 02'),(87,'Oromia','Buno Bedele Zone','Bedele','Kebele 03'),(88,'Oromia','Buno Bedele Zone','Bedele','Kebele 04'),(89,'Oromia','East Hararghe Zone','Babile','Kebele 01'),(90,'Oromia','East Hararghe Zone','Babile','Kebele 02'),(91,'Oromia','East Hararghe Zone','Babile','Kebele 03'),(92,'Oromia','East Hararghe Zone','Babile','Kebele 04'),(93,'Oromia','East Hararghe Zone','Babile','Kebele 05'),(94,'Oromia','East Hararghe Zone','Badeno','Kebele 01'),(95,'Oromia','East Hararghe Zone','Badeno','Kebele 02'),(96,'Oromia','East Hararghe Zone','Badeno','Kebele 03'),(97,'Oromia','East Hararghe Zone','Badeno','Kebele 04'),(98,'Oromia','East Hararghe Zone','Badeno','Kebele 05'),(99,'Oromia','East Hararghe Zone','Chinaksen','Kebele 01'),(100,'Oromia','East Hararghe Zone','Chinaksen','Kebele 02'),(101,'Oromia','East Hararghe Zone','Chinaksen','Kebele 03'),(102,'Oromia','East Hararghe Zone','Chinaksen','Kebele 04'),(103,'Oromia','East Hararghe Zone','Chinaksen','Kebele 05'),(104,'Oromia','East Hararghe Zone','Dadar','Kebele 01'),(105,'Oromia','East Hararghe Zone','Dadar','Kebele 02'),(106,'Oromia','East Hararghe Zone','Dadar','Kebele 03'),(107,'Oromia','East Hararghe Zone','Dadar','Kebele 04'),(108,'Oromia','East Hararghe Zone','Dadar','Kebele 05'),(109,'Oromia','East Shewa Zone','Ada\'a','Kebele 01'),(110,'Oromia','East Shewa Zone','Ada\'a','Kebele 02'),(111,'Oromia','East Shewa Zone','Ada\'a','Kebele 03'),(112,'Oromia','East Shewa Zone','Ada\'a','Kebele 04'),(113,'Oromia','East Shewa Zone','Adami Tullu and Jido Kombolcha','Kebele 01'),(114,'Oromia','East Shewa Zone','Adami Tullu and Jido Kombolcha','Kebele 02'),(115,'Oromia','East Shewa Zone','Adami Tullu and Jido Kombolcha','Kebele 03'),(116,'Oromia','East Shewa Zone','Adami Tullu and Jido Kombolcha','Kebele 04'),(117,'Oromia','East Shewa Zone','Adami Tullu and Jido Kombolcha','Kebele 05'),(118,'Oromia','East Welega Zone','Bonaya Boshe','Kebele 01'),(119,'Oromia','East Welega Zone','Bonaya Boshe','Kebele 02'),(120,'Oromia','East Welega Zone','Bonaya Boshe','Kebele 03'),(121,'Oromia','East Welega Zone','Bonaya Boshe','Kebele 04'),(122,'Oromia','East Welega Zone','Bonaya Boshe','Kebele 05'),(123,'Oromia','East Welega Zone','Diga','Kebele 01'),(124,'Oromia','East Welega Zone','Diga','Kebele 02'),(125,'Oromia','East Welega Zone','Diga','Kebele 03'),(126,'Oromia','East Welega Zone','Diga','Kebele 04'),(127,'Oromia','East Welega Zone','Diga','Kebele 05'),(128,'Oromia','East Welega Zone','Gida Kiremu','Kebele 01'),(129,'Oromia','East Welega Zone','Gida Kiremu','Kebele 02'),(130,'Oromia','East Welega Zone','Gida Kiremu','Kebele 03'),(131,'Oromia','East Welega Zone','Gida Kiremu','Kebele 04'),(132,'Oromia','East Welega Zone','Gida Kiremu','Kebele 05'),(133,'Oromia','Guji Zone','Adola','Kebele 01'),(134,'Oromia','Guji Zone','Adola','Kebele 02'),(135,'Oromia','Guji Zone','Adola','Kebele 03'),(136,'Oromia','Guji Zone','Adola','Kebele 04'),(137,'Oromia','Guji Zone','Adola','Kebele 05'),(138,'Oromia','Guji Zone','Adola Town','Kebele 01'),(139,'Oromia','Guji Zone','Adola Town','Kebele 02'),(140,'Oromia','Guji Zone','Adola Town','Kebele 03'),(141,'Oromia','Guji Zone','Adola Town','Kebele 04'),(142,'Oromia','Guji Zone','Adola Town','Kebele 05'),(143,'Oromia','Guji Zone','Arero','Kebele 01'),(144,'Oromia','Guji Zone','Arero','Kebele 02'),(145,'Oromia','Guji Zone','Arero','Kebele 03'),(146,'Oromia','Guji Zone','Arero','Kebele 04'),(147,'Oromia','Guji Zone','Arero','Kebele 05'),(148,'Somali','Afder Zone','Afder','Kebele 1'),(149,'Somali','Afder Zone','Afder','Kebele 2'),(150,'Somali','Afder Zone','Afder','Kebele 3'),(151,'Somali','Afder Zone','Afder','Kebele 4'),(152,'Somali','Afder Zone','Bare','Kebele 1'),(153,'Somali','Afder Zone','Bare','Kebele 2'),(154,'Somali','Afder Zone','Bare','Kebele 3'),(155,'Somali','Afder Zone','Bare','Kebele 4'),(156,'Somali','Afder Zone','Chereti','Kebele 1'),(157,'Somali','Afder Zone','Chereti','Kebele 2'),(158,'Somali','Afder Zone','Chereti','Kebele 3'),(159,'Somali','Afder Zone','Chereti','Kebele 4'),(160,'Somali','Afder Zone','Dolobay','Kebele 1'),(161,'Somali','Afder Zone','Dolobay','Kebele 2'),(162,'Somali','Afder Zone','Dolobay','Kebele 3'),(163,'Somali','Afder Zone','Dolobay','Kebele 4'),(164,'Somali','Dhawa Zone','Hudet','Kebele 1'),(165,'Somali','Dhawa Zone','Hudet','Kebele 2'),(166,'Somali','Dhawa Zone','Hudet','Kebele 3'),(167,'Somali','Dhawa Zone','Hudet','Kebele 4'),(168,'Somali','Dhawa Zone','Moyale','Kebele 1'),(169,'Somali','Dhawa Zone','Moyale','Kebele 2'),(170,'Somali','Dhawa Zone','Moyale','Kebele 3'),(171,'Somali','Dhawa Zone','Moyale','Kebele 4'),(172,'Somali','Dhawa Zone','Mubaarak','Kebele 1'),(173,'Somali','Dhawa Zone','Mubaarak','Kebele 2'),(174,'Somali','Dhawa Zone','Mubaarak','Kebele 3'),(175,'Somali','Dhawa Zone','Mubaarak','Kebele 4'),(176,'Somali','Dhawa Zone','Qadhaadhumo','Kebele 1'),(177,'Somali','Dhawa Zone','Qadhaadhumo','Kebele 2'),(178,'Somali','Dhawa Zone','Qadhaadhumo','Kebele 3'),(179,'Somali','Dhawa Zone','Qadhaadhumo','Kebele 4'),(180,'Somali','Dollo Zone','Boh','Kebele 1'),(181,'Somali','Dollo Zone','Boh','Kebele 2'),(182,'Somali','Dollo Zone','Boh','Kebele 3'),(183,'Somali','Dollo Zone','Boh','Kebele 4'),(184,'Somali','Dollo Zone','Danot','Kebele 1'),(185,'Somali','Dollo Zone','Danot','Kebele 2'),(186,'Somali','Dollo Zone','Danot','Kebele 3'),(187,'Somali','Dollo Zone','Danot','Kebele 4'),(188,'Somali','Dollo Zone','Daratole','Kebele 1'),(189,'Somali','Dollo Zone','Daratole','Kebele 2'),(190,'Somali','Dollo Zone','Daratole','Kebele 3'),(191,'Somali','Dollo Zone','Daratole','Kebele 4'),(192,'Somali','Dollo Zone','Gal-Hamur','Kebele 1'),(193,'Somali','Dollo Zone','Gal-Hamur','Kebele 2'),(194,'Somali','Dollo Zone','Gal-Hamur','Kebele 3'),(195,'Somali','Dollo Zone','Gal-Hamur','Kebele 4'),(196,'Somali','Dollo Zone','Geladin','Kebele 1'),(197,'Somali','Dollo Zone','Geladin','Kebele 2'),(198,'Somali','Dollo Zone','Geladin','Kebele 3'),(199,'Somali','Dollo Zone','Geladin','Kebele 4'),(200,'Somali','Dollo Zone','Lehel-Yucub','Kebele 1'),(201,'Somali','Dollo Zone','Lehel-Yucub','Kebele 2'),(202,'Somali','Dollo Zone','Lehel-Yucub','Kebele 3'),(203,'Somali','Dollo Zone','Lehel-Yucub','Kebele 4'),(204,'Somali','Dollo Zone','Warder','Kebele 1'),(205,'Somali','Dollo Zone','Warder','Kebele 2'),(206,'Somali','Dollo Zone','Warder','Kebele 3'),(207,'Somali','Dollo Zone','Warder','Kebele 4'),(208,'Somali','Erer Zone','Fiq','Kebele 1'),(209,'Somali','Erer Zone','Fiq','Kebele 2'),(210,'Somali','Erer Zone','Fiq','Kebele 3'),(211,'Somali','Erer Zone','Fiq','Kebele 4'),(212,'Somali','Erer Zone','Lagahida','Kebele 1'),(213,'Somali','Erer Zone','Lagahida','Kebele 2'),(214,'Somali','Erer Zone','Lagahida','Kebele 3'),(215,'Somali','Erer Zone','Lagahida','Kebele 4'),(216,'Somali','Erer Zone','Mayaa-muluqo','Kebele 1'),(217,'Somali','Erer Zone','Mayaa-muluqo','Kebele 2'),(218,'Somali','Erer Zone','Mayaa-muluqo','Kebele 3'),(219,'Somali','Erer Zone','Mayaa-muluqo','Kebele 4'),(220,'Somali','Erer Zone','Qubi','Kebele 1'),(221,'Somali','Erer Zone','Qubi','Kebele 2'),(222,'Somali','Erer Zone','Qubi','Kebele 3'),(223,'Somali','Erer Zone','Qubi','Kebele 4'),(224,'Somali','Erer Zone','Salahad','Kebele 1'),(225,'Somali','Erer Zone','Salahad','Kebele 2'),(226,'Somali','Erer Zone','Salahad','Kebele 3'),(227,'Somali','Erer Zone','Salahad','Kebele 4'),(228,'Somali','Erer Zone','Waangaay','Kebele 1'),(229,'Somali','Erer Zone','Waangaay','Kebele 2'),(230,'Somali','Erer Zone','Waangaay','Kebele 3'),(231,'Somali','Erer Zone','Waangaay','Kebele 4'),(232,'Somali','Erer Zone','Xamaro','Kebele 1'),(233,'Somali','Erer Zone','Xamaro','Kebele 2'),(234,'Somali','Erer Zone','Xamaro','Kebele 3'),(235,'Somali','Erer Zone','Xamaro','Kebele 4'),(236,'Somali','Erer Zone','Yaxoob','Kebele 1'),(237,'Somali','Erer Zone','Yaxoob','Kebele 2'),(238,'Somali','Erer Zone','Yaxoob','Kebele 3'),(239,'Somali','Erer Zone','Yaxoob','Kebele 4'),(240,'Somali','Fafan Zone','Awbare','Kebele 1'),(241,'Somali','Fafan Zone','Awbare','Kebele 2'),(242,'Somali','Fafan Zone','Awbare','Kebele 3'),(243,'Somali','Fafan Zone','Awbare','Kebele 4'),(244,'Somali','Fafan Zone','Babille','Kebele 1'),(245,'Somali','Fafan Zone','Babille','Kebele 2'),(246,'Somali','Fafan Zone','Babille','Kebele 3'),(247,'Somali','Fafan Zone','Babille','Kebele 4'),(248,'Somali','Fafan Zone','Goljano','Kebele 1'),(249,'Somali','Fafan Zone','Goljano','Kebele 2'),(250,'SNNPR','Gamo Zone','Arba Minch Zuria','Kebele 01'),(251,'SNNPR','Gamo Zone','Arba Minch Zuria','Kebele 02'),(252,'SNNPR','Gamo Zone','Arba Minch Zuria','Kebele 03'),(253,'SNNPR','Gamo Zone','Arba Minch Zuria','Kebele 04'),(254,'SNNPR','Gamo Zone','Bonke','Kebele 01'),(255,'SNNPR','Gamo Zone','Bonke','Kebele 02'),(256,'SNNPR','Gamo Zone','Bonke','Kebele 03'),(257,'SNNPR','Gamo Zone','Bonke','Kebele 04'),(258,'SNNPR','Gamo Zone','Chencha','Kebele 01'),(259,'SNNPR','Gamo Zone','Chencha','Kebele 02'),(260,'SNNPR','Gamo Zone','Chencha','Kebele 03'),(261,'SNNPR','Gamo Zone','Chencha','Kebele 04'),(262,'SNNPR','Gamo Zone','Deramalo','Kebele 01'),(263,'SNNPR','Gamo Zone','Deramalo','Kebele 02'),(264,'SNNPR','Gamo Zone','Deramalo','Kebele 03'),(265,'SNNPR','Gamo Zone','Deramalo','Kebele 04'),(266,'SNNPR','Gedeo Zone','Dila Zuria','Kebele 01'),(267,'SNNPR','Gedeo Zone','Dila Zuria','Kebele 02'),(268,'SNNPR','Gedeo Zone','Dila Zuria','Kebele 03'),(269,'SNNPR','Gedeo Zone','Dila Zuria','Kebele 04'),(270,'SNNPR','Gedeo Zone','Gedeb','Kebele 01'),(271,'SNNPR','Gedeo Zone','Gedeb','Kebele 02'),(272,'SNNPR','Gedeo Zone','Gedeb','Kebele 03'),(273,'SNNPR','Gedeo Zone','Gedeb','Kebele 04'),(274,'SNNPR','Gurage Zone','Butajira','Kebele 01'),(275,'SNNPR','Gurage Zone','Butajira','Kebele 02'),(276,'SNNPR','Gurage Zone','Butajira','Kebele 03'),(277,'SNNPR','Gurage Zone','Butajira','Kebele 04'),(278,'SNNPR','Gurage Zone','Cheha','Kebele 01'),(279,'SNNPR','Gurage Zone','Cheha','Kebele 02'),(280,'SNNPR','Gurage Zone','Cheha','Kebele 03'),(281,'SNNPR','Gurage Zone','Cheha','Kebele 04'),(282,'SNNPR','Hadiya Zone','Hosaena Town','Kebele 01'),(283,'SNNPR','Hadiya Zone','Hosaena Town','Kebele 02'),(284,'SNNPR','Hadiya Zone','Hosaena Town','Kebele 03'),(285,'SNNPR','Hadiya Zone','Hosaena Town','Kebele 04'),(286,'SNNPR','Hadiya Zone','Gomibora','Kebele 01'),(287,'SNNPR','Hadiya Zone','Gomibora','Kebele 02'),(288,'SNNPR','Hadiya Zone','Gomibora','Kebele 03'),(289,'SNNPR','Hadiya Zone','Gomibora','Kebele 04'),(290,'SNNPR','Kembata Tembaro Zone','Durame Town','Kebele 01'),(291,'SNNPR','Kembata Tembaro Zone','Durame Town','Kebele 02'),(292,'SNNPR','Kembata Tembaro Zone','Durame Town','Kebele 03'),(293,'SNNPR','Kembata Tembaro Zone','Durame Town','Kebele 04'),(294,'SNNPR','Kembata Tembaro Zone','Kacha Bira','Kebele 01'),(295,'SNNPR','Kembata Tembaro Zone','Kacha Bira','Kebele 02'),(296,'SNNPR','Kembata Tembaro Zone','Kacha Bira','Kebele 03'),(297,'SNNPR','Kembata Tembaro Zone','Kacha Bira','Kebele 04'),(298,'SNNPR','South Omo Zone','Bako Gazer','Kebele 01'),(299,'SNNPR','South Omo Zone','Bako Gazer','Kebele 02'),(300,'SNNPR','South Omo Zone','Bako Gazer','Kebele 03'),(301,'SNNPR','South Omo Zone','Bako Gazer','Kebele 04'),(302,'SNNPR','South Omo Zone','Bena Tsemay','Kebele 01'),(303,'SNNPR','South Omo Zone','Bena Tsemay','Kebele 02'),(304,'SNNPR','South Omo Zone','Bena Tsemay','Kebele 03'),(305,'SNNPR','South Omo Zone','Bena Tsemay','Kebele 04'),(306,'SNNPR','Wolayita Zone','Arba Abaya','Kebele 01'),(307,'SNNPR','Wolayita Zone','Arba Abaya','Kebele 02'),(308,'SNNPR','Wolayita Zone','Arba Abaya','Kebele 03'),(309,'SNNPR','Wolayita Zone','Arba Abaya','Kebele 04'),(310,'SNNPR','Wolayita Zone','Boloso Bombe','Kebele 01'),(311,'SNNPR','Wolayita Zone','Boloso Bombe','Kebele 02'),(312,'SNNPR','Wolayita Zone','Boloso Bombe','Kebele 03'),(313,'SNNPR','Wolayita Zone','Boloso Bombe','Kebele 04'),(314,'Tigray','Central Zone','Adwa','Kebele 1'),(315,'Tigray','Central Zone','Adwa','Kebele 2'),(316,'Tigray','Central Zone','Adwa','Kebele 3'),(317,'Tigray','Central Zone','Adwa','Kebele 4'),(318,'Tigray','Central Zone','Axum','Kebele 1'),(319,'Tigray','Central Zone','Axum','Kebele 2'),(320,'Tigray','Central Zone','Axum','Kebele 3'),(321,'Tigray','Central Zone','Axum','Kebele 4'),(322,'Tigray','Eastern Zone','Adigrat','Kebele 1'),(323,'Tigray','Eastern Zone','Adigrat','Kebele 2'),(324,'Tigray','Eastern Zone','Adigrat','Kebele 3'),(325,'Tigray','Eastern Zone','Adigrat','Kebele 4'),(326,'Tigray','Eastern Zone','Atsbi Wenberta','Kebele 1'),(327,'Tigray','Eastern Zone','Atsbi Wenberta','Kebele 2'),(328,'Tigray','Eastern Zone','Atsbi Wenberta','Kebele 3'),(329,'Tigray','Eastern Zone','Atsbi Wenberta','Kebele 4'),(330,'Tigray','South Eastern Zone','Enderta','Kebele 1'),(331,'Tigray','South Eastern Zone','Enderta','Kebele 2'),(332,'Tigray','South Eastern Zone','Enderta','Kebele 3'),(333,'Tigray','South Eastern Zone','Enderta','Kebele 4'),(334,'Tigray','South Eastern Zone','Hintalo Wajirat','Kebele 1'),(335,'Tigray','South Eastern Zone','Hintalo Wajirat','Kebele 2'),(336,'Tigray','South Eastern Zone','Hintalo Wajirat','Kebele 3'),(337,'Tigray','South Eastern Zone','Hintalo Wajirat','Kebele 4'),(338,'Tigray','Southern Zone','Alaje','Kebele 1'),(339,'Tigray','Southern Zone','Alaje','Kebele 2'),(340,'Tigray','Southern Zone','Alaje','Kebele 3'),(341,'Tigray','Southern Zone','Alaje','Kebele 4'),(342,'Tigray','Southern Zone','Alamata','Kebele 1'),(343,'Tigray','Southern Zone','Alamata','Kebele 2'),(344,'Tigray','Southern Zone','Alamata','Kebele 3'),(345,'Tigray','Southern Zone','Alamata','Kebele 4'),(346,'Benishangul-Gumuz','Asosa Zone','Asosa','Kebele 1'),(347,'Benishangul-Gumuz','Asosa Zone','Asosa','Kebele 2'),(348,'Benishangul-Gumuz','Asosa Zone','Asosa','Kebele 3'),(349,'Benishangul-Gumuz','Asosa Zone','Asosa','Kebele 4'),(350,'Benishangul-Gumuz','Asosa Zone','Bambasi','Kebele 1'),(351,'Benishangul-Gumuz','Asosa Zone','Bambasi','Kebele 2'),(352,'Benishangul-Gumuz','Asosa Zone','Bambasi','Kebele 3'),(353,'Benishangul-Gumuz','Asosa Zone','Bambasi','Kebele 4'),(354,'Benishangul-Gumuz','Asosa Zone','Komesha','Kebele 1'),(355,'Benishangul-Gumuz','Asosa Zone','Komesha','Kebele 2'),(356,'Benishangul-Gumuz','Asosa Zone','Komesha','Kebele 3'),(357,'Benishangul-Gumuz','Asosa Zone','Komesha','Kebele 4'),(358,'Benishangul-Gumuz','Asosa Zone','Kurmuk','Kebele 1'),(359,'Benishangul-Gumuz','Asosa Zone','Kurmuk','Kebele 2'),(360,'Benishangul-Gumuz','Asosa Zone','Kurmuk','Kebele 3'),(361,'Benishangul-Gumuz','Asosa Zone','Kurmuk','Kebele 4'),(362,'Benishangul-Gumuz','Asosa Zone','Menge','Kebele 1'),(363,'Benishangul-Gumuz','Asosa Zone','Menge','Kebele 2'),(364,'Benishangul-Gumuz','Asosa Zone','Menge','Kebele 3'),(365,'Benishangul-Gumuz','Asosa Zone','Menge','Kebele 4'),(366,'Benishangul-Gumuz','Asosa Zone','Sherkole','Kebele 1'),(367,'Benishangul-Gumuz','Asosa Zone','Sherkole','Kebele 2'),(368,'Benishangul-Gumuz','Asosa Zone','Sherkole','Kebele 3'),(369,'Benishangul-Gumuz','Asosa Zone','Sherkole','Kebele 4'),(370,'Benishangul-Gumuz','Kamashi Zone','Agalo Mite','Kebele 1'),(371,'Benishangul-Gumuz','Kamashi Zone','Agalo Mite','Kebele 2'),(372,'Benishangul-Gumuz','Kamashi Zone','Agalo Mite','Kebele 3'),(373,'Benishangul-Gumuz','Kamashi Zone','Agalo Mite','Kebele 4'),(374,'Benishangul-Gumuz','Kamashi Zone','Belo Jegonfoy','Kebele 1'),(375,'Benishangul-Gumuz','Kamashi Zone','Belo Jegonfoy','Kebele 2'),(376,'Benishangul-Gumuz','Kamashi Zone','Belo Jegonfoy','Kebele 3'),(377,'Benishangul-Gumuz','Kamashi Zone','Belo Jegonfoy','Kebele 4'),(378,'Benishangul-Gumuz','Kamashi Zone','Kamashi','Kebele 1'),(379,'Benishangul-Gumuz','Kamashi Zone','Kamashi','Kebele 2'),(380,'Benishangul-Gumuz','Kamashi Zone','Kamashi','Kebele 3'),(381,'Benishangul-Gumuz','Kamashi Zone','Kamashi','Kebele 4'),(382,'Benishangul-Gumuz','Kamashi Zone','Sirba Abbay','Kebele 1'),(383,'Benishangul-Gumuz','Kamashi Zone','Sirba Abbay','Kebele 2'),(384,'Benishangul-Gumuz','Kamashi Zone','Sirba Abbay','Kebele 3'),(385,'Benishangul-Gumuz','Kamashi Zone','Sirba Abbay','Kebele 4'),(386,'Benishangul-Gumuz','Kamashi Zone','Yaso','Kebele 1'),(387,'Benishangul-Gumuz','Kamashi Zone','Yaso','Kebele 2'),(388,'Benishangul-Gumuz','Kamashi Zone','Yaso','Kebele 3'),(389,'Benishangul-Gumuz','Kamashi Zone','Yaso','Kebele 4'),(390,'Benishangul-Gumuz','Metekel Zone','Bulen','Kebele 1'),(391,'Benishangul-Gumuz','Metekel Zone','Bulen','Kebele 2'),(392,'Benishangul-Gumuz','Metekel Zone','Bulen','Kebele 3'),(393,'Benishangul-Gumuz','Metekel Zone','Bulen','Kebele 4'),(394,'Benishangul-Gumuz','Metekel Zone','Dangur','Kebele 1'),(395,'Benishangul-Gumuz','Metekel Zone','Dangur','Kebele 2'),(396,'Benishangul-Gumuz','Metekel Zone','Dangur','Kebele 3'),(397,'Benishangul-Gumuz','Metekel Zone','Dangur','Kebele 4'),(398,'Benishangul-Gumuz','Metekel Zone','Dibate','Kebele 1'),(399,'Benishangul-Gumuz','Metekel Zone','Dibate','Kebele 2'),(400,'Benishangul-Gumuz','Metekel Zone','Dibate','Kebele 3'),(401,'Benishangul-Gumuz','Metekel Zone','Dibate','Kebele 4'),(402,'Benishangul-Gumuz','Metekel Zone','Guba','Kebele 1'),(403,'Benishangul-Gumuz','Metekel Zone','Guba','Kebele 2'),(404,'Benishangul-Gumuz','Metekel Zone','Guba','Kebele 3'),(405,'Benishangul-Gumuz','Metekel Zone','Guba','Kebele 4'),(406,'Benishangul-Gumuz','Metekel Zone','Mandura','Kebele 1'),(407,'Benishangul-Gumuz','Metekel Zone','Mandura','Kebele 2'),(408,'Benishangul-Gumuz','Metekel Zone','Mandura','Kebele 3'),(409,'Benishangul-Gumuz','Metekel Zone','Mandura','Kebele 4'),(410,'Benishangul-Gumuz','Metekel Zone','Wenbera','Kebele 1'),(411,'Benishangul-Gumuz','Metekel Zone','Wenbera','Kebele 2'),(412,'Benishangul-Gumuz','Metekel Zone','Wenbera','Kebele 3'),(413,'Benishangul-Gumuz','Metekel Zone','Wenbera','Kebele 4'),(414,'Harari','Amir-Nur','Amir-Nur Woreda','Kebele 1'),(415,'Harari','Amir-Nur','Amir-Nur Woreda','Kebele 2'),(416,'Harari','Amir-Nur','Amir-Nur Woreda','Kebele 3'),(417,'Harari','Amir-Nur','Amir-Nur Woreda','Kebele 4'),(418,'Harari','Abadir','Abadir Woreda','Kebele 1'),(419,'Harari','Abadir','Abadir Woreda','Kebele 2'),(420,'Harari','Abadir','Abadir Woreda','Kebele 3'),(421,'Harari','Abadir','Abadir Woreda','Kebele 4'),(422,'Harari','Shenkor','Shenkor Woreda','Kebele 1'),(423,'Harari','Shenkor','Shenkor Woreda','Kebele 2'),(424,'Harari','Shenkor','Shenkor Woreda','Kebele 3'),(425,'Harari','Shenkor','Shenkor Woreda','Kebele 4'),(426,'Harari','Jin\'Eala','Jin\'Eala Woreda','Kebele 1'),(427,'Harari','Jin\'Eala','Jin\'Eala Woreda','Kebele 2'),(428,'Harari','Jin\'Eala','Jin\'Eala Woreda','Kebele 3'),(429,'Harari','Jin\'Eala','Jin\'Eala Woreda','Kebele 4'),(430,'Harari','Aboker','Aboker Woreda','Kebele 1'),(431,'Harari','Aboker','Aboker Woreda','Kebele 2'),(432,'Harari','Aboker','Aboker Woreda','Kebele 3'),(433,'Harari','Aboker','Aboker Woreda','Kebele 4'),(434,'Harari','Hakim','Hakim Woreda','Kebele 1'),(435,'Harari','Hakim','Hakim Woreda','Kebele 2'),(436,'Harari','Hakim','Hakim Woreda','Kebele 3'),(437,'Harari','Hakim','Hakim Woreda','Kebele 4'),(438,'Harari','Sofi','Sofi Woreda','Kebele 1'),(439,'Harari','Sofi','Sofi Woreda','Kebele 2'),(440,'Harari','Sofi','Sofi Woreda','Kebele 3'),(441,'Harari','Sofi','Sofi Woreda','Kebele 4'),(442,'Harari','Erer','Erer Woreda','Kebele 1'),(443,'Harari','Erer','Erer Woreda','Kebele 2'),(444,'Harari','Erer','Erer Woreda','Kebele 3'),(445,'Harari','Erer','Erer Woreda','Kebele 4'),(446,'Gambela','Anyuak Zone','Abwobo','Kebele 1'),(447,'Gambela','Anyuak Zone','Abwobo','Kebele 2'),(448,'Gambela','Anyuak Zone','Abwobo','Kebele 3'),(449,'Gambela','Anyuak Zone','Abwobo','Kebele 4'),(450,'Gambela','Anyuak Zone','Dimma','Kebele 1'),(451,'Gambela','Anyuak Zone','Dimma','Kebele 2'),(452,'Gambela','Anyuak Zone','Dimma','Kebele 3'),(453,'Gambela','Anyuak Zone','Dimma','Kebele 4'),(454,'Gambela','Anyuak Zone','Gambela','Kebele 1'),(455,'Gambela','Anyuak Zone','Gambela','Kebele 2'),(456,'Gambela','Anyuak Zone','Gambela','Kebele 3'),(457,'Gambela','Anyuak Zone','Gambela','Kebele 4'),(458,'Gambela','Anyuak Zone','Gog','Kebele 1'),(459,'Gambela','Anyuak Zone','Gog','Kebele 2'),(460,'Gambela','Anyuak Zone','Gog','Kebele 3'),(461,'Gambela','Anyuak Zone','Gog','Kebele 4'),(462,'Gambela','Anyuak Zone','Jor','Kebele 1'),(463,'Gambela','Anyuak Zone','Jor','Kebele 2'),(464,'Gambela','Anyuak Zone','Jor','Kebele 3'),(465,'Gambela','Anyuak Zone','Jor','Kebele 4'),(466,'Gambela','Nuer Zone','Akobo','Kebele 1'),(467,'Gambela','Nuer Zone','Akobo','Kebele 2'),(468,'Gambela','Nuer Zone','Akobo','Kebele 3'),(469,'Gambela','Nuer Zone','Akobo','Kebele 4'),(470,'Gambela','Nuer Zone','Jikaw','Kebele 1'),(471,'Gambela','Nuer Zone','Jikaw','Kebele 2'),(472,'Gambela','Nuer Zone','Jikaw','Kebele 3'),(473,'Gambela','Nuer Zone','Jikaw','Kebele 4'),(474,'Gambela','Nuer Zone','Lare','Kebele 1'),(475,'Gambela','Nuer Zone','Lare','Kebele 2'),(476,'Gambela','Nuer Zone','Lare','Kebele 3'),(477,'Gambela','Nuer Zone','Lare','Kebele 4'),(478,'Gambela','Nuer Zone','Wentawo','Kebele 1'),(479,'Gambela','Nuer Zone','Wentawo','Kebele 2'),(480,'Gambela','Nuer Zone','Wentawo','Kebele 3'),(481,'Gambela','Nuer Zone','Wentawo','Kebele 4'),(482,'Gambela','Mezhenger Zone','Godere','Kebele 1'),(483,'Gambela','Mezhenger Zone','Godere','Kebele 2'),(484,'Gambela','Mezhenger Zone','Godere','Kebele 3'),(485,'Gambela','Mezhenger Zone','Godere','Kebele 4'),(486,'Gambela','Mezhenger Zone','Mengesh','Kebele 1'),(487,'Gambela','Mezhenger Zone','Mengesh','Kebele 2'),(488,'Gambela','Mezhenger Zone','Mengesh','Kebele 3'),(489,'Gambela','Mezhenger Zone','Mengesh','Kebele 4'),(490,'Addis Ababa','Addis Ketema','Woreda 01','Kebele 01'),(491,'Addis Ababa','Addis Ketema','Woreda 01','Kebele 02'),(492,'Addis Ababa','Addis Ketema','Woreda 01','Kebele 03'),(493,'Addis Ababa','Addis Ketema','Woreda 01','Kebele 04'),(494,'Addis Ababa','Addis Ketema','Woreda 02','Kebele 01'),(495,'Addis Ababa','Addis Ketema','Woreda 02','Kebele 02'),(496,'Addis Ababa','Addis Ketema','Woreda 02','Kebele 03'),(497,'Addis Ababa','Addis Ketema','Woreda 02','Kebele 04'),(498,'Addis Ababa','Arada','Woreda 01','Kebele 01'),(499,'Addis Ababa','Arada','Woreda 01','Kebele 02'),(500,'Addis Ababa','Arada','Woreda 01','Kebele 03'),(501,'Addis Ababa','Arada','Woreda 01','Kebele 04'),(502,'Addis Ababa','Arada','Woreda 02','Kebele 01'),(503,'Addis Ababa','Arada','Woreda 02','Kebele 02'),(504,'Addis Ababa','Arada','Woreda 02','Kebele 03'),(505,'Addis Ababa','Arada','Woreda 02','Kebele 04'),(506,'Addis Ababa','Kolfe Keranio','Woreda 01','Kebele 01'),(507,'Addis Ababa','Kolfe Keranio','Woreda 01','Kebele 02'),(508,'Addis Ababa','Kolfe Keranio','Woreda 01','Kebele 03'),(509,'Addis Ababa','Kolfe Keranio','Woreda 01','Kebele 04'),(510,'Addis Ababa','Kolfe Keranio','Woreda 02','Kebele 01'),(511,'Addis Ababa','Kolfe Keranio','Woreda 02','Kebele 02'),(512,'Addis Ababa','Kolfe Keranio','Woreda 02','Kebele 03'),(513,'Addis Ababa','Kolfe Keranio','Woreda 02','Kebele 04');
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) NOT NULL,
  `fathername` varchar(100) NOT NULL,
  `grandfathername` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `sex` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `age` int NOT NULL,
  `bloodtype` varchar(3) NOT NULL,
  `nationality` varchar(100) NOT NULL,
  `occupation` varchar(100) NOT NULL,
  `dateofbirth` varchar(100) NOT NULL,
  `maritalstatus` varchar(100) NOT NULL,
  `approveddate` varchar(100) NOT NULL,
  `expirationdate` varchar(100) NOT NULL,
  `birthcardverification` varchar(100) NOT NULL,
  `region` varchar(100) NOT NULL,
  `zone` varchar(100) NOT NULL,
  `woreda` varchar(100) NOT NULL,
  `kebele` varchar(100) NOT NULL,
  `image` longblob NOT NULL,
  `house_number` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `phone_UNIQUE` (`phone`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `waiting`
--

DROP TABLE IF EXISTS `waiting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `waiting` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) NOT NULL,
  `fathername` varchar(100) NOT NULL,
  `grandfathername` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `sex` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `age` int NOT NULL,
  `bloodtype` varchar(3) NOT NULL,
  `nationality` varchar(100) NOT NULL,
  `occupation` varchar(100) NOT NULL,
  `dateofbirth` varchar(100) NOT NULL,
  `maritalstatus` varchar(100) NOT NULL,
  `issuedate` varchar(100) NOT NULL,
  `region` varchar(100) NOT NULL,
  `zone` varchar(100) NOT NULL,
  `woreda` varchar(100) NOT NULL,
  `kebele` varchar(100) NOT NULL,
  `image` longblob NOT NULL,
  `house_number` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `phone_UNIQUE` (`phone`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed
