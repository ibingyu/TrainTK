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
    public partial class DateSelect : Form
    {
        public DateSelect()
        {
            InitializeComponent();
        }

        private void DateSelect_Load(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            GetCheckedText();
        }

        public void GetCheckedText()
        {
            
            string ck2 = this.checkBox2.Text;
            if (checkBox2.Checked)
            {
                CheckedText.Text = ck2;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string ck1 = this.checkBox1.Text;
            if (checkBox1.Checked)
            {
                CheckedText.Text = ck1;
            }
        }
    }
}
