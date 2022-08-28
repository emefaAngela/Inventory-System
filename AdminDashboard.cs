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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAttendants manageAttendants = new ManageAttendants();
            manageAttendants.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordTransaction recordTransaction = new RecordTransaction();
            recordTransaction.Show();
        }
    }
}
