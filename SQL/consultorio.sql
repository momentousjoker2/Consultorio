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
	select * from EnvioMaterial
	select * from Historial
	select * from Cita

	select m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where p.id=1
	select p.nombre,m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where  c.fecha   BETWEEN   '1/1/2020'   AND '3/31/2020' 
	select p.nombre,m.titulo,m.material, m.tipo from Material as m inner join EnvioMaterial as e on e.idMaterial = m.id inner join Historial as h on e.idHistorial = h.id inner join Cita as c on h.idCita = c.id inner join Paciente as p on c.idPaciente = p.id where h.id=1
