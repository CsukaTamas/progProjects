using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace barlang
{
    class Barlang
    {
        public int azon { get; private set; }
        public string nev { get; private set; }

        public string telepules { get; private set; }
        public string vedettseg { get; set; }

        private int H = 0;
        public int hossz
        {
            get
            {
                return H;
            }
            set
            {
                if (H <= value || value == 0)
                {
                    H = value;
                }
            }
        }
        private int M = 0;
        public int melyseg
        {
            get
            {
                return M;
            }
            set
            {
                if (M <= value)
                {
                    M = value;
                }
            }
        }
        public Barlang(string line)
        {
            try 
            {
                string[] strings = line.Split(';');
                azon = int.Parse(strings[0]);
                nev = strings[1];
                hossz = int.Parse(strings[2]);
                melyseg = int.Parse(strings[3]);
                telepules = strings[4];
                vedettseg = strings[5];
            }
            catch (Exception)
            {
                hossz = 0;
            }
        }

        public override string ToString()
        {
            return $"Azon: {azon}\nNév: {nev}\nHossz: {hossz}\nMélység: {melyseg}\nTelepülés: {telepules}\nVédettség: {vedettseg}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Barlang a = new Barlang("1;Név;500;50;Település;Védettség");
            Console.WriteLine(a.ToString());
            a.hossz = 600;
            Console.WriteLine(a.ToString());
            a.hossz = 599;
            Console.WriteLine(a.ToString());
            */   //teszteset


            //1. feladat

            List<Barlang> barlangok = new List<Barlang>();

            StreamReader sr = new StreamReader("..\\..\\..\\barlangok.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                Barlang tmp = new Barlang(sr.ReadLine());
                if (tmp.hossz != 0) barlangok.Add(tmp);   //continue;
                //Console.WriteLine(tmp.ToString());
            }

            sr.Close();

            //2. feladat

            Console.WriteLine($"2. feladat: Barlangok száma: {barlangok.Count}");

            //3. feladat

            int db = 0, melyseg = 0;

            foreach (var item in barlangok)
            {
                if (item.nev.StartsWith("Miskolc"))
                {
                    db++;
                    melyseg += item.melyseg;
                }
            }

            Console.WriteLine($"3. feladat: Az átlagos mélység: {(double)melyseg / (double)db} m");

            //4. feladat

            Console.Write("4. feladat: Kérem a védettségi szintet: ");
            string kvedszint = Console.ReadLine();




            Console.ReadKey();
        }
    }
}
