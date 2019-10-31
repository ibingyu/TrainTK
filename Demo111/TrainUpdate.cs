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
    public partial class TrainUpdate : Form
    {
        public TrainUpdate()
        {
            InitializeComponent();
        }
        public TrainUpdate(TrainNum train)
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
            this.train = train;
        }
        private List<string> getTrainCode()
        {
            List<string> allTrainCode = new List<string>();
            string sql = "SELECT typeCode FROM TrainType";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                string trainCode = dt.DefaultView.Table.Rows[0][0].ToString();
                allTrainCode.Add(trainCode);
            }
            return allTrainCode;
        }
        private TrainNum train;

        private int updateTrain(TrainNum train)
        {
            string sql = "UPDATE dbo.TrainNum SET TrainType='"+train.TrainType+"',trainCode='"+train.trainCode+"',startSite='"+train.startSite+"',endSite='"+train.endSite+"',startTime='"+train.startTime+"',endTime='"+train.endTime+"',spendTime='"+train.spendTime+"',startDate='"+train.startDate+"', swz_num ="+train.swz_num+", yd_num ="+train.yd_num+", yw_num ="+train.yw_num+", wz_num ="+train.wz_num+", rz_num ="+train.rz_num+", gr_num ="+train.gr_num+", rw_num ="+train.rw_num+", dw_num ="+train.dw_num+", qt_num ="+train.qt_num+", weekdays = '"+train.weekday+"' where trainCode='"+train.trainCode+"'";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void TrainUpdate_Load(object sender, EventArgs e)
        {
            List<string> allTrainType = getTrainCode();
            for (int i = 0; i < allTrainType.Count; i++)
            {
                string trainType = allTrainType[i];
                this.trainType.Items.Add(trainType);
            }
            this.trainType.SelectedIndex = 0;
            this.trainType.Text = train.TrainType;
            this.trainCode.Text = train.trainCode;
            this.startSite.Text = train.startSite;
            this.endSite.Text = train.endSite;
            this.startTime.Text = train.startTime;
            this.endTime.Text = train.endTime;
            this.spendTime.Text = train.spendTime;
            this.swz.Text = train.swz_num.ToString();
            this.ydz.Text = train.yd_num.ToString();
            this.edz.Text = train.ed_num.ToString();
            this.yz.Text = train.yz_num.ToString();
            this.rz.Text = train.rz_num.ToString();
            this.gjrw.Text = train.gr_num.ToString();
            this.rwydw.Text = train.rw_num.ToString();
            this.ywedw.Text = train.yw_num.ToString();
            this.wz.Text = train.wz_num.ToString();
            this.dw.Text = train.dw_num.ToString();
            this.weekday.Text = train.weekday;
        }

        private void update_Click(object sender, EventArgs e)
        {
            TrainNum train = new TrainNum();
            train.TrainType = this.trainType.Text;
            train.trainCode = this.trainCode.Text;
            train.startSite = this.startSite.Text;
            train.endSite = this.endSite.Text;
            train.startTime = this.startTime.Text;
            train.endTime = this.endTime.Text;
            train.spendTime = this.spendTime.Text;
            train.swz_num = int.Parse(this.swz.Text);
            train.yd_num = int.Parse(this.ydz.Text);
            train.ed_num = int.Parse(this.edz.Text);
            train.gr_num = int.Parse(this.gjrw.Text);
            train.rw_num = int.Parse(this.rwydw.Text);
            train.dw_num = int.Parse(this.dw.Text);
            train.yz_num = int.Parse(this.yz.Text);
            train.rz_num = int.Parse(this.rz.Text);
            train.wz_num = int.Parse(this.wz.Text);
            train.yw_num = int.Parse(this.ywedw.Text);
            train.startDate = DateTime.Parse(this.dateTimePicker1.Text);
            train.weekday = this.weekday.Text;
            train.qt_num = 0;
            if (updateTrain(train) > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.weekday.Text = this.dateTimePicker1.Value.DayOfWeek.ToString();
        }
    }
}
