using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using cartellBarbershop.GUI;
using System.Data;
using System.Data.SqlClient;

namespace cartellBarbershop
{
    public partial class Menu : Form
    {
        DBConnection connection;
        CustomerController customerCtr;
        string connectionString = "Server=DESKTOP-P6F6B0H\\SQLEXPRESS; Database=CartellDatabase; Trusted_Connection=True;";

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

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                //using(SqlConnection con = new SqlConnection(connectionString))
                //{
                //    using (DataTable dt = new DataTable("Customer"))
                //    {
                //        using(SqlCommand cmd = new SqlCommand("select * from Customers where Phone_Number = @phoneNo", con))
                //        {
                //            cmd.Parameters.AddWithValue("@phoneNo", findBox.Text);
                //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //            adapter.Fill(dt);
                //            dataGridView1.DataSource = dt;
                //        }
                //    }
                //}
                string phoneNo = findBox.Text;
                customerCtr.findCustomerByPhone(phoneNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong" + ex.StackTrace);
            }
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu CM = new CustomerMenu();
            CM.Show();
        }
    }
}