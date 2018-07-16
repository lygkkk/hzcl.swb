using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;

namespace WebApplication1._6._3
{
    /// <summary>
    /// DeleteUserInfo 的摘要说明
    /// </summary>
    public class DeleteUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = 0;
            

            if (int.TryParse(context.Request["id"], out id))
            {
                customerBll customerBll = new customerBll();
                if (customerBll.DeleteCustomer(id) > 0)
                {
                    context.Response.Write("YES");
                }
                else
                {
                    context.Response.Write("NO");
                }
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