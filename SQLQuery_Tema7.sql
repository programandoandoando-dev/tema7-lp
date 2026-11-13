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

--Creamos la tabla estudiante
create table estudiante
(
	idestudiante char(7)not null,
	nombres varchar(100)not null,
	apellidos varchar(100)not null,
	idcarrera smallint not null,
	telefono varchar(15)not null,
	email varchar(30)not null,
	fecha_ingreso date default getdate(),
	estado bit default 1,
	constraint pk_estudiante_idestudiante primary key(idestudiante),
	constraint fk_estudiante_idcarrera foreign key(idcarrera) references carrera(idcarrera)
)