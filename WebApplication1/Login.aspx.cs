using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        public string UserName { get; set; }
        public string Msg { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //先判断是POST还是GET
            if (IsPostBack)
            {
                string userName = Request.Form["txtName"];
                string userPwd = Request.Form["txtPwd"];
                string msg = string.Empty;
                DataTable dt = new DataTable();
                customerBll customerBll = new customerBll();
                if (customerBll.CheckUserInfo(userName, userPwd, out msg, out dt))
                {
                    Session["userName"] = userName;
                    Response.Redirect("LoginSuccess.aspx");
                }
                else
                {
                    Msg = msg;
                }

                Response.Cookies["userName"].Value = userName;
                Response.Cookies["userName"].Expires = DateTime.Now.AddDays(3);
            }
            else
            {
                if (Session["userName"] != null)
                {
                    Response.Redirect("LoginSuccess.aspx");
                }
            }
        }
    }
}