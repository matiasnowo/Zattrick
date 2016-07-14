using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;
using System.Windows.Forms;

namespace AppWeb.Public
{
    public partial class Competencia : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




            string name = Request.QueryString["name"];
            string subfase = Request.QueryString["subfase"];


            string fase = Request.QueryString["fase"];


            Title = name + " - " + fase;

            TemporadaActualDAO TA = new TemporadaActualDAO();
            TA.GetTemporadaActual();

            
            LabelTemporada.Text = TA.GetTemporadaActual() + "";

            if (fase != null)
            {
                if (subfase != null) {

                    Titulo.Text = name + " - " + fase + " - " + subfase;

                }

                if (subfase == null)
                {


                    Titulo.Text = name + " - " + fase;
                }

            }

            if (fase == null)
            {

                Titulo.Text = name;

            }
            if (name == "Primera Division") { 

            if (Request.QueryString["subfase"] == null && Request.QueryString["fase"] == null)
            {

                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&fase=" + TA.GetFaseActualPrimera() + "&subfase=" + TA.GetSubFaseActualPrimera());

            }


            if (Request.QueryString["fase"] == null)
            {
              
                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&fase=" + TA.GetFaseActualPrimera());

            }

            if (Request.QueryString["subfase"] == null)
            {

                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&subfase=" + TA.GetSubFaseActualPrimera());

            }

            if (Request.QueryString["temporada"] == null)
            {

                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&temporada=" + TA.GetTemporadaActual());

            }

            }


            if (name == "Segunda Division")
            {

                if (Request.QueryString["subfase"] == null && Request.QueryString["fase"] == null)
                {

                    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&fase=" + TA.GetFaseActualSegunda() + "&subfase=" + TA.GetSubFaseActualSegunda());

                }


                if (Request.QueryString["fase"] == null)
                {

                    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&fase=" + TA.GetFaseActualSegunda());

                }

                if (Request.QueryString["subfase"] == null)
                {

                    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&subfase=" + TA.GetSubFaseActualSegunda());

                }

                if (Request.QueryString["temporada"] == null)
                {

                    Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri + "&temporada=" + TA.GetTemporadaActual());

                }

            }

            GridViewTablaCompetencia.DataBind();

            for (int v = 0; v < GridViewTablaCompetencia.Rows.Count; v++)
            {

                int golfav = Int32.Parse(GridViewTablaCompetencia.Rows[v].Cells[5].Text);
                int golcont = Int32.Parse(GridViewTablaCompetencia.Rows[v].Cells[6].Text);



                GridViewTablaCompetencia.Rows[v].Cells[7].Text = (golfav - golcont) + "";





            }

          

            if (!IsPostBack)
            {
                EquipoDAO ED2 = new EquipoDAO();
                List<Model.Equipo> EquiposCLogo = new List<Model.Equipo>();
                EquiposCLogo = ED2.GetEquipos();
                for (int s = 0; s < EquiposCLogo.Count; s++)
                {

                    if (UltimosGanadores.Rows.Count > 0) { 
                    for (int r = 0; r < UltimosGanadores.Rows.Count; r++)
                    {
                        if (EquiposCLogo[s].Nombre == ((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text) { 

                            ((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text = "<img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + "> <br/>" + ((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text;

                    }

                            if (EquiposCLogo[s].Nombre == ((HyperLink)UltimosGanadores.Rows[r].Cells[3].Controls[0]).Text)
                            {

                                ((HyperLink)UltimosGanadores.Rows[r].Cells[3].Controls[0]).Text = "<img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + "> <br/>" + ((HyperLink)UltimosGanadores.Rows[r].Cells[3].Controls[0]).Text;

                            }

                            if (EquiposCLogo[s].Nombre == ((HyperLink)UltimosGanadores.Rows[r].Cells[4].Controls[0]).Text)
                            {

                                ((HyperLink)UltimosGanadores.Rows[r].Cells[4].Controls[0]).Text = "<img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + "> <br/>" + ((HyperLink)UltimosGanadores.Rows[r].Cells[4].Controls[0]).Text;

                            }
                        }
                    }

                

                for (int r = 0; r < Goleadores.Rows.Count; r++)
                {
                        if (EquiposCLogo[s].Nombre == ((HyperLink)Goleadores.Rows[r].Cells[0].Controls[0]).Text)
                        {
                            ((HyperLink)Goleadores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + ">";
                        }
                }

                for (int r = 0; r < Asistidores.Rows.Count; r++)
                {
                        if (EquiposCLogo[s].Nombre == ((HyperLink)Asistidores.Rows[r].Cells[0].Controls[0]).Text)
                        {
                            ((HyperLink)Asistidores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + ">";
                        }
                }


                

                for (int r = 0; r < MejoresJugadores.Rows.Count; r++)
                {
                    if (EquiposCLogo[s].Nombre == ((HyperLink)MejoresJugadores.Rows[r].Cells[0].Controls[0]).Text)
                    {
                        ((HyperLink)MejoresJugadores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + EquiposCLogo[s].Logo + ">";
                
                //    string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) >= 0 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 5)
                    {
                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-2.png\">";
                        continue;

                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 5 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 10)
                    {
                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 10 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 15)
                    {

                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 15 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 20)
                    {

                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 20 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 25)
                    {

                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 25 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 30)
                    {


                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 30 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 35)
                    {
                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 35 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 40)
                    {


                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 40 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 45)
                    {


                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) > 45 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[2].Text) <= 50)
                    {
                        MejoresJugadores.Rows[r].Cells[2].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }

                    }
                    }

                }
            }




            //         if (Session["Equipo"] == null)
            //        {

            //            Response.Redirect("/Inicio.aspx");
            //        }





        }

        



        }
    }
        