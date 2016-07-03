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

            Titulo.Text = name;

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

            GridViewTablaCompetencia.DataBind();

            for (int v = 0; v < GridViewTablaCompetencia.Rows.Count; v++)
            {

                int golfav = Int32.Parse(GridViewTablaCompetencia.Rows[v].Cells[5].Text);
                int golcont = Int32.Parse(GridViewTablaCompetencia.Rows[v].Cells[6].Text);



                GridViewTablaCompetencia.Rows[v].Cells[7].Text = (golfav - golcont) + "";





            }

          

            if (!IsPostBack)
            {

                for (int r = 0; r < UltimosGanadores.Rows.Count; r++)
                {
                    EquipoDAO ED = new EquipoDAO();
                    ((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + ED.GetEquipoPorNombre(((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text).Logo + ">" + ((HyperLink)UltimosGanadores.Rows[r].Cells[2].Controls[0]).Text;

                }



                for (int r = 0; r < Goleadores.Rows.Count; r++)
                {
                    EquipoDAO ED = new EquipoDAO();
                    ((HyperLink)Goleadores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + ED.GetEquipoPorNombre(((HyperLink)Goleadores.Rows[r].Cells[0].Controls[0]).Text).Logo + ">";

                }

                for (int r = 0; r < Asistidores.Rows.Count; r++)
                {
                    EquipoDAO ED = new EquipoDAO();
                    ((HyperLink)Asistidores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + ED.GetEquipoPorNombre(((HyperLink)Asistidores.Rows[r].Cells[0].Controls[0]).Text).Logo + ">";

                }
                
                
                for (int r = 0; r < MejoresJugadores.Rows.Count; r++)
                {
                          EquipoDAO ED = new EquipoDAO();

                          ((HyperLink)MejoresJugadores.Rows[r].Cells[0].Controls[0]).Text = " <img src=/Content/ClubLogo/Small/" + ED.GetEquipoPorNombre(((HyperLink)MejoresJugadores.Rows[r].Cells[0].Controls[0]).Text).Logo + ">";
                              
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




            //         if (Session["Equipo"] == null)
            //        {

            //            Response.Redirect("/Inicio.aspx");
            //        }





        }

        



        }
    }
        