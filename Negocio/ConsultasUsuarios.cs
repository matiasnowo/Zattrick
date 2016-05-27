using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppWeb.Session;
using AppWeb.DataAccess;

namespace AppWeb.Negocio
{
    public class ConsultasUsuarios
    {
        //static List<Usuario> usuarios;

        public bool Autenticar(string usuario, string password)
        {
            List<Usuario> usuarios = new AutentificationDAO().Autenticar(usuario, new Encription().StringToSHA(password));
            if (usuarios.Count != 1)
                return false;
            else
                return true;

        }

        public Usuario GetUsuarioPorNombre(string user)
        {
            List<Usuario> usuarios = new AutentificationDAO().GetUsuario(user);


            return usuarios[0];
        }

        public bool UserExists(string user)
        {
            bool Existe;
            AutentificationDAO AD = new AutentificationDAO();
           
            if (AD.GetUsuario(user).Count != 0)
            {

                Existe = true;
            }
            else
            {

                Existe = false;
            }


            return Existe;
        }


        public void SetUsuario(Usuario user)
        {
            new AutentificationDAO().nuevoUsuario(user);
            //incidentes.Add(inc);
        }

        public void ModifyUsuario(Usuario user)
        {
            new AutentificationDAO().cambiarpwdUsuario(user);
            //incidentes.Add(inc);
        }
    }
}
