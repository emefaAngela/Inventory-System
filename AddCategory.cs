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
    public partial class AddCategory : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = c_name.Text;
            String description = c_description.Text;
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

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

            this.Close();
        }

        private void c_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
