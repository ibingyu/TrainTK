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
    public partial class UpdateSite : Form
    {
        public UpdateSite()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public UpdateSite(Site site)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.site = site;
        }

        private Site site;
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private int updateSite(Site site)
        {
            string sql = "UPDATE initial SET SiteName ='" + site.SiteName + "' ,SiteFirstAlp ='" + site.SiteFirstAlp + "' ,SiteComplteSp='" + site.SiteComplteSp + "' ,is_hot=" + site.is_hot +
                " ,is_Effective=" + site.is_Effective+ "WHERE SiteName='"+site.SiteName+"'";
            return SqlHelper.ExecuteNonQuery(sql);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
  
            site.SiteName = this.siteName.Text;
            site.SiteFirstAlp = this.pinYinMa.Text;
            site.SiteComplteSp = this.pinYin.Text;
            if (this.is_Hot.Text == "是")
            {
                site.is_hot = 1;
            }
            else
            {
                site.is_hot = 0;
            }
            if (updateSite(site) > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改失败，请再次尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSite_Load(object sender, EventArgs e)
        {
            this.siteName.Text = site.SiteName;
            this.pinYinMa.Text = site.SiteFirstAlp;
            this.pinYin.Text = site.SiteComplteSp;
            if (site.is_hot == 1)
            {
                this.is_Hot.Text = "是";
            }
            else
            {
                this.is_Hot.Text = "否";
            }
        }
    }
}
