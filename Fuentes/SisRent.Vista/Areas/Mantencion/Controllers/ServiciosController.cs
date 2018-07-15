using SisRent.Entidades.Request;
using SisRent.Negocio.Admin;

namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class ServiciosController : Controller
    {
        // GET: Mantencion/Servicios
        public ActionResult Index()
        {
            var model = new ServiciosViewModel
            {
                ListaServicios = new ViewModelMapperHelper().ListaServicios(),
            };

            return View(model);
        }

        // GET: Mantencion/Servicios/AgregarServicio
        public ActionResult AgregarServicio()
        {
            return View();
        }

        public JsonResult ObtenerServicio(int idServicio)
        {
            var response = new
            {
                valid = true,
                message = "",
                servicio = new ServicioModel()
            };
            var servicio = new ViewModelMapperHelper().ObtenerServicio(idServicio);
            if (servicio.IdServicio > 0)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    servicio
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "Servicio no encontrado",
                    servicio = new ServicioModel()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CrearServicio(string nombre, decimal valor, string descripcion,
            bool estado)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var servicio = new ServicioModel
            {
                Servicio = nombre,
                Descripcion = descripcion,
                Valor = valor,
                Estado = estado
            };

            var crear = new ServiciosBo().AgregaServicio(new ServiciosRequest
            {
                Servicio = new ViewModelMapperHelper().CrearServicio(servicio)
            });
            if (crear.EsValido)
            {
                response = new
                {
                    valid = true,
                    message = ""
                };
            }
            else
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
        public JsonResult ActualizarServicio(int idServicio, string nombre,
            string descripcion, decimal valor)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var servicio = new ServiciosBo().ObtenerServicio(new ServiciosRequest
            {
                IdServicio = idServicio
            });
            if (servicio.EsValido)
            {
                servicio.Servicio.Servicio = nombre;
                servicio.Servicio.Descripcion = descripcion;
                servicio.Servicio.Valor = valor;
                var cambio = new ServiciosBo().ActualizarServicio(new ServiciosRequest
                {
                    Servicio = servicio.Servicio
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
                    message = servicio.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CambiarEstado(int idServicio, bool estado)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var servicio = new ServiciosBo().ObtenerServicio(new ServiciosRequest
            {
                IdServicio = idServicio
            });
            if (servicio.EsValido)
            {
                servicio.Servicio.Estado = estado;
                var cambio = new ServiciosBo().ActualizarServicio(new ServiciosRequest
                {
                    Servicio = servicio.Servicio
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
                    message = servicio.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}