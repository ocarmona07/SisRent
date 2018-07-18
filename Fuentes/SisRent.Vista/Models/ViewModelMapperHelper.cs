using System;
using SisRent.Entidades.Entidades;

namespace SisRent.Vista.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Common;
    using Entidades.Request;
    using Negocio.Admin;
    using Negocio.Common;

    public class ViewModelMapperHelper
    {
        public List<ComboModel> ListaComunas()
        {
            var response = new List<ComboModel>();
            var lista = new ListasBo().ObtenerComunas();
            if (lista.EsValido)
            {
                response = lista.Comunas.Select(o => new ComboModel
                {
                    Value = o.IdComuna.ToString(),
                    Text = o.Comuna
                }).ToList();
            }

            return response;
        }

        public ResponseBase CrearReserva(string comunaRetiro, string fechaRetiro,
            string horaRetiro, string comunaEntrega, string fechaEntrega, string horaEntrega,
            int idVehiculo, List<int> servicios, string nombres, string apellidos, string email,
            string direccion, string comuna, string telefono)
        {
            var response = new ResponseBase
            {
                EsValido = true
            };
            var reserva = new ReservasBo().AgregaReserva(new ReservasRequest
            {
                Reserva = new Reservas
                {
                    IdComunaRetiro = int.Parse(comunaRetiro),
                    FechaRetiro = DateTime.Parse(fechaRetiro + " " + horaRetiro),
                    IdComunaEntrega = int.Parse(comunaEntrega),
                    FechaEntrega = DateTime.Parse(fechaRetiro + " " + horaEntrega),
                    IdVehiculo = idVehiculo,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Email = email,
                    Direccion = direccion,
                    IdComuna = int.Parse(comuna),
                    Telefono = telefono,
                    IdEstado = (int)EnumEstados.EnEspera,
                    ValorFinal = 0,
                    IdUsuario = 1
                }
            });
            if (reserva.EsValido)
            {
                foreach (var servicio in servicios)
                {
                    var dataServicio = new ServiciosBo().ObtenerServicio(new ServiciosRequest
                    {
                        IdServicio = servicio
                    });
                    if (!dataServicio.EsValido)
                    {
                        response.EsValido = false;
                        response.MensajeError = dataServicio.MensajeError;
                        break;
                    }

                    var reservaServicio = new ReservaServiciosBo().AgregaReservaServicio(
                        new ReservaServiciosRequest
                        {
                            ReservaServicio = new ReservaServicio
                            {
                                IdReserva = reserva.Reserva.IdReserva,
                                IdServicio = servicio,
                                ValorServicio = dataServicio.Servicio.Valor
                            }
                        });
                    if (!reservaServicio.EsValido)
                    {
                        response.EsValido = false;
                        response.MensajeError = reservaServicio.MensajeError;
                        break;
                    }
                }
            }
            else
            {
                response.EsValido = false;
                response.MensajeError = reserva.MensajeError;
            }

            return response;
        }

        public ResponseBase ActualizarReserva(string comunaRetiro, string fechaRetiro,
            string horaRetiro, string comunaEntrega, string fechaEntrega, string horaEntrega,
            int idVehiculo, List<int> servicios, string nombres, string apellidos, string email,
            string direccion, string comuna, string telefono)
        {
            var response = new ResponseBase
            {
                EsValido = true
            };
            var reserva = new ReservasBo().ActualizarReserva(new ReservasRequest
            {
                Reserva = new Reservas
                {
                    IdComunaRetiro = int.Parse(comunaRetiro),
                    FechaRetiro = DateTime.Parse(fechaRetiro + " " + horaRetiro),
                    IdComunaEntrega = int.Parse(comunaEntrega),
                    FechaEntrega = DateTime.Parse(fechaRetiro + " " + horaEntrega),
                    IdVehiculo = idVehiculo,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Email = email,
                    Direccion = direccion,
                    IdComuna = int.Parse(comuna),
                    Telefono = telefono,
                    IdEstado = (int)EnumEstados.EnPreparación,
                    ValorFinal = 0,
                    IdUsuario = 1
                }
            });
            if (reserva.EsValido)
            {
                foreach (var servicio in servicios)
                {
                    var dataServicio = new ServiciosBo().ObtenerServicio(new ServiciosRequest
                    {
                        IdServicio = servicio
                    });
                    if (!dataServicio.EsValido)
                    {
                        response.EsValido = false;
                        response.MensajeError = dataServicio.MensajeError;
                        break;
                    }

                    var reservaServicio = new ReservaServiciosBo().AgregaReservaServicio(
                        new ReservaServiciosRequest
                        {
                            ReservaServicio = new ReservaServicio
                            {
                                IdReserva = reserva.Reserva.IdReserva,
                                IdServicio = servicio,
                                ValorServicio = dataServicio.Servicio.Valor
                            }
                        });
                    if (!reservaServicio.EsValido)
                    {
                        response.EsValido = false;
                        response.MensajeError = reservaServicio.MensajeError;
                        break;
                    }
                }
            }
            else
            {
                response.EsValido = false;
                response.MensajeError = reserva.MensajeError;
            }

            return response;
        }
    }
}