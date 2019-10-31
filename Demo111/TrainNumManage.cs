using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Demo111;

namespace TrainTK
{
    public partial class TrainNumManage : Form
    {
        public TrainNumManage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private DataTable getAllTrain()
        {
            List<TrainNum> trains = new List<TrainNum>();
            string sql = " SELECT TrainType, trainCode, startSite, endSite, startTime, endTime, spendTime, startDate, weekdays, swz_num, yd_num, ed_num, gr_num, rw_num, dw_num, yw_num, rz_num, yz_num, wz_num FROM TrainNum";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            return dt;
        }


        private DataTable getTrain(string trainCode,string startDate)
        {
            string sql = "SELECT TrainType, trainCode, startSite, endSite, startTime, endTime, spendTime, startDate, weekdays, swz_num, yd_num, ed_num, gr_num, rw_num, dw_num, yw_num, rz_num, yz_num, wz_num FROM TrainNum WHERE trainCode='"+trainCode+"' AND startDate='"+startDate+"'";
            DataTable dt=new DataTable();
            return dt;
        }
        private void dgvClear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
        private void dgvLoad(List<Site> sites, DataGridView dataGridView)
        {
            for (int i = 0; i < sites.Count - 1; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < sites.Count; i++)
            {
                //dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[1].Value = sites[i].SiteName;
                dataGridView.Rows[i].Cells[2].Value = sites[i].SiteFirstAlp;
                dataGridView.Rows[i].Cells[3].Value = sites[i].SiteComplteSp;
                if (sites[i].is_hot == 1)
                {
                    dataGridView.Rows[i].Cells[4].Value = "否";
                }
                else
                {
                    dataGridView.Rows[i].Cells[4].Value = "否";
                }
            }
        }
        private void TrainNumManage_Load(object sender, EventArgs e)
        {
            
            this.dgvtrainInfo.DataSource = getAllTrain().DefaultView;
            this.dgvtrainInfo.Columns[0].HeaderCell.Value = "火车类型";
            this.dgvtrainInfo.Columns[1].HeaderCell.Value = "车次";
            this.dgvtrainInfo.Columns[2].HeaderCell.Value = "出发站";
            this.dgvtrainInfo.Columns[3].HeaderCell.Value = "到达站";
            this.dgvtrainInfo.Columns[4].HeaderCell.Value = "出发时间";
            this.dgvtrainInfo.Columns[5].HeaderCell.Value = "到达时间";
            this.dgvtrainInfo.Columns[6].HeaderCell.Value = "历时";
            this.dgvtrainInfo.Columns[7].HeaderCell.Value = "出发日期";
            this.dgvtrainInfo.Columns[8].HeaderCell.Value = "星期";
            this.dgvtrainInfo.Columns[9].HeaderCell.Value = "商务座";
            this.dgvtrainInfo.Columns[10].HeaderCell.Value = "一等座";
            this.dgvtrainInfo.Columns[11].HeaderCell.Value = "二等座";
            this.dgvtrainInfo.Columns[12].HeaderCell.Value = "高软";
            this.dgvtrainInfo.Columns[13].HeaderCell.Value = "软卧";
            this.dgvtrainInfo.Columns[14].HeaderCell.Value = "动卧";
            this.dgvtrainInfo.Columns[15].HeaderCell.Value = "硬卧";
            this.dgvtrainInfo.Columns[16].HeaderCell.Value = "软座";
            this.dgvtrainInfo.Columns[17].HeaderCell.Value = "硬座";
            this.dgvtrainInfo.Columns[18].HeaderCell.Value = "无座";

        }

        private void query_Click(object sender, EventArgs e)
        {
            this.dgvtrainInfo.DataSource = getTrain(this.trainC.Text, this.dateTimePicker1.Text);
        }

        private int deleteTrain(string trainCode, string startDate)
        {
            string sql = "DELETE dbo.TrainNum WHERE trainCode='"+trainCode+"' AND startDate='"+startDate+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            int index = this.dgvtrainInfo.CurrentRow.Index;
            string trainCode = this.dgvtrainInfo.Rows[index].Cells[1].Value.ToString();
            string startDate = this.dgvtrainInfo.Rows[index].Cells[8].Value.ToString();
            if (deleteTrain(trainCode,startDate)>0)
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                this.dgvtrainInfo.DataSource = getAllTrain();
            }
            else
            {
                MessageBox.Show("删除失败，请再次尝试", "提示", MessageBoxButtons.OK);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            
            TrainAdd add = new TrainAdd();
            add.ShowDialog();
            DataView dv = (DataView)this.dgvtrainInfo.DataSource;
            dv.Table.Rows.Clear();
            this.dgvtrainInfo.DataSource = dv;
            this.dgvtrainInfo.DataSource = getAllTrain().DefaultView;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int index = this.dgvtrainInfo.CurrentRow.Index;
            TrainNum train = new TrainNum();
            train.TrainType = this.dgvtrainInfo.Rows[index].Cells[0].Value.ToString();
            train.trainCode = this.dgvtrainInfo.Rows[index].Cells[1].Value.ToString();
            train.startSite = this.dgvtrainInfo.Rows[index].Cells[2].Value.ToString();
            train.endSite = this.dgvtrainInfo.Rows[index].Cells[3].Value.ToString();
            train.startTime = this.dgvtrainInfo.Rows[index].Cells[4].Value.ToString();
            train.endTime = this.dgvtrainInfo.Rows[index].Cells[5].Value.ToString();
            train.spendTime = this.dgvtrainInfo.Rows[index].Cells[6].Value.ToString(); 
            train.swz_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[9].Value.ToString());
            train.yd_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[10].Value.ToString());
            train.ed_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[11].Value.ToString());
            train.gr_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[12].Value.ToString());
            train.rw_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[13].Value.ToString());
            train.dw_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[14].Value.ToString());
            train.yz_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[17].Value.ToString());
            train.rz_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[16].Value.ToString());
            train.wz_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[18].Value.ToString());
            train.yw_num = int.Parse(this.dgvtrainInfo.Rows[index].Cells[15].Value.ToString());
            train.startDate = DateTime.Parse(this.dgvtrainInfo.Rows[index].Cells[7].Value.ToString());
            train.weekday = this.dgvtrainInfo.Rows[index].Cells[8].Value.ToString();
            train.qt_num = 0;
            TrainUpdate update=new TrainUpdate(train);
            update.ShowDialog();
            DataView dv = (DataView)this.dgvtrainInfo.DataSource;
            dv.Table.Rows.Clear();
            this.dgvtrainInfo.DataSource = dv;
            this.dgvtrainInfo.DataSource = getAllTrain().DefaultView;
        }
    }
}
