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


        public string GetNombreEquipoporNombreArchivo(string Archivo)
        {
            string nombrete = "";
            string query = "SELECT Nombre FROM Equipos WHERE Archivo = '" + Archivo + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                nombrete = (string)dr["Nombre"];


            }
            dr.Close();

            return nombrete;
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

        public Equipo GetEquipoPorNombre(string Nombre)
        {
            
            string query = "SELECT * FROM Equipos WHERE Nombre = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Equipo Equipazo = new Equipo();
            while (dr.Read())
            {

                Equipazo.Nivel_Instalaciones = (int)dr["Nivel_Instalaciones"];
                Equipazo.Nombre = Nombre;
                Equipazo.Archivo = (string)dr["Archivo"];
                Equipazo.Dinero = (int)dr["Dinero"];
                Equipazo.Auspiciantes = (int)dr["Auspiciantes"];
                Equipazo.Inferiores = (int)dr["Inferiores"];
                Equipazo.Estadio = (string)dr["Estadio"];
                Equipazo.Entrenador = (string)dr["Entrenador"];
                Equipazo.Categoria = (string)dr["Categoria"];
                Equipazo.Pais = (string)dr["Pais"];
                Equipazo.Fundacion = (int)dr["Fundacion"];
                Equipazo.Apodo = (string)dr["Apodo"];
                Equipazo.Rival = (string)dr["Rival"];
                Equipazo.Logo = (string)dr["Logo"];


            }
            dr.Close();

            return Equipazo;
        }


        public List<Equipo> tratarResultadoEquipo(string query)
        {
            List<Equipo> equipos = new List<Equipo>();
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            while (dr.Read())
            {
                Equipo equipo = new Equipo() { Nombre = (string)dr["Nombre"], Archivo = (string)dr["Archivo"], Logo = (string)dr["Logo"] };
                equipos.Add(equipo);
            }
            dr.Close();
            return equipos;
        }

        








    }
}
