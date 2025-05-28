using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ugroAblak
{
    public partial class Form1 : Form
    {
        static int x = 0;
        static int y = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void mozgat(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            mozgat(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.WorkingArea.Width - Width;
            y = 0;
            mozgat(x, y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 0;
            y = Screen.PrimaryScreen.WorkingArea.Height - Height;
            mozgat(x, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.WorkingArea.Width - Width;
            y = Screen.PrimaryScreen.WorkingArea.Height - Height;
            mozgat(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
