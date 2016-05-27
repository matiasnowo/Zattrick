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
    public partial class Estadio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Titulo.Text = Convert.ToString(Session["Equipo"]);

            EstadioDAO ED = new EstadioDAO();


            Capacidad.Text = ED.TraerCapacidadDe(Titulo.Text);
            NombreEstadio.Text = ED.TraerNombreEstadioDe(Titulo.Text);
            Hinchada.Text = ED.TraerHinchadaDe(Titulo.Text);
            PopuActual.Text = ED.TraerPopuActualDe(Titulo.Text);
            VHistorico.Text = ED.TraerValorHistoricoDe(Titulo.Text);
            SiguientePartido.Text = ED.TraerSiguientePartidoDe(Titulo.Text);






                }

                 }

            








        }







          


   