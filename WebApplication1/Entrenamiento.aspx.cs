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
    public partial class Entrenamiento : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Equipo"] == null)
            {

                Response.Redirect("/Inicio.aspx");
            }

            Titulo.Text = Convert.ToString(Session["Equipo"]);
            EquipoDAO ED = new EquipoDAO();

            NivelInstalaciones.Text = ED.GetNivelInstalacionesDeEquipo(Titulo.Text)+"";





        }

        protected void ListaJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

            BandasDisponibles.Items.FindByValue("Entrenar L").Enabled = true;
            BandasDisponibles.Items.FindByValue("Entrenar R").Enabled = true;
            BandasDisponibles.Items.FindByValue("Entrenar C").Enabled = true;


            JugadorDAO JD = new JugadorDAO();
            EquipoDAO ED = new EquipoDAO();
            Model.Jugador JugadorAEntrenar = new Model.Jugador();
            JugadorAEntrenar = JD.TraerJugador(ListaJugadores.SelectedValue);

            if (ListaJugadores.SelectedValue != "") { 
            if (JugadorAEntrenar.Prs.Contains("L"))
            {
                BandasDisponibles.Items.FindByValue("Entrenar L").Enabled = false;

            }

            if (JugadorAEntrenar.Prs.Contains("R"))
                {
                    BandasDisponibles.Items.FindByValue("Entrenar R").Enabled = false;
                }

            if (JugadorAEntrenar.Prs.Contains("C"))
                {
                    BandasDisponibles.Items.FindByValue("Entrenar C").Enabled = false;
                }

            BandasDisponibles.DataBind();

                int costo;
                int dias;
                int semanas;



                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 1) { 
                costo = ((JugadorAEntrenar.Age - 16) * 50000) + 100000;

                CostoEntrenamiento.Text = costo + "";


                    semanas = ((JugadorAEntrenar.Age - 16) * 2 ) + 2;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 2)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 40000) + 80000;

                    CostoEntrenamiento.Text = costo + "";

                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 2;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 3)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 25000) + 50000;

                    CostoEntrenamiento.Text = costo + "";

                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 4)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 20000) + 40000;

                    CostoEntrenamiento.Text = costo + "";
                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 5)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 10000) + 30000;

                    CostoEntrenamiento.Text = costo + "";
                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "") + "";

                }




            }
        }
    }

            








        }







          


   