namespace SisRent.Datos.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Entidades.Response;

    public class VehiculosDa
    {
        private readonly SisRentModel _sisRentModel;

        public VehiculosDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }

        public VehiculosResponse CrearVehiculo(VehiculosRequest request)
        {
            var response = new VehiculosResponse
            {
                EsValido = true
            };
            try
            {
                _sisRentModel.Vehiculos.Add(request.Vehiculo);
                _sisRentModel.SaveChanges();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public VehiculosResponse ObtenerVehiculos()
        {
            var response = new VehiculosResponse
            {
                EsValido = true,
                Vehiculos = new List<Vehiculos>()
            };
            try
            {
                response.Vehiculos = _sisRentModel.Vehiculos.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public VehiculosResponse ObtenerVehiculo(VehiculosRequest request)
        {
            var response = new VehiculosResponse
            {
                EsValido = true
            };
            try
            {
                response.Vehiculo = _sisRentModel.Vehiculos
                    .FirstOrDefault(o => o.IdVehiculo == request.IdVehiculo);
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public VehiculosResponse ActualizarVehiculo(VehiculosRequest request)
        {
            var response = new VehiculosResponse
            {
                EsValido = true
            };
            try
            {
                var vehiculo = _sisRentModel.Vehiculos
                    .FirstOrDefault(o => o.IdVehiculo == request.Vehiculo.IdVehiculo);
                if (vehiculo == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Vehículo no encontrado";
                }
                else
                {
                    vehiculo.IdModelo = request.Vehiculo.IdModelo;
                    vehiculo.Anio = request.Vehiculo.Anio;
                    vehiculo.Valor = request.Vehiculo.Valor;
                    vehiculo.Patente = request.Vehiculo.Patente;
                    vehiculo.RutaImagen = request.Vehiculo.RutaImagen;
                    vehiculo.Observaciones = request.Vehiculo.Observaciones;
                    vehiculo.Estado = request.Vehiculo.Estado;
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

        public VehiculosResponse EliminarVehiculo(VehiculosRequest request)
        {
            var response = new VehiculosResponse
            {
                EsValido = true
            };
            try
            {
                var vehiculo = _sisRentModel.Vehiculos
                    .FirstOrDefault(o => o.IdVehiculo == request.IdVehiculo);
                if (vehiculo == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Vehículo no encontrado";
                }
                else
                {
                    _sisRentModel.Vehiculos.Remove(vehiculo);
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
