using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HZH_Controls;

namespace TrainTK
{
    public partial class FrmRegisterStep1 : Form
    {
        public FrmRegisterStep1()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private UserModel user;

        private void FrmRegisterStep1_Load(object sender, EventArgs e)
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

        private int getUser(string userName)
        {
            string sql = "select count(*) from user1 WHERE userName = '"+userName+"'";
            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (this.userName.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入用户名！", "信息提示");
                this.pass.Focus();
                this.pass.SelectAll();
                return;
            }
            if (getUser(this.userName.Text.Trim())>0)
            {
                MessageBox.Show("用户名已存在，请重新输入！", "信息提示");
                this.pass.Focus();
                this.pass.SelectAll();
                return;
            }
            if (this.pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "信息提示");
                this.pass.Focus();
                this.pass.SelectAll();
                return;
            }
            
            //判断密码是否符合规则
            if (this.pass.Text.Trim().Length < 6 && System.Text.RegularExpressions.Regex.IsMatch(this.pass.Text.Trim(), @"^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("请输入包含数字和字母且大于6位的密码！", "信息提示");
                this.pass.Focus();
                this.pass.SelectAll();
                return;
            }
            //二次验证密码
            if (this.pass.Text.Trim() != this.passConf.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不符，请再次输入！", "信息提示");
                this.passConf.Focus();
                this.passConf.SelectAll();
                return;
            }
            if (this.textName.Text.Length== 0)
            {
                MessageBox.Show("请输入名字！", "信息提示");
                this.passConf.Focus();
                this.passConf.SelectAll();
                return;
            }

            user.userName = this.userName.Text.Trim();
            user.password = this.pass.Text.Trim();

            if (this.IDNum.Text.Length == 0)
            {
                MessageBox.Show("请输入证件号码！", "信息提示");
                this.passConf.Focus();
                this.passConf.SelectAll();
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(this.cPhoneNum.Text.Trim(), @"(^\d{18}$)|(^\d{15}$)"))
            {
                MessageBox.Show("输入的证件号码不符合规则，请再次输入！", "信息提示");
                this.cPhoneNum.Focus();
                this.cPhoneNum.SelectAll();
                return;
            }
            if (IDType.SelectedIndex == 0)
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if ((control is RadioButton) && (control as RadioButton).Checked)
                    {
                        user.IDType = control.Text;
                    }
                }
            }
            else
            {
                user.IDType = IDType.Text;
            }

            foreach (Control control in groupBox2.Controls)
            {
                if ((control is RadioButton) && (control as RadioButton).Checked)
                {
                    user.sex = control.Text;
                }
            }
            user.Name = this.textName.Text.Trim();
            user.Country = this.Country.Text.Trim();

            if (this.cPhoneNum.Text.Length == 0)
            {
                MessageBox.Show("请输入手机号码！", "信息提示");
                this.cPhoneNum.Focus();
                this.cPhoneNum.SelectAll();
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(this.cPhoneNum.Text.Trim(), @"^[1]+[3,8]+\d{9}$"))
            {
                MessageBox.Show("输入的手机号不符合规则，请再次输入！", "信息提示");
                this.cPhoneNum.Focus();
                this.cPhoneNum.SelectAll();
                return;
            }
            user.IDNumber = this.IDNum.Text.Trim();
            user.phoneNumber = this.cPhoneNum.Text.Trim();
            user.passengerType = this.passengerType.Text.Trim();

            FrmRegisterStep2 step2=new FrmRegisterStep2(user);
            step2.ShowDialog();
        }

        private void btnCancle_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void IDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IDType.SelectedItem.ToString() == "中国居民身份证")
            {
                this.groupBox1.Visible = true;
            }
            else
            {
                this.groupBox1.Visible = false;
            }
        }
    }
}

