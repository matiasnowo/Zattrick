using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Configuration;
using AppWeb.Session;
using DataAcces;


namespace AppWeb.DataAccess
{
    public class AutentificationDAO
    {
        //Tratamiento del DataReader de Usuario
        public List<Usuario> tratarResultadoUsuarios(string query)
        {
            List<Usuario> usuarios = new List<Usuario>();
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            while (dr.Read())
            {
                Usuario usuario = new Usuario() { NUsuario = (string)dr["Usuario"], Pass = (string)dr["Pass"], Role = (string)dr["Role"], Equipo = (string)dr["Equipo"] };
                usuarios.Add(usuario);
            }
            dr.Close();
            return usuarios;
        }



        public List<Usuario> Autenticar(string usuario, string password)
        {
            //consulta a la base de datos
            string sql = string.Format("SELECT * FROM Login WHERE Usuario = '{0}' AND Pass = '{1}' ", usuario, password);
            return tratarResultadoUsuarios(sql);
        }

        public List<Usuario> GetUsuario(string user)
        {


            
                   //consulta a la base de datoss
                string sql = "SELECT * FROM Login WHERE Usuario = '" + user + "'";
            

                return tratarResultadoUsuarios(sql);

           
        }

        public void nuevoUsuario(Usuario user)
        {

            string query = string.Format("INSERT INTO Login (Usuario, Pass, Role, Email) VALUES ('{0}', '{1}', '{2}', '{3}' )", user.NUsuario, user.Pass, user.Role, user.Email);

            new ConnectionDAO().queryABM(query);
        }

        public void cambiarpwdUsuario(Usuario user)
        {

            string query = string.Format("UPDATE Login SET Pass = '{0}', Role = '{1}', Email = '{2}' WHERE Usuario = '{3}'", user.Pass, user.Role, user.Email, user.NUsuario);
  new ConnectionDAO().queryABM(query);
        }


    }
}
