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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userName = userName;
        }
        public UserMain(string userName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userName = userName;
        }
        private string userName;

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmChangePass changePass=new FrmChangePass(userName);
            changePass.ShowDialog();
        }

        private void btnTicketQuery_Click(object sender, EventArgs e)
        {
            TicketQuery query=new TicketQuery(userName);
            this.Hide();
            DialogResult dialog = query.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void UserMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            FrmFrequentContacts frequentContacts=new FrmFrequentContacts(userName);
            this.Hide();
            DialogResult dialog = frequentContacts.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            FrmPersonDetail personDetail=new FrmPersonDetail(userName);
            this.Hide();
            DialogResult dialog = personDetail.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrderCenter center=new FrmOrderCenter(userName);
            this.Hide();
            DialogResult dialog = center.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
