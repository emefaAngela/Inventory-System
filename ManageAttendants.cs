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
    public partial class ManageAttendants : Form

    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        public ManageAttendants()
        {
            InitializeComponent();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AddAttendant addAttendant = new AddAttendant();
            //addAttendant.Show();
            String name = atten_name.Text;
            String email = atten_email.Text;
            String password = atten_password.Text;
            if (name != "" && email != "" && password != "")

            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into attendants(attendant_name,attendant_password,attendant_email) values (?name, ?password,?email )";

                command.Parameters.AddWithValue("?name", name);
                command.Parameters.AddWithValue("?password", password);
                command.Parameters.AddWithValue("?email", email);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Attendant has been added succesfully");
                loaddata();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        public void loaddata()
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "Select * from Attendants";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
