USE SisRent
GO

INSERT  INTO Roles
        ( IdRol, Rol, Descripcion, Estado )
VALUES  ( 1, 'Administrador', 'Encargado de administrar todos los accesos y perfiles', 1 ),
        ( 2, 'Coordinador', 'Encargado de evaluar las solicitudes', 1 ),
        ( 3, 'Usuario', 'Encargado de revisar los estados de las solicitudes', 1 ),
        ( 4, 'Cliente', 'Vista para las solicitudes realizadas', 0 )
GO
