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
                cmd = new SqlCommand("insert into Customers (First_Name, Last_Name, Phone_Number) values (@firstName, @lastName, @phoneNo)", 
                                     dbConnection.GetInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@firstName", _firstName);
                cmd.Parameters.AddWithValue("@lastName", _lastName);
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to create: " + e.StackTrace);
            }
        }

        public void findCustomerbyPhone(string _phoneNo)
        {
            try
            {
                cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", 
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string fName = reader.GetString("First_Name");
                    string lName = reader.GetString("Last_Name");
                    string pNum = reader.GetString("Phone_Number");
                    MessageBox.Show("Customer information:" +  "\n" + fName + " " + lName + " " + pNum);
                }

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to find: " + e.StackTrace);
            }
        }
        public void removeCustomer(string _phoneNo)
        {
            try
            {
                cmd = new SqlCommand("delete from Customers where Phone_Number = @phoneNo", 
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@phoneNo", _phoneNo);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void updateCustomer(string _newFirstName, string _newLastName, string _newPhoneNo, string _oldPhoneNo)
        {
            try
            {
                cmd = new SqlCommand("update Customers set First_Name = @firstName, Last_Name = @lastName, Phone_Number = @newPhone where Phone_Number = @oldPhone",
                                dbConnection.GetInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@firstName", _newFirstName);
                cmd.Parameters.AddWithValue("@lastName", _newLastName);
                cmd.Parameters.AddWithValue("@newPhone", _newPhoneNo);
                cmd.Parameters.AddWithValue("@oldPhone", _oldPhoneNo);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();

                MessageBox.Show("Customer Updated Successfully!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
