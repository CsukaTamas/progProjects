using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bingo2
{
    public partial class Form1 : Form
    {
        public int[] tol = new int[] { 1, 16, 31, 46, 61 };
        public int[] ig = new int[] { 16, 31, 46, 61, 76 };
        public int[,] szamok = new int[5, 5];
        public TextBox[,] Boxes = new TextBox[5, 5];

        public Form1()
        {
            InitializeComponent();
        }
        private void kozepso ()
        {
            Boxes[2, 2].Text = "X";
            Boxes[2, 2].Enabled = false;
        }
        public TextBox txbFileName = new TextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Bingo";
            Size = new Size(200, 300);
            ClientSize = new Size(200, 281);
            MinimumSize = Size;
            MaximumSize = Size;

            Button btnGeneral = new Button();
            btnGeneral.Text = "Kártya generálása";
            btnGeneral.Size = new Size(150, 50);
            btnGeneral.Location = new Point(25, 10);
            btnGeneral.Click += new EventHandler(btnGeneral_Click);
            Controls.Add(btnGeneral);

            Button btnSave = new Button();
            btnSave.Text = "Mentés";
            btnSave.Size = new Size(150, 50);
            btnSave.Location = new Point(25, 231);
            btnSave.Click += new EventHandler(btnSave_Click);
            Controls.Add(btnSave);

            
            txbFileName.Text = "bingo.txt";
            txbFileName.Size = new Size(150, 50);
            txbFileName.Location = new Point(25, 211);
            Controls.Add(txbFileName);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Boxes[i,j] = new TextBox();
                    Boxes[i, j].Size = new Size(25, 25);
                    Boxes[i, j].Location = new Point(25 + i * 31, 60 + j * 31);
                    Boxes[i, j].Visible = false;
                    Boxes[i, j].AutoSize = false;
                    Boxes[i, j].TextAlign = HorizontalAlignment.Center;


                    Controls.Add(Boxes[i, j]);
                }
            }
            
        }
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            

            for (int i = 0; i < 5; i++)
            {
                HashSet<int> set = new HashSet<int>();

                for (int j = 0; j < 5; j++)
                {
                    int halmazhossz = set.Count;
                    int a = 0;
                    while (set.Count != halmazhossz+1)
                    {
                        a = rnd.Next(tol[i], ig[i]);
                        set.Add(a);
                    }
                    Boxes[i, j].Text = a.ToString();
                    szamok[i, j] = a;
                    Boxes[i, j].Visible = true;

                }               
            }
            kozepso();
            foreach (var item in Boxes)
            {
                item.LostFocus += new EventHandler(Boxes_TextChange);
            }


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(txbFileName.Text, false, Encoding.UTF8);
            int ii = 0;
            foreach (var item in Boxes)
            {
                ii++;
                if (ii % 5 == 0) 
                {
                    sw.WriteLine(item.Text);
                    continue;
                }
                else
                {
                    sw.Write($"{item.Text}; ");
                }
            
            }
            sw.Close();

        }
        
        private void Boxes_TextChange(object sender, EventArgs e)
        {
            try
            {
                bool hiba = false;
                for (int i = 0; i < 5; i++)
                {
                    if (hiba) break;
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 2 && j == 2) continue;

                        if (int.Parse(Boxes[i, j].Text) < tol[i] || int.Parse(Boxes[i, j].Text) >= ig[i])
                        {
                            Boxes[i, j].Text = szamok[i, j].ToString();
                            kozepso();
                            hiba = true;
                            break;
                        }

                        HashSet<string> vizsga = new HashSet<string>();

                        for (int k = 0; k < 5; k++)
                        {
                            vizsga.Add(Boxes[i, k].Text);
                        }

                        if (vizsga.Count != 5)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                Boxes[i, k].Text = szamok[i, k].ToString();
                            }
                            kozepso();
                            hiba = true;
                            break;
                        }      
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        if (i == 2 && k == 2) continue;
                        szamok[i, k] = int.Parse(Boxes[i, k].Text);
                    }
                }
            }
            catch (Exception)
            { 
                for (int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        Boxes[i, j].Text = szamok[i, j].ToString();
                    }
                    kozepso();
                }
            }
  
        }
    }
}
