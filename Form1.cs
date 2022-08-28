using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ManagementSystem
{
    public partial class Form1 : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();

        

        public Form1()
        {
            InitializeComponent();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //   connection = new SqlConnection(connectionstring);
           
        //    MessageBox.Show("connection open");
        //    connection.Close();
                 
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String user_email = email.Text;
            String password = input_password.Text;
            String confirm = confirmpassword.Text;
            String username = input_user.Text;
            String role = input_role.Text;
            connection = new MySqlConnection(connectionstring);
            if (user_email != String.Empty || username != String.Empty || password != String.Empty || confirm != String.Empty)
            {
                if (password == confirm)
                {
                   /* 
                    command = new SqlCommand("Select * from login where '" + input_user.Text + "' ", connection);
                    SqlDataReader datareader = command.ExecuteReader();
                    if (datareader.Read())
                    {
                        datareader.Close();
                        MessageBox.Show("Username exists");

                    }
                    else
                    {*/
                        //datareader.Close();
                        connection = new MySqlConnection(connectionstring);
                        connection.Open();

                        command = new MySqlCommand("Insert into user(user_name,user_role,user_password,user_email) values (?username,?role,?password,?user_email)", connection);
                        
                        command.Parameters.AddWithValue("?user_email", user_email);
                        command.Parameters.AddWithValue("?username", username);
                        command.Parameters.AddWithValue("?password", password);
                        command.Parameters.AddWithValue("?role", role);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your account have been created,Proceed to login.");
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.Show();


                    }
                //}MySqlException: Parameter '@user_id' must be defined.

                else
                {
                    MessageBox.Show("Please make sure you confirm the correct password", "Done", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Plese make sure all fields have been filled");
            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

