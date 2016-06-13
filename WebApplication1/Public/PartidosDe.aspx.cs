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
    public partial class PartidosDe : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string name = Request.QueryString["name"];

            Session.Add("name", name);

            Titulo.Text = name;
                       
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);


            Liga.Text = Equipazo.Categoria;

           









                SqlDataSource2.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = '" + Equipazo.Categoria + "' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";

            SqlDataSource3.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] LIKE 'Copa*' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";

            SqlDataSource4.SelectCommand = "SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Amistoso' AND (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC";


            


            
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;


                if (A == B) { 

                GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            
             for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }






            
            PartidoDAO PD = new PartidoDAO();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text, GridViewTodoslosPartidos.Rows[v].Cells[6].Text);


                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;
               

            }
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text, Equipazo.Categoria);


                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text, "Copa*");


                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }
            
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text, "Amistoso");


                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            
            
            
            


        }


       /*

     protected void GridViewTodoslosPartidos_RowDataBound(object sender, GridViewRowEventArgs e)
        {


            //     
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;


                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");



            }
       //     
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


     //       
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

        //    
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            /*



            PartidoDAO PD = new PartidoDAO();
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);


            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text, GridViewTodoslosPartidos.Rows[v].Cells[6].Text);


                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }



            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text, Equipazo.Categoria);


                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text, "Copa*");


                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }


            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text, "Amistoso");


                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }




        } */
        /*
        protected void GridViewLiga_RowDataBound(object sender, GridViewRowEventArgs e)
        {



            //     
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;


                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            //     
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //       
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            //    
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }
            
            
            
            /*
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            PartidoDAO PD = new PartidoDAO();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text, GridViewTodoslosPartidos.Rows[v].Cells[6].Text);


                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }


            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text, Equipazo.Categoria);


                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text, "Copa*");


                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }


            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text, "Amistoso");


                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }
            
            
            
            

        }*/
       /*
        protected void GridViewCopa_RowDataBound(object sender, GridViewRowEventArgs e)
        {



            //     
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;


                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            //     
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //       
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            //    
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }
            /*
            PartidoDAO PD = new PartidoDAO();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text, GridViewTodoslosPartidos.Rows[v].Cells[6].Text);


                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            
            
            
            
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text, Equipazo.Categoria);


                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text, "Copa*");


                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }


            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text, "Amistoso");


                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }
            
            
            
            
        }
        */
   /*     protected void GridViewAmistosos_RowDataBound(object sender, GridViewRowEventArgs e)
        {



            //     
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewTodoslosPartidos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text;


                if (A == B)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewTodoslosPartidos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");


            }
            //     
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewLiga.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewLiga.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewLiga.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }


            //       
            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                int A = Int32.Parse(GridViewCopa.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewCopa.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewCopa.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            //    
            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {
                int A = Int32.Parse(GridViewAmistosos.Rows[v].Cells[3].Text);
                int B = Int32.Parse(GridViewAmistosos.Rows[v].Cells[4].Text);
                string EquipoA = ((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text;
                string EquipoB = ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text;

                if (A == B)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-de-color-naranja-icono-5575-16.png>";
                }

                if (A < B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }

                if (A < B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoA == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-verde-icono-4055-16.png>";
                }

                if (A > B & EquipoB == Titulo.Text)
                {

                    GridViewAmistosos.Rows[v].Cells[0].Text = "<IMG SRC=../Content/circulo-rojo-icono-9411-16.png>";
                }
                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text = ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text.Replace(" 12:00:00 a. m.", "").Replace(" 00:00:00", "").Replace(" 00:00:00", "");
            }

            
          
            
            EquipoDAO ED = new EquipoDAO();
            Model.Equipo Equipazo = new Model.Equipo();
            Equipazo = ED.GetEquipoPorNombre(Titulo.Text);
            PartidoDAO PD = new PartidoDAO();
            for (int v = 0; v < GridViewTodoslosPartidos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).Text, GridViewTodoslosPartidos.Rows[v].Cells[6].Text);


                ((HyperLink)GridViewTodoslosPartidos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

           
            for (int v = 0; v < GridViewLiga.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewLiga.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewLiga.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).Text, Equipazo.Categoria);


                ((HyperLink)GridViewLiga.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            for (int v = 0; v < GridViewCopa.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewCopa.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewCopa.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).Text, "Copa*");


                ((HyperLink)GridViewCopa.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }


            for (int v = 0; v < GridViewAmistosos.Rows.Count; v++)
            {

                Model.Partido Part = new Model.Partido();
                Part = PD.GetIDdePartidoPorLocalVisitanteFechaCompetencia(((HyperLink)GridViewAmistosos.Rows[v].Cells[2].Controls[0]).Text, ((HyperLink)GridViewAmistosos.Rows[v].Cells[5].Controls[0]).Text,
                    ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).Text, "Amistoso");


                ((HyperLink)GridViewAmistosos.Rows[v].Cells[1].Controls[0]).NavigateUrl = "/Public/partido.aspx?partido=" + Part.IDUnico;


            }

            
            
            
        }
        */
    }
}