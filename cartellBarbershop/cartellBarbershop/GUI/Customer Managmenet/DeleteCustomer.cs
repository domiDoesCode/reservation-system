using cartellBarbershop.Controller;
using cartellBarbershop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartellBarbershop.GUI
{
    public partial class DeleteCustomer : Form
    {
        public CustomerController customerCtr;

        public DeleteCustomer()
        {
            InitializeComponent();
            customerCtr = new CustomerController();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            customerCtr.deleteCustomer(deleteBox.Text);
        }
    }
}
