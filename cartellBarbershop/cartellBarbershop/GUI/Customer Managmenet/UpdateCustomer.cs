using System;
using System.Collections.Generic;
using System.ComponentModel;
using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cartellBarbershop.GUI
{
    public partial class UpdateCustomer : Form
    {
        public CustomerController customerCtr;
        public DBConnection db;

        public UpdateCustomer()
        {
            InitializeComponent();
            db = new DBConnection();
            customerCtr = new CustomerController();
            panel1.Hide();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (db.GetInstance().OpenConnection())
            {
                DataTable dt = new DataTable("Customer");
                SqlCommand cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", db.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@phoneNo", findBox.Text);
            }
            panel1.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            customerCtr.updateCustomer(newNameBox.Text, newLastNameBox.Text, newPhoneBox.Text, findBox.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void findBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
