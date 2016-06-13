using DataAcces;
using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class JugadorEnPartidoDAO
    {
        public JugadorEnPartido GetFitdeJugadorEnPartidoPorIDyNombre(int ID, string nombre)
        {

            string query = "SELECT * FROM JugadorEnPartido WHERE ID_Partido = " + ID + " AND Nombre = '" + nombre + "'";

            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            JugadorEnPartido Jugadorazo = new JugadorEnPartido();

            while (dr.Read())
            {



                Jugadorazo.Fit = (int)dr["Fit"];





            }

            dr.Close();




            return Jugadorazo;
        }

    }
}
