using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;
using System.Drawing;
using System.Collections;
using System.Data.OleDb;

namespace AppWeb.Public
{
    public partial class Partido : Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {



            string Partido = Request.QueryString["partido"];



            Session.Add("partido", Partido);

            if (Session["partido"] == null)
            {
                Response.Redirect("/Inicio.aspx");

            }

            PartidoDAO PD = new PartidoDAO();
            Model.Partido TraemosPartido = new Model.Partido();

            TraemosPartido = PD.GetPartidoPorID(Int32.Parse(Partido));

            List<string> JugadoresLocales = new List<string>();
            List<string> JugadoresVisitantes = new List<string>();

            LabelCompetencia.Text = TraemosPartido.Competencia;

            Title = "Partido - " + TraemosPartido.EquipoLocal + " " + TraemosPartido.ResultadoLocal + " - " + TraemosPartido.ResultadoVisitante + " " + TraemosPartido.EquipoVisitante;


            int SUPLENTE6L = 0;
            int SUPLENTE7L = 0;
            int SUPLENTE6V = 0;
            int SUPLENTE7V = 0;
            int rowlocal = 0;
            int rowvisita = 0;
            for (int a = 0; a < 11; a++)
            {

                JugadoresLocales.Add(TraemosPartido.LocalTitulares.ElementAt(a).Name);
                JugadoresVisitantes.Add(TraemosPartido.VisitanteTitulares.ElementAt(a).Name);


            }

            for (int a = 0; a < 7; a++)
            {
                JugadoresLocales.Add(TraemosPartido.LocalSuplentes.ElementAt(a).Name);
                JugadoresVisitantes.Add(TraemosPartido.VisitanteSuplentes.ElementAt(a).Name);
            }




            for (int v = 0; v < GridViewLocal.Rows.Count; v++)
            {

                string hay = ((HyperLink)GridViewLocal.Rows[v].Cells[1].Controls[0]).Text;

                if (SUPLENTE6L == 1 && hay == "Suplente6")
                {

                    GridViewLocal.Rows[v].Visible = false;
                }
                if (SUPLENTE7L == 1 && hay == "Suplente7")
                {

                    GridViewLocal.Rows[v].Visible = false;
                }

                if (!JugadoresLocales.Contains(hay))
                {

                    GridViewLocal.Rows[v].Visible = false;

                }

                if (JugadoresLocales.Contains(hay))
                {
                    rowlocal++;

                    if (rowlocal > 11) {
                        GridViewLocal.Rows[v].BackColor = Color.FromName("#FFFFCC");
                    }
                }


                if (hay == "Suplente6")
                {

                    SUPLENTE6L = 1;

                }

                if (hay == "Suplente7")
                {

                    SUPLENTE7L = 1;

                }

                for (int celda = 2; celda < 7; celda++) { 
               if (Convert.ToInt32(GridViewLocal.Rows[v].Cells[celda].Text) > 0)
                {

                        GridViewLocal.Rows[v].Cells[celda].Font.Bold = true;

                        GridViewLocal.Rows[v].Cells[celda].ForeColor = Color.Red;

                    }

                 


                }

                int Asist = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[2].Text));
                int Gols = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[3].Text));
                int Ams = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[4].Text));
                int Rjs = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[5].Text));
                int salv = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[9].Text));
                int ktk = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[10].Text));
                int kps = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[11].Text));
                int sht = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[12].Text));
                int minu = (Convert.ToInt32(GridViewLocal.Rows[v].Cells[13].Text));
                double result = 0.00;

                

                if (GridViewLocal.Rows[v].Cells[0].Text == "GK") {
                    result = (6.00 + (0.18 * salv) - (0.25 * Ams) - (1 * Rjs) - (0.2 * TraemosPartido.ResultadoVisitante));
                    GridViewLocal.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }


                if (GridViewLocal.Rows[v].Cells[0].Text.Contains("DF"))
                {

                    result = (6.00 + (0.21 * ktk) + (0.18 * kps) + (0.36 * Asist) + (0.18 * sht) + (0.82 * Gols) - (0.25 * Ams) - (1 * Rjs) - (0.15 * TraemosPartido.ResultadoVisitante));

                    GridViewLocal.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }

                if (GridViewLocal.Rows[v].Cells[0].Text.Contains("MF") || GridViewLocal.Rows[v].Cells[0].Text.Contains("DM") || GridViewLocal.Rows[v].Cells[0].Text.Contains("AM"))
                {

                    result = (6.00 + (0.23 * ktk) + (0.23 * kps) + (0.32 * Asist) + (0.21 * sht) + (0.82 * Gols) - (0.25 * Ams) - (1 * Rjs));

                    GridViewLocal.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }

                if (GridViewLocal.Rows[v].Cells[0].Text.Contains("FW"))
                {

                    result = (6.00 + (0.42 * ktk) + (0.18 * kps) + (0.36 * Asist) + (0.26 * sht) + (0.67 * Gols) - (0.25 * Ams) - (1 * Rjs));


                    GridViewLocal.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);

                      
                }

                if (Convert.ToDouble(GridViewLocal.Rows[v].Cells[8].Text) > 10)
                {

                    GridViewLocal.Rows[v].Cells[8].Text = 10 + "";

                }

                if (minu < 16)
                {
                    GridViewLocal.Rows[v].Cells[8].Text = "-";

                }



            }


            for (int v = 0; v < GridViewVisitante.Rows.Count; v++)
            {

                string hay = ((HyperLink)GridViewVisitante.Rows[v].Cells[1].Controls[0]).Text;

                if (SUPLENTE6V == 1 && hay == "Suplente6")
                {

                    GridViewVisitante.Rows[v].Visible = false;
                }
                if (SUPLENTE7V == 1 && hay == "Suplente7")
                {

                    GridViewVisitante.Rows[v].Visible = false;
                }

                if (!JugadoresVisitantes.Contains(hay))
                {

                    GridViewVisitante.Rows[v].Visible = false;

                  

                }

                if (JugadoresVisitantes.Contains(hay))
                {
                    rowvisita++;

                    if (rowvisita > 11)
                    {
                        GridViewVisitante.Rows[v].BackColor = Color.FromName("#FFFFCC");
                    }
                }

                if (hay == "Suplente6")
                {

                    SUPLENTE6V = 1;

                }

                if (hay == "Suplente7")
                {

                    SUPLENTE7V = 1;

                }

                for (int celda = 2; celda < 7; celda++)
                {
                    if (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[celda].Text) > 0)
                    {

                        GridViewVisitante.Rows[v].Cells[celda].Font.Bold = true;
                        GridViewVisitante.Rows[v].Cells[celda].ForeColor = Color.Red;

                    }

                }


                int Asist = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[2].Text));
                int Gols = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[3].Text));
                int Ams = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[4].Text));
                int Rjs = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[5].Text));
                int salv = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[9].Text));
                int ktk = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[10].Text));
                int kps = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[11].Text));
                int sht = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[12].Text));
                int minu = (Convert.ToInt32(GridViewVisitante.Rows[v].Cells[13].Text));
                double result = 0.00;



                if (GridViewVisitante.Rows[v].Cells[0].Text == "GK")
                {
                    result = (6.00 + (0.18 * salv) - (0.25 * Ams) - (1 * Rjs) - (0.2 * TraemosPartido.ResultadoLocal));
                    GridViewVisitante.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }


                if (GridViewVisitante.Rows[v].Cells[0].Text.Contains("DF"))
                {

                    result = (6.00 + (0.21 * ktk) + (0.18 * kps) + (0.36 * Asist) + (0.18 * sht) + (0.82 * Gols) - (0.25 * Ams) - (1 * Rjs) - (0.15 * TraemosPartido.ResultadoLocal));

                    GridViewVisitante.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }

                if (GridViewVisitante.Rows[v].Cells[0].Text.Contains("MF") || GridViewVisitante.Rows[v].Cells[0].Text.Contains("DM") || GridViewVisitante.Rows[v].Cells[0].Text.Contains("AM"))
                {

                    result = (6.00 + (0.23 * ktk) + (0.23 * kps) + (0.32 * Asist) + (0.21 * sht) + (0.82 * Gols) - (0.25 * Ams) - (1 * Rjs));

                    GridViewVisitante.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);
                }

                if (GridViewVisitante.Rows[v].Cells[0].Text.Contains("FW"))
                {

                    result = (6.00 + (0.42 * ktk) + (0.18 * kps) + (0.36 * Asist) + (0.26 * sht) + (0.67 * Gols) - (0.25 * Ams) - (1 * Rjs));


                    GridViewVisitante.Rows[v].Cells[8].Text = String.Format("{0:0.00}", result);


                }


                if (Convert.ToDouble(GridViewVisitante.Rows[v].Cells[8].Text) > 10){

                    GridViewVisitante.Rows[v].Cells[8].Text = 10 + "";

            }
                if (minu < 16)
                {
                    GridViewVisitante.Rows[v].Cells[8].Text = "-";

                }


            }


            EquipoLocal.Text = "<a href ='/Public/PerfilEquipo.aspx?name=" + TraemosPartido.EquipoLocal + "' >" + TraemosPartido.EquipoLocal + "</a>";
            ResultadoLocal.Text = TraemosPartido.ResultadoLocal + "";
            ResultadoVisitante.Text = TraemosPartido.ResultadoVisitante + "";
            EquipoVisiitante.Text = "<a href ='/Public/PerfilEquipo.aspx?name=" + TraemosPartido.EquipoVisitante + "' >" + TraemosPartido.EquipoVisitante + "</a>";



            FormacionLocal.Text = TraemosPartido.LocalFormacionUsada;
            TacticaLocal.Text = TraemosPartido.LocalTacticaUsada;
            FormacionVisitante.Text = TraemosPartido.VisitanteFormacionUsada;
            TacticaVisitante.Text = TraemosPartido.VisitanteTacticaUsada;

            TotalDisparosLocal.Text = (TraemosPartido.TirosFueraLocal + TraemosPartido.TirosPuertaLocal) + "";
            TotalDisparosVisitante.Text = (TraemosPartido.TirosFueraVisitante + TraemosPartido.TirosPuertaVisitante) + "";
            ApuertaLocal.Text = TraemosPartido.TirosPuertaLocal + "";
            ApuertaVisitante.Text = TraemosPartido.TirosPuertaVisitante + "";

            List<double> ListaRendiLocal = new List<double>();
            List<double> ListaRendiVisitante = new List<double>();
            for (int a = 0; a < 10; a++)
            {

                double g = Convert.ToInt64(Convert.ToDouble(TraemosPartido.RendimientoLocal[a].Ps));
                double h = Convert.ToInt64(Convert.ToDouble(TraemosPartido.RendimientoVisitante[a].Ps));
                ListaRendiLocal.Add(g);
                ListaRendiVisitante.Add(h);

            }

            double promedioloc = ListaRendiLocal[0] + ListaRendiLocal[1] + ListaRendiLocal[2] + ListaRendiLocal[3] + ListaRendiLocal[4] + ListaRendiLocal[5] + ListaRendiLocal[6] + ListaRendiLocal[7] + ListaRendiLocal[8] + ListaRendiLocal[9];
            double promediovis = ListaRendiVisitante[0] + ListaRendiVisitante[1] + ListaRendiVisitante[2] + ListaRendiVisitante[3] + ListaRendiVisitante[4] + ListaRendiVisitante[5] + ListaRendiVisitante[6] + ListaRendiVisitante[7] + ListaRendiVisitante[8] + ListaRendiVisitante[9];

            double ValorLocal = promedioloc / 10;
            double ValorVisita = promediovis / 10;

            double TOTAL = ValorVisita + ValorLocal;



            PosesionLocal.Text = Math.Round((ValorLocal*100)/TOTAL, 2) + "%";
            PosesionVisitante.Text = Math.Round((ValorVisita*100)/TOTAL, 2) + "%";

            string relatofinal = "";

            for (int a = 0; a < TraemosPartido.Relato.Count; a++) {


                ListItem li = new ListItem();
                relatofinal = relatofinal + System.Environment.NewLine + TraemosPartido.Relato.ElementAt(a);
                li.Text = TraemosPartido.Relato.ElementAt(a);

                RelatoBox.Items.Add(li);
                li.Attributes.Add("style", "color:snow;background-color:seagreen;");
            }






        }

       


    }
}