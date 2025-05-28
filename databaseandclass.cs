using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    class adat
    {
        public int id { get; set; }
        public string nev { get; set; }
        public int eletkor { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builde = new MySqlConnectionStringBuilder 
            {
                Server = "127.0.0.1", 
                Database = "pelda", 
                UserID = "root", 
                Password = "" 
            };
            MySqlConnection kapcsolat = new MySqlConnection(builde.ConnectionString);
            kapcsolat.Open();

            List<adat> adatok = new List<adat>();

            var parancssor = kapcsolat.CreateCommand();
            parancssor.CommandText = "SELECT azon, nev, eletkor FROM emberek";
            var reader = parancssor.ExecuteReader();
            while (reader.Read())
            {
                var ujAdat = new adat
                {
                    id = reader.GetInt32("azon"),
                    nev = reader.GetString("nev"),
                    eletkor = reader.GetInt32("eletkor")
                };

                adatok.Add(ujAdat);
            }

            kapcsolat.Close();

            //adatok kiiratása

            foreach (var elem in adatok)
            {
                Console.WriteLine($"Név: {elem.nev}, {elem.eletkor} éves (Azonosító: {elem.id})");
            }

            //emberek átlagéletkora

            int osszkor = 0;
            foreach (var elem in adatok)
            {
                osszkor += elem.eletkor;
            }
            Console.WriteLine($"Az emberek átlagéletkora: {osszkor / adatok.Count}");

            Console.ReadKey();
        }
    }
}
