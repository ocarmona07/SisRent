use master
go

if not exists (select 1 from sys.databases where name = 'SisRent')
    create database SisRent
go

use SisRent
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Accesos') and o.name = 'FK_ACCESOS_REFERENCE_ACCESOS')
alter table Accesos
   drop constraint FK_ACCESOS_REFERENCE_ACCESOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ReservaServicio') and o.name = 'FK_RESERVAS_REFERENCE_RESERVAS')
alter table ReservaServicio
   drop constraint FK_RESERVAS_REFERENCE_RESERVAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ReservaServicio') and o.name = 'FK_RESERVAS_REFERENCE_SERVICIO')
alter table ReservaServicio
   drop constraint FK_RESERVAS_REFERENCE_SERVICIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_USUARIOS')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_USUARIOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_VEHICULO')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_VEHICULO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_COMUNAS_1')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_COMUNAS_1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_COMUNAS_2')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_COMUNAS_2
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_COMUNAS_3')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_COMUNAS_3
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reservas') and o.name = 'FK_RESERVAS_REFERENCE_ESTADOS')
alter table Reservas
   drop constraint FK_RESERVAS_REFERENCE_ESTADOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RolAcceso') and o.name = 'FK_ROLACCES_REFERENCE_ROLES')
alter table RolAcceso
   drop constraint FK_ROLACCES_REFERENCE_ROLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RolAcceso') and o.name = 'FK_ROLACCES_REFERENCE_ACCESOS')
alter table RolAcceso
   drop constraint FK_ROLACCES_REFERENCE_ACCESOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Usuarios') and o.name = 'FK_USUARIOS_REFERENCE_ROLES')
alter table Usuarios
   drop constraint FK_USUARIOS_REFERENCE_ROLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VehModelos') and o.name = 'FK_VEHMODEL_REFERENCE_VEHMARCA')
alter table VehModelos
   drop constraint FK_VEHMODEL_REFERENCE_VEHMARCA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Vehiculos') and o.name = 'FK_VEHICULO_REFERENCE_VEHMODEL')
alter table Vehiculos
   drop constraint FK_VEHICULO_REFERENCE_VEHMODEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Accesos')
            and   type = 'U')
   drop table Accesos
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Comunas')
            and   type = 'U')
   drop table Comunas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Estados')
            and   type = 'U')
   drop table Estados
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ReservaServicio')
            and   type = 'U')
   drop table ReservaServicio
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Reservas')
            and   type = 'U')
   drop table Reservas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RolAcceso')
            and   type = 'U')
   drop table RolAcceso
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Roles')
            and   type = 'U')
   drop table Roles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Servicios')
            and   type = 'U')
   drop table Servicios
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Usuarios')
            and   type = 'U')
   drop table Usuarios
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VehMarcas')
            and   type = 'U')
   drop table VehMarcas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VehModelos')
            and   type = 'U')
   drop table VehModelos
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Vehiculos')
            and   type = 'U')
   drop table Vehiculos
go

/*==============================================================*/
/* Table: Accesos                                               */
/*==============================================================*/
create table Accesos (
   IdAcceso             int                  not null,
   IdAccesoPadre        int                  null,
   Acceso               nvarchar(32)         not null,
   Descripcion          nvarchar(64)         null,
   Icono                nvarchar(24)         null,
   UrlAcceso            nvarchar(128)        not null,
   constraint PK_ACCESOS primary key (IdAcceso)
)
go

/*==============================================================*/
/* Table: Comunas                                               */
/*==============================================================*/
create table Comunas (
   IdComuna             int                  not null,
   Comuna               nvarchar(64)         not null,
   Estado               bit                  not null,
   constraint PK_COMUNAS primary key (IdComuna)
)
go

/*==============================================================*/
/* Table: Estados                                               */
/*==============================================================*/
create table Estados (
   IdEstado             int                  not null,
   Estado               nvarchar(32)         not null,
   constraint PK_ESTADOS primary key (IdEstado)
)
go

/*==============================================================*/
/* Table: ReservaServicio                                       */
/*==============================================================*/
create table ReservaServicio (
   IdReservaServicio    int                  identity,
   IdReserva            int                  not null,
   IdServicio           int                  not null,
   ValorServicio        decimal              not null,
   constraint PK_RESERVASERVICIO primary key (IdReservaServicio)
)
go

/*==============================================================*/
/* Table: Reservas                                              */
/*==============================================================*/
create table Reservas (
   IdReserva            int                  identity,
   IdComunaRetiro       int                  not null,
   FechaRetiro          datetime             not null,
   IdComunaEntrega      int                  null,
   FechaEntrega         datetime             null,
   IdVehiculo           int                  not null,
   Nombres              nvarchar(32)         not null,
   Apellidos            nvarchar(32)         not null,
   Email                nvarchar(64)         not null,
   Direccion            nvarchar(128)        not null,
   IdComuna             int                  null,
   Telefono             nvarchar(10)         not null,
   IdEstado             int                  not null,
   ValorFinal           decimal              not null,
   IdUsuario            int                  not null,
   Observaciones        nvarchar(Max)        null,
   constraint PK_RESERVAS primary key (IdReserva)
)
go

/*==============================================================*/
/* Table: RolAcceso                                             */
/*==============================================================*/
create table RolAcceso (
   IdRolAcceso          int                  identity,
   IdRol                int                  null,
   IdAcceso             int                  null,
   constraint PK_ROLACCESO primary key (IdRolAcceso)
)
go

/*==============================================================*/
/* Table: Roles                                                 */
/*==============================================================*/
create table Roles (
   IdRol                int                  not null,
   Rol                  nvarchar(24)         not null,
   Descripcion          nvarchar(64)         null,
   Estado               bit                  not null,
   constraint PK_ROLES primary key (IdRol)
)
go

/*==============================================================*/
/* Table: Servicios                                             */
/*==============================================================*/
create table Servicios (
   IdServicio           int                  identity,
   Servicio             nvarchar(32)         not null,
   Descripcion          nvarchar(64)         null,
   Valor                decimal              not null,
   Estado               bit                  not null,
   constraint PK_SERVICIOS primary key (IdServicio)
)
go

/*==============================================================*/
/* Table: Usuarios                                              */
/*==============================================================*/
create table Usuarios (
   IdUsuario            int                  identity,
   Rut                  nvarchar(12)         not null,
   Nombres              nvarchar(32)         not null,
   ApPaterno            nvarchar(32)         not null,
   ApMaterno            nvarchar(32)         null,
   Telefono             nvarchar(10)         null,
   Email                nvarchar(64)         null,
   RutaImagen           nvarchar(256)        null,
   IdRol                int                  not null,
   Clave                nvarchar(16)         not null,
   Estado               bit                  not null,
   constraint PK_USUARIOS primary key (IdUsuario)
)
go

/*==============================================================*/
/* Table: VehMarcas                                             */
/*==============================================================*/
create table VehMarcas (
   IdMarca              int                  not null,
   Marca                nvarchar(32)         not null,
   constraint PK_VEHMARCAS primary key (IdMarca)
)
go

/*==============================================================*/
/* Table: VehModelos                                            */
/*==============================================================*/
create table VehModelos (
   IdModelo             int                  not null,
   IdMarca              int                  null,
   Modelo               nvarchar(32)         not null,
   constraint PK_VEHMODELOS primary key (IdModelo)
)
go

/*==============================================================*/
/* Table: Vehiculos                                             */
/*==============================================================*/
create table Vehiculos (
   IdVehiculo           int                  identity,
   IdModelo             int                  null,
   Anio                 int                  not null,
   Patente              nvarchar(7)          not null,
   RutaImagen           nvarchar(256)        null,
   Detalles             nvarchar(Max)        not null,
   Valor                decimal              not null,
   Estado               bit                  not null,
   constraint PK_VEHICULOS primary key (IdVehiculo)
)
go

alter table Accesos
   add constraint FK_ACCESOS_REFERENCE_ACCESOS foreign key (IdAccesoPadre)
      references Accesos (IdAcceso)
go

alter table ReservaServicio
   add constraint FK_RESERVAS_REFERENCE_RESERVAS foreign key (IdReserva)
      references Reservas (IdReserva)
go

alter table ReservaServicio
   add constraint FK_RESERVAS_REFERENCE_SERVICIO foreign key (IdServicio)
      references Servicios (IdServicio)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_USUARIOS foreign key (IdUsuario)
      references Usuarios (IdUsuario)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_VEHICULO foreign key (IdVehiculo)
      references Vehiculos (IdVehiculo)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_COMUNAS_1 foreign key (IdComunaRetiro)
      references Comunas (IdComuna)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_COMUNAS_2 foreign key (IdComunaEntrega)
      references Comunas (IdComuna)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_COMUNAS_3 foreign key (IdComuna)
      references Comunas (IdComuna)
go

alter table Reservas
   add constraint FK_RESERVAS_REFERENCE_ESTADOS foreign key (IdEstado)
      references Estados (IdEstado)
go

alter table RolAcceso
   add constraint FK_ROLACCES_REFERENCE_ROLES foreign key (IdRol)
      references Roles (IdRol)
go

alter table RolAcceso
   add constraint FK_ROLACCES_REFERENCE_ACCESOS foreign key (IdAcceso)
      references Accesos (IdAcceso)
go

alter table Usuarios
   add constraint FK_USUARIOS_REFERENCE_ROLES foreign key (IdRol)
      references Roles (IdRol)
go

alter table VehModelos
   add constraint FK_VEHMODEL_REFERENCE_VEHMARCA foreign key (IdMarca)
      references VehMarcas (IdMarca)
go

alter table Vehiculos
   add constraint FK_VEHICULO_REFERENCE_VEHMODEL foreign key (IdModelo)
      references VehModelos (IdModelo)
go
