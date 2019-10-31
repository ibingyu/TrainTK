using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Utility;
using TrainTK;

namespace Demo111
{
    public partial class OrderPay : Form
    {
        public OrderPay()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public OrderPay(Order order)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.order = order;
        }

        private Order order;
        private void OrderPay_Load(object sender, EventArgs e)
        {
            
        }

        private void canclePay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int updateOrderState(Order order)
        {
            string sql = "UPDATE TicketOrder SET orderState = 1 WHERE orderID=" + order.orderID;
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void payCom_Click(object sender, EventArgs e)
        {
            if (updateOrderState(order)>0)
            {
                MessageBox.Show("支付成功！", "提示", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
