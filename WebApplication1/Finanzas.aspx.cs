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
    public partial class Finanzas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Titulo.Text = Convert.ToString(Session["Equipo"]);
            if (Session["Equipo"] == null)
            {

                Response.Redirect("/Inicio.aspx");
            }

            FinanzasDAO FD = new FinanzasDAO();


            Dinero.Text = FD.TraerDineroDe(Titulo.Text);
            Auspiciantes.Text = FD.TraerAuspiciantesDe(Titulo.Text);
            MantencionDelEstadio.Text = FD.TraerManutencion(Titulo.Text);
            EstadioLleno.Text = FD.TraerGananciaSiLlena(Titulo.Text);
            Inferiores.Text = FD.TraerPagodeInferiores(Titulo.Text);
            SueldEntrenador.Text = FD.TraerSueldoEntrenadorDe(Titulo.Text);
            

            List<EventoDefinido>Prueba = FD.TraerListadeEventosFinanzas(Titulo.Text);





            ListView1.DataSource = Prueba; 
            ListView1.DataBind();

            

        //    for (int a = 0; a < Prueba.Count; a++)
         //   {

               
             //   DataList1.DataSource = Prueba;
           //     DataList1.DataBind();


        //    }




       //     ListView1.Items.Add("List item text");
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





            


      
    }
}