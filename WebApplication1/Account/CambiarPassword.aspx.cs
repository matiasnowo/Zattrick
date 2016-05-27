using System;
using System.Collections.Generic;
using System.Linq;
using AppWeb.Negocio;
using AppWeb.Session;
using System.Windows.Forms;


namespace AppWeb.Account
{
    public partial class CambiarPassword : System.Web.UI.Page
    {

        protected void Page_Load()
        {

        
        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {


            Usuario Actual = new Usuario();

            Actual = new ConsultasUsuarios().GetUsuarioPorNombre((string)Session["User"]);


            if (new Encription().StringToSHA(ChangePassword1.CurrentPassword) == Actual.Pass)
            {
                if (ChangePassword1.NewPassword == ChangePassword1.ConfirmNewPassword)
                {

                    string Password = new Encription().StringToSHA(ChangePassword1.ConfirmNewPassword);

                    Actual.Pass = Password;

                    new ConsultasUsuarios().ModifyUsuario(Actual);

                    MessageBox.Show("Contraseña modificada correctamente!");

                    Response.Redirect("/Inicio.aspx");
                }

                else
                {


                    MessageBox.Show("Has ingresado la nueva contraseña de dos formas distintas.");

                }



            }
            else
            {
                MessageBox.Show( "La contraseña actual no es correcta.");

            }

        }

    





    }
}