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
    public partial class TicketPrice : Form
    {
        public TicketPrice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private List<Price> getAllPrice()
        {
            List<Price> prices = new List<Price>();
            string sql = " SELECT * FROM Price";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Price price = new Price();

                #region 获取price

                price.typeCode = dt.DefaultView.Table.Rows[i][3].ToString().ToCharArray()[0];
                price.trainName = dt.DefaultView.Table.Rows[i][4].ToString();
                price.departure = dt.DefaultView.Table.Rows[i][1].ToString();
                price.destination = dt.DefaultView.Table.Rows[i][2].ToString();
                price.seatType = dt.DefaultView.Table.Rows[i][5].ToString();
                price.passengerType = dt.DefaultView.Table.Rows[i][6].ToString();
                price.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                #endregion

                prices.Add(price);
            }

            return prices;
        }

        private int index;

        private List<Price> queryPrice(string startName,string endName)
        {
            List<Price> prices = new List<Price>();
            string sql = " SELECT * FROM Price WHERE departure='" + startName + "'AND destination= '"+endName+"'";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Price price = new Price();

                #region 获取price

                price.typeCode = dt.DefaultView.Table.Rows[i][3].ToString().ToCharArray()[0];
                price.trainName = dt.DefaultView.Table.Rows[i][4].ToString();
                price.departure = dt.DefaultView.Table.Rows[i][1].ToString();
                price.destination = dt.DefaultView.Table.Rows[i][2].ToString();
                price.seatType = dt.DefaultView.Table.Rows[i][5].ToString();
                price.passengerType = dt.DefaultView.Table.Rows[i][6].ToString();
                price.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[i][7].ToString());
                #endregion

                prices.Add(price);
            }

            return prices;
        }
        
        private Price getPrice(string startName, string endName, string typeCode, string passengerType, string seatType)
        {

            string sql = " SELECT * FROM Price WHERE departure='" + startName + "'AND destination= '" + endName + "' AND typeCode='" + typeCode + "' AND passengerType='" + passengerType + "' AND seatType='" + seatType + "'";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);

            Price price = new Price();

            #region 获取price

            price.typeCode = dt.DefaultView.Table.Rows[0][3].ToString().ToCharArray()[0];
            price.trainName = dt.DefaultView.Table.Rows[0][4].ToString();
            price.departure = dt.DefaultView.Table.Rows[0][1].ToString();
            price.destination = dt.DefaultView.Table.Rows[0][2].ToString();
            price.seatType = dt.DefaultView.Table.Rows[0][5].ToString();
            price.passengerType = dt.DefaultView.Table.Rows[0][6].ToString();
            price.ticketPrice = decimal.Parse(dt.DefaultView.Table.Rows[0][7].ToString());
            #endregion

            return price;
        }
        private void dgvClear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
        private void dgvLoad(List<Price> prices, DataGridView dataGridView)
        {
            for (int i = 0; i < prices.Count; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < prices.Count; i++)
            {
                //dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[1].Value = prices[i].typeCode;
                dataGridView.Rows[i].Cells[2].Value = prices[i].trainName;
                dataGridView.Rows[i].Cells[3].Value = prices[i].departure;
                dataGridView.Rows[i].Cells[4].Value = prices[i].destination;
                dataGridView.Rows[i].Cells[5].Value = prices[i].seatType;
                dataGridView.Rows[i].Cells[6].Value = prices[i].passengerType;
                dataGridView.Rows[i].Cells[7].Value = prices[i].ticketPrice;
            }
        }

        private void TicketPrice_Load(object sender, EventArgs e)
        {
            List<Price> prices = getAllPrice();
            dgvLoad(prices, this.dgvPrice);
        }

        private int priceDelete(string startName, string endName,string typeCode, string passengerType,string seatType)
        {
            string sql = " DELETE dbo.Price WHERE departure='"+startName+"' AND destination='"+endSite+"' AND typeCode='"+typeCode+"' AND passengerType='"+passengerType+"' AND seatType='"+seatType+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void dgvPrice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPrice.Rows.Count > 0)
                {
                    int rowIndex = dgvPrice.CurrentCell.RowIndex;
                    int colIndex = dgvPrice.CurrentCell.ColumnIndex;
                    if (colIndex == 0) //第一列
                    {
                        string _selectValue = dgvPrice.CurrentCell.EditedFormattedValue.ToString();
                        if (_selectValue == "True")
                        {
                            for (int i = 0; i < dgvPrice.Rows.Count; i++)
                            {
                                if (i != rowIndex)
                                {
                                    string otherValue = dgvPrice.Rows[i].Cells[0].EditedFormattedValue.ToString();
                                    if (otherValue == "True")
                                    {
                                        ((DataGridViewCheckBoxCell) dgvPrice.Rows[i].Cells[0]).Value = false;
                                    }
                                }
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
            }
            if (e.RowIndex > -1)
            {
                if (dgvPrice.Columns[e.ColumnIndex].Name == "check")
                {
                    for (int i = 0; i < this.dgvPrice.Rows.Count; i++)
                    {
                        if ((bool) dgvPrice.Rows[i].Cells["check"].EditedFormattedValue == true)
                        {
                            index = i;
                        }
                    }

                }
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            if (this.startSite.Text==""||this.endSite.Text=="")
            {
                MessageBox.Show("请输入出发站和到达站！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                List<Price> sites = queryPrice(this.startSite.Text, this.endSite.Text);
                dgvClear(this.dgvPrice);
                dgvLoad(sites, this.dgvPrice);
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            PriceADD add = new PriceADD();
            add.ShowDialog();
            dgvClear(this.dgvPrice);
            dgvLoad(getAllPrice(), this.dgvPrice);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (index<0)
            {
                MessageBox.Show("请选中其中一行做修改","提示",MessageBoxButtons.OK);
            }
            else
            {
                string startName = this.dgvPrice.Rows[index].Cells[3].Value.ToString();
                string endName = this.dgvPrice.Rows[index].Cells[4].Value.ToString();
                string typeCode = this.dgvPrice.Rows[index].Cells[1].Value.ToString();
                string passengerType = this.dgvPrice.Rows[index].Cells[6].Value.ToString();
                string seatType = this.dgvPrice.Rows[index].Cells[5].Value.ToString();
                PriceUpdate update = new PriceUpdate(getPrice(startName, endName, typeCode, passengerType, seatType));
                update.ShowDialog();
                dgvClear(this.dgvPrice);
                dgvLoad(getAllPrice(), this.dgvPrice);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dgvPrice.Rows[index].Cells[3].Value.ToString()==null)
            {
                return;
            }
            string startName = this.dgvPrice.Rows[index].Cells[3].Value.ToString();
            string endName= this.dgvPrice.Rows[index].Cells[4].Value.ToString();
            string typeCode= this.dgvPrice.Rows[index].Cells[1].Value.ToString();
            string passengerType= this.dgvPrice.Rows[index].Cells[6].Value.ToString();
            string seatType= this.dgvPrice.Rows[index].Cells[5].Value.ToString();
            if (startName==""|| endName==""|| typeCode==""|| seatType==""|| passengerType=="")
            {
                return;
            }
            if (index == 0)
            {
                MessageBox.Show("请选中其中一行删除！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                if (priceDelete(startName, endName, typeCode, passengerType, seatType) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                    List<Price> prices = getAllPrice();
                    dgvClear(this.dgvPrice);
                    dgvLoad(prices, dgvPrice);
                }
                else
                {
                    MessageBox.Show("删除失败，请再次尝试！", "提示", MessageBoxButtons.OK);
                }
            }
            
        }
    }
}
