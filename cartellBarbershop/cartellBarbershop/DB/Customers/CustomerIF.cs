using cartellBarbershop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Customers
{
    public interface CustomerIF
    {
        public void createCustomer(string _firstName, string _lastName, string _phoneNo);
        public void updateCustomer(string _oldPhoneNo, string _newFirstName, string _newLastName, string _newPhoneNo);
        public void findCustomerbyPhone(string _phoneNo);
        public void removeCustomer(string _phoneNo);
    }
}
