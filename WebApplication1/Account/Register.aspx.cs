using System;
using System.Linq;
using System.Web.UI;
using Negocio.Autenticacion;
using Model.Autenticacion;
using Session;
namespace AppWeb.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            limpiarErrores();   //Limpia los errores visualizados en pantalla
            int errores = verificarDatos(); //Verifica los distintos tipos de error
            if (errores == 0)
            {
                new UsuarioBLL().CrearUsuario(new UsuarioBE() { NUsuario = txtUser.Text, Pass = new Encription().StringToSHA(txtPass.Text), Role = "User", Equipo = "Null", Email = txtEmail.Text });
                Response.Redirect("/Inicio.aspx");
            }
        }
        private void limpiarErrores()
        {
            ErrortxtUser.Visible = false;
            ErrortxtUser2.Visible = false;
            ErrortxtEmail.Visible = false;
            ErrortxtEmail2.Visible = false;
            ErrortxtPass.Visible = false;
            ErrortxtPass2.Visible = false;
        }
        private int verificarDatos()
        {
            int Errores = 0;
            RegexUtilities RG = new RegexUtilities();
            if (String.IsNullOrEmpty(txtUser.Text))
            {
                ErrortxtUser.Visible = true;
                txtUser.Text = "";
                Errores++;
            }
            if (new UsuarioBLL().UsuarioExiste(txtUser.Text) == true)
            {
                ErrortxtUser2.Visible = true;
                txtUser.Text = "";
                Errores++;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                ErrortxtEmail.Visible = true;
                txtEmail.Text = "";
                Errores++;
            }
            if (RG.IsValidEmail(txtEmail.Text) == false)
            {
                ErrortxtEmail2.Visible = true;
                txtEmail.Text = "";
                Errores++;
            }
            if (txtPass.Text.Count() < 7)
            {
                ErrortxtPass.Visible = true;
                txtPass.Text = "";
                txtPass2.Text = "";
                Errores++;
            }
            if (txtPass.Text != txtPass2.Text)
            {
                ErrortxtPass2.Visible = true;
                txtPass.Text = "";
                txtPass2.Text = "";
                Errores++;
            }
            return Errores;
        }
    }
}