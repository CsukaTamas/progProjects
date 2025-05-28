using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace RealEstateGUI
{
    public partial class Form1 : Form
    {
        //static List<Seller> sellers = new List<Seller>();
        static List<Seller> activeSellers = new List<Seller>();
        static MySqlConnection kapcsolat;
        public Form1()
        {
            InitializeComponent();
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "",
                Database = "ingatlan"
            };
            kapcsolat = new MySqlConnection(builder.ConnectionString);
            kapcsolat.Open();
            activeSellers = fullRead();
            listBoxSellers.Items.Clear();
            foreach (var item in activeSellers)
            {
                listBoxSellers.Items.Add(item.Name);
            }
        }

        static List<Seller> activeRead()
        {
            List<Seller> a = new List<Seller>();
            var command = kapcsolat.CreateCommand();
            command.CommandText = "SELECT * FROM SELLERS WHERE ID IN (SELECT SELLERID FROM REALESTATES) ORDER BY NAME";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Seller tmp = new Seller();
                tmp.Id = reader.GetInt32("id");
                tmp.Name = reader.GetString("name");
                tmp.Phone = reader.GetString("phone");
                a.Add(tmp);
            }
            reader.Close();
            return a;
        }

        static List<Seller> fullRead()
        {
            List<Seller> a = new List<Seller>();
            var command = kapcsolat.CreateCommand();
            command.CommandText = "SELECT * FROM SELLERS ORDER BY NAME";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Seller tmp = new Seller();
                tmp.Id = reader.GetInt32("id");
                tmp.Name = reader.GetString("name");
                tmp.Phone = reader.GetString("phone");
                a.Add(tmp);
            }
            reader.Close();
            return a;
        }

        private void listBoxSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSellerName.Text = $"Eladó neve: {activeSellers[listBoxSellers.SelectedIndex].Name}";
            lblSellerPhone.Text = $"Eladó telefonszáma: {activeSellers[listBoxSellers.SelectedIndex].Phone}";
            btnHirdetések.Enabled = true;
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            btnHirdetések.Enabled = false;
            listBoxCoordinates.Items.Clear();
            lblCount.Text = "Hirdetések száma: -";
            if (btnSellers.BackColor == Color.Red)
            {
                btnSellers.BackColor = Color.Green;
                btnSellers.Text = "Aktív ügynök";
                activeSellers = fullRead();
                listBoxSellers.Items.Clear();
                foreach (var item in activeSellers)
                {
                    listBoxSellers.Items.Add(item.Name);
                }
            }
            else
            {
                btnSellers.BackColor = Color.Red;
                btnSellers.Text = "Összes ügynök";
                activeSellers = activeRead();
                listBoxSellers.Items.Clear();
                foreach (var item in activeSellers)
                {
                    listBoxSellers.Items.Add(item.Name);
                }
            } 
        }

        private void btnHirdetések_Click(object sender, EventArgs e)
        {
            /*var command = kapcsolat.CreateCommand();
            command.CommandText = $"SELECT COUNT(ID) FROM REALESTATES WHERE SELLERID = {activeSellers[listBoxSellers.SelectedIndex].Id}";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblCount.Text = $"Hirdetések száma: {reader.GetInt32(0)}";
            }
            reader.Close();*/

            var command = kapcsolat.CreateCommand();
            command.CommandText = $"SELECT * FROM REALESTATES WHERE SELLERID = {activeSellers[listBoxSellers.SelectedIndex].Id}";
            var reader = command.ExecuteReader();
            listBoxCoordinates.Items.Clear();
            while (reader.Read())
            {
                string a = "";
                a += $"Hirdetés száma: {reader.GetInt64("id")}\t";
                a += $"Szobák száma: {reader.GetInt64("rooms")}\t";
                a += $"Terület: {reader.GetInt64("area")}\t";
                a += $"Koordináta: {reader.GetString("latlong")}\t";
                listBoxCoordinates.Items.Add(a);
            }
            reader.Close();
            lblCount.Text = $"Hirdetések száma: {listBoxCoordinates.Items.Count.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Out(object sender, EventArgs e)
        {
            kapcsolat.Close();
        }
    }
    class Seller
    {
        public int Id { get; set; }
        public string Name;
        public string Phone;
    }
    class Category
    {
        public int Id;
        public string Name;
    }
    class Ad
    {
        public int Area;
        public int Floors;
        public int Id;
        public int Rooms;
        public Category Category;
        public DateTime CreateAt;
        public string Description;
        public string ImageUrl;
        public string Latlong;
        public bool FreeOfCharge;
        public Seller Seller;       
        
        public double DistanceTo(double x, double y)
        {
            double a = x - double.Parse(Latlong.Split(',')[0].Replace(".", ","));
            double b = y - double.Parse(Latlong.Split(',')[1].Replace(".", ","));
            return Math.Sqrt(a * a + b * b);
        }
    }
    
    
}
