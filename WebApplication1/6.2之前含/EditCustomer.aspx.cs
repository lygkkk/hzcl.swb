using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;
using hzcl.swb.Model;

namespace WebApplication1
{
    public partial class EditCustomer : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowEditCustomer();
            }
            else
            {
                customer customer = new customer();
                customerBll customerBll = new customerBll();
                customer.ID = Convert.ToInt32(Context.Request.Form["ID"]);
                customer.Name = Context.Request.Form["Name"];
                customer.Age = Context.Request.Form["Age"];
                customerBll.EditCustomer(customer);
                Context.Response.Redirect("customerInfo.aspx");
            }

            

        }

        protected void ShowEditCustomer()
        {
            int id;
            if (int.TryParse(Context.Request.QueryString["id"], out id))
            {
                customerBll customerBll = new customerBll();
                dt = customerBll.GetSingleCustomer(id);
                if (dt.Rows.Count == 0)
                {
                    Context.Response.Redirect("参数错误！！");
                }
            }
            else
            {
                Context.Response.Write("参数错误！！");
            }
        }
    }
}