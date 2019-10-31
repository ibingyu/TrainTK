namespace Demo111
{
    partial class FrmOrderCenter
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
            this.NotTravel = new System.Windows.Forms.TabPage();
            this.queryText1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.detail = new System.Windows.Forms.Button();
            this.changeOrder = new System.Windows.Forms.Button();
            this.refund = new System.Windows.Forms.Button();
            this.dgvNotTravel = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detail1 = new System.Windows.Forms.Button();
            this.refu = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.dgvChange = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.detail2 = new System.Windows.Forms.Button();
            this.refundticket = new System.Windows.Forms.Button();
            this.dgvRefund = new System.Windows.Forms.DataGridView();
            this.BtnOrderQuery = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.ComboBox();
            this.Unfinished = new System.Windows.Forms.TabPage();
            this.BtnPay = new System.Windows.Forms.Button();
            this.WarmPrompt = new System.Windows.Forms.RichTextBox();
            this.dgvUnfinish = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traincode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCenter = new System.Windows.Forms.TabControl();
            this.OrderHistory = new System.Windows.Forms.TabPage();
            this.queryText2 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NotTravel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotTravel)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefund)).BeginInit();
            this.Unfinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnfinish)).BeginInit();
            this.OrderCenter.SuspendLayout();
            this.OrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // NotTravel
            // 
            this.NotTravel.Controls.Add(this.queryText1);
            this.NotTravel.Controls.Add(this.richTextBox1);
            this.NotTravel.Controls.Add(this.tabControl1);
            this.NotTravel.Controls.Add(this.BtnOrderQuery);
            this.NotTravel.Controls.Add(this.dateTimePicker2);
            this.NotTravel.Controls.Add(this.dateTimePicker1);
            this.NotTravel.Controls.Add(this.label1);
            this.NotTravel.Controls.Add(this.condition);
            this.NotTravel.Location = new System.Drawing.Point(4, 54);
            this.NotTravel.Name = "NotTravel";
            this.NotTravel.Padding = new System.Windows.Forms.Padding(3);
            this.NotTravel.Size = new System.Drawing.Size(1022, 772);
            this.NotTravel.TabIndex = 1;
            this.NotTravel.Text = "未出行订单";
            this.NotTravel.UseVisualStyleBackColor = true;
            this.NotTravel.Click += new System.EventHandler(this.NotTravel_Click);
            // 
            // queryText1
            // 
            this.queryText1.ForeColor = System.Drawing.Color.Gray;
            this.queryText1.Location = new System.Drawing.Point(677, 21);
            this.queryText1.Name = "queryText1";
            this.queryText1.Size = new System.Drawing.Size(176, 31);
            this.queryText1.TabIndex = 9;
            this.queryText1.Text = "请输入姓名";
            this.queryText1.Leave += new System.EventHandler(this.queryText1_Leave);
            this.queryText1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.queryText1_MouseDown);
            this.queryText1.MouseLeave += new System.EventHandler(this.queryText1_MouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(29, 430);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(961, 295);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 35);
            this.tabControl1.Location = new System.Drawing.Point(29, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 316);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.detail);
            this.tabPage1.Controls.Add(this.changeOrder);
            this.tabPage1.Controls.Add(this.refund);
            this.tabPage1.Controls.Add(this.dgvNotTravel);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全部";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(480, 218);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(120, 42);
            this.detail.TabIndex = 3;
            this.detail.Text = "订单详情";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // changeOrder
            // 
            this.changeOrder.Location = new System.Drawing.Point(644, 218);
            this.changeOrder.Name = "changeOrder";
            this.changeOrder.Size = new System.Drawing.Size(120, 42);
            this.changeOrder.TabIndex = 3;
            this.changeOrder.Text = "改签";
            this.changeOrder.UseVisualStyleBackColor = true;
            this.changeOrder.Click += new System.EventHandler(this.button7_Click);
            // 
            // refund
            // 
            this.refund.Location = new System.Drawing.Point(803, 218);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(120, 42);
            this.refund.TabIndex = 4;
            this.refund.Text = "退票";
            this.refund.UseVisualStyleBackColor = true;
            this.refund.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvNotTravel
            // 
            this.dgvNotTravel.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotTravel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotTravel.Location = new System.Drawing.Point(6, 19);
            this.dgvNotTravel.Name = "dgvNotTravel";
            this.dgvNotTravel.ReadOnly = true;
            this.dgvNotTravel.RowTemplate.Height = 27;
            this.dgvNotTravel.Size = new System.Drawing.Size(941, 183);
            this.dgvNotTravel.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.detail1);
            this.tabPage2.Controls.Add(this.refu);
            this.tabPage2.Controls.Add(this.change);
            this.tabPage2.Controls.Add(this.dgvChange);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "可改签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // detail1
            // 
            this.detail1.Location = new System.Drawing.Point(476, 225);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(120, 42);
            this.detail1.TabIndex = 6;
            this.detail1.Text = "订单详情";
            this.detail1.UseVisualStyleBackColor = true;
            // 
            // refu
            // 
            this.refu.Location = new System.Drawing.Point(800, 225);
            this.refu.Name = "refu";
            this.refu.Size = new System.Drawing.Size(120, 42);
            this.refu.TabIndex = 5;
            this.refu.Text = "退票";
            this.refu.UseVisualStyleBackColor = true;
            this.refu.Click += new System.EventHandler(this.refu_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(644, 225);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(120, 42);
            this.change.TabIndex = 3;
            this.change.Text = "改签";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // dgvChange
            // 
            this.dgvChange.BackgroundColor = System.Drawing.Color.White;
            this.dgvChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChange.Location = new System.Drawing.Point(6, 19);
            this.dgvChange.Name = "dgvChange";
            this.dgvChange.ReadOnly = true;
            this.dgvChange.RowTemplate.Height = 27;
            this.dgvChange.Size = new System.Drawing.Size(941, 183);
            this.dgvChange.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.detail2);
            this.tabPage3.Controls.Add(this.refundticket);
            this.tabPage3.Controls.Add(this.dgvRefund);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(953, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "可退票";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // detail2
            // 
            this.detail2.Location = new System.Drawing.Point(644, 224);
            this.detail2.Name = "detail2";
            this.detail2.Size = new System.Drawing.Size(120, 42);
            this.detail2.TabIndex = 4;
            this.detail2.Text = "订单详情";
            this.detail2.UseVisualStyleBackColor = true;
            // 
            // refundticket
            // 
            this.refundticket.Location = new System.Drawing.Point(803, 224);
            this.refundticket.Name = "refundticket";
            this.refundticket.Size = new System.Drawing.Size(120, 42);
            this.refundticket.TabIndex = 1;
            this.refundticket.Text = "退票";
            this.refundticket.UseVisualStyleBackColor = true;
            this.refundticket.Click += new System.EventHandler(this.refundticket_Click);
            // 
            // dgvRefund
            // 
            this.dgvRefund.BackgroundColor = System.Drawing.Color.White;
            this.dgvRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefund.GridColor = System.Drawing.Color.White;
            this.dgvRefund.Location = new System.Drawing.Point(6, 25);
            this.dgvRefund.Name = "dgvRefund";
            this.dgvRefund.ReadOnly = true;
            this.dgvRefund.RowTemplate.Height = 27;
            this.dgvRefund.Size = new System.Drawing.Size(941, 183);
            this.dgvRefund.TabIndex = 0;
            // 
            // BtnOrderQuery
            // 
            this.BtnOrderQuery.Location = new System.Drawing.Point(882, 17);
            this.BtnOrderQuery.Name = "BtnOrderQuery";
            this.BtnOrderQuery.Size = new System.Drawing.Size(108, 35);
            this.BtnOrderQuery.TabIndex = 6;
            this.BtnOrderQuery.Text = "查询";
            this.BtnOrderQuery.UseVisualStyleBackColor = true;
            this.BtnOrderQuery.Click += new System.EventHandler(this.BtnOrderQuery_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(458, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2019, 10, 23, 15, 8, 53, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(438, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // condition
            // 
            this.condition.FormattingEnabled = true;
            this.condition.Location = new System.Drawing.Point(29, 21);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(186, 32);
            this.condition.TabIndex = 0;
            // 
            // Unfinished
            // 
            this.Unfinished.Controls.Add(this.BtnPay);
            this.Unfinished.Controls.Add(this.WarmPrompt);
            this.Unfinished.Controls.Add(this.dgvUnfinish);
            this.Unfinished.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Unfinished.Location = new System.Drawing.Point(4, 54);
            this.Unfinished.Name = "Unfinished";
            this.Unfinished.Padding = new System.Windows.Forms.Padding(3);
            this.Unfinished.Size = new System.Drawing.Size(1022, 772);
            this.Unfinished.TabIndex = 0;
            this.Unfinished.Text = "未完成订单";
            this.Unfinished.UseVisualStyleBackColor = true;
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(803, 292);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(137, 43);
            this.BtnPay.TabIndex = 2;
            this.BtnPay.Text = "网上支付";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // WarmPrompt
            // 
            this.WarmPrompt.BackColor = System.Drawing.SystemColors.Info;
            this.WarmPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarmPrompt.Location = new System.Drawing.Point(30, 341);
            this.WarmPrompt.Name = "WarmPrompt";
            this.WarmPrompt.Size = new System.Drawing.Size(960, 343);
            this.WarmPrompt.TabIndex = 1;
            this.WarmPrompt.Text = "";
            // 
            // dgvUnfinish
            // 
            this.dgvUnfinish.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnfinish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnfinish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.traincode,
            this.startSite,
            this.endStart,
            this.startTime,
            this.end,
            this.startDate,
            this.personName,
            this.IDType,
            this.SeatType,
            this.SeatNum,
            this.ticketType,
            this.price,
            this.orderState});
            this.dgvUnfinish.Location = new System.Drawing.Point(30, 42);
            this.dgvUnfinish.Name = "dgvUnfinish";
            this.dgvUnfinish.ReadOnly = true;
            this.dgvUnfinish.RowTemplate.Height = 27;
            this.dgvUnfinish.Size = new System.Drawing.Size(959, 229);
            this.dgvUnfinish.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // traincode
            // 
            this.traincode.HeaderText = "车次";
            this.traincode.Name = "traincode";
            this.traincode.ReadOnly = true;
            // 
            // startSite
            // 
            this.startSite.HeaderText = "出发站";
            this.startSite.Name = "startSite";
            this.startSite.ReadOnly = true;
            this.startSite.Width = 120;
            // 
            // endStart
            // 
            this.endStart.HeaderText = "到达站";
            this.endStart.Name = "endStart";
            this.endStart.ReadOnly = true;
            this.endStart.Width = 120;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "出发时间";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 120;
            // 
            // end
            // 
            this.end.HeaderText = "到达时间";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            this.end.Width = 120;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "出发日期";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 120;
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
            this.IDType.Width = 160;
            // 
            // SeatType
            // 
            this.SeatType.HeaderText = "席别";
            this.SeatType.Name = "SeatType";
            this.SeatType.ReadOnly = true;
            // 
            // SeatNum
            // 
            this.SeatNum.HeaderText = "席位号";
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.ReadOnly = true;
            this.SeatNum.Width = 180;
            // 
            // ticketType
            // 
            this.ticketType.HeaderText = "票种";
            this.ticketType.Name = "ticketType";
            this.ticketType.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "票价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // orderState
            // 
            this.orderState.HeaderText = "车票状态";
            this.orderState.Name = "orderState";
            this.orderState.ReadOnly = true;
            // 
            // OrderCenter
            // 
            this.OrderCenter.Controls.Add(this.Unfinished);
            this.OrderCenter.Controls.Add(this.NotTravel);
            this.OrderCenter.Controls.Add(this.OrderHistory);
            this.OrderCenter.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderCenter.ItemSize = new System.Drawing.Size(140, 50);
            this.OrderCenter.Location = new System.Drawing.Point(80, 60);
            this.OrderCenter.Name = "OrderCenter";
            this.OrderCenter.SelectedIndex = 0;
            this.OrderCenter.Size = new System.Drawing.Size(1030, 830);
            this.OrderCenter.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.OrderCenter.TabIndex = 1;
            this.OrderCenter.Click += new System.EventHandler(this.OrderCenter_Click);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Controls.Add(this.queryText2);
            this.OrderHistory.Controls.Add(this.richTextBox2);
            this.OrderHistory.Controls.Add(this.dgvHistory);
            this.OrderHistory.Controls.Add(this.label3);
            this.OrderHistory.Controls.Add(this.button10);
            this.OrderHistory.Controls.Add(this.dateTimePicker3);
            this.OrderHistory.Controls.Add(this.dateTimePicker4);
            this.OrderHistory.Controls.Add(this.label2);
            this.OrderHistory.Location = new System.Drawing.Point(4, 54);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.OrderHistory.Size = new System.Drawing.Size(1022, 772);
            this.OrderHistory.TabIndex = 2;
            this.OrderHistory.Text = "历史订单";
            this.OrderHistory.UseVisualStyleBackColor = true;
            // 
            // queryText2
            // 
            this.queryText2.ForeColor = System.Drawing.Color.Gray;
            this.queryText2.Location = new System.Drawing.Point(575, 26);
            this.queryText2.Name = "queryText2";
            this.queryText2.Size = new System.Drawing.Size(191, 31);
            this.queryText2.TabIndex = 20;
            this.queryText2.Text = "请输入姓名";
            this.queryText2.Leave += new System.EventHandler(this.queryText2_Leave);
            this.queryText2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.queryText2_MouseDown);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(38, 391);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(961, 295);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // dgvHistory
            // 
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(38, 91);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowTemplate.Height = 27;
            this.dgvHistory.Size = new System.Drawing.Size(941, 210);
            this.dgvHistory.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "乘车日期";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(805, 23);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 35);
            this.button10.TabIndex = 12;
            this.button10.Text = "查询";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(342, 26);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker3.TabIndex = 11;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(127, 26);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(440, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // FrmOrderCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 1033);
            this.Controls.Add(this.OrderCenter);
            this.MaximizeBox = false;
            this.Name = "FrmOrderCenter";
            this.Text = "订单中心";
            this.Load += new System.EventHandler(this.FrmOrderCenter_Load);
            this.Click += new System.EventHandler(this.NotTravel_Click);
            this.NotTravel.ResumeLayout(false);
            this.NotTravel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotTravel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefund)).EndInit();
            this.Unfinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnfinish)).EndInit();
            this.OrderCenter.ResumeLayout(false);
            this.OrderHistory.ResumeLayout(false);
            this.OrderHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage NotTravel;
        private System.Windows.Forms.TabPage Unfinished;
        private System.Windows.Forms.TabControl OrderCenter;
        private System.Windows.Forms.TabPage OrderHistory;
        private System.Windows.Forms.DataGridView dgvUnfinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.RichTextBox WarmPrompt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnOrderQuery;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button changeOrder;
        private System.Windows.Forms.Button refund;
        private System.Windows.Forms.DataGridView dgvNotTravel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.DataGridView dgvChange;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRefund;
        private System.Windows.Forms.Button refundticket;
        private System.Windows.Forms.TextBox queryText1;
        private System.Windows.Forms.TextBox queryText2;
        private System.Windows.Forms.Button refu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn traincode;
        private System.Windows.Forms.DataGridViewTextBoxColumn startSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderState;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Button detail1;
        private System.Windows.Forms.Button detail2;
    }
}