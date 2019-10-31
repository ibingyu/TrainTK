using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTK;

namespace Demo111
{
    public partial class FrmOrderCenter : Form
    {
        public FrmOrderCenter()
        {
            InitializeComponent();
        }

        public FrmOrderCenter(string userName)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.userName = userName;
        }

        private string userName;

        private void NotTravel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
           
            
            if (this.dgvUnfinish.CurrentRow.Index < 0)
            {
                MessageBox.Show("请选择一个订单！","提示",MessageBoxButtons.OK);
            }
            int index = this.dgvUnfinish.CurrentRow.Index;        
            List<Order> orders = getNotPayOrder(userName);

            Order order = orders[index];

            OrderPay pay=new OrderPay(order);
            pay.ShowDialog();
        }

        private string text = "请输入姓名";

        //获取两个月以内的历史订单
        private List<Order> getHistoryOrder(string userName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE (orderdate > (SELECT CONVERT(VARCHAR(10),DATEADD(DAY ,-60,GETDATE()),120))) AND userName='"+userName+"' AND orderState = 4";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //获取未支付订单
        private List<Order> getNotPayOrder(string userName)
        {
            List<Order> orders=new List<Order>();
            string sql= " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND orderState= 0";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order=new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        //获取已支付的订单
        private List<Order> getPaidOrder(string userName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND (orderState= 1 or orderState= 2 or orderState= 3)";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        //获取已支付并可以改签的订单
        private List<Order> getCanChangeOrder(string userName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND orderState= 1";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        //获取已支付并可以退票的订单
        private List<Order> getCanRefundOrder(string userName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND (orderState= 1 or orderState=2)";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        //根据日期查找订单
        private List<Order> queryByDate(string startDate, string endDate,string userName,int orderState)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND orderdate > '"+startDate+"' AND orderdate < '"+startDate+"' AND orderState="+orderState;
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期查找订单
        private List<Order> queryByDate(string startDate, string endDate, string userName, int orderState1,int orderState2)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND (orderdate > '" + startDate + "' AND orderdate < '" + endDate + "') AND (orderState=" + orderState1+ " or orderState="+orderState2+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        private List<Order> queryByDate(string startDate, string endDate, string userName, int orderState1, int orderState2, int orderState3)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND (orderdate > '" + startDate + "' AND orderdate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2 + " or orderState=" + orderState3 + ")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        private List<Order> queryByDate(string startDate, string endDate, string userName, int orderState1, int orderState2,int orderState3,string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND personName='" + personName + "' AND (orderdate > '" + startDate + "' AND orderdate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2+ " or orderState="+orderState3+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期和姓名查找订单
        private List<Order> queryByDate(string startDate, string endDate, string userName, int orderState,string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "'AND personName='"+personName+"' AND orderdate > '" + startDate + "' AND orderdate < '" + endDate + "' AND orderState=" + orderState;
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期查找订单
        private List<Order> queryByDate(string startDate, string endDate, string userName, int orderState1, int orderState2,string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "'AND personName='"+personName+"'AND (orderdate > '" + startDate + "' AND orderdate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        //根据日期查找订单
        private List<Order> queryByStartDate(string startDate, string endDate, string userName, int orderState)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND startDate > '" + startDate + "' AND startDate < '" + endDate + "' AND orderState=" + orderState;
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期查找订单
        private List<Order> queryByStartDate(string startDate, string endDate, string userName, int orderState1, int orderState2)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND (startDate > '" + startDate + "' AND startDate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        private List<Order> queryByStartDate(string startDate, string endDate, string userName, int orderState1, int orderState2, int orderState3,string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "' AND personName='" + personName
                + "' AND (startDate > '" + startDate + "' AND startDate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2 + " or orderState=" + orderState3+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期和姓名查找订单
        private List<Order> queryByStartDate(string startDate, string endDate, string userName, int orderState, string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "'AND personName='" + personName + "' AND startDate > '" + startDate + "' AND startDate < '" + endDate + "' AND orderState=" + orderState;
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }
        //根据日期查找订单
        private List<Order> queryByStartDate(string startDate, string endDate, string userName, int orderState1, int orderState2, string personName)
        {
            List<Order> orders = new List<Order>();
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "'AND personName='" + personName + "'AND (startDate > '" + startDate + "' AND startDate < '" + endDate + "') AND (orderState=" + orderState1 + " or orderState=" + orderState2+")";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Order order = new Order();
                #region 获取order
                order.orderID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                order.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                order.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                order.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                order.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                order.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                order.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                order.startDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                order.PersonName = dt.DefaultView.Table.Rows[i][8].ToString();
                order.IDType = dt.DefaultView.Table.Rows[i][9].ToString();
                order.IDNum = dt.DefaultView.Table.Rows[i][10].ToString();
                order.carriageNum = dt.DefaultView.Table.Rows[i][11].ToString();
                order.seatNum = dt.DefaultView.Table.Rows[i][12].ToString();
                order.seatType = dt.DefaultView.Table.Rows[i][13].ToString();
                order.passengerType = dt.DefaultView.Table.Rows[i][14].ToString();
                order.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][15].ToString());
                order.userName = dt.DefaultView.Table.Rows[i][16].ToString();
                order.PhoneNum = dt.DefaultView.Table.Rows[i][17].ToString();
                order.orderState = int.Parse(dt.DefaultView.Table.Rows[i][18].ToString());
                order.OrderDate = DateTime.Parse(dt.DefaultView.Table.Rows[i][19].ToString());
                #endregion

                orders.Add(order);
            }

            return orders;
        }

        private int deleteOrder(string trainCode,string startDate,string userName,string personName)
        {
            string sql = "UPDATE TicketOrder SET orderState=3 WHERE trainCode='"+trainCode.Substring(1)+"' AND startDate='"+startDate+"' AND userName='"+userName+"'AND personName='"+personName+"'";


            return SqlHelper.ExecuteNonQuery(sql);
        }

        private Order getOrder(string trainCode, string personName,string startDate,string userName)
        {
            string sql = " SELECT * FROM TicketOrder WHERE userName='" + userName + "'AND personName='" + personName + "'AND startDate = '" + startDate + "'AND trainCode = '" + trainCode.Substring(1)+"'";
            DataTable dt=new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql).DefaultView.Table;
            Order order=new Order();
            order.TrainType = dt.Rows[0][1].ToString();
            order.trainCode = dt.Rows[0][2].ToString();
            order.startSite = dt.Rows[0][3].ToString();
            order.endSite = dt.Rows[0][4].ToString();
            order.startTime = dt.Rows[0][5].ToString();
            order.endTime = dt.Rows[0][6].ToString();
            order.startDate = DateTime.Parse(dt.Rows[0][7].ToString());
            order.PersonName = dt.Rows[0][8].ToString();
            order.IDType = dt.Rows[0][9].ToString();
            order.IDNum = dt.Rows[0][10].ToString();
            order.carriageNum = dt.Rows[0][11].ToString();
            order.seatNum = dt.Rows[0][12].ToString();
            order.seatType = dt.Rows[0][13].ToString();
            order.passengerType = dt.Rows[0][14].ToString();
            order.ticketPrice = decimal.Parse(dt.Rows[0][15].ToString());
            order.userName = dt.Rows[0][16].ToString();
            order.PhoneNum = dt.Rows[0][17].ToString();
            order.orderState = int.Parse(dt.Rows[0][18].ToString());
            order.OrderDate = DateTime.Parse(dt.Rows[0][19].ToString());

            return order;
        }

        private void dgvClear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
        //DataGridview初始化
        private void dgvLoad(List<Order> orders,DataGridView dataGridView)
        {

            for (int i = 0; i < orders.Count - 1; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < orders.Count; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = i + 1;
                dataGridView.Rows[i].Cells[1].Value = orders[i].TrainType + orders[i].trainCode;
                dataGridView.Rows[i].Cells[2].Value = orders[i].startSite;
                dataGridView.Rows[i].Cells[3].Value = orders[i].endSite;
                dataGridView.Rows[i].Cells[4].Value = orders[i].startTime;
                dataGridView.Rows[i].Cells[5].Value = orders[i].endTime;
                dataGridView.Rows[i].Cells[6].Value = orders[i].startDate.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo);
                dataGridView.Rows[i].Cells[7].Value = orders[i].PersonName;
                dataGridView.Rows[i].Cells[8].Value = orders[i].IDType;
                dataGridView.Rows[i].Cells[9].Value = orders[i].seatType;
                dataGridView.Rows[i].Cells[10].Value = orders[i].carriageNum+" 车"+orders[i].seatNum+" 号";
                dataGridView.Rows[i].Cells[11].Value = orders[i].passengerType;
                dataGridView.Rows[i].Cells[12].Value = orders[i].ticketPrice;
                switch(orders[i].orderState)
                {
                    case 0:
                        dataGridView.Rows[i].Cells[13].Value = "未支付";
                        break;
                    case 1:
                        dataGridView.Rows[i].Cells[13].Value = "已支付";
                        break;
                    case 2:
                        dataGridView.Rows[i].Cells[13].Value = "已改签";
                        break;
                    case 3:
                        dataGridView.Rows[i].Cells[13].Value = "已退票";
                        break;
                    case 4:
                        dataGridView.Rows[i].Cells[13].Value = "已完成";
                        break;
                }
                

            }
            dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[13].Value == "已退票")
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }
        }
        private void FrmOrderCenter_Load(object sender, EventArgs e)
        {
            #region 未支付订单信息初始化

            List<Order> orders1 = getNotPayOrder(userName);
            dgvLoad(orders1,this.dgvUnfinish);

            #endregion

            #region 未出行订单信息初始化
            this.dgvNotTravel.Columns.Add("ID", "序号");
            this.dgvNotTravel.Columns.Add("traincode", "车次");
            this.dgvNotTravel.Columns.Add("StartSite", "出发站");
            this.dgvNotTravel.Columns.Add("endSite", "到达站");
            
            this.dgvNotTravel.Columns.Add("StartTime", "出发时间");
            this.dgvNotTravel.Columns.Add("endTime", "到达时间");
            this.dgvNotTravel.Columns.Add("startDate", "出发日期");
            this.dgvNotTravel.Columns.Add("personName", "姓名");
            this.dgvNotTravel.Columns.Add("IDType", "证件类型");
            this.dgvNotTravel.Columns.Add("seatType", "席别");
            this.dgvNotTravel.Columns.Add("SeatNum", "席位号");
            this.dgvNotTravel.Columns.Add("TicketType", "票种");
            this.dgvNotTravel.Columns.Add("price", "票价");
            this.dgvNotTravel.Columns.Add("orderState", "订单状态");

            List<Order> orders2 = getPaidOrder(userName);
            dgvLoad(orders2,this.dgvNotTravel);
            
            #endregion

            #region 未出行可改签订单信息初始化
		    this.dgvChange.Columns.Add("ID", "序号");
            this.dgvChange.Columns.Add("traincode", "车次");
            this.dgvChange.Columns.Add("StartSite", "出发站");
            this.dgvChange.Columns.Add("endSite", "到达站");
            this.dgvChange.Columns.Add("StartTime", "出发时间");
            this.dgvChange.Columns.Add("endTime", "到达时间");
            this.dgvChange.Columns.Add("startDate", "出发日期");
            this.dgvChange.Columns.Add("personName", "姓名");
            this.dgvChange.Columns.Add("IDType", "证件类型");
            this.dgvChange.Columns.Add("seatType", "席别");
            this.dgvChange.Columns.Add("SeatNum", "席位号");
            this.dgvChange.Columns.Add("TicketType", "票种");
            this.dgvChange.Columns.Add("price", "票价");
            this.dgvChange.Columns.Add("orderState", "订单状态");
            List<Order> orders3 = getCanChangeOrder(userName);
            dgvLoad(orders3, this.dgvChange);

            #endregion


            #region 可退票订单信息初始化
            this.dgvRefund.Columns.Add("ID", "序号");
            this.dgvRefund.Columns.Add("traincode", "车次");
            this.dgvRefund.Columns.Add("StartSite", "出发站");
            this.dgvRefund.Columns.Add("endSite", "到达站");
            this.dgvRefund.Columns.Add("StartTime", "出发时间");
            this.dgvRefund.Columns.Add("endTime", "到达时间");
            this.dgvRefund.Columns.Add("startDate", "出发日期");
            this.dgvRefund.Columns.Add("personName", "姓名");
            this.dgvRefund.Columns.Add("IDType", "证件类型");
            this.dgvRefund.Columns.Add("seatType", "席别");
            this.dgvRefund.Columns.Add("SeatNum", "席位号");
            this.dgvRefund.Columns.Add("TicketType", "票种");
            this.dgvRefund.Columns.Add("price", "票价");
            this.dgvRefund.Columns.Add("orderState", "订单状态");
            List<Order> orders4 = getCanRefundOrder(userName);
            dgvLoad(orders4, this.dgvRefund);
            #endregion


            #region 历史订单信息初始化
            this.dgvHistory.Columns.Add("ID", "序号");
            this.dgvHistory.Columns.Add("traincode", "车次");
            this.dgvHistory.Columns.Add("StartSite", "出发站");
            this.dgvHistory.Columns.Add("endSite", "到达站");

            this.dgvHistory.Columns.Add("StartTime", "出发时间");
            this.dgvHistory.Columns.Add("endTime", "到达时间");
            this.dgvHistory.Columns.Add("startDate", "出发日期");
            this.dgvHistory.Columns.Add("personName", "姓名");
            this.dgvHistory.Columns.Add("IDType", "证件类型");
            this.dgvHistory.Columns.Add("seatType", "席别");
            this.dgvHistory.Columns.Add("SeatNum", "席位号");
            this.dgvHistory.Columns.Add("TicketType", "票种");
            this.dgvHistory.Columns.Add("price", "票价");
            this.dgvHistory.Columns.Add("orderState", "订单状态");
            List<Order> orders5 = getHistoryOrder(userName);
            dgvLoad(orders5, this.dgvHistory);
            #endregion

            this.condition.Items.Add("按订票日期查询");
            this.condition.Items.Add("按乘车日期查询");
            this.condition.SelectedIndex=0;


        }

        private void queryText1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.queryText1.Text==text)
            {
                this.queryText1.Text = "";
            }
        }

        private void queryText1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void queryText1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.queryText1.Text))
            {
                this.queryText1.Text = text;
            }
        }

        private void OrderCenter_Click(object sender, EventArgs e)
        {
            this.condition.Focus();
        }

        private void queryText2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.queryText2.Text))
            {
                this.queryText2.Text = text;
            }
        }

        private void queryText2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.queryText2.Text == text)
            {
                this.queryText2.Text = "";
            }
        }


        
        private void BtnOrderQuery_Click(object sender, EventArgs e)
        {
            if (this.condition.Text== "按订票日期查询")
            {
                if (this.queryText1.Text!=text)
                {
                    
                    if (this.tabControl1.SelectedTab.Text == "全部")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName,1,2,3,this.queryText1.Text);
                        dgvClear(dgvNotTravel);
                        dgvLoad(orders,dgvNotTravel);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可改签")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName,1,this.queryText1.Text);
                        dgvClear(dgvChange);
                        dgvLoad(orders, dgvChange);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可退票")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1,2,this.queryText1.Text);
                        dgvClear(dgvRefund);
                        dgvLoad(orders, dgvRefund);
                    }
                }
                else
                {
                    if (this.tabControl1.SelectedTab.Text == "全部")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName,1,2,3);
                        dgvClear(dgvNotTravel);
                        dgvLoad(orders, dgvNotTravel);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可改签")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1);
                        dgvClear(dgvChange);
                        dgvLoad(orders, dgvChange);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可退票")
                    {
                        List<Order> orders = queryByDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1, 2);
                        dgvClear(dgvRefund);
                        dgvLoad(orders, dgvRefund);
                    }
                }
            }
            else if(this.condition.Text== "按乘车日期查询")
            {
                if (this.queryText1.Text != text)
                {

                    if (this.tabControl1.SelectedTab.Text == "全部")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1, 2, 3,this.queryText1.Text);
                        dgvClear(dgvNotTravel);
                        dgvLoad(orders, dgvNotTravel);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可改签")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1, this.queryText1.Text);
                        dgvClear(dgvChange);
                        dgvLoad(orders, dgvChange);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可退票")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1, 2, this.queryText1.Text);
                        dgvClear(dgvRefund); 
                        dgvLoad(orders, dgvRefund);
                    }
                }
                else
                {
                    if (this.tabControl1.SelectedTab.Text == "全部")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1);
                        dgvClear(dgvNotTravel);
                        dgvLoad(orders, dgvNotTravel);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可改签")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1);
                        dgvClear(dgvChange);
                        dgvLoad(orders, dgvChange);
                    }
                    else if (this.tabControl1.SelectedTab.Text == "可退票")
                    {
                        List<Order> orders = queryByStartDate(this.dateTimePicker1.Text, this.dateTimePicker2.Text, userName, 1, 2);
                        dgvClear(dgvRefund);
                        dgvLoad(orders, dgvRefund);
                    }
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        //退票
        private void button8_Click(object sender, EventArgs e)
        {
            int index = this.dgvNotTravel.CurrentRow.Index;
            string trainCode = this.dgvNotTravel.Rows[index].Cells[1].Value.ToString();
            string startDate = this.dgvNotTravel.Rows[index].Cells[6].Value.ToString();
            string personName = this.dgvNotTravel.Rows[index].Cells[7].Value.ToString();
            if (deleteOrder(trainCode, startDate, userName, personName)>0)
            {
                MessageBox.Show("退票成功！", "提示", MessageBoxButtons.OK);
                List<Order> orders = getPaidOrder(userName);
                dgvClear(dgvNotTravel);
                dgvLoad(orders, dgvNotTravel);
            }
            else
            {

                MessageBox.Show("退票失败", "提示", MessageBoxButtons.OK);
            }
        }
        //改签
        private void button7_Click(object sender, EventArgs e)
        {

            int index = this.dgvNotTravel.CurrentRow.Index;
            string trainCode = this.dgvNotTravel.Rows[index].Cells[1].Value.ToString();
            string personName = this.dgvNotTravel.Rows[index].Cells[7].Value.ToString();
            string startDate = this.dgvNotTravel.Rows[index].Cells[6].Value.ToString();
            string userName = this.userName;
            Order order = getOrder(trainCode, personName, startDate, userName);
            if (order.orderState==3)
            {
                return;
            }
            FrmChangeTrainNum change=new FrmChangeTrainNum(order);
            this.Hide();
            DialogResult dr=change.ShowDialog();
            if (dr==DialogResult.Cancel)
            {
                this.Show();
            }
        }



        private void refu_Click(object sender, EventArgs e)
        {
            int index = this.dgvChange.CurrentRow.Index;
            string trainCode = this.dgvChange.Rows[index].Cells[1].Value.ToString();
            string startDate = this.dgvChange.Rows[index].Cells[6].Value.ToString();
            string personName = this.dgvChange.Rows[index].Cells[7].Value.ToString();
            if (deleteOrder(trainCode, startDate, userName, personName) > 0)
            {
                MessageBox.Show("退票成功！", "提示", MessageBoxButtons.OK);
                List<Order> orders = getPaidOrder(userName);
                dgvClear(dgvChange);
                dgvLoad(orders, dgvChange);
            }
            else
            {

                MessageBox.Show("退票失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void refundticket_Click(object sender, EventArgs e)
        {
            int index = this.dgvRefund.CurrentRow.Index;
            string trainCode = this.dgvRefund.Rows[index].Cells[1].Value.ToString();
            string startDate = this.dgvRefund.Rows[index].Cells[6].Value.ToString();
            string personName = this.dgvRefund.Rows[index].Cells[7].Value.ToString();
            if (deleteOrder(trainCode, startDate, userName, personName) > 0)
            {
                MessageBox.Show("退票成功！", "提示", MessageBoxButtons.OK);
                List<Order> orders = getPaidOrder(userName);
                dgvClear(dgvRefund);
                dgvLoad(orders, dgvRefund);
            }
            else
            {

                MessageBox.Show("退票失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            int index = this.dgvChange.CurrentRow.Index;
            string trainCode = this.dgvChange.Rows[index].Cells[1].Value.ToString();
            string personName = this.dgvChange.Rows[index].Cells[7].Value.ToString();
            string startDate = this.dgvChange.Rows[index].Cells[6].Value.ToString();
            string userName = this.userName;

            Order order = getOrder(trainCode, personName, startDate, userName);
            FrmChangeTrainNum change = new FrmChangeTrainNum(order);
            change.ShowDialog();
        }

        private void detail_Click(object sender, EventArgs e)
        {
            int index = this.dgvNotTravel.CurrentRow.Index;
            string trainCode = this.dgvNotTravel.Rows[index].Cells[1].Value.ToString();
            string personName = this.dgvNotTravel.Rows[index].Cells[7].Value.ToString();
            string startDate = this.dgvNotTravel.Rows[index].Cells[6].Value.ToString();
            string userName = this.userName;
            Order order = getOrder(trainCode, personName, startDate, userName);
            FrmOrderInfo info=new FrmOrderInfo(order);
            this.Hide();
            DialogResult dr = info.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
