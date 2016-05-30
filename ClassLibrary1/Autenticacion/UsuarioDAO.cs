using System.Collections.Generic;
using Model.Autenticacion;
using System.Data.OleDb;

namespace DataAcces.Autenticacion
{
    public class UsuarioDAO
    {
        public List<UsuarioBE> GetUsuariosPorNombre(string user)
        {
            string sql = "SELECT * FROM Login WHERE Usuario = '" + user + "'";
            return TratarUsuarios(sql);
        } //Busca un usuario por nombre

        public void CrearUsuario(UsuarioBE usuario) //Alta de Usuario
        {
            string query = string.Format("INSERT INTO Login (Usuario, Pass, Role, Equipo, Email) VALUES ('{0}', '{1}', '{2}', '{3}','{4}' )", usuario.NUsuario, usuario.Pass, usuario.Role, usuario.Equipo, usuario.Email);
            new ConnectionDAO().queryABM(query);
        } 

        public void ModificarUsuario(UsuarioBE usuario)
        {
            string query = string.Format("UPDATE Login SET Pass = '{0}', Role = '{1}', Email = '{2}' WHERE Usuario = '{3}'", usuario.Pass, usuario.Role, usuario.Email, usuario.NUsuario);
            new ConnectionDAO().queryABM(query);
        }
     
        public List<UsuarioBE> TratarUsuarios(string query)
        {
            List<UsuarioBE> usuarios = new List<UsuarioBE>();
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            while (dr.Read())
            {
                UsuarioBE usuario = new UsuarioBE() { NUsuario = (string)dr["Usuario"], Pass = (string)dr["Pass"], Role = (string)dr["Role"], Equipo = (string)dr["Equipo"] };
                usuarios.Add(usuario);
            }
            dr.Close();
            return usuarios;
        } //Trata las querys de los usuarios
    }
}
