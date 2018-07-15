using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;
using hzcl.swb.Model;

namespace WebApplication1
{
    public partial class customerInfo : System.Web.UI.Page
    {
        public string strHtml { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            customerBll customerBll = new customerBll();
            DataTable dt = customerBll.GetAllCustomerInfo();
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<tr><td>{0}</td>" +
                                "<td>{1}</td>" +
                                "<td>{2}</td>" +
                                "<td><a href = \"DeleteCustomer.ashx?id={3}\" class = \"delete\">删除</a></td>" +
                                "<td><a href = EditCustomer.aspx?id={4} class = edit>修改</a></td>" +
                                "</tr></br>", 
                                dt.Rows[i]["ID"], dt.Rows[i]["Name"], dt.Rows[i]["Age"], dt.Rows[i]["ID"], dt.Rows[i]["ID"]);
            }

            strHtml = sb.ToString();
        }
    }
}