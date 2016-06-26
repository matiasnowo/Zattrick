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
    public partial class Plantilla : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


                        string name = Request.QueryString["name"];

            Session.Add("name", name);

            Titulo.Text = name;

            //         if (Session["Equipo"] == null)
            //        {

            //            Response.Redirect("/Inicio.aspx");
            //        }

            SqlDataSource1.SelectParameters.Add("name", Titulo.Text);


            Title = "Plantilla - " + name;











            //    MejoresJugadores.Sort("Valor", SortDirection.Descending);




            if (!IsPostBack)
            {
                // the code that only needs to run once goes here

                for (int r = 0; r < PlantillaStars.Rows.Count; r++)
                {
                    int JugadorST = Convert.ToInt32(GridPlantilla.Rows[r].Cells[4].Text);
                    int JugadorTK = Convert.ToInt32(GridPlantilla.Rows[r].Cells[5].Text);
                    int JugadorPS = Convert.ToInt32(GridPlantilla.Rows[r].Cells[6].Text);
                    int JugadorSH = Convert.ToInt32(GridPlantilla.Rows[r].Cells[7].Text);
                    int JugadorSM = Convert.ToInt32(GridPlantilla.Rows[r].Cells[8].Text);

                    int[] numbers = new int[] { JugadorST, JugadorTK, JugadorPS, JugadorSH };
                    int maximumNumber = numbers.Max();
                    Double ValorStar = 0;




                    int bandas = GridPlantilla.Rows[r].Cells[3].Text.Count();

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

            Titulo.Text = "<a href ='/Public/PerfilEquipo.aspx?name=" + Titulo.Text + "' >" + Titulo.Text + "</a>";
        }

        protected void Plantilla_RowDataBound(object sender, GridViewRowEventArgs e)



        {

        }


        protected void PlantillaStars_RowDataBound(object sender, GridViewRowEventArgs e)
        {







        }



        //    for (int a = 0; a < Prueba.Count; a++)
        //   {


        //   DataList1.DataSource = Prueba;
        //     DataList1.DataBind();


        //    }




        //     ListView1.Items.Add("List item text");







    }
}
        