using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;

namespace WebApplication1._6._6
{
    public partial class CacheDemo : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["customerInfo"] == null)
            {
                customerBll customerBll = new customerBll();
                Cache.Insert("customerInfo", customerBll.GetAllCustomerInfo(), null, DateTime.Now.AddSeconds(3), TimeSpan.Zero, CacheItemPriority.Normal, RemoveCacheItem);
                Response.Write("来自数据库的数据");
            }
            else
            {
                Response.Write("来缓存");
                //DataTable dt = (DataTable) Cache["customerInfo"];
            }
        }

        protected void RemoveCacheItem(string key, object value, CacheItemRemovedReason reason)
        {
            if (reason == CacheItemRemovedReason.Expired)
            {
                //这里写移除的日志到硬盘
            }
        }
    }
}