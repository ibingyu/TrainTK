using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTK;

namespace Demo111
{
    public partial class TicketQuery : Form
    {
        public TicketQuery(string userName)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.userName = userName;
        }
        //出发站点名称
        public static string depSite;
        //到达站点名称
        public static string destSite;

        private string userName="hgf";

        private void StudentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentCheck.Checked)
            {
                AdultCheck.Checked = false;
            }
        }

        private void AdultCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AdultCheck.Checked)
            {
                StudentCheck.Checked = false;
            }
        }

       



        private void TicketQuery_Load(object sender, EventArgs e)
        {

        }
        private void GetDepSite_Click(object sender, EventArgs e)
        {
            FrmSelectSite selectSite=new FrmSelectSite(GetDepSite.Name);
            selectSite.ShowDialog();
            this.PlaceOfDeparture.Text = depSite;
        }
        private void GetDestSite_Click(object sender, EventArgs e)
        {
            FrmSelectSite selectSite=new FrmSelectSite(GetDestSite.Name);
            selectSite.ShowDialog();
            this.PlaceOfDestination.Text = destSite;
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            FrmAllTrainNum allTrain=new FrmAllTrainNum(userName,this.PlaceOfDeparture.Text,this.PlaceOfDestination.Text,this.dateTimePicker1.Text);
            allTrain.ShowDialog();
        }
    }
}
