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
           

            GridViewTodoslosPartidos.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                GridViewTodoslosPartidos.Rows[v].Cells[0].Text = GridViewTodoslosPartidos.Rows[v].Cells[0].Text.Replace(" 00:00:00", "").Replace(" 12:00:00 a. m.", "");
            }

            GridViewTodoslosPartidosSoloLiga.DataBind();
            for (int v = 0; v < GridViewTodoslosPartidosSoloLiga.Rows.Count; v++)
            {
                GridViewTodoslosPartidosSoloLiga.Rows[v].Cells[0].Text = GridViewTodoslosPartidos.Rows[v].Cells[0].Text.Replace(" 00:00:00", "").Replace(" 12:00:00 a. m.", "");
        }
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            PartidoDAO PD = new PartidoDAO();


            Liga.Text = Equipazo.Categoria;




            //    for (int a = 0; a < Prueba.Count; a++)
            //   {


            //   DataList1.DataSource = Prueba;
            //     DataList1.DataBind();


            //    }




            //     ListView1.Items.Add("List item text");
        }

     

            


      
    }
}