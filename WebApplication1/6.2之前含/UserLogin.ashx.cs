using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using hzcl.swb.BLL;

namespace WebApplication1
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            customerBll customerBll = new customerBll();
            string userName = context.Request["name"];
            string userPwd = context.Request["pwd"];
            DataTable dt =  customerBll.GetSingleCustomer(userName);
            if (dt.Rows.Count == 0)
            {
                context.Response.Write("NO:"+"登录失败");
            }
            else if(dt.Rows[0]["Age"].ToString() != userPwd)
            {
                context.Response.Write("NO:"+"用户名或密码错误");
            }
            else
            {
                context.Session["userInfo"] = userName;
                context.Response.Write("YES:"+"登录成功~~~~");
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