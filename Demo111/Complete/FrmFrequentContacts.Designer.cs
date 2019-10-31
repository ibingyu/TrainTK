namespace Demo111
{
    partial class FrmFrequentContacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameText = new HZH_Controls.Controls.UCTextBoxEx();
            this.btnQuery = new HZH_Controls.Controls.UCBtnExt();
            this.personInfo = new HZH_Controls.Controls.UCDataGridView();
            this.btnEdit = new HZH_Controls.Controls.UCBtnExt();
            this.btnAdd = new HZH_Controls.Controls.UCBtnExt();
            this.Delete = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.Color.White;
            this.userNameText.ConerRadius = 5;
            this.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameText.DecLength = 2;
            this.userNameText.FillColor = System.Drawing.Color.Empty;
            this.userNameText.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.userNameText.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.userNameText.InputText = "";
            this.userNameText.InputType = HZH_Controls.TextInputType.NotControl;
            this.userNameText.IsFocusColor = true;
            this.userNameText.IsRadius = true;
            this.userNameText.IsShowClearBtn = true;
            this.userNameText.IsShowKeyboard = false;
            this.userNameText.IsShowRect = true;
            this.userNameText.IsShowSearchBtn = false;
            this.userNameText.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.userNameText.Location = new System.Drawing.Point(69, 30);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameText.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.userNameText.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.userNameText.Name = "userNameText";
            this.userNameText.Padding = new System.Windows.Forms.Padding(5);
            this.userNameText.PromptColor = System.Drawing.Color.Gray;
            this.userNameText.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameText.PromptText = "";
            this.userNameText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.userNameText.RectWidth = 1;
            this.userNameText.RegexPattern = "";
            this.userNameText.Size = new System.Drawing.Size(235, 38);
            this.userNameText.TabIndex = 2;
            this.userNameText.Leave += new System.EventHandler(this.userNameText_Leave);
            this.userNameText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userNameText_MouseDown);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Info;
            this.btnQuery.BtnBackColor = System.Drawing.SystemColors.Info;
            this.btnQuery.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.BtnForeColor = System.Drawing.Color.Black;
            this.btnQuery.BtnText = "查询";
            this.btnQuery.ConerRadius = 12;
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.FillColor = System.Drawing.Color.White;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnQuery.ForeColor = System.Drawing.Color.Black;
            this.btnQuery.IsRadius = true;
            this.btnQuery.IsShowRect = true;
            this.btnQuery.IsShowTips = false;
            this.btnQuery.Location = new System.Drawing.Point(344, 30);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RectColor = System.Drawing.Color.NavajoWhite;
            this.btnQuery.RectWidth = 1;
            this.btnQuery.Size = new System.Drawing.Size(129, 38);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.TabStop = false;
            this.btnQuery.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnQuery.TipsText = "";
            this.btnQuery.BtnClick += new System.EventHandler(this.btnQuery_BtnClick);
            this.btnQuery.MouseEnter += new System.EventHandler(this.query_MouseEnter);
            this.btnQuery.MouseLeave += new System.EventHandler(this.btnQuery_MouseLeave);
            // 
            // personInfo
            // 
            this.personInfo.AutoRowsScroll = true;
            this.personInfo.BackColor = System.Drawing.Color.White;
            this.personInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personInfo.Columns = null;
            this.personInfo.DataSource = null;
            this.personInfo.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.personInfo.HeadHeight = 40;
            this.personInfo.HeadPadingLeft = 0;
            this.personInfo.HeadTextColor = System.Drawing.Color.Black;
            this.personInfo.IsCloseAutoHeight = false;
            this.personInfo.IsShowCheckBox = false;
            this.personInfo.IsShowHead = true;
            this.personInfo.Location = new System.Drawing.Point(69, 76);
            this.personInfo.Name = "personInfo";
            this.personInfo.Page = null;
            this.personInfo.RowHeight = 40;
            this.personInfo.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.personInfo.Size = new System.Drawing.Size(1200, 650);
            this.personInfo.TabIndex = 3;
            this.personInfo.RowCustomEvent += new HZH_Controls.Controls.DataGridViewRowCustomEventHandler(this.personInfo_RowCustomEvent);
            this.personInfo.Load += new System.EventHandler(this.personInfo_Load);
            this.personInfo.SizeChanged += new System.EventHandler(this.personInfo_SizeChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.BtnBackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.BtnForeColor = System.Drawing.Color.Black;
            this.btnEdit.BtnText = "修改";
            this.btnEdit.ConerRadius = 12;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.IsRadius = true;
            this.btnEdit.IsShowRect = true;
            this.btnEdit.IsShowTips = false;
            this.btnEdit.Location = new System.Drawing.Point(513, 30);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.NavajoWhite;
            this.btnEdit.RectWidth = 1;
            this.btnEdit.Size = new System.Drawing.Size(129, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TabStop = false;
            this.btnEdit.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnEdit.TipsText = "";
            this.btnEdit.BtnClick += new System.EventHandler(this.btnEdit_BtnClick);
            this.btnEdit.MouseEnter += new System.EventHandler(this.query_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnQuery_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.BtnBackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.BtnForeColor = System.Drawing.Color.Black;
            this.btnAdd.BtnText = "添加";
            this.btnAdd.ConerRadius = 12;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IsRadius = true;
            this.btnAdd.IsShowRect = true;
            this.btnAdd.IsShowTips = false;
            this.btnAdd.Location = new System.Drawing.Point(670, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.NavajoWhite;
            this.btnAdd.RectWidth = 1;
            this.btnAdd.Size = new System.Drawing.Size(129, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAdd.TipsText = "";
            this.btnAdd.BtnClick += new System.EventHandler(this.btnAdd_BtnClick);
            this.btnAdd.MouseEnter += new System.EventHandler(this.query_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnQuery_MouseLeave);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Delete.BtnBackColor = System.Drawing.SystemColors.Info;
            this.Delete.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delete.BtnForeColor = System.Drawing.Color.Black;
            this.Delete.BtnText = "删除";
            this.Delete.ConerRadius = 12;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FillColor = System.Drawing.Color.White;
            this.Delete.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.IsRadius = true;
            this.Delete.IsShowRect = true;
            this.Delete.IsShowTips = false;
            this.Delete.Location = new System.Drawing.Point(824, 30);
            this.Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Delete.Name = "Delete";
            this.Delete.RectColor = System.Drawing.Color.NavajoWhite;
            this.Delete.RectWidth = 1;
            this.Delete.Size = new System.Drawing.Size(129, 38);
            this.Delete.TabIndex = 1;
            this.Delete.TabStop = false;
            this.Delete.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Delete.TipsText = "";
            this.Delete.BtnClick += new System.EventHandler(this.Delete_BtnClick);
            this.Delete.MouseEnter += new System.EventHandler(this.query_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.btnQuery_MouseLeave);
            // 
            // FrmFrequentContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1332, 753);
            this.Controls.Add(this.personInfo);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnQuery);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmFrequentContacts";
            this.Text = "常用联系人";
            this.Load += new System.EventHandler(this.FrmFrequentContacts_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmFrequentContacts_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCBtnExt btnQuery;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCTextBoxEx userNameText;
        private HZH_Controls.Controls.UCDataGridView personInfo;
        private HZH_Controls.Controls.UCBtnExt btnEdit;
        private HZH_Controls.Controls.UCBtnExt btnAdd;
        private HZH_Controls.Controls.UCBtnExt Delete;
    }
}