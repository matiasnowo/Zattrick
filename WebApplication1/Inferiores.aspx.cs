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
    public partial class Inferiores : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Titulo.Text = Convert.ToString(Session["Equipo"]);


            InferioresDAO iD = new InferioresDAO();

            Pais.Text = iD.TraerPaisDe(Titulo.Text);
            Nivel.Text = iD.TraerNivelDe(Titulo.Text);
            PuntosdeExperiencia.Text = iD.TraerPuntosExp(Titulo.Text);
            Banda.Text = iD.TraerBandaDe(Titulo.Text);
            Edad.Text = iD.TraerEdad(Titulo.Text);
            Rango.Text = iD.TraerRango(Titulo.Text);
            Surgido.Text = DateTime.Today.ToString().Replace("12:00:00 a. m.", "");
            


                }

                 }

            








        }







          


   