using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;


namespace AppWeb.Public
{
    public partial class PerfilEquipo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            string name = Request.QueryString["name"];

            Session.Add("name", name);

            Titulo.Text = name;

            //         if (Session["Equipo"] == null)
            //        {

            //            Response.Redirect("/Inicio.aspx");
            //        }


            Title = "Equipo - " + name;

            EstadioDAO ESD = new EstadioDAO();


            Capacidad.Text = ESD.TraerCapacidadDe(Titulo.Text);
            NombreEstadio.Text = ESD.TraerNombreEstadioDe(Titulo.Text);
            Hinchada.Text = ESD.TraerHinchadaDe(Titulo.Text);
            PopuActual.Text = ESD.TraerPopuActualDe(Titulo.Text);
            VHistorico.Text = ESD.TraerValorHistoricoDe(Titulo.Text);



            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            PartidoDAO PD = new PartidoDAO();


            LabelPais.Text = Equipazo.Pais;
            LabelApodo.Text = Equipazo.Apodo;
            ButtCategoria.Text = Equipazo.Categoria;
            LabelFundacion.Text = Equipazo.Fundacion + "";
            LabelRival.Text = Equipazo.Rival;

            GridViewTodoslosPartidos.DataBind();
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

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }

            //    MejoresJugadores.Sort("Valor", SortDirection.Descending);


            if (!IsPostBack)
            {
                for (int r = 0; r < MejoresJugadores.Rows.Count; r++)
                {
                   

                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) >= 0 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 5)
                    {
                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-2.png\">";
                        continue;

                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 5 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 10)
                    {
                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 10 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 15)
                    {

                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 15 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 20)
                    {

                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 20 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 25)
                    {

                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 25 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 30)
                    {


                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 30 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 35)
                    {
                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 35 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 40)
                    {


                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 40 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 45)
                    {


                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                        continue;
                    }
                    if (Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) > 45 && Convert.ToDouble(MejoresJugadores.Rows[r].Cells[1].Text) <= 50)
                    {
                        MejoresJugadores.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                        continue;
                    }

                    

                }
            }
        }


            //    for (int a = 0; a < Prueba.Count; a++)
            //   {


            //   DataList1.DataSource = Prueba;
            //     DataList1.DataBind();


            //    }




            //     ListView1.Items.Add("List item text");
        





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

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
         


          


           




        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("/Public/PartidosDe.aspx?name=" + Titulo.Text);


        }

        protected void Plantilla_Click(object sender, EventArgs e)
        {

            Response.Redirect("/Public/Plantilla.aspx?name=" + Titulo.Text);
        }

        protected void Categoria1_Click(object sender, EventArgs e)
        {



            Response.Redirect("/Public/Competencia.aspx?name=" + ButtCategoria.Text);


        }
    }
}
        