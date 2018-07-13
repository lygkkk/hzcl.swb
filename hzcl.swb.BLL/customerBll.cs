using System;
using System.Data;
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
    }
}