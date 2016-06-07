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
    public class FinanzasDAO
    {


        public string TraerDineroDe(string NombreDeEquipo)
        {

            int DineroDeEquipo = 0;
            string query = string.Format("SELECT Dinero FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                DineroDeEquipo = (int)dr["Dinero"];


            }
            dr.Close();

           string DinerINT = "";

           DinerINT = String.Format(new CultureInfo("es-AR" , false), "{0:c0}", DineroDeEquipo);



             return DinerINT;
        }


       

        public string TraerAuspiciantesDe(string NombreDeEquipo)
        {

            int AuspicianteDeEquipo = 0;
            string query = string.Format("SELECT Auspiciantes FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                AuspicianteDeEquipo = (int)dr["Auspiciantes"];


            }
            dr.Close();

            string AuspiciaINT = "";

            AuspiciaINT = String.Format(new CultureInfo("es-AR", false), "{0:c0}", AuspicianteDeEquipo);



            return AuspiciaINT;
        }

        public string TraerManutencion(string NombreDeEquipo)
        {

            string Estadio = "";
            int Capacidad = 0;
            int ResultadoFinal = 0;
            string query = string.Format("SELECT Estadio FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");
            OleDbDataReader dr = new ConnectionDAO().consulta(query);


            while (dr.Read())
            {

                Estadio = (string)dr["Estadio"];

            }
            dr.Close();


            string queryestadio = string.Format("SELECT * FROM Estadios WHERE Nombre = '" + Estadio + "'");
            OleDbDataReader drestadio = new ConnectionDAO().consulta(queryestadio);

            while (drestadio.Read())
            {


                Capacidad = (int)drestadio["Capacidad"];


            }
            drestadio.Close();


            ResultadoFinal = Capacidad;


            if (15000 < Capacidad && Capacidad < 25001)
            {

                ResultadoFinal = ResultadoFinal + (ResultadoFinal / 2);
            }

            if (25000 < Capacidad && Capacidad < 40001)
            {

                ResultadoFinal = ResultadoFinal + ResultadoFinal;
            }

            if (40000 < Capacidad && Capacidad < 55001)
            {

                ResultadoFinal = ResultadoFinal + ResultadoFinal + (ResultadoFinal / 2);
            }

            if (55000 < Capacidad && Capacidad < 80001)
            {

                ResultadoFinal = ResultadoFinal + ResultadoFinal + ResultadoFinal;
            }

            if (80000 < Capacidad)
            {

                ResultadoFinal = ResultadoFinal + ResultadoFinal + ResultadoFinal + (ResultadoFinal / 2);
            }

            string CapacidadINT = "";

            CapacidadINT = String.Format(new CultureInfo("es-AR", false), "{0:c0}", ResultadoFinal);



            return CapacidadINT;
        }

        public string TraerGananciaSiLlena(string NombreDeEquipo)
        {

            string Estadio = "";
            string Categoria = "";
            int Capacidad = 0;
            int ResultadoFinal = 0;
            string query = string.Format("SELECT * FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Estadio = (string)dr["Estadio"];
                Categoria = (string)dr["Categoria"];

            }
            dr.Close();


            string queryestadio = string.Format("SELECT * FROM Estadios WHERE Nombre = '" + Estadio + "'");
            OleDbDataReader drestadio = new ConnectionDAO().consulta(queryestadio);

            while (drestadio.Read())
            {
            Capacidad = (int)drestadio["Capacidad"];
  }
            drestadio.Close();

            ResultadoFinal = Capacidad * 5;

            if (Categoria == "Primera Division")
            {

                ResultadoFinal = Capacidad * 10;

            }





            string CapacidadINT = "";

            CapacidadINT = String.Format(new CultureInfo("es-AR", false), "{0:c0}", ResultadoFinal);



            return CapacidadINT;
        }


        public string TraerPagodeInferiores(string NombreDeEquipo)
        {

            int Inferiores = 0;
            int Nivel_Inferiores = 0;

            string query1 = string.Format("SELECT * FROM Inferiores WHERE Equipo = '" + NombreDeEquipo + "'");

            string query2 = string.Format("SELECT * FROM Equipos WHERE Nombre = '" + NombreDeEquipo + "'");
            OleDbDataReader dr1 = new ConnectionDAO().consulta(query1);
            OleDbDataReader dr2 = new ConnectionDAO().consulta(query2);

            while (dr1.Read())
            {

                Inferiores = (int)dr1["Costo_Mantenimiento"];

            }
            dr1.Close();

            while (dr2.Read())
            {

                Nivel_Inferiores = (int)dr2["Inferiores"];

            }
            dr2.Close();




            string InferioresINT = Nivel_Inferiores + " + " + Inferiores;

            InferioresINT = String.Format(new CultureInfo("es-AR", false), "{0:c0}", Nivel_Inferiores + " + " + Inferiores);



            return InferioresINT;
        }

        public List<EventoDefinido> TraerListadeEventosFinanzas(string NombreDeEquipo)
        {
            
            List<EventoDefinido> EventsDefined = new List<EventoDefinido>();
            List<Evento> Events = new List<Evento>();
            DateTime aFecha = new DateTime();
            string aEquipoa = "";
            string aJugadora = "";
            int aCantidad = 0;
            string aEquipo2 = "";
            bool aActualizado = false;
            string TextodeEvento = "";

            List<string> TypeEvents = new List<string>();
            int aTipo = 0;


            string query1 = string.Format("SELECT * FROM TipoDeEventos WHERE Tipo = 'Finanzas' ORDER BY ID");
            OleDbDataReader dr1 = new ConnectionDAO().consulta(query1);

            while (dr1.Read())
            {
                TextodeEvento = (string)dr1["Texto"];

                TypeEvents.Add(TextodeEvento);
            }



            string query = string.Format("SELECT * FROM Eventos WHERE Equipo = '" + NombreDeEquipo + "'");
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {


                aTipo = (int)dr["Tipo"];
                aFecha = (DateTime)dr["Fecha"];
                aEquipoa = (string)dr["Equipo"];
                aJugadora = (string)dr["Jugador"];
                aCantidad = (int)dr["Cantidad"];
                aEquipo2 = (string)dr["Equipo2"];
                aActualizado = (bool)dr["Actualizado"];


                Events.Add(new Evento() { Tipo = aTipo - 1, Fecha = aFecha, Equipo = aEquipoa, Jugador = aJugadora, Cantidad = aCantidad, Equipo2 = aEquipo2, Actualizado = aActualizado });


            }
            Events.Reverse();
            dr.Close();

            List<string> Eventoslimpios = new List<string>();
            for (int a = 0; a < Events.Count; a++)
            {
                for (int b = 0; b < TypeEvents.Count; b++)
            { 
               if (b == Events[a].Tipo){

                   string NuevaCantidad = String.Format(new CultureInfo("es-AR", false), "{0:c0}", Events[a].Cantidad);

                   string textofevent = TypeEvents[b].Replace("DINERO", NuevaCantidad);

  
                   textofevent = textofevent.Replace("JUGADOR", Events[a].Jugador);

                string definitivo = Events[a].Fecha + " - " + textofevent;

                definitivo = definitivo.Replace(" 00:00:00", "");

                Eventoslimpios.Add(definitivo);

               }}}

            for (int a = 0; a < Eventoslimpios.Count; a++)
            {


               
                EventsDefined.Add(new EventoDefinido() { Texto = Eventoslimpios[a], ID = a });






            }



            return EventsDefined;
        }
    }

}




