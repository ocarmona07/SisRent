namespace SisRent.Datos.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Entidades.Response;

    public class ReservaServiciosDa
    {
        private readonly SisRentModel _sisRentModel;

        public ReservaServiciosDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }

        public ReservaServiciosResponse CrearReservaServicio(ReservaServiciosRequest request)
        {
            var response = new ReservaServiciosResponse
            {
                EsValido = true
            };
            try
            {
                _sisRentModel.ReservaServicio.Add(request.ReservaServicio);
                _sisRentModel.SaveChanges();
                response.ReservaServicio = request.ReservaServicio;
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservaServiciosResponse ObtenerReservaServicios()
        {
            var response = new ReservaServiciosResponse
            {
                EsValido = true,
                ReservaServicios = new List<ReservaServicio>()
            };
            try
            {
                response.ReservaServicios = _sisRentModel.ReservaServicio.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservaServiciosResponse ObtenerReservaServicio(ReservaServiciosRequest request)
        {
            var response = new ReservaServiciosResponse
            {
                EsValido = true
            };
            try
            {
                response.ReservaServicio = _sisRentModel.ReservaServicio
                    .FirstOrDefault(o => o.IdReservaServicio == request.IdReservaServicio);
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservaServiciosResponse ActualizarReservaServicio(ReservaServiciosRequest request)
        {
            var response = new ReservaServiciosResponse
            {
                EsValido = true
            };
            try
            {
                var reservaServicio = _sisRentModel.ReservaServicio
                    .FirstOrDefault(o => o.IdReservaServicio == request.ReservaServicio.IdReservaServicio);
                if (reservaServicio == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Reserva y/o Servicio no encontrado";
                }
                else
                {
                    reservaServicio.IdReserva = request.ReservaServicio.IdReserva;
                    reservaServicio.IdServicio = request.ReservaServicio.IdServicio;
                    reservaServicio.ValorServicio = request.ReservaServicio.ValorServicio;
                    _sisRentModel.SaveChanges();
                }
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservaServiciosResponse EliminarReservaServicio(ReservaServiciosRequest request)
        {
            var response = new ReservaServiciosResponse
            {
                EsValido = true
            };
            try
            {
                var reservaServicio = _sisRentModel.ReservaServicio
                    .FirstOrDefault(o => o.IdReservaServicio == request.IdReservaServicio);
                if (reservaServicio == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Reserva y/o Servicio no encontrado";
                }
                else
                {
                    _sisRentModel.ReservaServicio.Remove(reservaServicio);
                    _sisRentModel.SaveChanges();
                }
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
    }
}
