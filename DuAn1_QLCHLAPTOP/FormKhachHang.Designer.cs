namespace Presentation
{
    partial class FormKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_thongtin = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_loctrangthai = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_loctheogioitinh = new System.Windows.Forms.Label();
            this.groupBox_thietlap = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_khd = new System.Windows.Forms.RadioButton();
            this.rdb_hd = new System.Windows.Forms.RadioButton();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_dienthoai = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.lb_makh = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_thietlap.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_thongtin);
            this.panel1.Controls.Add(this.groupBox_thietlap);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 879);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_thongtin
            // 
            this.groupBox_thongtin.Controls.Add(this.textBox1);
            this.groupBox_thongtin.Controls.Add(this.dataGridView1);
            this.groupBox_thongtin.Controls.Add(this.comboBox2);
            this.groupBox_thongtin.Controls.Add(this.lb_loctrangthai);
            this.groupBox_thongtin.Controls.Add(this.comboBox1);
            this.groupBox_thongtin.Controls.Add(this.lb_loctheogioitinh);
            this.groupBox_thongtin.Location = new System.Drawing.Point(12, 405);
            this.groupBox_thongtin.Name = "groupBox_thongtin";
            this.groupBox_thongtin.Size = new System.Drawing.Size(1331, 458);
            this.groupBox_thongtin.TabIndex = 2;
            this.groupBox_thongtin.TabStop = false;
            this.groupBox_thongtin.Text = "Thông Tin Khách Hàng";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1008, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm Kiếm Theo Tên";
            this.textBox1.Size = new System.Drawing.Size(273, 31);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(14, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 296);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SĐT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng Thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hoạt Động",
            "Không Hoạt Động"});
            this.comboBox2.Location = new System.Drawing.Point(690, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 31);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lb_loctrangthai
            // 
            this.lb_loctrangthai.AutoSize = true;
            this.lb_loctrangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loctrangthai.Location = new System.Drawing.Point(482, 61);
            this.lb_loctrangthai.Name = "lb_loctrangthai";
            this.lb_loctrangthai.Size = new System.Drawing.Size(164, 23);
            this.lb_loctrangthai.TabIndex = 25;
            this.lb_loctrangthai.Text = "Lọc Theo Trạng Thái";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(185, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 31);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_loctheogioitinh
            // 
            this.lb_loctheogioitinh.AutoSize = true;
            this.lb_loctheogioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loctheogioitinh.Location = new System.Drawing.Point(14, 61);
            this.lb_loctheogioitinh.Name = "lb_loctheogioitinh";
            this.lb_loctheogioitinh.Size = new System.Drawing.Size(152, 23);
            this.lb_loctheogioitinh.TabIndex = 24;
            this.lb_loctheogioitinh.Text = "Lọc Theo Giới Tính";
            // 
            // groupBox_thietlap
            // 
            this.groupBox_thietlap.Controls.Add(this.bt_reset);
            this.groupBox_thietlap.Controls.Add(this.panel2);
            this.groupBox_thietlap.Controls.Add(this.tb_diachi);
            this.groupBox_thietlap.Controls.Add(this.bt_sua);
            this.groupBox_thietlap.Controls.Add(this.bt_them);
            this.groupBox_thietlap.Controls.Add(this.rdb_nu);
            this.groupBox_thietlap.Controls.Add(this.rdb_nam);
            this.groupBox_thietlap.Controls.Add(this.tb_dienthoai);
            this.groupBox_thietlap.Controls.Add(this.tb_email);
            this.groupBox_thietlap.Controls.Add(this.tb_tenkh);
            this.groupBox_thietlap.Controls.Add(this.tb_makh);
            this.groupBox_thietlap.Controls.Add(this.lb_gioitinh);
            this.groupBox_thietlap.Controls.Add(this.lb_dienthoai);
            this.groupBox_thietlap.Controls.Add(this.lb_diachi);
            this.groupBox_thietlap.Controls.Add(this.lb_email);
            this.groupBox_thietlap.Controls.Add(this.lb_tenkh);
            this.groupBox_thietlap.Controls.Add(this.lb_makh);
            this.groupBox_thietlap.Location = new System.Drawing.Point(12, 3);
            this.groupBox_thietlap.Name = "groupBox_thietlap";
            this.groupBox_thietlap.Size = new System.Drawing.Size(1331, 358);
            this.groupBox_thietlap.TabIndex = 1;
            this.groupBox_thietlap.TabStop = false;
            this.groupBox_thietlap.Text = "Thiết Lập Thông Tin Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_khd);
            this.panel2.Controls.Add(this.rdb_hd);
            this.panel2.Controls.Add(this.lb_trangthai);
            this.panel2.Location = new System.Drawing.Point(148, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 56);
            this.panel2.TabIndex = 25;
            // 
            // rdb_khd
            // 
            this.rdb_khd.AutoSize = true;
            this.rdb_khd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_khd.Location = new System.Drawing.Point(352, 14);
            this.rdb_khd.Name = "rdb_khd";
            this.rdb_khd.Size = new System.Drawing.Size(171, 27);
            this.rdb_khd.TabIndex = 28;
            this.rdb_khd.TabStop = true;
            this.rdb_khd.Text = "Không Hoạt Động";
            this.rdb_khd.UseVisualStyleBackColor = true;
            // 
            // rdb_hd
            // 
            this.rdb_hd.AutoSize = true;
            this.rdb_hd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_hd.Location = new System.Drawing.Point(172, 14);
            this.rdb_hd.Name = "rdb_hd";
            this.rdb_hd.Size = new System.Drawing.Size(116, 27);
            this.rdb_hd.TabIndex = 27;
            this.rdb_hd.TabStop = true;
            this.rdb_hd.Text = "Hoạt Động";
            this.rdb_hd.UseVisualStyleBackColor = true;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_trangthai.Location = new System.Drawing.Point(0, 18);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(90, 23);
            this.lb_trangthai.TabIndex = 26;
            this.lb_trangthai.Text = "Trạng Thái";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diachi.Location = new System.Drawing.Point(934, 148);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(263, 30);
            this.tb_diachi.TabIndex = 24;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_sua.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.Location = new System.Drawing.Point(630, 303);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(167, 37);
            this.bt_sua.TabIndex = 23;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Yellow;
            this.bt_them.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Location = new System.Drawing.Point(320, 303);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(167, 37);
            this.bt_them.TabIndex = 22;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nu.Location = new System.Drawing.Point(500, 155);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(55, 27);
            this.rdb_nu.TabIndex = 19;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nam.Location = new System.Drawing.Point(320, 155);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(73, 27);
            this.rdb_nam.TabIndex = 18;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam ";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dienthoai.Location = new System.Drawing.Point(934, 49);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(263, 30);
            this.tb_dienthoai.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(934, 98);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(263, 30);
            this.tb_email.TabIndex = 12;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenkh.Location = new System.Drawing.Point(320, 98);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(263, 30);
            this.tb_tenkh.TabIndex = 11;
            // 
            // tb_makh
            // 
            this.tb_makh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_makh.Location = new System.Drawing.Point(320, 53);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(263, 30);
            this.tb_makh.TabIndex = 10;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gioitinh.Location = new System.Drawing.Point(148, 159);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(78, 23);
            this.lb_gioitinh.TabIndex = 8;
            this.lb_gioitinh.Text = "Giới Tính";
            // 
            // lb_dienthoai
            // 
            this.lb_dienthoai.AutoSize = true;
            this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dienthoai.Location = new System.Drawing.Point(810, 56);
            this.lb_dienthoai.Name = "lb_dienthoai";
            this.lb_dienthoai.Size = new System.Drawing.Size(92, 23);
            this.lb_dienthoai.TabIndex = 6;
            this.lb_dienthoai.Text = "Điện Thoại";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_diachi.Location = new System.Drawing.Point(810, 155);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(65, 23);
            this.lb_diachi.TabIndex = 5;
            this.lb_diachi.Text = "Địa Chỉ";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(810, 105);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 23);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Email";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tenkh.Location = new System.Drawing.Point(148, 105);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(135, 23);
            this.lb_tenkh.TabIndex = 1;
            this.lb_tenkh.Text = "Tên Khách Hàng";
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_makh.Location = new System.Drawing.Point(148, 57);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(134, 23);
            this.lb_makh.TabIndex = 0;
            this.lb_makh.Text = "Mã Khách Hàng";
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.Yellow;
            this.bt_reset.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_reset.ForeColor = System.Drawing.Color.Black;
            this.bt_reset.Location = new System.Drawing.Point(934, 303);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(167, 37);
            this.bt_reset.TabIndex = 49;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 903);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.panel1.ResumeLayout(false);
            this.groupBox_thongtin.ResumeLayout(false);
            this.groupBox_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_thietlap.ResumeLayout(false);
            this.groupBox_thietlap.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox_thongtin;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label lb_loctrangthai;
        private ComboBox comboBox1;
        private Label lb_loctheogioitinh;
        private GroupBox groupBox_thietlap;
        private TextBox tb_diachi;
        private Button bt_sua;
        private Button bt_them;
        private RadioButton rdb_nu;
        private RadioButton rdb_nam;
        private TextBox tb_dienthoai;
        private TextBox tb_email;
        private TextBox tb_tenkh;
        private TextBox tb_makh;
        private Label lb_gioitinh;
        private Label lb_dienthoai;
        private Label lb_diachi;
        private Label lb_email;
        private Label lb_tenkh;
        private Label lb_makh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel2;
        private RadioButton rdb_khd;
        private RadioButton rdb_hd;
        private Label lb_trangthai;
        private Button bt_reset;
    }
}