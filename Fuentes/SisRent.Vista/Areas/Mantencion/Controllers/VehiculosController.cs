namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;

    public class VehiculosController : Controller
    {
        // GET: Mantencion/Vehiculos
        public ActionResult Index()
        {
            var vmmh = new ViewModelMapperHelper();
            var model = new VehiculosViewModel
            {
                ListaVehiculos = vmmh.ListaVehiculos(),
                ListaMarcas = vmmh.ListaMarcas()
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
                modelos = new List<Vista.Models.ComboModel>()
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
                    modelos = new List<Vista.Models.ComboModel>()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CrearVehiculo(int idModelo, int anio, decimal valor, string patente,
            string detalles, bool estado)
        {
            var response = new
            {
                valid = true,
                message = "",
                idVehiculo = 0
            };
            var vehiculo = new VehiculoModel
            {
                IdModelo = idModelo,
                Anio = anio,
                Valor = valor,
                Patente = patente.ToUpper(),
                RutaImagen = 
                    ConfigurationManager.AppSettings.Get("ImagesVehiculos") + "SinImagen.png",
                Detalles = detalles,
                Estado = estado
            };

            var crear = new VehiculosBo().AgregaVehiculo(new VehiculosRequest
            {
                Vehiculo = new ViewModelMapperHelper().CrearVehiculo(vehiculo)
            });
            if (crear.EsValido)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    idVehiculo = crear.Vehiculo.IdVehiculo
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = crear.MensajeError,
                    idVehiculo = 0
                };
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ActualizarVehiculo(int idVehiculo, int idModelo, int anio,
            decimal valor, string patente, string detalles)
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
                vehiculo.Vehiculo.Patente = patente.ToUpper();
                vehiculo.Vehiculo.Detalles = detalles;
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

        public ActionResult SubirImagen(int idVehiculo, HttpPostedFileBase rutaImagen)
        {
            var vehiculo = new VehiculosBo().ObtenerVehiculo(new VehiculosRequest
            {
                IdVehiculo = idVehiculo
            });
            if (vehiculo.EsValido && rutaImagen != null && Request.Files.Count > 0)
            {
                var dir = ConfigurationManager.AppSettings.Get("ImagesVehiculos");
                var veh = vehiculo.Vehiculo;
                var nombreArchivo = string.Format("{0}_{1}_{2}{3}",
                    veh.VehModelos.Modelo, veh.Anio, veh.Patente,
                    Path.GetExtension(rutaImagen.FileName));
                rutaImagen.SaveAs(Path.Combine(Server.MapPath("~" + dir), nombreArchivo));

                vehiculo.Vehiculo.RutaImagen = dir + nombreArchivo;
                new VehiculosBo().ActualizarVehiculo(new VehiculosRequest
                {
                    Vehiculo = vehiculo.Vehiculo
                });
            }

            return RedirectToAction("Index");
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