namespace SisRent.Datos.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Entidades.Response;

    public class ServiciosDa
    {
        private readonly SisRentModel _sisRentModel;

        public ServiciosDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }

        public ServiciosResponse CrearServicio(ServiciosRequest request)
        {
            var response = new ServiciosResponse
            {
                EsValido = true
            };
            try
            {
                _sisRentModel.Servicios.Add(request.Servicio);
                _sisRentModel.SaveChanges();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ServiciosResponse ObtenerServicios()
        {
            var response = new ServiciosResponse
            {
                EsValido = true,
                Servicios = new List<Servicios>()
            };
            try
            {
                response.Servicios = _sisRentModel.Servicios.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ServiciosResponse ObtenerServicio(ServiciosRequest request)
        {
            var response = new ServiciosResponse
            {
                EsValido = true
            };
            try
            {
                response.Servicio = _sisRentModel.Servicios
                    .FirstOrDefault(o => o.IdServicio == request.IdServicio);
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public ServiciosResponse ActualizarServicio(ServiciosRequest request)
        {
            var response = new ServiciosResponse
            {
                EsValido = true
            };
            try
            {
                var servicio = _sisRentModel.Servicios
                    .FirstOrDefault(o => o.IdServicio == request.IdServicio);
                if (servicio == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Servicio no encontrado";
                }
                else
                {
                    servicio.Servicio = request.Servicio.Servicio;
                    servicio.Descripcion = request.Servicio.Descripcion;
                    servicio.Valor = request.Servicio.Valor;
                    servicio.Estado = request.Servicio.Estado;
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

        public ServiciosResponse EliminarServicio(ServiciosRequest request)
        {
            var response = new ServiciosResponse
            {
                EsValido = true
            };
            try
            {
                var servicio = _sisRentModel.Servicios
                    .FirstOrDefault(o => o.IdServicio == request.IdServicio);
                if (servicio == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Servicio no encontrado";
                }
                else
                {
                    _sisRentModel.Servicios.Remove(servicio);
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
