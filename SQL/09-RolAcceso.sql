USE SisRent
GO

INSERT  INTO RolAcceso
        ( IdRol, IdAcceso )
VALUES  ( 1, 1 ),
        ( 1, 2 ),
        ( 1, 3 ),
        ( 1, 4 ),
        ( 1, 5 ),
        ( 1, 6 ),
        ( 1, 7 ),
        ( 1, 8 ),
        ( 1, 9 ),
        ( 1, 10 ),
        ( 1, 11 ),
        ( 1, 12 ),
        ( 1, 13 ),
        ( 2, 1 ),
        ( 2, 2 ),
        ( 2, 3 ),
        ( 2, 5 ),
        ( 2, 6 ),
        ( 2, 8 ),
        ( 2, 9 )
GO

/* Roles
( 1, 'Administrador', 'Encargado de administrar todos los accesos y perfiles', 1 ),
( 2, 'Coordinador', 'Encargado de evaluar las solicitudes', 1 ),
( 3, 'Usuario', 'Encargado de revisar los estados de las solicitudes', 1 ),
( 4, 'Cliente', 'Vista para las solicitudes realizadas', 0 )

** Accesos
( 1, NULL, 'Inicio', 'Inicio', 'th', N'/Mantencion/Inicio' ),
( 2, NULL, 'Reservas', 'Reservas', 'circle-o text-red', N'#' ),
( 3, 2, 'Lista de reservas', 'Listado de las reservas realizadas', 'map', N'/Mantencion/Reservas' ),
( 4, 2, 'Crear reserva', 'Crear/Editar reserva', 'map-marker', N'/Mantencion/Reservas/CrearReserva' ),
( 5, NULL, 'Vehículos', 'Vehículos', 'circle-o text-aqua', N'#' ),
( 6, 5, 'Lista de vehículos', 'Listado de vehículos', 'car', N'/Mantencion/Vehiculos' ),
( 7, 5, 'Agregar vehículo', 'Agregar/Editar vehículo', 'ambulance', N'/Mantencion/Vehiculos/AgregarVehiculo' ),
( 8, NULL, 'Servicios', 'Servicios', 'circle-o text-green', N'#' ),
( 9, 8, 'Lista de servicios', 'Listado de servicios', 'shopping-cart', N'/Mantencion/Servicios' ),
( 10, 8, 'Agregar servicio', 'Agregar/Editar servicio', 'cart-plus', N'/Mantencion/Servicios/AgregarServicio' ),
( 11, NULL, 'Usuarios', 'Usuarios', 'circle-o text-yellow', N'#' ),
( 12, 11, 'Lista de usuarios', 'Listado de usuarios', 'users', N'/Mantencion/Usuarios' ),
( 13, 11, 'Agregar usuario', 'Agregar/Editar usuario', 'user', N'/Mantencion/Usuarios/AgregarUsuario' )
*/
