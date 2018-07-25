USE SisRent
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE IdRol = 1)
BEGIN
    INSERT INTO dbo.Roles ( IdRol, Rol, Descripcion, Estado )
    VALUES (1, 'Administrador', 'Encargado de administrar todos los accesos y perfiles', 1);
END;
ELSE
BEGIN
    UPDATE dbo.Roles
    SET Rol = 'Administrador', Descripcion = 'Encargado de administrar todos los accesos y perfiles', Estado = 1
    WHERE IdRol = 1;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE IdRol = 2)
BEGIN
    INSERT INTO dbo.Roles ( IdRol, Rol, Descripcion, Estado )
    VALUES (2, 'Coordinador', 'Encargado de evaluar las solicitudes', 1);
END;
ELSE
BEGIN
    UPDATE dbo.Roles
    SET Rol = 'Coordinador', Descripcion = 'Encargado de evaluar las solicitudes', Estado = 1
    WHERE IdRol = 2;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE IdRol = 3)
BEGIN
    INSERT INTO dbo.Roles ( IdRol, Rol, Descripcion, Estado )
    VALUES (3, 'Usuario', 'Encargado de revisar los estados de las solicitudes', 1);
END;
ELSE
BEGIN
    UPDATE dbo.Roles
    SET Rol = 'Usuario', Descripcion = 'Encargado de revisar los estados de las solicitudes', Estado = 1
    WHERE IdRol = 3;
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Roles WHERE IdRol = 4)
BEGIN
    INSERT INTO dbo.Roles ( IdRol, Rol, Descripcion, Estado )
    VALUES (1, 'Cliente', 'Vista para las solicitudes realizadas', 0);
END;
ELSE
BEGIN
    UPDATE dbo.Roles
    SET Rol = 'Cliente', Descripcion = 'Vista para las solicitudes realizadas', Estado = 0
    WHERE IdRol = 4;
END;
GO
