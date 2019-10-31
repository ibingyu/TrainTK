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
    public partial class FrmChangeOrderConf : Form
    {
        public FrmChangeOrderConf()
        {
            InitializeComponent();
        }
        public FrmChangeOrderConf(TrainNum trainNum, Purchase purchase, string userName,decimal margin)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.purchase = purchase;
            this.userName = userName;
            this.train = trainNum;
            this.margin = margin;
        }

        private Purchase purchase;
        private decimal margin;
        private string userName;

        private TrainNum train;
        private Order order;
        private void FrmOrderConf_Load(object sender, EventArgs e)
        {
            order = getOrder(userName, train.trainCode, train.startDate,purchase.PersonName);
            
            #region 数据加载
            string price = purchase.SeatType.Split('（')[1];
            this.dgvPurchaseInfo.Rows[0].Cells[0].Value = 1.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[1].Value = purchase.PersonName.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[2].Value = purchase.IDType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[3].Value = purchase.IDNum.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[4].Value = purchase.TicketType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[5].Value = purchase.SeatType.ToString();
            this.dgvPurchaseInfo.Rows[0].Cells[6].Value = order.carriageNum;
            this.dgvPurchaseInfo.Rows[0].Cells[7].Value = order.seatNum + "号";
            this.dgvPurchaseInfo.Rows[0].Cells[8].Value = order.ticketPrice.ToString() + "元";

            this.date.Text = train.startDate.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo);
            this.week.Text = train.weekday;
            this.trainNum.Text = train.TrainType + train.trainCode;
            this.startSite.Text = train.startSite;
            this.endSite.Text = train.endSite;
            this.startTime.Text = train.startTime;
            this.endTime.Text = train.endTime;
            this.ticketPrice.Text = price; 
            #endregion

        }

        private int getOrderID(string userName,string trainCode,string startDate,string personName)
        {
            string sql = " SELECT orderID FROM TicketOrder WHERE trainCode='"+trainCode+"' AND userName='"+userName+"' AND startDate='"+startDate+ "'AND personName='" + personName + "'";

            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }

        private Order getOrder(string userName, string trainCode, DateTime startDate,string personName)
        {
            Order order=new Order();
            string sql = " SELECT * FROM TicketOrder WHERE trainCode='" + trainCode + "' AND userName='" + userName + "' AND startDate='" + startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "'AND personName='" + personName + "'";
            DataTable dt=SqlHelper.ExecuteDataTable(sql);
            #region 获取order
            order.orderID = int.Parse(dt.DefaultView.Table.Rows[0][0].ToString());
            order.TrainType = dt.DefaultView.Table.Rows[0][1].ToString();
            order.trainCode = dt.DefaultView.Table.Rows[0][2].ToString();
            order.startSite = dt.DefaultView.Table.Rows[0][3].ToString();
            order.endSite = dt.DefaultView.Table.Rows[0][4].ToString();
            order.startTime = dt.DefaultView.Table.Rows[0][5].ToString();
            order.endTime = dt.DefaultView.Table.Rows[0][6].ToString();
            order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[0][7].ToString());
            order.PersonName = dt.DefaultView.Table.Rows[0][8].ToString();
            order.IDType = dt.DefaultView.Table.Rows[0][9].ToString();
            order.IDNum = dt.DefaultView.Table.Rows[0][10].ToString();
            order.carriageNum = dt.DefaultView.Table.Rows[0][11].ToString();
            order.seatNum = dt.DefaultView.Table.Rows[0][12].ToString();
            order.seatType = dt.DefaultView.Table.Rows[0][13].ToString();
            order.passengerType = dt.DefaultView.Table.Rows[0][14].ToString();
            order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[0][15].ToString());
            order.userName = dt.DefaultView.Table.Rows[0][16].ToString();
            order.PhoneNum = dt.DefaultView.Table.Rows[0][17].ToString();
            order.orderState = int.Parse(dt.DefaultView.Table.Rows[0][18].ToString());
            order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[0][19].ToString()); 
            #endregion

            return order;
        }
        private int deleteOrder(int OrderID)
        {
            string sql = "UPDATE TicketOrder SET orderState = 4 where orderID="+OrderID;
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OrderID = getOrderID(userName, train.trainCode, train.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo), purchase.PersonName);
            if (deleteOrder(OrderID)>0)
            {
                MessageBox.Show("取消成功", "提示", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("取消失败请再次尝试", "提示", MessageBoxButtons.OK);
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            ChangeOrderPay order=new ChangeOrderPay(this.order, margin);
            order.ShowDialog();
            this.Close();
        }
    }
}
