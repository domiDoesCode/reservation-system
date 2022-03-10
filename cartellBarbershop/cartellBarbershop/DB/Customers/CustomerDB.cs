using cartellBarbershop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using cartellBarbershop.GUI;

namespace cartellBarbershop.DB.Customers
{
    internal class CustomerDB : CustomerIF
    {
        private SqlCommand cmd;
        public DBConnection dbConnection;

        public CustomerDB()
        {
            cmd = new SqlCommand();
            dbConnection = new DBConnection();
        }

        public void createCustomer(string _firstName, string _lastName, string _phoneNo)
        {
            try
            {
                cmd = new SqlCommand("insert into Customers (First_Name, Last_Name, Phone_Number) values (@firstName, @lastName, @phoneNo)", dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@firstName", _firstName);
                cmd.Parameters.AddWithValue("@lastName", _lastName);
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);
                cmd.ExecuteNonQuery();
                dbConnection.GetInstance().CloseConnection();
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
                cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                dbConnection.GetInstance().CloseConnection();
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
            try
            {
                cmd = new SqlCommand("delete from Customers where Phone_Number = @phoneNo", dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);
                cmd.ExecuteNonQuery();
                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {

                throw;
            }
        }

        public void updateCustomer(string _oldPhoneNo, string _newFirstName, string _newLastName, string _newPhoneNo)
        {
            throw new NotImplementedException();
        }
    }
}
