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

            int pageIndex;

            if (!int.TryParse(context.Request["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }
            customerBll customerBll = new customerBll();

            int pageCount = customerBll.GetPageCount(10);

            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;

            

            DataTable dt = customerBll.GetPageList(pageIndex, 10);

            string str = JsonConvert.SerializeObject(dt);
            
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