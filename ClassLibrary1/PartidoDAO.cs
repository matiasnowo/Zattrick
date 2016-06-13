using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAcces;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace DataAcces
{
    public class PartidoDAO
    {

        public Partido GetPartidoPorID(int ID)
        {

            string query2 = "SELECT * FROM RendimientoEnPartido WHERE ID_Partido = " + ID;
            OleDbDataReader dr2 = new ConnectionDAO().consulta(query2);
            string query = "SELECT * FROM Partidos WHERE ID = " + ID ;
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Partido Partidazo = new Partido();
            List<JugadorEnPartido> LJEP = new List<JugadorEnPartido>();
            List<JugadorEnPartido> LJEP2 = new List<JugadorEnPartido>();
            List<JugadorEnPartido> LJEP3 = new List<JugadorEnPartido>();
            List<JugadorEnPartido> LJEP4 = new List<JugadorEnPartido>();
            List<RendimientoDeEquipoEnPartido> LREN1 = new List<RendimientoDeEquipoEnPartido>();
            List<RendimientoDeEquipoEnPartido> LREN2 = new List<RendimientoDeEquipoEnPartido>();

            for (int a = 0; a < 11; a++)
            {
                JugadorEnPartido JEP = new JugadorEnPartido();
                LJEP.Add(JEP);
            }
            for (int a = 0; a < 7; a++)
            {
                JugadorEnPartido JEP2 = new JugadorEnPartido();
                LJEP2.Add(JEP2);
            }

            for (int a = 0; a < 11; a++)
            {
                JugadorEnPartido JEP3 = new JugadorEnPartido();
                LJEP3.Add(JEP3);
            }
            for (int a = 0; a < 7; a++)
            {
                JugadorEnPartido JEP4 = new JugadorEnPartido();
                LJEP4.Add(JEP4);
            }

            for (int a = 0; a < 10; a++)
            {
                RendimientoDeEquipoEnPartido REN1 = new RendimientoDeEquipoEnPartido();
                LREN1.Add(REN1);
            }
            for (int a = 0; a < 10; a++)
            {
                RendimientoDeEquipoEnPartido REN2 = new RendimientoDeEquipoEnPartido();
                LREN2.Add(REN2);
            }

            Partidazo.RendimientoLocal = LREN1;
            Partidazo.RendimientoVisitante = LREN2;


            Partidazo.LocalTitulares = LJEP;
            Partidazo.LocalSuplentes = LJEP2;

            Partidazo.VisitanteTitulares = LJEP3;
            Partidazo.VisitanteSuplentes = LJEP4;

            while (dr.Read())
            {

                

                Partidazo.Fecha = (DateTime)dr["Fecha"];
                Partidazo.EquipoLocal = (string)dr["EquipoLocal"];
                Partidazo.EquipoVisitante = (string)dr["EquipoVisitante"];
                Partidazo.ArchivoPartido = (string)dr["ArchivoPartido"];
                Partidazo.ResultadoLocal = (int)dr["ResultadoLocal"];
                Partidazo.ResultadoVisitante = (int)dr["ResultadoVisitante"];
                Partidazo.Competencia = (string)dr["Competencia"];
                Partidazo.Temporada = (int)dr["Temporada"];
                Partidazo.LocalTitulares.ElementAt(0).Name = (string)dr["TitularLocal1"];
                Partidazo.LocalTitulares.ElementAt(1).Name = (string)dr["TitularLocal2"];
                Partidazo.LocalTitulares.ElementAt(2).Name = (string)dr["TitularLocal3"];
                Partidazo.LocalTitulares.ElementAt(3).Name = (string)dr["TitularLocal4"];
                Partidazo.LocalTitulares.ElementAt(4).Name = (string)dr["TitularLocal5"];
                Partidazo.LocalTitulares.ElementAt(5).Name = (string)dr["TitularLocal6"];
                Partidazo.LocalTitulares.ElementAt(6).Name = (string)dr["TitularLocal7"];
                Partidazo.LocalTitulares.ElementAt(7).Name = (string)dr["TitularLocal8"];
                Partidazo.LocalTitulares.ElementAt(8).Name = (string)dr["TitularLocal9"];
                Partidazo.LocalTitulares.ElementAt(9).Name = (string)dr["TitularLocal10"];
                Partidazo.LocalTitulares.ElementAt(10).Name = (string)dr["TitularLocal11"];

                Partidazo.LocalSuplentes.ElementAt(0).Name = (string)dr["SuplenteLocal1"];
                Partidazo.LocalSuplentes.ElementAt(1).Name = (string)dr["SuplenteLocal2"];
                Partidazo.LocalSuplentes.ElementAt(2).Name = (string)dr["SuplenteLocal3"];
                Partidazo.LocalSuplentes.ElementAt(3).Name = (string)dr["SuplenteLocal4"];
                Partidazo.LocalSuplentes.ElementAt(4).Name = (string)dr["SuplenteLocal5"];
                Partidazo.LocalSuplentes.ElementAt(5).Name = (string)dr["SuplenteLocal6"];
                Partidazo.LocalSuplentes.ElementAt(6).Name = (string)dr["SuplenteLocal7"];

                Partidazo.VisitanteTitulares.ElementAt(0).Name = (string)dr["TitularVisitante1"];
                Partidazo.VisitanteTitulares.ElementAt(1).Name = (string)dr["TitularVisitante2"];
                Partidazo.VisitanteTitulares.ElementAt(2).Name = (string)dr["TitularVisitante3"];
                Partidazo.VisitanteTitulares.ElementAt(3).Name = (string)dr["TitularVisitante4"];
                Partidazo.VisitanteTitulares.ElementAt(4).Name = (string)dr["TitularVisitante5"];
                Partidazo.VisitanteTitulares.ElementAt(5).Name = (string)dr["TitularVisitante6"];
                Partidazo.VisitanteTitulares.ElementAt(6).Name = (string)dr["TitularVisitante7"];
                Partidazo.VisitanteTitulares.ElementAt(7).Name = (string)dr["TitularVisitante8"];
                Partidazo.VisitanteTitulares.ElementAt(8).Name = (string)dr["TitularVisitante9"];
                Partidazo.VisitanteTitulares.ElementAt(9).Name = (string)dr["TitularVisitante10"];
                Partidazo.VisitanteTitulares.ElementAt(10).Name = (string)dr["TitularVisitante11"];

                Partidazo.VisitanteSuplentes.ElementAt(0).Name = (string)dr["SuplenteVisitante1"];
                Partidazo.VisitanteSuplentes.ElementAt(1).Name = (string)dr["SuplenteVisitante2"];
                Partidazo.VisitanteSuplentes.ElementAt(2).Name = (string)dr["SuplenteVisitante3"];
                Partidazo.VisitanteSuplentes.ElementAt(3).Name = (string)dr["SuplenteVisitante4"];
                Partidazo.VisitanteSuplentes.ElementAt(4).Name = (string)dr["SuplenteVisitante5"];
                Partidazo.VisitanteSuplentes.ElementAt(5).Name = (string)dr["SuplenteVisitante6"];
                Partidazo.VisitanteSuplentes.ElementAt(6).Name = (string)dr["SuplenteVisitante7"];

                Partidazo.LocalFormacionUsada = (string)dr["FormacionLocal"];
                Partidazo.LocalTacticaUsada = (string)dr["TacticaLocal"];
                Partidazo.VisitanteFormacionUsada = (string)dr["FormacionVisistante"];
                Partidazo.VisitanteTacticaUsada = (string)dr["TacticaVisitante"];


                Partidazo.TirosPuertaLocal = (int)dr["TirosPuertaLocal"];
                Partidazo.TirosPuertaVisitante = (int)dr["TirosPuertaVisitante"];
                Partidazo.TirosFueraLocal = (int)dr["TirosFueraLocal"];
                Partidazo.TirosFueraVisitante = (int)dr["TirosFueraVisitante"];





            }

            dr.Close();

            int klocal = 0;
            int kvisita = 0;
            while (dr2.Read())
            {

                if ((Boolean)dr2["Equipo"] == true)
                {

                    
                    Partidazo.RendimientoLocal.ElementAt(klocal).Min = (int)dr2["Minuto"];
                    Partidazo.RendimientoLocal.ElementAt(klocal).Tk = (string)dr2["RendimientoTk"];
                    Partidazo.RendimientoLocal.ElementAt(klocal).Ps = (string)dr2["RendimientoPs"];
                    Partidazo.RendimientoLocal.ElementAt(klocal).Sh = (string)dr2["RendimientoSh"];
                    klocal++;
                
                }
                if ((Boolean)dr2["Equipo"] == false) { 

                


                    Partidazo.RendimientoVisitante.ElementAt(kvisita).Min = (int)dr2["Minuto"];
                Partidazo.RendimientoVisitante.ElementAt(kvisita).Tk = (string)dr2["RendimientoTk"];
                Partidazo.RendimientoVisitante.ElementAt(kvisita).Ps = (string)dr2["RendimientoPs"];
                Partidazo.RendimientoVisitante.ElementAt(kvisita).Sh = (string)dr2["RendimientoSh"];
                        kvisita++;
                    
                }

            }
            dr2.Close();



            return Partidazo;
        }

        public Partido GetPartidoPorLocal(string Nombre)
        {

            string query = "SELECT * FROM Partidos WHERE EquipoLocal = '" + Nombre + "'";
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            Partido Partidazo = new Partido();
            while (dr.Read())
            {

                List<JugadorEnPartido> LJEP = new List<JugadorEnPartido>();
                for (int a = 0; a< 10; a++) { 
                    JugadorEnPartido JEP = new JugadorEnPartido();
                    LJEP.Add(JEP);
                }
                Partidazo.LocalTitulares = LJEP;
                Partidazo.Fecha = (DateTime)dr["Fecha"];
                Partidazo.EquipoLocal = Nombre;
                Partidazo.EquipoVisitante = (string)dr["EquipoVisitante"];
                Partidazo.ArchivoPartido = (string)dr["ArchivoPartido"];
                Partidazo.ResultadoLocal = (int)dr["ResultadoLocal"];
                Partidazo.ResultadoVisitante = (int)dr["ResultadoVisitante"];
                Partidazo.Competencia = (string)dr["Competencia"];
                Partidazo.Temporada = (int)dr["Temporada"];
                Partidazo.LocalTitulares.ElementAt(0).Name = (string)dr["TitularLocal1"];
                Partidazo.LocalTitulares.ElementAt(1).Name = (string)dr["TitularLocal2"];
                Partidazo.LocalTitulares.ElementAt(2).Name = (string)dr["TitularLocal3"];
                Partidazo.LocalTitulares.ElementAt(3).Name = (string)dr["TitularLocal4"];
                Partidazo.LocalTitulares.ElementAt(4).Name = (string)dr["TitularLocal5"];
                Partidazo.LocalTitulares.ElementAt(5).Name = (string)dr["TitularLocal6"];
                Partidazo.LocalTitulares.ElementAt(6).Name = (string)dr["TitularLocal7"];
                Partidazo.LocalTitulares.ElementAt(7).Name = (string)dr["TitularLocal8"];
                Partidazo.LocalTitulares.ElementAt(8).Name = (string)dr["TitularLocal9"];
                Partidazo.LocalTitulares.ElementAt(9).Name = (string)dr["TitularLocal10"];
                Partidazo.LocalTitulares.ElementAt(10).Name = (string)dr["TitularLocal11"];


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



        public void PonerPartidoEnBase(string Local, string Visitante, string Competencia, int Temporada, string path)
        {
            Partido PartidoTraido = new Partido();
            EquipoDAO ED = new EquipoDAO();
            string ArchivoDelLocal = ED.GetEquipoPorNombre(Local).Archivo.Replace(".txt", "");
            string ArchivoDelVisitante = ED.GetEquipoPorNombre(Visitante).Archivo.Replace(".txt", "");

            PartidoTraido.EquipoLocal = Local;
            PartidoTraido.EquipoVisitante = Visitante;

            List<JugadorEnPartido> ListaLocalTitulares = new List<JugadorEnPartido>();
            List<JugadorEnPartido> ListaVisitanteTitulares = new List<JugadorEnPartido>();
            List<JugadorEnPartido> ListaLocalSuplentes = new List<JugadorEnPartido>();
            List<JugadorEnPartido> ListaVisitanteSuplentes = new List<JugadorEnPartido>();
            List<RendimientoDeEquipoEnPartido> ListaDeRendimientosDelLocal = new List<RendimientoDeEquipoEnPartido>();
            List<RendimientoDeEquipoEnPartido> ListaDeRendimientosDelVisitante = new List<RendimientoDeEquipoEnPartido>();

            int counter = 0;
            string line;
            string row = "";
            int countrelato = 0;
            List<string> agregame = new List<string>();
            int counterpostrelato = 999999999;
            int jugadornumero = 0;
            int intercarlarendir = 2;
            int haypenales= 0;
            int counterpenales = 0;
            Boolean hubopenales = false;
            Boolean seguicargando = false;

            path = path.Replace(System.AppDomain.CurrentDomain.BaseDirectory, "");

            path = path + "\\";
            //Notebook //
            //  System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams.ElementAt(i).Archivo, System.Text.Encoding.Default, false);

            // Casa PC //  
            System.IO.StreamReader file = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + path + ArchivoDelLocal + "_" + ArchivoDelVisitante + ".txt", System.Text.Encoding.Default, false);

            PartidoTraido.ArchivoPartido = ArchivoDelLocal + "_" + ArchivoDelVisitante + ".txt";
            PartidoTraido.Competencia = Competencia;
            PartidoTraido.Temporada = Temporada;
            PartidoTraido.Fecha = DateTime.Today; //Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "");


            for (int a = 0; a < 7; a++)
            {
                JugadorEnPartido JP = new JugadorEnPartido();

                ListaLocalSuplentes.Add(JP);

                JugadorEnPartido JP2 = new JugadorEnPartido();
                ListaVisitanteSuplentes.Add(JP2);
            }

            while ((line = file.ReadLine()) != null)
            {
                row = line;
                if (row != "")
                {

                    if (counter > 4)
                    {

                        if (counter < 16)
                        {

                            JugadorEnPartido JP = new JugadorEnPartido();
                            ListaLocalTitulares.Add(JP);
                            JP.Position = row.Substring(0, 3).Trim();
                            JP.Name = row.Substring(4, 19).Trim();

                            JugadorEnPartido JP2 = new JugadorEnPartido();
                            ListaVisitanteTitulares.Add(JP2);
                            JP2.Position = row.Substring(31, 3).Trim();
                            JP2.Name = row.Substring(35, 19).Trim();

                        }



                        PartidoTraido.LocalSuplentes = ListaLocalSuplentes;
                        PartidoTraido.VisitanteSuplentes = ListaVisitanteSuplentes;
                        PartidoTraido.RendimientoLocal = ListaDeRendimientosDelLocal;
                        PartidoTraido.RendimientoVisitante = ListaDeRendimientosDelVisitante;

                        if (counter == 17)
                        {
                            PartidoTraido.LocalTitulares = ListaLocalTitulares;
                            PartidoTraido.VisitanteTitulares = ListaVisitanteTitulares;

                            PartidoTraido.LocalFormacionUsada = row.Substring(0, 9).Trim();
                            PartidoTraido.VisitanteFormacionUsada = row.Substring(31, 9).Trim();

                            if (PartidoTraido.LocalFormacionUsada.Contains(" "))
                            {
                                PartidoTraido.LocalFormacionUsada = PartidoTraido.LocalFormacionUsada.Remove(8);
                                if (PartidoTraido.LocalFormacionUsada.Contains(" "))
                                {
                                    PartidoTraido.LocalFormacionUsada = PartidoTraido.LocalFormacionUsada.Remove(7);

                                    if (PartidoTraido.LocalFormacionUsada.Contains(" "))
                                    {
                                        PartidoTraido.LocalFormacionUsada = PartidoTraido.LocalFormacionUsada.Remove(6);
                                        if (PartidoTraido.LocalFormacionUsada.Contains(" "))
                                        {
                                            PartidoTraido.LocalFormacionUsada = PartidoTraido.LocalFormacionUsada.Remove(5);
                                        }

                                    }

                                }
                            }


                            if (PartidoTraido.VisitanteFormacionUsada.Contains(" "))
                            {

                                PartidoTraido.VisitanteFormacionUsada = PartidoTraido.VisitanteFormacionUsada.Remove(8);

                                if (PartidoTraido.VisitanteFormacionUsada.Contains(" "))
                                {


                                    PartidoTraido.VisitanteFormacionUsada = PartidoTraido.VisitanteFormacionUsada.Remove(7);
                                    if (PartidoTraido.VisitanteFormacionUsada.Contains(" "))
                                    {

                                        PartidoTraido.VisitanteFormacionUsada = PartidoTraido.VisitanteFormacionUsada.Remove(6);
                                        if (PartidoTraido.VisitanteFormacionUsada.Contains(" "))
                                        {
                                            PartidoTraido.VisitanteFormacionUsada = PartidoTraido.VisitanteFormacionUsada.Remove(5);
                                        }
                                    }
                                }
                            }
                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 24).Trim().Split(delimiter);

                            string[] rowsplit2;
                            rowsplit2 = row.Substring(31, 24).Trim().Split(delimiter);

                            PartidoTraido.LocalTacticaUsada = rowsplit1.ElementAt(1);
                            PartidoTraido.VisitanteTacticaUsada = rowsplit2.ElementAt(1);
                        }


                        if (counter > 19 && countrelato == 0)
                        {
                            string agrego = row;
                            agregame.Add(agrego);

                            if (row == "*************  FINAL DEL PARTIDO  ****************")
                            {
                                countrelato = 1;

                                PartidoTraido.Relato = agregame;
                               // counterpostrelato = counter;
                                haypenales = counter;
                            }


                        }

                        if (haypenales + 3 == counter && row == "*************  TANDA DE PENALTIS  *************" && counterpenales == 0)
                        {


                            string agrego = row;
                            agregame.Add(agrego);
                            seguicargando = true;

                        }

                        if (seguicargando == true)
                        {

                            string agrego = row;
                            agregame.Add(agrego);
                            if (row.Contains("se impone") || row.Contains("es el ganador!!!") || row.Contains("gana la tanda de penaltis!!!") 
                                || row.Contains("gana en la ruleta de los penaltis!!!"))
                            {
                                counterpenales = 1;
                                counterpostrelato = counter;
                                counter++;
                                PartidoTraido.Relato.Concat(agregame);
                                seguicargando = false;
                            }


                        }
                        

                        if (row.Contains("tiros fuera") && counterpenales == 0)
                        {
                            counterpostrelato = counter;

                            counter++;
                            counter++;
                            counter++;
                            counter++;
                        }
                       


                        if (counter > counterpostrelato && counter == counterpostrelato + 4)
                        {
                            PartidoTraido.TirosFueraLocal = Convert.ToInt32(row.Substring(28, 1).Trim());
                            PartidoTraido.TirosFueraVisitante = Convert.ToInt32(row.Substring(34, 1).Trim());

                        }
                        if (counter > counterpostrelato && counter == counterpostrelato + 5)
                        {
                            PartidoTraido.TirosPuertaLocal = Convert.ToInt32(row.Substring(28, 1).Trim());
                            PartidoTraido.TirosPuertaVisitante = Convert.ToInt32(row.Substring(34, 1).Trim());

                        }

                        if (counter > counterpostrelato && counter == counterpostrelato + 7)
                        {
                            PartidoTraido.ResultadoLocal = Convert.ToInt32(row.Substring(28, 1).Trim());
                            PartidoTraido.ResultadoVisitante = Convert.ToInt32(row.Substring(34, 1).Trim());

                        }

                        if (counter > counterpostrelato && counter > counterpostrelato + 13 && counter < counterpostrelato + 25)
                        {

                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 98).Trim().Split(delimiter);

                            List<string> rowsplit2 = new List<string>();

                            for (int a = 0; a < rowsplit1.Length; a++)
                            {
                                if (rowsplit1.ElementAt(a) != "")
                                {

                                    rowsplit2.Add(rowsplit1.ElementAt(a));
                                }

                            }


                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Prs = rowsplit2.ElementAt(2);
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).St = Convert.ToInt32(rowsplit2.ElementAt(3));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Tk = Convert.ToInt32(rowsplit2.ElementAt(4));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Ps = Convert.ToInt32(rowsplit2.ElementAt(5));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Sh = Convert.ToInt32(rowsplit2.ElementAt(6));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Sm = Convert.ToInt32(rowsplit2.ElementAt(7));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Min = Convert.ToInt32(rowsplit2.ElementAt(9));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Sav = Convert.ToInt32(rowsplit2.ElementAt(10));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Ktk = Convert.ToInt32(rowsplit2.ElementAt(11));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Kps = Convert.ToInt32(rowsplit2.ElementAt(12));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Ass = Convert.ToInt32(rowsplit2.ElementAt(13));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Sht = Convert.ToInt32(rowsplit2.ElementAt(14));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Gls = Convert.ToInt32(rowsplit2.ElementAt(15));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Yel = Convert.ToInt32(rowsplit2.ElementAt(16));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Red = Convert.ToInt32(rowsplit2.ElementAt(17));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Inj = Convert.ToInt32(rowsplit2.ElementAt(18));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Kab = Convert.ToInt32(rowsplit2.ElementAt(19));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Tab = Convert.ToInt32(rowsplit2.ElementAt(20));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Pab = Convert.ToInt32(rowsplit2.ElementAt(21));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Sab = Convert.ToInt32(rowsplit2.ElementAt(22));
                            PartidoTraido.LocalTitulares.ElementAt(jugadornumero).Fit = Convert.ToInt32(rowsplit2.ElementAt(23));
                            jugadornumero++;

                            if (jugadornumero == 11)
                            {
                                jugadornumero = 0;
                            }


                        }

                        if (counter > counterpostrelato && counter > counterpostrelato + 24 && counter < counterpostrelato + 32)
                        {

                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 98).Trim().Split(delimiter); // PROBLEMA AL CARGAR OTROS PARTIDOS!!!!!!!

                            List<string> rowsplit2 = new List<string>();

                            for (int a = 0; a < rowsplit1.Length; a++)
                            {
                                if (rowsplit1.ElementAt(a) != "")
                                {

                                    rowsplit2.Add(rowsplit1.ElementAt(a));
                                }

                            }


                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Name = rowsplit2.ElementAt(0);
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Position = rowsplit2.ElementAt(1);
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Prs = rowsplit2.ElementAt(2);
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).St = Convert.ToInt32(rowsplit2.ElementAt(3));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Tk = Convert.ToInt32(rowsplit2.ElementAt(4));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Ps = Convert.ToInt32(rowsplit2.ElementAt(5));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Sh = Convert.ToInt32(rowsplit2.ElementAt(6));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Sm = Convert.ToInt32(rowsplit2.ElementAt(7));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Min = Convert.ToInt32(rowsplit2.ElementAt(9));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Sav = Convert.ToInt32(rowsplit2.ElementAt(10));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Ktk = Convert.ToInt32(rowsplit2.ElementAt(11));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Kps = Convert.ToInt32(rowsplit2.ElementAt(12));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Ass = Convert.ToInt32(rowsplit2.ElementAt(13));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Sht = Convert.ToInt32(rowsplit2.ElementAt(14));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Gls = Convert.ToInt32(rowsplit2.ElementAt(15));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Yel = Convert.ToInt32(rowsplit2.ElementAt(16));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Red = Convert.ToInt32(rowsplit2.ElementAt(17));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Inj = Convert.ToInt32(rowsplit2.ElementAt(18));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Kab = Convert.ToInt32(rowsplit2.ElementAt(19));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Tab = Convert.ToInt32(rowsplit2.ElementAt(20));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Pab = Convert.ToInt32(rowsplit2.ElementAt(21));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Sab = Convert.ToInt32(rowsplit2.ElementAt(22));
                            PartidoTraido.LocalSuplentes.ElementAt(jugadornumero).Fit = Convert.ToInt32(rowsplit2.ElementAt(23));
                            jugadornumero++;

                            if (jugadornumero == 7)
                            {
                                jugadornumero = 0;
                            }

                        }


                        if (counter > counterpostrelato && counter > counterpostrelato + 38 && counter < counterpostrelato + 50)
                        {

                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 98).Trim().Split(delimiter);

                            List<string> rowsplit2 = new List<string>();

                            for (int a = 0; a < rowsplit1.Length; a++)
                            {
                                if (rowsplit1.ElementAt(a) != "")
                                {

                                    rowsplit2.Add(rowsplit1.ElementAt(a));
                                }

                            }


                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Prs = rowsplit2.ElementAt(2);
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).St = Convert.ToInt32(rowsplit2.ElementAt(3));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Tk = Convert.ToInt32(rowsplit2.ElementAt(4));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Ps = Convert.ToInt32(rowsplit2.ElementAt(5));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Sh = Convert.ToInt32(rowsplit2.ElementAt(6));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Sm = Convert.ToInt32(rowsplit2.ElementAt(7));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Min = Convert.ToInt32(rowsplit2.ElementAt(9));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Sav = Convert.ToInt32(rowsplit2.ElementAt(10));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Ktk = Convert.ToInt32(rowsplit2.ElementAt(11));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Kps = Convert.ToInt32(rowsplit2.ElementAt(12));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Ass = Convert.ToInt32(rowsplit2.ElementAt(13));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Sht = Convert.ToInt32(rowsplit2.ElementAt(14));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Gls = Convert.ToInt32(rowsplit2.ElementAt(15));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Yel = Convert.ToInt32(rowsplit2.ElementAt(16));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Red = Convert.ToInt32(rowsplit2.ElementAt(17));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Inj = Convert.ToInt32(rowsplit2.ElementAt(18));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Kab = Convert.ToInt32(rowsplit2.ElementAt(19));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Tab = Convert.ToInt32(rowsplit2.ElementAt(20));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Pab = Convert.ToInt32(rowsplit2.ElementAt(21));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Sab = Convert.ToInt32(rowsplit2.ElementAt(22));
                            PartidoTraido.VisitanteTitulares.ElementAt(jugadornumero).Fit = Convert.ToInt32(rowsplit2.ElementAt(23));
                            jugadornumero++;

                            if (jugadornumero == 11)
                            {
                                jugadornumero = 0;
                            }


                        }

                        if (counter > counterpostrelato && counter > counterpostrelato + 49 && counter < counterpostrelato + 57)
                        {

                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 98).Trim().Split(delimiter);

                            List<string> rowsplit2 = new List<string>();

                            for (int a = 0; a < rowsplit1.Length; a++)
                            {
                                if (rowsplit1.ElementAt(a) != "")
                                {

                                    rowsplit2.Add(rowsplit1.ElementAt(a));
                                }

                            }


                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Name = rowsplit2.ElementAt(0);
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Position = rowsplit2.ElementAt(1);
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Prs = rowsplit2.ElementAt(2);
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).St = Convert.ToInt32(rowsplit2.ElementAt(3));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Tk = Convert.ToInt32(rowsplit2.ElementAt(4));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Ps = Convert.ToInt32(rowsplit2.ElementAt(5));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Sh = Convert.ToInt32(rowsplit2.ElementAt(6));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Sm = Convert.ToInt32(rowsplit2.ElementAt(7));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Min = Convert.ToInt32(rowsplit2.ElementAt(9));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Sav = Convert.ToInt32(rowsplit2.ElementAt(10));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Ktk = Convert.ToInt32(rowsplit2.ElementAt(11));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Kps = Convert.ToInt32(rowsplit2.ElementAt(12));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Ass = Convert.ToInt32(rowsplit2.ElementAt(13));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Sht = Convert.ToInt32(rowsplit2.ElementAt(14));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Gls = Convert.ToInt32(rowsplit2.ElementAt(15));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Yel = Convert.ToInt32(rowsplit2.ElementAt(16));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Red = Convert.ToInt32(rowsplit2.ElementAt(17));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Inj = Convert.ToInt32(rowsplit2.ElementAt(18));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Kab = Convert.ToInt32(rowsplit2.ElementAt(19));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Tab = Convert.ToInt32(rowsplit2.ElementAt(20));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Pab = Convert.ToInt32(rowsplit2.ElementAt(21));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Sab = Convert.ToInt32(rowsplit2.ElementAt(22));
                            PartidoTraido.VisitanteSuplentes.ElementAt(jugadornumero).Fit = Convert.ToInt32(rowsplit2.ElementAt(23));
                            jugadornumero++;

                            if (jugadornumero == 7)
                            {
                                jugadornumero = 0;
                            }

                        }

                        if (counter > counterpostrelato && counter > counterpostrelato + 62 && counter < counterpostrelato + 84)
                        {

                            string[] rowsplit1;
                            char delimiter = ' ';
                            rowsplit1 = row.Substring(0, 37).Trim().Split(delimiter);

                            List<string> rowsplit2 = new List<string>();

                            for (int a = 0; a < rowsplit1.Length; a++)
                            {
                                if (rowsplit1.ElementAt(a) != "")
                                {

                                    rowsplit2.Add(rowsplit1.ElementAt(a));
                                }

                            }


                            RendimientoDeEquipoEnPartido Rendimiento = new RendimientoDeEquipoEnPartido();
                            Rendimiento.Min = Int32.Parse(rowsplit2.ElementAt(1)); //Aca cambie el tipo de variable en Min, OJO
                            Rendimiento.Tk = rowsplit2.ElementAt(2);
                            Rendimiento.Ps = rowsplit2.ElementAt(3);
                            Rendimiento.Sh = rowsplit2.ElementAt(4);

                            if (intercarlarendir % 2 == 0)
                            {
                                PartidoTraido.RendimientoLocal.Add(Rendimiento);

                            }
                            else
                            {

                                PartidoTraido.RendimientoVisitante.Add(Rendimiento);

                            }


                            intercarlarendir++;



                        }

                        if (counter > counterpostrelato && counter == counterpostrelato + 85)


                        {

                            PartidoTraido.IDUnico = Convert.ToInt32(row.Substring(0, 10).Trim());
                        }
                    }

                }
                counter++;


            }
            file.Close();

            PartidoTraido.LocalTitulares = ListaLocalTitulares;
            PartidoTraido.VisitanteTitulares = ListaVisitanteTitulares;
            CrearPartido(PartidoTraido);

            //     PartidoDAO PD = new PartidoDAO();
            //    PD.CrearPartido(PartidoTraido);
        }

        public void CrearPartido(Partido Partido)
        {


          string relatofinal =  Partido.Relato.Aggregate((current, next) => current + "|||" + next);

            relatofinal = relatofinal.Replace("'", "");

            string query = string.Format
           ("INSERT INTO partidos VALUES ({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}',{8}, '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}', '{40}', '{41}', '{42}', '{43}', '{44}', '{45}', {46}, {47}, {48}, {49}, '{50}', '{51}', '{52}', '{53}')", 
           Partido.IDUnico, Partido.Fecha, Partido.EquipoLocal, Partido.EquipoVisitante, Partido.ArchivoPartido, Partido.ResultadoLocal, Partido.ResultadoVisitante, Partido.Competencia, 
           Partido.Temporada, relatofinal , Partido.LocalTitulares.ElementAt(0).Name, Partido.LocalTitulares.ElementAt(1).Name, Partido.LocalTitulares.ElementAt(2).Name, 
           Partido.LocalTitulares.ElementAt(3).Name, Partido.LocalTitulares.ElementAt(4).Name, Partido.LocalTitulares.ElementAt(5).Name, Partido.LocalTitulares.ElementAt(6).Name, 
           Partido.LocalTitulares.ElementAt(7).Name, Partido.LocalTitulares.ElementAt(8).Name, Partido.LocalTitulares.ElementAt(9).Name, Partido.LocalTitulares.ElementAt(10).Name,
           Partido.LocalSuplentes.ElementAt(0).Name, Partido.LocalSuplentes.ElementAt(1).Name, Partido.LocalSuplentes.ElementAt(2).Name, Partido.LocalSuplentes.ElementAt(3).Name, 
           Partido.LocalSuplentes.ElementAt(4).Name, Partido.LocalSuplentes.ElementAt(5).Name, Partido.LocalSuplentes.ElementAt(6).Name, Partido.VisitanteTitulares.ElementAt(0).Name, 
           Partido.VisitanteTitulares.ElementAt(1).Name, Partido.VisitanteTitulares.ElementAt(2).Name, Partido.VisitanteTitulares.ElementAt(3).Name, Partido.VisitanteTitulares.ElementAt(4).Name,
           Partido.VisitanteTitulares.ElementAt(5).Name, Partido.VisitanteTitulares.ElementAt(6).Name, Partido.VisitanteTitulares.ElementAt(7).Name, Partido.VisitanteTitulares.ElementAt(8).Name,
           Partido.VisitanteTitulares.ElementAt(9).Name, Partido.VisitanteTitulares.ElementAt(10).Name, Partido.VisitanteSuplentes.ElementAt(0).Name, Partido.VisitanteSuplentes.ElementAt(1).Name,
           Partido.VisitanteSuplentes.ElementAt(2).Name, Partido.VisitanteSuplentes.ElementAt(3).Name, Partido.VisitanteSuplentes.ElementAt(4).Name, Partido.VisitanteSuplentes.ElementAt(5).Name
           , Partido.VisitanteSuplentes.ElementAt(6).Name, Partido.TirosPuertaLocal, Partido.TirosPuertaVisitante, Partido.TirosFueraLocal, Partido.TirosFueraVisitante, Partido.LocalFormacionUsada, 
           Partido.VisitanteFormacionUsada, Partido.LocalTacticaUsada, Partido.VisitanteTacticaUsada);


           
            // FALTA CARGAR EN TABLA DE "JUGADOR EN PARTIDO" Y TABLA DE "RENDIMIENTO EN PARTIDO"


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit
            new ConnectionDAO().queryABM(query);

            for (int a=0; a < 11; a++) { 
            string query2 = string.Format
               ("INSERT INTO JugadorEnPartido VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5}, {6}, {7},{8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23})",
          Partido.LocalTitulares[a].Name, Partido.IDUnico, Partido.LocalTitulares[a].Position, Partido.LocalTitulares[a].Prs, Partido.LocalTitulares[a].St, Partido.LocalTitulares[a].Tk,
           Partido.LocalTitulares[a].Ps, Partido.LocalTitulares[a].Sh, Partido.LocalTitulares[a].Sm, Partido.LocalTitulares[a].Kab, Partido.LocalTitulares[a].Tab, Partido.LocalTitulares[a].Pab,
           Partido.LocalTitulares[a].Sab, Partido.LocalTitulares[a].Min, Partido.LocalTitulares[a].Sav, Partido.LocalTitulares[a].Ktk, Partido.LocalTitulares[a].Kps, Partido.LocalTitulares[a].Sht,
           Partido.LocalTitulares[a].Gls, Partido.LocalTitulares[a].Ass, Partido.LocalTitulares[a].Yel, Partido.LocalTitulares[a].Red, Partido.LocalTitulares[a].Inj, Partido.LocalTitulares[a].Fit);

            new ConnectionDAO().queryABM(query2);

            }

            for (int a = 0; a < 11; a++)
            {
                string query3 = string.Format
                   ("INSERT INTO JugadorEnPartido VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5}, {6}, {7},{8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23})",
              Partido.VisitanteTitulares[a].Name, Partido.IDUnico, Partido.VisitanteTitulares[a].Position, Partido.VisitanteTitulares[a].Prs, Partido.VisitanteTitulares[a].St, Partido.VisitanteTitulares[a].Tk,
               Partido.VisitanteTitulares[a].Ps, Partido.VisitanteTitulares[a].Sh, Partido.VisitanteTitulares[a].Sm, Partido.VisitanteTitulares[a].Kab, Partido.VisitanteTitulares[a].Tab, Partido.VisitanteTitulares[a].Pab,
               Partido.VisitanteTitulares[a].Sab, Partido.VisitanteTitulares[a].Min, Partido.VisitanteTitulares[a].Sav, Partido.VisitanteTitulares[a].Ktk, Partido.VisitanteTitulares[a].Kps, Partido.VisitanteTitulares[a].Sht,
               Partido.VisitanteTitulares[a].Gls, Partido.VisitanteTitulares[a].Ass, Partido.VisitanteTitulares[a].Yel, Partido.VisitanteTitulares[a].Red, Partido.VisitanteTitulares[a].Inj, Partido.VisitanteTitulares[a].Fit);

                new ConnectionDAO().queryABM(query3);

            }

            for (int a = 0; a < 7; a++)
            {
                string query4 = string.Format
                   ("INSERT INTO JugadorEnPartido VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5}, {6}, {7},{8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23})",
              Partido.VisitanteSuplentes[a].Name, Partido.IDUnico, Partido.VisitanteSuplentes[a].Position, Partido.VisitanteSuplentes[a].Prs, Partido.VisitanteSuplentes[a].St, Partido.VisitanteSuplentes[a].Tk,
               Partido.VisitanteSuplentes[a].Ps, Partido.VisitanteSuplentes[a].Sh, Partido.VisitanteSuplentes[a].Sm, Partido.VisitanteSuplentes[a].Kab, Partido.VisitanteSuplentes[a].Tab, Partido.VisitanteSuplentes[a].Pab,
               Partido.VisitanteSuplentes[a].Sab, Partido.VisitanteSuplentes[a].Min, Partido.VisitanteSuplentes[a].Sav, Partido.VisitanteSuplentes[a].Ktk, Partido.VisitanteSuplentes[a].Kps, Partido.VisitanteSuplentes[a].Sht,
               Partido.VisitanteSuplentes[a].Gls, Partido.VisitanteSuplentes[a].Ass, Partido.VisitanteSuplentes[a].Yel, Partido.VisitanteSuplentes[a].Red, Partido.VisitanteSuplentes[a].Inj, Partido.VisitanteSuplentes[a].Fit);

                new ConnectionDAO().queryABM(query4);

            }

            for (int a = 0; a < 7; a++)
            {
                string query5 = string.Format
                   ("INSERT INTO JugadorEnPartido VALUES ('{0}', {1}, '{2}', '{3}', {4}, {5}, {6}, {7},{8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23})",
              Partido.LocalSuplentes[a].Name, Partido.IDUnico, Partido.LocalSuplentes[a].Position, Partido.LocalSuplentes[a].Prs, Partido.LocalSuplentes[a].St, Partido.LocalSuplentes[a].Tk,
               Partido.LocalSuplentes[a].Ps, Partido.LocalSuplentes[a].Sh, Partido.LocalSuplentes[a].Sm, Partido.LocalSuplentes[a].Kab, Partido.LocalSuplentes[a].Tab, Partido.LocalSuplentes[a].Pab,
               Partido.LocalSuplentes[a].Sab, Partido.LocalSuplentes[a].Min, Partido.LocalSuplentes[a].Sav, Partido.LocalSuplentes[a].Ktk, Partido.LocalSuplentes[a].Kps, Partido.LocalSuplentes[a].Sht,
               Partido.LocalSuplentes[a].Gls, Partido.LocalSuplentes[a].Ass, Partido.LocalSuplentes[a].Yel, Partido.LocalSuplentes[a].Red, Partido.LocalSuplentes[a].Inj, Partido.LocalSuplentes[a].Fit);

                new ConnectionDAO().queryABM(query5);

            }


            
            for (int a = 0; a < 10; a++)
            {
                string query6 = string.Format
                   ("INSERT INTO RendimientoEnPartido VALUES ({0}, {1}, {2}, {3}, {4}, {5})",
              Partido.IDUnico, true,  Partido.RendimientoLocal[a].Min, Partido.RendimientoLocal[a].Tk, Partido.RendimientoLocal[a].Ps, Partido.RendimientoLocal[a].Sh);

                new ConnectionDAO().queryABM(query6);

            }

            for (int a = 0; a < 10; a++)
            {
                string query7 = string.Format
                   ("INSERT INTO RendimientoEnPartido VALUES ({0}, {1}, {2}, {3}, {4}, {5})",
              Partido.IDUnico, false, Partido.RendimientoVisitante[a].Min, Partido.RendimientoVisitante[a].Tk, Partido.RendimientoVisitante[a].Ps, Partido.RendimientoVisitante[a].Sh);

                new ConnectionDAO().queryABM(query7);

            }
        }


        public void PonerTodosLosPartidosEnBase()
        {

            string equipo1 = "";
            string equipo2 = "";
            EquipoDAO ED = new EquipoDAO();
            DirectoryInfo dir = new DirectoryInfo(@System.AppDomain.CurrentDomain.BaseDirectory + "Temporadas Anteriores\\Amistosos\\1");

           for (int a = 0; a < dir.GetDirectories().Length; a++)
            {

                DirectoryInfo dir2 = new DirectoryInfo(dir.GetDirectories().ElementAt(a).FullName.ToString());

                for (int b = 0; b < dir2.GetFiles().Length; b++)
                {

                    if ( !dir2.GetFiles().ElementAt(b).ToString().Contains("reports")  &&  !dir2.GetFiles().ElementAt(b).ToString().Contains("updtr"))
                    {

                       string equipo = dir2.GetFiles().ElementAt(b).ToString();
                        equipo1 = equipo.Substring(0, 3);
                        equipo2 = equipo.Substring(4, 3);

                       string  equipodef1 = ED.GetNombreEquipoporNombreArchivo(equipo1 + ".txt");
                       string  equipodef2 = ED.GetNombreEquipoporNombreArchivo(equipo2 + ".txt");

                     

                        PonerPartidoEnBase(equipodef1, equipodef2, "Amistoso", 1, dir2.FullName);

                      


                    }




                }


                    










            }
             
            



        }




    }







}
