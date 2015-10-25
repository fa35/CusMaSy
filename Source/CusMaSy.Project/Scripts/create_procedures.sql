USE `cusmasydb`;

CREATE PROCEDURE `sp_SelectAll_Ort` ()
BEGIN
SELECT * FROM Ort;
END;	

CREATE PROCEDURE `sp_Select_Ort`(IN `_p_Ort_Nr` BIGINT)
BEGIN
SELECT * FROM Ort WHERE p_Ort_Nr = _p_Ort_Nr;
END;

CREATE PROCEDURE `sp_Insert_Ort`(IN `_plz` INT, IN `_ort` VARCHAR(200), IN `_land` VARCHAR(200))
BEGIN
INSERT INTO Ort VALUES ('', _plz, _ort, _land);
END;

CREATE PROCEDURE `sp_Update_Ort`(IN `_p_Ort_Nr` BIGINT IN `_plz` INT, IN `_ort` VARCHAR(200))
BEGIN
UPDATE Ort SET PLZ = _plz, Ort = _ort WHERE p_Ort_Nr = _p_Ort_Nr;
END;

CREATE PROCEDURE `sp_Delete_Ort`(IN `_p_Ort_Nr` BIGINT)
BEGIN
DELETE FROM Ort WHERE p_Ort_Nr = _p_Ort_Nr;
END;

CREATE PROCEDURE `sp_Select_AnbieterTyp` (IN `_p_AnbieterTyp_Nr` INT)
BEGIN
SELECT * FROM AnbieterTyp WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END;

CREATE PROCEDURE `sp_SelectAll_AnbieterTyp` ()
BEGIN
SELECT * FROM AnbieterTyp;
END;

CREATE PROCEDURE `sp_Insert_AnbieterTyp`(IN `_bezeichnung` VARCHAR(200))
BEGIN
INSERT INTO AnbieterTyp VALUES ('', _bezeichnung);
END;

CREATE PROCEDURE `sp_Select_Anbieter` (IN `_p_Anbieter_Nr` BIGINT)
BEGIN
SELECT * FROM Anbieter WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END;

CREATE PROCEDURE `sp_SelectAll_Anbieter` ()
BEGIN
SELECT * FROM Anbieter;
END;

CREATE PROCEDURE `sp_Update_AnbieterTyp`(IN `_p_AnbieterTyp_Nr` INT IN `_bezeichnung` VARCHAR(200))
BEGIN
UPDATE AnbieterTyp SET Bezeichnung = _bezeichnung WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END;

CREATE PROCEDURE `sp_Delete_AnbieterTyp`(IN `_p_AnbieterTyp_Nr` INT)
BEGIN
DELETE FROM AnbieterTyp WHERE p_AnbieterTyp_Nr = _p_AnbieterTyp_Nr;
END;

CREATE PROCEDURE `sp_Insert_Anbieter` (
		IN `_steuernumer` VARCHAR(200),
		IN `_f_AnbieterTyp_Nr` INT,	
		IN `_firma` VARCHAR(200),
		IN `_strasse` VARCHAR(200),
		IN `_hausnummer` VARCHAR(50),
		IN `_f_Ort_Nr BIGINT,
		IN `_land` VARCHAR(200),
		IN `_mailadresse` VARCHAR(200),
		IN `_telefonnummer` VARCHAR(200),
		IN `_homepage` VARCHAR(200),
		IN `_branche` VARCHAR(200)
	)
BEGIN
INSERT INTO Anbieter VALUES('',_steuernumer, _f_AnbieterTyp_Nr, _firma,							   _strasse, _hausnummer, _f_Ort_Nr, _land, 
							_mailadresse, _telefonnummer, _homepage,_branche);
END;

CREATE PROCEDURE `sp_Update_Anbieter`(
		IN `_p_Anbieter_Nr` BIGINT 
		IN `_steuernumer` VARCHAR(200),
		IN `_f_AnbieterTyp_Nr` INT,	
		IN `_firma` VARCHAR(200),
		IN `_strasse` VARCHAR(200),
		IN `_hausnummer` VARCHAR(50),
		IN `_f_Ort_Nr BIGINT,
		IN `_land` VARCHAR(200),
		IN `_mailadresse` VARCHAR(200),
		IN `_telefonnummer` VARCHAR(200),
		IN `_homepage` VARCHAR(200),
		IN `_branche` VARCHAR(200))
BEGIN
UPDATE Anbieter SET steuernummer = _steuernumer, f_AbieterTyp_Nr = _f_AnbieterTyp_Nr,
					Firma = _firma, Strasse = _strasse, Hausnummer = _hausnummer,
					f_Ort_Nr = _f_Ort_Nr, Land = _land, Mailadresse = _mailadresse,
					Telefonnummer = _telefonnummer, Homepage = _homepage, 
					Branche = _branche WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END;

CREATE PROCEDURE `sp_Delete_Anbieter` (IN `_p_Anbieter_Nr` INT)
BEGIN
DELETE FROM Anbieter WHERE p_Anbieter_Nr = _p_Anbieter_Nr;
END;

CREATE PROCEDURE `sp_SelectAll_Anbieter_Zuordnung` ()
BEGIN
SELECT * FROM Anbieter_Zuordnung ;
END;

CREATE PROCEDURE `sp_Select_Anbieter_Zuordnung` (IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
SELECT * FROM Anbieter_Zuordnung WHERE pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr` AND pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END;

CREATE PROCEDURE `sp_Insert_Anbieter_Zuordnung` (IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
INSERT INTO Anbieter_Zuordnung VALUES(_pf_HostAnbieter_Nr, _pf_ClientAnbieter_Nr);
END;

CREATE PROCEDURE `sp_Delete_Anbieter_Zuordnung` (IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
DELETE FROM Anbieter_Zuordnung WHERE pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr AND pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END;

CREATE PROCEDURE `sp_Update_Anbieter_Zuordnung` (IN `_pf_HostAnbieter_Nr` BIGINT, IN `_pf_ClientAnbieter_Nr` BIGINT)
BEGIN
UPDATE Anbieter_Zuordnung SET pf_HostAnbieter_Nr = _pf_HostAnbieter_Nr, pf_ClientAnbieter_Nr = _pf_ClientAnbieter_Nr;
END;
	