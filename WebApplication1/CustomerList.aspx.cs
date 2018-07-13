using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hzcl.swb.BLL;
using Microsoft.Ajax.Utilities;

namespace WebApplication1
{
    public partial class CustomerList : System.Web.UI.Page
    {
        public string strHtml { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
        public string PageNum { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            int pageSize = 10;
            int pageIndex;
            int pageCount;
            DataTable dt = new DataTable();
            if (!int.TryParse(Context.Request.QueryString["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }

            customerBll customerBll = new customerBll();
            pageCount = customerBll.GetPageCount(pageSize);
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            CurrentPageIndex = pageIndex;
            PageCount = pageCount;


            dt = customerBll.GetPageList(pageIndex, pageSize);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<li>{0}</li>", dt.Rows[i]["Name"]);
            }

            strHtml = sb.ToString();

            sb.Clear();

            int startPage = CurrentPageIndex - 5 < 1 ? 1 : CurrentPageIndex - 5;
            int endPage = startPage + 9 > pageCount ? pageCount : startPage + 9;

            for (int i = startPage; i < endPage; i++)
            {
                if (i == CurrentPageIndex)
                {
                    sb.AppendFormat("{0}, ", i + 1);
                }
                else if (i < pageCount - 1)
                {
                    sb.AppendFormat("<a href=customerList.aspx?pageIndex={0}>{0}</a>, ", i + 1);
                }
                else
                {
                    sb.AppendFormat("<a href=customerList.aspx?pageIndex={0}>{0}</a>", i + 1);
                }

                
            }

            PageNum = sb.ToString();
        }
    }
}