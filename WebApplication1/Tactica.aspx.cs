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


            }



        }

        protected void DropDownList65_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList65.SelectedValue == "CambiarJugador")
            {

                DropDownList66.Enabled = true;
                DropDownList67.Enabled = true;

                DropDownList67.Visible = true;

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


            }



        }


        protected void DropDownList303_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList303.SelectedValue == "CambiarJugador")
            {

                DropDownList304.Enabled = true;
                DropDownList305.Enabled = true;

                DropDownList305.Visible = true;

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


            }



        }

        protected void DropDownList313_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList313.SelectedValue == "CambiarJugador")
            {

                DropDownList314.Enabled = true;
                DropDownList315.Enabled = true;

                DropDownList315.Visible = true;

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
                    MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 1");
                    DeboActualizar1 = 0;
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
            }




            if (Orden2Boolean.Checked == true)
            {
                if (DropDownList65.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 1");
                    DeboActualizar2 = 0;
                }

                if (DropDownList178.SelectedValue == "")
                {
                    MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 1");
                    DeboActualizar2 = 0;
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
            }




            if (Orden3Boolean.Checked == true)
            {
                if (DropDownList303.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 1");
                    DeboActualizar3 = 0;
                }

                if (DropDownList306.SelectedValue == "")
                {
                    MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 1");
                    DeboActualizar3 = 0;
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


            }

            if (Orden4Boolean.Checked == true)
            {
                if (DropDownList313.SelectedValue == "")
                {
                    MessageBox.Show("Tienes que seleccionar algun Tipo de Orden en la Orden 1");
                    DeboActualizar4 = 0;
                }

                if (DropDownList316.SelectedValue == "")
                {
                    MessageBox.Show("Verifica la Posicion a Cambiar de la Orden 1");
                    DeboActualizar4 = 0;
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
                }

            }


// Verifico Que no se repitan jugadores entre los Titulares


            List<string> Titulares = new List<string>();
            Titulares.Add(DropDownList156.SelectedItem.Text);
            Titulares.Add(DropDownList24.SelectedItem.Text);
            Titulares.Add(DropDownList157.SelectedItem.Text);
            Titulares.Add(DropDownList158.SelectedItem.Text);
            Titulares.Add(DropDownList159.SelectedItem.Text);
            Titulares.Add(DropDownList160.SelectedItem.Text);
            Titulares.Add(DropDownList161.SelectedItem.Text);
            Titulares.Add(DropDownList162.SelectedItem.Text);
            Titulares.Add(DropDownList163.SelectedItem.Text);
            Titulares.Add(DropDownList164.SelectedItem.Text);
            Titulares.Add(DropDownList165.SelectedItem.Text);

            for (int v = 0; v < Titulares.Count-1; v++)
            {

                for (int p = 0; p < Titulares.Count-1; p++)
                {
                    if (v != p) {
                        if (Titulares.ElementAt(v) == Titulares.ElementAt(p)){



                            MessageBox.Show("El jugador titular numero " + Titulares.ElementAt(v) + ", no puede estar dos veces de titular");


                            DeboActualizar1 = 0;

                            v = Titulares.Count - 1;
                            p = Titulares.Count - 1;
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

    }
}