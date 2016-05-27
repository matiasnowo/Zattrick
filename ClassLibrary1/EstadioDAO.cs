using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;
using System.Globalization;

namespace DataAcces
{
    public class EstadioDAO
    {


        public string TraerCapacidadDe(string NombreDeEquipo)
        {

            int CapacidadDeEstadio = 0;
            string query = string.Format("SELECT Capacidad FROM Estadios, Equipos WHERE Estadios.Nombre = Equipos.Estadio AND Equipos.Nombre= '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                CapacidadDeEstadio = (int)dr["Capacidad"];


            }
            dr.Close();

           string CapacidadINT = "";

           CapacidadINT = CapacidadDeEstadio.ToString(); // para q sea en pesos $$ "{0:c0}"



           return CapacidadINT;
        }


        public string TraerHinchadaDe(string NombreDeEquipo)
        {

            int HinchadaDeEstadio = 0;
            string query = string.Format("SELECT Hinchada FROM Estadios, Equipos WHERE Estadios.Nombre = Equipos.Estadio AND Equipos.Nombre= '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                HinchadaDeEstadio = (int)dr["Hinchada"];


            }
            dr.Close();

            string HinchadaINT = "";

            HinchadaINT = HinchadaDeEstadio.ToString(); // para q sea en pesos $$ "{0:c0}"



            return HinchadaINT;
        }

        public string TraerPopuActualDe(string NombreDeEquipo)
        {

            int PopuActualDeEstadio = 0;
            string query = string.Format("SELECT PopularidadActual FROM Estadios, Equipos WHERE Estadios.Nombre = Equipos.Estadio AND Equipos.Nombre= '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                PopuActualDeEstadio = (int)dr["PopularidadActual"];


            }
            dr.Close();

            string PopuActualINT = "";

            PopuActualINT = PopuActualDeEstadio.ToString()+"%"; // para q sea en pesos $$ "{0:c0}"



            return PopuActualINT;
        }


        public string TraerValorHistoricoDe(string NombreDeEquipo)
        {

            int ValorHistoricoDeEstadio = 0;
            string query = string.Format("SELECT PopularidadHistorica FROM Estadios, Equipos WHERE Estadios.Nombre = Equipos.Estadio AND Equipos.Nombre= '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                ValorHistoricoDeEstadio = (int)dr["PopularidadHistorica"];


            }
            dr.Close();

            string VHistoricoINT = "";

            VHistoricoINT = ValorHistoricoDeEstadio.ToString() + "%"; // para q sea en pesos $$ "{0:c0}"



            return VHistoricoINT;
        }

        public string TraerSiguientePartidoDe(string NombreDeEquipo)
        {

            int SiguientePartidoDeEstadio = 0;
            string query = string.Format("SELECT SiguientePartido FROM Estadios, Equipos WHERE Estadios.Nombre = Equipos.Estadio AND Equipos.Nombre= '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                SiguientePartidoDeEstadio = (int)dr["SiguientePartido"];


            }
            dr.Close();

            string SPartidoINT = "";

            SPartidoINT = SiguientePartidoDeEstadio.ToString() + "%"; // para q sea en pesos $$ "{0:c0}"



            return SPartidoINT;
        }







        public string TraerNombreEstadioDe(string NombreDeEquipo)
        {

            string NombreEstadio = "";
            string query = string.Format("SELECT Estadio FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                NombreEstadio = (string)dr["Estadio"];


            }
            dr.Close();

            string NombreEstadioSTRING = "";

            NombreEstadioSTRING = NombreEstadio;



            return NombreEstadioSTRING;
        }


    }

}