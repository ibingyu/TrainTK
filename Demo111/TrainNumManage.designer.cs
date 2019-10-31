namespace TrainTK
{
    partial class TrainNumManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.trainT = new System.Windows.Forms.ComboBox();
            this.trainC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvtrainInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrainInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.query);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.trainT);
            this.groupBox1.Controls.Add(this.trainC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1252, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(957, 34);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 40);
            this.update.TabIndex = 18;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1103, 34);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 40);
            this.delete.TabIndex = 18;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(629, 34);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(100, 40);
            this.query.TabIndex = 18;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(793, 34);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 40);
            this.add.TabIndex = 18;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 25);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // trainT
            // 
            this.trainT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainT.FormattingEnabled = true;
            this.trainT.Location = new System.Drawing.Point(97, 44);
            this.trainT.Margin = new System.Windows.Forms.Padding(4);
            this.trainT.Name = "trainT";
            this.trainT.Size = new System.Drawing.Size(76, 23);
            this.trainT.TabIndex = 16;
            // 
            // trainC
            // 
            this.trainC.Location = new System.Drawing.Point(183, 44);
            this.trainC.Margin = new System.Windows.Forms.Padding(4);
            this.trainC.Name = "trainC";
            this.trainC.Size = new System.Drawing.Size(79, 25);
            this.trainC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(319, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "出发时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "车次";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvtrainInfo);
            this.groupBox2.Location = new System.Drawing.Point(45, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1252, 567);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车票信息";
            // 
            // dgvtrainInfo
            // 
            this.dgvtrainInfo.AllowUserToAddRows = false;
            this.dgvtrainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrainInfo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvtrainInfo.Location = new System.Drawing.Point(7, 25);
            this.dgvtrainInfo.Name = "dgvtrainInfo";
            this.dgvtrainInfo.RowTemplate.Height = 27;
            this.dgvtrainInfo.Size = new System.Drawing.Size(1239, 535);
            this.dgvtrainInfo.TabIndex = 24;
            // 
            // TrainNumManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1361, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TrainNumManage";
            this.Text = "车次信息管理";
            this.Load += new System.EventHandler(this.TrainNumManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrainInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox trainC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox trainT;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvtrainInfo;
        private System.Windows.Forms.Button query;
    }
}