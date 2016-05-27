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
    public partial class Jugador : Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {



                string name = Request.QueryString["name"];



                Session.Add("name", name);

                NamePlayer.Text = name;

            JugadorDAO JD = new JugadorDAO();

            Model.Jugador JugadorEnWeb = new Model.Jugador();

            JugadorEnWeb = JD.TraerJugador(name);


            EquipoActual.Text = JugadorEnWeb.Equipo;
            Edad.Text = JugadorEnWeb.Age+"";
            Banda.Text = JugadorEnWeb.Prs;
            BanderaNacion.ImageUrl = "~/Images/Paises/" + JugadorEnWeb.Nat + ".png";



        }

        
    }
}