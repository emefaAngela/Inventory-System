using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1;  username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSales manageSales = new ManageSales();
            manageSales.Show();
        }

        private void Total_products_TextChanged(object sender, EventArgs e)
        {


            connection = new MySqlConnection(connectionstring);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader queryResult;
            connection.Open();
            command.CommandText = "SELECT count(*) from products";

            queryResult = command.ExecuteReader();

            //Return an object so first check for null
            if (queryResult.HasRows)
            {
                // If we have result, then convert it from object to string.
                //t_products.Text= Convert.ToString(queryResult);

                //MessageBox.Show(t_products.Text);
                queryResult.Read();
                Total_products.Text = queryResult.GetString(0);
                MessageBox.Show(queryResult.GetString(0));

            }
            else
            {
                MessageBox.Show("couldn't fetch");
            }
            //// Else make id = "" so you can later check it.
            

        }
    }
}
