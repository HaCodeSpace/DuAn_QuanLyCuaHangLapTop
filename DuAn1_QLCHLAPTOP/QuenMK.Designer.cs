namespace Presentation
{
    partial class QuenMK
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
            this.lb_laylaimatkhau = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_laylaimatkhau
            // 
            this.lb_laylaimatkhau.AutoSize = true;
            this.lb_laylaimatkhau.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_laylaimatkhau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_laylaimatkhau.Location = new System.Drawing.Point(316, 80);
            this.lb_laylaimatkhau.Name = "lb_laylaimatkhau";
            this.lb_laylaimatkhau.Size = new System.Drawing.Size(263, 41);
            this.lb_laylaimatkhau.TabIndex = 19;
            this.lb_laylaimatkhau.Text = "Lấy Lại Mật Khẩu";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(151, 184);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(73, 31);
            this.lb_email.TabIndex = 20;
            this.lb_email.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(280, 181);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(338, 34);
            this.tb_email.TabIndex = 21;
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.BackColor = System.Drawing.Color.White;
            this.bt_xacnhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_xacnhan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_xacnhan.Location = new System.Drawing.Point(280, 395);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(145, 40);
            this.bt_xacnhan.TabIndex = 26;
            this.bt_xacnhan.Text = "Xác Nhận";
            this.bt_xacnhan.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(473, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_laylaimatkhau);
            this.Name = "QuenMK";
            this.Text = "QuenMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_laylaimatkhau;
        private Label lb_email;
        private TextBox tb_email;
        private Button bt_xacnhan;
        private Button button1;
    }
}