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



        public void PonerPartidosEnBase()
        {
            Partido PartidoTraido = new Partido();

            PartidoTraido.EquipoLocal = "Olimpo";
            PartidoTraido.EquipoVisitante = "Newells";

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

            //Notebook //
            //  System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\matias.nowogrodzki\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + teams.ElementAt(i).Archivo, System.Text.Encoding.Default, false);

            // Casa PC //  
            System.IO.StreamReader file = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "olp_nwl.txt", System.Text.Encoding.Default, false);

            PartidoTraido.ArchivoPartido = "olp_nwl.txt";
            PartidoTraido.Competencia = "Copa Zattrick";
            PartidoTraido.Temporada = 1;
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
                            rowsplit1 = row.Substring(6, 24).Trim().Split(delimiter);

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
                                counterpostrelato = counter;
                            }


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
                            rowsplit1 = row.Substring(0, 98).Trim().Split(delimiter);

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
                            Rendimiento.Min = rowsplit2.ElementAt(1);
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
        }







    }







}
