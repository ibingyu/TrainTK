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
    public partial class FrmPrompt : Form
    {
        public FrmPrompt()
        {
            InitializeComponent();
        }
        public FrmPrompt(TrainNum trainNum, Purchase purchase, string userName)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.purchase = purchase;
            this.userName = userName;
            this.train = trainNum;
        }
        private Purchase purchase;

        private string userName;

        private TrainNum train;

        private void FrmPrompt_Load(object sender, EventArgs e)
        {
            timer1.Interval = 4000;
            timer1.Enabled = true;
            timer1.Tick+=new EventHandler(timer1_Tick);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            FrmOrderConf orderConf = new FrmOrderConf(train, purchase, userName);
            orderConf.Show();
        }
    }
}
