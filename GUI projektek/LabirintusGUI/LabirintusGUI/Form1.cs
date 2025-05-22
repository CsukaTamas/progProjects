using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirintusGUI
{
    public partial class Form1 : Form
    {
        public bool generated = false;
        public int xValue;
        public int yValue;
        public int oldxValue;
        public int oldyValue;
        public CheckBox[,] Boxes = new CheckBox[20, 20];
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            xValue = Convert.ToInt32(cBx.Text);
            yValue = Convert.ToInt32(cBy.Text);

            if (generated == true && oldxValue != 0 && oldyValue != 0)
            {
                for (int i = 0; i < oldxValue; i++)
                {
                    for (int j = 0; j < oldyValue; j++)
                    {
                        Controls.Remove(Boxes[i, j]);
                    }
                }
            }
            generated = false;
            oldxValue = 0;
            oldyValue = 0;

            if (xValue < 5 || xValue > 20 || yValue < 5 || yValue > 20)
            {
                cBx.Text = "12";
                cBy.Text = "12";
                MessageBox.Show("Az sorok és az oszlopok száma 5-20 közötti érték lehet.");
            }
            else
            {
                for (int i = 0; i < xValue; i++)
                {
                    for (int j = 0; j < yValue; j++)
                    {
                        Boxes[i, j] = new CheckBox();
                        Boxes[i, j].Text = "";
                        if (i == 0 || j == 0 || i == xValue - 1 || j == yValue - 1)
                        {
                            Boxes[i, j].Checked = true;
                            Boxes[i, j].Enabled = false;
                        }
                        else Boxes[i, j].Checked = false;
                        Boxes[i, j].Size = new Size(15, 14);
                        Boxes[i, j].Location = new Point(20 + i * 16, 80 + j * 16);
                        Controls.Add(Boxes[i, j]);
                    }
                }
                Boxes[0, 1].Checked = false;
                Boxes[xValue - 1, yValue - 2].Checked = false;
                generated = true;
                oldxValue = xValue;
                oldyValue = yValue;
            }        
        }

        private void saveLab_Click(object sender, EventArgs e)
        {
            int labValue = Convert.ToInt32(cBvalue.Text);
            if (labValue < 1 || labValue > 16)
            {
                cBvalue.Text = "3";
                MessageBox.Show("Hiba történt. Az fájl állományának értéke 1-16 között lehet.");
            }
            else
            {
                StreamWriter sw = new StreamWriter($"Lab{labValue}.txt", false, Encoding.UTF8);
                if (generated == false)
                {
                    MessageBox.Show("Hiba történt. Nincsen létrehozott labirintus.");
                }
                else
                {
                    for (int j = 0; j < yValue; j++)
                    {
                        for (int i = 0; i < xValue; i++)
                        {
                            if (Boxes[i, j].Checked == true)
                            {
                                sw.Write("X");
                            }
                            if (Boxes[i, j].Checked == false)
                            {
                                sw.Write(' ');
                            }
                        }
                        sw.WriteLine();
                    }
                    MessageBox.Show("Az állomány mentése sikeres!");
                }
                sw.Close();
            }   
        }
    }
}
