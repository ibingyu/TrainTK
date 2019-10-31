namespace Demo111
{
    partial class FrmPersonDetail
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
            this.personInfo = new System.Windows.Forms.TabControl();
            this.BasicInfo = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.idType = new System.Windows.Forms.TextBox();
            this.passengerType = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.idNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new HZH_Controls.Controls.UCBtnExt();
            this.btnEdit = new HZH_Controls.Controls.UCBtnExt();
            this.postcode = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.fPhoneNum = new System.Windows.Forms.TextBox();
            this.cPhoneNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personInfo.SuspendLayout();
            this.BasicInfo.SuspendLayout();
            this.contactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfo
            // 
            this.personInfo.Controls.Add(this.BasicInfo);
            this.personInfo.Controls.Add(this.contactInfo);
            this.personInfo.ItemSize = new System.Drawing.Size(140, 40);
            this.personInfo.Location = new System.Drawing.Point(70, 34);
            this.personInfo.Name = "personInfo";
            this.personInfo.SelectedIndex = 0;
            this.personInfo.Size = new System.Drawing.Size(576, 410);
            this.personInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.personInfo.TabIndex = 0;
            // 
            // BasicInfo
            // 
            this.BasicInfo.Controls.Add(this.name);
            this.BasicInfo.Controls.Add(this.userName);
            this.BasicInfo.Controls.Add(this.sex);
            this.BasicInfo.Controls.Add(this.idType);
            this.BasicInfo.Controls.Add(this.passengerType);
            this.BasicInfo.Controls.Add(this.country);
            this.BasicInfo.Controls.Add(this.idNum);
            this.BasicInfo.Controls.Add(this.label9);
            this.BasicInfo.Controls.Add(this.label8);
            this.BasicInfo.Controls.Add(this.label7);
            this.BasicInfo.Controls.Add(this.label6);
            this.BasicInfo.Controls.Add(this.label5);
            this.BasicInfo.Controls.Add(this.label4);
            this.BasicInfo.Controls.Add(this.label3);
            this.BasicInfo.Location = new System.Drawing.Point(4, 44);
            this.BasicInfo.Name = "BasicInfo";
            this.BasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.BasicInfo.Size = new System.Drawing.Size(568, 362);
            this.BasicInfo.TabIndex = 0;
            this.BasicInfo.Text = "基本信息";
            this.BasicInfo.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(243, 95);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 24);
            this.name.TabIndex = 7;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userName.Location = new System.Drawing.Point(243, 55);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(160, 24);
            this.userName.TabIndex = 7;
            // 
            // sex
            // 
            this.sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sex.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.Location = new System.Drawing.Point(243, 135);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(160, 24);
            this.sex.TabIndex = 7;
            // 
            // idType
            // 
            this.idType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idType.Location = new System.Drawing.Point(243, 221);
            this.idType.Name = "idType";
            this.idType.Size = new System.Drawing.Size(160, 24);
            this.idType.TabIndex = 7;
            // 
            // passengerType
            // 
            this.passengerType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passengerType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerType.Location = new System.Drawing.Point(243, 311);
            this.passengerType.Name = "passengerType";
            this.passengerType.Size = new System.Drawing.Size(160, 24);
            this.passengerType.TabIndex = 7;
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(243, 179);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(160, 24);
            this.country.TabIndex = 7;
            // 
            // idNum
            // 
            this.idNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNum.Location = new System.Drawing.Point(243, 269);
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(160, 24);
            this.idNum.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "乘客类型:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "证件号码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "证件类型:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "国家/地区:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名:";
            // 
            // contactInfo
            // 
            this.contactInfo.Controls.Add(this.btnSave);
            this.contactInfo.Controls.Add(this.btnEdit);
            this.contactInfo.Controls.Add(this.postcode);
            this.contactInfo.Controls.Add(this.address);
            this.contactInfo.Controls.Add(this.email);
            this.contactInfo.Controls.Add(this.fPhoneNum);
            this.contactInfo.Controls.Add(this.cPhoneNum);
            this.contactInfo.Controls.Add(this.label12);
            this.contactInfo.Controls.Add(this.label11);
            this.contactInfo.Controls.Add(this.label10);
            this.contactInfo.Controls.Add(this.label2);
            this.contactInfo.Controls.Add(this.label1);
            this.contactInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contactInfo.Location = new System.Drawing.Point(4, 44);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Padding = new System.Windows.Forms.Padding(3);
            this.contactInfo.Size = new System.Drawing.Size(568, 362);
            this.contactInfo.TabIndex = 1;
            this.contactInfo.Text = "联系方式";
            this.contactInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BtnBackColor = System.Drawing.Color.White;
            this.btnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.BtnForeColor = System.Drawing.Color.White;
            this.btnSave.BtnText = "保存";
            this.btnSave.ConerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.Orange;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.IsRadius = true;
            this.btnSave.IsShowRect = true;
            this.btnSave.IsShowTips = false;
            this.btnSave.Location = new System.Drawing.Point(435, 77);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.btnSave.RectWidth = 1;
            this.btnSave.Size = new System.Drawing.Size(105, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.TabStop = false;
            this.btnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSave.TipsText = "";
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BtnBackColor = System.Drawing.Color.White;
            this.btnEdit.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.BtnForeColor = System.Drawing.Color.White;
            this.btnEdit.BtnText = "修改";
            this.btnEdit.ConerRadius = 5;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.Orange;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnEdit.IsRadius = true;
            this.btnEdit.IsShowRect = true;
            this.btnEdit.IsShowTips = false;
            this.btnEdit.Location = new System.Drawing.Point(435, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.btnEdit.RectWidth = 1;
            this.btnEdit.Size = new System.Drawing.Size(105, 36);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnEdit.TipsText = "";
            this.btnEdit.BtnClick += new System.EventHandler(this.btnEdit_BtnClick);
            // 
            // postcode
            // 
            this.postcode.BackColor = System.Drawing.SystemColors.Window;
            this.postcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postcode.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.postcode.Location = new System.Drawing.Point(169, 287);
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            this.postcode.Size = new System.Drawing.Size(180, 24);
            this.postcode.TabIndex = 10;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Window;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.address.Location = new System.Drawing.Point(169, 235);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(180, 24);
            this.address.TabIndex = 9;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Window;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.Location = new System.Drawing.Point(169, 176);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(180, 24);
            this.email.TabIndex = 8;
            // 
            // fPhoneNum
            // 
            this.fPhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.fPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fPhoneNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fPhoneNum.Location = new System.Drawing.Point(169, 122);
            this.fPhoneNum.Name = "fPhoneNum";
            this.fPhoneNum.ReadOnly = true;
            this.fPhoneNum.Size = new System.Drawing.Size(180, 24);
            this.fPhoneNum.TabIndex = 7;
            // 
            // cPhoneNum
            // 
            this.cPhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.cPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPhoneNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cPhoneNum.Location = new System.Drawing.Point(169, 79);
            this.cPhoneNum.Name = "cPhoneNum";
            this.cPhoneNum.ReadOnly = true;
            this.cPhoneNum.Size = new System.Drawing.Size(180, 24);
            this.cPhoneNum.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(108, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "邮编:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(108, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "地址:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(108, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "邮箱:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "固定电话:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机号:";
            // 
            // FrmPersonDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 479);
            this.Controls.Add(this.personInfo);
            this.Name = "FrmPersonDetail";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.frmPersonDetail_Load);
            this.personInfo.ResumeLayout(false);
            this.BasicInfo.ResumeLayout(false);
            this.BasicInfo.PerformLayout();
            this.contactInfo.ResumeLayout(false);
            this.contactInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl personInfo;
        private System.Windows.Forms.TabPage BasicInfo;
        private System.Windows.Forms.TabPage contactInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox idType;
        private System.Windows.Forms.TextBox passengerType;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox idNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCBtnExt btnEdit;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox fPhoneNum;
        private System.Windows.Forms.TextBox cPhoneNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private HZH_Controls.Controls.UCBtnExt btnSave;
    }
}