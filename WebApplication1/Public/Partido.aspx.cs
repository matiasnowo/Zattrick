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