using System.Data;
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
    }
}