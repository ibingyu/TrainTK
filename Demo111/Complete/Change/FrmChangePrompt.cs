using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo111.Complete;

namespace Demo111
{
    public partial class FrmChangePrompt : Form
    {
        public FrmChangePrompt()
        {
            InitializeComponent();
        }
        public FrmChangePrompt(TrainNum trainNum, Purchase purchase, string userName,decimal margin)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.purchase = purchase;
            this.userName = userName;
            this.train = trainNum;
            this.margin = margin;
        }
        private Purchase purchase;

        private string userName;
        private decimal margin;
        private TrainNum train;
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrompt_Load(object sender, EventArgs e)
        {
            timer1.Interval = 4000;
            timer1.Enabled = true;
            timer1.Tick+=new EventHandler(timer1_Tick);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            FrmChangeOrderConf orderConf = new FrmChangeOrderConf(train, purchase, userName, margin);
            orderConf.Show();
        }
    }
}
