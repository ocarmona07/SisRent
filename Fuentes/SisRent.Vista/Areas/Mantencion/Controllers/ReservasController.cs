namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;

    public class ReservasController : Controller
    {
        // GET: Mantencion/Reservas
        public ActionResult Index()
        {
            var vmmhAdmin = new ViewModelMapperHelper();
            var model = new ReservasViewModel
            {
                ListaReservas = vmmhAdmin.ListaReservas(),
                ListaComunas = new Vista.Models.ViewModelMapperHelper().ListaComunas(),
                ListaServicios = vmmhAdmin.ListaServicios(),
                ListaVehiculos = vmmhAdmin.ListaVehiculos(),
                ListaEstados = vmmhAdmin.ListaEstados()
            };

            return View(model);
        }

        // GET: Mantencion/Reservas/CrearReserva
        public ActionResult CrearReserva()
        {
            var vmmhAdmin = new ViewModelMapperHelper();
            var model = new ReservasViewModel
            {
                ListaComunas = new Vista.Models.ViewModelMapperHelper().ListaComunas(),
                ListaServicios = vmmhAdmin.ListaServicios(),
                ListaVehiculos = vmmhAdmin.ListaVehiculos()
            };

            return View(model);
        }

        public JsonResult NuevaReserva(string comunaRetiro, string fechaRetiro, string horaRetiro,
            string comunaEntrega, string fechaEntrega, string horaEntrega, int idVehiculo,
            List<int> servicios, string nombres, string apellidos, string email, string direccion,
            string comuna, string telefono)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var reserva = new Vista.Models.ViewModelMapperHelper().CrearReserva(comunaRetiro,
                fechaRetiro, horaRetiro, comunaEntrega, fechaEntrega, horaEntrega, idVehiculo,
                servicios, nombres, apellidos, email, direccion, comuna, telefono);
            if (!reserva.EsValido)
            {
                response = new
                {
                    valid = false,
                    message = reserva.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerReserva(int idReserva)
        {
            var response = new
            {
                valid = true,
                message = "",
                reserva = new ReservaModel()
            };
            var reserva = new ViewModelMapperHelper().ObtenerReserva(idReserva);
            if (reserva.IdReserva > 0)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    reserva
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "Reserva no encontrado",
                    reserva = new ReservaModel()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ActualizarReserva(int idReserva, string comunaRetiro, string fechaRetiro,
            string horaRetiro, string comunaEntrega, string fechaEntrega, string horaEntrega,
            int idVehiculo, List<int> servicios, string nombres, string apellidos, string email,
            string direccion, string comuna, string telefono)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var reserva = new Vista.Models.ViewModelMapperHelper().CrearReserva(comunaRetiro,
                fechaRetiro, horaRetiro, comunaEntrega, fechaEntrega, horaEntrega, idVehiculo,
                servicios, nombres, apellidos, email, direccion, comuna, telefono);
            if (!reserva.EsValido)
            {
                response = new
                {
                    valid = false,
                    message = reserva.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CambiarEstado(int idReserva, int idEstado, string observaciones)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var reserva = new ReservasBo().ObtenerReserva(new ReservasRequest
            {
                IdReserva = idReserva
            });
            if (reserva.EsValido)
            {
                reserva.Reserva.IdEstado = idEstado;
                reserva.Reserva.Observaciones = observaciones;
                var cambio = new ReservasBo().ActualizarReserva(new ReservasRequest
                {
                    Reserva = reserva.Reserva
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
                    message = reserva.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}