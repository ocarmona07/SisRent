USE SisRent
GO

INSERT  INTO Accesos
        ( IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso )
VALUES  ( 1, NULL, 'Inicio', 'Inicio', 'th', N'/Mantencion/Inicio' ),
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
GO
