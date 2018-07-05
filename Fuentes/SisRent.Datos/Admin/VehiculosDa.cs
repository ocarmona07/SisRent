using System;
using System.Collections.Generic;
using System.Linq;
using SisRent.Entidades.Entidades;
using SisRent.Entidades.Request;
using SisRent.Entidades.Response;

namespace SisRent.Datos.Admin
{
    public class VehiculosDa
    {
        private readonly SisRentModel _sisRentModel;

        public VehiculosDa(SisRentModel sisRentModel)
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = sisRentModel;
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
                EsValido = true,
                Vehiculos = new List<Vehiculos>()
            };
            try
            {
                response.Vehiculos = _sisRentModel.Vehiculos
                    .Where(o => o.IdVehiculo == request.IdVehiculo).ToList();
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
