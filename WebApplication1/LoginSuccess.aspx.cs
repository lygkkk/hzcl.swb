using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginSuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Write("欢迎光临" + Session["userName"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}