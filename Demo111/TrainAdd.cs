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
    public partial class TrainAdd : Form
    {
        public TrainAdd()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private TrainNum train;
        private List<string> getTrainCode()
        {
            List<string> allTrainCode = new List<string>();
            string sql = "SELECT typeCode FROM TrainType";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                string trainCode = dt.DefaultView.Table.Rows[i][0].ToString();
                allTrainCode.Add(trainCode);
            }
            return allTrainCode;
        }
        private int addTrain(TrainNum train)
        {
            string sql = "INSERT INTO dbo.TrainNum(TrainType,trainCode,startSite,endSite,startTime,endTime,spendTime,startDate,swz_num,yd_num,ed_num,yz_num,yw_num,wz_num,rz_num,gr_num,rw_num,dw_num,qt_num,weekdays)VALUES('"+train.TrainType+"', '"+train.trainCode+"', '"+train.startSite+"', '"+train.endSite+"', '"+train.startTime+"', '"+train.endTime+"', '"+train.spendTime+"',' "+train.startDate+"', "+train.swz_num+", "+train.yd_num+", "+train.ed_num+", "+train.yz_num+", "+train.yw_num+", "+train.wz_num+", "+train.rz_num+", "+train.gr_num+", "+train.rw_num+", "+train.dw_num+", "+train.qt_num+", '"+train.weekday+"')";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private int getTrain(TrainNum train)
        {
            string sql = " SELECT COUNT(*) FROM dbo.TrainNum WHERE trainCode='"+train.trainCode+"' AND startDate='"+train.startDate+"'";

            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }
        private void add_Click(object sender, EventArgs e)
        {
            TrainNum train=new TrainNum();
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
            if (getTrain(train)>0)
            {
                MessageBox.Show("车次已存在，请选择修改或添加其他", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (addTrain(train) > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void TrainAdd_Load(object sender, EventArgs e)
        {
            List<string> allTrainType = getTrainCode();
            for (int i = 0; i < allTrainType.Count; i++)
            {
                string trainType = allTrainType[i];
                this.trainType.Items.Add(trainType);
            }
            this.trainType.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.weekday.Text = this.dateTimePicker1.Value.DayOfWeek.ToString();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
