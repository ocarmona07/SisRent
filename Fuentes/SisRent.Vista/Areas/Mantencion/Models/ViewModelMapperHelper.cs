namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Negocio.Admin;
    using Negocio.Common;
    using Vista.Models;

    public class ViewModelMapperHelper
    {
        #region Vehículos

        public List<VehiculoModel> ListaVehiculos()
        {
            var response = new List<VehiculoModel>();
            var lista = new VehiculosBo().ObtenerVehiculos();
            if (lista.EsValido)
            {
                response = lista.Vehiculos.Select(o => new VehiculoModel
                {
                    IdVehiculo = o.IdVehiculo,
                    IdMarca = o.VehModelos.IdMarca,
                    Marca = o.VehModelos.VehMarcas.Marca,
                    IdModelo = o.IdModelo,
                    Modelo = o.VehModelos.Modelo,
                    Anio = o.Anio,
                    Valor = o.Valor,
                    Patente = o.Patente,
                    RutaImagen = o.RutaImagen,
                    Detalles = o.Detalles,
                    Estado = o.Estado
                }).ToList();
            }

            return response;
        }

        public VehiculoModel ObtenerVehiculo(int idVehiculo)
        {
            var response = new VehiculoModel();
            var item = new VehiculosBo().ObtenerVehiculo(new VehiculosRequest
            {
                IdVehiculo = idVehiculo
            });
            if (item.EsValido)
            {
                response = new VehiculoModel
                {
                    IdVehiculo = item.Vehiculo.IdVehiculo,
                    IdMarca = item.Vehiculo.VehModelos.IdMarca,
                    IdModelo = item.Vehiculo.IdModelo,
                    Anio = item.Vehiculo.Anio,
                    Valor = item.Vehiculo.Valor,
                    Patente = item.Vehiculo.Patente,
                    RutaImagen = item.Vehiculo.RutaImagen,
                    Detalles = item.Vehiculo.Detalles,
                    Estado = item.Vehiculo.Estado
                };
            }

            return response;
        }

        public List<ComboModel> ListaMarcas()
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerMarcas();
            if (lista.EsValido)
            {
                response = lista.Marcas.Select(o => new ComboModel
                {
                    Text = o.Marca,
                    Value = o.IdMarca.ToString()
                }).ToList();
            }

            return response;
        }

        public List<ComboModel> ListaModelos(int idMarca)
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerModelos();
            if (lista.EsValido && idMarca > 0)
            {
                response = lista.Modelos.Where(o => o.IdMarca == idMarca)
                    .Select(o => new ComboModel
                    {
                        Text = o.Modelo,
                        Value = o.IdModelo.ToString()
                    }).ToList();
            }

            return response;
        }

        public Vehiculos CrearVehiculo(VehiculoModel model)
        {
            return new Vehiculos
            {
                IdVehiculo = model.IdVehiculo,
                IdModelo = model.IdModelo,
                Anio = model.Anio,
                Valor = model.Valor,
                Patente = model.Patente,
                RutaImagen = model.RutaImagen,
                Detalles = model.Detalles,
                Estado = model.Estado
            };
        }

        #endregion

        #region Servicios

        public List<ServicioModel> ListaServicios()
        {
            var response = new List<ServicioModel>();
            var lista = new ServiciosBo().ObtenerServicios();
            if (lista.EsValido)
            {
                response = lista.Servicios.Select(o => new ServicioModel
                {
                    IdServicio = o.IdServicio,
                    Servicio = o.Servicio,
                    Descripcion = o.Descripcion,
                    Valor = o.Valor,
                    Estado = o.Estado
                }).ToList();
            }

            return response;
        }

        public ServicioModel ObtenerServicio(int idServicio)
        {
            var response = new ServicioModel();
            var item = new ServiciosBo().ObtenerServicio(new ServiciosRequest
            {
                IdServicio = idServicio
            });
            if (item.EsValido)
            {
                response = new ServicioModel
                {
                    IdServicio = item.Servicio.IdServicio,
                    Servicio = item.Servicio.Servicio,
                    Descripcion = item.Servicio.Descripcion,
                    Valor = item.Servicio.Valor,
                    Estado = item.Servicio.Estado
                };
            }

            return response;
        }

        public Servicios CrearServicio(ServicioModel servicio)
        {
            return new Servicios
            {
                IdServicio = servicio.IdServicio,
                Servicio = servicio.Servicio,
                Descripcion = servicio.Descripcion,
                Valor = servicio.Valor,
                Estado = servicio.Estado
            };
        }

        #endregion

        #region Reservas

        public List<ReservaModel> ListaReservas()
        {
            var response = new List<ReservaModel>();
            var lista = new ReservasBo().ObtenerReservas();
            if (lista.EsValido)
            {
                response = lista.Reservas.Select(o => new ReservaModel
                {
                    IdReserva = o.IdReserva,
                    IdComunaRetiro = o.IdComunaRetiro,
                    ComunaRetiro = o.Comunas.Comuna,
                    FechaHoraRetiro = o.FechaRetiro,
                    IdComunaEntrega = o.IdComunaEntrega,
                    ComunaEntrega = o.Comunas1.Comuna,
                    FechaHoraEntrega = o.FechaEntrega ?? DateTime.MinValue,
                    IdVehiculo = o.IdVehiculo,
                    Vehiculo = ObtenerVehiculo(o.IdVehiculo),
                    Nombres = o.Nombres,
                    Apellidos = o.Apellidos,
                    Email = o.Email,
                    Direccion = o.Direccion,
                    IdComuna = o.IdComuna,
                    Comuna = o.Comunas2.Comuna,
                    Telefono = o.Telefono,
                    IdEstado = o.IdEstado,
                    Estado = o.Estados.Estado,
                    ValorFinal = o.ValorFinal,
                    IdUsuario = o.IdUsuario,
                    Usuario = ObtenerUsuario(o.IdUsuario),
                    Observaciones = o.Observaciones
                }).ToList();
            }

            return response;
        }

        public ReservaModel ObtenerReserva(int idReserva)
        {
            var response = new ReservaModel();
            var item = new ReservasBo().ObtenerReserva(new ReservasRequest
            {
                IdReserva = idReserva
            });
            if (item.EsValido)
            {
                response = new ReservaModel
                {
                    IdReserva = item.Reserva.IdReserva,
                    IdComunaRetiro = item.Reserva.IdComunaRetiro,
                    ComunaRetiro = item.Reserva.Comunas.Comuna,
                    FechaHoraRetiro = item.Reserva.FechaRetiro,
                    FechaRetiro = item.Reserva.FechaRetiro.ToString("dd/MM/yyyy"),
                    HoraRetiro = item.Reserva.FechaRetiro.ToString("HH:mm"),
                    IdComunaEntrega = item.Reserva.IdComunaEntrega,
                    ComunaEntrega = item.Reserva.Comunas1.Comuna,
                    FechaHoraEntrega = item.Reserva.FechaEntrega ?? DateTime.MinValue,
                    FechaEntrega = item.Reserva.FechaEntrega.HasValue ?
                        item.Reserva.FechaEntrega.Value.ToString("dd/MM/yyyy") : "",
                    HoraEntrega = item.Reserva.FechaEntrega.HasValue  ?
                        item.Reserva.FechaEntrega.Value.ToString("HH:mm") : "",
                    IdVehiculo = item.Reserva.IdVehiculo,
                    Vehiculo = ObtenerVehiculo(item.Reserva.IdVehiculo),
                    Servicios = ObtenerServiciosReserva(idReserva),
                    Nombres = item.Reserva.Nombres,
                    Apellidos = item.Reserva.Apellidos,
                    Email = item.Reserva.Email,
                    Direccion = item.Reserva.Direccion,
                    IdComuna = item.Reserva.IdComuna,
                    Comuna = item.Reserva.Comunas2.Comuna,
                    Telefono = item.Reserva.Telefono,
                    IdEstado = item.Reserva.IdEstado,
                    Estado = item.Reserva.Estados.Estado,
                    ValorFinal = item.Reserva.ValorFinal,
                    IdUsuario = item.Reserva.IdUsuario,
                    Usuario = ObtenerUsuario(item.Reserva.IdUsuario),
                    Observaciones = item.Reserva.Observaciones
                };
            }

            return response;
        }

        public List<ServicioModel> ObtenerServiciosReserva(int idReserva)
        {
            var response = new List<ServicioModel>();
            var lista = new ReservaServiciosBo().ObtenerReservaServiciosPorIdReserva(new ReservaServiciosRequest
            {
                IdReserva = idReserva
            });
            if (lista.EsValido)
            {
                response = lista.ReservaServicios.Select(o => new ServicioModel
                {
                    IdServicio = o.IdServicio,
                    Servicio = o.Servicios.Servicio,
                    Descripcion = o.Servicios.Descripcion,
                    Valor = o.Servicios.Valor,
                    Estado = o.Servicios.Estado
                }).ToList();
            }

            return response;
        }

        public List<ComboModel> ListaEstados()
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerEstados();
            if (lista.EsValido)
            {
                response = lista.Estados.Select(o => new ComboModel
                {
                    Text = o.Estado,
                    Value = o.IdEstado.ToString()
                }).ToList();
            }

            return response;
        }

        #endregion

        #region Usuarios

        public List<UsuarioModel> ListaUsuarios()
        {
            var response = new List<UsuarioModel>();
            var lista = new UsuariosBo().ObtenerUsuarios();
            if (lista.EsValido)
            {
                response = lista.Usuarios.Select(o => new UsuarioModel
                {
                    IdUsuario = o.IdUsuario,
                    Rut = o.Rut,
                    Nombres = o.Nombres,
                    ApPaterno = o.ApPaterno,
                    ApMaterno = o.ApMaterno,
                    Telefono = o.Telefono,
                    Email = o.Email,
                    RutaImagen = o.RutaImagen,
                    IdRol = o.IdRol,
                    Rol = o.Roles.Rol,
                    Clave = o.Clave,
                    Estado = o.Estado
                }).ToList();
            }

            return response;
        }

        public UsuarioModel ObtenerUsuario(int idUsuario)
        {
            var response = new UsuarioModel();
            var item = new UsuariosBo().ObtenerUsuario(new UsuariosRequest
            {
                IdUsuario = idUsuario
            });
            if (item.EsValido)
            {
                response = new UsuarioModel
                {
                    IdUsuario = item.Usuario.IdUsuario,
                    Rut = item.Usuario.Rut,
                    Nombres = item.Usuario.Nombres,
                    ApPaterno = item.Usuario.ApPaterno,
                    ApMaterno = item.Usuario.ApMaterno,
                    Telefono = item.Usuario.Telefono,
                    Email = item.Usuario.Email,
                    RutaImagen = item.Usuario.RutaImagen,
                    IdRol = item.Usuario.IdRol,
                    Rol = item.Usuario.Roles.Rol,
                    Clave = item.Usuario.Clave,
                    Estado = item.Usuario.Estado
                };
            }

            return response;
        }

        public Usuarios CrearUsuario(UsuarioModel usuario)
        {
            return new Usuarios
            {
                IdUsuario = usuario.IdUsuario,
                Rut = usuario.Rut,
                Nombres = usuario.Nombres,
                ApPaterno = usuario.ApPaterno,
                ApMaterno = usuario.ApMaterno,
                Telefono = usuario.Telefono,
                Email = usuario.Email,
                RutaImagen = usuario.RutaImagen,
                IdRol = usuario.IdRol,
                Clave = usuario.Clave,
                Estado = usuario.Estado
            };
        }

        public UsuarioModel CrearUsuarioModel(Usuarios usuario)
        {
            return new UsuarioModel
            {
                IdUsuario = usuario.IdUsuario,
                Rut = usuario.Rut,
                Nombres = usuario.Nombres,
                ApPaterno = usuario.ApPaterno,
                ApMaterno = usuario.ApMaterno,
                Telefono = usuario.Telefono,
                Email = usuario.Email,
                RutaImagen = usuario.RutaImagen,
                IdRol = usuario.IdRol,
                Rol = usuario.Roles.Rol,
                Clave = usuario.Clave,
                Estado = usuario.Estado
            };
        }

        public List<ComboModel> ListaRoles()
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerRoles();
            if (lista.EsValido)
            {
                response = lista.Roles.Select(o => new ComboModel
                {
                    Text = o.Rol,
                    Value = o.IdRol.ToString()
                }).ToList();
            }

            return response;
        }

        #endregion
    }
}