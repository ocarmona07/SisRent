namespace SisRent.Vista.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Net;
    using System.Net.Mail;
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentar()
        {
            var vmmhAdmin = new Areas.Mantencion.Models.ViewModelMapperHelper();
            var model = new RentarViewModel
            {
                ListaComunas = new ViewModelMapperHelper().ListaComunas(),
                ListaServicios = vmmhAdmin.ListaServicios(),
                ListaVehiculos = vmmhAdmin.ListaVehiculos()
            };

            return View(model);
        }

        public JsonResult CrearReserva(string comunaRetiro, string fechaRetiro, string horaRetiro,
            string comunaEntrega, string fechaEntrega, string horaEntrega, int idVehiculo,
            List<int> servicios, string nombres, string apellidos, string email, string direccion,
            string comuna, string telefono)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var reserva = new ViewModelMapperHelper().CrearReserva(comunaRetiro, fechaRetiro,
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


        public ActionResult Informacion()
        {
            ViewBag.Message = "Información";

            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult EnviarCorreo(string titulo, string nombre, string correo,
            string mensaje)
        {
            var model = string.Empty;
            try
            {
                var correoEnvio = ConfigurationManager.AppSettings.Get("Mail:CorreoEnvio");
                var passEnvio = ConfigurationManager.AppSettings.Get("Mail:PasswordEnvio");
                var fromAddress = new MailAddress(correoEnvio, "From Name");
                var toAddress = new MailAddress(correoEnvio, "To Name");

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, passEnvio)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = "VIA WEB: " + titulo,
                    Body = mensaje
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception e)
            {
                model = "Error al enviar correo: " + e.GetBaseException().Message;
            }

            return RedirectToAction("Contacto", model);
        }
    }
}