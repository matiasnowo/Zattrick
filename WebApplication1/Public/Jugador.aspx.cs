using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcces;
using Model;


namespace AppWeb.Public
{
    public partial class Jugador : Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            

            string name = Request.QueryString["name"];



                Session.Add("name", name);

                NamePlayer.Text = name;
            Title = "Jugador - " + name;

            JugadorDAO JD = new JugadorDAO();

            Model.Jugador JugadorEnWeb = new Model.Jugador();

            JugadorEnWeb = JD.TraerJugador(name);


            EquipoActual.Text = "<a href ='/Public/PerfilEquipo.aspx?name=" + JugadorEnWeb.Equipo + "' >" + JugadorEnWeb.Equipo + "</a>";
            Edad.Text = JugadorEnWeb.Age+"";
            Banda.Text = JugadorEnWeb.Prs;
            BanderaNacion.ImageUrl = "~/Images/Paises/" + JugadorEnWeb.Nat + ".png";

            St.Text = JugadorEnWeb.St + "";
            Tk.Text = JugadorEnWeb.Tk + "";
            Ps.Text = JugadorEnWeb.Ps + "";
            Sh.Text = JugadorEnWeb.Sh + "";
            Sm.Text = JugadorEnWeb.Sm + "";
            Ag.Text = JugadorEnWeb.Ag + "";
            Fit.Text = JugadorEnWeb.Fit + "";
            Kab.Text = JugadorEnWeb.Kab + "";
            Tab.Text = JugadorEnWeb.Tab + "";
            Pab.Text = JugadorEnWeb.Pab + "";
            Sab.Text = JugadorEnWeb.Sab + "";
            Gam.Text = JugadorEnWeb.Gam + "";
            Sav.Text = JugadorEnWeb.Sav + "";
            Ktk.Text = JugadorEnWeb.Ktk + "";
            Kps.Text = JugadorEnWeb.Kps + "";
            Sht.Text = JugadorEnWeb.Sht + "";
            Gls.Text = JugadorEnWeb.Gls + "";
            Ass.Text = JugadorEnWeb.Ass + "";
            DP.Text = JugadorEnWeb.DP + "";
            Inj.Text = JugadorEnWeb.Inj + "";
            Sus.Text = JugadorEnWeb.Sus + "";




        }

        
    }
}