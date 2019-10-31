namespace Demo111
{
    partial class FrmOrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderInfo));
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carriageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endSite = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startSite = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trainNum = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 57;
            this.button1.Text = "继续购票";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(33, 296);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1023, 287);
            this.treeView1.TabIndex = 52;
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.personName,
            this.IDType,
            this.IDNum,
            this.ticketType,
            this.seatType,
            this.carriageNum,
            this.seatNum,
            this.price,
            this.orderStat});
            this.dgvOrderInfo.Location = new System.Drawing.Point(33, 77);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.RowTemplate.Height = 27;
            this.dgvOrderInfo.Size = new System.Drawing.Size(1023, 111);
            this.dgvOrderInfo.TabIndex = 51;
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // personName
            // 
            this.personName.HeaderText = "姓名";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            // 
            // IDType
            // 
            this.IDType.HeaderText = "证件类型";
            this.IDType.Name = "IDType";
            this.IDType.ReadOnly = true;
            this.IDType.Width = 180;
            // 
            // IDNum
            // 
            this.IDNum.HeaderText = "证件号码";
            this.IDNum.Name = "IDNum";
            this.IDNum.ReadOnly = true;
            this.IDNum.Width = 200;
            // 
            // ticketType
            // 
            this.ticketType.HeaderText = "票种";
            this.ticketType.Name = "ticketType";
            this.ticketType.ReadOnly = true;
            this.ticketType.Width = 120;
            // 
            // seatType
            // 
            this.seatType.HeaderText = "席别";
            this.seatType.Name = "seatType";
            this.seatType.ReadOnly = true;
            // 
            // carriageNum
            // 
            this.carriageNum.HeaderText = "车厢";
            this.carriageNum.Name = "carriageNum";
            this.carriageNum.ReadOnly = true;
            // 
            // seatNum
            // 
            this.seatNum.HeaderText = "席位号";
            this.seatNum.Name = "seatNum";
            this.seatNum.ReadOnly = true;
            this.seatNum.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "票价（元）";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // orderStat
            // 
            this.orderStat.HeaderText = "订单状态";
            this.orderStat.Name = "orderStat";
            this.orderStat.ReadOnly = true;
            // 
            // endSite
            // 
            this.endSite.AutoSize = true;
            this.endSite.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endSite.Location = new System.Drawing.Point(611, 32);
            this.endSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endSite.Name = "endSite";
            this.endSite.Size = new System.Drawing.Size(50, 26);
            this.endSite.TabIndex = 50;
            this.endSite.Text = "潍坊";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(570, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 26);
            this.label10.TabIndex = 49;
            this.label10.Text = "—";
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.Location = new System.Drawing.Point(707, 31);
            this.endTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(65, 26);
            this.endTime.TabIndex = 48;
            this.endTime.Text = "13:43";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(657, 32);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 25);
            this.label24.TabIndex = 45;
            this.label24.Text = "站";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTime.Location = new System.Drawing.Point(465, 32);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(65, 26);
            this.startTime.TabIndex = 47;
            this.startTime.Text = "12:39";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(413, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "站";
            // 
            // startSite
            // 
            this.startSite.AutoSize = true;
            this.startSite.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startSite.Location = new System.Drawing.Point(366, 32);
            this.startSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startSite.Name = "startSite";
            this.startSite.Size = new System.Drawing.Size(50, 26);
            this.startSite.TabIndex = 44;
            this.startSite.Text = "淄博";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(316, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "次";
            // 
            // trainNum
            // 
            this.trainNum.AutoSize = true;
            this.trainNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trainNum.Location = new System.Drawing.Point(261, 31);
            this.trainNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainNum.Name = "trainNum";
            this.trainNum.Size = new System.Drawing.Size(61, 26);
            this.trainNum.TabIndex = 38;
            this.trainNum.Text = "K955";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(768, 31);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 25);
            this.label23.TabIndex = 37;
            this.label23.Text = "到）";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.Location = new System.Drawing.Point(28, 29);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(124, 26);
            this.date.TabIndex = 36;
            this.date.Text = "2019-10-18";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(526, 31);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 25);
            this.label21.TabIndex = 35;
            this.label21.Text = "开）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(213, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "）";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(685, 31);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 25);
            this.label22.TabIndex = 42;
            this.label22.Text = "（";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(441, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 25);
            this.label20.TabIndex = 43;
            this.label20.Text = "（";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(142, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "（";
            // 
            // week
            // 
            this.week.AutoSize = true;
            this.week.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.week.Location = new System.Drawing.Point(169, 29);
            this.week.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(50, 26);
            this.week.TabIndex = 39;
            this.week.Text = "周五";
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(773, 235);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(105, 35);
            this.print.TabIndex = 59;
            this.print.Text = "打印车票";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 613);
            this.ControlBox = false;
            this.Controls.Add(this.print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgvOrderInfo);
            this.Controls.Add(this.endSite);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startSite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trainNum);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.week);
            this.Name = "FrmOrderInfo";
            this.Text = "订单信息";
            this.Load += new System.EventHandler(this.FrmOrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.Label endSite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label startSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label trainNum;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label week;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn carriageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStat;
        private System.Windows.Forms.Button print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}