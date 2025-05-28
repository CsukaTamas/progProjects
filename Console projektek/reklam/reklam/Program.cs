using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reklam
{
    internal class data
    {
        public byte day;
        public string city;
        public byte qt;
        public data(string dataLines)
        {
            string[] strings = dataLines.Split(' ');
            this.city = strings[1];
            this.day = byte.Parse(strings[0]);
            this.qt = byte.Parse(strings[2]);
        }
    }
    internal class Program
    {
        static public List<data> list = new List<data>();
        static int osszes(string city, byte day)
        {
            int osszeg = 0;
            foreach (var item in list)
            {
                if (item.day == day) osszeg += (int)item.qt;
            }
            return osszeg;
        }
        static void Main(string[] args)
        {
            string[] strings = File.ReadAllLines("rendel.txt");
            int length = strings.Length;


            #region 1.feladat
            foreach (var item in strings)
            {
                list.Add(new data(item));

            }
            #endregion

            Console.WriteLine($"2.feladat:\nA rendelések száma: {list.Count}");

            Console.Write("3.feladat\nKérem adja meg a napot: ");
            byte day = byte.Parse(Console.ReadLine());
            int count = 0;
            foreach (var item in list)
            {
                if (item.day == day) count++;
            }
            Console.WriteLine($"A rendelések száma az adott napon: {count}");

            HashSet<byte> rendelesiNapok = new HashSet<byte>();
            HashSet<byte> napok = new HashSet<byte>();
            foreach (var item in list)
            {
                napok.Add(item.day);
                if (item.city == "NR")
                {
                    rendelesiNapok.Add(item.day);
                }
            }
            Console.WriteLine($"4.feladat");
            if (rendelesiNapok.Count == napok.Count) Console.WriteLine("Minden nap volt rendelés a reklámban nem érintett városból");
            else Console.WriteLine($"{napok.Count - rendelesiNapok.Count} nap nem volt rendelés a reklámban nem érintett városból");

            int maxIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (list[i].qt > list[maxIndex].qt)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"5.feladat\nA legnagyobb darabszám: {list[maxIndex].qt}" +
                $", a rendelés napja: {list[maxIndex].day}");





            Console.ReadKey();
        }
    }
}