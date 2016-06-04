using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;

namespace AppWeb
{
    public partial class Partidos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["Equipo"] == null)
            {

                Response.Redirect("/Inicio.aspx");
            }

            Titulo.Text = Convert.ToString(Session["Equipo"]);
           
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            PartidoDAO PD = new PartidoDAO();


            Liga.Text = Equipazo.Categoria;

            
            

            
            
            
            SqlDataSource2.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = '" + Equipazo.Categoria + "' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";

            SqlDataSource3.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Copa Zattrick' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";

            SqlDataSource4.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Amistoso' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";





            GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B) { 

                GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            GridViewLiga.DataBind();
             for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewLiga.Rows[v].Cells[1].Text = GridViewLiga.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            GridViewCopa.DataBind();
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewCopa.Rows[v].Cells[1].Text = GridViewCopa.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            GridViewAmistosos.DataBind();
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewAmistosos.Rows[v].Cells[1].Text = GridViewAmistosos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //    for (int a = 0; a < Prueba.Count; a++)
            //   {


            //   DataList1.DataSource = Prueba;
            //     DataList1.DataBind();


            //    }




            //     ListView1.Items.Add("List item text");
        }


       


        protected void GridViewTodoslosPartidos_RowDataBound(object sender, GridViewRowEventArgs e)
        {




        //    GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
   //         GridViewLiga.DataBind();
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewLiga.Rows[v].Cells[1].Text = GridViewLiga.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


    //        GridViewCopa.DataBind();
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewCopa.Rows[v].Cells[1].Text = GridViewCopa.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

     //       GridViewAmistosos.DataBind();
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewAmistosos.Rows[v].Cells[1].Text = GridViewAmistosos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }



        }

        protected void GridViewLiga_RowDataBound(object sender, GridViewRowEventArgs e)
        {



            //    GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            //         GridViewLiga.DataBind();
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewLiga.Rows[v].Cells[1].Text = GridViewLiga.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //        GridViewCopa.DataBind();
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewCopa.Rows[v].Cells[1].Text = GridViewCopa.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            //       GridViewAmistosos.DataBind();
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewAmistosos.Rows[v].Cells[1].Text = GridViewAmistosos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


        }

        protected void GridViewCopa_RowDataBound(object sender, GridViewRowEventArgs e)
        {



            //    GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            //         GridViewLiga.DataBind();
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewLiga.Rows[v].Cells[1].Text = GridViewLiga.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //        GridViewCopa.DataBind();
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewCopa.Rows[v].Cells[1].Text = GridViewCopa.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            //       GridViewAmistosos.DataBind();
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewAmistosos.Rows[v].Cells[1].Text = GridViewAmistosos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

        }

        protected void GridViewAmistosos_RowDataBound(object sender, GridViewRowEventArgs e)
        {



      //      GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = GridViewTodoslosPartidos.Rows[v].Cells[2].Text;
                string EquipoB = GridViewTodoslosPartidos.Rows[v].Cells[5].Text;

                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
        //    GridViewLiga.DataBind();
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = GridViewLiga.Rows[v].Cells[2].Text;
                string EquipoB = GridViewLiga.Rows[v].Cells[5].Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewLiga.Rows[v].Cells[1].Text = GridViewLiga.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


      //      GridViewCopa.DataBind();
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = GridViewCopa.Rows[v].Cells[2].Text;
                string EquipoB = GridViewCopa.Rows[v].Cells[5].Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewCopa.Rows[v].Cells[1].Text = GridViewCopa.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

      //      GridViewAmistosos.DataBind();
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = GridViewAmistosos.Rows[v].Cells[2].Text;
                string EquipoB = GridViewAmistosos.Rows[v].Cells[5].Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=/Content/circulo-rojo-icono-9411-16.png>";
                }
                GridViewAmistosos.Rows[v].Cells[1].Text = GridViewAmistosos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }



        }

    }
}