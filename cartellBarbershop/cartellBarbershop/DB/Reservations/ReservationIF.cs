using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Reservations
{
    public interface ReservationIF
    {
        public void CreateReservation(string reservationNo, DateTime date, int customerId, int barberId, int serviceId);
        public void UpdateReservation(string newReservationNo, DateTime newDate, int newBarberId, int newServiceId);
        public void DeleteReservation(string reservationNo);
        public void FindReservation(string reservationNo);
    }
}
