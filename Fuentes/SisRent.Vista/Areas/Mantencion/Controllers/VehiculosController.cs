namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;
    using Negocio.Common;

    public class VehiculosController : Controller
    {
        // GET: Mantencion/Vehiculos
        public ActionResult Index()
        {
            var model = new VehiculosViewModel
            {
                ListaVehiculos = new VehiculosBo().ObtenerVehiculos().Vehiculos,
                ListaMarcas = new ListasBo().ObtenerMarcas().Marcas
            };

            return View(model);
        }

        // GET: Mantencion/Vehiculos/AgregarVehiculo
        public ActionResult AgregarVehiculo()
        {
            return View();
        }

        public JsonResult ObtenerVehiculo(int idVehiculo)
        {
            var response = new
            {
                valid = true,
                message = "",
                vehiculo = new VehiculoModel()
            };
            var vehiculo = new VehiculosBo().ObtenerVehiculo(new VehiculosRequest
            {
                IdVehiculo = idVehiculo
            });
            if (vehiculo.EsValido)
            {
                var vehiculoModel = new VehiculoModel
                {
                    IdVehiculo = vehiculo.Vehiculo.IdVehiculo,
                    IdMarca = vehiculo.Vehiculo.VehModelos.IdMarca,
                    IdModelo = vehiculo.Vehiculo.IdModelo,
                    Anio = vehiculo.Vehiculo.Anio,
                    Patente = vehiculo.Vehiculo.Patente,
                    Valor = vehiculo.Vehiculo.Valor,
                    Observaciones = vehiculo.Vehiculo.Observaciones,
                    RutaImagen = vehiculo.Vehiculo.RutaImagen,
                    Estado = vehiculo.Vehiculo.Estado
                };

                response = new
                {
                    valid = true,
                    message = "",
                    vehiculo = vehiculoModel
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = vehiculo.MensajeError,
                    vehiculo = new VehiculoModel()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CambiarEstado(int idVehiculo, bool estado)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var vehiculo = new VehiculosBo().ObtenerVehiculo(new VehiculosRequest
            {
                IdVehiculo = idVehiculo
            });
            if (vehiculo.EsValido)
            {
                vehiculo.Vehiculo.Estado = estado;
                var cambio = new VehiculosBo().ActualizarVehiculo(new VehiculosRequest
                {
                    Vehiculo = vehiculo.Vehiculo
                });
                if (!cambio.EsValido)
                {
                    response = new
                    {
                        valid = false,
                        message = cambio.MensajeError
                    };
                }
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = vehiculo.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}