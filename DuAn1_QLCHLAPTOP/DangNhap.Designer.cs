namespace Presentation
{
    partial class DangNhap
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.cb_luutaikhoan = new System.Windows.Forms.CheckBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_dangnhaphethong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.White;
            this.bt_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_thoat.Location = new System.Drawing.Point(441, 472);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(145, 40);
            this.bt_thoat.TabIndex = 27;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // cb_luutaikhoan
            // 
            this.cb_luutaikhoan.AutoSize = true;
            this.cb_luutaikhoan.Location = new System.Drawing.Point(266, 421);
            this.cb_luutaikhoan.Name = "cb_luutaikhoan";
            this.cb_luutaikhoan.Size = new System.Drawing.Size(214, 24);
            this.cb_luutaikhoan.TabIndex = 26;
            this.cb_luutaikhoan.Text = "Nhớ Tài Khoản Và Mật Khẩu";
            this.cb_luutaikhoan.UseVisualStyleBackColor = true;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.White;
            this.bt_dangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_dangnhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_dangnhap.Location = new System.Drawing.Point(266, 472);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(145, 40);
            this.bt_dangnhap.TabIndex = 25;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.Font = new System.Drawing.Font("Sitka Banner", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_quenmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(621, 387);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(127, 24);
            this.lb_quenmatkhau.TabIndex = 24;
            this.lb_quenmatkhau.Text = "Quên mật khẩu ?";
            this.lb_quenmatkhau.Click += new System.EventHandler(this.lb_quenmatkhau_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_matkhau.Location = new System.Drawing.Point(266, 385);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(320, 30);
            this.tb_matkhau.TabIndex = 23;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_taikhoan.Location = new System.Drawing.Point(266, 320);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(320, 30);
            this.tb_taikhoan.TabIndex = 22;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_matkhau.Location = new System.Drawing.Point(115, 387);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(104, 28);
            this.lb_matkhau.TabIndex = 21;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_taikhoan.Location = new System.Drawing.Point(115, 322);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(105, 28);
            this.lb_taikhoan.TabIndex = 20;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.istockphoto_1151650060_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(203, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lb_dangnhaphethong
            // 
            this.lb_dangnhaphethong.AutoSize = true;
            this.lb_dangnhaphethong.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_dangnhaphethong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_dangnhaphethong.Location = new System.Drawing.Point(266, 229);
            this.lb_dangnhaphethong.Name = "lb_dangnhaphethong";
            this.lb_dangnhaphethong.Size = new System.Drawing.Size(333, 41);
            this.lb_dangnhaphethong.TabIndex = 18;
            this.lb_dangnhaphethong.Text = "Đăng Nhập Hệ Thống ";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 599);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.cb_luutaikhoan);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_dangnhaphethong);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_thoat;
        private CheckBox cb_luutaikhoan;
        private Button bt_dangnhap;
        private Label lb_quenmatkhau;
        private TextBox tb_matkhau;
        private TextBox tb_taikhoan;
        private Label lb_matkhau;
        private Label lb_taikhoan;
        private PictureBox pictureBox1;
        private Label lb_dangnhaphethong;
    }
}