using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using hzcl.swb.BLL;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using hzcl.swb.Model;
namespace WebApplication1._6._3
{
    /// <summary>
    /// LoadAllUserInfo 的摘要说明
    /// </summary>
    public class LoadAllUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            customerBll customerBll = new customerBll();
            DataTable dt = customerBll.GetAllCustomerInfo();

            System.Web.Script.Serialization.JavaScriptSerializer js = new JavaScriptSerializer();
            string str = JsonConvert.SerializeObject(dt);
            //context.Response.Write("{\"name\":\"dada\"}");
            context.Response.Write(str);
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