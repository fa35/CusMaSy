

if not exists(select * from sys.databases where name = 'CusMaSyDb')
    create database CusMaSyDb
go

use[CusMaSyDb]
go


CREATE TABLE Ort (
	p_Ort_Nr BIGINT NOT NULL Primary key Identity(1,1),
	PLZ INT NOT NULL,
	Ort VARCHAR(200) NOT NULL,
	Land VARCHAR(200) NOT NULL
);

CREATE TABLE AnbieterTyp (
	p_AnbieterTyp_Nr INT NOT NULL Primary key Identity(1,1),
	Bezeichnung VARCHAR(200) NOT NULL 
);


CREATE TABLE Anbieter 
 (
   p_Anbieter_Nr bigint NOT NULL identity(1,1) primary key,
  Steuernummer varchar(200)  NOT NULL,
  f_AnbieterTyp_Nr int NOT NULL foreign key references AnbieterTyp (p_AnbieterTyp_Nr) on delete no action on update cascade,
  Firma varchar(200)  NOT NULL,
  Strasse varchar(200)  NOT NULL,
  Hausnummer varchar(50)  NOT NULL,
  f_Ort_Nr bigint NOT NULL foreign key references Ort (p_Ort_Nr) on delete no action on update cascade,
  Mailadresse varchar(200) NOT NULL,
  Telefonnummer varchar(200) DEFAULT NULL,
  Homepage varchar(200) NOT NULL,
  Branche varchar(200) DEFAULT NULL
) ;


CREATE TABLE Anbieter_Zuordnung(
	pf_HostAnbieter_Nr BIGINT NOT NULL,
	pf_ClientAnbieter_Nr BIGINT NOT NULL,
	PRIMARY KEY(pf_HostAnbieter_Nr, pf_ClientAnbieter_Nr)
);

go