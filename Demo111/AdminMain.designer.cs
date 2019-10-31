namespace TrainTK
{
    partial class AdminMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exit = new System.Windows.Forms.ToolStripLabel();
            this.Logout = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.priceManage = new System.Windows.Forms.Button();
            this.btnTrainNum = new System.Windows.Forms.Button();
            this.btnSeat = new System.Windows.Forms.Button();
            this.btnSiteManage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.Logout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(0, 22);
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 22);
            this.Logout.Text = "退出登录";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(416, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "后台管理系统";
            // 
            // priceManage
            // 
            this.priceManage.BackColor = System.Drawing.Color.Wheat;
            this.priceManage.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceManage.Location = new System.Drawing.Point(694, 386);
            this.priceManage.Name = "priceManage";
            this.priceManage.Size = new System.Drawing.Size(159, 72);
            this.priceManage.TabIndex = 9;
            this.priceManage.Text = "票价管理";
            this.priceManage.UseVisualStyleBackColor = false;
            this.priceManage.Click += new System.EventHandler(this.priceManage_Click);
            // 
            // btnTrainNum
            // 
            this.btnTrainNum.BackColor = System.Drawing.Color.Wheat;
            this.btnTrainNum.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrainNum.Location = new System.Drawing.Point(302, 386);
            this.btnTrainNum.Name = "btnTrainNum";
            this.btnTrainNum.Size = new System.Drawing.Size(161, 72);
            this.btnTrainNum.TabIndex = 8;
            this.btnTrainNum.Text = "车次管理";
            this.btnTrainNum.UseVisualStyleBackColor = false;
            this.btnTrainNum.Click += new System.EventHandler(this.btnTrainNum_Click);
            // 
            // btnSeat
            // 
            this.btnSeat.BackColor = System.Drawing.Color.Wheat;
            this.btnSeat.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeat.Location = new System.Drawing.Point(488, 386);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Size = new System.Drawing.Size(176, 72);
            this.btnSeat.TabIndex = 7;
            this.btnSeat.Text = "添加座位";
            this.btnSeat.UseVisualStyleBackColor = false;
            this.btnSeat.Click += new System.EventHandler(this.btnSeat_Click);
            // 
            // btnSiteManage
            // 
            this.btnSiteManage.BackColor = System.Drawing.Color.Wheat;
            this.btnSiteManage.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSiteManage.Location = new System.Drawing.Point(109, 386);
            this.btnSiteManage.Name = "btnSiteManage";
            this.btnSiteManage.Size = new System.Drawing.Size(167, 72);
            this.btnSiteManage.TabIndex = 6;
            this.btnSiteManage.Text = "站点管理";
            this.btnSiteManage.UseVisualStyleBackColor = false;
            this.btnSiteManage.Click += new System.EventHandler(this.btnSiteManage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(876, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "退出登录";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceManage);
            this.Controls.Add(this.btnTrainNum);
            this.Controls.Add(this.btnSeat);
            this.Controls.Add(this.btnSiteManage);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminMain";
            this.Text = "后台管理系统";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel exit;
        private System.Windows.Forms.ToolStripLabel Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button priceManage;
        private System.Windows.Forms.Button btnTrainNum;
        private System.Windows.Forms.Button btnSeat;
        private System.Windows.Forms.Button btnSiteManage;
        private System.Windows.Forms.Button button1;
    }
}