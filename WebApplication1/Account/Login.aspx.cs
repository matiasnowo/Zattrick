using System;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Windows.Forms;
using Negocio.Autenticacion;
using DataAcces;

namespace AppWeb.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginForm_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (new UsuarioBLL().Autenticar(LoginForm.UserName, LoginForm.Password))
            {
                TemporadaActualDAO TA = new TemporadaActualDAO();
                FormsAuthentication.RedirectFromLoginPage(LoginForm.UserName, LoginForm.RememberMeSet);
                Session["User"] = LoginForm.UserName;
                Session["role"] = new UsuarioBLL().GetUsuarioPorNombre(LoginForm.UserName).Role;
                Session["Equipo"] = new UsuarioBLL().GetUsuarioPorNombre(LoginForm.UserName).Equipo;
                Session["TemporadaActual"] = TA.GetTemporadaActual();
                Response.Redirect("/Inicio.aspx");
            }
            else
            {
                MessageBox.Show("El nombre de usuario no existe o la contraseña es incorrecta!");
            }
        } //Autenticacion del usuario
    }
}