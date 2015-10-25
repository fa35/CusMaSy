CREATE DATABASE IF NOT EXISTS `CusMaSyDB` /*!40100 COLLATE 'utf8_bin' */;

USE `cusmasydb`;
CREATE TABLE IF NOT EXISTS `Ort` (
	`p_Ort_Nr` BIGINT NOT NULL AUTO_INCREMENT,
	`PLZ` INT NOT NULL DEFAULT '0',
	`Ort` VARCHAR(200) NOT NULL DEFAULT '0',
	`Land` VARCHAR(200) NOT NULL,
	PRIMARY KEY (`p_Ort_Nr`)
);

CREATE TABLE IF NOT EXISTS `AnbieterTyp` (
	`p_AnbieterTyp_Nr` INT NOT NULL AUTO_INCREMENT,
	`Bezeichnung` VARCHAR(200) NOT NULL DEFAULT '0',
	PRIMARY KEY (`p_AnbieterTyp_Nr`)
);

CREATE TABLE IF NOT EXISTS `Anbieter` (
	`p_Anbieter_Nr` BIGINT NOT NULL AUTO_INCREMENT,
	`Steuernummer` VARCHAR(200) NOT NULL,
	`f_AnbieterTyp_Nr` INT NOT NULL,
	`Firma` VARCHAR(200) NOT NULL,
	`Strasse` VARCHAR(200) NOT NULL,
	`Hausnummer` VARCHAR(50) NOT NULL,
	`f_Ort_Nr` BIGINT NOT NULL,
	`Mailadresse` VARCHAR(200) NOT NULL,
	`Telefonnummer` VARCHAR(200) NULL,
	`Homepage` VARCHAR(200) NOT NULL,
	`Branche` VARCHAR(200) NULL,
	PRIMARY KEY (`p_Anbieter_Nr`),
	CONSTRAINT `f_AnbieterTyp_Nr` FOREIGN KEY (`f_AnbieterTyp_Nr`) REFERENCES `anbietertyp` (`p_AnbieterTyp_Nr`) ON UPDATE CASCADE ON DELETE NO ACTION,
	CONSTRAINT `f_Ort_Nr` FOREIGN KEY (`f_Ort_Nr`) REFERENCES `ort` (`p_Ort_Nr`) ON UPDATE CASCADE ON DELETE NO ACTION
);

CREATE TABLE IF NOT EXISTS `Anbieter_Zuordnung`(
	`pf_HostAnbieter_Nr` BIGINT NOT NULL,
	`pf_ClientAnbieter_Nr` BIGINT NOT NULL,
	PRIMARY KEY(pf_HostAnbieter_Nr, pf_ClientAnbieter_Nr),
	CONSTRAINT `f_HostAnbieter_Nr` FOREIGN KEY (`pf_HostAnbieter_Nr`) REFERENCES `Anbieter` (`p_Anbieter_Nr`) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT `f_ClientAnbieter_Nr` FOREIGN KEY (`pf_ClientAnbieter_Nr`) REFERENCES `Anbieter` (`p_Anbieter_Nr`) ON UPDATE CASCADE ON DELETE CASCADE
);
