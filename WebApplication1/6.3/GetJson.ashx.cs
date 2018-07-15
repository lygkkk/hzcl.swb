using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1._6._3
{
    /// <summary>
    /// GetJson 的摘要说明
    /// </summary>
    public class GetJson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("{\"name\":\"张晶\", \"age\": \"36\"}");
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