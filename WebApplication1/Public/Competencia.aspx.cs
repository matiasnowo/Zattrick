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
    public partial class Competencia : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




            string name = Request.QueryString["name"];
            string fase = Request.QueryString["fase"];
            string subfase = Request.QueryString["subfase"];
            string tempo = Request.QueryString["TemporadaActual"];






            Titulo.Text = name;

            //         if (Session["Equipo"] == null)
            //        {

            //            Response.Redirect("/Inicio.aspx");
            //        }





        }
    }
}
        