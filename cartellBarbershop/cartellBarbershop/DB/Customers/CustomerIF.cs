﻿using cartellBarbershop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Customers
{
    internal interface CustomerIF
    {
        public void createCustomer(string _firstName, string _lastName, string _phoneNo);
        public void updateCustomer(string _firstName, string _lastName, string _phoneNo);
        public void findCustomerbyPhone(string _phoneNo);
        public void removeCustomer(string _phoneNo);
        public List<Customer> printAllCustomers();
    }
}