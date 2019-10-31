using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo111.Complete;
using TrainTK;

namespace Demo111
{
    public partial class FrmCheckInfo : Form
    {
        public FrmCheckInfo()
        {
            InitializeComponent();
        }
        public FrmCheckInfo(TrainNum trainNum,Purchase purchase,string userName)
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
        public static object _lock = new object();
        private void FrmCheckInfo_Load(object sender, EventArgs e)
        {

            this.dgvPurchaseInfo.Rows[0].Cells[0].Value = purchase.ID.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[1].Value = purchase.SeatType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[2].Value = purchase.TicketType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[3].Value = purchase.PersonName.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[4].Value = purchase.IDType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[5].Value = purchase.IDNum.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[6].Value = purchase.PhoneNum.ToString();

            this.date.Text = train.startDate.ToShortDateString();
            this.week.Text = train.weekday;
            this.trainNum.Text = train.TrainType + train.trainCode;
            this.startSite.Text = train.startSite;
            this.endSite.Text = train.endSite;
            this.startTime.Text = train.startTime;
            this.endTime.Text = train.endTime;
            this.yzNum.Text = train.yz_num.ToString();
            this.wzNum.Text = train.wz_num.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //分配车厢和座位
        private List<string> allotSeat()
        {
            List<string> seatInfo=new List<string>();

            return seatInfo;
        } 

        private int submitOrder(TrainNum train,Purchase purchase,string userName,string orderNum)
        {
            string steatType=purchase.SeatType.Split('（')[0];
            decimal price = decimal.Parse(purchase.SeatType.Substring(3,4));
            string sql= "INSERT INTO TicketOrder(TrainType,trainCode,startSite,endSite,startTime,endTime,startDate,personName,IDType,IDNum,carriageNum,seatNum,seatType,passengerType,ticketPrice,userName,phoneNum,orderState,orderDate)VALUES('" + train.TrainType+"','"+train.trainCode+"','"+train.startSite+"','"+train.endSite+"','"+train.startTime+"','"+train.endTime+"','"+train.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "','"+purchase.PersonName+"','"+purchase.IDType+"','"+purchase.IDNum+"','"+random(2,8)+"','"+random(1,50)+"','"+steatType+"','"+purchase.TicketType+"',"+price+",'"+userName+"','"+purchase.PhoneNum+"',0,'"+DateTime.Today.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo)+"')";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        public string GetOrderNum()
        {
            lock (_lock)
            {
                Random ran = new Random();
                return DateTime.Now.ToString("yyyyMMddHHmmssfff")+(char)('A'+ran.Next(26)) + ran.Next(100, 999);
            }
        }

        private int getOrderSum(TrainNum train, string userName,string personName)
        {
            string sql = " SELECT count(*) FROM TicketOrder WHERE trainCode='" + train.trainCode + "' AND userName='" + userName + "' AND startDate='" + train.startDate.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo) + "'AND personName='"+personName+"'";

            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }
        private int updateNum(string trainCode, string startDate, string seatType, int num)
        {
            string sql = "UPDATE dbo.TrainNum SET " + seatType + " = " + num + " WHERE trainCode='" + trainCode + "' AND startDate='" + startDate + "'";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private string seatTypeStr(string seatType)
        {
            switch (seatType)
            {
                case "硬座":
                    return "yz_num";
                case "无座":
                    return "wz_num";
                case "硬卧":
                    return "yw_num";
                case "软卧":
                    return "rw_num";
                case "一等座":
                    return "yd_num";
                case "二等座":
                    return "ed_num";
                case "商务座":
                    return "swz_num";
                case "软座":
                    return "rz_num";
                case "高软":
                    return "gr_num";
                case "动卧":
                    return "dw_num";
            }
            return "yz_num";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string seatType = seatTypeStr(purchase.SeatType);
            int n = int.Parse(train.GetType().GetField(seatType).GetValue(train).ToString());
            train.GetType().GetField(seatType).SetValue(train, n - 1);
            int num = int.Parse(train.GetType().GetField(seatType).GetValue(train).ToString());
            if (getOrderSum(train,userName,purchase.PersonName)<1 && submitOrder(train,purchase,userName,GetOrderNum())>0)
            {
                if (updateNum(train.trainCode, train.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo), seatType, num) < 1)
                {
                    return;
                }
                FrmPrompt prompt=new FrmPrompt(train,purchase,userName);
                this.Hide();
                prompt.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("订单已存在，请去订单中心查看！", "提示", MessageBoxButtons.OK);
            }
        }

        private int random(int start, int end)
        {
            Random random = new Random();
            int seatNum = random.Next(start, end);
            return seatNum;
        }
    }
}
