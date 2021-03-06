﻿using System;
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
            EntrenamientoEspecialDAO EED = new EntrenamientoEspecialDAO();
            EntrenadorDAO END = new EntrenadorDAO();

            NivelInstalaciones.Text = ED.GetNivelInstalacionesDeEquipo(Titulo.Text) + "";
            Entrenador.Text = END.GetEntrenadorPorEquipo(Titulo.Text).Nombre;
            EdadEntrenador.Text = END.GetEntrenadorPorEquipo(Titulo.Text).Edad+ "";
            NivelEntrenador.Text = END.GetEntrenadorPorEquipo(Titulo.Text).Nivel + "";
            Especialidad.Text = END.GetEntrenadorPorEquipo(Titulo.Text).Especialidad;
            SueldoEntrenador.Text = END.GetEntrenadorPorEquipo(Titulo.Text).Sueldo + "";

            if (EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).Equipo == Titulo.Text)
            {

                ListaJugadores.Visible = false;
                BandasDisponibles.Visible = false;
                CostoEntrenamiento.Visible = false;
                FechaFinEntrenamiento.Visible = false;
                BotonConfirmar.Visible = false;
                Panel3.Visible = false;

                JugadorEntrenando.Visible = true;
                BandaEntrenando.Visible = true;
                FechaFinEntrenamiento.Visible = true;

       //         ListaJugadores.SelectedValue = JugadorEntrenando.Text;

                JugadorEntrenando.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).Jugador;
                BandaEntrenando.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).BandaNueva;
                FechaFinEntrenamiento.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).FechaFin.ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "");

            }



            /////////////////////////////////
            BandasDisponibles.Items.FindByValue("Entrenar L").Enabled = true;
            BandasDisponibles.Items.FindByValue("Entrenar R").Enabled = true;
            BandasDisponibles.Items.FindByValue("Entrenar C").Enabled = true;
            if (BandasDisponibles.SelectedValue != "")
            {

                BotonConfirmar.Enabled = true;
            }

            if (BandasDisponibles.SelectedValue == "")
            {
                BotonConfirmar.Enabled = false;
            }

            JugadorDAO JD = new JugadorDAO();
            //   EquipoDAO ED = new EquipoDAO();
            Model.Jugador JugadorAEntrenar = new Model.Jugador();
            ListaJugadores.DataBind(); // mmmmmmmmm
            JugadorAEntrenar = JD.TraerJugador(ListaJugadores.SelectedValue);

  //   if (ListaJugadores.SelectedValue != "")
       //   {
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

                if (JugadorAEntrenar.Prs.Contains("RLC"))
                {
                    BotonConfirmar.Enabled = false;
                }


                BandasDisponibles.DataBind();



                int costo;
                int dias;
                int semanas;



                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 1)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 50000) + 100000;

                    CostoEntrenamiento.Text = costo + "";


                    semanas = ((JugadorAEntrenar.Age - 16) * 2) + 2;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 2)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 40000) + 80000;

                    CostoEntrenamiento.Text = costo + "";

                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 2;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 3)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 25000) + 50000;

                    CostoEntrenamiento.Text = costo + "";

                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 4)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 20000) + 40000;

                    CostoEntrenamiento.Text = costo + "";
                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "";

                }

                if (ED.GetNivelInstalacionesDeEquipo(Titulo.Text) == 5)
                {
                    costo = ((JugadorAEntrenar.Age - 16) * 10000) + 30000;

                    CostoEntrenamiento.Text = costo + "";
                    semanas = ((JugadorAEntrenar.Age - 16) * 1) + 1;
                    dias = semanas * 7;
                    FechaFinEntrenamiento.Text = DateTime.Today.AddDays(dias).ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "") + "";

                }

                BandasDisponibles.Enabled = true;


           
    //    }
    }

        protected void ListaJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        
        }

        protected void BotonConfirmar_Click(object sender, EventArgs e)
        {




            EntrenamientoEspecialDAO EED = new EntrenamientoEspecialDAO();
            
            DateTime FechaFinal = DateTime.Parse(FechaFinEntrenamiento.Text);

            EED.SetEntrenamientoEspecialDeJugador(ListaJugadores.SelectedValue, Titulo.Text, BandasDisponibles.Text.Replace("Entrenar ",""), DateTime.Today, FechaFinal);


            if (EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).Equipo == Titulo.Text)
            {

                ListaJugadores.Visible = false;
                BandasDisponibles.Visible = false;
                CostoEntrenamiento.Visible = false;
                FechaFinEntrenamiento.Visible = false;
                BotonConfirmar.Visible = false;
                Panel3.Visible = false;

                JugadorEntrenando.Visible = true;
                BandaEntrenando.Visible = true;
                FechaFinEntrenamiento.Visible = true;

          //      ListaJugadores.SelectedValue = JugadorEntrenando.Text;

                JugadorEntrenando.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).Jugador;
                BandaEntrenando.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).BandaNueva;
                FechaFinEntrenamiento.Text = EED.GetEntrenamientoEspecialDeJugadorPorEquipo(Titulo.Text).FechaFin.ToString().Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "");

            }


        }

        protected void BandasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

          if ( BandasDisponibles.SelectedValue != "")
            {

                BotonConfirmar.Enabled = true;
}

            if (BandasDisponibles.SelectedValue == "")
            {
    BotonConfirmar.Enabled = false;
}



        }
    }

            








        }







          


   