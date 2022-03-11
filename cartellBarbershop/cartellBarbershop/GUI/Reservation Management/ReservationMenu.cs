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

namespace cartellBarbershop.GUI.Reservation_Management
{
    public partial class ReservationMenu : Form
    {
        public ReservationController reservationController;
        public DBConnection db;
        public ReservationMenu()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            db = new DBConnection();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DateTime dt = DateTime.Parse(resDateBox.Text);
                //string date = dt.ToString("ddMMyyyy");

                string s = resDateBox.Text;
                DateTime dt = Convert.ToDateTime(s);
                string date2 = dt.ToString();
                int cid = int.Parse(cidBox.Text);
                int bid = int.Parse(bidBox.Text);
                int sid = int.Parse(sidbox.Text);
                reservationController.CreateReservation(resNoBox.Text, dt, cid, bid, sid);
                MessageBox.Show("Customer created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer creation failed: " + ex.StackTrace);
            }
        }

        private void findButton2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findbox.Text))
            {
                // Get a list of all customers
                using (db.GetInstance().OpenConnection())
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter("select * from Reservations", db.GetInstance().OpenConnection());
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
                    DataTable dt = new DataTable("Reservation");
                    SqlCommand cmd = new SqlCommand("select * from Reservations where Reservation_Number = @resNo", db.GetInstance().OpenConnection());
                    cmd.Parameters.AddWithValue("@ResNo", findbox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                //string phoneNo;
                //phoneNo = findBox2.Text;
                //customerCtr.findCustomerByPhone(phoneNo);
            }
        }
    }
}
