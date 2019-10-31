using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Utility;
using TrainTK;

namespace Demo111
{
    public partial class FrmChangePass : Form
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }
        public FrmChangePass(string userName)
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
            this.userName = userName;
        }
        /// <summary>
        /// 验证码
        /// </summary>
        public string code;

        public string userName="hgf";
        private void btnGetEmailCode_Click(object sender, EventArgs e)
        {
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址。
            mailMessage.From = new MailAddress("912872729@qq.com");
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress("m15662042572@163.com"));
            //邮件标题。
            mailMessage.Subject = "这是你的验证码";
            //随机验证码
            RandomOperate valCode=new RandomOperate();
            string verificationcode = valCode.GenerateCheckCode(4);
            //邮件内容。
            mailMessage.Body = "你的验证码是" + verificationcode;
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            client.Credentials = new NetworkCredential("912872729", "qxvqjuyizimwbejd");
            //发送
            client.Send(mailMessage);
            MessageBox.Show("发送成功！", "提示");
            code = verificationcode;
        }

        //确认修改
        private void btnOk_BtnClick(object sender, EventArgs e)
        {

            #region 数据验证
            //确认原密码是否为空
            if (this.oldPass.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入原密码！", "信息提示");
                this.oldPass.Focus();
                this.oldPass.SelectAll();
                return;
            }
            //确认原密码是否正确
            if (this.oldPass.Text.Trim()==getPsw(userName))
            {
                MessageBox.Show("原密码错误！", "信息提示");
                this.oldPass.Focus();
                this.oldPass.SelectAll();
                return;
            }
            //判断新密码是否符合规则
            if (this.newPass.Text.Trim().Length < 6&& System.Text.RegularExpressions.Regex.IsMatch(this.newPass.Text.Trim(), @"^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("请输入包含数字和字母且大于6位的密码！", "信息提示");
                this.oldPass.Focus();
                this.oldPass.SelectAll();
                return;
            }
            //二次验证密码
            if (this.newPass.Text.Trim()!=this.passConf.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不符，请再次输入！", "信息提示");
                this.oldPass.Focus();
                this.oldPass.SelectAll();
                return;
            }
            //判断验证码是否正确
            if (this.verificationCode.Text.Trim()==code)
            {
                MessageBox.Show("验证码错误！", "信息提示");
                this.oldPass.Focus();
                this.oldPass.SelectAll();
                return;
            }

            #endregion

            #region 数据更新并响应

            if (updatePsw(userName, this.newPass.Text.Trim())>0)
            {
                MessageBox.Show("密码修改成功！", "信息提示");
            }
            

            #endregion


        }

        //获取密码
        public string getPsw(string userName)
        {
            string sql = "select password from user1 where userName='" + userName+"'";
            try
            {
                return SqlHelper.ExecuteScalar(sql).ToString();
            }
            catch (Exception e)
            {
                throw new Exception("错误信息:" + e.Message);
            }
        }

        //更改密码
        public int updatePsw(string userName,string newPsw)
        {
            string sql = "update user1 set password ='" + newPsw + "' where userName='" + userName+"'";
            try
            {
                return SqlHelper.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                throw new Exception("错误信息:"+e.Message);
            }
        }

        private void btnClose_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
