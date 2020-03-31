USE master;
DROP DATABASE  IF EXISTS consultorio;

CREATE DATABASE consultorio;

USE consultorio;

CREATE TABLE Paciente(
	id int identity (1,1) PRIMARY KEY,
	nombre varchar (40),
	domicilio varchar(20),
	sexo varchar (20),
	fechaNac date ,
	telefono varchar(20),
	email varchar(100),
	ocupacion varchar(40)
);

CREATE TABLE Material(
	id int identity (1,1) PRIMARY KEY,
	titulo varchar(255),
	material varchar(255),
	tipo varchar(15)
);
CREATE TABLE Cita(
	id int  PRIMARY KEY,
	idPaciente int ,
	fecha date ,
	horaInicio time,
	edo varchar(20),
);
CREATE TABLE Pago(
	id int  PRIMARY KEY,
	idCita int ,
	importe money,
	fecha datetime,
);

CREATE TABLE Historial(
	id int  PRIMARY KEY,
	idCita int,
	sesion int,
	actividad varchar(255),
	sugetivo varchar(255),
	objetivo varchar(255),
	analices varchar(255),
	plantacion varchar(255) ,
);
 
CREATE TABLE EnvioMaterial(
	id int PRIMARY KEY,
	idHistorial int ,
	idMaterial int
	);

   Select c.edo,p.nombre,p.ocupacion,p.sexo,p.domicilio,p.id From Cita As C Join Paciente As P  On C.idPaciente = P.id  where c.id=0 ;
    Select c.edo,p.nombre,p.ocupacion,p.sexo,p.domicilio,p.id From Cita As C Join Paciente As P  On C.idPaciente = P.id  where c.id=0;
	Select e.id,h.sesion, h.actividad , m.titulo, m.material from EnvioMaterial as E Join Historial as h on h.id= e.idHistorial Join Material as m on e.idMaterial=m.id
 