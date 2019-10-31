using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using TrainTK;

namespace Demo111
{
    public partial class FrmPersonDetail : Form
    {
        public FrmPersonDetail(string userName)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            this.username = userName;
        }
        //基本信息
        private string username= "hgf";
        //private string Name;
        //private string Sex;
        //private string Country;
        //private string idtype;
        //private string idnum;
        //private string is_stu;


        //联系方式
        private string cphoneNum;
        private string fphoneNum;
        private string Email;
        private string Address;
        private string postCode;


        //获取个人信息
        private string GetInfo(string text)
        {
            string sql = "select " + text + " from user1 where userName='" + username+"'";
            return SqlHelper.ExecuteScalar(sql).ToString();  
        }

        //更新个人联系信息
        private int UpdateInfo(string cphoneNum,string fphoneNum,string email,string address,string postCode)
        {
            string sql = "UPDATE user1 SET usermobile = '"+cphoneNum+"',phonenumber = '"+fphoneNum+"',email = '"+email+"',[address] = '"+address+"',PostCode = '"+postCode+"' WHERE userName='" + username+"'";
            return SqlHelper.ExecuteNonQuery(sql);
        }

        private void frmPersonDetail_Load(object sender, EventArgs e)
        {
            #region 信息加载
            this.userName.Text = username;
            this.name.Text = GetInfo("Name");
            this.sex.Text = GetInfo("sex");
            this.idType.Text = GetInfo("IdType");
            this.country.Text = GetInfo("Country");
            this.idNum.Text = GetInfo("IDnumber");
            this.passengerType.Text = GetInfo("passengerType");
            this.fPhoneNum.Text = GetInfo("phonenumber");
            this.cPhoneNum.Text = GetInfo("usermobile");
            this.email.Text = GetInfo("email");
            this.address.Text = GetInfo("address");
            this.postcode.Text = GetInfo("postcode"); 
            #endregion
        }

        private void btnEdit_BtnClick(object sender, EventArgs e)
        {
            this.cPhoneNum.ReadOnly = false;
            this.fPhoneNum.ReadOnly = false;
            this.address.ReadOnly = false;
            this.email.ReadOnly = false;
            this.postcode.ReadOnly = false;
        }

        //保存修改内容
        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            cphoneNum = this.cPhoneNum.Text;
            fphoneNum = this.fPhoneNum.Text;
            Address = this.address.Text;
            Email = this.email.Text;
            postCode = this.postcode.Text;

            if (UpdateInfo(cphoneNum, fphoneNum, Email, Address, postCode) > 0)
            {
                if (MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.fPhoneNum.Text = GetInfo("phonenumber");
                    this.cPhoneNum.Text = GetInfo("usermobile");
                    this.email.Text = GetInfo("email");
                    this.address.Text = GetInfo("address");
                    this.postcode.Text = GetInfo("postcode");
                }
            }
            else
            {
                MessageBox.Show("修改失败，请重新提交保存！", "提示", MessageBoxButtons.OKCancel);
            }
            
        }
    }
}
