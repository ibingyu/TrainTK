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
    public partial class PriceUpdate : Form
    {
        public PriceUpdate()
        {
            InitializeComponent();
        }
        public PriceUpdate(Price price)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.price = price;
        }

        private Price price;
        private int updatePrice(Price price)
        {
            string sql = "UPDATE Price SET typeCode='"+price.typeCode+"',trainName='"+price.trainName+"',departure='"+price.departure+"',destination='"+price.destination+"',seatType='"+price.seatType+"',passengerType='"+price.passengerType+"',ticketPrice="+price.ticketPrice;
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void PriceUpdate_Load(object sender, EventArgs e)
        {
            this.trainType.Text = price.typeCode.ToString();
            this.typeName.Text = price.trainName;
            this.startSite.Text = price.departure;
            this.endSite.Text = price.destination;
            this.seatType.Text = price.seatType;
            this.passagerType.Text = price.passengerType;
            this.ticketPrice.Text = price.ticketPrice.ToString();

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            price.typeCode =this.trainType.Text.ToString().ToCharArray()[0];
            price.trainName=this.typeName.Text;
            price.departure = this.startSite.Text;
            price.destination = this.endSite.Text;
            price.seatType = this.seatType.Text;
            price.passengerType = this.passagerType.Text;
            price.ticketPrice = decimal.Parse(this.ticketPrice.Text);
            if (updatePrice(price) > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
