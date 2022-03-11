using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void FindReservation(string reservationNo)
        {
            throw new NotImplementedException();
        }

        public void UpdateReservation(string newReservationNo, DateTime newDate, int newBarberId, int newServiceId)
        {
            throw new NotImplementedException();
        }
    }
}
