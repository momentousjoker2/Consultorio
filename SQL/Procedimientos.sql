CREATE  PROCEDURE  citasSemana (@FI	DATE,  @FF  DATE) AS
SELECT  p.nombre, c.fecha, c.horaInicio, c.edo 
FROM   Cita as c    JOIN  Paciente as p    ON p.id=c.idPaciente   
WHERE   c.fecha   BETWEEN   @FI   AND @FF 
GO

CREATE  PROCEDURE  citasPaciente (@ID INTEGER) AS
SELECT  p.nombre, c.fecha, c.horaInicio, c.edo 
FROM   Cita as c    JOIN  Paciente as p    ON p.id=c.idPaciente   
WHERE   p.id=@ID
GO


CREATE  PROCEDURE  citasEstado (@ID VARCHAR) AS
SELECT  p.nombre, c.fecha, c.horaInicio
FROM   Cita as c    JOIN  Paciente as p    ON p.id=c.idPaciente   
WHERE   c.edo=@ID
GO


CREATE  PROCEDURE  listadoMateriales  AS
SELECT  *
FROM   Material  
GO

CREATE  PROCEDURE  listadoPacientes  AS
SELECT  *
FROM   Material  
GO


CREATE  PROCEDURE  historiaPaciente (@ID INTEGER) AS
SELECT p.nombre, p.ocupacion,DATEDIFF(YEAR,GETDATE(), p.fechaNac)*-1 AS edad, p.sexo, h.* ,c.*
FROM   Cita as c   JOIN  Paciente as p  ON p.id=c.idPaciente   JOIN Historial as h ON c.id=h.idCita
WHERE   p.id=@ID
GO