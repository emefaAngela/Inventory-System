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
    public partial class Form2 : Form
    {

        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String username = user.Text;
            String pass = password.Text;
            connection = new MySqlConnection(connectionstring);
            if (username != "" && pass != "")
            {
                
                string query = "select user_name,user_password,user_role from user WHERE user_name ='" + username + "' AND user_password ='" + pass + "'";
                connection.Open();
                MySqlDataReader row;
                MySqlCommand command = new MySqlCommand(query, connection);
                row=command.ExecuteReader();
                row.Read();
                if (row.HasRows && row[2].ToString() == "Admin") 
                {
                    this.Hide();
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();

                }
                else if(row.HasRows && row[2].ToString() == "Attendant")
                {
                    this.Hide();
                    AttendantDashboard ad = new AttendantDashboard();
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("Data not found", "Information");
                }
            }
            
        }
    }
}
