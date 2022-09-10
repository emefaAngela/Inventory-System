using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class AttendantDashboard : Form
    {
        public AttendantDashboard()
        {
            InitializeComponent();
        }

        private void logout_attendant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void close_atten_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSales manageSales = new ManageSales();
            manageSales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
