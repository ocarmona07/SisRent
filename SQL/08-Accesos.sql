USE SisRent;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 1)
BEGIN
    INSERT INTO dbo.Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (1, NULL, 'Inicio', 'Inicio', 'th', N'/Mantencion/Inicio');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = NULL, Acceso = 'Inicio', Descripcion = 'Inicio', Icono = 'th', UrlAcceso = N'/Mantencion/Inicio'
    WHERE IdAcceso = 1;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 2)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (2, NULL, 'Reservas', 'Reservas', 'circle-o text-red', N'#');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = NULL, Acceso = 'Reservas', Descripcion = 'Reservas', Icono = 'circle-o text-red', UrlAcceso = N'#'
    WHERE IdAcceso = 2;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 3)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (3, 2, 'Lista de reservas', 'Listado de las reservas realizadas', 'tags', N'/Mantencion/Reservas');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 2, Acceso = 'Lista de reservas', Descripcion = 'Listado de las reservas realizadas', Icono = 'tags', UrlAcceso = N'/Mantencion/Reservas'
    WHERE IdAcceso = 3;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 4)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (4, 2, 'Crear reserva', 'Crear/Editar reserva', 'tag', N'/Mantencion/Reservas/CrearReserva');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 2, Acceso = 'Crear reserva', Descripcion = 'Crear/Editar reserva', Icono = 'tag', UrlAcceso = N'/Mantencion/Reservas/CrearReserva'
    WHERE IdAcceso = 4;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 5)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (5, NULL, 'Vehículos', 'Vehículos', 'circle-o text-aqua', N'#');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = NULL, Acceso = 'Vehículos', Descripcion = 'Vehículos', Icono = 'circle-o text-aqua', UrlAcceso = N'#'
    WHERE IdAcceso = 5;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 6)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (6, 5, 'Lista de vehículos', 'Listado de vehículos', 'car', N'/Mantencion/Vehiculos');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 5, Acceso = 'Lista de vehículos', Descripcion = 'Listado de vehículos', Icono = 'car', UrlAcceso = N'/Mantencion/Vehiculos'
    WHERE IdAcceso = 6;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 7)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (7, 5, 'Agregar vehículo', 'Agregar/Editar vehículo', 'ambulance', N'/Mantencion/Vehiculos/AgregarVehiculo');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 5, Acceso = 'Agregar vehículo', Descripcion = 'Agregar/Editar vehículo', Icono = 'ambulance', UrlAcceso = N'/Mantencion/Vehiculos/AgregarVehiculo'
    WHERE IdAcceso = 7;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 8)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (8, NULL, 'Servicios', 'Servicios', 'circle-o text-green', N'#');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = NULL, Acceso = 'Servicios', Descripcion = 'Servicios', Icono = 'circle-o text-green', UrlAcceso = N'#'
    WHERE IdAcceso = 8;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 9)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (9, 8, 'Lista de servicios', 'Listado de servicios', 'shopping-cart', N'/Mantencion/Servicios');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 8, Acceso = 'Lista de servicios', Descripcion = 'Listado de servicios', Icono = 'shopping-cart', UrlAcceso = N'/Mantencion/Servicios'
    WHERE IdAcceso = 9;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 10)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (10, 8, 'Agregar servicio', 'Agregar/Editar servicio', 'cart-plus', N'/Mantencion/Servicios/AgregarServicio');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 8, Acceso = 'Agregar servicio', Descripcion = 'Agregar/Editar servicio', Icono = 'cart-plus', UrlAcceso = N'/Mantencion/Servicios/AgregarServicio'
    WHERE IdAcceso = 10;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 11)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (11, NULL, 'Usuarios', 'Usuarios', 'circle-o text-yellow', N'#');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = NULL, Acceso = 'Usuarios', Descripcion = 'Usuarios', Icono = 'circle-o text-yellow', UrlAcceso = N'#'
    WHERE IdAcceso = 11;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 12)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (12, 11, 'Lista de usuarios', 'Listado de usuarios', 'users', N'/Mantencion/Usuarios');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 11, Acceso = 'Lista de usuarios', Descripcion = 'Listado de usuarios', Icono = 'users', UrlAcceso = N'/Mantencion/Usuarios'
    WHERE IdAcceso = 12;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Accesos WHERE IdAcceso = 13)
BEGIN
    INSERT INTO Accesos (IdAcceso, IdAccesoPadre, Acceso, Descripcion, Icono, UrlAcceso)
    VALUES (13, 11, 'Agregar usuario', 'Agregar/Editar usuario', 'user', N'/Mantencion/Usuarios/AgregarUsuario');
END;
ELSE
BEGIN
    UPDATE dbo.Accesos
    SET IdAccesoPadre = 11, Acceso = 'Agregar usuario', Descripcion = 'Agregar/Editar usuario', Icono = 'user', UrlAcceso = N'/Mantencion/Usuarios/AgregarUsuario'
    WHERE IdAcceso = 13;
END;
GO
