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

namespace cartellBarbershop.GUI.Barber_Managmenet
{
    public partial class UpdateBarber : Form
    {
        public BarberController barberCtr;
        public DBConnection db;

        public UpdateBarber()
        {
            InitializeComponent();
            db = new DBConnection();
            barberCtr = new BarberController();
            panel1.Hide();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (db.GetInstance().OpenConnection())
            {
                DataTable dt = new DataTable("Barber");
                SqlCommand cmd = new SqlCommand("select * from Barbers where Nickname = @name", db.GetInstance().OpenConnection());
                cmd.Parameters.AddWithValue("@name", findBox.Text);
            }
            panel1.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            barberCtr.UpdateBarber(findBox.Text, newNameBox.Text);
        }
    }
}
