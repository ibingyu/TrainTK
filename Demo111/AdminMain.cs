using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo111;
using HZH_Controls.Forms;

namespace TrainTK
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private void SiteManage_Click(object sender, EventArgs e)
        {
            SiteManage siteManage=new SiteManage();
            siteManage.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("确认是否退出！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.OK)
            {
                this.Close();
            }
           
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSiteManage_Click(object sender, EventArgs e)
        {
            SiteManage siteManage = new SiteManage();
            siteManage.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认是否退出！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            SeatAdd add=new SeatAdd();
            this.Hide();
            DialogResult dr=add.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnTrainNum_Click(object sender, EventArgs e)
        {
            TrainNumManage train = new TrainNumManage();
            this.Hide();
            DialogResult dr = train.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void priceManage_Click(object sender, EventArgs e)
        {
            TicketPrice price = new TicketPrice();
            this.Hide();
            DialogResult dr = price.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
    
}
