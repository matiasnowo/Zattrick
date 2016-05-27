using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppWeb.DataAccess;
using System.Web.Security;
using AppWeb.Negocio;

namespace AppWeb.Account
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Session["User"] = null;



   
        }





    }
}