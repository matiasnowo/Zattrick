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
   public class PartidoDAO
    {

  

        public Partido GetPartidoPorLocal(string Nombre)
        {
            
            string query = "SELECT * FROM Partidos WHERE EquipoLocal = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Partido Partidazo = new Partido();
            while (dr.Read())
            {

                Partidazo.Fecha = (DateTime)dr["Fecha"];
                Partidazo.EquipoLocal = Nombre;
                Partidazo.EquipoVisitante = (string)dr["EquipoVisitante"];
                Partidazo.ArchivoPartido = (string)dr["ArchivoPartido"];
                Partidazo.ResultadoLocal = (int)dr["ResultadoLocal"];
                Partidazo.ResultadoVisitante = (int)dr["ResultadoVisitante"];
                Partidazo.Competencia = (string)dr["Competencia"];
                Partidazo.Temporada = (int)dr["Temporada"];


            }
            dr.Close();

            return Partidazo;
        }


        public Partido GetPartidoPorVisitante(string Nombre)
        {

            string query = "SELECT * FROM Partidos WHERE EquipoVisitante = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Partido Partidazo = new Partido();
            while (dr.Read())
            {

                Partidazo.Fecha = (DateTime)dr["Fecha"];
                Partidazo.EquipoLocal = (string)dr["EquipoLocal"];
                Partidazo.EquipoVisitante = Nombre;
                Partidazo.ArchivoPartido = (string)dr["ArchivoPartido"];
                Partidazo.ResultadoLocal = (int)dr["ResultadoLocal"];
                Partidazo.ResultadoVisitante = (int)dr["ResultadoVisitante"];
                Partidazo.Competencia = (string)dr["Competencia"];
                Partidazo.Temporada = (int)dr["Temporada"];


            }
            dr.Close();

            return Partidazo;
        }










    }
}
