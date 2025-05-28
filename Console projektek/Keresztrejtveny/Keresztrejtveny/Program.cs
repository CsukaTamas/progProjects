using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keresztrejtveny
{
    class KeresztrejtvenyRacs
    {
        public List<string> Adatsorok = new List<string>();
        public char[,] Racs;
        public int[,] Sorszamok;

        public int OszlopokDb
        {
            get { return Racs.GetLength(1); }
        }

        public int SorokDb
        {
            get { return Racs.GetLength(0); }
        }

        public KeresztrejtvenyRacs(string forras)
        {
            Adatsorok = new List<string>();
            BeolvasAdatsorok(forras);
            FeltoltRacs();
        }

        public void BeolvasAdatsorok(string forras)
        {
            try
            {
                string[] sorok = File.ReadAllLines(forras);
                foreach (var sor in sorok)
                {
                    Adatsorok.Add(sor.Trim());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a fájl beolvasása közben: " + e.Message);
            }
        }

        public void FeltoltRacs()
        {
            int sorokDb = Adatsorok.Count;
            int oszlopokDb = Adatsorok[0].Length;

            Racs = new char[sorokDb + 2, oszlopokDb + 2];
            Sorszamok = new int[sorokDb + 2, oszlopokDb + 2];

            for (int i = 0; i < sorokDb; i++)
            {
                for (int j = 0; j < oszlopokDb; j++)
                {
                    char karakter = Adatsorok[i][j];

                    if (karakter == '#' || karakter == '-')
                    {
                        Racs[i + 1, j + 1] = karakter;
                    }
                    else
                    {
                        throw new InvalidDataException($"Érvénytelen karakter található a fájlban: {karakter}");
                    }

                    Sorszamok[i + 1, j + 1] = (i * oszlopokDb) + j + 1;
                }
            }

            for (int i = 0; i < sorokDb + 2; i++)
            {
                for (int j = 0; j < oszlopokDb + 2; j++)
                {
                    if (i == 0 || i == sorokDb + 1 || j == 0 || j == oszlopokDb + 1)
                    {
                        Racs[i, j] = ' ';
                        Sorszamok[i, j] = 0;
                    }
                }
            }
        }

        public void KiirRacs()
        {
            for (int i = 0; i < Racs.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < Racs.GetLength(1) - 1; j++)
                {
                    if (Racs[i, j] == '-')
                    {
                        Console.Write("[]");
                    }
                    else if (Racs[i, j] == '#')
                    {
                        Console.Write("##");
                    }

                }
                Console.WriteLine();
            }
        }

        public void LeghosszFugg()
        {
            int leghossz = 0;
            int temp = 0;
            for (int i = 0; i < Racs.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < Racs.GetLength(0) - 1; j++)
                {
                    if (Racs[j, i] == '-')
                    {
                        temp++;
                    }
                    else
                    {
                        if (leghossz < temp)
                        {
                            leghossz = temp;
                        }
                        temp = 0;
                    }
                }


            }
            Console.WriteLine($"7. feladat: A leghosszabb függ.: {leghossz} karakter");
        }

        public void VizszStat()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //4f
            
            string forras = "kr1.txt";

            var keresztrejtveny = new KeresztrejtvenyRacs(forras);

            //5f

            Console.WriteLine("5. feladat: A keresztrejtvény mérete");
            Console.WriteLine($"\t Sorok száma: {keresztrejtveny.SorokDb - 2}");
            Console.WriteLine($"\t Oszlopok száma: {keresztrejtveny.OszlopokDb - 2}");

            //6f

            Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");

            keresztrejtveny.KiirRacs();

            //7f

            keresztrejtveny.LeghosszFugg();

            //8f

            

            Console.ReadKey();
        }
    }
}
