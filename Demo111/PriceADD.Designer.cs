namespace Demo111
{
    partial class PriceADD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endSite = new System.Windows.Forms.TextBox();
            this.startSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trainType = new System.Windows.Forms.ComboBox();
            this.typeName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.seatType = new System.Windows.Forms.TextBox();
            this.passagerType = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(66, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "座位类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "票价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(308, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "乘客类型：";
            // 
            // endSite
            // 
            this.endSite.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endSite.Location = new System.Drawing.Point(406, 118);
            this.endSite.Name = "endSite";
            this.endSite.Size = new System.Drawing.Size(100, 28);
            this.endSite.TabIndex = 17;
            // 
            // startSite
            // 
            this.startSite.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startSite.Location = new System.Drawing.Point(161, 118);
            this.startSite.Name = "startSite";
            this.startSite.Size = new System.Drawing.Size(141, 28);
            this.startSite.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(323, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "到达站：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(81, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "出发站：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(66, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "火车类型：";
            // 
            // trainType
            // 
            this.trainType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trainType.FormattingEnabled = true;
            this.trainType.Location = new System.Drawing.Point(161, 60);
            this.trainType.Name = "trainType";
            this.trainType.Size = new System.Drawing.Size(121, 26);
            this.trainType.TabIndex = 18;
            this.trainType.SelectedIndexChanged += new System.EventHandler(this.trainType_SelectedIndexChanged);
            // 
            // typeName
            // 
            this.typeName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeName.Location = new System.Drawing.Point(301, 58);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(132, 28);
            this.typeName.TabIndex = 19;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.price.Location = new System.Drawing.Point(161, 241);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 28);
            this.price.TabIndex = 17;
            // 
            // seatType
            // 
            this.seatType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seatType.Location = new System.Drawing.Point(161, 179);
            this.seatType.Name = "seatType";
            this.seatType.Size = new System.Drawing.Size(141, 28);
            this.seatType.TabIndex = 16;
            // 
            // passagerType
            // 
            this.passagerType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passagerType.FormattingEnabled = true;
            this.passagerType.Location = new System.Drawing.Point(406, 181);
            this.passagerType.Name = "passagerType";
            this.passagerType.Size = new System.Drawing.Size(155, 26);
            this.passagerType.TabIndex = 18;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Location = new System.Drawing.Point(176, 311);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 40);
            this.add.TabIndex = 20;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancle
            // 
            this.cancle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancle.Location = new System.Drawing.Point(344, 311);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(89, 40);
            this.cancle.TabIndex = 21;
            this.cancle.Text = " 取消 ";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // PriceADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 386);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.add);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.passagerType);
            this.Controls.Add(this.trainType);
            this.Controls.Add(this.price);
            this.Controls.Add(this.endSite);
            this.Controls.Add(this.seatType);
            this.Controls.Add(this.startSite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PriceADD";
            this.Text = "添加票价";
            this.Load += new System.EventHandler(this.PriceADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endSite;
        private System.Windows.Forms.TextBox startSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox trainType;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox seatType;
        private System.Windows.Forms.ComboBox passagerType;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancle;
    }
}