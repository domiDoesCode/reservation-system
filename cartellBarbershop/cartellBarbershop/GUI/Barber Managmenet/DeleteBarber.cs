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

namespace cartellBarbershop.GUI.Barber_Managmenet
{
    public partial class DeleteBarber : Form
    {
        public BarberController barberCtr;
        public DeleteBarber()
        {
            InitializeComponent();
            barberCtr = new BarberController();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            barberCtr.DeleteBarber(deleteBox.Text);
        }
    }
}
