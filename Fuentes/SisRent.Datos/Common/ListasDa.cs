namespace SisRent.Datos.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Response;

    public class ListasDa
    {
        private readonly SisRentModel _sisRentModel;

        public ListasDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }
        
        public ListasResponse ObtenerRoles()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Roles = new List<Roles>()
            };
            try
            {
                response.Roles = _sisRentModel.Roles.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerRolAccesos()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                RolAccesos = new List<RolAcceso>()
            };
            try
            {
                response.RolAccesos = _sisRentModel.RolAcceso.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerAccesos()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Accesos = new List<Accesos>()
            };
            try
            {
                response.Accesos = _sisRentModel.Accesos.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerComunas()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Comunas = new List<Comunas>()
            };
            try
            {
                response.Comunas = _sisRentModel.Comunas.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerMarcas()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Marcas = new List<VehMarcas>()
            };
            try
            {
                response.Marcas = _sisRentModel.VehMarcas.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerModelos()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Modelos = new List<VehModelos>()
            };
            try
            {
                response.Modelos = _sisRentModel.VehModelos.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }
        
        public ListasResponse ObtenerEstados()
        {
            var response = new ListasResponse
            {
                EsValido = true,
                Estados = new List<Estados>()
            };
            try
            {
                response.Estados = _sisRentModel.Estados.ToList();
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
