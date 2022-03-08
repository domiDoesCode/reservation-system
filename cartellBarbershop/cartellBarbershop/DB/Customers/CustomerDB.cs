using cartellBarbershop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cartellBarbershop.DB.Customers
{
    internal class CustomerDB : CustomerIF
    {
        private SqlCommand cmd;
        private string connectionString;

        public CustomerDB()
        {
            cmd = new SqlCommand();
            connectionString = "Server=DESKTOP-P6F6B0H\\SQLEXPRESS; Database=CartellDatabase; Trusted_Connection=True;";
        }

        public void createCustomer(string _firstName, string _lastName, string _phoneNo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    cmd = new SqlCommand("insert into Customers (First_Name, Last_Name, Phone_Number) values (@firstName, @lastName, @phoneNo)", con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@firstName", _firstName);
                    cmd.Parameters.AddWithValue("@lastName", _lastName);
                    cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed: " + e.StackTrace);
            }
        }

        public void findCustomerbyPhone(string _phoneNo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed: " + e.StackTrace);
            }
        }

        public List<Customer> printAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void removeCustomer(string _phoneNo)
        {
            throw new NotImplementedException();
        }

        public void updateCustomer(string _firstName, string _lastName, string _phoneNo)
        {
            throw new NotImplementedException();
        }
    }
}
