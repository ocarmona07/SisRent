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
        ( 2, 1 ),
        ( 2, 3 ),
        ( 2, 5 )
GO

/* Roles
( 1, 'Administrador', 'Encargado de administrar todos los accesos y perfiles', 1 ),
( 2, 'Coordinador', 'Encargado de evaluar las solicitudes', 1 ),
( 3, 'Usuario', 'Encargado de revisar los estados de las solicitudes', 1 ),
( 4, 'Cliente', 'Vista para las solicitudes realizadas', 0 )

** Accesos
( 1, 'Lista de reservas', 'Listado de las reservas realizadas', 'map', '/Reservas/ListaReservas' ),
( 2, 'Crear reserva', 'Crear/Editar reserva', 'map-marked', '/Reservas/CrearReserva' ),
( 3, 'Lista de vehículos', 'Listado de vehículos', 'parking', '/Vehiculos/ListaVehiculos' ),
( 4, 'Agregar vehículo', 'Agregar/Editar vehículo', 'car', '/Vehiculos/AgregarVehiculo' ),
( 5, 'Lista de servicios', 'Listado de servicios', 'shopping-cart', '/Servicios/ListaServicios' ),
( 6, 'Agregar servicio', 'Agregar/Editar servicio', 'cart-plus', '/Servicios/AgregarServicio' )
*/
