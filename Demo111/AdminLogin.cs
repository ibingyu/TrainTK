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
    //管理员登录
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Amuser = this.txtname.Text.ToString();
            string Ampwd = this.txtpwd.Text.ToString();

            string sql = "select * from AM";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            int w = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["amname"].ToString();
                string pwd = dt.Rows[i]["ampwd"].ToString();
                if (name == Amuser && Ampwd == pwd)
                {
                    w++;
                    if (MessageBox.Show("欢迎进入后台管理系统！", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        AdminMain adminMain=new AdminMain();
                        this.Hide();
                        DialogResult dr=adminMain.ShowDialog();
                        if (dr == DialogResult.Cancel)
                        {
                            this.Show();
                        }
                    }
                }
            }
            if (w == 0)
            {
                MessageBox.Show("密码或用户名错误!");
            }
        }

        private void enrol_Load(object sender, EventArgs e)
        {

            this.txtpwd.PasswordChar = '*';
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
