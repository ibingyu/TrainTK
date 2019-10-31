using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;
using Test;

namespace Demo111
{
    public partial class FrmFrequentContacts : Form
    {
        public FrmFrequentContacts(string userName)
        {
            this.StartPosition=FormStartPosition.CenterScreen;
            InitializeComponent();
            personInfo.SizeChanged += personInfo_SizeChanged;
            this.userName = userName;
        }

        private string prompt = "请输入乘客姓名";
        private string userName="hgf";
        private void userNameText_Enter(object sender, EventArgs e)
        {
            //if (userNameText.InputText==prompt)
            //{
            //    this.userNameText.InputText = "";
            //}
        }

        private void userNameText_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameText.InputText))
            {
                this.userNameText.InputText = prompt;
            }
            
        }

        private void FrmFrequentContacts_Load(object sender, EventArgs e)
        {
            this.label1.Focus();
            this.userNameText.InputText = "请输入乘客姓名";
        }



   

        private void userNameText_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.userNameText.InputText==prompt)
            {
                this.userNameText.InputText = "";
            }            
        }

        private void FrmFrequentContacts_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Focus();
        }

        private void query_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void query_MouseEnter(object sender, EventArgs e)
        {
            this.btnQuery.RectColor = Color.SandyBrown;
        }

        private void btnQuery_MouseLeave(object sender, EventArgs e)
        {
            this.btnQuery.RectColor=Color.LightGray;
        }

        
        private void btnQuery_BtnClick(object sender, EventArgs e)
        {
            if (this.userNameText.InputText!= "请输入乘客姓名")
            {
                List<object> lstSource = new List<object>();
                Passenger passenger = new Passenger();
                passenger = PassengerOperation.GetPassenger(userName, this.userNameText.InputText);
                lstSource.Add(passenger);
                var page = new UCPagerControl2();
                page.DataSource = lstSource;
                this.personInfo.Page = page;
                this.personInfo.First();
            }

        }

        private void personInfo_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstColumns=new List<DataGridViewColumnEntity>();
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "PersonID",
                HeadText = "序号",Width = 80,WidthType = SizeType.Absolute
            });
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "PersonName",
                HeadText = "姓名",
                Width = 80,
                WidthType = SizeType.Absolute
            });
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "IDType",
                HeadText = "证件类型",
                Width = 210,
                WidthType = SizeType.Absolute
            });
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "IDNum",
                HeadText = "证件号码",
                Width = 210,
                WidthType = SizeType.Absolute
            });
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "PhoneNum",
                HeadText = "手机／电话",
                Width = 180,
                WidthType = SizeType.Absolute
            });
            lstColumns.Add(new DataGridViewColumnEntity()
            {
                DataField = "PassengerType",
                HeadText = "乘客类型",
                Width = 100,
                WidthType = SizeType.Absolute
            });
            //lstColumns.Add(new DataGridViewColumnEntity()
            //{
            //    DataField = "AddDate",
            //    HeadText = "添加日期",
            //    Width = 80,
            //    WidthType = SizeType.Absolute
            //});
            this.personInfo.Columns = lstColumns;
            this.personInfo.IsShowCheckBox = true;
            List<object> lstSource = new List<object>();
            List<Passenger> passengers = new List<Passenger>();
            passengers = PassengerOperation.getAllPassenger(userName);
            for (int i = 0; i < passengers.Count; i++)
            {
                lstSource.Add(passengers[i]);
            }
            var page = new UCPagerControl2();
            page.DataSource = lstSource;
            this.personInfo.Page = page;
            this.personInfo.First();
        }

        private void personInfo_SizeChanged(object sender, EventArgs e)
        {
            if (this.personInfo.Page != null)
            {
                this.personInfo.Page.PageSize = this.personInfo.ShowCount;
                this.personInfo.DataSource = this.personInfo.Page.GetCurrentSource();
            }
        }

        private void personInfo_RowCustomEvent(object sender, DataGridViewRowCustomEventArgs e)
        {

        }

        private void btnEdit_BtnClick(object sender, EventArgs e)
        {
            if (this.personInfo.SelectRow.IsChecked)
            {
                int rowIndex = 1;
                for (int i = 0; i < this.personInfo.Rows.Count; i++)
                {
                    if (this.personInfo.Rows[i].IsChecked)
                    {
                        rowIndex = i;
                    }
                }
                Passenger passenger = (Passenger)this.personInfo.Page.DataSource[rowIndex];
                
                FrmUpdatePassenger updatePassenger = new FrmUpdatePassenger(userName, passenger.PersonName);
                updatePassenger.ShowDialog();
            }
            else
            {
                MessageBox.Show("只能选择一个联系人！", "提示", MessageBoxButtons.OK);
            }


        }
        private void btnAdd_BtnClick(object sender, EventArgs e)
        {
            FrmAddPassenger addPassenger = new FrmAddPassenger(userName);
            addPassenger.Show();
        }

        private void Delete_BtnClick(object sender, EventArgs e)
        {
            if (this.personInfo.SelectRow.IsChecked)
            {
                int rowIndex = 1;
                for (int i = 0; i < this.personInfo.Rows.Count; i++)
                {
                    if (this.personInfo.Rows[i].IsChecked)
                    {
                        rowIndex = i;
                    }
                }
                Passenger passenger = (Passenger)this.personInfo.Page.DataSource[rowIndex];
                if (PassengerOperation.DeletePassenger(userName,passenger.PersonName)>0)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK);
                    this.personInfo.ReloadSource();
                }
                else
                {
                    MessageBox.Show("删除失败，请再次尝试！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("只能选择一个联系人！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
