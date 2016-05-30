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
   public class EntrenadorDAO
    {

         public Entrenador GetEntrenadorPorEquipo(string Nombre)
        {
            string NombEnt = "";
            string Especialidad = "";
            int Edad = 0;
            int Nivel = 0;
            int Sueldo = 0;

            string query = "SELECT Entrenadores.Nombre, Entrenadores.Edad, Entrenadores.Nivel, Entrenadores.Sueldo, Entrenadores.Especialidad FROM Entrenadores, Equipos WHERE Equipos.Entrenador = Entrenadores.Nombre AND Equipos.Nombre = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Entrenador E = new Entrenador();

            while (dr.Read())
            {

                NombEnt = (string)dr["Nombre"];
                Especialidad = (string)dr["Especialidad"];
                Edad = (int)dr["Edad"];
                Nivel = (int)dr["Nivel"];
                Sueldo = (int)dr["Sueldo"];


            }
            dr.Close();

            E.Nombre = NombEnt;
            E.Especialidad = Especialidad;
            E.Edad = Edad;
            E.Nivel = Nivel;
            E.Sueldo = Sueldo;

            return E;
        }
      
        


    }
}
