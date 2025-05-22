using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meretezes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void listBox1_changeSize(object sender, PaintEventArgs e)
        {
            if (tableLayoutPanel1.Size.Width < 200)
            {
                this.tableLayoutPanel1.SetColumnSpan(listBox1, 4);
            }

            //this
        }
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_changeSize(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Size.Width < 200)
            {
                this.tableLayoutPanel1.SetColumnSpan(listBox1, 3);
            }
            
            else
            {
                this.tableLayoutPanel1.SetColumnSpan(listBox1, 2);
            }

        }
    }
}
