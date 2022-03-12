using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Services
{
    public class ServiceDB : ServiceIF
    {
        private SqlCommand cmd;
        public DBConnection dbConnection;

        public ServiceDB()
        {
            cmd = new SqlCommand();
            dbConnection = new DBConnection();
        }
        public void CreateService(string name, string description, float price)
        {
            try
            {
                cmd = new SqlCommand("insert into Service (Service_Name, Description, Price) values (@name, @desc, @price)",
                                 dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to create: " + e.StackTrace);
            }
        }

        public void DeleteService(string name)
        {
            try
            {
                cmd = new SqlCommand("delete from Services where Service_Name = @name",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to delete: " + e.StackTrace);
            }
        }

        public void FindService(string name)
        {
            try
            {
                cmd = new SqlCommand("select * from Services where Service_Name = @name",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString("Service_Name");
                    string desc = reader.GetString("Description");
                    float price = reader.GetFloat("Price");
                    MessageBox.Show("Customer information:" + "\n" + sName + " " + desc + " " + price);
                }

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to find: " + e.StackTrace);
            }
        }

        public void UpdateService(string name, float newPrice)
        {
            try
            {
                cmd = new SqlCommand("update Services set Price = @price where Service_Name = @name",
                                dbConnection.GetInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@price", newPrice);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();

                MessageBox.Show("Customer Updated Successfully!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to update: " + e.StackTrace);
            }
        }
    }
}
