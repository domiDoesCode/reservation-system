using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public DBConnection db;

        public CustomerMenu()
        {
            InitializeComponent();
            db = new DBConnection();
            customerCtr = new CustomerController();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findBox2.Text))
            {
                // Get a list of all customers
                using (db.GetInstance().OpenConnection())
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("select * from Customers", db.GetInstance().OpenConnection());
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
            else
            {
                // Get a specific Customer via Phone Number
                using (db.GetInstance().OpenConnection())
                {
                    DataTable dt = new DataTable("Customer");
                    SqlCommand cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", db.GetInstance().OpenConnection());
                    cmd.Parameters.AddWithValue("@phoneNo", findBox2.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView.DataSource=dt;
                }
                //string phoneNo;
                //phoneNo = findBox2.Text;
                //customerCtr.findCustomerByPhone(phoneNo);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                customerCtr.createCustomer(nameBox.Text, surnameBox.Text, phoneBox.Text);
                MessageBox.Show("Customer created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer creation failed: " + ex.StackTrace);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer DC = new DeleteCustomer();
            DC.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer UC = new UpdateCustomer();
            UC.Show();
        }
    }
}
