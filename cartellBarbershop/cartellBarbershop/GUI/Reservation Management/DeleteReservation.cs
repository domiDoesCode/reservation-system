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

namespace cartellBarbershop.GUI.Reservation_Management
{
    public partial class DeleteReservation : Form
    {
        public ReservationController reservationController;
        public DeleteReservation()
        {
            InitializeComponent();
            reservationController = new ReservationController();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            reservationController.DeleteReservation(deleteBox.Text);
        }
    }
}
