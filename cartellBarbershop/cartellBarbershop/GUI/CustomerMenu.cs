using cartellBarbershop.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartellBarbershop.GUI
{
    public partial class CustomerMenu : Form
    {
        public CustomerController customerCtr;
        public CustomerMenu()
        {
            InitializeComponent();
            customerCtr = new CustomerController();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string phoneNo;
            phoneNo = findBox2.Text;
            customerCtr.findCustomerByPhone(phoneNo);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName;
                string lastName;
                string phoneNo;
                firstName = nameBox.Text;
                lastName = surnameBox.Text;
                phoneNo = phoneBox.Text;

                customerCtr.createCustomer(firstName, lastName, phoneNo);
                MessageBox.Show("Customer created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer creation failed: " + ex.StackTrace);
            }
        }
    }
}
