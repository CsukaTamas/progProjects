using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lnko_lkkt
{
    public partial class Form1 : Form
    {
        private int lnko(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private int lkkt(int a, int b)
        {
            return Math.Abs(a * b) / lnko(a, b);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnko_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lkkt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eredmeny_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            if (!int.TryParse(number1.Text, out num1) || !int.TryParse(number2.Text, out num2))
            {
                MessageBox.Show("Kérem adjon meg két érvényes számot!", "Hiba", MessageBoxButtons.OK);
                return;
            }

            if (lnkoSum.Checked)
            {
                int lnkoSzam = lnko(num1, num2);
                eredmeny.Text = $"{lnkoSzam}";
            }
            else if (lkktSum.Checked)
            {
                int lkktSzam = lkkt(num1, num2);
                eredmeny.Text = $"{lkktSzam}";
            }
            else
            {
                MessageBox.Show("Kérem válasszon egy számítást (LNKO vagy LKKT)!", "Hiba", MessageBoxButtons.OK);
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
