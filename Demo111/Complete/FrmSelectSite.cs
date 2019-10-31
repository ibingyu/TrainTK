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
using Demo111;

namespace TrainTK
{
    public partial class FrmSelectSite : Form
    {
        public FrmSelectSite()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        //按钮名称
        public string btnSite;
        public FrmSelectSite(string btnName)
        {
            btnSite = btnName;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public delegate void ReBindDataSouce(ComboBox cbBox, DataTable dt);

        public static void BindDataSouce(ComboBox cbBox, DataTable dt)
        {
            try
            {
                cbBox.BeginUpdate();

                // make sure change it to false, or there will be exception if the droppedDownList is empty  
                cbBox.DroppedDown = false;

                string oldText = cbBox.Text;

                cbBox.DataSource = dt.DefaultView;
                cbBox.DisplayMember = dt.Columns[0].ColumnName;

                // set the text, so user can input continuely  
                cbBox.Text = oldText;

                // set the cursor at the end of the text  
                cbBox.Focus();
                cbBox.Select(oldText.Length, oldText.Length);

                // do not drop down if it is empty, or there will be exception  
                if (cbBox.Items.Count > 0)
                {
                    cbBox.DroppedDown = true;
                }

                cbBox.Cursor = Cursors.Default;
                cbBox.DroppedDown = true;
            }
            catch (Exception ex)
            {
                //statusLabel.Text = ex.Message;  
            }
            finally
            {
                cbBox.EndUpdate();
            }
        }

        private void FrmSelectSite_Load(object sender, EventArgs e)
        {
            this.SiteClassify.ReadOnly = true;
            //string sql = "select SiteName from initial where SiteFirstAlp like 'z%'";

            //DataTable dt = SqlHelper.ExecuteDataTable(sql);

            for (int i = 0; i < 6; i++)
            {
                this.SiteClassify.Columns.Add("", "");
            }

            for (int i = 0; i < 5; i++)
            {
                this.SiteClassify.Rows.Add();
            }

            //SiteClassify.Rows[0].HeaderCell.Value = "A";
            //SiteClassify.Rows[1].HeaderCell.Value = "B";
            //SiteClassify.Rows[2].HeaderCell.Value = "C";
            //SiteClassify.Rows[3].HeaderCell.Value = "D";
            //SiteClassify.Rows[4].HeaderCell.Value = "E";
            SiteClassify.Columns[0].HeaderText = "热门";
            SiteClassify.Columns[1].HeaderText = "ABCDE";
            SiteClassify.Columns[2].HeaderText = "FGHIJ";
            SiteClassify.Columns[3].HeaderText = "KLMNO";
            SiteClassify.Columns[4].HeaderText = "PQRST";
            SiteClassify.Columns[5].HeaderText = "UVWXYZ";
        }

        private void SiteSelect_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SiteSelect_TextUpdate(object sender, EventArgs e)
        {
            string abbr = SiteSelect.Text.Trim().ToLower();
            string sql = "select SiteName from initial where SiteFirstAlp like '"+@abbr+"%'";

            DataTable dt = SqlHelper.ExecuteDataTable(sql,new SqlParameter("@abbr",abbr));
            DataSet ds = dt.DataSet;
            this.SiteSelect.BeginInvoke(new ReBindDataSouce(BindDataSouce), SiteSelect, dt);
        }

        //站点名称数据加载
        public void GetSiteOfInitial(string initial,int position,int index)
        {
            string sql = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE '"+initial.ToLower()+"%'";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            if (index==5)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (j > 5)
                    {
                        this.SiteClassify.Columns.Add("", "");
                        this.SiteClassify.Rows[position].Cells[j].Value = dt.Rows[j][0].ToString();
                    }
                    else
                    {
                        this.SiteClassify.Rows[position].Cells[j].Value = dt.Rows[j][0].ToString();
                    }
                }

            }
            else
            {
                if (position==5)
                {
                    for (int i = 0; i < this.SiteClassify.ColumnCount; i++)
                    {
                        this.SiteClassify.Rows[position].Cells[i].Value = "";
                    }
                }
                else
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (j > 5)
                        {
                            this.SiteClassify.Columns.Add("", "");
                            this.SiteClassify.Rows[position].Cells[j].Value = dt.Rows[j][0].ToString();
                        }
                        else
                        {
                            this.SiteClassify.Rows[position].Cells[j].Value = dt.Rows[j][0].ToString();
                        }
                    }
                }
   
            }
            
        }

        //清空所有数据
        public void Clear()
        {
            for (int i = 0; i < this.SiteClassify.ColumnCount; i++)
            {
                for (int j = 0; j < this.SiteClassify.RowCount; j++)
                {
                    this.SiteClassify.Rows[j].Cells[i].Value = null;
                }               
            }
        }

        //绑定站点数据
        public void BindSiteData(int index)
        {
            Clear();
            char[] initial = this.SiteClassify.Columns[index].HeaderText.ToCharArray();
            if (index==0)
            {
                for (int i = 0; i < initial.Length; i++)
                {
                    initial[i] = ' ';
                }
            }
            for (int i = 0; i < initial.Length; i++)
            {
                SiteClassify.Rows[i].HeaderCell.Value = initial[i].ToString();
            }
            for (int i = 0; i < SiteClassify.RowCount; i++)
            {
                //常规站点
                if (index>0)
                {
                    string rowHeaderCell = SiteClassify.Rows[i].HeaderCell.Value.ToString();
                    GetSiteOfInitial(rowHeaderCell, i, index);
                }
                //热门站点
                else
                {
                    string sql = "SELECT SiteName FROM initial WHERE is_hot=1";
                    DataTable dt = SqlHelper.ExecuteDataTable(sql);
                    int m = 0;
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            if (m>dt.Rows.Count-1)
                            {
                              break;
                            }
                            this.SiteClassify.Rows[j].Cells[k].Value = dt.Rows[m][0].ToString();      
                            m += 1;
                        }
                    }
                }
                


            }
        }

        private void SiteClassify_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index=e.ColumnIndex;
            if (index == 0)
            {
               
                SiteClassify.Rows[0].HeaderCell.Value = "";
                SiteClassify.Rows[1].HeaderCell.Value = "";
                SiteClassify.Rows[2].HeaderCell.Value = "";
                SiteClassify.Rows[3].HeaderCell.Value = "";
                SiteClassify.Rows[4].HeaderCell.Value = "";
                SiteClassify.Rows[5].HeaderCell.Value = "";
                BindSiteData(index);
            }
            else
            {
                BindSiteData(index);
            }

            #region 加载站点名称数据

            //switch (rowHeaderCell)
            //{
            //    case "U":
            //        string sqlU = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'u%'";
            //        DataTable dtU = SqlHelper.ExecuteDataTable(sqlU);

            //        for (int j = 0; j < dtU.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtU.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtU.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    case "V":
            //        string sqlV = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'v%'";
            //        DataTable dtV = SqlHelper.ExecuteDataTable(sqlV);

            //        for (int j = 0; j < dtV.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtV.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtV.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    case "W":
            //        string sqlZ = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'z%'";
            //        DataTable dtZ = SqlHelper.ExecuteDataTable(sqlZ);

            //        for (int j = 0; j < dtZ.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    case "X":
            //        string sqlZ = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'z%'";
            //        DataTable dtZ = SqlHelper.ExecuteDataTable(sqlZ);

            //        for (int j = 0; j < dtZ.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    case "Y":
            //        string sqlZ = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'z%'";
            //        DataTable dtZ = SqlHelper.ExecuteDataTable(sqlZ);

            //        for (int j = 0; j < dtZ.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    case "Z":
            //        string sqlZ = "SELECT SiteName FROM initial WHERE SiteFirstAlp LIKE 'z%'";
            //        DataTable dtZ = SqlHelper.ExecuteDataTable(sqlZ);

            //        for (int j = 0; j < dtZ.Rows.Count; j++)
            //        {
            //            if (j > 5)
            //            {
            //                this.SiteClassify.Columns.Add("", "");
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //            else
            //            {
            //                this.SiteClassify.Rows[5].Cells[j].Value = dtZ.Rows[j][0].ToString();
            //            }
            //        }
            //        break;
            //    default:
            //        break;
            //}

            #endregion
        }



        private void SiteClassify_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentColumn = e.ColumnIndex;
            int currentRow = e.RowIndex;
            string cellContent = this.SiteClassify.Rows[currentRow].Cells[currentColumn].Value.ToString();
            if (btnSite== "GetDepSite")
            {
                TicketQuery.depSite = cellContent;
            }
            else if (btnSite== "GetDestSite")
            {
                TicketQuery.destSite = cellContent;
            }
            {
                
            }
            this.Close();
        }

        private void querySite_Click(object sender, EventArgs e)
        {
            if (btnSite == "GetDepSite")
            {
                TicketQuery.depSite = SiteSelect.Text;
            }
            else if (btnSite == "GetDestSite")
            {
                TicketQuery.destSite = SiteSelect.Text;
            }
            this.Close();
        }
    }
}
