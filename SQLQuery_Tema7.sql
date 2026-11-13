--Creamos por defecto una Base de Datos
create database bdTema7
go

--Activamos la Base de Datos
use bdTema7
go

--Crear la tabla carrera
create table carrera
(
	idcarrera smallint identity(1,1) not null,
	carrera varchar(40)not null,
	descripcion varchar(150),
	estado bit default 1,
	constraint pk_carrera_idcarrera primary key(idcarrera),
	constraint u_carrera_carrera unique(carrera)
)