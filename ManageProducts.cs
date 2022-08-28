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
    public partial class ManageProducts : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int totalproducts;
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select count(*) from products;";
            var queryResult = command.ExecuteScalar();//Return an object so first check for null
            if (queryResult != null)
                MessageBox.Show(Convert.ToString(queryResult));

            
            // If we have result, then convert it from object to string.
            //    totalproducts = queryResult;
            //total_products.Text.Replace(char 0, totalproducts);
            else
                // Else make id = "" so you can later check it.
                totalproducts = 0;
            //total_products.Text.Replace("0", totalproducts);

        }
    }
}
