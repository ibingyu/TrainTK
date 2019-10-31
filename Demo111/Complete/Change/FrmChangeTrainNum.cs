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
    public partial class FrmChangeTrainNum : Form
    {
        public FrmChangeTrainNum()
        {
            InitializeComponent();
        }
        public FrmChangeTrainNum(Order order)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.order = order;
            this.userName = order.userName;
            this.personName = order.PersonName;
            this.trainCode=order.trainCode;
            this.startSite = order.startSite;
            this.endSite = order.endSite;
            this.date = order.startDate.ToString("yyyy-MM-dd",System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }
        //出发站点名称
        public static string depSite;
        //到达站点名称
        public static string destSite;

        private Order order;
        private string startSite;
        private string endSite;
        private string date;
        private string userName;
        private string personName;
        private string trainCode;
        private List<TrainNum> getTrainNum(string date, string startSite,string endSite)
        {
            List<TrainNum> trains = new List<TrainNum>();
            string sql = "SELECT * FROM TrainNum WHERE startSite='" + startSite+ "' AND endSite='"+endSite + "' AND startDate='" + date+ "'";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                TrainNum train=new TrainNum();
                train.TrainType = dt.DefaultView.Table.Rows[i][1].ToString();
                train.trainCode = dt.DefaultView.Table.Rows[i][2].ToString();
                train.startSite = dt.DefaultView.Table.Rows[i][3].ToString();
                train.endSite = dt.DefaultView.Table.Rows[i][4].ToString();
                train.startTime = dt.DefaultView.Table.Rows[i][5].ToString();
                train.endTime = dt.DefaultView.Table.Rows[i][6].ToString();
                train.spendTime = dt.DefaultView.Table.Rows[i][7].ToString();
                train.startDate = DateTime.Parse(date);
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
                train.startToendTime=train.startTime+" - "+train.endTime;
                trains.Add(train);
            }
            
            return trains;
        }
        private void dgvClear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
        private void loadDate(List<TrainNum> trains)
        {
            for (int i = 0; i < trains.Count; i++)
            {
                this.dgvtrainInfo.Rows.Add();
            }
            for (int i = 0; i < trains.Count; i++)
            {
                
                this.dgvtrainInfo.Rows[i].Cells[0].Value = trains[i].TrainType+trains[i].trainCode;
                this.dgvtrainInfo.Rows[i].Cells[1].Value = trains[i].startToendSite;
                this.dgvtrainInfo.Rows[i].Cells[2].Value = trains[i].startToendTime;
                this.dgvtrainInfo.Rows[i].Cells[3].Value = trains[i].spendTime;
                this.dgvtrainInfo.Rows[i].Cells[4].Value = trains[i].swz_num;
                this.dgvtrainInfo.Rows[i].Cells[5].Value = trains[i].yd_num;
                this.dgvtrainInfo.Rows[i].Cells[6].Value = trains[i].ed_num;
                this.dgvtrainInfo.Rows[i].Cells[7].Value = trains[i].gr_num;
                this.dgvtrainInfo.Rows[i].Cells[8].Value = trains[i].rw_num;
                this.dgvtrainInfo.Rows[i].Cells[9].Value = trains[i].dw_num;
                this.dgvtrainInfo.Rows[i].Cells[10].Value = trains[i].yw_num;
                this.dgvtrainInfo.Rows[i].Cells[11].Value = trains[i].rz_num;
                this.dgvtrainInfo.Rows[i].Cells[12].Value = trains[i].yz_num;
                this.dgvtrainInfo.Rows[i].Cells[13].Value = trains[i].wz_num;
            }
        }

        private void FrmAllTrainNum_Load(object sender, EventArgs e)
        {
            this.PlaceOfDeparture.Text = startSite;
            this.PlaceOfDestination.Text = endSite;
            this.dateTimePicker1.Text = date;
            List<TrainNum> trains = getTrainNum(date, startSite, endSite);
            loadDate(trains);

        }
        private void GetDepSite_Click(object sender, EventArgs e)
        {
            FrmSelectSite1 selectSite = new FrmSelectSite1(GetDepSite.Name);
            selectSite.ShowDialog();
            this.PlaceOfDeparture.Text = depSite;
        }
        private void GetDestSite_Click(object sender, EventArgs e)
        {
            FrmSelectSite1 selectSite = new FrmSelectSite1(GetDestSite.Name);
            selectSite.ShowDialog();
            this.PlaceOfDestination.Text = destSite;
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (this.PlaceOfDeparture.Text == "" || this.PlaceOfDestination.Text == "")
            {
                MessageBox.Show("请输入出发站和到达站！", "提示", MessageBoxButtons.OK);
            }
            List<TrainNum> trains = getTrainNum(this.dateTimePicker1.Text, this.PlaceOfDeparture.Text, this.PlaceOfDestination.Text);
            dgvClear(this.dgvtrainInfo);
            loadDate(trains);
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            int index = this.dgvtrainInfo.CurrentRow.Index;
            string trainCode = this.dgvtrainInfo.Rows[index].Cells[0].Value.ToString().Substring(1);
            string date = this.dateTimePicker1.Text;
            if (trainCode==order.trainCode)
            {
                MessageBox.Show("与原车次相同，请选择其他车次","提示",MessageBoxButtons.OK);
            }
            else
            {
                FrmChangePurchase purchase=new FrmChangePurchase(userName,trainCode,date,order.PersonName,order);
                this.Hide();
                DialogResult dr=purchase.ShowDialog();
                if (dr==DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            
        }
    }
}
