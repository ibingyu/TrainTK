using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;


namespace TrainTK
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }


        private void UserManager_Load(object sender, EventArgs e)
        {
            string sql = "select * from user1";

            string sql1 = "select count(*) from user1";
            LoadPage(sql,sql1);
        }

        private void BtnLoadPage()
        {
            DataTable dt=this.GetGridDataSoure;     //数据源
            int beginRecord;    //开始指针
            int endRecord;      //结束指针


            userData.DataSource = dt;
            lbCurrentPageIndex.Text = this.CurrentPageIndex.ToString();
        }

        private void LoadPage(string sql1,string sql2)
        {
            DataTable dt = SqlHelper.ExecuteDataTable(sql1);

            this.PageSize = 16;
            //int CurrentPageIndex = 1;
            //this.CurrentPageIndex = CurrentPageIndex;
            int CurrentPageIndex = this.CurrentPageIndex == 0 ? this.CurrentPageIndex += 1 : this.CurrentPageIndex += 0;
            this.GetGridDataSoure = dt;
            int totalCount = SqlHelper.ExecuteScalar(sql2).ToInt();
            this.DataSoureCount = totalCount;
            int totalPageNum = (totalCount % this.PageSize) > 1 ? ((totalCount / this.PageSize) + 1) : (totalCount / this.PageSize);
            this.gdvColHeaderText = new List<string> { "", "", "", "", "", "", "", "", "", "", "", "", "" };
            this.PageCount = totalPageNum;
            this.DataBaind();
        }
        #region 控件属性
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int DataSoureCount
        {
            get;
            set;
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get;
            set;
        }

        /// <summary>
        /// 当前记录行
        /// </summary>
        public int CurrentPageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 取得或者设置数据控件的自定义列名
        /// </summary>
        public List<string> gdvColHeaderText
        {
            get;
            set;
        }

        /// <summary>
        /// 取得或者设置绑定控件的数据集
        /// </summary>
        public DataTable GetGridDataSoure
        {
            get;
            set;
        }
        #endregion

        #region 数据绑定
        /// <summary>
        /// 绑定数据到控件中
        /// </summary>
        public void DataBaind()
        {
            userData.DataSource = GetGridDataSoure;
            lbSoureCount.Text = DataSoureCount.ToString();
            lbPageCount.Text = this.PageCount.ToString();
            lbPageSize.Text = this.PageSize.ToString();
            lbCurrentPageIndex.Text = this.CurrentPageIndex.ToString();
            DataGridViewStyle(userData);
            if (gdvColHeaderText != null)
            {
                for (int i = 0; i < gdvColHeaderText.Count; i++)
                {
                    if (userData.Columns.Count >= i)
                    {
                        userData.Columns[i].HeaderText = gdvColHeaderText[i];
                    }
                }
            }

            if (IsVisibleFirstCom)
            {
                userData.Columns[0].Visible = false;
            }
        } 
        #endregion

        

        #region DGV样式
        //新增一列填充空余单元格
        bool tc_column = true;
        /// <summary>
        /// DataGridView样式处理
        /// </summary>
        /// <param name="gridview">DataGridView控件</param>
        /// <param name="tc_column">是否需要添加列</param>
        public void DataGridViewStyle(DataGridView gridview)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            gridview.AllowUserToAddRows = false;
            gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            Form f = new System.Windows.Forms.Form();
            gridview.AutoGenerateColumns = false;


            gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.EnableHeadersVisualStyles = false;
            gridview.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            gridview.ReadOnly = true;
            //gridview.RowHeadersVisible = false;
            gridview.RowTemplate.Height = 28;
            gridview.RowTemplate.ReadOnly = false;
            //标题文字居中
            gridview.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            //gridview.RowHeadersVisible = false;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridview.ColumnHeadersHeight = 30;

            //设置选择单元模式
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (tc_column)
            {
                //设置默认填充列自动填充
                DataGridViewTextBoxColumn TextBoxColumn = new DataGridViewTextBoxColumn();
                TextBoxColumn.Name = "";
                TextBoxColumn.HeaderText = "";
                gridview.Columns.Insert(gridview.ColumnCount, TextBoxColumn);
                TextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //取消该列排序
                TextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                tc_column = false;
            }

            //点击立即进入编辑模式
            gridview.EditMode = DataGridViewEditMode.EditOnEnter;
        } 
        #endregion


        #region 分页按钮事件

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            //按钮状态
            btnFirstPage.Enabled = false;
            btnLastPage.Enabled = true;
            btnNextPage.Enabled = true;
            btnPrevPage.Enabled = false;
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex >= 2)
            {
                btnPrevPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnNextPage.Enabled = true;
                btnPrevPage.Enabled = true;
                this.CurrentPageIndex -= 1;
                PageChange_Click(sender, e);
            }
            else
            {
                btnPrevPage.Enabled = false;
                btnFirstPage.Enabled = false;
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.PageCount)
            {
                btnFirstPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnNextPage.Enabled = true;
                btnPrevPage.Enabled = true;
                this.CurrentPageIndex += 1;
                PageChange_Click(sender, e);
            }
            else
            {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
            }
        }

    
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.PageCount)
            {
                btnLastPage.Enabled = false;
                this.CurrentPageIndex = PageCount;
                PageChange_Click(sender, e);
                btnFirstPage.Enabled = true;
                btnNextPage.Enabled = false;
                btnPrevPage.Enabled = true;
            }
            else
            {
                btnLastPage.Enabled = false;
                btnNextPage.Enabled = false;
            }
        }


        #endregion

      

        #region 控件事件
        /// <summary>
        /// 页改变的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void PageChange(object sender, EventArgs e);

        /// <summary>
        /// 页改变的委托事件
        /// </summary>
        public event EventHandler PageChange_Click;

        /// <summary>
        /// 点击行的事件
        /// </summary>
        public delegate void clickRow();

        /// <summary>
        /// 点击行的委托事件
        /// </summary>
        public event EventHandler dgvRows_Click;

        /// <summary>
        /// 单一值
        /// </summary>
        public string singleValue
        {
            get;
            set;
        }

        /// <summary>
        /// 多值
        /// </summary>
        public string manyValue
        {
            get;
            set;
        }

        /// <summary>
        /// 设置需要取的单一值
        /// </summary>
        public string setSingleValue
        {
            get;
            set;
        }

        /// <summary>
        /// 设置需要取的多值
        /// </summary>
        public string setManyValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否隐藏首列的值
        /// </summary>
        public bool IsVisibleFirstCom
        {
            get;
            set;
        }

        /// <summary>
        /// 双击单元格事件发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            //if (!string.IsNullOrEmpty(setSingleValue))
            //{
            //    singleValue = userData.Rows[e.RowIndex].Cells[setSingleValue].Value.ToString();
            //}
            //else
            //{
            //    string[] keyItem = setManyValue.Split(',');
            //    string Values = string.Empty;
            //    foreach (string s in keyItem)
            //    {
            //        Values += userData.Rows[e.RowIndex].Cells[s].Value.ToString() + ",";
            //    }
            //    Values = Values.Remove(Values.LastIndexOf(','));
            //    manyValue = Values;
            //}
            //dgvRows_Click(sender, e);
            userName.Text = userData.Rows[e.RowIndex].Cells[1].Value.ToString();
            userPwd.Text= userData.Rows[e.RowIndex].Cells[2].Value.ToString();
            name.Text = userData.Rows[e.RowIndex].Cells[3].Value.ToString();
            telNum.Text = userData.Rows[e.RowIndex].Cells[7].Value.ToString();
        }


        /// <summary>
        /// 单击单元格事件发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex <= -1) return;
        //    if (!string.IsNullOrEmpty(setSingleValue))
        //    {
        //        singleValue = userData.Rows[e.RowIndex].Cells[setSingleValue].Value.ToString();
        //    }
        //    else
        //    {
        //        string[] keyItem = setManyValue.Split(',');
        //        string Values = string.Empty;
        //        foreach (string s in keyItem)
        //        {
        //            Values += userData.Rows[e.RowIndex].Cells[s].Value.ToString() + ",";
        //        }
        //        manyValue = Values.Remove(Values.LastIndexOf(','));
        //    }
        //    dgvRows_Click(sender, e);
        //} 
        #endregion

        private void userQuery_Click(object sender, EventArgs e)
        {
            string IdentityCard = IDNumber.Text;
            string sql = "select * from user1 where IDnumber=@IdentityCard";
            DataTable dt = SqlHelper.ExecuteDataTable(sql, new SqlParameter("@IdentityCard", IdentityCard));
            this.PageSize = 16;
            int CurrentPageIndex = this.CurrentPageIndex == 0 ? this.CurrentPageIndex += 1 : this.CurrentPageIndex += 0;
            this.CurrentPageIndex = CurrentPageIndex;
            this.GetGridDataSoure = dt;
            int totalCount = SqlHelper.ExecuteNonQuery(sql);
            this.DataSoureCount = totalCount;
            int totalPageNum = (totalCount % this.PageSize) > 1 ? ((totalCount / this.PageSize) + 1) : (totalCount / this.PageSize);
            this.gdvColHeaderText = new List<string> { "", "", "", "", "", "", "", "", "", "", "", "", "" };
            this.PageCount = totalPageNum;
            lbSoureCount.Text = totalCount.ToString();
            lbCurrentPageIndex.Text = CurrentPageIndex.ToString();
            lbPageCount.Text = this.PageSize.ToString();
            lbPageCount.Text = totalPageNum.ToString();
            //this.setSingleValue = "fItemID";
            this.IsVisibleFirstCom = true;
            this.DataBaind();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string userName = this.userName.Text;
            string userPwd = this.userPwd.Text;
            string telNum = this.telNum.Text;
            string IdentityCard = this.IDNumber.Text;
            string sql = "update user1 set userName=@userName,password=@userPwd,phonenumber=@telNum where IDnumber=@IdentityCard";
            SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@userName",userName),
                    new SqlParameter("@userPwd",userPwd),
                    new SqlParameter("@telNum",telNum),
                 };
            if (SqlHelper.ExecuteNonQuery(sql, sqlParameters) > 0)
            {
                MessageBox.Show("修改成功");
                string sql1 = "select * from user1 where IDnumber=@IdentityCard";
                DataTable dt = SqlHelper.ExecuteDataTable(sql1, new SqlParameter("@IdentityCard", IdentityCard));
                this.PageSize = 15;
                int CurrentPageIndex = this.CurrentPageIndex == 0 ? this.CurrentPageIndex += 1 : this.CurrentPageIndex += 0;
                this.CurrentPageIndex = CurrentPageIndex;
                this.GetGridDataSoure = dt;
                int totalCount = SqlHelper.ExecuteNonQuery(sql);
                this.DataSoureCount = totalCount;
                int totalPageNum = (totalCount % this.PageSize) > 1 ? ((totalCount / this.PageSize) + 1) : (totalCount / this.PageSize);
                this.gdvColHeaderText = new List<string> { "", "", "", "", "", "", "", "", "", "", "", "", "" };
                this.PageCount = totalPageNum;
                //this.setSingleValue = "fItemID";
                this.IsVisibleFirstCom = true;
                this.DataBaind();

            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
