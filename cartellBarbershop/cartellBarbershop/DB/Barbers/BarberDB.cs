using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Barbers
{
    public class BarberDB : BarberIF
    {
        private SqlCommand cmd;
        public DBConnection dbConnection;

        public BarberDB()
        {
            cmd = new SqlCommand();
            dbConnection = new DBConnection();
        }
        public void CreateBarber(string nickname)
        {
            try
            {
                cmd = new SqlCommand("insert into Barbers (Nickname) values (@name)",
                                 dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", nickname);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to create: " + e.StackTrace);
            }
        }

        public void DeleteBarber(string nickname)
        {
            try
            {
                cmd = new SqlCommand("delete from Barbers where Nickname = @name",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", nickname);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to delete: " + e.StackTrace);
            }
        }

        public void FindBarber(string nickname)
        {
            try
            {
                cmd = new SqlCommand("select * from Barbers where Nickname = @name",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", nickname);

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("Nickname");
                    MessageBox.Show("Customer information:" + "\n" + name);
                }

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to find: " + e.StackTrace);
            }
        }

        public void UpdateBarber(string nickname, string newNickname)
        {
            try
            {
                cmd = new SqlCommand("update Barbers set Nickname = @newNickname where Nickname = @name",
                                dbConnection.GetInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@newNickname", newNickname);
                cmd.Parameters.AddWithValue("@name", nickname);

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
