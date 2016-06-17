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
                Jugadorazo.Equipo = (string)dr["Equipo"];
                Jugadorazo.Position = (string)dr["Position"];
                Jugadorazo.Prs = (string)dr["Prs"];
                Jugadorazo.St = (int)dr["St"];
                Jugadorazo.Tk = (int)dr["Tk"];
                Jugadorazo.Ps = (int)dr["Ps"];
                Jugadorazo.Sh = (int)dr["Sh"];
                Jugadorazo.Sm = (int)dr["Sm"];
                Jugadorazo.Kab = (int)dr["Kab"];
                Jugadorazo.Tab = (int)dr["Tab"];
                Jugadorazo.Pab = (int)dr["Pab"];
                Jugadorazo.Sab = (int)dr["Sab"];
                Jugadorazo.Min = (int)dr["Min"];
                Jugadorazo.Sav = (int)dr["Sav"];
                Jugadorazo.Ktk = (int)dr["Ktk"];
                Jugadorazo.Kps = (int)dr["Kps"];
                Jugadorazo.Sht = (int)dr["Sht"];
                Jugadorazo.Gls = (int)dr["Gls"];
                Jugadorazo.Ass = (int)dr["Ass"];
                Jugadorazo.Yel = (int)dr["Yel"];
                Jugadorazo.Red = (int)dr["Red"];
                Jugadorazo.Inj = (int)dr["Inj"];
                Jugadorazo.Yel = (int)dr["Yel"];
                Jugadorazo.Red = (int)dr["Red"];
                Jugadorazo.Inj = (int)dr["Inj"];




            }

            dr.Close();




            return Jugadorazo;
        }

    }
}
