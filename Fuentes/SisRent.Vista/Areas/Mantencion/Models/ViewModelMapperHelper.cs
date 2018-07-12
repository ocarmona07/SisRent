namespace SisRent.Vista.Areas.Mantencion.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Negocio.Admin;
    using Negocio.Common;

    public class ViewModelMapperHelper
    {
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
                    Observaciones = o.Observaciones,
                    Estado = o.Estado
                }).ToList();
            }

            return response;
        }

        public VehiculoModel ObtenerVehiculo(int idVehiculo)
        {
            var response = new VehiculoModel();
            var lista = new VehiculosBo().ObtenerVehiculo(new VehiculosRequest
            {
                IdVehiculo = idVehiculo
            });
            if (lista.EsValido)
            {
                response = new VehiculoModel
                {
                    IdVehiculo = lista.Vehiculo.IdVehiculo,
                    IdMarca = lista.Vehiculo.VehModelos.IdMarca,
                    IdModelo = lista.Vehiculo.IdModelo,
                    Anio = lista.Vehiculo.Anio,
                    Valor = lista.Vehiculo.Valor,
                    Patente = lista.Vehiculo.Patente,
                    RutaImagen = lista.Vehiculo.RutaImagen,
                    Observaciones = lista.Vehiculo.Observaciones,
                    Estado = lista.Vehiculo.Estado
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
                Observaciones = model.Observaciones,
                Estado = model.Estado
            };
        }
    }
}