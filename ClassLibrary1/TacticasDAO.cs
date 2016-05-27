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


    }


}