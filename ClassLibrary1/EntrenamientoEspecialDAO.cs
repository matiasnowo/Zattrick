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
   public class EntrenamientoEspecialDAO
    {

         public EntrenamientoEspecial GetEntrenamientoEspecialDeJugadorPorEquipo(string Nombre)
        {
            string Jugador = "";
            string Equipo = "";
            string BandaNueva = "";
            DateTime FechaInicio = new DateTime(); 
            DateTime FechaFin = new DateTime(); 
            string query = "SELECT * FROM EntrenamientoEspecial WHERE Equipo = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            EntrenamientoEspecial EE = new EntrenamientoEspecial();

            while (dr.Read())
            {

                Jugador = (string)dr["Jugador"];
                Equipo = (string)dr["Equipo"];
                BandaNueva = (string)dr["BandaNueva"];
                FechaInicio = (DateTime)dr["FechaInicio"];
                FechaFin = (DateTime)dr["FechaFin"];


            }
            dr.Close();

            EE.Jugador = Jugador;
            EE.Equipo = Equipo;
            EE.BandaNueva = BandaNueva;
            EE.Jugador = Jugador;
            EE.FechaInicio = FechaInicio;
            EE.FechaFin = FechaFin;

            return EE;
        }
        public void SetEntrenamientoEspecialDeJugador(string Jugador, string Equipo, string BandaNueva, DateTime FechaInicio, DateTime FechaFin)
        {
            

            string query = "INSERT INTO EntrenamientoEspecial (Jugador, Equipo, BandaNueva, FechaInicio, FechaFin) VALUES ('"+Jugador+"', '"+ Equipo+ "', '" + BandaNueva + "', '" + FechaInicio.ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "', '" + FechaFin.ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "')";

         //   string query = string.Format("INSERT INTO Login (Usuario, Pass, Role, Email) VALUES ('{0}', '{1}', '{2}', '{3}' )", user.NUsuario, user.Pass, user.Role, user.Email);

          new ConnectionDAO().queryABM(query);
            //    INSERT INTO table_name(column1, column2, column3,...)
            //           VALUES(value1, value2, value3,...);

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
