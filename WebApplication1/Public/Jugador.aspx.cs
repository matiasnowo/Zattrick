﻿using System;
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
            Edad.Text = JugadorEnWeb.Age + "";
            Banda.Text = "(" + JugadorEnWeb.Prs + ")";
            BanderaNacion.ImageUrl = "~/Images/Paises/" + JugadorEnWeb.Nat + ".png";

            if (JugadorEnWeb.Nat != null)
            {
                JugadorEnWeb.Nat = JugadorEnWeb.Nat.First().ToString().ToUpper() + JugadorEnWeb.Nat.Substring(1);
                NacionalidadLabel.Text = JugadorEnWeb.Nat;

            }


            int[] numbers = new int[] { JugadorEnWeb.St, JugadorEnWeb.Tk, JugadorEnWeb.Ps, JugadorEnWeb.Sh };
            int maximumNumber = numbers.Max();
            Double ValorStar = 0;

            if (JugadorEnWeb.Prs != null)
            {
                
                    int bandas = JugadorEnWeb.Prs.Count();

                    if (maximumNumber == JugadorEnWeb.St)
                    {
                        LabelPosicion.Text = "Arquero";
                        ValorStar = JugadorEnWeb.St;
                    }
                    if (maximumNumber == JugadorEnWeb.Tk)
                    {
                        LabelPosicion.Text = "Defensor";

                        ValorStar = (JugadorEnWeb.Tk + (bandas * 5) + (JugadorEnWeb.Ps * 0.4) + (JugadorEnWeb.Sh * 0.2) + (JugadorEnWeb.Sm * 0.2)) / 2.1;


                    }
                    if (maximumNumber == JugadorEnWeb.Ps)
                    {
                        LabelPosicion.Text = "Volante";

                        ValorStar = (JugadorEnWeb.Ps + (bandas * 5) + (JugadorEnWeb.Tk * 0.4) + (JugadorEnWeb.Sh * 0.4) + (JugadorEnWeb.Sm * 0.2)) / 2.3;

                    }
                    if (maximumNumber == JugadorEnWeb.Sh)
                    {
                        LabelPosicion.Text = "Delantero";

                        ValorStar = (JugadorEnWeb.Sh + (bandas * 5) + (JugadorEnWeb.Tk * 0.2) + (JugadorEnWeb.Ps * 0.4) + (JugadorEnWeb.Sm * 0.4)) / 2.5;

                    }
                    

                    if (ValorStar > 0)
                    {
                       Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-2.png";
                        
                    }
                    if (ValorStar > 5)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                    }
                    if (ValorStar > 10)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-2.png";
                    }
                    if (ValorStar > 15)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                    }
                    if (ValorStar > 20)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-2.png";
                    }
                    if (ValorStar > 25)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-4.png";
                    }
                    if (ValorStar > 30)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-4.png";
                        Star4.Visible = true;
                        Star4.ImageUrl = "~/Content/star-2.png";
                    }
                    if (ValorStar > 35)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-4.png";
                        Star4.Visible = true;
                        Star4.ImageUrl = "~/Content/star-4.png";
                    }
                    if (ValorStar > 40)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-4.png";
                        Star4.Visible = true;
                        Star4.ImageUrl = "~/Content/star-4.png";
                        Star5.Visible = true;
                        Star5.ImageUrl = "~/Content/star-2.png";
                    }
                    if (ValorStar > 45)
                    {
                        Star1.Visible = true;
                        Star1.ImageUrl = "~/Content/star-4.png";
                        Star2.Visible = true;
                        Star2.ImageUrl = "~/Content/star-4.png";
                        Star3.Visible = true;
                        Star3.ImageUrl = "~/Content/star-4.png";
                        Star4.Visible = true;
                        Star4.ImageUrl = "~/Content/star-4.png";
                        Star5.Visible = true;
                        Star5.ImageUrl = "~/Content/star-4.png";
                    }

                if (Session["Equipo"] != null) { 
                    if (JugadorEnWeb.Equipo == Session["Equipo"].ToString()) { 


                St.Text = JugadorEnWeb.St + "";
                Tk.Text = JugadorEnWeb.Tk + "";
                Ps.Text = JugadorEnWeb.Ps + "";
                Sh.Text = JugadorEnWeb.Sh + "";








                if (JugadorEnWeb.St > 17)
                {
                    St.ForeColor = System.Drawing.Color.DarkOrange;
                    St.Font.Bold = true;
                }

                if (JugadorEnWeb.St > 29)
                {
                    St.ForeColor = System.Drawing.Color.Red;
                    St.Font.Bold = true;
                }
                if (JugadorEnWeb.St > 40)
                {
                    St.ForeColor = System.Drawing.Color.Firebrick;
                    St.Font.Bold = true;
                }

                if (JugadorEnWeb.Tk > 17)
                {
                    Tk.ForeColor = System.Drawing.Color.DarkOrange;
                    Tk.Font.Bold = true;
                }

                if (JugadorEnWeb.Tk > 29)
                {
                    Tk.ForeColor = System.Drawing.Color.Red;
                    Tk.Font.Bold = true;
                }
                if (JugadorEnWeb.Tk > 40)
                {
                    Tk.ForeColor = System.Drawing.Color.Firebrick;
                    Tk.Font.Bold = true;
                }

                if (JugadorEnWeb.Ps > 17)
                {
                    Ps.ForeColor = System.Drawing.Color.DarkOrange;
                    Ps.Font.Bold = true;
                }

                if (JugadorEnWeb.Ps > 29)
                {
                    Ps.ForeColor = System.Drawing.Color.Red;
                    Ps.Font.Bold = true;
                }
                if (JugadorEnWeb.Ps > 40)
                {
                    Ps.ForeColor = System.Drawing.Color.Firebrick;
                    Ps.Font.Bold = true;
                }

                if (JugadorEnWeb.Sh > 17)
                {
                    Sh.ForeColor = System.Drawing.Color.DarkOrange;
                    Sh.Font.Bold = true;
                }

                if (JugadorEnWeb.Sh > 29)
                {
                    Sh.ForeColor = System.Drawing.Color.Red;
                    Sh.Font.Bold = true;
                }
                if (JugadorEnWeb.Sh > 40)
                {
                    Sh.ForeColor = System.Drawing.Color.Firebrick;
                    Sh.Font.Bold = true;
                }

                if (JugadorEnWeb.Fit < 50)
                {
                    Fit.BackColor = System.Drawing.Color.Red;
                    Sh.Font.Bold = true;
                }




                }
                }


                Sm.Text = JugadorEnWeb.Sm + "";
                Ag.Text = JugadorEnWeb.Ag + "";
                Fit.Text = JugadorEnWeb.Fit + "";
                Kab.Text = JugadorEnWeb.Kab / 10 + "%";
                Tab.Text = JugadorEnWeb.Tab / 10 + "%";
                Pab.Text = JugadorEnWeb.Pab / 10 + "%";
                Sab.Text = JugadorEnWeb.Sab / 10 + "%";
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

                progressokab.Style["width"] = (JugadorEnWeb.Kab / 10) + "%";
                progressotab.Style["width"] = (JugadorEnWeb.Tab / 10) + "%";
                progressopab.Style["width"] = (JugadorEnWeb.Pab / 10) + "%";
                progressosab.Style["width"] = (JugadorEnWeb.Sab / 10) + "%";

                if (JugadorEnWeb.Kab > 600)
                {
 Kab.Style["Color"] = "#e28e08";


                }
                if (JugadorEnWeb.Tab > 600)
                {
                    Tab.Style["Color"] = "#e28e08";


                }
                if (JugadorEnWeb.Pab > 600)
                {
                    Pab.Style["Color"] = "#e28e08";


                }
                if (JugadorEnWeb.Sab > 600)
                {
                    Sab.Style["Color"] = "#e28e08";


                }


                if (JugadorEnWeb.Kab > 850)
                {

                    Kab.Style["Color"] = "#c9302c";

                }
                if (JugadorEnWeb.Tab > 850)
                {

                    Tab.Style["Color"] = "#c9302c";

                }
                if (JugadorEnWeb.Pab > 850)
                {

                    Pab.Style["Color"] = "#c9302c";

                }
                if (JugadorEnWeb.Sab > 850)
                {

                    Sab.Style["Color"] = "#c9302c";


                }



            }


        }
    }

}
 