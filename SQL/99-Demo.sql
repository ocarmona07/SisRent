USE SisRent
GO

INSERT  INTO Usuarios
        ( Rut, Nombres, ApPaterno, ApMaterno, Telefono, Email, RutaImagen, IdRol, Clave, Estado )
VALUES  ( '159888207', 'Omar', 'Carmona', 'Rivas', '987654321', 'ocarmona@gmail.com', '/Images/User.jpg', 1, 'MTIzNDU2', 1 )
GO

INSERT  INTO Vehiculos
        ( IdModelo, Anio, Valor, Patente, RutaImagen, Detalles, Estado )
VALUES  ( 138, 2010, 22000, 'ABCD12', '/Images/Aveo_2010_ABCD12.png', '5 Puertas, Frenos ABS, Cierre centralizado', 1 )
GO
