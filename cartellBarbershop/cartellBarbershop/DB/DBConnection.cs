using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace cartellBarbershop.DB
{
    public class DBConnection
    {
        public string connectionString = "Server=DESKTOP-P6F6B0H\\SQLEXPRESS; Database=CartellDatabase; Trusted_Connection=True;";
        public SqlConnection connection;
        public DBConnection dbConnection;


        public DBConnection GetInstance()
        {
            if(dbConnection == null)
            {
                dbConnection = new DBConnection();
            }
            return dbConnection;
        }
        public SqlConnection OpenConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed: " + e.StackTrace);
            }
            return null;
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public void ExecuteQuery(string _query)
        {
            SqlCommand cmd = new SqlCommand(_query, connection);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DataReader(string _query)
        {
            SqlCommand sqlCommand = new SqlCommand(_query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return reader;
        }

        public object ShowDataInGridView(string _query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(_query, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
