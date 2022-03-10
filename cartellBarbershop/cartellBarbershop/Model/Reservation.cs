using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }  
        public Customer Customer { get; set; }
        public Barber Barber { get; set; }
        public Service Service { get; set; }

        public Reservation(int _id, DateTime _date, Customer c, Barber b)
        {
            this.Id = _id;
            this.Date = _date;
            this.Customer = c;
            this.Barber = b;
        }

        // In case the customer wants to choose a service while making the reservation.
        public Reservation(int _id, DateTime _date, Customer c, Barber b, Service s)
        {
            this.Id = _id;
            this.Date = _date;
            this.Customer = c;
            this.Barber = b;
            this.Service = s;
        }
    }
}
