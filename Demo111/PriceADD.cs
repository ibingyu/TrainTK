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
    public partial class PriceADD : Form
    {
        public PriceADD()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private int addPrice(Price price)
        {
            string sql = "INSERT INTO dbo.Price( departure,destination,typeCode,trainName,seatType,passengerType,ticketPrice) VALUES( '" + price.departure + "','" + price.destination + "','" + price.typeCode + "','" + price.trainName + "','" + price.seatType + "','" + price.passengerType +"'," + price.ticketPrice + ")";
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private List<string> getTrainCode()
        {
            List<string> allTrainCode = new List<string>();
            string sql = "SELECT typeCode FROM TrainType";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                string trainCode=dt.DefaultView.Table.Rows[i][0].ToString();
                allTrainCode.Add(trainCode);            
            }
            return allTrainCode;
        }
        private int getPrice(string startName, string endName, string typeCode, string passengerType, string seatType)
        {
            string sql = " SELECT count(*) FROM Price WHERE departure='" + startName + "'AND destination= '" + endName + "' AND typeCode='" + typeCode + "' AND passengerType='" + passengerType + "' AND seatType='" + seatType + "'";
            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }
        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.typeCode = this.trainType.Text.ToString().ToCharArray()[0];
            price.trainName = this.typeName.Text;
            price.departure = this.startSite.Text;
            price.destination = this.endSite.Text;
            price.seatType = this.seatType.Text;
            price.passengerType = this.passagerType.Text;
            price.ticketPrice = decimal.Parse(this.price.Text);
            if (getPrice(this.startSite.Text,this.endSite.Text, this.trainType.Text, price.passengerType,price.seatType) <1)
            {
                if (addPrice(price) > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("票价已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PriceADD_Load(object sender, EventArgs e)
        {
            this.passagerType.Items.Add("成人");
            this.passagerType.Items.Add("学生");
            this.passagerType.Items.Add("儿童");
            this.passagerType.Items.Add("残疾军人、伤残人民警察");
            this.passagerType.SelectedText = "成人";

            List<string> allTrainCode = getTrainCode();
            for (int i = 0; i < allTrainCode.Count; i++)
            {
                string trainCode = allTrainCode[i];
                this.trainType.Items.Add(trainCode);
            }
            this.trainType.SelectedIndex = 0;
        }

        private void trainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.passagerType.Text=="G")
            {
                this.typeName.Text = "高铁";
            }
            else if (this.passagerType.Text == "D")
            {
                this.typeName.Text = "动车";
            }
            else if (this.passagerType.Text == "T")
            {
                this.typeName.Text = "特快";
            }
            else if (this.passagerType.Text == "K")
            {
                this.typeName.Text = "高铁";
            }
            else if (this.passagerType.Text == "Z")
            {
                this.typeName.Text = "直达";
            }

        }
    }
}
