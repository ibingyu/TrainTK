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
    public partial class FrmUpdatePassenger : Form
    {
        public FrmUpdatePassenger()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public FrmUpdatePassenger(string userName, string personName)
        {
            this.username = userName;
            this.personName = personName;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private string username;
        private string personName;

        //联系方式
        private string cphoneNum;
        private string fphoneNum;
        private string Email;
        private string Address;
        private string postCode;
        private string passengertype;
        //获取联系人信息
        private string GetInfo(string text)
        {
            string sql = "select " + text + " from Contacts where userName='" + username+"' and personName='"+personName+"'";
            return SqlHelper.ExecuteScalar(sql).ToString();
        }
        private void FrmUpdatePassenger_Load(object sender, EventArgs e)
        {
            #region 旅客类型设置

            this.passengerType.Items.Add("成人");
            this.passengerType.Items.Add("学生");
            this.passengerType.Items.Add("儿童");
            this.passengerType.Items.Add("残疾军人、伤残人民警察");
            this.passengerType.SelectedText = GetInfo("passengerType");
            #endregion
            this.name.Text = GetInfo("personName");
            this.sex.Text = GetInfo("Sex");
            this.idType.Text = GetInfo("IdType");
            this.country.Text = GetInfo("Country");
            this.idNum.Text = GetInfo("IDnum");
            this.addDate.Text = GetInfo("addDate");

            this.fPhoneNum.Text = GetInfo("phoneNum");
            this.cPhoneNum.Text = GetInfo("telePhone");
            this.email.Text = GetInfo("email");
            this.address.Text = GetInfo("address");
            this.postcode.Text = GetInfo("postCode");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //更新个人联系信息
        private int UpdateInfo(string cphoneNum, string fphoneNum, string email, string address, string postCode,string passengertype)
        {
            string sql = "UPDATE Contacts SET phoneNum = '" + cphoneNum + "',telePhone = '" + fphoneNum + "',email = '" + email + "',[address] = '" + address + "',postCode = '" + postCode + "',passengerType = '"+passengertype+"' WHERE userName='" + username+"'";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cphoneNum = this.cPhoneNum.Text;
            fphoneNum = this.fPhoneNum.Text;
            Address = this.address.Text;
            Email = this.email.Text;
            postCode = this.postcode.Text;
            passengertype = this.passengerType.SelectedItem.ToString(); 
            if (UpdateInfo(cphoneNum, fphoneNum, Email, Address, postCode,passengertype) > 0)
            {
                if (MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.fPhoneNum.Text = GetInfo("phoneNum");
                    this.cPhoneNum.Text = GetInfo("telePhone");
                    this.email.Text = GetInfo("email");
                    this.address.Text = GetInfo("address");
                    this.postcode.Text = GetInfo("postCode");
                    this.passengerType.SelectedText = GetInfo("passengerType");
                }
            }
            else
            {
                MessageBox.Show("修改失败，请重新提交保存！", "提示", MessageBoxButtons.OKCancel);
            }
        }
    }
}
