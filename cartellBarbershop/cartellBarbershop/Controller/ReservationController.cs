using cartellBarbershop.DB.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Controller
{
    public class ReservationController
    {
        public ReservationIF reservationDB;

        public ReservationController()
        {
            reservationDB = new ReservationDB();
        }

        public void CreateReservation(string reservationNo, DateTime date, int customerId, int barberId, int serviceId)
        {
            reservationDB.CreateReservation(reservationNo, date, customerId, barberId, serviceId);
        }

        public void DeleteReservation(string reservationNo)
        {
            reservationDB.DeleteReservation(reservationNo);
        }

        public void FindReservation(string reservationNo)
        {
            reservationDB.FindReservation(reservationNo);
        }

        public void UpdateReservatin(string reservationNo, DateTime newDate, int newBarberId, int newServiceId)
        {
            reservationDB.UpdateReservation(reservationNo, newDate, newBarberId, newServiceId);
        }
    }
}
