using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;
using hzcl.swb.Model;
using Newtonsoft.Json;

namespace WebApplication1._6._3
{
    /// <summary>
    /// ModifyUserInfo 的摘要说明
    /// </summary>
    public class ModifyUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            customer customer = new customer();
            customer.ID = int.Parse(context.Request["txtID"]);
            customer.Name = context.Request["txtName"];
            customer.Age = context.Request["txtAge"];
            customerBll customerBll = new customerBll();
            if (customerBll.EditCustomer(customer) > 0)
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