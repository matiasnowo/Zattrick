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
    public class InferioresDAO
    {


        public string TraerPaisDe(string NombreDeEquipo)
        {

            string Pais = "";
            string query = string.Format("SELECT Pais FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Pais = (string)dr["Pais"];


            }
            dr.Close();

            string PaisString = "";

            PaisString = Pais;



            return PaisString;
        }


        public string TraerBandaDe(string NombreDeEquipo)
        {

            string Banda = "";
            string query = string.Format("SELECT Prs FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Banda = (string)dr["Prs"];


            }
            dr.Close();

            string BandaSTRING = "";

            BandaSTRING = Banda;



            return BandaSTRING;
        }

        public string TraerNivelDe(string NombreDeEquipo)
        {

            int Nivel = 0;
            string query = string.Format("SELECT Nivel FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Nivel = (int)dr["Nivel"];


            }
            dr.Close();

            string NivelINT = "";

            NivelINT = Nivel+"";



            return NivelINT;
        }

        public string TraerPuntosExp(string NombreDeEquipo)
        {

            int PuntosExp = 0;
            string query = string.Format("SELECT PuntosExperiencia FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                PuntosExp = (int)dr["PuntosExperiencia"];


            }
            dr.Close();

            string PexpINT = "";

            PexpINT = PuntosExp + "";



            return PexpINT;
        }

        public string TraerEdad(string NombreDeEquipo)
        {

            int Edad = 0;
            string query = string.Format("SELECT Edad FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Edad = (int)dr["Edad"];


            }
            dr.Close();

            string EdadINT = "";

            EdadINT = Edad + "";



            return EdadINT;
        }
        public string TraerRango (string NombreDeEquipo)
        {
            int RangoMayor = 0;
            int RangoMenor = 0;
            string query1 = string.Format("SELECT RangoMayor FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");
            string query2 = string.Format("SELECT RangoMenor FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr1 = new ConnectionDAO().consulta(query1);
            OleDbDataReader dr2 = new ConnectionDAO().consulta(query2);

            while (dr1.Read())
            {

                RangoMayor = (int)dr1["RangoMayor"];


            }
            dr1.Close();

            while (dr2.Read())
            {

                RangoMenor = (int)dr2["RangoMenor"];


            }
            dr2.Close();



            string RangoMenorstring = "";
            string RangoMayorstring = "";

            RangoMenorstring = RangoMenor + "";
            RangoMayorstring = RangoMayor + "";



            return "Entre " + RangoMenorstring + " y " + RangoMayor;
        }

    }

}




