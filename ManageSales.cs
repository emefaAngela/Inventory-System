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
    public partial class ManageSales : Form
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket;Allow User Variables=True";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        public ManageSales()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "Select * from sales";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DateTime date = DateTime.Today;
            currentDate.Text = dateTimePicker1.Value.ToString();
        }

        private void startsale_Click(object sender, EventArgs e)
        {
            DateTime start =DateTime.Now;
            DateTime date = DateTime.Today;
            DateTime end = new DateTime();

            connection = new MySqlConnection(connectionstring);
            connection.Open();

            command = new MySqlCommand("INSERT INTO sales (start_time,sales_date) values(?start,?date) ", connection);

            command.Parameters.AddWithValue("?start", start);
            command.Parameters.AddWithValue("?date", date);
            command.ExecuteNonQuery();
            MessageBox.Show("You have successfully started a sale");
            loaddata();

            currentDate.Text=date.ToString("'yyyy'-'MM'-'dd' ");
            //if (currentDate.Text != "")
            //{
            //    connection = new MySqlConnection(connectionstring);
            //    connection.Open();
            //    MySqlCommand command = connection.CreateCommand();
            //    command.CommandText = "insert into sales(start_time,sales_date) values (?start, ?currentDate.Text)";

            //    command.Parameters.AddWithValue("?start", start);
            //    command.Parameters.AddWithValue("?currentDate.Text", currentDate.Text);
               
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("You have  succesfully started a sale.");



            //}
            //else
            //{
            //    MessageBox.Show("Please Provide Details!");
            //}

        
    }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " yyyy MMMM dd";
        }

        

        private void endSale_Click(object sender, EventArgs e)
        {

        }
    }
}
