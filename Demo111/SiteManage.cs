using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo111;

namespace TrainTK
{
    public partial class SiteManage : Form
    {
        public SiteManage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private List<Site> getAllSite()
        {
            List<Site> sites = new List<Site>();
            string sql = " SELECT * FROM initial WHERE is_Effective= 1";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Site site = new Site();
                #region 获取order
                site.SiteID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                site.SiteName = dt.DefaultView.Table.Rows[i][1].ToString();
                site.SiteFirstAlp = dt.DefaultView.Table.Rows[i][2].ToString();
                site.SiteComplteSp = dt.DefaultView.Table.Rows[i][3].ToString();
                site.is_hot = int.Parse(dt.DefaultView.Table.Rows[i][4].ToString());
                site.is_Effective = int.Parse(dt.DefaultView.Table.Rows[i][5].ToString());
                #endregion

                sites.Add(site);
            }

            return sites;
        }

        private int index;
        private List<Site> querySite(string siteName)
        {
            List<Site> sites = new List<Site>();
            string sql = " SELECT * FROM initial WHERE SiteName='"+siteName+"' AND is_Effective= 1";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            for (int i = 0; i < dt.DefaultView.Table.Rows.Count; i++)
            {
                Site site = new Site();
                #region 获取order
                site.SiteID = int.Parse(dt.DefaultView.Table.Rows[i][0].ToString());
                site.SiteName = dt.DefaultView.Table.Rows[i][1].ToString();
                site.SiteFirstAlp = dt.DefaultView.Table.Rows[i][2].ToString();
                site.SiteComplteSp = dt.DefaultView.Table.Rows[i][3].ToString();
                site.is_hot = int.Parse(dt.DefaultView.Table.Rows[i][4].ToString());
                site.is_Effective = int.Parse(dt.DefaultView.Table.Rows[i][5].ToString());
                #endregion

                sites.Add(site);
            }

            return sites;
        }

        private Site getSite(string siteName)
        {
            string sql = " SELECT * FROM initial WHERE SiteName='" + siteName + "' AND is_Effective= 1";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            Site site = new Site();
            #region 获取order
            site.SiteID = int.Parse(dt.DefaultView.Table.Rows[0][0].ToString());
            site.SiteName = dt.DefaultView.Table.Rows[0][1].ToString();
            site.SiteFirstAlp = dt.DefaultView.Table.Rows[0][2].ToString();
            site.SiteComplteSp = dt.DefaultView.Table.Rows[0][3].ToString();
            site.is_hot = int.Parse(dt.DefaultView.Table.Rows[0][4].ToString());
            site.is_Effective = int.Parse(dt.DefaultView.Table.Rows[0][5].ToString());
            #endregion

            return site;
        }

        private void dgvClear(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }
        private void dgvLoad(List<Site> sites, DataGridView dataGridView)
        {
            for (int i = 0; i < sites.Count-1; i++)
            {
                dataGridView.Rows.Add();
            }
            for (int i = 0; i < sites.Count; i++)
            {
                //dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[1].Value = sites[i].SiteName;
                dataGridView.Rows[i].Cells[2].Value = sites[i].SiteFirstAlp;
                dataGridView.Rows[i].Cells[3].Value = sites[i].SiteComplteSp;
                if (sites[i].is_hot==1)
                {
                    dataGridView.Rows[i].Cells[4].Value = "是";
                }
                else
                {
                    dataGridView.Rows[i].Cells[4].Value = "否";
                }
            }
        }

        private int siteDelete(string siteName)
        {
            string sql = " UPDATE initial SET is_Effective= 0 WHERE SiteName='" + siteName + "'";

            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void SiteManage_Load(object sender, EventArgs e)
        {
            List<Site> sites = getAllSite();
            dgvLoad(sites,this.dgvSite);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Site site=getSite(this.dgvSite.Rows[index].Cells[1].Value.ToString());
            
            UpdateSite update=new UpdateSite(site);
            update.ShowDialog();
            dgvClear(this.dgvSite);
            dgvLoad(getAllSite(),this.dgvSite);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Site> sites = querySite(this.sname.Text);
            dgvClear(this.dgvSite);
            dgvLoad(sites, this.dgvSite);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSite addSite=new AddSite();
            addSite.ShowDialog();
            dgvClear(this.dgvSite);
            dgvLoad(getAllSite(),this.dgvSite);
        }

        private void dgvSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSite.Rows.Count > 0)
                {
                    int rowIndex = dgvSite.CurrentCell.RowIndex;
                    int colIndex = dgvSite.CurrentCell.ColumnIndex;
                    if (colIndex == 0) //第一列
                    {
                        string _selectValue = dgvSite.CurrentCell.EditedFormattedValue.ToString();
                        if (_selectValue == "True")
                        {
                            for (int i = 0; i < dgvSite.Rows.Count; i++)
                            {
                                if (i != rowIndex)
                                {
                                    string otherValue = dgvSite.Rows[i].Cells[0].EditedFormattedValue.ToString();
                                    if (otherValue == "True")
                                    {
                                        ((DataGridViewCheckBoxCell)dgvSite.Rows[i].Cells[0]).Value = false;
                                    }
                                }
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            { }
            if (e.RowIndex > -1)
            {
                if (dgvSite.Columns[e.ColumnIndex].Name == "check")
                {
                    for (int i = 0; i < this.dgvSite.Rows.Count; i++)
                    {
                        if ((bool)dgvSite.Rows[i].Cells["check"].EditedFormattedValue == true)
                        {
                            index = i;
                        }
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (siteDelete(this.dgvSite.Rows[index].Cells[1].Value.ToString()) > 0)
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                List<Site> sites = getAllSite();
                dgvClear(this.dgvSite);
                dgvLoad(sites, dgvSite);
            }
            else
            {
                MessageBox.Show("删除失败，请再次尝试！", "提示", MessageBoxButtons.OK);
            }
        }

    }
}
