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
            LabelCategoria.Text = Equipazo.Categoria;
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

                GridViewTodoslosPartidos.Rows[v].Cells[1].Text = GridViewTodoslosPartidos.Rows[v].Cells[1].Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


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
         


          


           




        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("/Public/PartidosDe.aspx?name=" + Titulo.Text);


        }
    }
}
        