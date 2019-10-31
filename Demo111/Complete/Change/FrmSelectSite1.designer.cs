namespace TrainTK
{
    partial class FrmSelectSite1
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
            this.SiteClassify = new System.Windows.Forms.DataGridView();
            this.querySite = new System.Windows.Forms.Button();
            this.SiteSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SiteClassify)).BeginInit();
            this.SuspendLayout();
            // 
            // SiteClassify
            // 
            this.SiteClassify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SiteClassify.Location = new System.Drawing.Point(46, 67);
            this.SiteClassify.Name = "SiteClassify";
            this.SiteClassify.ReadOnly = true;
            this.SiteClassify.RowTemplate.Height = 27;
            this.SiteClassify.Size = new System.Drawing.Size(850, 400);
            this.SiteClassify.TabIndex = 0;
            this.SiteClassify.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SiteClassify_CellDoubleClick);
            this.SiteClassify.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SiteClassify_ColumnHeaderMouseClick);
            // 
            // querySite
            // 
            this.querySite.Location = new System.Drawing.Point(186, 21);
            this.querySite.Name = "querySite";
            this.querySite.Size = new System.Drawing.Size(80, 30);
            this.querySite.TabIndex = 2;
            this.querySite.Text = "选择";
            this.querySite.UseVisualStyleBackColor = true;
            this.querySite.Click += new System.EventHandler(this.querySite_Click);
            // 
            // SiteSelect
            // 
            this.SiteSelect.FormattingEnabled = true;
            this.SiteSelect.Location = new System.Drawing.Point(46, 26);
            this.SiteSelect.Name = "SiteSelect";
            this.SiteSelect.Size = new System.Drawing.Size(120, 23);
            this.SiteSelect.TabIndex = 3;
            this.SiteSelect.TextUpdate += new System.EventHandler(this.SiteSelect_TextUpdate);
            this.SiteSelect.TextChanged += new System.EventHandler(this.SiteSelect_TextChanged);
            // 
            // FrmSelectSite1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.SiteSelect);
            this.Controls.Add(this.querySite);
            this.Controls.Add(this.SiteClassify);
            this.Name = "FrmSelectSite1";
            this.Text = "站点选择";
            this.Load += new System.EventHandler(this.FrmSelectSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SiteClassify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SiteClassify;
        private System.Windows.Forms.Button querySite;
        private System.Windows.Forms.ComboBox SiteSelect;
    }
}