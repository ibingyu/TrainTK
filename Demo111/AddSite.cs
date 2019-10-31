using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTK;

namespace Demo111
{
    public partial class AddSite : Form
    {
        public AddSite()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }



        private void AddSite_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int addSite(Site site)
        {
            string sql = "INSERT INTO initial(SiteName,SiteFirstAlp,SiteComplteSp,is_hot,is_Effective ) VALUES('" + site.SiteName + "','" + site.SiteFirstAlp + "','" + site.SiteComplteSp + "'," + site.is_hot + "," + " 1)";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private int updateSiteStat(Site site)
        {
            string sql = "UPDATE initial SET is_Effective= 1 where SiteName=" + site.SiteName;
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private int getSite(Site site)
        {
            string sql = "SELECT COUNT(*) FROM initial WHERE SiteName='"+site.SiteName+"'";
            return int.Parse(SqlHelper.ExecuteScalar(sql).ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Site site=new Site();
            site.SiteName = this.siteName.Text;
            site.SiteFirstAlp = this.pinYinMa.Text;
            site.SiteComplteSp = this.pinYin.Text;
            if (this.is_Hot.Text=="是")
            {
                site.is_hot = 1;
            }
            else
            {
                site.is_hot = 0;
            }
            site.is_Effective = 1;
            if (getSite(site)>0)
            {
                if (updateSiteStat(site) > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (addSite(site) > 0)
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
