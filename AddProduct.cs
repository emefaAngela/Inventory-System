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
    public partial class AddProduct : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        //MySqlCommand command = new MySqlCommand();
        
        public AddProduct()
        {
            InitializeComponent();
        }

        private void closeaddproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = p_name.Text;
            String price  = p_price.Text;
            String description = category.Text;
            if(name!="" && price!= "")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText= "insert into products(product_name,product_price,product_description) values (?name, ?price,?description )";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?price", price);
                command.Parameters.AddWithValue("?description", description);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product has been added succesfully");

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            
            this.Close();
        }
    }
}
