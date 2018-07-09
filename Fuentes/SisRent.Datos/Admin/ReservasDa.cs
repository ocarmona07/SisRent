namespace SisRent.Datos.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Entidades.Response;

    public class ReservasDa
    {
        private readonly SisRentModel _sisRentModel;

        public ReservasDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }

        public ReservasResponse CrearReserva(ReservasRequest request)
        {
            var response = new ReservasResponse
            {
                EsValido = true
            };
            try
            {
                _sisRentModel.Reservas.Add(request.Reserva);
                _sisRentModel.SaveChanges();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservasResponse ObtenerReservas()
        {
            var response = new ReservasResponse
            {
                EsValido = true,
                Reservas = new List<Reservas>()
            };
            try
            {
                response.Reservas = _sisRentModel.Reservas.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservasResponse ObtenerReserva(ReservasRequest request)
        {
            var response = new ReservasResponse
            {
                EsValido = true
            };
            try
            {
                response.Reserva = _sisRentModel.Reservas
                    .FirstOrDefault(o => o.IdReserva == request.IdReserva);
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ReservasResponse ActualizarReserva(ReservasRequest request)
        {
            var response = new ReservasResponse
            {
                EsValido = true
            };
            try
            {
                var reserva = _sisRentModel.Reservas
                    .FirstOrDefault(o => o.IdReserva == request.IdReserva);
                if (reserva == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Reserva no encontrada";
                }
                else
                {
                    reserva.IdComunaRetiro = request.Reserva.IdComunaRetiro;
                    reserva.FechaRetiro = request.Reserva.FechaRetiro;
                    reserva.IdComunaEntrega = request.Reserva.IdComunaEntrega;
                    reserva.FechaEntrega = request.Reserva.FechaEntrega;
                    reserva.IdVehiculo = request.Reserva.IdVehiculo;
                    reserva.Nombres = request.Reserva.Nombres;
                    reserva.Apellidos = request.Reserva.Apellidos;
                    reserva.Email = request.Reserva.Email;
                    reserva.Direccion = request.Reserva.Direccion;
                    reserva.IdComuna = request.Reserva.IdComuna;
                    reserva.Telefono = request.Reserva.Telefono;
                    reserva.IdEstado = request.Reserva.IdEstado;
                    reserva.IdUsuario = request.Reserva.IdUsuario;
                    reserva.Observaciones = request.Reserva.Observaciones;
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

        public ReservasResponse EliminarReserva(ReservasRequest request)
        {
            var response = new ReservasResponse
            {
                EsValido = true
            };
            try
            {
                var reserva = _sisRentModel.Reservas
                    .FirstOrDefault(o => o.IdReserva == request.IdReserva);
                if (reserva == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Reserva no encontrada";
                }
                else
                {
                    _sisRentModel.Reservas.Remove(reserva);
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
