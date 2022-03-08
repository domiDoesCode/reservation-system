using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using System.Data.SqlClient;

namespace cartellBarbershop
{
    public partial class Menu : Form
    {
        DBConnection connection;
        CustomerController customerCtr;

        public Menu()
        {
            InitializeComponent();
            connection = new DBConnection();
            customerCtr = new CustomerController();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();
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

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNo;
                phoneNo = findBox.Text;

                customerCtr.findCustomerByPhone(phoneNo);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex.StackTrace);
            }
        }
    }
}