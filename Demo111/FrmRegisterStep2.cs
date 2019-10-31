using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TrainTK
{
    public partial class FrmRegisterStep2 : Form
    {
        public FrmRegisterStep2()
        {
            InitializeComponent();
        }

        public FrmRegisterStep2(UserModel user)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.user = user;
        }

        private UserModel user;
        private void FrmRegisterStep1_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private int addUser(UserModel user)
        {
            string sql= "UPDATE user1 SET userName = '"+user.userName+"', [password]='"+user.password+"' ,Name = '"+user.Name+"',sex = '"+user.sex+"',usermobile = '"+user.userMobile+"',phonenumber = '"+user.phoneNumber+"',email ='"+user.email+"' ,Idtype ='"+user.IDType+"' ,IDnumber = '"+user.IDNumber+"',Country = '"+user.Country+"',[address] = '"+user.address+"',PostCode = '"+user.postCode+"',passengerType = '"+user.passengerType+"'";

            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            //确认固定电话号是否符合格式
            if (this.telPhone.Text.Trim().Length != 0&&System.Text.RegularExpressions.Regex.IsMatch(this.telPhone.Text.Trim(),@"^[0-9]{7,8}$"))
            {
                MessageBox.Show("请输入7~8位数字的号码！", "信息提示");
                this.telPhone.Focus();
                this.telPhone.SelectAll();
                return;
            }
            //确认邮箱格式是否正确
            if (this.email.Text.Trim().Length !=0 && System.Text.RegularExpressions.Regex.IsMatch(this.email.Text.Trim(), @"^[A-Za-z0-9\u4e00-\u9fa5]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$"))
            {
                MessageBox.Show("邮箱格式错误！", "信息提示");
                this.email.Focus();
                this.email.SelectAll();
                return;
            }
        
            //判断邮编格式是否正确
            if (this.PostCode.Text.Trim().Length != 0 && System.Text.RegularExpressions.Regex.IsMatch(this.PostCode.Text.Trim(),@"^[0-9]{6}$"))
            {
                MessageBox.Show("邮编格式错误！", "信息提示");
                this.PostCode.Focus();
                this.PostCode.SelectAll();
                return;
            }
            this.user.userMobile = this.telPhone.Text.Trim();
            this.user.email = this.email.Text.Trim();
            this.user.address = this.address.Text.Trim();
            this.user.postCode = this.PostCode.Text.Trim();
            if (addUser(user)>0)
            {
                MessageBox.Show("注册成功！", "信息提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败，请再次尝试！", "信息提示");
            }
        }
    }
}

