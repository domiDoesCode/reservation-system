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
    public partial class BarberMenu : Form
    {
        public BarberController barberCtr;
        public DBConnection db;

        public BarberMenu()
        {
            InitializeComponent();
            db = new DBConnection();
            barberCtr = new BarberController();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            barberCtr.CreateBarber(nameBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteBarber DB = new DeleteBarber();
            DB.Show();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateBarber UB = new UpdateBarber();
            UB.Show();
        }

        private void findButton2_Click(object sender, EventArgs e)
        {
            using (db.GetInstance().OpenConnection())
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from Barbers", db.GetInstance().OpenConnection());
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }
    }
}
