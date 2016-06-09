using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;
using System.Drawing;

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

                string hay = GridViewLocal.Rows[v].Cells[0].Text;

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
                        GridViewLocal.Rows[v].BackColor = Color.FromName("#FFFF99");
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

                string hay = GridViewVisitante.Rows[v].Cells[0].Text;

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
                        GridViewVisitante.Rows[v].BackColor = Color.FromName("#FFFF99");
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

          




        }
        }

}