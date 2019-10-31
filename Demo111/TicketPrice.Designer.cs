namespace Demo111
{
    partial class TicketPrice
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
            this.endSite = new System.Windows.Forms.TextBox();
            this.startSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.dgvPrice = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // endSite
            // 
            this.endSite.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endSite.Location = new System.Drawing.Point(509, 48);
            this.endSite.Name = "endSite";
            this.endSite.Size = new System.Drawing.Size(138, 31);
            this.endSite.TabIndex = 35;
            // 
            // startSite
            // 
            this.startSite.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startSite.Location = new System.Drawing.Point(182, 48);
            this.startSite.Name = "startSite";
            this.startSite.Size = new System.Drawing.Size(146, 31);
            this.startSite.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(415, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "到达站：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(98, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "出发站：";
            // 
            // query
            // 
            this.query.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(700, 46);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(101, 35);
            this.query.TabIndex = 36;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // dgvPrice
            // 
            this.dgvPrice.AllowUserToAddRows = false;
            this.dgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.trainType,
            this.typeName,
            this.start,
            this.end,
            this.seatType,
            this.passengerType,
            this.price});
            this.dgvPrice.Location = new System.Drawing.Point(65, 169);
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.RowTemplate.Height = 27;
            this.dgvPrice.Size = new System.Drawing.Size(801, 371);
            this.dgvPrice.TabIndex = 37;
            this.dgvPrice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrice_CellValueChanged);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 60;
            // 
            // trainType
            // 
            this.trainType.HeaderText = "火车类型";
            this.trainType.Name = "trainType";
            this.trainType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trainType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // typeName
            // 
            this.typeName.HeaderText = "类型名称";
            this.typeName.Name = "typeName";
            // 
            // start
            // 
            this.start.HeaderText = "出发站";
            this.start.Name = "start";
            // 
            // end
            // 
            this.end.HeaderText = "终点站";
            this.end.Name = "end";
            // 
            // seatType
            // 
            this.seatType.HeaderText = "座位类型";
            this.seatType.Name = "seatType";
            // 
            // passengerType
            // 
            this.passengerType.HeaderText = "乘客类型";
            this.passengerType.Name = "passengerType";
            // 
            // price
            // 
            this.price.HeaderText = "票价";
            this.price.Name = "price";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Location = new System.Drawing.Point(103, 106);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 35);
            this.add.TabIndex = 36;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Location = new System.Drawing.Point(427, 106);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 35);
            this.update.TabIndex = 36;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Location = new System.Drawing.Point(700, 106);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 35);
            this.delete.TabIndex = 36;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 585);
            this.Controls.Add(this.dgvPrice);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.query);
            this.Controls.Add(this.endSite);
            this.Controls.Add(this.startSite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "TicketPrice";
            this.Text = "票价管理";
            this.Load += new System.EventHandler(this.TicketPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endSite;
        private System.Windows.Forms.TextBox startSite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.DataGridView dgvPrice;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button delete;
    }
}