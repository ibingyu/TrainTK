namespace Demo111
{
    partial class TicketQuery
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaceOfDeparture = new System.Windows.Forms.TextBox();
            this.PlaceOfDestination = new System.Windows.Forms.TextBox();
            this.TrainType = new System.Windows.Forms.CheckBox();
            this.StudentCheck = new System.Windows.Forms.CheckBox();
            this.AdultCheck = new System.Windows.Forms.CheckBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.GetDepSite = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GetDestSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发地";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "到达地";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "出发日期";
            // 
            // PlaceOfDeparture
            // 
            this.PlaceOfDeparture.Location = new System.Drawing.Point(158, 80);
            this.PlaceOfDeparture.Name = "PlaceOfDeparture";
            this.PlaceOfDeparture.Size = new System.Drawing.Size(197, 25);
            this.PlaceOfDeparture.TabIndex = 3;
            // 
            // PlaceOfDestination
            // 
            this.PlaceOfDestination.Location = new System.Drawing.Point(158, 152);
            this.PlaceOfDestination.Name = "PlaceOfDestination";
            this.PlaceOfDestination.Size = new System.Drawing.Size(197, 25);
            this.PlaceOfDestination.TabIndex = 4;
            // 
            // TrainType
            // 
            this.TrainType.AutoSize = true;
            this.TrainType.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TrainType.Location = new System.Drawing.Point(84, 311);
            this.TrainType.Name = "TrainType";
            this.TrainType.Size = new System.Drawing.Size(97, 19);
            this.TrainType.TabIndex = 6;
            this.TrainType.Text = "高铁/动车";
            this.TrainType.UseVisualStyleBackColor = true;
            // 
            // StudentCheck
            // 
            this.StudentCheck.AutoSize = true;
            this.StudentCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentCheck.Location = new System.Drawing.Point(259, 311);
            this.StudentCheck.Name = "StudentCheck";
            this.StudentCheck.Size = new System.Drawing.Size(59, 19);
            this.StudentCheck.TabIndex = 7;
            this.StudentCheck.Text = "学生";
            this.StudentCheck.UseVisualStyleBackColor = true;
            this.StudentCheck.CheckedChanged += new System.EventHandler(this.StudentCheck_CheckedChanged);
            // 
            // AdultCheck
            // 
            this.AdultCheck.AutoSize = true;
            this.AdultCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdultCheck.Location = new System.Drawing.Point(384, 311);
            this.AdultCheck.Name = "AdultCheck";
            this.AdultCheck.Size = new System.Drawing.Size(59, 19);
            this.AdultCheck.TabIndex = 9;
            this.AdultCheck.Text = "成人";
            this.AdultCheck.UseVisualStyleBackColor = true;
            this.AdultCheck.CheckedChanged += new System.EventHandler(this.AdultCheck_CheckedChanged);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "查询";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(120, 352);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(285, 45);
            this.ucBtnExt1.TabIndex = 10;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // GetDepSite
            // 
            this.GetDepSite.Location = new System.Drawing.Point(384, 80);
            this.GetDepSite.Name = "GetDepSite";
            this.GetDepSite.Size = new System.Drawing.Size(80, 25);
            this.GetDepSite.TabIndex = 11;
            this.GetDepSite.Text = "选择";
            this.GetDepSite.UseVisualStyleBackColor = true;
            this.GetDepSite.Click += new System.EventHandler(this.GetDepSite_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // GetDestSite
            // 
            this.GetDestSite.Location = new System.Drawing.Point(384, 152);
            this.GetDestSite.Name = "GetDestSite";
            this.GetDestSite.Size = new System.Drawing.Size(80, 25);
            this.GetDestSite.TabIndex = 13;
            this.GetDestSite.Text = "选择";
            this.GetDestSite.UseVisualStyleBackColor = true;
            this.GetDestSite.Click += new System.EventHandler(this.GetDestSite_Click);
            // 
            // TicketQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 446);
            this.Controls.Add(this.GetDestSite);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GetDepSite);
            this.Controls.Add(this.AdultCheck);
            this.Controls.Add(this.StudentCheck);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.TrainType);
            this.Controls.Add(this.PlaceOfDestination);
            this.Controls.Add(this.PlaceOfDeparture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketQuery";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.TicketQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlaceOfDeparture;
        private System.Windows.Forms.TextBox PlaceOfDestination;
        private System.Windows.Forms.CheckBox TrainType;
        private System.Windows.Forms.CheckBox StudentCheck;
        private System.Windows.Forms.CheckBox AdultCheck;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.Button GetDepSite;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button GetDestSite;
    }
}