using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;

namespace WebApplication1
{
    /// <summary>
    /// DeleteCustomer 的摘要说明
    /// </summary>
    public class DeleteCustomer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;

            if(int.TryParse(context.Request.QueryString["id"], out id))
            {
                customerBll customerBll = new customerBll();
                if (customerBll.DeleteCustomer(id) > 0)
                {
                    context.Response.Redirect("customerInfo.aspx");
                }
            }
            else
            {
                context.Response.Write("参数错误~！");
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