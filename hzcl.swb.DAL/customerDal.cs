using System.Data;
using System.Data.SQLite;
using hzcl.swb.Model;
namespace hzcl.swb.DAL
{
    public class customerDal
    {
        public DataTable GetAllCustomerInfo()
        {
            string sql = "SELECT * FROM customer";
            return SqliteHelp.ExecuteTable(sql);
        }

        public int DeleteCustomerInfo(int id)
        {
            string sql = "DELETE FROM customer WHERE id = @id ";
            SQLiteParameter[] para =
            {
                new SQLiteParameter("@id", id),
            };

            return SqliteHelp.ExecuteNonQuery(sql, para);
        }

        public int AddCustomer(customer customer)
        {
            string sql = "INSERT INTO customer VALUES(NULL, @Name, @Age)";
            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Name", customer.Name),
                new SQLiteParameter("@Age", customer.Age),
            };

            return SqliteHelp.ExecuteNonQuery(sql, param);
        }


        public int EditCustomer(customer customer)
        {
            string sql = "UPDATE customer SET Name = @Name, Age = @Age WHERE ID = @ID";
            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Name", customer.Name),
                new SQLiteParameter("@Age", customer.Age),
                new SQLiteParameter("@ID", customer.ID),
            };

            return SqliteHelp.ExecuteNonQuery(sql, param);
        }

        public DataTable GetSingleCustomer(int id)
        {
            string sql = "SELECT * FROM customer WHERE ID = @ID";
            SQLiteParameter[] param =
            {
                new SQLiteParameter("@ID", id),
            };

            return SqliteHelp.ExecuteTable(sql, param);
        }
    }
}