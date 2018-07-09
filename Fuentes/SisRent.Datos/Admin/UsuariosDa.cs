namespace SisRent.Datos.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades.Entidades;
    using Entidades.Request;
    using Entidades.Response;

    public class UsuariosDa
    {
        private readonly SisRentModel _sisRentModel;

        public UsuariosDa()
        {
            if (_sisRentModel == null)
            {
                _sisRentModel = new SisRentModel();
            }
        }

        public UsuariosResponse CrearUsuario(UsuariosRequest request)
        {
            var response = new UsuariosResponse
            {
                EsValido = true
            };
            try
            {
                _sisRentModel.Usuarios.Add(request.Usuario);
                _sisRentModel.SaveChanges();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public UsuariosResponse ObtenerUsuarios()
        {
            var response = new UsuariosResponse
            {
                EsValido = true,
                Usuarios = new List<Usuarios>()
            };
            try
            {
                response.Usuarios = _sisRentModel.Usuarios.ToList();
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public UsuariosResponse ObtenerUsuario(UsuariosRequest request)
        {
            var response = new UsuariosResponse
            {
                EsValido = true
            };
            try
            {
                response.Usuario = _sisRentModel.Usuarios
                    .FirstOrDefault(o => o.IdUsuario == request.IdUsuario);
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public UsuariosResponse ActualizarUsuario(UsuariosRequest request)
        {
            var response = new UsuariosResponse
            {
                EsValido = true
            };
            try
            {
                var usuario = _sisRentModel.Usuarios
                    .FirstOrDefault(o => o.IdUsuario == request.IdUsuario);
                if (usuario == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Usuario no encontrado";
                }
                else
                {
                    usuario.Nombres = request.Usuario.Nombres;
                    usuario.ApPaterno = request.Usuario.ApPaterno;
                    usuario.ApMaterno = request.Usuario.ApMaterno;
                    usuario.Telefono = request.Usuario.Telefono;
                    usuario.Email = request.Usuario.Email;
                    usuario.IdRol = request.Usuario.IdRol;
                    usuario.Clave = request.Usuario.Clave;
                    usuario.Estado = request.Usuario.Estado;
                    _sisRentModel.SaveChanges();
                }
            }
            catch (Exception e)
            {
                response.EsValido = false;
                response.MensajeError = e.GetBaseException().Message;
            }

            return response;
        }

        public UsuariosResponse EliminarUsuario(UsuariosRequest request)
        {
            var response = new UsuariosResponse
            {
                EsValido = true
            };
            try
            {
                var usuario = _sisRentModel.Usuarios
                    .FirstOrDefault(o => o.IdUsuario == request.IdUsuario);
                if (usuario == null)
                {
                    response.EsValido = false;
                    response.MensajeError = "Usuario no encontrado";
                }
                else
                {
                    _sisRentModel.Usuarios.Remove(usuario);
                    _sisRentModel.SaveChanges();
                }
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
