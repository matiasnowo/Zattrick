using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;

namespace AppWeb
{
    public partial class About : Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] == null)
            {

                Response.Redirect("/Account/Login.aspx");

            }






       }

        

        protected void Actualizar_Click(object sender, EventArgs e)
        {

              JugadorDAO jd = new JugadorDAO();



              jd.ActualizarBasedeDatos();

                    

               
           }

        protected void DeBaseATxt_Click(object sender, EventArgs e)
        {
            JugadorDAO jd = new JugadorDAO();



            jd.ActualizarTodoslosTxt();
        }

        protected void CrearPartidoEnBase_Click(object sender, EventArgs e)
        {

         PartidoDAO PD = new PartidoDAO();



       //     PD.PonerPartidoEnBase("Aldosivi", "All Boys", "Copa Zattrick", 1);

            PD.PonerTodosLosPartidosEnBase();

        }
    }
}
    
