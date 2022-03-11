using cartellBarbershop.DB;
using cartellBarbershop.DB.Customers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Controller
{
    public class CustomerController
    {
        public CustomerIF customerDB;

        public CustomerController()
        {
            customerDB = new CustomerDB();
        }

        public void createCustomer(string _firstName, string _lastName, string _phoneNo)
        {
            customerDB.createCustomer(_firstName, _lastName, _phoneNo);
        }

        public void findCustomerByPhone(string _phoneNo)
        {
            customerDB.findCustomerbyPhone( _phoneNo);
        }

        public void deleteCustomer(string _phoneNo)
        {
            customerDB.removeCustomer(_phoneNo);
        }

        public void updateCustomer(string _oldPhoneNo, string _newFirstName, string _newLastName, string _newPhoneNo)
        {
            customerDB.updateCustomer(_oldPhoneNo, _newFirstName, _newLastName, _newPhoneNo);
        }
    }
}
