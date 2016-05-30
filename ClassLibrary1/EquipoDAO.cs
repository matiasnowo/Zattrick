using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAcces;
using System.Data.OleDb;

namespace DataAcces
{
   public class EquipoDAO
    {

        public List<Equipo> GetEquipos()
        {
            string query = "SELECT * FROM Equipos";
            List<Equipo> equipos = tratarResultadoEquipo(query);

            return equipos;
        }

        public string GetNombreArchivoDeEquipo(string Nombre)
        {
            string archivote = "";
            string query = "SELECT Archivo FROM Equipos WHERE Nombre = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                archivote = (string)dr["Archivo"];


            }
            dr.Close();

            return archivote;
        }

        public int GetNivelInstalacionesDeEquipo(string Nombre)
        {
            int Nivel_Instalaciones = 0;
            string query = "SELECT Nivel_Instalaciones FROM Equipos WHERE Nombre = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Nivel_Instalaciones = (int)dr["Nivel_Instalaciones"];


            }
            dr.Close();

            return Nivel_Instalaciones;
        }


        public List<Equipo> tratarResultadoEquipo(string query)
        {
            List<Equipo> equipos = new List<Equipo>();
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            while (dr.Read())
            {
                Equipo equipo = new Equipo() { Nombre = (string)dr["Nombre"], Archivo = (string)dr["Archivo"] };
                equipos.Add(equipo);
            }
            dr.Close();
            return equipos;
        }

        








    }
}
