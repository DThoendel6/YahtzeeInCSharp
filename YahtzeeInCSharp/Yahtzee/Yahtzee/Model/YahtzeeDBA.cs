using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Dominic Thoendel
 * Program: Yahtzee
*/
namespace Yahtzee.Model
{
    class YahtzeeDBA
    {
        public static SqlConnection GetYahtzeeConnection()
        {
            // connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dthoe\source\repos\Yahtzee\Yahtzee\YahtzeeDB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}

