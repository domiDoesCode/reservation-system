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
    public partial class UpdateReservation : Form
    {
        public ReservationController reservationCtr;
        public DBConnection db;

        public UpdateReservation()
        {
            InitializeComponent();
            db = new DBConnection();
            reservationCtr = new ReservationController();
            panel1.Hide();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (db.GetInstance().OpenConnection())
            {
                DataTable dt = new DataTable("Reservation");
                SqlCommand cmd = new SqlCommand("select * from Reservations where Reservation_Number = @resNo", db.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@resNo", findBox.Text);
            }
            panel1.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string s = newResDateBox.Text;
            DateTime dt = Convert.ToDateTime(s);
            int bid = int.Parse(newBIDBox.Text);
            int sid = int.Parse(newSIDBox.Text);
            reservationCtr.UpdateReservatin(findBox.Text, dt, bid, sid);
        }
    }
}
