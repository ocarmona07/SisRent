namespace SisRent.Vista.Areas.Mantencion.Controllers
{
    using System.Configuration;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;
    using Entidades.Request;
    using Models;
    using Negocio.Admin;

    public class UsuariosController : Controller
    {
        // GET: Mantencion/Usuarios
        public ActionResult Index()
        {
            var model = new UsuariosViewModel
            {
                ListaUsuarios = new ViewModelMapperHelper().ListaUsuarios(),
                ListaRoles = new ViewModelMapperHelper().ListaRoles()
            };

            return View(model);
        }

        // GET: Mantencion/Usuarios/AgregarUsuario
        public ActionResult AgregarUsuario()
        {
            var model = new UsuariosViewModel
            {
                ListaRoles = new ViewModelMapperHelper().ListaRoles()
            };

            return View(model);
        }

        public JsonResult ObtenerUsuario(int idUsuario)
        {
            var response = new
            {
                valid = true,
                message = "",
                usuario = new UsuarioModel()
            };
            var usuario = new ViewModelMapperHelper().ObtenerUsuario(idUsuario);
            if (usuario.IdUsuario > 0)
            {
                response = new
                {
                    valid = true,
                    message = "",
                    usuario
                };
            }
            else
            {
                response = new
                {
                    valid = false,
                    message = "Usuario no encontrado",
                    usuario = new UsuarioModel()
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CrearUsuario(string rut, string nombres, string apPaterno, string apMaterno,
            string telefono, string email, int idRol)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var usuario = new UsuarioModel
            {
                Rut = rut.Replace(".", "").Replace("-", ""),
                Nombres = nombres,
                ApPaterno = apPaterno,
                ApMaterno = apMaterno,
                Telefono = telefono,
                Email = email,
                RutaImagen = ConfigurationManager.AppSettings.Get("ImagesUsuarios") + "User.jpg",
                IdRol = idRol,
                Clave = ConfigurationManager.AppSettings.Get("ClaveDefecto"),
                Estado = false
            };

            var crear = new UsuariosBo().AgregaUsuario(new UsuariosRequest
            {
                Usuario = new ViewModelMapperHelper().CrearUsuario(usuario)
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
        public JsonResult ActualizarUsuario(int idUsuario, string nombres, string apPaterno,
            string apMaterno, string telefono, string email, int idRol)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var usuario = new UsuariosBo().ObtenerUsuario(new UsuariosRequest
            {
                IdUsuario = idUsuario
            });
            if (usuario.EsValido)
            {
                usuario.Usuario.Nombres = nombres;
                usuario.Usuario.ApPaterno = apPaterno;
                usuario.Usuario.ApMaterno = apMaterno;
                usuario.Usuario.Telefono = telefono;
                usuario.Usuario.Email = email;
                usuario.Usuario.IdRol = idRol;
                var cambio = new UsuariosBo().ActualizarUsuario(new UsuariosRequest
                {
                    Usuario = usuario.Usuario
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
                    message = usuario.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SubirImagen(int idUsuario, HttpPostedFileBase rutaImagen)
        {
            var usuario = new UsuariosBo().ObtenerUsuario(new UsuariosRequest
            {
                IdUsuario = idUsuario
            });
            if (usuario.EsValido && rutaImagen != null && Request.Files.Count > 0)
            {
                var dir = ConfigurationManager.AppSettings.Get("ImagesUsuarios");
                var nombreArchivo = usuario.Usuario.Rut + Path.GetExtension(rutaImagen.FileName);
                rutaImagen.SaveAs(Path.Combine(Server.MapPath("~" + dir), nombreArchivo));

                usuario.Usuario.RutaImagen = dir + nombreArchivo;
                new UsuariosBo().ActualizarUsuario(new UsuariosRequest
                {
                    Usuario = usuario.Usuario
                });
            }

            return RedirectToAction("Index");
        }

        public JsonResult CambiarEstado(int idUsuario, bool estado)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var usuario = new UsuariosBo().ObtenerUsuario(new UsuariosRequest
            {
                IdUsuario = idUsuario
            });
            if (usuario.EsValido)
            {
                usuario.Usuario.Estado = estado;
                var cambio = new UsuariosBo().ActualizarUsuario(new UsuariosRequest
                {
                    Usuario = usuario.Usuario
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
                    message = usuario.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ResetClave(int idUsuario)
        {
            var response = new
            {
                valid = true,
                message = ""
            };
            var usuario = new UsuariosBo().ObtenerUsuario(new UsuariosRequest
            {
                IdUsuario = idUsuario
            });
            if (usuario.EsValido)
            {
                usuario.Usuario.Clave = ConfigurationManager.AppSettings.Get("ClaveDefecto");
                var cambio = new UsuariosBo().ActualizarUsuario(new UsuariosRequest
                {
                    Usuario = usuario.Usuario
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
                    message = usuario.MensajeError
                };
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}