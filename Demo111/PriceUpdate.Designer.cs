namespace Demo111
{
    partial class PriceUpdate
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
            this.cancle = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.trainType = new System.Windows.Forms.TextBox();
            this.passagerType = new System.Windows.Forms.ComboBox();
            this.ticketPrice = new System.Windows.Forms.TextBox();
            this.endSite = new System.Windows.Forms.TextBox();
            this.seatType = new System.Windows.Forms.TextBox();
            this.startSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancle
            // 
            this.cancle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.Location = new System.Drawing.Point(365, 307);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(89, 40);
            this.cancle.TabIndex = 36;
            this.cancle.Text = " 取消 ";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Location = new System.Drawing.Point(197, 307);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(85, 40);
            this.update.TabIndex = 35;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // trainType
            // 
            this.trainType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trainType.Location = new System.Drawing.Point(188, 55);
            this.trainType.Name = "trainType";
            this.trainType.Size = new System.Drawing.Size(132, 28);
            this.trainType.TabIndex = 34;
            // 
            // passagerType
            // 
            this.passagerType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passagerType.FormattingEnabled = true;
            this.passagerType.Location = new System.Drawing.Point(427, 182);
            this.passagerType.Name = "passagerType";
            this.passagerType.Size = new System.Drawing.Size(155, 26);
            this.passagerType.TabIndex = 32;
            // 
            // ticketPrice
            // 
            this.ticketPrice.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ticketPrice.Location = new System.Drawing.Point(182, 237);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.Size = new System.Drawing.Size(100, 28);
            this.ticketPrice.TabIndex = 30;
            // 
            // endSite
            // 
            this.endSite.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endSite.Location = new System.Drawing.Point(427, 114);
            this.endSite.Name = "endSite";
            this.endSite.Size = new System.Drawing.Size(128, 28);
            this.endSite.TabIndex = 31;
            // 
            // seatType
            // 
            this.seatType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seatType.Location = new System.Drawing.Point(182, 175);
            this.seatType.Name = "seatType";
            this.seatType.Size = new System.Drawing.Size(138, 28);
            this.seatType.TabIndex = 28;
            // 
            // startSite
            // 
            this.startSite.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startSite.Location = new System.Drawing.Point(182, 114);
            this.startSite.Name = "startSite";
            this.startSite.Size = new System.Drawing.Size(138, 28);
            this.startSite.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(344, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "到达站：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(102, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "出发站：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(87, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "火车类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(329, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "乘客类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(125, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "票价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(87, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "座位类型：";
            // 
            // typeName
            // 
            this.typeName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeName.Location = new System.Drawing.Point(348, 55);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(132, 28);
            this.typeName.TabIndex = 34;
            // 
            // PriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 400);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.update);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.trainType);
            this.Controls.Add(this.passagerType);
            this.Controls.Add(this.ticketPrice);
            this.Controls.Add(this.endSite);
            this.Controls.Add(this.seatType);
            this.Controls.Add(this.startSite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PriceUpdate";
            this.Text = "价格修改";
            this.Load += new System.EventHandler(this.PriceUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox trainType;
        private System.Windows.Forms.ComboBox passagerType;
        private System.Windows.Forms.TextBox ticketPrice;
        private System.Windows.Forms.TextBox endSite;
        private System.Windows.Forms.TextBox seatType;
        private System.Windows.Forms.TextBox startSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeName;
    }
}