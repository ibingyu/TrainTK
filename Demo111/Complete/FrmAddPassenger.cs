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
    public partial class FrmAddPassenger : Form
    {
        public FrmAddPassenger()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public FrmAddPassenger(string userName)
        {
            this.username = userName;
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string username;
        private string name;
        private string idType;
        private string idNum;
        private string sex;
        private string country;
        //联系方式
        private string cphoneNum;
        private string fphoneNum;
        private string email;
        private string address;
        private string postCode;
        private string passengertype;
        private DateTime addDate;

        //添加乘客信息
        private int AddPassenger(string username,string name,string idType,string idNum,string sex,string country,string cphoneNum,string fphoneNum,string email,string address,string postCode,string passengertype,DateTime addDate)
        {
            string sql = "INSERT INTO Contacts(personName,IDType,Sex,IDNum,phoneNum,telePhone,email,[address],postCode,passengerType,AddDate,Country,userName) VALUES('"+name+"','"+idType+ "','" +sex+ "','" +idNum+ "','" +cphoneNum+ "','" +fphoneNum+ "','" +email+ "','" +address+ "','" +postCode+ "','" +passengertype+ "','"+country+"','" +addDate+ "','" +username + "')";

            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void FrmAddPassenger_Load(object sender, EventArgs e)
        {
            #region 旅客类型设置

            this.passengerType.Items.Add("成人");
            this.passengerType.Items.Add("学生");
            this.passengerType.Items.Add("儿童");
            this.passengerType.Items.Add("残疾军人、伤残人民警察");
            this.passengerType.SelectedText = "成人";

            #endregion
            #region 证件类型设置

            this.IDType.Items.Add("中国居民身份证");
            this.IDType.Items.Add("港澳居民来往内地通行证");
            this.IDType.Items.Add("台湾居民来往大陆通行证");
            this.IDType.Items.Add("护照");
            this.IDType.SelectedText = "中国居民身份证";

            #endregion

            this.groupBox1.Visible = true;

        }

        private void IDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IDType.SelectedItem.ToString()== "中国居民身份证")
            {
                this.groupBox1.Visible = true;    
            }
            else
            {
                this.groupBox1.Visible = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            #region 获取填写信息
            if (IDType.SelectedIndex == 0)
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if ((control is RadioButton) && (control as RadioButton).Checked)
                    {
                        idType = control.Text;
                    }
                }
            }
            else
            {
                idType = IDType.Text;
            }
            name = this.textName.Text;
            idNum = this.IDNum.Text;
            foreach (Control control in groupBox2.Controls)
            {
                if ((control is RadioButton) && (control as RadioButton).Checked)
                {
                    sex = control.Text;
                }
            }
            cphoneNum = this.cPhoneNum.Text;
            fphoneNum = this.fPhoneNum.Text;
            email = this.Email.Text;
            address = this.Address.Text;
            postCode = this.PostCode.Text;
            passengertype = this.passengerType.Text;
            addDate = DateTime.Today.Date;

            #endregion

            if (AddPassenger(username,name,idType,idNum,sex,country,cphoneNum,fphoneNum,email,address,postCode,passengertype,addDate)>0)
            {
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加失败，请重新提交保存！", "提示", MessageBoxButtons.OK);
            }

        }
    }
}
