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
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            
        }

        public string userName;
        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin asd = new AdminLogin();
            this.Hide();
            DialogResult dr = asd.ShowDialog();
            if (dr==DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.txtuserpwd.PasswordChar = '*';
            this.label5.Text = getsui();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegisterStep1 register=new FrmRegisterStep1();
            register.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string la = this.label5.Text;
            string la1 = this.txtvcode.Text;
            if (this.txtusername.Text == "" && this.txtuserpwd.Text == "")
            {
                MessageBox.Show("请填写登陆名和密码");
                return;
            }
            if (la != la1)
            {
                MessageBox.Show("验证码错误", "提示");
                return;
            }
            string userName = this.txtusername.Text.ToString();
            string userpwd = this.txtuserpwd.Text.ToString();

            string sql = "select * from user1";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            int w = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["userName"].ToString();
                string pwd = dt.Rows[i]["password"].ToString();
                if (userName == name && userpwd == pwd)
                {
                    w++;
                    if (MessageBox.Show("Hello" + name ,"提示", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        string time = System.DateTime.Now.ToString();
                        string sql1 = "insert into userjilv(name,datetimes) values(@userName,@time)";
                        SqlParameter[] sqlParameters =
                        {
                            new SqlParameter("@userName",userName),
                            new SqlParameter("@time",time)  
                        };
                        if (SqlHelper.ExecuteNonQuery(sql1,sqlParameters) > 0)
                        {
                            UserMain main=new UserMain(userName);
                            this.Hide();
                            DialogResult dr=main.ShowDialog();
                            if (dr==DialogResult.Cancel)
                            {
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("登陆失败");
                            return;
                        }
                        this.Text = userName;
                        this.userName = userName;


                    }
                }
            }
            if (w == 0)
            {
                MessageBox.Show("密码或用户名错误!");
            }





        }


        /// <summary>
        /// 验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            this.label5.Text = getsui();
        }

        private string getsui()
        {
            string s = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,,0,1,2,3,4,5,6,7,8,9";
            string[] str = s.Split(',');
            string news = "";
            Random r = new Random();
            for(int i=0;i<4;i++)
            {
                news+=str[r.Next(0,str.Length)];
            }
            return news;
        }


        private void test_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
