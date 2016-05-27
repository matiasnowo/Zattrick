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

            } }



        

        protected void Plantilla_RowDataBound(object sender, GridViewRowEventArgs e)
        {


        if    (e.Row.RowType == DataControlRowType.DataRow) {

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
}

    }
}
        