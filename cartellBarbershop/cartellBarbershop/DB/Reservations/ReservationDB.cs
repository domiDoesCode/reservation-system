using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Reservations
{
    public class ReservationDB : ReservationIF
    {
        private SqlCommand cmd;
        public DBConnection dbConnection;

        public ReservationDB()
        {
            cmd = new SqlCommand();
            dbConnection = new DBConnection();
        }
    
        public void CreateReservation(string reservationNo, DateTime date, int customerId, int barberId, int serviceId)
        {
            try
            {
                cmd = new SqlCommand("insert into Reservations (Reservation_Number, Reservation_Date, Customer_Id, Barber_Id, Service_Id) values (@resNo, @date, @cid, @bid, @sid)",
                                 dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@resNo", reservationNo);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@cid", customerId);
                cmd.Parameters.AddWithValue("@bid", barberId);
                cmd.Parameters.AddWithValue("@sid", serviceId);
                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to create: " + e.StackTrace);
            }
        }

        public void DeleteReservation(string reservationNo)
        {
            try
            {
                cmd = new SqlCommand("delete from Reservations where Reservation_Number = @resNo",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@resNo", reservationNo);

                cmd.ExecuteNonQuery();

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to delete: " + e.StackTrace);
            }
        }

        public void FindReservation(string reservationNo)
        {
            try
            {
                cmd = new SqlCommand("select * from Reservations where Reservation_Number = @resNo",
                                     dbConnection.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@resNo", reservationNo);

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string resNo = reader.GetString("Reservation_Number");
                    string resDate = reader.GetString("Reservation_Date");
                    int bid = reader.GetInt32("Barber_Id");
                    int cid = reader.GetInt32("Customer_Id");
                    int sid = reader.GetInt32("Service_Id");
                    MessageBox.Show("Customer information:" + "\n" + resNo + " " + resDate + " " + bid + " " + cid + " " + sid);
                }

                dbConnection.GetInstance().CloseConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Failed to find: " + e.StackTrace);
            }
        }

        public void UpdateReservation(string reservationNo, DateTime newDate, int newBarberId, int newServiceId)
        {
            try
            {
                cmd = new SqlCommand("update Reservations set Reservation_Date = @resDate, Barber_Id = @bid, Service_Id = @sid where Reservation_Number = @resNo",
                                dbConnection.GetInstance().OpenConnection());

                cmd.Parameters.AddWithValue("@resDate", newDate);
                cmd.Parameters.AddWithValue("@bid", newBarberId);
                cmd.Parameters.AddWithValue("@sid", newServiceId);
                cmd.Parameters.AddWithValue("@resNo", reservationNo);

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
