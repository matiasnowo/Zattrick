using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DataAcces;
using System.Windows.Forms;


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

                DropDownList64.Visible = true;
                DropDownList63.DataSourceID = "SqlDataSource5";
                DropDownList260.Visible = true;

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


                DropDownList63.Enabled = true;
                DropDownList64.Visible = false;
                DropDownList260.Enabled = true;
                DropDownList63.DataSourceID = "SqlDataSource5";
                DropDownList260.Visible = true;
                if (DropDownList260.SelectedValue != "")
                {
                    
                    DropDownList174.Enabled = true;
                    DropDownList175.Enabled = true;
                    DropDownList176.Enabled = true;

                }

            }


            if (DropDownList62.SelectedValue == "CambiarTactica")
            {


                DropDownList63.Enabled = true;
                DropDownList64.Visible = false;
                DropDownList260.Enabled = true;
                DropDownList260.Visible = false;
                DropDownList174.Enabled = true;
                DropDownList175.Enabled = true;
                DropDownList176.Enabled = true;


                DropDownList63.Items.Clear();
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("A"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("D"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("P"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("L"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("C"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue(""));
                





            }



        }

        protected void DropDownList65_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList65.SelectedValue == "CambiarJugador")
            {

                DropDownList66.Enabled = true;
                DropDownList67.Enabled = true;

                DropDownList67.Visible = true;
                DropDownList66.DataSourceID = "SqlDataSource5";
                DropDownList178.Visible = true;

            }
            else
            {

                DropDownList66.Enabled = false;
                DropDownList67.Enabled = false;
                DropDownList178.Enabled = false;
                DropDownList179.Enabled = false;
                DropDownList180.Enabled = false;
                DropDownList181.Enabled = false;
                DropDownList300.Enabled = false;
                DropDownList301.Enabled = false;
                DropDownList302.Enabled = false;

            }


            if (DropDownList65.SelectedValue == "CambiarPosicion")
            {


                DropDownList66.Enabled = true;
                DropDownList67.Visible = false;
                DropDownList66.DataSourceID = "SqlDataSource5";
                DropDownList178.Enabled = true;
                DropDownList178.Visible = true;

                if (DropDownList178.SelectedValue != "")
                {

                    DropDownList179.Enabled = true;
                    DropDownList180.Enabled = true;
                    DropDownList181.Enabled = true;

                }

            }

            if (DropDownList65.SelectedValue == "CambiarTactica")
            {


                DropDownList66.Enabled = true;
                DropDownList67.Visible = false;
                DropDownList178.Enabled = true;
                DropDownList178.Visible = false;
                DropDownList179.Enabled = true;
                DropDownList180.Enabled = true;
                DropDownList181.Enabled = true;


                DropDownList66.Items.Clear();
                DropDownList66.Items.Add(DropTactic.Items.FindByValue("A"));
                DropDownList66.Items.Add(DropTactic.Items.FindByValue("D"));
                DropDownList66.Items.Add(DropTactic.Items.FindByValue("P"));
                DropDownList66.Items.Add(DropTactic.Items.FindByValue("L"));
                DropDownList66.Items.Add(DropTactic.Items.FindByValue("C"));
                DropDownList66.Items.Add(DropTactic.Items.FindByValue(""));





            }



        }


        protected void DropDownList303_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList303.SelectedValue == "CambiarJugador")
            {

                DropDownList304.Enabled = true;
                DropDownList305.Enabled = true;

                DropDownList305.Visible = true;
                DropDownList304.DataSourceID = "SqlDataSource5";
                DropDownList306.Visible = true;

            }
            else
            {

                DropDownList304.Enabled = false;
                DropDownList305.Enabled = false;
                DropDownList306.Enabled = false;
                DropDownList307.Enabled = false;
                DropDownList308.Enabled = false;
                DropDownList309.Enabled = false;
                DropDownList310.Enabled = false;
                DropDownList311.Enabled = false;
                DropDownList312.Enabled = false;

            }


            if (DropDownList303.SelectedValue == "CambiarPosicion")
            {


                DropDownList304.Enabled = true;
                DropDownList305.Visible = false;
                DropDownList304.DataSourceID = "SqlDataSource5";
                DropDownList306.Enabled = true;
                DropDownList306.Visible = true;
                if (DropDownList306.SelectedValue != "")
                {

                    DropDownList307.Enabled = true;
                    DropDownList308.Enabled = true;
                    DropDownList309.Enabled = true;

                }

            }


            if (DropDownList303.SelectedValue == "CambiarTactica")
            {


                DropDownList304.Enabled = true;
                DropDownList305.Visible = false;
                DropDownList306.Enabled = true;
                DropDownList306.Visible = false;
                DropDownList307.Enabled = true;
                DropDownList308.Enabled = true;
                DropDownList309.Enabled = true;


                DropDownList304.Items.Clear();
                DropDownList304.Items.Add(DropTactic.Items.FindByValue("A"));
                DropDownList304.Items.Add(DropTactic.Items.FindByValue("D"));
                DropDownList304.Items.Add(DropTactic.Items.FindByValue("P"));
                DropDownList304.Items.Add(DropTactic.Items.FindByValue("L"));
                DropDownList304.Items.Add(DropTactic.Items.FindByValue("C"));
                DropDownList304.Items.Add(DropTactic.Items.FindByValue(""));





            }



        }

        protected void DropDownList313_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList313.SelectedValue == "CambiarJugador")
            {

                DropDownList314.Enabled = true;
                DropDownList315.Enabled = true;

                DropDownList315.Visible = true;
                DropDownList314.DataSourceID = "SqlDataSource5";

                DropDownList316.Visible = true;
            }
            else
            {

                DropDownList314.Enabled = false;
                DropDownList315.Enabled = false;
                DropDownList316.Enabled = false;
                DropDownList317.Enabled = false;
                DropDownList318.Enabled = false;
                DropDownList319.Enabled = false;
                DropDownList320.Enabled = false;
                DropDownList321.Enabled = false;
                DropDownList322.Enabled = false;

            }


            if (DropDownList313.SelectedValue == "CambiarPosicion")
            {

                DropDownList314.Enabled = true;
                DropDownList315.Visible = false;
                DropDownList314.DataSourceID = "SqlDataSource5";
                DropDownList316.Enabled = true;

                DropDownList316.Visible = true;
                if (DropDownList316.SelectedValue != "")
                {

                    DropDownList317.Enabled = true;
                    DropDownList318.Enabled = true;
                    DropDownList319.Enabled = true;

                }

            }

            if (DropDownList313.SelectedValue == "CambiarTactica")
            {


                DropDownList314.Enabled = true;
                DropDownList315.Visible = false;
                DropDownList316.Enabled = true;
                DropDownList316.Visible = false;
                DropDownList317.Enabled = true;
                DropDownList318.Enabled = true;
                DropDownList319.Enabled = true;

                DropDownList314.Items.Clear();
                DropDownList314.Items.Add(DropTactic.Items.FindByValue("A"));
                DropDownList314.Items.Add(DropTactic.Items.FindByValue("D"));
                DropDownList314.Items.Add(DropTactic.Items.FindByValue("P"));
                DropDownList314.Items.Add(DropTactic.Items.FindByValue("L"));
                DropDownList314.Items.Add(DropTactic.Items.FindByValue("C"));
                DropDownList314.Items.Add(DropTactic.Items.FindByValue(""));

                





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

            if (DropDownList174.SelectedValue == "SCORE")
            {

                DropDownList261.Items.FindByText("Resultado").Enabled = false;
                DropDownList261.Items.FindByText("Minuto").Enabled = true;

            }
            if (DropDownList174.SelectedValue == "MIN")
            {

                DropDownList261.Items.FindByText("Resultado").Enabled = true;
                DropDownList261.Items.FindByText("Minuto").Enabled = false;

            }








            if (DropDownList174.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList176.Items.Clear();

                DropDownList176.Items.Add(Item1);
                DropDownList176.Items.Add(Item2);
                DropDownList176.Items.Add(Item3);
                DropDownList176.Items.Add(Item4);
                DropDownList176.Items.Add(Item5);
                DropDownList176.Items.Add(Item6);
                DropDownList176.Items.Add(Item7);
                DropDownList176.Items.Add(Item8);
                DropDownList176.Items.Add(Item9);

            }

            if (DropDownList174.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList176.Items.Clear();

                DropDownList176.Items.Add(Item1);
                DropDownList176.Items.Add(Item2);
                DropDownList176.Items.Add(Item3);
                DropDownList176.Items.Add(Item4);
                DropDownList176.Items.Add(Item5);
                DropDownList176.Items.Add(Item6);
                DropDownList176.Items.Add(Item7);
                DropDownList176.Items.Add(Item8);
                DropDownList176.Items.Add(Item9);
                DropDownList176.Items.Add(Item10);
                DropDownList176.Items.Add(Item11);
                DropDownList176.Items.Add(Item12);
                DropDownList176.Items.Add(Item13);
                DropDownList176.Items.Add(Item14);
                DropDownList176.Items.Add(Item15);
                DropDownList176.Items.Add(Item16);
                DropDownList176.Items.Add(Item17);
                DropDownList176.Items.Add(Item18);

            }
        }

        protected void DropDownList175_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList261_SelectedIndexChanged(object sender, EventArgs e)
        {




            if (DropDownList261.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList263.Items.Clear();

                DropDownList263.Items.Add(Item1);
                DropDownList263.Items.Add(Item2);
                DropDownList263.Items.Add(Item3);
                DropDownList263.Items.Add(Item4);
                DropDownList263.Items.Add(Item5);
                DropDownList263.Items.Add(Item6);
                DropDownList263.Items.Add(Item7);
                DropDownList263.Items.Add(Item8);
                DropDownList263.Items.Add(Item9);

            }

            if (DropDownList261.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList263.Items.Clear();

                DropDownList263.Items.Add(Item1);
                DropDownList263.Items.Add(Item2);
                DropDownList263.Items.Add(Item3);
                DropDownList263.Items.Add(Item4);
                DropDownList263.Items.Add(Item5);
                DropDownList263.Items.Add(Item6);
                DropDownList263.Items.Add(Item7);
                DropDownList263.Items.Add(Item8);
                DropDownList263.Items.Add(Item9);
                DropDownList263.Items.Add(Item10);
                DropDownList263.Items.Add(Item11);
                DropDownList263.Items.Add(Item12);
                DropDownList263.Items.Add(Item13);
                DropDownList263.Items.Add(Item14);
                DropDownList263.Items.Add(Item15);
                DropDownList263.Items.Add(Item16);
                DropDownList263.Items.Add(Item17);
                DropDownList263.Items.Add(Item18);

            }
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

            DropDownList178.Enabled = true;

        }

        protected void DropDownList67_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList178.Enabled = true;

        }

        protected void DropDownList304_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList306.Enabled = true;

        }

        protected void DropDownList305_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList306.Enabled = true;

        }


        protected void DropDownList306_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList307.Enabled = true;
            DropDownList308.Enabled = true;
            DropDownList309.Enabled = true;
        }


        protected void DropDownList307_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList307.SelectedValue == "SCORE")
            {

                DropDownList310.Items.FindByText("Resultado").Enabled = false;
                DropDownList310.Items.FindByText("Minuto").Enabled = true;

            }
            if (DropDownList307.SelectedValue == "MIN")
            {

                DropDownList310.Items.FindByText("Resultado").Enabled = true;
                DropDownList310.Items.FindByText("Minuto").Enabled = false;

            }

            if (DropDownList307.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList309.Items.Clear();

                DropDownList309.Items.Add(Item1);
                DropDownList309.Items.Add(Item2);
                DropDownList309.Items.Add(Item3);
                DropDownList309.Items.Add(Item4);
                DropDownList309.Items.Add(Item5);
                DropDownList309.Items.Add(Item6);
                DropDownList309.Items.Add(Item7);
                DropDownList309.Items.Add(Item8);
                DropDownList309.Items.Add(Item9);

            }

            if (DropDownList307.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList309.Items.Clear();

                DropDownList309.Items.Add(Item1);
                DropDownList309.Items.Add(Item2);
                DropDownList309.Items.Add(Item3);
                DropDownList309.Items.Add(Item4);
                DropDownList309.Items.Add(Item5);
                DropDownList309.Items.Add(Item6);
                DropDownList309.Items.Add(Item7);
                DropDownList309.Items.Add(Item8);
                DropDownList309.Items.Add(Item9);
                DropDownList309.Items.Add(Item10);
                DropDownList309.Items.Add(Item11);
                DropDownList309.Items.Add(Item12);
                DropDownList309.Items.Add(Item13);
                DropDownList309.Items.Add(Item14);
                DropDownList309.Items.Add(Item15);
                DropDownList309.Items.Add(Item16);
                DropDownList309.Items.Add(Item17);
                DropDownList309.Items.Add(Item18);

            }
        }

        protected void DropDownList308_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList309_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList310.Enabled = true;
            DropDownList311.Enabled = true;
            DropDownList312.Enabled = true;

           
        }

        protected void DropDownList310_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (DropDownList310.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList312.Items.Clear();

                DropDownList312.Items.Add(Item1);
                DropDownList312.Items.Add(Item2);
                DropDownList312.Items.Add(Item3);
                DropDownList312.Items.Add(Item4);
                DropDownList312.Items.Add(Item5);
                DropDownList312.Items.Add(Item6);
                DropDownList312.Items.Add(Item7);
                DropDownList312.Items.Add(Item8);
                DropDownList312.Items.Add(Item9);

            }

            if (DropDownList310.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList312.Items.Clear();

                DropDownList312.Items.Add(Item1);
                DropDownList312.Items.Add(Item2);
                DropDownList312.Items.Add(Item3);
                DropDownList312.Items.Add(Item4);
                DropDownList312.Items.Add(Item5);
                DropDownList312.Items.Add(Item6);
                DropDownList312.Items.Add(Item7);
                DropDownList312.Items.Add(Item8);
                DropDownList312.Items.Add(Item9);
                DropDownList312.Items.Add(Item10);
                DropDownList312.Items.Add(Item11);
                DropDownList312.Items.Add(Item12);
                DropDownList312.Items.Add(Item13);
                DropDownList312.Items.Add(Item14);
                DropDownList312.Items.Add(Item15);
                DropDownList312.Items.Add(Item16);
                DropDownList312.Items.Add(Item17);
                DropDownList312.Items.Add(Item18);

            }
        }

        protected void DropDownList311_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList312_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList314_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList316.Enabled = true;
        }

        protected void DropDownList315_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList316.Enabled = true;

        }

        protected void DropDownList317_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList317.SelectedValue == "SCORE")
            {

                DropDownList320.Items.FindByText("Resultado").Enabled = false;
                DropDownList320.Items.FindByText("Minuto").Enabled = true;

            }
            if (DropDownList317.SelectedValue == "MIN")
            {

                DropDownList320.Items.FindByText("Resultado").Enabled = true;
                DropDownList320.Items.FindByText("Minuto").Enabled = false;

            }

            if (DropDownList317.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList319.Items.Clear();

                DropDownList319.Items.Add(Item1);
                DropDownList319.Items.Add(Item2);
                DropDownList319.Items.Add(Item3);
                DropDownList319.Items.Add(Item4);
                DropDownList319.Items.Add(Item5);
                DropDownList319.Items.Add(Item6);
                DropDownList319.Items.Add(Item7);
                DropDownList319.Items.Add(Item8);
                DropDownList319.Items.Add(Item9);

            }

            if (DropDownList317.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList319.Items.Clear();

                DropDownList319.Items.Add(Item1);
                DropDownList319.Items.Add(Item2);
                DropDownList319.Items.Add(Item3);
                DropDownList319.Items.Add(Item4);
                DropDownList319.Items.Add(Item5);
                DropDownList319.Items.Add(Item6);
                DropDownList319.Items.Add(Item7);
                DropDownList319.Items.Add(Item8);
                DropDownList319.Items.Add(Item9);
                DropDownList319.Items.Add(Item10);
                DropDownList319.Items.Add(Item11);
                DropDownList319.Items.Add(Item12);
                DropDownList319.Items.Add(Item13);
                DropDownList319.Items.Add(Item14);
                DropDownList319.Items.Add(Item15);
                DropDownList319.Items.Add(Item16);
                DropDownList319.Items.Add(Item17);
                DropDownList319.Items.Add(Item18);

            }
        }

        protected void DropDownList316_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList317.Enabled = true;
            DropDownList318.Enabled = true;
            DropDownList319.Enabled = true;
        }


        protected void DropDownList318_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList319_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList320.Enabled = true;
            DropDownList321.Enabled = true;
            DropDownList322.Enabled = true;
        }

        protected void DropDownList320_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (DropDownList320.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList322.Items.Clear();

                DropDownList322.Items.Add(Item1);
                DropDownList322.Items.Add(Item2);
                DropDownList322.Items.Add(Item3);
                DropDownList322.Items.Add(Item4);
                DropDownList322.Items.Add(Item5);
                DropDownList322.Items.Add(Item6);
                DropDownList322.Items.Add(Item7);
                DropDownList322.Items.Add(Item8);
                DropDownList322.Items.Add(Item9);

            }

            if (DropDownList320.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList322.Items.Clear();

                DropDownList322.Items.Add(Item1);
                DropDownList322.Items.Add(Item2);
                DropDownList322.Items.Add(Item3);
                DropDownList322.Items.Add(Item4);
                DropDownList322.Items.Add(Item5);
                DropDownList322.Items.Add(Item6);
                DropDownList322.Items.Add(Item7);
                DropDownList322.Items.Add(Item8);
                DropDownList322.Items.Add(Item9);
                DropDownList322.Items.Add(Item10);
                DropDownList322.Items.Add(Item11);
                DropDownList322.Items.Add(Item12);
                DropDownList322.Items.Add(Item13);
                DropDownList322.Items.Add(Item14);
                DropDownList322.Items.Add(Item15);
                DropDownList322.Items.Add(Item16);
                DropDownList322.Items.Add(Item17);
                DropDownList322.Items.Add(Item18);

            }
        }

        protected void DropDownList321_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList322_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void DropDownList178_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownList179.Enabled = true;
            DropDownList180.Enabled = true;
            DropDownList181.Enabled = true;
        }

        protected void DropDownList179_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList179.SelectedValue == "SCORE")
            {

                DropDownList300.Items.FindByText("Resultado").Enabled = false;
                DropDownList300.Items.FindByText("Minuto").Enabled = true;

            }
            if (DropDownList179.SelectedValue == "MIN")
            {

                DropDownList300.Items.FindByText("Resultado").Enabled = true;
                DropDownList300.Items.FindByText("Minuto").Enabled = false;

            }


            if (DropDownList179.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList181.Items.Clear();

                DropDownList181.Items.Add(Item1);
                DropDownList181.Items.Add(Item2);
                DropDownList181.Items.Add(Item3);
                DropDownList181.Items.Add(Item4);
                DropDownList181.Items.Add(Item5);
                DropDownList181.Items.Add(Item6);
                DropDownList181.Items.Add(Item7);
                DropDownList181.Items.Add(Item8);
                DropDownList181.Items.Add(Item9);

            }

            if (DropDownList179.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList181.Items.Clear();

                DropDownList181.Items.Add(Item1);
                DropDownList181.Items.Add(Item2);
                DropDownList181.Items.Add(Item3);
                DropDownList181.Items.Add(Item4);
                DropDownList181.Items.Add(Item5);
                DropDownList181.Items.Add(Item6);
                DropDownList181.Items.Add(Item7);
                DropDownList181.Items.Add(Item8);
                DropDownList181.Items.Add(Item9);
                DropDownList181.Items.Add(Item10);
                DropDownList181.Items.Add(Item11);
                DropDownList181.Items.Add(Item12);
                DropDownList181.Items.Add(Item13);
                DropDownList181.Items.Add(Item14);
                DropDownList181.Items.Add(Item15);
                DropDownList181.Items.Add(Item16);
                DropDownList181.Items.Add(Item17);
                DropDownList181.Items.Add(Item18);

            }

        }

        protected void DropDownList180_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void DropDownList181_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList300.Enabled = true;
            DropDownList301.Enabled = true;
            DropDownList302.Enabled = true;

           
        }


        protected void DropDownList300_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList300.SelectedValue == "SCORE")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "-4";
                ListItem Item2 = new ListItem();
                Item2.Text = "-3";
                ListItem Item3 = new ListItem();
                Item3.Text = "-2";
                ListItem Item4 = new ListItem();
                Item4.Text = "-1";
                ListItem Item5 = new ListItem();
                Item5.Text = "0";
                ListItem Item6 = new ListItem();
                Item6.Text = "1";
                ListItem Item7 = new ListItem();
                Item7.Text = "2";
                ListItem Item8 = new ListItem();
                Item8.Text = "3";
                ListItem Item9 = new ListItem();
                Item9.Text = "4";

                DropDownList302.Items.Clear();

                DropDownList302.Items.Add(Item1);
                DropDownList302.Items.Add(Item2);
                DropDownList302.Items.Add(Item3);
                DropDownList302.Items.Add(Item4);
                DropDownList302.Items.Add(Item5);
                DropDownList302.Items.Add(Item6);
                DropDownList302.Items.Add(Item7);
                DropDownList302.Items.Add(Item8);
                DropDownList302.Items.Add(Item9);

            }

            if (DropDownList300.SelectedValue == "MIN")
            {
                ListItem Item1 = new ListItem();
                Item1.Text = "5";
                ListItem Item2 = new ListItem();
                Item2.Text = "10";
                ListItem Item3 = new ListItem();
                Item3.Text = "15";
                ListItem Item4 = new ListItem();
                Item4.Text = "20";
                ListItem Item5 = new ListItem();
                Item5.Text = "25";
                ListItem Item6 = new ListItem();
                Item6.Text = "30";
                ListItem Item7 = new ListItem();
                Item7.Text = "35";
                ListItem Item8 = new ListItem();
                Item8.Text = "40";
                ListItem Item9 = new ListItem();
                Item9.Text = "45";
                ListItem Item10 = new ListItem();
                Item10.Text = "50";
                ListItem Item11 = new ListItem();
                Item11.Text = "55";
                ListItem Item12 = new ListItem();
                Item12.Text = "60";
                ListItem Item13 = new ListItem();
                Item13.Text = "65";
                ListItem Item14 = new ListItem();
                Item14.Text = "70";
                ListItem Item15 = new ListItem();
                Item15.Text = "75";
                ListItem Item16 = new ListItem();
                Item16.Text = "80";
                ListItem Item17 = new ListItem();
                Item17.Text = "85";
                ListItem Item18 = new ListItem();
                Item18.Text = "90";

                DropDownList302.Items.Clear();

                DropDownList302.Items.Add(Item1);
                DropDownList302.Items.Add(Item2);
                DropDownList302.Items.Add(Item3);
                DropDownList302.Items.Add(Item4);
                DropDownList302.Items.Add(Item5);
                DropDownList302.Items.Add(Item6);
                DropDownList302.Items.Add(Item7);
                DropDownList302.Items.Add(Item8);
                DropDownList302.Items.Add(Item9);
                DropDownList302.Items.Add(Item10);
                DropDownList302.Items.Add(Item11);
                DropDownList302.Items.Add(Item12);
                DropDownList302.Items.Add(Item13);
                DropDownList302.Items.Add(Item14);
                DropDownList302.Items.Add(Item15);
                DropDownList302.Items.Add(Item16);
                DropDownList302.Items.Add(Item17);
                DropDownList302.Items.Add(Item18);

            }
        }

        protected void DropDownList301_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList302_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Guardar_Click(object sender, EventArgs e)
        {


            int DeboActualizar1 = 1;
            int DeboActualizar2 = 1;
            int DeboActualizar3 = 1;
            int DeboActualizar4 = 1;






            TacticasDAO TD = new TacticasDAO();
            EquipoDAO ED = new EquipoDAO();

            Model.Tactica TacticaAEnviar = new Model.Tactica();
            string Archivo = ED.GetNombreArchivoDeEquipo(Titulo.Text);

            TacticaAEnviar.Equipo = Archivo.Replace(".txt", "");
            TacticaAEnviar.Tactic = DropTactic.SelectedValue;
            TacticaAEnviar.Player1 = "GK " + DropDownList156.SelectedItem.Text;
            TacticaAEnviar.Player2 = "DF" + DropDownList13.SelectedValue + " " + DropDownList24.SelectedItem.Text;
            TacticaAEnviar.Player3 = "DF" + DropDownList140.SelectedValue + " " + DropDownList157.SelectedItem.Text;
            TacticaAEnviar.Player4 = "DF" + DropDownList141.SelectedValue + " " + DropDownList158.SelectedItem.Text;
            TacticaAEnviar.Player5 = DropDownList5.SelectedValue + DropDownList142.SelectedValue + " " + DropDownList159.SelectedItem.Text;
            TacticaAEnviar.Player6 = DropDownList124.SelectedValue + DropDownList143.SelectedValue + " " + DropDownList160.SelectedItem.Text;
            TacticaAEnviar.Player7 = DropDownList125.SelectedValue + DropDownList144.SelectedValue + " " + DropDownList161.SelectedItem.Text;
            TacticaAEnviar.Player8 = DropDownList126.SelectedValue + DropDownList145.SelectedValue + " " + DropDownList162.SelectedItem.Text;
            TacticaAEnviar.Player9 = DropDownList130.SelectedValue + DropDownList146.SelectedValue + " " + DropDownList163.SelectedItem.Text;
            TacticaAEnviar.Player10 = DropDownList131.SelectedValue + DropDownList147.SelectedValue + " " + DropDownList164.SelectedItem.Text;
            TacticaAEnviar.Player11 = DropDownList129.SelectedValue + DropDownList148.SelectedValue + " " + DropDownList165.SelectedItem.Text;
            TacticaAEnviar.PK = "PK: " + DropDownList166.SelectedItem.Text;
            TacticaAEnviar.Sustitute1 = "GK " + DropDownList167.SelectedItem.Text;
            TacticaAEnviar.Sustitute2 = DropDownList133.SelectedValue + DropDownList254.SelectedValue + " " + DropDownList168.SelectedItem.Text;
            TacticaAEnviar.Sustitute3 = DropDownList134.SelectedValue + DropDownList255.SelectedValue + " " + DropDownList169.SelectedItem.Text;
            TacticaAEnviar.Sustitute4 = DropDownList135.SelectedValue + DropDownList256.SelectedValue + " " + DropDownList170.SelectedItem.Text;
            TacticaAEnviar.Sustitute5 = DropDownList136.SelectedValue + DropDownList257.SelectedValue + " " + DropDownList171.SelectedItem.Text;
            TacticaAEnviar.Sustitute6 = DropDownList137.SelectedValue + DropDownList258.SelectedValue + " " + DropDownList172.SelectedItem.Text;
            TacticaAEnviar.Sustitute7 = DropDownList138.SelectedValue + DropDownList259.SelectedValue + " " + DropDownList173.SelectedItem.Text;



            if (TacticaAEnviar.Tactic == "")
            {
                MessageBox.Show("No has seleccionado un Tipo de Tactica (Ej. Atacante, Defensiva..)");
                DeboActualizar1 = 0;
            }



            if (Orden1Boolean.Checked == true)
            {



                if (DropDownList260.SelectedValue == "")
                {
                    if (DropDownList62.SelectedValue != "CambiarTactica")
                    {
                        MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 1");
                    DeboActualizar1 = 0;
                    }
                }
                if (DropDownList174.SelectedValue == "")
                {
                    
                        DeboActualizar1 = 0;
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 1 (Campo 1)");
                    
                }
                if (DropDownList175.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 1 (Campo 2)");
                    DeboActualizar1 = 0;
                }
                if (DropDownList176.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 1 (Campo 3)");
                    DeboActualizar1 = 0;
                }

                if (DropDownList261.SelectedValue == "" && (DropDownList262.SelectedValue != "" || DropDownList263.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 1 (Campo 1)");
                    DeboActualizar1 = 0;
                }

                if (DropDownList262.SelectedValue == "" && (DropDownList261.SelectedValue != "" || DropDownList263.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 1 (Campo 2)");
                    DeboActualizar1 = 0;
                }

                if (DropDownList263.SelectedValue == "" && (DropDownList261.SelectedValue != "" || DropDownList262.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 1 (Campo 3)");
                    DeboActualizar1 = 0;
                }




                if (DropDownList62.SelectedValue == "CambiarJugador")
                {
                    if (DropDownList261.SelectedValue != "")
                    {
                        TacticaAEnviar.Order1 = "SUB " + DropDownList63.SelectedItem.Text + " " + DropDownList64.SelectedItem.Text + " " + DropDownList260.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue + ", " + DropDownList261.SelectedValue + " " + DropDownList262.SelectedValue + " " + DropDownList263.SelectedValue;
                    }
                    if (DropDownList261.SelectedValue == "")
                    {
                        TacticaAEnviar.Order1 = "SUB " + DropDownList63.SelectedItem.Text + " " + DropDownList64.SelectedItem.Text + " " + DropDownList260.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue;
                    }
                    if (DropDownList63.SelectedItem.Text == DropDownList64.SelectedItem.Text)
                    {
                        MessageBox.Show("El jugador que sale, no puede ser el mismo que entra en la Orden 1");
                        DeboActualizar1 = 0;
                    }
                }

                if (DropDownList62.SelectedValue == "CambiarPosicion")
                {
                    if (DropDownList261.SelectedValue != "")
                    {
                        TacticaAEnviar.Order1 = "CHANGEPOS " + DropDownList63.SelectedItem.Text + " " + DropDownList260.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue + ", " + DropDownList261.SelectedValue + " " + DropDownList262.SelectedValue + " " + DropDownList263.SelectedValue;
                    }
                    if (DropDownList261.SelectedValue == "")
                    {
                        TacticaAEnviar.Order1 = "CHANGEPOS " + DropDownList63.SelectedItem.Text + " " + DropDownList260.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue;
                    }
                }

                if (DropDownList62.SelectedValue == "CambiarTactica")
                {
                    if (DropDownList261.SelectedValue != "")
                    {
                        TacticaAEnviar.Order1 = "TACTIC " + DropDownList63.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue + ", " + DropDownList261.SelectedValue + " " + DropDownList262.SelectedValue + " " + DropDownList263.SelectedValue;
                    }
                    if (DropDownList261.SelectedValue == "")
                    {
                        TacticaAEnviar.Order1 = "TACTIC " + DropDownList63.SelectedValue + " IF " + DropDownList174.SelectedValue + " " + DropDownList175.SelectedValue + " " + DropDownList176.SelectedValue;
                    }
                }
            }




            if (Orden2Boolean.Checked == true)
            {
                if (DropDownList65.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 2");
                    DeboActualizar2 = 0;
                }

                if (DropDownList178.SelectedValue == "")
                {
                    if (DropDownList65.SelectedValue != "CambiarTactica")
                    {
                        MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 2");
                    DeboActualizar2 = 0;
                    }
                }
                if (DropDownList179.SelectedValue == "")
                {
                    DeboActualizar2 = 0;
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 2 (Campo 1)");
                }
                if (DropDownList180.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 2 (Campo 2)");
                    DeboActualizar2 = 0;
                }
                if (DropDownList181.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 2 (Campo 3)");
                    DeboActualizar2 = 0;
                }

                if (DropDownList300.SelectedValue == "" && (DropDownList301.SelectedValue != "" || DropDownList302.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 2 (Campo 1)");
                    DeboActualizar2 = 0;
                }

                if (DropDownList301.SelectedValue == "" && (DropDownList300.SelectedValue != "" || DropDownList302.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 2 (Campo 2)");
                    DeboActualizar2 = 0;
                }

                if (DropDownList302.SelectedValue == "" && (DropDownList300.SelectedValue != "" || DropDownList301.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 2 (Campo 3)");
                    DeboActualizar2 = 0;
                }


                if (DropDownList65.SelectedValue == "CambiarJugador")
                {
                    if (DropDownList300.SelectedValue != "")
                    {
                        TacticaAEnviar.Order2 = "SUB " + DropDownList66.SelectedItem.Text + " " + DropDownList67.SelectedItem.Text + " " + DropDownList178.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue + ", " + DropDownList300.SelectedValue + " " + DropDownList301.SelectedValue + " " + DropDownList302.SelectedValue;
                    }
                    if (DropDownList300.SelectedValue == "")
                    {
                        TacticaAEnviar.Order2 = "SUB " + DropDownList66.SelectedItem.Text + " " + DropDownList67.SelectedItem.Text + " " + DropDownList178.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue;
                    }
                    if (DropDownList66.SelectedItem.Text == DropDownList67.SelectedItem.Text)
                    {
                        MessageBox.Show("El jugador que sale, no puede ser el mismo que entra en la Orden 2");
                        DeboActualizar2 = 0;
                    }
                }
                if (DropDownList65.SelectedValue == "CambiarPosicion")
                {
                    if (DropDownList300.SelectedValue != "")
                    {
                        TacticaAEnviar.Order2 = "CHANGEPOS " + DropDownList66.SelectedItem.Text + " " + DropDownList178.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue + ", " + DropDownList300.SelectedValue + " " + DropDownList301.SelectedValue + " " + DropDownList302.SelectedValue;
                    }
                    if (DropDownList300.SelectedValue == "")
                    {
                        TacticaAEnviar.Order2 = "CHANGEPOS " + DropDownList66.SelectedItem.Text + " " + DropDownList178.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue;
                    }
                }

                if (DropDownList65.SelectedValue == "CambiarTactica")
                {
                    if (DropDownList300.SelectedValue != "")
                    {
                        TacticaAEnviar.Order2 = "TACTIC " + DropDownList66.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue + ", " + DropDownList300.SelectedValue + " " + DropDownList301.SelectedValue + " " + DropDownList302.SelectedValue;
                    }
                    if (DropDownList300.SelectedValue == "")
                    {
                        TacticaAEnviar.Order2 = "TACTIC " + DropDownList66.SelectedValue + " IF " + DropDownList179.SelectedValue + " " + DropDownList180.SelectedValue + " " + DropDownList181.SelectedValue;
                    }
                }
            }




            if (Orden3Boolean.Checked == true)
            {
                if (DropDownList303.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 3");
                    DeboActualizar3 = 0;
                }

                if (DropDownList306.SelectedValue == "")
                {
                    if (DropDownList303.SelectedValue != "CambiarTactica")
                    {
                        MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 3");
                    DeboActualizar3 = 0;
                    }
                }
                if (DropDownList307.SelectedValue == "")
                {
                    DeboActualizar3 = 0;
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 3 (Campo 1)");
                }
                if (DropDownList308.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 3 (Campo 2)");
                    DeboActualizar3 = 0;
                }
                if (DropDownList309.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 3 (Campo 3)");
                    DeboActualizar3 = 0;
                }

                if (DropDownList310.SelectedValue == "" && (DropDownList311.SelectedValue != "" || DropDownList312.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 3 (Campo 1)");
                    DeboActualizar3 = 0;
                }

                if (DropDownList311.SelectedValue == "" && (DropDownList310.SelectedValue != "" || DropDownList312.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 3 (Campo 2)");
                    DeboActualizar3 = 0;
                }

                if (DropDownList312.SelectedValue == "" && (DropDownList310.SelectedValue != "" || DropDownList311.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 3 (Campo 3)");
                    DeboActualizar3 = 0;
                }


                if (DropDownList303.SelectedValue == "CambiarJugador")
                {
                    if (DropDownList310.SelectedValue != "")
                    {
                        TacticaAEnviar.Order3 = "SUB " + DropDownList304.SelectedItem.Text + " " + DropDownList305.SelectedItem.Text + " " + DropDownList306.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue + ", " + DropDownList310.SelectedValue + " " + DropDownList311.SelectedValue + " " + DropDownList312.SelectedValue;
                    }
                    if (DropDownList310.SelectedValue == "")
                    {
                        TacticaAEnviar.Order3 = "SUB " + DropDownList304.SelectedItem.Text + " " + DropDownList305.SelectedItem.Text + " " + DropDownList306.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue;
                    }

                    if (DropDownList304.SelectedItem.Text == DropDownList305.SelectedItem.Text)
                    {
                        MessageBox.Show("El jugador que sale, no puede ser el mismo que entra en la Orden 3");
                        DeboActualizar3 = 0;
                    }
                }
                if (DropDownList303.SelectedValue == "CambiarPosicion")
                {
                    if (DropDownList310.SelectedValue != "")
                    {
                        TacticaAEnviar.Order3 = "CHANGEPOS " + DropDownList304.SelectedItem.Text + " " + DropDownList306.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue + ", " + DropDownList310.SelectedValue + " " + DropDownList311.SelectedValue + " " + DropDownList312.SelectedValue;
                    }
                    if (DropDownList310.SelectedValue == "")
                    {
                        TacticaAEnviar.Order3 = "CHANGEPOS " + DropDownList304.SelectedItem.Text + " " + DropDownList306.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue;
                    }
                }

                if (DropDownList303.SelectedValue == "CambiarTactica")
                {
                    if (DropDownList310.SelectedValue != "")
                    {
                        TacticaAEnviar.Order3 = "TACTIC " + DropDownList304.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue + ", " + DropDownList310.SelectedValue + " " + DropDownList311.SelectedValue + " " + DropDownList312.SelectedValue;
                    }
                    if (DropDownList310.SelectedValue == "")
                    {
                        TacticaAEnviar.Order3 = "TACTIC " + DropDownList304.SelectedValue + " IF " + DropDownList307.SelectedValue + " " + DropDownList308.SelectedValue + " " + DropDownList309.SelectedValue;
                    }
                }


            }

            if (Orden4Boolean.Checked == true)
            {
                if (DropDownList313.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 4");
                    DeboActualizar4 = 0;
                }

                if (DropDownList316.SelectedValue == "")
                {
                    if (DropDownList313.SelectedValue != "CambiarTactica") { 
                    MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 4");
                    DeboActualizar4 = 0;
                    }
                }
                if (DropDownList317.SelectedValue == "")
                {
                    DeboActualizar4 = 0;
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 4 (Campo 1)");
                }
                if (DropDownList318.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 4 (Campo 2)");
                    DeboActualizar4 = 0;
                }
                if (DropDownList319.SelectedValue == "")
                {
                    MessageBox.Show("Verifica el Condicional 1 de la Orden 4 (Campo 3)");
                    DeboActualizar4 = 0;
                }

                if (DropDownList320.SelectedValue == "" && (DropDownList321.SelectedValue != "" || DropDownList322.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 4 (Campo 1)");
                    DeboActualizar4 = 0;
                }

                if (DropDownList321.SelectedValue == "" && (DropDownList320.SelectedValue != "" || DropDownList322.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 4 (Campo 2)");
                    DeboActualizar4 = 0;
                }

                if (DropDownList322.SelectedValue == "" && (DropDownList320.SelectedValue != "" || DropDownList321.SelectedValue != ""))
                {
                    MessageBox.Show("Verifica el Condicional 2 de la Orden 4 (Campo 3)");
                    DeboActualizar4 = 0;
                }

                if (Orden1Boolean.Checked == true)
                {
                    if (DropDownList313.SelectedValue == "CambiarJugador")
                    {
                        if (DropDownList320.SelectedValue != "")
                        {
                            TacticaAEnviar.Order4 = "SUB " + DropDownList314.SelectedItem.Text + " " + DropDownList315.SelectedItem.Text + " " + DropDownList316.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue + ", " + DropDownList320.SelectedValue + " " + DropDownList321.SelectedValue + " " + DropDownList322.SelectedValue;
                        }
                        if (DropDownList320.SelectedValue == "")
                        {
                            TacticaAEnviar.Order4 = "SUB " + DropDownList314.SelectedItem.Text + " " + DropDownList315.SelectedItem.Text + " " + DropDownList316.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue;
                        }

                        if (DropDownList314.SelectedItem.Text == DropDownList315.SelectedItem.Text)
                        {
                            MessageBox.Show("El jugador que sale, no puede ser el mismo que entra en la Orden 4");
                            DeboActualizar4 = 0;
                        }
                    }
                    if (DropDownList313.SelectedValue == "CambiarPosicion")
                    {
                        if (DropDownList320.SelectedValue != "")
                        {
                            TacticaAEnviar.Order4 = "CHANGEPOS " + DropDownList314.SelectedItem.Text + " " + DropDownList316.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue + ", " + DropDownList320.SelectedValue + " " + DropDownList321.SelectedValue + " " + DropDownList322.SelectedValue;
                        }
                        if (DropDownList320.SelectedValue == "")
                        {
                            TacticaAEnviar.Order4 = "CHANGEPOS " + DropDownList314.SelectedItem.Text + " " + DropDownList316.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue;
                        }
                    }

                    if (DropDownList313.SelectedValue == "CambiarTactica")
                    {
                        if (DropDownList320.SelectedValue != "")
                        {
                            TacticaAEnviar.Order4 = "TACTIC " + DropDownList314.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue + ", " + DropDownList320.SelectedValue + " " + DropDownList321.SelectedValue + " " + DropDownList322.SelectedValue;
                        }
                        if (DropDownList320.SelectedValue == "")
                        {
                            TacticaAEnviar.Order4 = "TACTIC " + DropDownList314.SelectedValue + " IF " + DropDownList317.SelectedValue + " " + DropDownList318.SelectedValue + " " + DropDownList319.SelectedValue;
                        }
                    }
                }

            }


// Verifico Que no se repitan jugadores entre los Titulares


            List<string> Convocados = new List<string>();
            Convocados.Add(DropDownList156.SelectedItem.Text);
            Convocados.Add(DropDownList24.SelectedItem.Text);
            Convocados.Add(DropDownList157.SelectedItem.Text);
            Convocados.Add(DropDownList158.SelectedItem.Text);
            Convocados.Add(DropDownList159.SelectedItem.Text);
            Convocados.Add(DropDownList160.SelectedItem.Text);
            Convocados.Add(DropDownList161.SelectedItem.Text);
            Convocados.Add(DropDownList162.SelectedItem.Text);
            Convocados.Add(DropDownList163.SelectedItem.Text);
            Convocados.Add(DropDownList164.SelectedItem.Text);
            Convocados.Add(DropDownList165.SelectedItem.Text);
            Convocados.Add(DropDownList167.SelectedItem.Text);
            Convocados.Add(DropDownList168.SelectedItem.Text);
            Convocados.Add(DropDownList169.SelectedItem.Text);
            Convocados.Add(DropDownList170.SelectedItem.Text);
            Convocados.Add(DropDownList171.SelectedItem.Text);
            Convocados.Add(DropDownList172.SelectedItem.Text);
            Convocados.Add(DropDownList173.SelectedItem.Text);

            for (int v = 0; v < Convocados.Count; v++)
            {

                for (int p = 0; p < Convocados.Count; p++)
                {
                    if (v != p) {
                        if (Convocados.ElementAt(v) == Convocados.ElementAt(p)){



                            MessageBox.Show("El jugador " + Convocados.ElementAt(v) + ", no puede estar dos veces convocado");


                            DeboActualizar1 = 0;

                            v = Convocados.Count;
                            p = Convocados.Count;
                        }





                    }
                }



                if (DeboActualizar1 == 1 && DeboActualizar2 == 1 && DeboActualizar3 == 1 && DeboActualizar4 == 1) {
                    TD.ActualizarTxtdeTactica(TacticaAEnviar);

                }

            } } 

                //  MessageBox.Show("El nombre de usuario no existe o la contraseña es incorrecta!");


         

       








        protected void DropDownList156_SelectedIndexChanged(object sender, EventArgs e)
        {










        }

        protected void Cargar_Click(object sender, EventArgs e)
        {
          


            TacticasDAO TD = new TacticasDAO();
            Model.Tactica TacticaTraida = new Model.Tactica();

            TacticaTraida = TD.TraerTacticadeTXT(Titulo.Text);


            DropTactic.SelectedValue = TacticaTraida.Tactic;
            DropDownList156.SelectedValue = TacticaTraida.Player1;
            DropDownList13.SelectedValue = TacticaTraida.BandPlayer2;
            DropDownList24.SelectedValue = TacticaTraida.Player2;
            DropDownList140.SelectedValue = TacticaTraida.BandPlayer3;
            DropDownList157.SelectedValue = TacticaTraida.Player3;
            DropDownList141.SelectedValue = TacticaTraida.BandPlayer4;
            DropDownList158.SelectedValue = TacticaTraida.Player4;
            DropDownList5.SelectedValue = TacticaTraida.PositionPlayer5;
            DropDownList142.SelectedValue = TacticaTraida.BandPlayer5;
            DropDownList159.SelectedValue = TacticaTraida.Player5;
            DropDownList124.SelectedValue = TacticaTraida.PositionPlayer6;
            DropDownList143.SelectedValue = TacticaTraida.BandPlayer6;
            DropDownList160.SelectedValue = TacticaTraida.Player6;
            DropDownList125.SelectedValue = TacticaTraida.PositionPlayer7;
            DropDownList144.SelectedValue = TacticaTraida.BandPlayer7;
            DropDownList161.SelectedValue = TacticaTraida.Player7;
            DropDownList126.SelectedValue = TacticaTraida.PositionPlayer8;
            DropDownList145.SelectedValue = TacticaTraida.BandPlayer8;
            DropDownList162.SelectedValue = TacticaTraida.Player8;
            DropDownList130.SelectedValue = TacticaTraida.PositionPlayer9;
            DropDownList146.SelectedValue = TacticaTraida.BandPlayer9;
            DropDownList163.SelectedValue = TacticaTraida.Player9;
            DropDownList131.SelectedValue = TacticaTraida.PositionPlayer10;
            DropDownList147.SelectedValue = TacticaTraida.BandPlayer10;
            DropDownList164.SelectedValue = TacticaTraida.Player10;
            DropDownList129.SelectedValue = TacticaTraida.PositionPlayer11;
            DropDownList148.SelectedValue = TacticaTraida.BandPlayer11;
            DropDownList165.SelectedValue = TacticaTraida.Player11;
            DropDownList167.SelectedValue = TacticaTraida.Sustitute1;
            DropDownList133.SelectedValue = TacticaTraida.PositionSustitute2;
            DropDownList254.SelectedValue = TacticaTraida.BandSustitute2;
            DropDownList168.SelectedValue = TacticaTraida.Sustitute2;
            DropDownList134.SelectedValue = TacticaTraida.PositionSustitute3;
            DropDownList255.SelectedValue = TacticaTraida.BandSustitute3;
            DropDownList169.SelectedValue = TacticaTraida.Sustitute3;
            DropDownList135.SelectedValue = TacticaTraida.PositionSustitute4;
            DropDownList256.SelectedValue = TacticaTraida.BandSustitute4;
            DropDownList170.SelectedValue = TacticaTraida.Sustitute4;
            DropDownList136.SelectedValue = TacticaTraida.PositionSustitute5;
            DropDownList257.SelectedValue = TacticaTraida.BandSustitute5;
            DropDownList171.SelectedValue = TacticaTraida.Sustitute5;
            DropDownList137.SelectedValue = TacticaTraida.PositionSustitute6;
            DropDownList258.SelectedValue = TacticaTraida.BandSustitute6;
            DropDownList172.SelectedValue = TacticaTraida.Sustitute6;
            DropDownList138.SelectedValue = TacticaTraida.PositionSustitute7;
            DropDownList259.SelectedValue = TacticaTraida.BandSustitute7;
            DropDownList173.SelectedValue = TacticaTraida.Sustitute7;

            DropDownList166.DataBind();
            DropDownList166.SelectedValue = TacticaTraida.PK;



            if (TacticaTraida.Order1.Substring(0, 1) == "S")
            {
                DropDownList63.DataBind();
                DropDownList64.DataBind();
                DropDownList260.DataBind();
                DropDownList174.DataBind();
                DropDownList175.DataBind();
                DropDownList176.DataBind();
                DropDownList261.DataBind();
                DropDownList262.DataBind();
                DropDownList263.DataBind();
                DropDownList63.Enabled = true;
                DropDownList64.Enabled = true;
                DropDownList260.Enabled = true;
                DropDownList174.Enabled = true;
                DropDownList175.Enabled = true;
                DropDownList176.Enabled = true;
                DropDownList261.Enabled = true;
                DropDownList262.Enabled = true;
                DropDownList263.Enabled = true;



                Orden1Boolean.Checked = true;
                string Orden1 = TacticaTraida.Order1;
                char limitador1 = ' ';
                char limitador2 = ',';
                string[] OrdenDelimitada = Orden1.Split(limitador1, limitador2);
                DropDownList62.SelectedValue = "CambiarJugador";
                DropDownList63.SelectedValue = OrdenDelimitada.ElementAt(1);
                DropDownList64.SelectedValue = OrdenDelimitada.ElementAt(2);
                DropDownList260.SelectedValue = OrdenDelimitada.ElementAt(3);
                DropDownList174.SelectedValue = OrdenDelimitada.ElementAt(5);
                DropDownList175.SelectedValue = OrdenDelimitada.ElementAt(6);
                DropDownList176.SelectedValue = OrdenDelimitada.ElementAt(7);
                DropDownList261.SelectedValue = OrdenDelimitada.ElementAt(9);
                DropDownList262.SelectedValue = OrdenDelimitada.ElementAt(10);
                DropDownList263.SelectedValue = OrdenDelimitada.ElementAt(11);

            }

            if (TacticaTraida.Order1.Substring(0, 1) == "C")
            {
                DropDownList63.DataBind();
                DropDownList64.Visible = false;
                DropDownList63.DataSourceID = "SqlDataSource5";
                DropDownList260.DataBind();
                DropDownList174.DataBind();
                DropDownList175.DataBind();
                DropDownList176.DataBind();
                DropDownList261.DataBind();
                DropDownList262.DataBind();
                DropDownList263.DataBind();
                DropDownList63.Enabled = true;
                DropDownList64.Enabled = true;
                DropDownList260.Enabled = true;
                DropDownList174.Enabled = true;
                DropDownList175.Enabled = true;
                DropDownList176.Enabled = true;
                DropDownList261.Enabled = true;
                DropDownList262.Enabled = true;
                DropDownList263.Enabled = true;



                Orden1Boolean.Checked = true;
                string Orden1 = TacticaTraida.Order1;
                char limitador1 = ' ';
                char limitador2 = ',';
                string[] OrdenDelimitada = Orden1.Split(limitador1, limitador2);
                DropDownList62.SelectedValue = "CambiarPosicion";
                DropDownList63.SelectedValue = OrdenDelimitada.ElementAt(1);
                DropDownList260.SelectedValue = OrdenDelimitada.ElementAt(2);
                DropDownList174.SelectedValue = OrdenDelimitada.ElementAt(4);
                DropDownList175.SelectedValue = OrdenDelimitada.ElementAt(5);
                DropDownList176.SelectedValue = OrdenDelimitada.ElementAt(6);
                DropDownList261.SelectedValue = OrdenDelimitada.ElementAt(8);
                DropDownList262.SelectedValue = OrdenDelimitada.ElementAt(9);
                DropDownList263.SelectedValue = OrdenDelimitada.ElementAt(10);

            }

            if (TacticaTraida.Order1.Substring(0, 1) == "T")
            {



                DropDownList63.DataSourceID = "";
                DropDownList63.DataBind();
                DropDownList63.Items.Clear();
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("A"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("D"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("P"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("L"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue("C"));
                DropDownList63.Items.Add(DropTactic.Items.FindByValue(""));

                
                DropDownList64.Visible = false;
                DropDownList260.Visible = false;
                
                DropDownList260.DataBind();
                DropDownList174.DataBind();
                DropDownList175.DataBind();
                DropDownList176.DataBind();
                DropDownList261.DataBind();
                DropDownList262.DataBind();
                DropDownList263.DataBind();
                DropDownList63.Enabled = true;
                DropDownList64.Enabled = true;
                DropDownList260.Enabled = true;
                DropDownList174.Enabled = true;
                DropDownList175.Enabled = true;
                DropDownList176.Enabled = true;
                DropDownList261.Enabled = true;
                DropDownList262.Enabled = true;
                DropDownList263.Enabled = true;



                Orden1Boolean.Checked = true;
                string Orden1 = TacticaTraida.Order1;
                char limitador1 = ' ';
                char limitador2 = ',';
                string[] OrdenDelimitada = Orden1.Split(limitador1, limitador2);
                DropDownList62.SelectedValue = "CambiarTactica";
                DropDownList63.SelectedValue = OrdenDelimitada.ElementAt(1);
                DropDownList174.SelectedValue = OrdenDelimitada.ElementAt(3);
                DropDownList175.SelectedValue = OrdenDelimitada.ElementAt(4);
                DropDownList176.SelectedValue = OrdenDelimitada.ElementAt(5);
                DropDownList261.SelectedValue = OrdenDelimitada.ElementAt(7);
                DropDownList262.SelectedValue = OrdenDelimitada.ElementAt(8);
                DropDownList263.SelectedValue = OrdenDelimitada.ElementAt(9);

            }
        }
    }
}