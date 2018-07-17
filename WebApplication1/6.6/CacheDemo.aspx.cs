using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;

namespace WebApplication1._6._6
{
    public partial class CacheDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["customerInfo"] == null)
            {
                customerBll customerBll = new customerBll();
                Cache["customerInfo"] = customerBll.GetAllCustomerInfo();
                Response.Write("来自数据库的数据");
            }
            else
            {
                DataTable dt = (DataTable) Cache["customerInfo"];
            }
        }
    }
}