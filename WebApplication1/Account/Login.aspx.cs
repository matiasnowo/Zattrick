using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppWeb.DataAccess;
using System.Web.Security;
using AppWeb.Negocio;
using System.Windows.Forms;

namespace AppWeb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      //      RegisterHyperLink.NavigateUrl = "Register";
      //      OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
//
      //      var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
       //     if (!String.IsNullOrEmpty(returnUrl))
       //     {
       //         RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
       //     }
        }



        protected void LoginForm_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (new ConsultasUsuarios().Autenticar(LoginForm.UserName, LoginForm.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(LoginForm.UserName, LoginForm.RememberMeSet);
                Session["User"] = LoginForm.UserName;
                Session["role"] = new AutentificationDAO().GetUsuario(LoginForm.UserName)[0].Role;
                Session["Equipo"] = new AutentificationDAO().GetUsuario(LoginForm.UserName)[0].Equipo;
                Response.Redirect("/Inicio.aspx");
            }
            else
            {

                MessageBox.Show("El nombre de usuario no existe o la contraseña es incorrecta!");

            }
            
        }


    }
}