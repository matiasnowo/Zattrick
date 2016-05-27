using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataAcces;


namespace AppWeb
{
    public partial class Tactica : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            Titulo.Text = Convert.ToString(Session["Equipo"]);

            

        }

        


        protected void DropDownList165_SelectedIndexChanged(object sender, EventArgs e)
        {


            DropDownList166.Enabled = true;



        }

        protected void DropTactic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        protected void DropDownList62_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList62.SelectedValue == "CambiarJugador")
            {

                DropDownList63.Enabled = true;
                DropDownList64.Enabled = true;


            }
            else
            {

                DropDownList63.Enabled = false;
                DropDownList64.Enabled = false;
                DropDownList260.Enabled = false;
                DropDownList174.Enabled = false;
                DropDownList175.Enabled = false;
                DropDownList176.Enabled = false;
                DropDownList261.Enabled = false;
                DropDownList262.Enabled = false;
                DropDownList263.Enabled = false;

            }


            if (DropDownList62.SelectedValue == "CambiarPosicion")
            {

               
                DropDownList64.Enabled = true;


            }


        }

        protected void DropDownList63_SelectedIndexChanged(object sender, EventArgs e)
        {


            DropDownList260.Enabled = true;

        }


        protected void DropDownList64_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                DropDownList260.Enabled = true;

            
        }

        protected void DropDownList260_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList174.Enabled = true;
            DropDownList175.Enabled = true;
            DropDownList176.Enabled = true;
        }

        protected void DropDownList174_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList175_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList261_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList262_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList176_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList261.Enabled = true;

            DropDownList262.Enabled = true;

            DropDownList263.Enabled = true;
        }

        protected void DropDownList24_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList166.Enabled = true;

        }

        protected void DropDownList164_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList163_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList157_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList158_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList159_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList160_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList161_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList162_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList166_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList167_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList168_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList169_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList170_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList171_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList172_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList173_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList66_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList67_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList304_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList305_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList306_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList307_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList308_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList309_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList310_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList311_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList312_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList313_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList314_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList315_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList317_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList316_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList318_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList319_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList320_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList321_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList322_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList178_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownList179_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList180_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList181_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList300_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList301_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList302_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList303_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        