using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudentManagementSystem
{
    public partial class CustomerPicker : Form
    {
        public CustomerPicker()
        {
            InitializeComponent();
        }

        private void _customerpotential_Click(object sender, EventArgs e)
        {
            Form CustomerPotential = new CustomerPotential();
            CustomerPotential.ShowDialog();
        }

        private void _viewPotential_Click(object sender, EventArgs e)
        {
            Form PotentialGrid = new PotentialGrid();
            PotentialGrid.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
