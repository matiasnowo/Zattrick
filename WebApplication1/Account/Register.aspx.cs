using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppWeb.Negocio;
using AppWeb.Session;
using AppWeb.DataAccess;

namespace AppWeb.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
         //   RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        

        protected void btnCrear_Click(object sender, EventArgs e)
        {
          //  FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);
//
          //  string continueUrl = RegisterUser.ContinueDestinationPageUrl;
          //  if (!OpenAuth.IsLocalUrl(continueUrl))
          //  {
         //       continueUrl = "~/";
         //   }
           // Response.Redirect(continueUrl);

            ErrortxtUser.Visible = false;
            ErrortxtUser2.Visible = false;
            ErrortxtUser3.Visible = false;
            ErrortxtEmail.Visible = false;
            ErrortxtEmail2.Visible = false;
            ErrortxtPass2.Visible = false;
            ErrortxtPass.Visible = false;
            RegexUtilities RG = new RegexUtilities();

            if (new ConsultasUsuarios().UserExists(txtUser.Text) == true)
            {

                ErrortxtUser3.Visible = true;
                txtUser.Text = "";
            }
            else
            if (txtUser.Text == "")
            {

                ErrortxtUser.Visible = true;
                txtUser.Text = "";
            }
            else if (txtUser.Text.Count() < 4)
            {

                ErrortxtUser2.Visible = true;
                txtUser.Text = "";
            }
            else
                if (RG.IsValidEmail(txtEmail.Text) == false)
               {

                   ErrortxtEmail2.Visible = true;
                    txtEmail.Text = "";
               } else
                if (txtEmail.Text == ""){

                    ErrortxtEmail.Visible = true;
                    txtEmail.Text = "";
            }
                else if (txtPass.Text != txtPass2.Text)
                {
                    txtPass.Text = "";
                    txtPass2.Text = "";
                ErrortxtPass2.Visible = true;
            }
            else
             if (txtPass.Text.Count() < 7)
            {

                txtPass.Text = "";
                txtPass2.Text = "";
                ErrortxtPass.Visible = true;
            }

            {

                new ConsultasUsuarios().SetUsuario(new Usuario() { NUsuario = txtUser.Text, Pass = new Encription().StringToSHA(txtPass.Text), Role = "User", Email = txtEmail.Text });



                Response.Redirect("/Inicio.aspx");
            }

   
        }





       

       
    }
}