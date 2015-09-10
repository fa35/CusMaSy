-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server Version:               5.6.26 - MySQL Community Server (GPL)
-- Server Betriebssystem:        Win32
-- HeidiSQL Version:             8.3.0.4714
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Exportiere Datenbank Struktur für as_projekt
CREATE DATABASE IF NOT EXISTS `as_projekt` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;
USE `as_projekt`;


-- Exportiere Struktur von Tabelle as_projekt.test
CREATE TABLE IF NOT EXISTS `test` (
  `name` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  `id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Exportiere Daten aus Tabelle as_projekt.test: ~2 rows (ungefähr)
/*!40000 ALTER TABLE `test` DISABLE KEYS */;
INSERT INTO `test` (`name`, `id`) VALUES
	('Yeah', 1),
	('klappt', 2);
/*!40000 ALTER TABLE `test` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
