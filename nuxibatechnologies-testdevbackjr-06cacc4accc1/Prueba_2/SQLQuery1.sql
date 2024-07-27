create database Nuxiba;
USE Nuxiba;

CREATE TABLE usuarios (
    userId INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Paterno VARCHAR(100),
    Materno VARCHAR(100)
);

ALTER TABLE usuarios
ADD login VARCHAR(100);


CREATE TABLE empleados (
    userId INT REFERENCES usuarios(userId), 
    Sueldo decimal(7,2),
    FechaIngreso DATE,
);

/*--------------------------------------------------------------------------------------------------------------------------------*/
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user01', 'BERE', 'NARANJO', 'GONZALEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user02', 'ALEXIS', 'CAMPOS', 'NARANJO')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user03', 'SERGIO ALEJANDRO', 'CAMPOS', 'HERNANDEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user04', 'DIEGO ISMAEL', 'BERUMEN', 'CEDILLO')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user05', 'AURORA', 'ESCALANTE', 'PALAFOX')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user06', 'JOYCELENE FABIOLA', 'ESTRADA', 'BARBA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user07', 'FRANCISCO', 'ESTRADA', 'GOMEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user08', 'LEONARDO DANIEL', 'FARIAS', 'ROSAS')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user09', 'RAMON ANDRES', 'FIERROS', 'ROBLES')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user10', 'EDGAR ANDRES', 'FLORES', 'OLIVARES')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user11', 'MARIA FERNANDA', 'FRANCO', 'ESQUIVEL')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user12', 'ALEJANDRO', 'GALVAN', 'MUÑIZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user13', 'MARTHA ALICIA', 'GUTIERREZ', 'ORTIZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user14', 'JOSAFAT GERARDO', 'HERNANDEZ', 'SAUCEDO')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user15', 'ROSALIA', 'JIMENEZ', 'GONZALEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user16', 'LAURA CELENE', 'JIMENEZ', 'RIOS')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user17', 'ANGELICA', 'LOPEZ', 'CORTES')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user18', 'CRISTIAN IVAN', 'LOPEZ', 'GOMEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user19', 'MARLENE GABRIELA', 'LOPEZ', 'MEZA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user20', 'ALEJANDRA', 'MEDINA', 'IBARRA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user21', 'CONSUELO YURIDIANA THALIA', 'MEJIA', 'ALVAREZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user22', 'JAVIER ADRIAN', 'MEJIA', 'ALVAREZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user23', 'JUAN CARLOS EVARISTO', 'PEÑA', 'GUTIERREZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user24', 'JAZMIN ALEJANDRA', 'PEREZ', 'VELEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user25', 'GUSTAVO', 'RAMIREZ', 'RIVERA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user26', 'CARLOS NIVARDO', 'RODRIGUEZ', 'ASCENCIO')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user27', 'KARLA JOHANA', 'ROMERO', 'LUEVANOS')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user28', 'YESSICA YOSELINNE', 'RUIZ', 'HERNANDEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user29', 'CHRISTIAN EDUARDO', 'SALAS', 'SANCHEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user30', 'LUIS ROBERTO', 'SALDAÑA', 'ESPINOZA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user31', 'ADRIAN', 'SANCHEZ', 'ORTIZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user32', 'EDUARDO YAIR', 'SUAREZ', 'HERNANDEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user33', 'JUAN FRANCISCO', 'TABAREZ', 'GARCIA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user34', 'ZULEICA ELIZABETH', 'TERAN', 'TORRES')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user35', 'ADRIANA YUNUHEN', 'VARGAS', 'AYALA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user36', 'OSCAR URIEL', 'VELAZQUEZ', 'ALVAREZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user37', 'ERICK DE JESUS', 'CORONA', 'DIAZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user38', 'MARIA GUADALUPE', 'RAMOS', 'HERNANDEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user39', 'JESSICA NOEMI', 'JIMENEZ', 'VENTURA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user40', 'FLOR MARGARITA', 'ROJAS', 'HERNANDEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user41', 'LUIS ANTONIO', 'ALVARADO', 'VALENCIA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user42', 'EDGAR IVAN', 'AGUILAR', 'PADILLA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user43', 'LUIS ALFONSO', 'MICHEL', 'SANCHEZ')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user44', 'JOSE CARLOS', 'SILVA', 'ROCHA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user45', 'JUDITH', 'RODRIGUEZ', 'REYES')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user46', 'BRENDA SORAYA', 'CHAVEZ', 'GARCIA')
INSERT INTO usuarios (login, Nombre, Paterno, Materno) VALUES ('user47', 'ALMA ROSA', 'MARQUEZ', 'AGUILA')
/*--------------------------------------------------------------------------------------------------------------------------------*/


/*--------------------------------------------------------------------------------------------------------------------------------*/
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8837', '20000111')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8837', '20000111')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15000', '20000111')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15000', '20000111')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7812', '20000118')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7812', '20000118')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('10200', '20000118')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('10200', '20000118')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('13800', '20010520')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('13800', '20010520')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('18880', '20010520')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('18880', '20010520')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8000', '20010713')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8000', '20010713')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('6000', '20010713')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('19470', '20010713')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('19470', '20010713')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('10200', '20010716')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('10200', '20010716')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('25000', '20010716')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7812', '20010716')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7812', '20010716')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('12210', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('12210', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7500', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15020', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15020', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('25000', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('7812', '20011124')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15020', '20011212')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15020', '20011212')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('12210', '20011212')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('12210', '20011212')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('19470', '20080817')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('19470', '20080817')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8000', '20080817')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8000', '20080817')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('18880', '20090611')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('18880', '20090611')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('14000', '20090611')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('13800', '20090611')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('13800', '20090611')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15000', '20091006')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('15000', '20091006')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('13000', '20091006')
INSERT INTO empleados (Sueldo, FechaIngreso) VALUES ('8837', '20091006')

/*--------------------------------------------------------------------------------------------------------------------------------
Depurar solo los ID diferentes de 6,7,9 y 10 de la tabla usuarios (5 puntos)
Actualizar el dato Sueldo en un 10 porciento a los empleados que tienen fechas entre el año
2000 y 2001 (5 puntos)
README.md 27/4/2022
2 / 2
Realiza una consulta para traer el nombre de usuario y fecha de ingreso de los usuarios que
gananen mas de 10000 y su apellido comience con T ordernado del mas reciente al mas antiguo
(10 puntos)
Realiza una consulta donde agrupes a los empleados por sueldo, un grupo con los que ganan
menos de 1200 y uno mayor o igual a 1200, cuantos hay en cada grupo? (10 puntos)
------------------------------------------------------------------------------------------------------------------------------------*/
DELETE FROM usuarios WHERE userId IN (6, 7, 9, 10);
/*--------------------------------------------------------------------------------------------------------------------------------*/
update empleados
set Sueldo = Sueldo * 1.10
WHERE YEAR(FechaIngreso) BETWEEN 2000 AND 2001;
/*--------------------------------------------------------------------------------------------------------------------------------*/
SELECT u.Nombre, e.FechaIngreso
FROM usuarios u
JOIN empleados e ON u.userId = e.userId
WHERE e.Sueldo > 10000 AND u.Paterno LIKE 'T%'
ORDER BY e.FechaIngreso DESC;
/*--------------------------------------------------------------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------------------------------------------------------------*/
SELECT 
    CASE 
        WHEN Sueldo < 1200 THEN 'Menos de 1200'
        ELSE '1200 o más'
    END AS RangoSueldo,
    COUNT(*) AS Cantidad
FROM empleados
GROUP BY CASE 
           WHEN Sueldo < 1200 THEN 'Menos de 1200'
           ELSE '1200 o más'
         END;
/*--------------------------------------------------------------------------------------------------------------------------------*/

