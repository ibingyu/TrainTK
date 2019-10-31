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
using HZH_Controls;
using TrainTK;

namespace Demo111
{
    public partial class FrmPurchase : Form
    {
        public FrmPurchase()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public FrmPurchase(string userName, string trainNum,string date)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.userName = userName;
            this.trainNum = trainNum;
            this.date=DateTime.Parse(date);
        }
        private string userName;

        private string trainNum;

        private DateTime date = DateTime.Parse("2019-10-26");
        private List<string> getAllPasserger(string userName)
        {
            string sql = "SELECT personName FROM Contacts AS c WHERE userName='" + userName + "'";
            DataTable dt=new DataTable();
            List<string> personList=new List<string>();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                string personName= dt.DefaultView.Table.Rows[i][0].ToString();
                personList.Add(personName);
            }
            return personList;
        }

        private int getPasserger(string userName,string personName)
        {
            string sql = "SELECT personName FROM Contacts AS c WHERE userName='" + userName + "' and personName= '"+personName+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }

        private Purchase GetPersonInfo(string userName, string personName)
        {
            Purchase purchase=new Purchase();
            string sql = "select IDType,IDNum,phoneNum from Contacts where userName='"+userName+"'and personName='"+personName+"'";

            DataTable dt=new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            purchase.ID = 1;
            purchase.PersonName = personName;
            purchase.IDType = dt.DefaultView.Table.Rows[0][0].ToString();
            purchase.IDNum = dt.DefaultView.Table.Rows[0][1].ToString();
            purchase.PhoneNum = dt.DefaultView.Table.Rows[0][2].ToString();
            purchase.SeatType = "";
            purchase.TicketType = "";
            

            return purchase;
        }

        private List<Purchase> GetPriceInfo(string startSite, string endSite)
        {
            string sql = "SELECT seatType,ticketprice FROM Price WHERE departure='" + startSite + "' AND destination='" +
                          endSite + "'";
            List<Purchase> purchases=new List<Purchase>();
            DataTable dt=new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Purchase purchase=new Purchase();
                string seat = dt.DefaultView.Table.Rows[i][0].ToString();
                string price = dt.DefaultView.Table.Rows[i][1].ToString();
                purchase.SeatType = seat + "（" + price + "）";
                purchases.Add(purchase);
            }
            return purchases;
        }

        private TrainNum getTrainNum(DateTime date, string trainNum)
        {
            TrainNum train=new TrainNum();
            string sql = "SELECT * FROM TrainNum WHERE trainCode='" + trainNum + "' AND startDate='" + date.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)+ "'";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable(sql);
            train.TrainType = dt.DefaultView.Table.Rows[0][1].ToString();
            train.trainCode = dt.DefaultView.Table.Rows[0][2].ToString();
            train.startSite = dt.DefaultView.Table.Rows[0][3].ToString();
            train.endSite = dt.DefaultView.Table.Rows[0][4].ToString();
            train.startTime = dt.DefaultView.Table.Rows[0][5].ToString();
            train.endTime = dt.DefaultView.Table.Rows[0][6].ToString();
            train.spendTime = dt.DefaultView.Table.Rows[0][7].ToString();
            train.startDate = date;
            train.swz_num = int.Parse(dt.DefaultView.Table.Rows[0][9].ToString());
            train.yd_num= int.Parse(dt.DefaultView.Table.Rows[0][10].ToString());
            train.ed_num = int.Parse(dt.DefaultView.Table.Rows[0][11].ToString());
            train.yz_num = int.Parse(dt.DefaultView.Table.Rows[0][12].ToString());
            train.yw_num = int.Parse(dt.DefaultView.Table.Rows[0][13].ToString());
            train.wz_num = int.Parse(dt.DefaultView.Table.Rows[0][14].ToString());
            train.rz_num = int.Parse(dt.DefaultView.Table.Rows[0][15].ToString());
            train.gr_num = int.Parse(dt.DefaultView.Table.Rows[0][16].ToString());
            train.rw_num = int.Parse(dt.DefaultView.Table.Rows[0][17].ToString());
            train.dw_num = int.Parse(dt.DefaultView.Table.Rows[0][18].ToString());
            train.qt_num = int.Parse(dt.DefaultView.Table.Rows[0][19].ToString());
            train.weekday= dt.DefaultView.Table.Rows[0][20].ToString();
            return train;
        } 

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            #region CheckBox加载
		    int x=30, y=20;
            List<string> personList = getAllPasserger(userName);
            foreach (string personName in personList)
            {
                Font font=new Font("微软雅黑", 12);
                CheckBox chkbox = new CheckBox();
                chkbox.Location = new Point(x, y);
                chkbox.Name = "chk"+personList.IndexOf(personName);
                chkbox.Text = personName.ToString();
                chkbox.Font = font;
                chkbox.CheckedChanged+=new EventHandler(chkbox_CheckedChanged);
                this.groupBox1.Controls.Add(chkbox);
                if (x<900)
                {
                    x += 170;
                }
                else
                {
                    break;
                }
            }
            string name = personList[0];
            foreach (Control control in this.groupBox1.Controls)
            {
                if ((control is CheckBox)&&(control as CheckBox).Checked)
                {
                    name = control.Text.Trim();
                }
            }

	        #endregion



            Purchase purchase = GetPersonInfo(userName, name);
            this.dgvselect.Rows[0].Cells[0].Value = purchase.ID.ToString();
            this.dgvselect.Rows[0].Cells[3].Value = purchase.PersonName;
            this.dgvselect.Rows[0].Cells[4].Value = purchase.IDType;
            this.dgvselect.Rows[0].Cells[5].Value = purchase.IDNum;
            this.dgvselect.Rows[0].Cells[6].Value = purchase.PhoneNum;

           
            DataGridViewComboBoxCell cell=this.dgvselect.Rows[0].Cells[1] as DataGridViewComboBoxCell;
            if (cell!=null)
            {
                cell.Items.Add("成人票");
                cell.Items.Add("学生票");
                cell.Items.Add("儿童票");
                cell.Items.Add("军残票");
                cell.Value = "成人票";
            }
            TrainNum train = getTrainNum(date, trainNum);
            string startSite=train.startSite;
            string endSite=train.endSite;
            List<Purchase> purchases = GetPriceInfo(startSite, endSite);
            DataGridViewComboBoxCell seatCell = this.dgvselect.Rows[0].Cells[2] as DataGridViewComboBoxCell;
            for (int i = 0; i < purchases.Count; i++)
            {
                if (seatCell!=null)
                {
                    seatCell.Items.Add(purchases[i].SeatType);
                }
            }
            seatCell.Value = seatCell.Items[0].ToString();

        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk=sender as CheckBox;
            if (chk.Checked)
            {
                Purchase purchase = GetPersonInfo(userName, chk.Text);
                this.dgvselect.Rows[0].Cells[0].Value = purchase.ID.ToString();
                this.dgvselect.Rows[0].Cells[3].Value = purchase.PersonName;
                this.dgvselect.Rows[0].Cells[4].Value = purchase.IDType;
                this.dgvselect.Rows[0].Cells[5].Value = purchase.IDNum;
                this.dgvselect.Rows[0].Cells[6].Value = purchase.PhoneNum;
            }
        }

        private string prompt = "输入乘客姓名";
            
        private void userNameText_MouseDown(object sender, MouseEventArgs e)
        {
            if (personNameText.Text == prompt)
            {
                this.personNameText.Text = "";
            }
        }


        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(personNameText.Text))
            {
                this.personNameText.Text = prompt;
            }
        }

        private void FrmPurchase_MouseClick(object sender, MouseEventArgs e)
        {
            this.button1.Focus();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //乘客查找
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.personNameText.Text!= "输入乘客姓名"&&getPasserger(userName,this.personNameText.Text.Trim())>0)
            {
                foreach (Control control in this.groupBox1.Controls)
                {
                    if (control is CheckBox)
                    {
                        this.groupBox1.Controls.Remove(control);
                    }
                }
                Font font = new Font("微软雅黑", 12);
                CheckBox chkbox = new CheckBox();
                chkbox.Location = new Point(30, 20);
                chkbox.Name = "chk";
                chkbox.Text = this.personNameText.Text.Trim();
                chkbox.Font = font;
                this.groupBox1.Controls.Add(chkbox);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Purchase purchase=new Purchase();
            TrainNum train = getTrainNum(date, trainNum);
            purchase.ID =int.Parse(this.dgvselect.Rows[0].Cells[0].Value.ToString());
            purchase.TicketType = this.dgvselect.Rows[0].Cells[1].Value.ToString();
            purchase.SeatType = this.dgvselect.Rows[0].Cells[2].Value.ToString();
            purchase.PersonName = this.dgvselect.Rows[0].Cells[3].Value.ToString();
            purchase.IDType = this.dgvselect.Rows[0].Cells[4].Value.ToString();
            purchase.IDNum = this.dgvselect.Rows[0].Cells[5].Value.ToString();
            purchase.PhoneNum = this.dgvselect.Rows[0].Cells[6].Value.ToString();

            FrmCheckInfo checkInfo=new FrmCheckInfo(train,purchase,userName);
            this.Hide();
                    DialogResult dr=checkInfo.ShowDialog();
                    if (dr==DialogResult.Cancel)
                    {
                        this.Show();
                    }
        }
    }
}
