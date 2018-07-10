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
( 3, 2, 'Lista de reservas', 'Listado de las reservas realizadas', 'map', N'/Reservas/ListaReservas' ),
( 4, 2, 'Crear reserva', 'Crear/Editar reserva', 'map-marked', N'/Reservas/CrearReserva' ),
( 5, NULL, 'Vehículos', 'Vehículos', 'circle-o text-aqua', N'#' ),
( 6, 5, 'Lista de vehículos', 'Listado de vehículos', 'parking', N'/Vehiculos/ListaVehiculos' ),
( 7, 5, 'Agregar vehículo', 'Agregar/Editar vehículo', 'car', N'/Vehiculos/AgregarVehiculo' ),
( 8, NULL, 'Servicios', 'Servicios', 'circle-o text-green', N'#' ),
( 9, 8, 'Lista de servicios', 'Listado de servicios', 'shopping-cart', N'/Servicios/ListaServicios' ),
( 10, 8, 'Agregar servicio', 'Agregar/Editar servicio', 'cart-plus', N'/Servicios/AgregarServicio' )
*/
