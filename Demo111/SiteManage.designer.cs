namespace TrainTK
{
    partial class SiteManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSite = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.siteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PinYinMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PinYin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_Hot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnquery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSite
            // 
            this.dgvSite.AllowUserToAddRows = false;
            this.dgvSite.BackgroundColor = System.Drawing.Color.White;
            this.dgvSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.siteName,
            this.PinYinMa,
            this.PinYin,
            this.is_Hot});
            this.dgvSite.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSite.Location = new System.Drawing.Point(52, 172);
            this.dgvSite.Name = "dgvSite";
            this.dgvSite.RowTemplate.Height = 27;
            this.dgvSite.Size = new System.Drawing.Size(515, 507);
            this.dgvSite.TabIndex = 0;
            this.dgvSite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSite_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 50;
            // 
            // siteName
            // 
            this.siteName.HeaderText = "站点名称";
            this.siteName.Name = "siteName";
            this.siteName.Width = 122;
            // 
            // PinYinMa
            // 
            this.PinYinMa.HeaderText = "拼音码";
            this.PinYinMa.Name = "PinYinMa";
            // 
            // PinYin
            // 
            this.PinYin.HeaderText = "拼音码";
            this.PinYin.Name = "PinYin";
            // 
            // is_Hot
            // 
            this.is_Hot.HeaderText = "是否热门";
            this.is_Hot.Name = "is_Hot";
            // 
            // sname
            // 
            this.sname.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sname.Location = new System.Drawing.Point(202, 36);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(182, 31);
            this.sname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "站点名称";
            // 
            // btnquery
            // 
            this.btnquery.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnquery.Location = new System.Drawing.Point(427, 36);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(100, 35);
            this.btnquery.TabIndex = 3;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(264, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(101, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(427, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SiteManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 724);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.dgvSite);
            this.Name = "SiteManage";
            this.Text = "站点管理";
            this.Load += new System.EventHandler(this.SiteManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSite;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PinYinMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PinYin;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_Hot;
        private System.Windows.Forms.Button btnDelete;
    }
}