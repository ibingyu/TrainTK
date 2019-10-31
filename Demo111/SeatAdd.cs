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
    public partial class SeatAdd : Form
    {
        public SeatAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
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

        private List<TrainNum> getAllTrainNum()
        {
            List<TrainNum> trains = new List<TrainNum>();
            string sql = "SELECT * FROM TrainNum";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                TrainNum train = new TrainNum();
                train.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                train.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                train.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                train.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                train.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                train.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                train.spendTime = dt.DefaultView.Table.Rows[i][7].ToString();
                train.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][8].ToString());
                train.swz_num = int.Parse(dt.DefaultView.Table.Rows[i][9].ToString());
                train.yd_num = int.Parse(dt.DefaultView.Table.Rows[i][10].ToString());
                train.ed_num = int.Parse(dt.DefaultView.Table.Rows[i][11].ToString());
                train.yz_num = int.Parse(dt.DefaultView.Table.Rows[i][12].ToString());
                train.yw_num = int.Parse(dt.DefaultView.Table.Rows[i][13].ToString());
                train.wz_num = int.Parse(dt.DefaultView.Table.Rows[i][14].ToString());
                train.rz_num = int.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                train.gr_num = int.Parse(dt.DefaultView.Table.Rows[i][16].ToString());
                train.rw_num = int.Parse(dt.DefaultView.Table.Rows[i][17].ToString());
                train.dw_num = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                train.qt_num = int.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                train.weekday = dt.DefaultView.Table.Rows[i][20].ToString();

                train.startToendSite = train.startSite + " - " + train.endSite;
                train.startToendTime = train.startTime + " - " + train.endTime;
                trains.Add(train);
            }

            return trains;
        }

        private TrainNum getTrainNum(string date, string trainCode
            )
        {
            string sql = "SELECT * FROM TrainNum WHERE trainCode='" + trainCode + "' AND startDate='" + date + "'";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);

            #region 获取车次信息
            TrainNum train = new TrainNum();
            train.TrainType = dt.DefaultView.Table.Rows[0][1].ToString();
            train.trainCode = dt.DefaultView.Table.Rows[0][2].ToString();
            train.startSite = dt.DefaultView.Table.Rows[0][3].ToString();
            train.endSite = dt.DefaultView.Table.Rows[0][4].ToString();
            train.startTime = dt.DefaultView.Table.Rows[0][5].ToString();
            train.endTime = dt.DefaultView.Table.Rows[0][6].ToString();
            train.spendTime = dt.DefaultView.Table.Rows[0][7].ToString();
            train.startDate = DateTime.Parse(date);
            train.swz_num = int.Parse(dt.DefaultView.Table.Rows[0][9].ToString());
            train.yd_num = int.Parse(dt.DefaultView.Table.Rows[0][10].ToString());
            train.ed_num = int.Parse(dt.DefaultView.Table.Rows[0][11].ToString());
            train.yz_num = int.Parse(dt.DefaultView.Table.Rows[0][12].ToString());
            train.yw_num = int.Parse(dt.DefaultView.Table.Rows[0][13].ToString());
            train.wz_num = int.Parse(dt.DefaultView.Table.Rows[0][14].ToString());
            train.rz_num = int.Parse(dt.DefaultView.Table.Rows[0][15].ToString());
            train.gr_num = int.Parse(dt.DefaultView.Table.Rows[0][16].ToString());
            train.rw_num = int.Parse(dt.DefaultView.Table.Rows[0][17].ToString());
            train.dw_num = int.Parse(dt.DefaultView.Table.Rows[0][18].ToString());
            train.qt_num = int.Parse(dt.DefaultView.Table.Rows[0][19].ToString());
            train.weekday = dt.DefaultView.Table.Rows[0][20].ToString();

            train.startToendSite = train.startSite + " - " + train.endSite;
            train.startToendTime = train.startTime + " - " + train.endTime; 
            #endregion

            return train;
        }
        private void SeatAdd_Load(object sender, EventArgs e)
        {
            List<TrainNum> trainNums=getAllTrainNum();
            for (int i = 0; i < trainNums.Count; i++)
            {
                string trainCode = trainNums[i].trainCode;
                this.trainCode.Items.Add(trainCode);
            }


            List<string> allTrainType = getTrainCode();
            for (int i = 0; i < allTrainType.Count; i++)
            {
                string trainType = allTrainType[i];
                this.trainType.Items.Add(trainType);
            }
            for (int i = 1; i < 9; i++)
            {
                this.carriageNum.Items.Add(i);
            }
            this.carriageNum.SelectedIndex = 0;
            this.trainType.SelectedIndex = 0;
            this.trainCode.SelectedIndex = 0;
        }

        private void get_Click(object sender, EventArgs e)
        {
            TrainNum trainNum = getTrainNum(this.dateTimePicker1.Text, this.trainCode.Text);
            this.swz.Text = trainNum.swz_num.ToString();
            this.ydz.Text = trainNum.yd_num.ToString();
            this.edz.Text = trainNum.ed_num.ToString();
            this.gjrw.Text = trainNum.gr_num.ToString();
            this.rwydw.Text = trainNum.rw_num.ToString();
            this.dw.Text = trainNum.dw_num.ToString();
            this.rr.Text = trainNum.rz_num.ToString();
            this.aa.Text = trainNum.yz_num.ToString();
            this.wz.Text = trainNum.wz_num.ToString();
            this.ywedw.Text = trainNum.yw_num.ToString();

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int addCarriage(Carriage carriage)
        {
            string sql = "INSERT INTO CarriageType(trainType,trainCode,carriageNum,carriageType,seatCount) VALUES ('" + carriage.trainType+"','"+carriage.trainCode+"',"+carriage.carriageNum+",'"+carriage.carriageType+"',"+carriage.seatCount+")";
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private int addSeat(TrainSeat seat,int seatNum)
        {
            string sql = "INSERT INTO dbo.TrainSeat(trainCode,carriageNum,carriageType,carriageSeatNum,seatNum,seatType,startSite,endSite,startDate,trainType,seatState)VALUES('"+seat.trainCode+"', '"+seat.carriageNum+"', '"+seat.carriageType+"',"+seat.carriageSeatNum+",'"+seatNum+"','"+seat.seatType+"','"+seat.startSite+"','"+seat.endSite+"','"+seat.startDate+"','"+seat.trainType+"', 1)";

            return SqlHelper.ExecuteNonQuery(sql);
        }

        private int deleteSeat(TrainSeat seat)
        {
            string sql = "DELETE dbo.TrainSeat WHERE trainCode='"+seat.trainCode+"' AND startDate='"+seat.startDate+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Carriage carriage=new Carriage();
            carriage.trainType = this.trainType.Text.ToCharArray()[0];
            carriage.trainCode = this.trainCode.Text;
            carriage.carriageNum = int.Parse(this.carriageNum.Text);
            carriage.carriageType = this.carriageType.Text;
            carriage.seatCount = int.Parse(this.seatNum.Text);
            carriage.startDate = DateTime.Parse(this.dateTimePicker1.Text);
            TrainNum trainNum = getTrainNum(this.dateTimePicker1.Text, this.trainCode.Text);
            TrainSeat seat=new TrainSeat();
            seat.seatType = this.seatType.Text;
            seat.trainCode = this.trainCode.Text;
            seat.carriageNum = this.carriageNum.Text;
            seat.carriageType = this.carriageType.Text;
            seat.carriageSeatNum = int.Parse(this.seatNum.Text);
            seat.seatType = this.seatType.Text;
            seat.startSite = trainNum.startSite;
            seat.endSite = trainNum.endSite;
            seat.startDate = this.dateTimePicker1.Text;

            if (addCarriage(carriage) > 0)
            {
                for (int i = 1; i <= int.Parse(this.seatNum.Text); i++)
                {
                    if (addSeat(seat,i)>0)
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("添加座位失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        deleteSeat(seat);
                    }
                } 
            }
            else
            {
                MessageBox.Show("添加失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
