using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;
using hzcl.swb.Model;
namespace WebApplication1
{
    public partial class Addcustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Context.Request.Form["isPostBack"]))
            {
                AddcustomerInfo();
                Context.Response.Redirect("customerInfo.aspx");
            }
        }

        protected void AddcustomerInfo()
        {
            customer customer = new customer();
            customer.Name = Context.Request.Form["Name"];
            customer.Age = Context.Request.Form["Age"];
            customerBll customerBll = new customerBll();
            customerBll.AddCustomer(customer);
        }
    }
}