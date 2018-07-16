using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;
using Newtonsoft.Json;

namespace WebApplication1
{
    /// <summary>
    /// GetSingalUserInfo 的摘要说明
    /// </summary>
    public class GetSingalUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = 0;
            if (int.TryParse(context.Request["id"], out id))
            {
                customerBll customerBll = new customerBll();
                DataTable dt = customerBll.GetSingleCustomer(id);
                if (dt.Rows.Count > 0)
                {
                    string str = JsonConvert.SerializeObject(dt);
                    context.Response.Write(str);
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