﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace DataAcces
{
    public class JugadorDAO
    {

      

        public Jugador TraerJugador(string NombreDeJugador)
        {

            Jugador JugadorTraido = new Jugador();

            string query = string.Format("SELECT * FROM jugadores WHERE NAME = '" + NombreDeJugador + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

            Jugador JugadorA = new Jugador() { Name = (string)dr["Name"], Age = (int)dr["Age"], Equipo = (string)dr["Equipo"], Nat = (string)dr["Nat"], Prs = (string)dr["Prs"], St = (int)dr["St"], Tk = (int)dr["Tk"], Ps = (int)dr["Ps"], Sh = (int)dr["Sh"], Sm = (int)dr["Sm"], Ag = (int)dr["Ag"], Kab = (int)dr["Kab"], Tab = (int)dr["Tab"], Pab = (int)dr["Pab"], Sab = (int)dr["Sab"], Gam = (int)dr["Gam"], Sav = (int)dr["Sav"], Ktk = (int)dr["Ktk"], Kps = (int)dr["Kps"], Sht = (int)dr["Sht"], Gls = (int)dr["Gls"], Ass = (int)dr["Ass"], DP = (int)dr["DP"], Inj = (int)dr["Inj"], Sus = (int)dr["Sus"], Fit = (int)dr["Fit"] };

                JugadorTraido = JugadorA;

            }
            dr.Close(); dr.Dispose();

            

            return JugadorTraido;
        }

        public Jugador TraerJugadorDeEquipoEspecifico(string NombreDeJugador, string DeQueEquipo)
        {

            Jugador JugadorTraido = new Jugador();

            string query = string.Format("SELECT * FROM jugadores WHERE Equipo = '" + DeQueEquipo + "' AND NAME = '" + NombreDeJugador + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Jugador JugadorA = new Jugador() { Name = (string)dr["Name"], Age = (int)dr["Age"], Equipo = (string)dr["Equipo"], Nat = (string)dr["Nat"], Prs = (string)dr["Prs"], St = (int)dr["St"], Tk = (int)dr["Tk"], Ps = (int)dr["Ps"], Sh = (int)dr["Sh"], Sm = (int)dr["Sm"], Ag = (int)dr["Ag"], Kab = (int)dr["Kab"], Tab = (int)dr["Tab"], Pab = (int)dr["Pab"], Sab = (int)dr["Sab"], Gam = (int)dr["Gam"], Sav = (int)dr["Sav"], Ktk = (int)dr["Ktk"], Kps = (int)dr["Kps"], Sht = (int)dr["Sht"], Gls = (int)dr["Gls"], Ass = (int)dr["Ass"], DP = (int)dr["DP"], Inj = (int)dr["Inj"], Sus = (int)dr["Sus"], Fit = (int)dr["Fit"] };

                JugadorTraido = JugadorA;

            }
            dr.Close(); dr.Dispose();



            return JugadorTraido;
        }

     


        public void ModificarJugador(Jugador jugador)
        {

            
            string query = string.Format
                ("UPDATE jugadores SET Age={1}, Nat='{2}', Prs='{3}', St={4}, Tk={5}, Ps={6}, Sh={7}, Sm={8}, Ag={9}, Kab={10}, Tab={11}, Pab={12}, Sab={13}, Gam={14}, Sav={15}, Ktk={16}, Kps={17}, Sht={18}, Gls={19}, Ass={20}, DP={21}, Inj={22}, Sus={23}, Fit={24}, Equipo='{25}' WHERE Name = '{0}'", jugador.Name, jugador.Age, jugador.Nat, jugador.Prs, jugador.St, jugador.Tk, jugador.Ps, jugador.Sh, jugador.Sm, jugador.Ag, jugador.Kab, jugador.Tab, jugador.Pab, jugador.Sab, jugador.Gam, jugador.Sav, jugador.Ktk, jugador.Kps, jugador.Sht, jugador.Gls, jugador.Ass, jugador.DP, jugador.Inj, jugador.Sus, jugador.Fit, jugador.Equipo);


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit
            new ConnectionDAO().queryABM(query);
        }

        public void CrearJugador(Jugador jugador, string Equipo)
        {

            string query = string.Format
           ("INSERT INTO jugadores VALUES ('{25}', '{0}', {1}, '{2}', '{3}', {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24})", jugador.Name, jugador.Age, jugador.Nat, jugador.Prs, jugador.St, jugador.Tk, jugador.Ps, jugador.Sh, jugador.Sm, jugador.Ag, jugador.Kab, jugador.Tab, jugador.Pab, jugador.Sab, jugador.Gam, jugador.Sav, jugador.Ktk, jugador.Kps, jugador.Sht, jugador.Gls, jugador.Ass, jugador.DP, jugador.Inj, jugador.Sus, jugador.Fit, Equipo);


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit
            new ConnectionDAO().queryABM(query);
        }

        public List<Jugador> ListadeJugadores()
        {

            List<Jugador> Jugadores = new List<Jugador>();

            string query = string.Format("SELECT * FROM jugadores'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {

                Jugador juego = new Jugador() { Name = (string)dr["Name"], Age = (int)dr["Age"], Equipo = (string)dr["Equipo"], Nat = (string)dr["Nat"], Prs = (string)dr["Prs"], St = (int)dr["St"], Tk = (int)dr["Tk"], Ps = (int)dr["Ps"], Sh = (int)dr["Sh"], Sm = (int)dr["Sm"], Ag = (int)dr["Ag"], Kab = (int)dr["Kab"], Tab = (int)dr["Tab"], Pab = (int)dr["Pab"], Sab = (int)dr["Sab"], Gam = (int)dr["Gam"], Sav = (int)dr["Sav"], Ktk = (int)dr["Ktk"], Kps = (int)dr["Kps"], Sht = (int)dr["Sht"], Gls = (int)dr["Gls"], Ass = (int)dr["Ass"], DP = (int)dr["DP"], Inj = (int)dr["Inj"], Sus = (int)dr["Sus"], Fit = (int)dr["Fit"] };

                Jugadores.Add(juego);


            }
 dr.Close(); dr.Dispose();
  return Jugadores;
        }

        

        public List<string> ListanombresJugadores(){

            DataAcces.JugadorDAO cnd = new DataAcces.JugadorDAO();
            List<Jugador> ListaJugadores = ListadeJugadores();
            List<string> ListanombresdeJugadores = new List<string>();

            for (int v = 0; v < ListaJugadores.Count; v++)
                {
                    ListanombresdeJugadores.Add(ListaJugadores[v].Name);
                }
            return ListanombresdeJugadores;

        }

        public void ActualizarBasedeDatos()
        {

            Model.Jugador player = new Model.Jugador();
            DataAcces.EquipoDAO team = new EquipoDAO();
            List<Equipo> teams = new List<Equipo>();

            for (int i = 0; i < team.GetEquipos().Count; i++)
            {
                teams.Add(team.GetEquipos().ElementAt(i));
                int counter = 0;
                string line;
                string row = "";

             //Notebook //
           //  System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams.ElementAt(i).Archivo, System.Text.Encoding.Default, false);
                                                                   
             // Casa PC //  
             System.IO.StreamReader file = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + teams.ElementAt(i).Archivo, System.Text.Encoding.Default, false);
                                                                       
                DataAcces.JugadorDAO cnd = new DataAcces.JugadorDAO();

                
                List<string> ListanombresdeJugadores = ListanombresJugadores();

               

                while ((line = file.ReadLine()) != null)
                {
                    row = line;
                    if (counter > 1 && row != "")
                    {
                        string nombre;
                        player.Equipo = teams.ElementAt(i).Nombre;
                        player.Name = row.Substring(0, 13).Trim(); // PROBLEMA CON APOSTROFES
                        nombre = player.Name;
                        player.Age = Convert.ToInt32(row.Substring(14, 3).Trim());
                        player.Nat = row.Substring(17, 3).Trim();
                        player.Prs = row.Substring(21, 3).Trim();
                        player.St = Convert.ToInt32(row.Substring(25, 3).Trim());
                        player.Tk = Convert.ToInt32(row.Substring(28, 3).Trim());
                        player.Ps = Convert.ToInt32(row.Substring(31, 3).Trim());
                        player.Sh = Convert.ToInt32(row.Substring(34, 3).Trim());
                        player.Sm = Convert.ToInt32(row.Substring(37, 3).Trim());
                        player.Ag = Convert.ToInt32(row.Substring(40, 3).Trim());
                        player.Kab = Convert.ToInt32(row.Substring(43, 4).Trim());
                        player.Tab = Convert.ToInt32(row.Substring(47, 4).Trim());
                        player.Pab = Convert.ToInt32(row.Substring(51, 4).Trim());
                        player.Sab = Convert.ToInt32(row.Substring(54, 4).Trim());
                        player.Gam = Convert.ToInt32(row.Substring(60, 3).Trim());
                        player.Sav = Convert.ToInt32(row.Substring(64, 3).Trim());
                        player.Ktk = Convert.ToInt32(row.Substring(68, 3).Trim());
                        player.Kps = Convert.ToInt32(row.Substring(72, 3).Trim());
                        player.Sht = Convert.ToInt32(row.Substring(76, 3).Trim());
                        player.Gls = Convert.ToInt32(row.Substring(80, 3).Trim());
                        player.Ass = Convert.ToInt32(row.Substring(84, 3).Trim());
                        player.DP = Convert.ToInt32(row.Substring(88, 3).Trim());
                        player.Inj = Convert.ToInt32(row.Substring(92, 3).Trim());
                        player.Sus = Convert.ToInt32(row.Substring(96, 3).Trim());
                        player.Fit = Convert.ToInt32(row.Substring(99, 3).Trim());

                        if (ListanombresdeJugadores.Contains(player.Name))
                        {
                            nombre = nombre.Replace("'", "''");// NO FUNCIONA
                            player.Name = nombre;
                            cnd.ModificarJugador(player);
                        }
                        else
                        {
                            nombre = nombre.Replace("'", "''");// NO FUNCIONA
                            player.Name = nombre;
                            cnd.CrearJugador(player, teams.ElementAt(i).Nombre);
                        }

                    } counter++;

                }
                file.Close();
            }
        }



        public void ActualizarTodoslosTxt()
        {
            DataAcces.JugadorDAO cnd = new DataAcces.JugadorDAO();

            List<Jugador> ListaJugadores = cnd.ListadeJugadores();
            List<string> ListadeNombresPlayers = cnd.ListanombresJugadores();

            EquipoDAO team = new EquipoDAO();
            List<Equipo> teams = new List<Equipo>();

            teams = team.GetEquipos();

            List<string> ListaFINALdeLineas = new List<string>();

             for (int j = 0; j < teams.Count; j++)
            {
                ListaFINALdeLineas.Clear();
                ListaFINALdeLineas.Add("Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit");
                ListaFINALdeLineas.Add("------------------------------------------------------------------------------------------------------");
          
                for (int v = 0; v < ListaJugadores.Count; v++)
                {
                    Jugador Player = ListaJugadores[v];
                    if (teams[j].Nombre == Player.Equipo)
                    {

                        string NuevaLinea = ArmarLinea(Player);
                        ListaFINALdeLineas.Add(NuevaLinea);
                    }
                }

                string[] lines = new string[ListaFINALdeLineas.Count];

                for (int h = 0; h < ListaFINALdeLineas.Count; h++)
                {
                    lines[h] = ListaFINALdeLineas.ElementAt(h);

                }
                //Notebook //
             //   System.IO.File.WriteAllLines("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams[j].Archivo, lines, System.Text.Encoding.Default);
                // Casa PC //  
              System.IO.File.WriteAllLines(System.AppDomain.CurrentDomain.BaseDirectory + teams[j].Archivo, lines, System.Text.Encoding.Default);
              
  
            }
        }


        public void ActualizarTxtdeEquipo(Equipo TEAM)
        {
            DataAcces.JugadorDAO cnd = new DataAcces.JugadorDAO();

            List<Jugador> ListaJugadores = cnd.ListadeJugadores();
            List<string> ListadeNombresPlayers = cnd.ListanombresJugadores();

           
            List<string> ListaFINALdeLineas = new List<string>();

                ListaFINALdeLineas.Clear();
                ListaFINALdeLineas.Add("Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit");
                ListaFINALdeLineas.Add("------------------------------------------------------------------------------------------------------");

                for (int v = 0; v < ListaJugadores.Count; v++)
                {
                    Jugador Player = ListaJugadores[v];
                    if (TEAM.Nombre == Player.Equipo)
                    {

                        string NuevaLinea = ArmarLinea(Player);
                        ListaFINALdeLineas.Add(NuevaLinea);
                    }
                }

                string[] lines = new string[ListaFINALdeLineas.Count];

                for (int h = 0; h < ListaFINALdeLineas.Count; h++)
                {
                    lines[h] = ListaFINALdeLineas.ElementAt(h);

                }
                //Notebook //
              // System.IO.File.WriteAllLines("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + TEAM.Archivo, lines, System.Text.Encoding.Default);
            // Casa PC // 
            System.IO.File.WriteAllLines(System.AppDomain.CurrentDomain.BaseDirectory + TEAM.Archivo, lines, System.Text.Encoding.Default);









            //  System.IO.File.WriteAllLines("C:\\Users\\matia\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams[j].Archivo, lines, System.Text.Encoding.Default);



        }


        public string ArmarLinea(Jugador Player){


                                             string NuevaLinea;
                                            string Name = string.Format("{0,-14}", Player.Name);
                                            string Age = string.Format("{0,-3}", Player.Age);
                                            string Nat = string.Format("{0,-3}", Player.Nat);
                                            string Prs = string.Format("{0,4}", Player.Prs);
                                            string St = string.Format("{0,3}", Player.St);
                                            string Tk = string.Format("{0,3}", Player.Tk);
                                            string Ps = string.Format("{0,3}", Player.Ps);
                                            string Sh = string.Format("{0,3}", Player.Sh);
                                            string Sm = string.Format("{0,3}", Player.Sm);
                                            string Ag = string.Format("{0,3}", Player.Ag);
                                            string Kab = string.Format("{0,4}", Player.Kab);
                                            string Tab = string.Format("{0,4}", Player.Tab);
                                            string Pab = string.Format("{0,4}", Player.Pab);
                                            string Sab = string.Format("{0,4}", Player.Sab);
                                            string Gam = string.Format("{0,4}", Player.Gam);
                                            string Sav = string.Format("{0,4}", Player.Sav);
                                            string Ktk = string.Format("{0,4}", Player.Ktk);
                                            string Kps = string.Format("{0,4}", Player.Kps);
                                            string Sht = string.Format("{0,4}", Player.Sht);
                                            string Gls = string.Format("{0,4}", Player.Gls);
                                            string Ass = string.Format("{0,4}", Player.Ass);
                                            string DP = string.Format("{0,4}", Player.DP);
                                            string Inj = string.Format("{0,4}", Player.Inj);
                                            string Sus = string.Format("{0,4}", Player.Sus);
                                            string Fit = string.Format("{0,4}", Player.Fit);





                                            NuevaLinea = Name + Age + Nat + Prs + St + Tk + Ps + Sh + Sm + Ag + Kab + Tab + Pab + Sab + Gam + Sav + Ktk + Kps + Sht + Gls + Ass + DP + Inj + Sus + Fit;
            return NuevaLinea;
        }



        public List<Jugador> MejoresJugadoresDeEquipo(string Equipo)
        {

            Jugador JugadorTraido = new Jugador();
            List<Jugador> ListaDeJugadores = new List<Jugador>();
            string query = string.Format("SELECT * FROM jugadores WHERE Equipo = '" + Equipo + "'");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {


                Jugador JugadorA = new Jugador() { Name = (string)dr["Name"], Age = (int)dr["Age"], Equipo = (string)dr["Equipo"], Nat = (string)dr["Nat"], Prs = (string)dr["Prs"], St = (int)dr["St"], Tk = (int)dr["Tk"], Ps = (int)dr["Ps"], Sh = (int)dr["Sh"], Sm = (int)dr["Sm"], Ag = (int)dr["Ag"], Kab = (int)dr["Kab"], Tab = (int)dr["Tab"], Pab = (int)dr["Pab"], Sab = (int)dr["Sab"], Gam = (int)dr["Gam"], Sav = (int)dr["Sav"], Ktk = (int)dr["Ktk"], Kps = (int)dr["Kps"], Sht = (int)dr["Sht"], Gls = (int)dr["Gls"], Ass = (int)dr["Ass"], DP = (int)dr["DP"], Inj = (int)dr["Inj"], Sus = (int)dr["Sus"], Fit = (int)dr["Fit"] };

                int[] numbers = new int[] { JugadorA.St, JugadorA.Tk, JugadorA.Ps, JugadorA.Sh };
                int maximumNumber = numbers.Max();
                Double ValorStar = 0;

                int bandas = JugadorA.Prs.Count();

                if (maximumNumber == JugadorA.St)
                {
                    ValorStar = JugadorA.St;
                }
                if (maximumNumber == JugadorA.Tk)
                {

                    ValorStar = (JugadorA.Tk + (bandas * 5) + (JugadorA.Ps * 0.4) + (JugadorA.Sh * 0.2) + (JugadorA.Sm * 0.2)) / 2.1;


                }
                if (maximumNumber == JugadorA.Ps)
                {

                    ValorStar = (JugadorA.Ps + (bandas * 5) + (JugadorA.Tk * 0.4) + (JugadorA.Sh * 0.4) + (JugadorA.Sm * 0.2)) / 2.3;

                }
                if (maximumNumber == JugadorA.Sh)
                {

                    ValorStar = (JugadorA.Sh + (bandas * 5) + (JugadorA.Tk * 0.2) + (JugadorA.Ps * 0.4) + (JugadorA.Sm * 0.4)) / 2.5;

                }




                JugadorA.ValorStar = ValorStar;


                ListaDeJugadores.Add(JugadorA);



            }

            ListaDeJugadores = Sorted5Objects(ListaDeJugadores);

            dr.Close(); dr.Dispose();



            return ListaDeJugadores;
        }


        public List<Jugador> MejoresJugadoresDeCompetencia(string Competencia)
        {

            Jugador JugadorTraido = new Jugador();
            List<Jugador> ListaDeJugadores = new List<Jugador>();
            string query = string.Format("SELECT * FROM jugadores, Equipos WHERE Categoria = '" + Competencia + "'  AND Jugadores.Equipo = Equipos.Nombre");


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit


            OleDbDataReader dr = new ConnectionDAO().consulta(query);

            while (dr.Read())
            {


                Jugador JugadorA = new Jugador() { Name = (string)dr["Name"], Age = (int)dr["Age"], Equipo = (string)dr["Equipo"], Nat = (string)dr["Nat"], Prs = (string)dr["Prs"], St = (int)dr["St"], Tk = (int)dr["Tk"], Ps = (int)dr["Ps"], Sh = (int)dr["Sh"], Sm = (int)dr["Sm"], Ag = (int)dr["Ag"], Kab = (int)dr["Kab"], Tab = (int)dr["Tab"], Pab = (int)dr["Pab"], Sab = (int)dr["Sab"], Gam = (int)dr["Gam"], Sav = (int)dr["Sav"], Ktk = (int)dr["Ktk"], Kps = (int)dr["Kps"], Sht = (int)dr["Sht"], Gls = (int)dr["Gls"], Ass = (int)dr["Ass"], DP = (int)dr["DP"], Inj = (int)dr["Inj"], Sus = (int)dr["Sus"], Fit = (int)dr["Fit"] };

                int[] numbers = new int[] { JugadorA.St, JugadorA.Tk, JugadorA.Ps, JugadorA.Sh };
                int maximumNumber = numbers.Max();
                Double ValorStar = 0;

                int bandas = JugadorA.Prs.Count();

                if (maximumNumber == JugadorA.St)
                {
                    ValorStar = JugadorA.St;
                }
                if (maximumNumber == JugadorA.Tk)
                {

                    ValorStar = (JugadorA.Tk + (bandas * 5) + (JugadorA.Ps * 0.4) + (JugadorA.Sh * 0.2) + (JugadorA.Sm * 0.2)) / 2.1;


                }
                if (maximumNumber == JugadorA.Ps)
                {

                    ValorStar = (JugadorA.Ps + (bandas * 5) + (JugadorA.Tk * 0.4) + (JugadorA.Sh * 0.4) + (JugadorA.Sm * 0.2)) / 2.3;

                }
                if (maximumNumber == JugadorA.Sh)
                {

                    ValorStar = (JugadorA.Sh + (bandas * 5) + (JugadorA.Tk * 0.2) + (JugadorA.Ps * 0.4) + (JugadorA.Sm * 0.4)) / 2.5;

                }




                JugadorA.ValorStar = ValorStar;


                ListaDeJugadores.Add(JugadorA);



            }

            ListaDeJugadores = Sorted10Objects(ListaDeJugadores);

            dr.Close(); dr.Dispose();


            return ListaDeJugadores;
        }

            public List<Jugador> GoleadoresDeCompetencia(string Competencia, int Temporada, string Fase)
            {

                Jugador JugadorTraido = new Jugador();
                List<Jugador> ListaDeJugadores = new List<Jugador>();
            if (Temporada == 0)
            {

                TemporadaActualDAO TA = new TemporadaActualDAO();
                Temporada = TA.GetTemporadaActual();
            }
            string query = "";

            if (Fase == null) {
                query = string.Format("SELECT Jugadores.Equipo, JugadorEnPartido.Jugador, JugadorEnPartido.Gls FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido), Jugadores, Equipos WHERE (Equipos.Nombre = Jugadores.Equipo AND Jugadores.Name = JugadorEnPartido.Jugador AND Partidos.TEMPORADA = " + Temporada + " AND Partidos.Competencia = '" + Competencia + "')");

            }

            if (Fase != null)
            {
                query = string.Format("SELECT Jugadores.Equipo, JugadorEnPartido.Jugador, JugadorEnPartido.Gls FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido), Jugadores, Equipos WHERE (Equipos.Nombre = Jugadores.Equipo AND Jugadores.Name = JugadorEnPartido.Jugador AND Partidos.fase = '" + Fase + "' AND Partidos.TEMPORADA = " + Temporada + " AND Partidos.Competencia = '" + Competencia + "')");
            }

            OleDbDataReader dr = new ConnectionDAO().consulta(query);

                while (dr.Read())
                {


                    Jugador JugadorA = new Jugador() { Name = (string)dr["Jugador"], Gls = (int)dr["Gls"], Equipo = (string)dr["Equipo"]};

                  ListaDeJugadores.Add(JugadorA);



                }

                ListaDeJugadores = SortGoleadores(ListaDeJugadores);

                dr.Close(); dr.Dispose();



                return ListaDeJugadores;
            }


            public static List<Jugador> SortGoleadores(List<Jugador> myList)
            {

                List<Jugador> sortedList = new List<Jugador>();

                foreach (Jugador Juega in myList)
                {
                    bool agrego = true;
 if (sortedList.Count > 0) {
     for (int a = 0; a < sortedList.Count; a++) { 
                  if (sortedList[a].Name == Juega.Name)
         {
             sortedList[a].Gls = sortedList[a].Gls + Juega.Gls;
             agrego = false;
             continue;
                  }

                    }
 }

 if (agrego == true) { 
                        sortedList.Add(Juega);
 }
                
                }

              List<Jugador> postasortedList = new  List<Jugador> ();

                sortedList.Sort(delegate(Jugador x, Jugador y)
                {
                    return y.Gls.CompareTo(x.Gls);
                });




                for (int asd = 0; asd < 9; asd++)
            {

                postasortedList.Add(sortedList[asd]);
            }
            return new List<Jugador>(postasortedList);
            }

            public List<Jugador> AsistidoresDeCompetencia(string Competencia, int Temporada, string Fase)
            {

                Jugador JugadorTraido = new Jugador();
                List<Jugador> ListaDeJugadores = new List<Jugador>();
            string query = "";
            if (Temporada == 0)
            {

                TemporadaActualDAO TA = new TemporadaActualDAO();
                Temporada = TA.GetTemporadaActual();
            }


            if (Fase == null)
            {
                query = string.Format("SELECT Jugadores.Equipo, JugadorEnPartido.Jugador, JugadorEnPartido.Ass FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido), Jugadores, Equipos WHERE (Equipos.Nombre = Jugadores.Equipo AND Jugadores.Name = JugadorEnPartido.Jugador AND Partidos.TEMPORADA = " + Temporada + " AND Partidos.Competencia = '" + Competencia + "')");
            }
            if (Fase != null)
            {
                query = string.Format("SELECT Jugadores.Equipo, JugadorEnPartido.Jugador, JugadorEnPartido.Ass FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido), Jugadores, Equipos WHERE (Equipos.Nombre = Jugadores.Equipo AND Jugadores.Name = JugadorEnPartido.Jugador AND Partidos.fase = '" + Fase + "' AND Partidos.TEMPORADA = " + Temporada + " AND Partidos.Competencia = '" + Competencia + "')");
            }
            OleDbDataReader dr = new ConnectionDAO().consulta(query);

                while (dr.Read())
                {


                    Jugador JugadorA = new Jugador() { Name = (string)dr["Jugador"], Ass = (int)dr["Ass"], Equipo = (string)dr["Equipo"] };

                    ListaDeJugadores.Add(JugadorA);



                }

                ListaDeJugadores = SortAsistidores(ListaDeJugadores);

                dr.Close(); dr.Dispose();



                return ListaDeJugadores;
            }


            public static List<Jugador> SortAsistidores(List<Jugador> myList)
            {

                List<Jugador> sortedList = new List<Jugador>();

                foreach (Jugador Juega in myList)
                {
                    bool agrego = true;
                    if (sortedList.Count > 0)
                    {
                        for (int a = 0; a < sortedList.Count; a++)
                        {
                            if (sortedList[a].Name == Juega.Name)
                            {
                                sortedList[a].Gls = sortedList[a].Ass + Juega.Ass;
                                agrego = false;
                                continue;
                            }

                        }
                    }

                    if (agrego == true)
                    {
                        sortedList.Add(Juega);
                    }

                }

                List<Jugador> postasortedList = new List<Jugador>();

                sortedList.Sort(delegate(Jugador x, Jugador y)
                {
                    return y.Ass.CompareTo(x.Ass);
                });




                for (int asd = 0; asd < 9; asd++)
                {

                    postasortedList.Add(sortedList[asd]);
                }
                return new List<Jugador>(postasortedList);
            }

        

        public static List<Jugador> Sorted5Objects(List<Jugador> myList)
        {

            double cambiante = 0.0000000001;
            SortedList<double, Jugador> sortedList = new SortedList<double, Jugador>();
            foreach (Jugador Juega in myList) {

                if (sortedList.Keys.Contains(Juega.ValorStar)){

                sortedList.Add(Juega.ValorStar + cambiante, Juega);
                    cambiante = cambiante + 0.0000000001;
                }
                else { 
                sortedList.Add(Juega.ValorStar, Juega);
                }



              
            }

            int cantidaddejugadores = sortedList.Count;

            for (int asd = 5; asd < cantidaddejugadores; asd++)
            {

                sortedList.RemoveAt(0);
            }


            return new List<Jugador>(sortedList.Values.Reverse());
        }


        public static List<Jugador> Sorted10Objects(List<Jugador> myList)
        {

            double cambiante = 0.0000000001;
            SortedList<double, Jugador> sortedList = new SortedList<double, Jugador>();
            foreach (Jugador Juega in myList)
            {

                if (sortedList.Keys.Contains(Juega.ValorStar))
                {

                    sortedList.Add(Juega.ValorStar + cambiante, Juega);
                    cambiante = cambiante + 0.0000000001;
                }
                else
                {
                    sortedList.Add(Juega.ValorStar, Juega);
                }




            }

            int cantidaddejugadores = sortedList.Count;

            for (int asd = 10; asd < cantidaddejugadores; asd++)
            {

                sortedList.RemoveAt(0);
            }


            return new List<Jugador>(sortedList.Values.Reverse());
        }






    }

}





