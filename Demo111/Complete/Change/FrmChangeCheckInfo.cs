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
    public partial class FrmChangeCheckInfo : Form
    {
        public FrmChangeCheckInfo()
        {
            InitializeComponent();
        }
        public FrmChangeCheckInfo(TrainNum trainNum,Purchase purchase,string userName,Order order)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.purchase = purchase;
            this.userName = userName;
            this.train = trainNum;
            this.order = order;
        }

        private Purchase purchase;
        private Order order;
        private string userName;
        private decimal margin;
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

        

        private int changeOrder(TrainNum train, Purchase purchase, string userName)
        {
            string steatType = purchase.SeatType.Split('（')[0];
            decimal price = decimal.Parse(purchase.SeatType.Substring(3, 4));
            string sql = "UPDATE dbo.TicketOrder SET TrainType='" + train.TrainType + "',trainCode='" + train.trainCode + "',startSite='" + train.startSite + "',endSite='" + train.endSite + "',startTime='" + train.startTime + "',endTime='" + train.endTime + "',startDate='" + train.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "',personName='" + purchase.PersonName + "',IDType='" + purchase.IDType + "',IDNum='" + purchase.IDNum + "',carriageNum='" + random(2, 8) + "',seatNum='" + random(1, 50) + "',seatType='" + steatType + "',passengerType='" + purchase.TicketType + "',ticketPrice=" + price + ",userName='" + userName + "',phoneNum='" + purchase.PhoneNum + "',orderState=0,orderDate='" + DateTime.Today.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "' where userName='" + userName + "'AND personName='" + purchase.PersonName + "'AND startDate = '" + train.startDate + "'AND trainCode = '" + train.trainCode + "'";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private int submitOrder(TrainNum train,Purchase purchase,string userName,string orderNum)
        {
            
            string steatType = purchase.SeatType.Split('（')[0];
            decimal price = decimal.Parse(purchase.SeatType.Substring(3, 4));
            string sql = "INSERT INTO TicketOrder(TrainType,trainCode,startSite,endSite,startTime,endTime,startDate,personName,IDType,IDNum,carriageNum,seatNum,seatType,passengerType,ticketPrice,userName,phoneNum,orderState,orderDate)VALUES('" + train.TrainType + "','" + train.trainCode + "','" + train.startSite + "','" + train.endSite + "','" + train.startTime + "','" + train.endTime + "','" + train.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "','" + purchase.PersonName + "','" + purchase.IDType + "','" + purchase.IDNum + "','" + random(2, 8) + "','" + random(1, 50) + "','" + steatType + "','" + purchase.TicketType + "'," + price + ",'" + userName + "','" + purchase.PhoneNum + "',0,'" + DateTime.Today.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "')";
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
        private int updateOrderState(Purchase purchase,TrainNum train)
        {
            string sql = "UPDATE TicketOrder SET orderState = 2 WHERE userName='" + userName + "'AND personName='" + purchase.PersonName + "'AND startDate = '" + train.startDate + "'AND trainCode = " + train.trainCode + "'";
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private int updateNum(string trainCode,string startDate,string seatType,int num)
        {
            string sql = "UPDATE dbo.TrainNum SET "+seatType+" = "+num+" WHERE trainCode='"+trainCode+"' AND startDate='"+startDate+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string seatType = seatTypeStr(purchase.SeatType);
            int n = int.Parse(train.GetType().GetField(seatType).GetValue(train).ToString());
            train.GetType().GetField(seatType).SetValue(train,n-1);
            int num = int.Parse(train.GetType().GetField(seatType).GetValue(train).ToString());
            if (getOrderSum(train,userName,purchase.PersonName)<1 && changeOrder(train,purchase,userName)>0)
            {

                decimal price = decimal.Parse(purchase.SeatType.Substring(3, 4));
                if (price>order.ticketPrice)
                {
                    if (updateNum(train.trainCode,train.startDate.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo),seatType,num)<1)
                    {
                        return;
                    }
                    margin = price - order.ticketPrice;
                    FrmChangePrompt prompt = new FrmChangePrompt(train, purchase, userName,margin);
                    this.Hide();
                    prompt.Show();
                }
                else
                {
                    if (updateOrderState(purchase, train) > 0)
                    {
                        if (MessageBox.Show("改签成功，售后将差额退还", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("改签失败，请再次尝试", "提示", MessageBoxButtons.OK)==DialogResult.OK)
                        {
                            this.Close();
                        }
                        
                    }
                }
                
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
