namespace Demo111
{
    partial class ChangeOrderPay
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
            this.canclePay = new System.Windows.Forms.Button();
            this.payCom = new System.Windows.Forms.Button();
            this.QRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // canclePay
            // 
            this.canclePay.Location = new System.Drawing.Point(74, 367);
            this.canclePay.Name = "canclePay";
            this.canclePay.Size = new System.Drawing.Size(111, 42);
            this.canclePay.TabIndex = 1;
            this.canclePay.Text = "取消支付";
            this.canclePay.UseVisualStyleBackColor = true;
            this.canclePay.Click += new System.EventHandler(this.canclePay_Click);
            // 
            // payCom
            // 
            this.payCom.Location = new System.Drawing.Point(319, 367);
            this.payCom.Name = "payCom";
            this.payCom.Size = new System.Drawing.Size(111, 42);
            this.payCom.TabIndex = 1;
            this.payCom.Text = "支付完成";
            this.payCom.UseVisualStyleBackColor = true;
            this.payCom.Click += new System.EventHandler(this.payCom_Click);
            // 
            // QRCode
            // 
            this.QRCode.Image = global::Demo111.Properties.Resources.RSCode;
            this.QRCode.Location = new System.Drawing.Point(97, 42);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(300, 300);
            this.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.QRCode.TabIndex = 0;
            this.QRCode.TabStop = false;
            // 
            // ChangeOrderPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 432);
            this.ControlBox = false;
            this.Controls.Add(this.payCom);
            this.Controls.Add(this.canclePay);
            this.Controls.Add(this.QRCode);
            this.Name = "ChangeOrderPay";
            this.Text = "扫码支付";
            this.Load += new System.EventHandler(this.OrderPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRCode;
        private System.Windows.Forms.Button canclePay;
        private System.Windows.Forms.Button payCom;
    }
}