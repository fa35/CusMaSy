-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server Version:               5.6.26 - MySQL Community Server (GPL)
-- Server Betriebssystem:        Win32
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Exportiere Datenbank Struktur für cusmasydb
CREATE DATABASE IF NOT EXISTS `cusmasydb` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;
USE `cusmasydb`;


-- Exportiere Struktur von Tabelle cusmasydb.anbieter
CREATE TABLE IF NOT EXISTS `anbieter` (
  `p_Anbieter_Nr` bigint(20) NOT NULL AUTO_INCREMENT,
  `Steuernummer` varchar(200) COLLATE utf8_bin NOT NULL,
  `f_AnbieterTyp_Nr` int(11) NOT NULL,
  `Firma` varchar(200) COLLATE utf8_bin NOT NULL,
  `Strasse` varchar(200) COLLATE utf8_bin NOT NULL,
  `Hausnummer` varchar(50) COLLATE utf8_bin NOT NULL,
  `f_Ort_Nr` bigint(20) NOT NULL,
  `Land` varchar(200) COLLATE utf8_bin NOT NULL,
  `Mailadresse` varchar(200) COLLATE utf8_bin NOT NULL,
  `Telefonnummer` varchar(200) COLLATE utf8_bin DEFAULT NULL,
  `Homepage` varchar(200) COLLATE utf8_bin NOT NULL,
  `Branche` varchar(200) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`p_Anbieter_Nr`),
  KEY `f_AnbieterTyp_Nr` (`f_AnbieterTyp_Nr`),
  KEY `f_Ort_Nr` (`f_Ort_Nr`),
  CONSTRAINT `f_AnbieterTyp_Nr` FOREIGN KEY (`f_AnbieterTyp_Nr`) REFERENCES `anbietertyp` (`p_AnbieterTyp_Nr`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `f_Ort_Nr` FOREIGN KEY (`f_Ort_Nr`) REFERENCES `ort` (`p_Ort_Nr`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Daten Export vom Benutzer nicht ausgewählt


-- Exportiere Struktur von Tabelle cusmasydb.anbietertyp
CREATE TABLE IF NOT EXISTS `anbietertyp` (
  `p_AnbieterTyp_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Bezeichnung` varchar(200) COLLATE utf8_bin NOT NULL DEFAULT '0',
  PRIMARY KEY (`p_AnbieterTyp_Nr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Daten Export vom Benutzer nicht ausgewählt


-- Exportiere Struktur von Tabelle cusmasydb.anbieter_zuordnung
CREATE TABLE IF NOT EXISTS `anbieter_zuordnung` (
  `pf_HostAnbieter_Nr` bigint(20) NOT NULL,
  `pf_ClientAnbieter_Nr` bigint(20) NOT NULL,
  PRIMARY KEY (`pf_HostAnbieter_Nr`,`pf_ClientAnbieter_Nr`),
  KEY `f_ClientAnbieter_Nr` (`pf_ClientAnbieter_Nr`),
  CONSTRAINT `f_ClientAnbieter_Nr` FOREIGN KEY (`pf_ClientAnbieter_Nr`) REFERENCES `anbieter` (`p_Anbieter_Nr`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `f_HostAnbieter_Nr` FOREIGN KEY (`pf_HostAnbieter_Nr`) REFERENCES `anbieter` (`p_Anbieter_Nr`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Daten Export vom Benutzer nicht ausgewählt


-- Exportiere Struktur von Tabelle cusmasydb.ort
CREATE TABLE IF NOT EXISTS `ort` (
  `p_Ort_Nr` bigint(20) NOT NULL AUTO_INCREMENT,
  `PLZ` int(11) NOT NULL DEFAULT '0',
  `Ort` varchar(200) COLLATE utf8_bin NOT NULL DEFAULT '0',
  PRIMARY KEY (`p_Ort_Nr`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Daten Export vom Benutzer nicht ausgewählt


-- Exportiere Struktur von Prozedur cusmasydb.sp_Delete_Anbieter
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Delete_Anbieter`(IN `_p_Anbieter_Nr` INT)
BEGIN
DELETE FROM Anbieter WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Delete_AnbieterTyp
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Delete_AnbieterTyp`(IN `_p_AnbieterTyp_Nr` INT)
BEGIN
DELETE FROM AnbieterTyp WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Delete_Anbieter_Zuordnung
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Delete_Anbieter_Zuordnung`(IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
DELETE FROM Anbieter_Zuordnung WHERE pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr AND pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Delete_Ort
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Delete_Ort`(IN `_p_Ort_Nr` BIGINT)
BEGIN
DELETE FROM Ort WHERE p_Ort_Nr = _p_Ort_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Insert_Anbieter
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Insert_Anbieter`(IN `_steuernumer` VARCHAR(200), IN `_f_AnbieterTyp_Nr` INT, IN `_firma` VARCHAR(200), IN `_strasse` VARCHAR(200), IN `_hausnummer` VARCHAR(50), IN `_f_Ort_Nr` BIGINT, IN `_land` VARCHAR(200), IN `_mailadresse` VARCHAR(200), IN `_telefonnummer` VARCHAR(200), IN `_homepage` VARCHAR(200), IN `_branche` VARCHAR(200))
BEGIN
INSERT INTO Anbieter VALUES('',_steuernumer, _f_AnbieterTyp_Nr, _firma,	_strasse, _hausnummer, _f_Ort_Nr, _land, _mailadresse, _telefonnummer, _homepage,_branche);
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Insert_AnbieterTyp
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Insert_AnbieterTyp`(IN `_bezeichnung` VARCHAR(200))
BEGIN
INSERT INTO AnbieterTyp VALUES ('', _bezeichnung);
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Insert_Anbieter_Zuordnung
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Insert_Anbieter_Zuordnung`(IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
INSERT INTO Anbieter_Zuordnung VALUES(_pf_HostAnbieter_Nr, _pf_ClientAnbieter_Nr);
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Insert_Ort
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Insert_Ort`(IN `_plz` INT, IN `_ort` VARCHAR(200))
BEGIN
INSERT INTO Ort VALUES ('', _plz, _ort);
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_SelectAll_Anbieter
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectAll_Anbieter`()
BEGIN
SELECT * FROM Anbieter;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_SelectAll_AnbieterTyp
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectAll_AnbieterTyp`()
BEGIN
SELECT * FROM AnbieterTyp;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_SelectAll_Anbieter_Zuordnung
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectAll_Anbieter_Zuordnung`()
BEGIN
SELECT * FROM Anbieter_Zuordnung ;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_SelectAll_Ort
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectAll_Ort`()
BEGIN
SELECT * FROM Ort;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Select_Anbieter
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Select_Anbieter`(IN `_p_Anbieter_Nr` BIGINT)
BEGIN
SELECT * FROM Anbieter WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Select_AnbieterTyp
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Select_AnbieterTyp`(IN `_p_AnbieterTyp_Nr` INT)
BEGIN
SELECT * FROM AnbieterTyp WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Select_Anbieter_Zuordnung
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Select_Anbieter_Zuordnung`(IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
SELECT * FROM Anbieter_Zuordnung WHERE pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr AND pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Select_Ort
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Select_Ort`(IN `_p_Ort_Nr` BIGINT)
BEGIN
SELECT * FROM Ort WHERE p_Ort_Nr = _p_Ort_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Update_Anbieter
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Update_Anbieter`(IN `_p_Anbieter_Nr` BIGINT, IN `_steuernumer` VARCHAR(200), IN `_f_AnbieterTyp_Nr` INT, IN `_firma` VARCHAR(200), IN `_strasse` VARCHAR(200), IN `_hausnummer` VARCHAR(50), IN `_f_Ort_Nr` BIGINT, IN `_land` VARCHAR(200), IN `_mailadresse` VARCHAR(200), IN `_telefonnummer` VARCHAR(200), IN `_homepage` VARCHAR(200), IN `_branche` VARCHAR(200))
BEGIN
UPDATE Anbieter SET steuernummer = _steuernumer, f_AbieterTyp_Nr = _f_AnbieterTyp_Nr, Firma = _firma, Strasse = _strasse, Hausnummer = _hausnummer, f_Ort_Nr = _f_Ort_Nr, Land = _land, Mailadresse = _mailadresse, Telefonnummer = _telefonnummer, Homepage = _homepage, Branche = _branche WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Update_AnbieterTyp
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Update_AnbieterTyp`(IN `_p_AnbieterTyp_Nr` INT, IN `_bezeichnung` VARCHAR(200))
BEGIN
UPDATE AnbieterTyp SET Bezeichnung = _bezeichnung WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Update_Anbieter_Zuordnung
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Update_Anbieter_Zuordnung`(IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
UPDATE Anbieter_Zuordnung SET pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr, pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END//
DELIMITER ;


-- Exportiere Struktur von Prozedur cusmasydb.sp_Update_Ort
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Update_Ort`(IN `_p_Ort_Nr` BIGINT, IN `_plz` INT, IN `_ort` VARCHAR(200))
BEGIN
UPDATE Ort SET PLZ = _plz, Ort = _ort WHERE p_Ort_Nr = _p_Ort_Nr;
END//
DELIMITER ;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
