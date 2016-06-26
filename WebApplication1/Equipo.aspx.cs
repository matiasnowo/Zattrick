using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppWeb
{
    public partial class Equipo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Titulo.Text = Convert.ToString(Session["Equipo"]);

            SqlDataSource1.SelectParameters.Add("Name", Titulo.Text);

            if (Session["Equipo"] == null)
            {

                Response.Redirect("/Inicio.aspx");
            }

        


            for (int v = 0; v < Plantilla.Rows.Count; v++)
            {

                int entero = Convert.ToInt32(Plantilla.Rows[v].Cells[16].Text);
                if (entero < 50)
                {
                    Plantilla.Rows[v].Cells[16].BackColor = System.Drawing.Color.Red;
                }
                for (int a = 4; a < 8; a++)
                {

                    int entero2 = Convert.ToInt32(Plantilla.Rows[v].Cells[a].Text);
                    if (entero2 > 17)
                    {
                        Plantilla.Rows[v].Cells[a].ForeColor = System.Drawing.Color.DarkOrange;
                        Plantilla.Rows[v].Cells[a].Font.Bold = true;
                    }

                    if (entero2 > 29)
                    {
                        Plantilla.Rows[v].Cells[a].ForeColor = System.Drawing.Color.Red;
                        Plantilla.Rows[v].Cells[a].Font.Bold = true;
                    }
                    if (entero2 > 40)
                    {
                        Plantilla.Rows[v].Cells[a].ForeColor = System.Drawing.Color.Firebrick;
                        Plantilla.Rows[v].Cells[a].Font.Bold = true;
                    }
                }


            }


            if (!IsPostBack)
            {
                // the code that only needs to run once goes here

                for (int r = 0; r < PlantillaStars.Rows.Count; r++)
                {
                    int JugadorST = Convert.ToInt32(Plantilla.Rows[r].Cells[4].Text);
                    int JugadorTK = Convert.ToInt32(Plantilla.Rows[r].Cells[5].Text);
                    int JugadorPS = Convert.ToInt32(Plantilla.Rows[r].Cells[6].Text);
                    int JugadorSH = Convert.ToInt32(Plantilla.Rows[r].Cells[7].Text);
                    int JugadorSM = Convert.ToInt32(Plantilla.Rows[r].Cells[8].Text);

                    int[] numbers = new int[] { JugadorST, JugadorTK, JugadorPS, JugadorSH };
                    int maximumNumber = numbers.Max();
                    Double ValorStar = 0;




                    int bandas = Plantilla.Rows[r].Cells[3].Text.Count();

                    if (maximumNumber == JugadorST)
                    {
                        ValorStar = JugadorST;
                    }
                    if (maximumNumber == JugadorTK)
                    {

                        ValorStar = (JugadorTK + (bandas * 5) + (JugadorPS * 0.4) + (JugadorSH * 0.2) + (JugadorSM * 0.2)) / 2.1;


                    }
                    if (maximumNumber == JugadorPS)
                    {

                        ValorStar = (JugadorPS + (bandas * 5) + (JugadorTK * 0.4) + (JugadorSH * 0.4) + (JugadorSM * 0.2)) / 2.3;

                    }
                    if (maximumNumber == JugadorSH)
                    {

                        ValorStar = (JugadorSH + (bandas * 5) + (JugadorTK * 0.2) + (JugadorPS * 0.4) + (JugadorSM * 0.4)) / 2.5;

                    }


                    if (ValorStar > 0)
                    {
                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-2.png\">";

                    }
                    if (ValorStar > 5)
                    {
                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\">";
                    }
                    if (ValorStar > 10)
                    {

                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                    }
                    if (ValorStar > 15)
                    {

                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                    }
                    if (ValorStar > 20)
                    {

                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                    }
                    if (ValorStar > 25)
                    {

                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                    }
                    if (ValorStar > 30)
                    {
                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";

                    }
                    if (ValorStar > 35)
                    {


                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";

                    }
                    if (ValorStar > 40)
                    {


                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";

                    }
                    if (ValorStar > 45)
                    {
                        PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";

                    }






                }



            }

            VistaPlantilla.Text = "Vista Detallada";

            if (Session["VistaPlantilla"] != null) { 
            VistaPlantilla.Text = Session["VistaPlantilla"].ToString() ;
            }


            if (VistaPlantilla.Text == "Vista General")
            {

                Plantilla.Visible = false;
                PlantillaStars.Visible = true;

            }
            if (VistaPlantilla.Text == "Vista Detallada")
            {

                Plantilla.Visible = true;
                PlantillaStars.Visible = false;

            }
        }





        protected void Plantilla_RowDataBound(object sender, GridViewRowEventArgs e)
        {


            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                int entero = Convert.ToInt32(e.Row.Cells[16].Text);
                if (entero < 50)
                {
                    e.Row.Cells[16].BackColor = System.Drawing.Color.Red;
                }
                for (int a = 4; a < 8; a++)
                {

                    int entero2 = Convert.ToInt32(e.Row.Cells[a].Text);
                    if (entero2 > 17)
                    {
                        e.Row.Cells[a].ForeColor = System.Drawing.Color.DarkOrange;
                        e.Row.Cells[a].Font.Bold = true;
                    }

                    if (entero2 > 29)
                    {
                        e.Row.Cells[a].ForeColor = System.Drawing.Color.Red;
                        e.Row.Cells[a].Font.Bold = true;
                    }
                    if (entero2 > 40)
                    {
                        e.Row.Cells[a].ForeColor = System.Drawing.Color.Firebrick;
                        e.Row.Cells[a].Font.Bold = true;
                    }

                }


            }


            /*
            for (int r = 0; r < PlantillaStars.Rows.Count; r++)
            {
                int JugadorST = Convert.ToInt32(Plantilla.Rows[r].Cells[4].Text);
                int JugadorTK = Convert.ToInt32(Plantilla.Rows[r].Cells[5].Text);
                int JugadorPS = Convert.ToInt32(Plantilla.Rows[r].Cells[6].Text);
                int JugadorSH = Convert.ToInt32(Plantilla.Rows[r].Cells[7].Text);
                int JugadorSM = Convert.ToInt32(Plantilla.Rows[r].Cells[8].Text);

                int[] numbers = new int[] { JugadorST, JugadorTK, JugadorPS, JugadorSH };
                int maximumNumber = numbers.Max();
                Double ValorStar = 0;




                int bandas = Plantilla.Rows[r].Cells[3].Text.Count();

                if (maximumNumber == JugadorST)
                {
                    ValorStar = JugadorST;
                }
                if (maximumNumber == JugadorTK)
                {

                    ValorStar = (JugadorTK + (bandas * 5) + (JugadorPS * 0.4) + (JugadorSH * 0.2) + (JugadorSM * 0.2)) / 2.1;


                }
                if (maximumNumber == JugadorPS)
                {

                    ValorStar = (JugadorPS + (bandas * 5) + (JugadorTK * 0.4) + (JugadorSH * 0.4) + (JugadorSM * 0.2)) / 2.3;

                }
                if (maximumNumber == JugadorSH)
                {

                    ValorStar = (JugadorSH + (bandas * 5) + (JugadorTK * 0.2) + (JugadorPS * 0.4) + (JugadorSM * 0.4)) / 2.5;

                }


                if (ValorStar > 0)
                {
                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-2.png\">";

                }
                if (ValorStar > 5)
                {
                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\">";
                }
                if (ValorStar > 10)
                {

                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                }
                if (ValorStar > 15)
                {

                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                }
                if (ValorStar > 20)
                {

                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";
                }
                if (ValorStar > 25)
                {

                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";
                }
                if (ValorStar > 30)
                {
                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";

                }
                if (ValorStar > 35)
                {


                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";

                }
                if (ValorStar > 40)
                {


                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-2.png\">";

                }
                if (ValorStar > 45)
                {
                    PlantillaStars.Rows[r].Cells[1].Text = " <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\"> <img src=\"/Content/ministar-4.png\">";

                }






            }*/


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Plantilla.Visible = false;
            PlantillaStars.Visible = true;
            VistaPlantilla.Text = "Vista General";

            Session["VistaPlantilla"] = "Vista General";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Plantilla.Visible = true;
            PlantillaStars.Visible = false;

            VistaPlantilla.Text = "Vista Detallada";

            Session["VistaPlantilla"] = "Vista Detallada";
        }



        protected void PlantillaStars_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            


            


        }
    }

}
        