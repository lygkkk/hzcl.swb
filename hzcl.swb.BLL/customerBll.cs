using System;
using System.Data;
using System.Net.Configuration;
using System.Text.RegularExpressions;
using hzcl.swb.DAL;
using hzcl.swb.Model;

namespace hzcl.swb.BLL
{
    public class customerBll
    {
        customer customer = new customer();
        customerDal customerDal = new customerDal();

        public DataTable GetAllCustomerInfo()
        {
            return customerDal.GetAllCustomerInfo();
        }

        public int DeleteCustomer(int id)
        {
            return customerDal.DeleteCustomerInfo(id);
        }

        public int AddCustomer(customer customer)
        {
            return customerDal.AddCustomer(customer);
        }

        public int EditCustomer(customer customer)
        {
            return customerDal.EditCustomer(customer);
        }

        public DataTable GetSingleCustomer(int id)
        {
            return customerDal.GetSingleCustomer(id);
        }

        public DataTable GetPageList(int pageIndex, int pageSize)
        {
            int startPage = (pageIndex - 1) * pageSize + 1;
            int endPage = pageIndex * pageSize;
            return customerDal.GetPageList(startPage, endPage);
        }

        public int GetPageCount(int pageSize)
        {
            int recordCount = customerDal.GetRecordCount();
            int pageCount = Convert.ToInt32(Math.Ceiling((double)recordCount / pageSize)); 
            return pageCount;
        }


        public bool CheckUserInfo(string userName, string userPwd, out string msg, out DataTable dt)
        {
            dt = customerDal.GetSingleCustomer(userName);
            if (dt.Rows.Count == 0)
            {
                msg = "查无此人";
                return false;
            }
            else
            {
                if (userPwd == dt.Rows[0]["Age"].ToString())
                {
                    msg = "登录成功";
                    return true;
                }
                else
                {
                    msg = "密码错误";
                    return false;
                }
            }
        }
    }
}