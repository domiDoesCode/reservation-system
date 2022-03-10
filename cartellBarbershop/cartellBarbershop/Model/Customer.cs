using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(int _id, string _firstName, string _lastName, string _phoneNo)
        {
            this.Id = _id;
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.PhoneNumber = _phoneNo;
        }
    }
}
