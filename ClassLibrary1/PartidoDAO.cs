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



      /*   public void PonerPartidosEnBase()
        {
            Partido PartidoTraido = new Partido();

            PartidoTraido.EquipoLocal = "Olimpo";
            PartidoTraido.EquipoVisitante = "Newell's";

           


                        int counter = 0;
                        string line;
                        string row = "";

                        //Notebook //
                        //  System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams.ElementAt(i).Archivo, System.Text.Encoding.Default, false);

                        // Casa PC //  
                        System.IO.StreamReader file = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "olp_nwl.txt", System.Text.Encoding.Default, false);



                            while ((line = file.ReadLine()) != null)
                            {
                                row = line;
                                if (row != "")
                                {

                                    if (counter == 5)
                                {

                                    if (counter < 16)
                                    {


                                        PartidoTraido.LocalTitulares.ElementAt(counter - 5).Position = row.Substring(0, 3).Trim();
                                        PartidoTraido.LocalTitulares.ElementAt(counter - 5).Name = row.Substring(4, 19).Trim();

                                    }

                                }


                                }
                                counter++;

                            }
                            file.Close();
            
            PartidoDAO PD = new PartidoDAO();
            PD.CrearPartido(PartidoTraido);
        }
        */
        public void CrearPartido(Partido Partido)
        {

            string query = string.Format
           ("INSERT INTO partidos VALUES ({1}, '{2}', '{3}', {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, {30}, {31}, {32}, {33}, {34}, {35}, {36}, {37}, {38}, {39}, {40}, {41})", Partido.Fecha, Partido.EquipoLocal, Partido.EquipoVisitante, Partido.ArchivoPartido, Partido.ResultadoLocal, Partido.ResultadoVisitante, Partido.Competencia, Partido.Temporada, Partido.Relato, Partido.LocalTitulares.ElementAt(0).Name, Partido.LocalTitulares.ElementAt(1).Name, Partido.LocalTitulares.ElementAt(2), Partido.LocalTitulares.ElementAt(3).Name, Partido.LocalTitulares.ElementAt(4).Name, Partido.LocalTitulares.ElementAt(5).Name, Partido.LocalTitulares.ElementAt(6).Name, Partido.LocalTitulares.ElementAt(7).Name, Partido.LocalTitulares.ElementAt(8).Name, Partido.LocalTitulares.ElementAt(9).Name, Partido.LocalTitulares.ElementAt(10).Name, 
           Partido.LocalSuplentes.ElementAt(0).Name, Partido.LocalSuplentes.ElementAt(1).Name, Partido.LocalSuplentes.ElementAt(2).Name, Partido.LocalSuplentes.ElementAt(3).Name, Partido.LocalSuplentes.ElementAt(4).Name, Partido.LocalSuplentes.ElementAt(5).Name, Partido.LocalSuplentes.ElementAt(6).Name, Partido.VisitanteTitulares.ElementAt(0).Name, Partido.VisitanteTitulares.ElementAt(1).Name, Partido.VisitanteTitulares.ElementAt(2).Name, Partido.VisitanteTitulares.ElementAt(3).Name, Partido.VisitanteTitulares.ElementAt(4).Name, Partido.VisitanteTitulares.ElementAt(5).Name, Partido.VisitanteTitulares.ElementAt(6).Name, Partido.VisitanteTitulares.ElementAt(7).Name, Partido.VisitanteTitulares.ElementAt(8).Name, Partido.VisitanteTitulares.ElementAt(9).Name, Partido.VisitanteTitulares.ElementAt(10).Name, Partido.VisitanteSuplentes.ElementAt(0).Name, Partido.LocalFormacionUsada, Partido.VisitanteFormacionUsada, Partido.LocalTacticaUsada, Partido.VisitanteTacticaUsada, Partido.RendimientoLocal, Partido.RendimientoVisitante);


            // Name         Age Nat Prs St Tk Ps Sh Sm Ag KAb TAb PAb SAb Gam Sav Ktk Kps Sht Gls Ass  DP Inj Sus Fit
            new ConnectionDAO().queryABM(query);
        }







    }







    }
