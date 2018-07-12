namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;

    public class VehiculosController : Controller
    {
        // GET: Mantencion/Vehiculos
        public ActionResult Index()
        {
            var model = new VehiculosViewModel
            {
                ListaVehiculos = new ViewModelMapperHelper().ListaVehiculos(),
                ListaMarcas = new ViewModelMapperHelper().ListaMarcas()
            };

            return View(model);
        }

        // GET: Mantencion/Vehiculos/AgregarVehiculo
        public ActionResult AgregarVehiculo()
        {
            var model = new VehiculosViewModel
            {
                ListaMarcas = new ViewModelMapperHelper().ListaMarcas()
            };

            return View(model);
        }

        public JsonResult ObtenerVehiculo(int idVehiculo)
        {
            var response = new
            {
                valid = true,
                message = "",
                vehiculo = new VehiculoModel()
            };
            var vehiculo = new ViewModelMapperHelper().ObtenerVehiculo(idVehiculo);
            if (vehiculo.IdVehiculo > 0)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    vehiculo
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "Vehículo no encontrado",
                    vehiculo = new VehiculoModel()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerModelos(int idMarca)
        {
            var response = new
            {
                valid = true,
                message = "",
                modelos = new List<ComboModel>()
            };
            var modelos = new ViewModelMapperHelper().ListaModelos(idMarca);
            if (modelos.Count > 0)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    modelos
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "No se pueden obtener los modelos",
                    modelos = new List<ComboModel>()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CrearVehiculo(int idModelo, int anio, decimal valor, string patente,
            string rutaImagen, string observaciones)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var vehiculo = new VehiculoModel
            {
                IdModelo = idModelo,
                Anio = anio,
                Valor = valor,
                Patente = patente,
                Observaciones = observaciones
            };
            if (!string.IsNullOrWhiteSpace(rutaImagen) && Request.Files.Count > 0)
            {
                // TODO: Subir imagen
                //Request.Files
                vehiculo.RutaImagen = rutaImagen;
            }
            else
            {
                vehiculo.RutaImagen = "/Images/SinImagen.png";
            }

            var crear = new VehiculosBo().AgregaVehiculo(new VehiculosRequest
            {
                Vehiculo = new ViewModelMapperHelper().CrearVehiculo(vehiculo)
            });
            if (!crear.EsValido)
            {
                response = new
                {
                    valid = false,
                    message = crear.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ActualizarVehiculo(int idVehiculo, int idModelo, int anio,
            decimal valor, string patente, string rutaImagen, string observaciones)
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
                vehiculo.Vehiculo.IdModelo = idModelo;
                vehiculo.Vehiculo.Anio = anio;
                vehiculo.Vehiculo.Valor = valor;
                vehiculo.Vehiculo.Patente = patente;
                if (!string.IsNullOrWhiteSpace(rutaImagen) && Request.Files.Count > 0)
                {
                    // TODO: Subir imagen
                    //Request.Files
                    vehiculo.Vehiculo.RutaImagen = rutaImagen;
                }

                vehiculo.Vehiculo.Observaciones = observaciones;
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