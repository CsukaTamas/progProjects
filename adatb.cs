using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazisKezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builde = new MySqlConnectionStringBuilder { Server = "127.0.0.1", Database = "ingatlan", UserID = "root", Password = "" };
            MySqlConnection kapcsolat = new MySqlConnection(builde.ConnectionString);
            kapcsolat.Open();

            /*
            var parancssor = kapcsolat.CreateCommand();
            parancssor.CommandText = "SELECT * FROM `sellers`";
            var reader = parancssor.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt64(0)} {reader.GetString(1)} {reader.GetString(2)}");
            }
            */

            /*
            var parancssor = kapcsolat.CreateCommand();
            parancssor.CommandText = "SELECT name FROM sellers WHERE id = (SELECT sellerId FROM realestates WHERE area = (SELECT max(area) FROM realestates));\r\n";
            var reader = parancssor.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetString(0)}");
            }
            */

            var parancssor = kapcsolat.CreateCommand();
            parancssor.CommandText = "SELECT max(area) FROM realestates";
            var reader = parancssor.ExecuteReader();
            int nm = 0;
            while (reader.Read())
            {
                nm = reader.GetInt32(0);
            }
            parancssor.CommandText = $"SELECT sellerId FROM realestates WHERE area = {nm}";
            reader = parancssor.ExecuteReader();
            int sellerID = 0;
            while (reader.Read())
            {
                sellerID = reader.GetInt32(0);
            }
            //parancssor.CommandText = $"SELECT "


            kapcsolat.Close();


            Console.ReadKey();
        }
    }
}
