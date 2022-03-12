using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using cartellBarbershop.GUI;
using cartellBarbershop.GUI.Barber_Managmenet;
using cartellBarbershop.GUI.Reservation_Management;
using System.Data;
using System.Data.SqlClient;

namespace cartellBarbershop
{
    public partial class Menu : Form
    {
        DBConnection connection;

        public Menu()
        {
            InitializeComponent();
            connection = new DBConnection();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            connection.OpenConnection();
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu CM = new CustomerMenu();
            CM.Show();
        }

        private void reservationMenuButton_Click(object sender, EventArgs e)
        {
            ReservationMenu RM = new ReservationMenu();
            RM.Show();
        }

        private void barberMenuButton_Click(object sender, EventArgs e)
        {
            BarberMenu BM = new BarberMenu();
            BM.Show();
        }
    }
}