USE SisRent
GO

INSERT  INTO Accesos
        ( IdAcceso, Acceso, Descripcion, Icono, UrlAcceso )
VALUES  ( 1, 'Lista de reservas', 'Listado de las reservas realizadas', 'map', '/Reservas/ListaReservas' ),
        ( 2, 'Crear reserva', 'Crear/Editar reserva', 'map-marked', '/Reservas/CrearReserva' ),
        ( 3, 'Lista de vehÝculos', 'Listado de vehÝculos', 'parking', '/Vehiculos/ListaVehiculos' ),
        ( 4, 'Agregar vehÝculo', 'Agregar/Editar vehÝculo', 'car', '/Vehiculos/AgregarVehiculo' ),
        ( 5, 'Lista de servicios', 'Listado de servicios', 'shopping-cart', '/Servicios/ListaServicios' ),
        ( 6, 'Agregar servicio', 'Agregar/Editar servicio', 'cart-plus', '/Servicios/AgregarServicio' )
GO
