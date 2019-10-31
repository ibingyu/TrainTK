using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo111
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = " ";
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Focus();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.FlatStyle=FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor=Color.Coral;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.FlatStyle=FlatStyle.Standard;
        }
    }
}
