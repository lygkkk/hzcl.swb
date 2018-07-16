using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;
using hzcl.swb.Model;

namespace WebApplication1._6._3
{
    /// <summary>
    /// AddUserInfo 的摘要说明
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            customer customer = new customer();
            customer.Name = context.Request["txtName"];
            customer.Age = context.Request["txtAge"];

            customerBll customerBll = new customerBll();
            if (customerBll.AddCustomer(customer) > 0)
            {
                context.Response.Write("YES");
            }
            else
            {
                context.Response.Write("NO");
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}