using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.UC;
using TrainTK;
using TrainTK;

namespace Demo111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public static string siteCk;

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmSelectSite frmSelectSite=new FrmSelectSite();
            frmSelectSite.ShowDialog();
            this.siteChecked.Text = siteCk;
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmChangePass changePass=new FrmChangePass();
            changePass.ShowDialog();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            TicketQuery ticketQuery=new TicketQuery("hgf");
            this.Hide();
            ticketQuery.ShowDialog();
            this.Show();
        }
        private int getOrder()
        {
            string sql = "SELECT count(*) FROM TicketOrder WHERE trainCode='271' AND userName='hgf' AND startDate='2019-10-26'";

            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }



        
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse("2012-12-22");
  
            MessageBox.Show(date.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo));

            //SiteManage site=new SiteManage();
            //site.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FrmFrequentContacts frequentContacts=new FrmFrequentContacts("hgf");
            frequentContacts.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPurchase purchase=new FrmPurchase();
            purchase.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTimeFormatInfo dtFormatInfo=new System.Globalization.DateTimeFormatInfo();
            dtFormatInfo.ShortDatePattern = "yyyy-MM-dd";
            DateTime date = DateTime.Parse("2019-10-26",System.Globalization.DateTimeFormatInfo.InvariantInfo);
            MessageBox.Show(date.ToString(), "", MessageBoxButtons.OK);
        }
        private int random(int start,int end)
        {
            Random random = new Random();
            int seatNum = random.Next(start, end);
            return seatNum;
        }
    }
}
