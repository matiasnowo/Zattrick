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
            Titulo.Text = Convert.ToString(Session["Equipo"]);
            if (Session["Equipo"] == null)
            {

                Response.Redirect("/Inicio.aspx");
            }

           

            

        //    for (int a = 0; a < Prueba.Count; a++)
         //   {

               
             //   DataList1.DataSource = Prueba;
           //     DataList1.DataBind();


        //    }




       //     ListView1.Items.Add("List item text");
        }

     

            


      
    }
}