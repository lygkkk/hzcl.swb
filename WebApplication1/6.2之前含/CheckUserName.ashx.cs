using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;

namespace WebApplication1
{
    /// <summary>
    /// CheckUserName 的摘要说明
    /// </summary>
    public class CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["name"];
            customerBll customerBll = new customerBll();
            if (customerBll.GetSingleCustomer(userName).Rows.Count == 0)
            {
                context.Response.Write("此用户名可以使用！");
            }
            else
            {
                context.Response.Write("此用户名已使用,请更换！");
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