namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;

    public class ReservasController : Controller
    {
        // GET: Mantencion/Reservas
        public ActionResult Index()
        {
            var model = new ReservasViewModel
            {
                ListaReservas = new ViewModelMapperHelper().ListaReservas()
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
            var reserva = new Vista.Models.ViewModelMapperHelper().CrearReserva(comunaRetiro, fechaRetiro,
                horaRetiro, comunaEntrega, fechaEntrega, horaEntrega, idVehiculo, servicios,
                nombres, apellidos, email, direccion, comuna, telefono);
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
    }
}