USE SisRent
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE Rut = '159888207')
BEGIN
    INSERT INTO dbo.Usuarios ( Rut, Nombres, ApPaterno, ApMaterno, Telefono, Email, RutaImagen, IdRol, Clave, Estado )
    VALUES ('159888207', 'Omar', 'Carmona', 'Rivas', '987654321', N'ocarmona@gmail.com', N'/Images/Users/User.jpg', 1, N'MTIzNDU2', 1);
END;
ELSE
BEGIN
    UPDATE dbo.Usuarios
    SET Nombres = 'Omar', ApPaterno = 'Carmona', ApMaterno = 'Rivas', Telefono = '987654321', Email = N'ocarmona@gmail.com',
        RutaImagen = N'/Images/Users/User.jpg', Clave = N'MTIzNDU2', Estado = 1
    WHERE Rut = '159888207';
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Vehiculos WHERE Patente = 'ABCD12')
BEGIN
    INSERT INTO dbo.Vehiculos ( IdModelo, Anio, Valor, Patente, RutaImagen, Detalles, Estado )
    VALUES ( 138, 2010, 22000, 'ABCD12', N'/Images/Autos/Aveo_2010_ABCD12.png', N'5 Puertas, Frenos ABS, Cierre centralizado', 1 );
END;
ELSE
BEGIN
    UPDATE dbo.Vehiculos
    SET IdModelo = 138, Anio = 2010, Valor = 22000, RutaImagen = N'/Images/Autos/Aveo_2010_ABCD12.png',
        Detalles = N'5 Puertas, Frenos ABS, Cierre centralizado', Estado = 1
    WHERE Patente = 'ABCD12';
END;
GO
