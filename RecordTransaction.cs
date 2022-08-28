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
    public partial class RecordTransaction : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
       // MySqlCommand command = new MySqlCommand();
        //MySqlDataAdapter adapter = new MySqlDataAdapter();
        //MySqlDataReader reader;
        //DataSet ds = new DataSet();

        public RecordTransaction()
        {
            InitializeComponent();
        }
       

        private void load_details()
        {
            MySqlConnection connection = new MySqlConnection();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader reader;
            DataSet ds = new DataSet();
            if (qrcode.Text != "")
            {
                connection = new MySqlConnection(connectionstring);
                //connection.Open();
                command = new MySqlCommand ("Select * from products where product_qrcode='" + qrcode.Text +"'",connection);
                connection.Open();
                reader = command.ExecuteReader();
                
                if (reader.Read()) {
                    product_name.Text = (String)reader[2];
                    product_price.Text = (String)reader[1].ToString();
                }
                
                
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void completeTransaction_Click(object sender, EventArgs e)
        {
       
            String customerName = customer.Text;
            String code = qrcode.Text;
            String AttendantName = attendant.Text;
            String product = product_name.Text;
            String price = product_price.Text;
            String quantity = product_quantity.Text;

                

            if(customerName!="" && AttendantName!="" && code != "")
            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText="Insert into transactions(customer_name,attendant_name,product_name) values(?customerName,?AttendantName,?product)";
                //connection.Open();
                command.Parameters.AddWithValue("?customerName", customerName);
                command.Parameters.AddWithValue("?AttendantName", AttendantName);
                command.Parameters.AddWithValue("?product", product);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Transaction has been recorded successfully");
            }
            else
            {
                MessageBox.Show("Please provide transaction details!");
            }
            
        }

        private void qrcode_TextChanged(object sender, EventArgs e)
        {
            load_details();
        }
    }
}
