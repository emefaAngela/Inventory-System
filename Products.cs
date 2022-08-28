using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManagementSystem
{
    class Products
    {
        public static string connectionstring = "Datasource = 127.0.0.1; username=root;password=;database=supermarket";

        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
    }
}
