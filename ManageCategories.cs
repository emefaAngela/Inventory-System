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
    public partial class ManageCategories : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        public ManageCategories()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "Select * from categories";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = category_name.Text;
            String description = category_des.Text;
            if (name != "" && description != "")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into categories(category_name,category_description) values (?name, ?description )";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?description", description);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category has been added succesfully");
                loaddata();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            //this.Hide();
            //AddCategory addCategory = new AddCategory();
            //addCategory.Show();
        }

        private void updatecategory_Click(object sender, EventArgs e)
        {
            String name = category_name.Text;
            String description = category_des.Text;
            String id = category_id.Text;
            if (name != "" && description != "" && id!="")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "update categories set category_name=?name,category_description=?description where category_id=?id";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?description", description);
                command.Parameters.AddWithValue("?id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category has been updated succesfully");
                loaddata();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = category_name.Text;
            String description = category_des.Text;
            String id = category_id.Text;
            if (name != "" && description != "" && id != "")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "delete from categories where category_id=?id";

                
                command.Parameters.AddWithValue("?id", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Category has been deleted succesfully");
                loaddata();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void closeform_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
        }
    }
}
