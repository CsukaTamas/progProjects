using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace konyvek
{
    public partial class Form1 : Form
    {
        public class adat
        {
            public int evSzam;
            public int negyedEv;
            public string kiadHely;
            public string muCim;
            public int peldSzam;
            public adat(string sorok)
            {
                string[] strings = sorok.Split(';');
                this.evSzam = int.Parse(strings[0]);
                this.negyedEv = int.Parse(strings[1]);
                this.kiadHely = strings[2];
                this.muCim = strings[3];
                this.peldSzam = int.Parse(strings[4]);
            }
        }
        List<adat> konyvekLista = new List<adat>();
        HashSet<int> evek = new HashSet<int>(); 
        public Form1()
        {
            InitializeComponent();

            StreamReader beolv = new StreamReader("kiadas.txt", Encoding.UTF8);

            while (!beolv.EndOfStream)
            {
                konyvekLista.Add(new adat(beolv.ReadLine()));
            }
            beolv.Close();

            for (int i = 0; i < konyvekLista.Count; i++)
            {
                evek.Add(konyvekLista[i].evSzam);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //3. feladat
            int topPeldanySzam = 0;
            int elofordul = 0;

            for (int i = 0; i < konyvekLista.Count; i++)
            {
                if (konyvekLista[i].peldSzam > topPeldanySzam)
                {
                    topPeldanySzam = konyvekLista[i].peldSzam;
                }
            }

            for (int i = 0; i < konyvekLista.Count; i++)
            {
                if (topPeldanySzam == konyvekLista[i].peldSzam) elofordul++;
            }

            peldSzamLabel.Text = $"3. feladat: Legnagyobb példányszám: {topPeldanySzam}, előfordult {elofordul} alkalommal.";
            peldSzamLabel.Visible = true;

            //4. feladat
            for (int i = 0; i < konyvekLista.Count; i++)
            {
                if (konyvekLista[i].kiadHely == "kf" && konyvekLista[i].peldSzam >= 40000)
                {
                    kulfoldiMu40000.Text += $"{konyvekLista[i].evSzam}/{konyvekLista[i].negyedEv}. {konyvekLista[i].muCim}\n";
                }
            }


            //5. feladat
            //StreamWriter kiir = new StreamWriter("tabla.html");

            string weboldal = "<table><tr><th>Év</th><th>Magyar kiadás</th><th>Magyar példányszám</th><th>Külföldi kiadás</th><th>Külföldi példányszám</th></tr>";

            int szamlalo = 1;
            foreach (var i in evek)
            {
                //evszam

                TextBox txtev = new TextBox();
                txtev.Name = $"ev{i}";
                txtev.Text = $"{i}";
                txtev.Size = new Size(109, 20);
                txtev.Location = new Point(16, 250 + szamlalo * 26);
                txtev.TextAlign = HorizontalAlignment.Center;
                txtev.ReadOnly = true;
                this.Controls.Add(txtev);

                //adatok

                int magyarkiad = 0;
                int magyarpeldszam = 0;
                int kulfkiad = 0;
                int kulfpeldszam = 0;
                for (int j = 0; j < konyvekLista.Count; j++)
                {
                    if (konyvekLista[j].evSzam == i && konyvekLista[j].kiadHely == "ma")
                    {
                        magyarkiad++;
                        magyarpeldszam += konyvekLista[j].peldSzam;
                    }
                    else if (konyvekLista[j].evSzam == i && konyvekLista[j].kiadHely == "kf")
                    {
                        kulfkiad++;
                        kulfpeldszam += konyvekLista[j].peldSzam;
                    }
                }

                //magyarkiad

                TextBox txtmk = new TextBox();
                txtmk.Name = $"magyarkiad{i}";
                txtmk.Text = $"{magyarkiad}";
                txtmk.Size = new Size(109, 20);
                txtmk.Location = new Point(140, 250 + szamlalo * 26);
                txtmk.TextAlign = HorizontalAlignment.Center;
                txtmk.ReadOnly = true;
                this.Controls.Add(txtmk);

                //magyarpeldsz

                TextBox txtmp = new TextBox();
                txtmp.Name = $"magyarpeldsz{i}";
                txtmp.Text = $"{magyarpeldszam}";
                txtmp.Size = new Size(109, 20);
                txtmp.Location = new Point(264, 250 + szamlalo * 26);
                txtmp.TextAlign = HorizontalAlignment.Center;
                txtmp.ReadOnly = true;
                this.Controls.Add(txtmp);

                //kulfkiad

                TextBox txtkk = new TextBox();
                txtkk.Name = $"kulfkiad{i}";
                txtkk.Text = $"{kulfkiad}";
                txtkk.Size = new Size(109, 20);
                txtkk.Location = new Point(388, 250 + szamlalo * 26);
                txtkk.TextAlign = HorizontalAlignment.Center;
                txtkk.ReadOnly = true;
                this.Controls.Add(txtkk);

                //kulfpeldsz

                TextBox txtkp = new TextBox();
                txtkp.Name = $"kulfpeldsz{i}";
                txtkp.Text = $"{kulfpeldszam}";
                txtkp.Size = new Size(109, 20);
                txtkp.Location = new Point(512, 250 + szamlalo * 26);
                txtkp.TextAlign = HorizontalAlignment.Center;
                txtkp.ReadOnly = true;
                this.Controls.Add(txtkp);

                weboldal += $"<tr><td>{i}</td><td>{magyarkiad}</td><td>{magyarpeldszam}</td><td>{kulfkiad}</td><td>{kulfpeldszam}</td></tr>";

                szamlalo++;
            }

            weboldal += "</table>";

            StreamWriter kiir = new StreamWriter("tabla.html");
            kiir.WriteLine(weboldal);
            kiir.Close();
        }

        private void szerzoBeker_Click(object sender, EventArgs e)
        {
            //2. feladat
            string megadottSzerzo = szerzoNeve.Text;
            int talalat = 0;

            for (int i = 0; i < konyvekLista.Count; i++)
            {
                if (konyvekLista[i].muCim.Contains(megadottSzerzo)) talalat++;
            }

            if (talalat > 0)
            {
                muKiadLabel.Text = $"{megadottSzerzo} szerzőtől {talalat} alkalommal adtak ki könyvet.";
                muKiadLabel.Visible = true;
            }
            else
            {
                muKiadLabel.Text = "Nem adtak ki";
                muKiadLabel.Visible = true;
            }

        }
    }
}
