using System.Collections.Generic;
using DataAcces.Autenticacion;
using Model.Autenticacion;

namespace Negocio.Autenticacion
{
    public class UsuarioBLL
    {
        public bool Autenticar(string username, string password)
        {
            bool resultado = false;
            UsuarioBE usuario = GetUsuarioPorNombre(username);
            if (usuario != null)
            {
                resultado = new Session.Autenticacion().Autenticar(username, password, usuario);

            }
            return resultado;
        } //Autenticación del usuario

        public bool UsuarioExiste(string usuario) //Verifica si un usuario ya existe
        {
            bool Existe = false;
            UsuarioDAO AD = new UsuarioDAO();
            if (AD.GetUsuariosPorNombre(usuario).Count != 0)
            {
                Existe = true;
            }
            return Existe;
        }

        public UsuarioBE GetUsuarioPorNombre(string usuario)
        {
            List<UsuarioBE> usuarios = new UsuarioDAO().GetUsuariosPorNombre(usuario);
            return usuarios[0];
        } //Busca un usuario por nombre

        public void CrearUsuario(UsuarioBE usuario) //Alta de Usuario
        {
            new UsuarioDAO().CrearUsuario(usuario);
        }

        public void ModificarUsuario(UsuarioBE usuario)
        {
            new UsuarioDAO().ModificarUsuario(usuario);
        }
    }
}
