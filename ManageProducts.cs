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
            loaddata();
        }
        public void loaddata()
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "Select * from Products";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = product_name.Text;
            String price = product_price.Text;
            String des = product_des.Text;
            String reorder = reorder_level.Text;
            String quantity = product_quantity.Text;
            String code = product_code.Text;
            if (name != "" && price != "" && des!=""&& reorder!=""&&quantity!=""&&code!="")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into products(product_name,product_price,product_description,product_quantity,product_qrcode,reorder_level) values (?name, ?price,?des,?quantity,?code,?reorder )";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?price", price);
                command.Parameters.AddWithValue("?des", des);
                command.Parameters.AddWithValue("?quantity", quantity);
                command.Parameters.AddWithValue("?code", code);
                command.Parameters.AddWithValue("?reorder", reorder);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product has been added succesfully");
                loaddata();



            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            String name = product_name.Text;
            String price = product_price.Text;
            String des = product_des.Text;
            String reorder = reorder_level.Text;
            String quantity = product_quantity.Text;
            String code = product_code.Text;
            String id = product_id.Text;
            if (name != "" && price != "" && des != "" && reorder != "" && quantity != "" && code != "" && id!="")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "update products set product_name=?name,product_price=?price,product_description=?des,product_quantity=?quantity,product_qrcode=?code,reorder_level=?reorder where product_id=?id";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?price", price);
                command.Parameters.AddWithValue("?des", des);
                command.Parameters.AddWithValue("?quantity", quantity);
                command.Parameters.AddWithValue("?code", code);
                command.Parameters.AddWithValue("?reorder", reorder);
                command.Parameters.AddWithValue("?id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product has been updated succesfully");
                loaddata();



            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            String name = product_name.Text;
            String price = product_price.Text;
            String des = product_des.Text;
            String reorder = reorder_level.Text;
            String quantity = product_quantity.Text;
            String code = product_code.Text;
            String id = product_id.Text;
            if (name != "" && price != "" && des != "" && reorder != "" && quantity != "" && code != "" && id != "")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "delete from products where product_id=?id";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?price", price);
                command.Parameters.AddWithValue("?des", des);
                command.Parameters.AddWithValue("?quantity", quantity);
                command.Parameters.AddWithValue("?code", code);
                command.Parameters.AddWithValue("?reorder", reorder);
                command.Parameters.AddWithValue("?id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product has been deleted succesfully");
                loaddata();



            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }
    }
}
