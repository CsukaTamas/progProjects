using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torpedoJatek
{
    public partial class Form1 : Form
    {
        CheckBox[,] sajat = new CheckBox[10, 10];
        CheckBox[,] lovesek = new CheckBox[10, 10];
        CheckBox[,] puska = new CheckBox[10, 10];
        Button btnJatek = new Button();
        Button btnKilep = new Button();
        string[] palyak = System.IO.File.ReadAllLines("palyak.txt", Encoding.UTF8);
        int valasztott = 0;
        static bool joE(CheckBox[,] matrix)
        {
            bool[] hajok = new bool[6];

            int[] kooSor = new int[5];
            int[] kooOszlop = new int[5];

            int[,] alap = new int[12, 12];

            int jelolt = 0;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (matrix[i, j].Checked)
                    {
                        alap[i + 1, j + 1] = 1;
                        jelolt++;
                    }
                    else alap[i + 1, j + 1] = 0;

            if (jelolt != 15) // 15 jelölés vizsgálata
            {
                return false;
            }

            for (int s = 1; s < 12; s++)
            {
                jelolt = 0;
                for (int o = 1; o < 12; o++)
                {
                    if (alap[s, o] == 1) jelolt++;
                    else
                    {
                        if (jelolt <= 5) hajok[jelolt] = true;
                        else
                        {
                            return false;
                        }
                        jelolt = 0;
                    }
                }
            }
            for (int o = 1; o < 12; o++)
            {
                jelolt = 0;
                for (int s = 1; s < 12; s++)
                {
                    if (alap[s, o] == 1) jelolt++;
                    else
                    {
                        if (jelolt <= 5) hajok[jelolt] = true;
                        else
                        {
                            return false;
                        }
                        jelolt = 0;
                    }
                }
            }

            for (int i = 1; i < 6; i++)
            {
                if (!hajok[i])
                {
                    return false;
                }
            }

            for (int hajo = 5; hajo > 0; hajo--)
            {
                if (!hajok[hajo]) continue;

                for (int s = 1; s < 12; s++)
                {
                    jelolt = 0;
                    kooSor = new int[5];
                    kooOszlop = new int[5];

                    for (int o = 1; o < 12; o++)
                    {
                        if (alap[s, o] == 1)
                        {
                            kooOszlop[jelolt] = o;
                            kooSor[jelolt] = s;
                            jelolt++;
                        }
                        else
                        {
                            if (jelolt == hajo)
                            {
                                for (int torol = 0; torol < jelolt; torol++)
                                {
                                    alap[kooSor[torol], kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] - 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] + 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] - 1] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] + 1] = 0;
                                }
                                hajok[hajo] = false;
                                jelolt = 0;
                                continue;
                            }
                            else
                            {
                                jelolt = 0;
                                continue;
                            }

                        }
                    }
                }
                if (!hajok[hajo]) continue;

                for (int o = 1; o < 12; o++)
                {
                    jelolt = 0;
                    kooSor = new int[5];
                    kooOszlop = new int[5];

                    for (int s = 1; s < 12; s++)
                    {
                        if (alap[s, o] == 1)
                        {
                            kooOszlop[jelolt] = o;
                            kooSor[jelolt] = s;
                            jelolt++;
                        }
                        else
                        {
                            if (jelolt == hajo)
                            {
                                for (int torol = 0; torol < jelolt; torol++)
                                {
                                    alap[kooSor[torol], kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] - 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol] + 1, kooOszlop[torol]] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] - 1] = 0;
                                    alap[kooSor[torol], kooOszlop[torol] + 1] = 0;
                                }
                                hajok[hajo] = false;
                                jelolt = 0;
                                continue;
                            }
                            else
                            {
                                jelolt = 0;
                                continue;
                            }
                        }
                    }
                }
            }

            for (int i = 1; i < 6; i++)
            {
                if (hajok[i])
                {
                    return false;
                }
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnJatek.Location = new Point(470, 15);
            btnJatek.AutoSize = false;
            btnJatek.Size = new Size(100, 30);
            btnJatek.Text = "Játék";
            btnJatek.Name = "btnJatek";
            btnJatek.Enabled = false;
            btnJatek.Visible = true;
            btnJatek.Click += new System.EventHandler(btnJatek_Click);
            Controls.Add(btnJatek);

            btnKilep.Location = new Point(470, 55);
            btnKilep.AutoSize = false;
            btnKilep.Size = new Size(100, 30);
            btnKilep.Text = "Kilépés";
            btnKilep.Name = "btnKilep";
            btnKilep.Enabled = true;
            btnKilep.Visible = true;
            btnKilep.Click += new System.EventHandler(btnKilep_Click);
            Controls.Add(btnKilep);

            for (int s = 0; s < 10; s++)
            {
                for (global::System.Int32 o = 0; o < 10; o++)
                {
                    lovesek[s, o] = new CheckBox();
                    lovesek[s, o].Location = new Point(230 + o * 20, 20 + s * 20);
                    lovesek[s, o].AutoSize = false;
                    lovesek[s, o].Size = new Size(20, 20);
                    lovesek[s, o].Visible = true;
                    lovesek[s, o].Enabled = false;
                    lovesek[s, o].Checked = false;
                    lovesek[s, o].Text = null;
                    Controls.Add(lovesek[s, o]);
                    lovesek[s, o].CheckedChanged += new EventHandler(lovesekChange);                    
                }
                
            }
            for (int s = 0; s < 10; s++)
            {
                for (global::System.Int32 o = 0; o < 10; o++)
                {
                    sajat[s, o] = new CheckBox();
                    sajat[s, o].Location = new Point(20 + o * 20, 20 + s * 20);
                    sajat[s, o].AutoSize = false;
                    sajat[s, o].Size = new Size(20, 20);
                    sajat[s, o].Visible = true;
                    sajat[s, o].Enabled = true;
                    sajat[s, o].Checked = false;
                    sajat[s, o].Text = null;
                    Controls.Add(sajat[s, o]);
                    sajat[s, o].CheckedChanged += new EventHandler(sajatEllenorzes);
                    

                }
            }
            sajat[0, 0].Checked = true;
            sajat[0, 2].Checked = true;
            sajat[0, 3].Checked = true;
            sajat[0, 5].Checked = true;
            sajat[0, 6].Checked = true;
            sajat[0, 7].Checked = true;
            sajat[2, 1].Checked = true;
            sajat[2, 2].Checked = true;
            sajat[2, 3].Checked = true;
            sajat[2, 4].Checked = true;
            sajat[4, 4].Checked = true;
            sajat[4, 5].Checked = true;
            sajat[4, 6].Checked = true;
            sajat[4, 7].Checked = true;
            sajat[4, 8].Checked = true;
            for (int s = 0; s < 10; s++)
            {
                for (global::System.Int32 o = 0; o < 10; o++)
                {
                    puska[s, o] = new CheckBox();
                    puska[s, o].Location = new Point(20 + o * 20, 230 + s * 20);
                    puska[s, o].AutoSize = false;
                    puska[s, o].Size = new Size(20, 20);
                    puska[s, o].Visible = true;
                    puska[s, o].Enabled = false;
                    puska[s, o].Checked = false;
                    puska[s, o].Text = null;
                    Controls.Add(puska[s, o]);
                }
            }          
        }

        private void btnJatek_Click(object sender, EventArgs e)
        {

            foreach (var item in sajat)
            {
                item.BackColor = Color.White;
                item.Enabled = false;
            }

            foreach (var item in lovesek)
            {
                item.Enabled = true;
            }

            //valasztott = new Random().Next(0, palyak.Length);
            valasztott = 2;
                
            int ii = 0;
                
            foreach (var item in puska)  
            {     
                item.Checked = palyak[valasztott][ii] == '1';  
                ii++;      
            }
        }
        private void sajatEllenorzes(object sender, EventArgs e)
        {
            if (joE(sajat))
            {
                foreach (var item in sajat) item.BackColor = Color.Green;
                btnJatek.Enabled = true;
            }
            else
            {
                foreach (var item in sajat) item.BackColor = Color.Red;
                btnJatek.Enabled = false;
            }
        }
        private void btnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void lovesekChange(object sender, EventArgs e)
        {
            int poz = 0;
            foreach (var item in lovesek)
            {
                if (item.Enabled && item.Checked)                
                { 
                    item.Enabled = false;
                    break; 
                }
                else poz++;                
            }

            if (palyak[valasztott][poz] == '1')
            {
                lovesek[poz / 10, poz % 10].BackColor = Color.Yellow;

                bool sor = false;
                bool oszlop = false;

                int maxO = 0;
                int minO = 0;
                int maxS = 0;
                int minS = 0;

                for (int i = (poz / 10) + 1; i < 10; i++)
                {
                    if (puska[i, poz % 10].Checked) oszlop = true;
                    else if (!puska[i, poz % 10].Checked) 
                    {
                        maxO = i - 1;
                        break;
                    }
                }
                for (int i = (poz / 10) - 1; i >= 0; i--)
                {
                    if (puska[i, poz % 10].Checked) oszlop = true;
                    else if (!puska[i, poz % 10].Checked) 
                    {
                        minO = i + 1;
                        break;
                    } 
                }

                if (!oszlop)
                {
                    for (int i = (poz % 10) - 1; i >= 0; i--)
                    {
                        if (puska[poz / 10, i].Checked) sor = true;
                        else if (!puska[poz / 10, i].Checked)
                        {
                            minS = i + 1;
                            break;
                        };
                    }
                    for (int i = (poz % 10) + 1; i < 10; i++)
                    {
                        if (puska[poz / 10, i].Checked) sor = true;
                        else if (!puska[poz / 10, i].Checked)
                        {
                            maxS = i - 1;
                            break;
                        }
                    }
                }
                
                if (!sor && !oszlop)
                {
                    lovesek[poz / 10, poz % 10].BackColor = Color.Red;
                    return;
                }

                if(sor)
                {
                    bool sulyed = true;
                    for (int i = minS; i <= maxS; i++)
                    {
                        if (lovesek[poz / 10, i].BackColor != Color.Yellow)
                        {
                            sulyed = false;
                            break;
                        }
                    }
                    if (!sulyed) return;
                    for (int i = minS; i <= maxS; i++)
                    {
                        lovesek[poz / 10, i].BackColor = Color.Red;
                    }
                }


            }
            else
            {
                lovesek[poz / 10, poz % 10].BackColor = Color.Blue;
                return;
            }
        }
    }
}
