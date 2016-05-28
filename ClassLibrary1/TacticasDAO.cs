using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace DataAcces
{
    public class TacticasDAO
    {

        public void ActualizarTxtdeTactica(Tactica Tactic)
        {
            DataAcces.TacticasDAO cnd = new DataAcces.TacticasDAO();




            List<string> ListaFINALdeLineas = new List<string>();


            ListaFINALdeLineas.Clear();
            ListaFINALdeLineas.Add(Tactic.Equipo);
            ListaFINALdeLineas.Add(Tactic.Tactic);
            ListaFINALdeLineas.Add("");
            ListaFINALdeLineas.Add(Tactic.Player1);
            ListaFINALdeLineas.Add(Tactic.Player2);
            ListaFINALdeLineas.Add(Tactic.Player3);
            ListaFINALdeLineas.Add(Tactic.Player4);
            ListaFINALdeLineas.Add(Tactic.Player5);
            ListaFINALdeLineas.Add(Tactic.Player6);
            ListaFINALdeLineas.Add(Tactic.Player7);
            ListaFINALdeLineas.Add(Tactic.Player8);
            ListaFINALdeLineas.Add(Tactic.Player9);
            ListaFINALdeLineas.Add(Tactic.Player10);
            ListaFINALdeLineas.Add(Tactic.Player11);
            ListaFINALdeLineas.Add("");
            ListaFINALdeLineas.Add(Tactic.Sustitute1);
            ListaFINALdeLineas.Add(Tactic.Sustitute2);
            ListaFINALdeLineas.Add(Tactic.Sustitute3);
            ListaFINALdeLineas.Add(Tactic.Sustitute4);
            ListaFINALdeLineas.Add(Tactic.Sustitute5);
            ListaFINALdeLineas.Add(Tactic.Sustitute6);
            ListaFINALdeLineas.Add(Tactic.Sustitute7);
            ListaFINALdeLineas.Add("");
            ListaFINALdeLineas.Add(Tactic.PK);
            ListaFINALdeLineas.Add("");
            ListaFINALdeLineas.Add(Tactic.Order1);
            ListaFINALdeLineas.Add(Tactic.Order2);
            ListaFINALdeLineas.Add(Tactic.Order3);
            ListaFINALdeLineas.Add(Tactic.Order4);
            ListaFINALdeLineas.Add(Tactic.Order5);
            ListaFINALdeLineas.Add(Tactic.Order6);
            ListaFINALdeLineas.Add(Tactic.Order7);
            ListaFINALdeLineas.Add(Tactic.Order8);
            ListaFINALdeLineas.Add(Tactic.Order9);
            ListaFINALdeLineas.Add(Tactic.Order10);
            ListaFINALdeLineas.Add(Tactic.Order11);
            ListaFINALdeLineas.Add(Tactic.Order12);
            ListaFINALdeLineas.Add(Tactic.Order13);
            ListaFINALdeLineas.Add(Tactic.Order14);
            ListaFINALdeLineas.Add(Tactic.Order15);
            ListaFINALdeLineas.Add(Tactic.Order16);
            ListaFINALdeLineas.Add(Tactic.Order17);
            ListaFINALdeLineas.Add(Tactic.Order18);
            ListaFINALdeLineas.Add(Tactic.Order19);
            ListaFINALdeLineas.Add(Tactic.Order20);





            string[] lines = new string[ListaFINALdeLineas.Count];

            for (int h = 0; h < ListaFINALdeLineas.Count; h++)
            {
                lines[h] = ListaFINALdeLineas.ElementAt(h);
            }




            //  System.IO.File.WriteAllLines("C:\\Users\\matia\\Dropbox\\3. Zattrick\\5. C# - Zattrick\\Solution1\\WebApplication1\\" + Tactic.Equipo + "sht.txt", lines, System.Text.Encoding.Default);
            System.IO.File.WriteAllLines(System.AppDomain.CurrentDomain.BaseDirectory + Tactic.Equipo + "sht.txt", lines, System.Text.Encoding.Default);




        }


        public Tactica TraerTacticadeTXT(string NombreDeEquipo)
        {
            Tactica TacticaAEnviar = new Tactica();
            EquipoDAO ED = new EquipoDAO();
            string NombreArchivoEquipo = ED.GetNombreArchivoDeEquipo(NombreDeEquipo);
            NombreArchivoEquipo = NombreArchivoEquipo.Replace(".txt", "");
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + NombreArchivoEquipo + "sht.txt" , System.Text.Encoding.Default, false);

            int contador = 0;
            while ((line = file.ReadLine()) != null)
            {
                contador++;

                if (contador == 2)
                {
                    TacticaAEnviar.Tactic = line;
                }

                if (contador == 4)
                {
                    TacticaAEnviar.Player1 = line.Substring(3);
                }
                if (contador == 5)
                {
                    TacticaAEnviar.Player2 = line.Substring(4);
                    TacticaAEnviar.BandPlayer2 = line.Substring(2, 1);
                    
                }
                if (contador == 6)
                {
                    TacticaAEnviar.Player3 = line.Substring(4);
                    TacticaAEnviar.BandPlayer3 = line.Substring(2, 1);
                }
                if (contador == 7)
                {
                    TacticaAEnviar.Player4 = line.Substring(4);
                    TacticaAEnviar.BandPlayer4 = line.Substring(2, 1);
                }
                if (contador == 8)
                {
                    TacticaAEnviar.Player5 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer5 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer5 = line.Substring(2, 1);
                }
                if (contador == 9)
                {
                    TacticaAEnviar.Player6 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer6 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer6 = line.Substring(2, 1);
                }
                if (contador == 10)
                {
                    TacticaAEnviar.Player7 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer7 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer7 = line.Substring(2, 1);
                }
                if (contador == 11)
                {
                    TacticaAEnviar.Player8 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer8 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer8 = line.Substring(2, 1);
                }
                if (contador == 12)
                {
                    TacticaAEnviar.Player9 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer9 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer9 = line.Substring(2, 1);
                }
                if (contador == 13)
                {
                    TacticaAEnviar.Player10 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer10 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer10 = line.Substring(2, 1);
                }
                if (contador == 14)
                {
                    TacticaAEnviar.Player11 = line.Substring(4);
                    TacticaAEnviar.PositionPlayer11 = line.Substring(0, 2);
                    TacticaAEnviar.BandPlayer11 = line.Substring(2, 1);
                }

                if (contador == 16)
                {
                    TacticaAEnviar.Sustitute1 = line.Substring(3);
                }
                if (contador == 17)
                {
                    TacticaAEnviar.Sustitute2 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute2 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute2 = line.Substring(2, 1);
                }
                if (contador == 18)
                {
                    TacticaAEnviar.Sustitute3 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute3 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute3 = line.Substring(2, 1);
                }
                if (contador == 19)
                {
                    TacticaAEnviar.Sustitute4 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute4 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute4 = line.Substring(2, 1);
                }
                if (contador == 20)
                {
                    TacticaAEnviar.Sustitute5 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute5 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute5 = line.Substring(2, 1);
                }
                if (contador == 21)
                {
                    TacticaAEnviar.Sustitute6 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute6 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute6 = line.Substring(2, 1);
                }
                if (contador == 22)
                {
                    TacticaAEnviar.Sustitute7 = line.Substring(4);
                    TacticaAEnviar.PositionSustitute7 = line.Substring(0, 2);
                    TacticaAEnviar.BandSustitute7 = line.Substring(2, 1);
                }

                if (contador == 24)
                {
                    TacticaAEnviar.PK = line.Substring(4);
                }

                if (contador == 26)
                {
                    TacticaAEnviar.Order1 = line;
                }
                if (contador == 27)
                {
                    TacticaAEnviar.Order2 = line;
                }
                if (contador == 28)
                {
                    TacticaAEnviar.Order3 = line;
                }
                if (contador == 29)
                {
                    TacticaAEnviar.Order4 = line;
                }



            }

            file.Close();
            return TacticaAEnviar;

        }


    }
}