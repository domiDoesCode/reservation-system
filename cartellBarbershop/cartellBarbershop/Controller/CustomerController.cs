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
    internal class CustomerController
    {
        public CustomerIF customerDB;

        public CustomerController()
        {
            customerDB = new CustomerDB();
        }

        public void createCustomer(string _firstName, string _lastName, string _phoneNo)
        {
            try
            {
                customerDB.createCustomer(_firstName, _lastName, _phoneNo);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void findCustomerByPhone(string _phoneNo)
        {
            try
            {
                customerDB.findCustomerbyPhone( _phoneNo);
                MessageBox.Show("Customer found.");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
