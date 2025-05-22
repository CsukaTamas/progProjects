using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySqlConnector;

namespace adatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "",
            };
            var kapcsolat = new MySqlConnection(server.ConnectionString);
            var sqlParancs = kapcsolat.CreateCommand();

            #region kiosztas
            string[] kiosztasAdat = File.ReadAllLines("kiosztas.txt", Encoding.UTF8);

            sqlParancs.CommandText = "CREATE DATABASE IF NOT EXISTS radioadok CHARACTER SET utf8 COLLATE utf8_hungarian_ci;";
            sqlParancs.CommandText += "USE radioadok;";
            sqlParancs.CommandText += "DROP TABLE IF EXISTS kiosztas;\n";
            sqlParancs.CommandText += "CREATE TABLE kiosztas (" +
                $"azon INT AUTO_INCREMENT PRIMARY KEY," +
                $"{kiosztasAdat[0].Split('\t')[0].Trim()} FLOAT," +
                $"{kiosztasAdat[0].Split('\t')[1].Trim()} FLOAT," +
                $"{kiosztasAdat[0].Split('\t')[2].Trim()} VARCHAR(255)," +
                $"{kiosztasAdat[0].Split('\t')[3].Trim()} VARCHAR(255)," +
                $"{kiosztasAdat[0].Split('\t')[4].Trim()} VARCHAR(255))";

            kapcsolat.Open();
            var reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();

            sqlParancs.CommandText = $"INSERT INTO kiosztas(" +
                $"{kiosztasAdat[0].Split('\t')[0].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[1].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[2].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[3].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[4].Trim()}) VALUES";

            for (int i = 1; i < kiosztasAdat.Length; i++)
            {
                sqlParancs.CommandText += $"(" +
                $"{kiosztasAdat[i].Split('\t')[0].Trim()}," +
                $"{kiosztasAdat[i].Split('\t')[1].Trim()}," +
                $"'{kiosztasAdat[i].Split('\t')[2].Trim()}'," +
                $"'{kiosztasAdat[i].Split('\t')[3].Trim()}',";
                if (kiosztasAdat[i].Split('\t')[4].Trim() != "")
                {
                    sqlParancs.CommandText += $"'{kiosztasAdat[i].Split('\t')[4].Trim()}')";
                }
                else sqlParancs.CommandText += $"NULL)";
                
                if (i != kiosztasAdat.Length - 1) sqlParancs.CommandText += $",\n";
            }
            //Console.WriteLine(sqlParancs.CommandText);
            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();

            #endregion

            #region telepules
            string[] telepulesAdat = File.ReadAllLines("telepules.txt", Encoding.UTF8);

            sqlParancs.CommandText = "DROP TABLE IF EXISTS telepules;\n";
            sqlParancs.CommandText += "CREATE TABLE telepules (" +
                $"{telepulesAdat[0].Split('\t')[0].Trim()} VARCHAR(255) PRIMARY KEY," +
                $"{telepulesAdat[0].Split('\t')[1].Trim()} VARCHAR(255))";
            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();

            sqlParancs.CommandText = $"INSERT INTO telepules(" +
                $"{telepulesAdat[0].Split('\t')[0].Trim()}," +
                $"{telepulesAdat[0].Split('\t')[1].Trim()}) VALUES";

            for (int i = 1; i < telepulesAdat.Length; i++)
            {
                sqlParancs.CommandText += $"(" +
                $"'{telepulesAdat[i].Split('\t')[0].Trim()}'," +
                $"'{telepulesAdat[i].Split('\t')[1].Trim()}')";               
                if (i != telepulesAdat.Length - 1) sqlParancs.CommandText += $",\n";
            }
            //Console.WriteLine(sqlParancs.CommandText);
            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();
            #endregion

            #region regio
            string[] regioAdat = File.ReadAllLines("regio.txt", Encoding.UTF8);

            sqlParancs.CommandText = "DROP TABLE IF EXISTS regio;\n";
            sqlParancs.CommandText += "CREATE TABLE regio (" +
                $"{regioAdat[0].Split('\t')[0].Trim()} VARCHAR(255)," +
                $"{regioAdat[0].Split('\t')[1].Trim()} VARCHAR(255) PRIMARY KEY)";
            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();

            sqlParancs.CommandText = $"INSERT INTO regio(" +
                $"{regioAdat[0].Split('\t')[0].Trim()}," +
                $"{regioAdat[0].Split('\t')[1].Trim()}) VALUES";

            for (int i = 1; i < regioAdat.Length; i++)
            {
                sqlParancs.CommandText += $"(" +
                $"'{regioAdat[i].Split('\t')[0].Trim()}'," +
                $"'{regioAdat[i].Split('\t')[1].Trim()}')";
                if (i != regioAdat.Length - 1) sqlParancs.CommandText += $",\n";
            }
            //Console.WriteLine(sqlParancs.CommandText);
            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();
            #endregion

            sqlParancs.CommandText = "ALTER TABLE kiosztas ADD CONSTRAINT FOREIGN KEY (adohely) REFERENCES telepules(nev);";
            sqlParancs.CommandText += "ALTER TABLE telepules ADD CONSTRAINT FOREIGN KEY (megye) REFERENCES regio(megye);";

            reader = sqlParancs.ExecuteReader();
            reader.Read();
            reader.Close();

            kapcsolat.Close();
            Console.WriteLine("Kész");
            Console.ReadKey();
        }
    }
}
