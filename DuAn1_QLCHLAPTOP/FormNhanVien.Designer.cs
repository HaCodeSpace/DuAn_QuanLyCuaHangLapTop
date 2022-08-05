namespace Presentation
{
    partial class FormNhanVien
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox_thongtin = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_loctrangthai = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_locvaitro = new System.Windows.Forms.Label();
            this.groupBox_thietlap = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.rdb_nghiviec = new System.Windows.Forms.RadioButton();
            this.rdb_danglam = new System.Windows.Forms.RadioButton();
            this.comboBox_vaitro = new System.Windows.Forms.ComboBox();
            this.tb_ngaysinh = new System.Windows.Forms.TextBox();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_tennv = new System.Windows.Forms.TextBox();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_dienthoai = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_vaitro = new System.Windows.Forms.Label();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_thietlap.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox_thongtin);
            this.panel3.Controls.Add(this.groupBox_thietlap);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1410, 879);
            this.panel3.TabIndex = 1;
            // 
            // groupBox_thongtin
            // 
            this.groupBox_thongtin.Controls.Add(this.textBox1);
            this.groupBox_thongtin.Controls.Add(this.dataGridView1);
            this.groupBox_thongtin.Controls.Add(this.comboBox2);
            this.groupBox_thongtin.Controls.Add(this.lb_loctrangthai);
            this.groupBox_thongtin.Controls.Add(this.comboBox1);
            this.groupBox_thongtin.Controls.Add(this.lb_locvaitro);
            this.groupBox_thongtin.Location = new System.Drawing.Point(19, 393);
            this.groupBox_thongtin.Name = "groupBox_thongtin";
            this.groupBox_thongtin.Size = new System.Drawing.Size(1331, 458);
            this.groupBox_thongtin.TabIndex = 1;
            this.groupBox_thongtin.TabStop = false;
            this.groupBox_thongtin.Text = "Thông Tin Nhân Viên";
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 300);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Đang Làm",
            "Nghỉ Việc"});
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
            "Quản Lý",
            "Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(173, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 31);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lb_locvaitro
            // 
            this.lb_locvaitro.AutoSize = true;
            this.lb_locvaitro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_locvaitro.Location = new System.Drawing.Point(14, 61);
            this.lb_locvaitro.Name = "lb_locvaitro";
            this.lb_locvaitro.Size = new System.Drawing.Size(136, 23);
            this.lb_locvaitro.TabIndex = 24;
            this.lb_locvaitro.Text = "Lọc Theo Vai Trò";
            // 
            // groupBox_thietlap
            // 
            this.groupBox_thietlap.Controls.Add(this.panel1);
            this.groupBox_thietlap.Controls.Add(this.bt_sua);
            this.groupBox_thietlap.Controls.Add(this.bt_them);
            this.groupBox_thietlap.Controls.Add(this.rdb_nghiviec);
            this.groupBox_thietlap.Controls.Add(this.rdb_danglam);
            this.groupBox_thietlap.Controls.Add(this.comboBox_vaitro);
            this.groupBox_thietlap.Controls.Add(this.tb_ngaysinh);
            this.groupBox_thietlap.Controls.Add(this.tb_dienthoai);
            this.groupBox_thietlap.Controls.Add(this.tb_diachi);
            this.groupBox_thietlap.Controls.Add(this.tb_matkhau);
            this.groupBox_thietlap.Controls.Add(this.tb_email);
            this.groupBox_thietlap.Controls.Add(this.tb_tennv);
            this.groupBox_thietlap.Controls.Add(this.tb_manv);
            this.groupBox_thietlap.Controls.Add(this.lb_trangthai);
            this.groupBox_thietlap.Controls.Add(this.lb_gioitinh);
            this.groupBox_thietlap.Controls.Add(this.lb_ngaysinh);
            this.groupBox_thietlap.Controls.Add(this.lb_dienthoai);
            this.groupBox_thietlap.Controls.Add(this.lb_diachi);
            this.groupBox_thietlap.Controls.Add(this.lb_email);
            this.groupBox_thietlap.Controls.Add(this.lb_vaitro);
            this.groupBox_thietlap.Controls.Add(this.lb_matkhau);
            this.groupBox_thietlap.Controls.Add(this.lb_tennv);
            this.groupBox_thietlap.Controls.Add(this.lb_manv);
            this.groupBox_thietlap.Location = new System.Drawing.Point(19, 17);
            this.groupBox_thietlap.Name = "groupBox_thietlap";
            this.groupBox_thietlap.Size = new System.Drawing.Size(1331, 358);
            this.groupBox_thietlap.TabIndex = 0;
            this.groupBox_thietlap.TabStop = false;
            this.groupBox_thietlap.Text = "Thiết Lập Thông Tin Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_nu);
            this.panel1.Controls.Add(this.rdb_nam);
            this.panel1.Location = new System.Drawing.Point(858, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 30);
            this.panel1.TabIndex = 24;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nu.Location = new System.Drawing.Point(160, 2);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(55, 27);
            this.rdb_nu.TabIndex = 19;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Checked = true;
            this.rdb_nam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nam.Location = new System.Drawing.Point(15, 2);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(73, 27);
            this.rdb_nam.TabIndex = 18;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam ";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_sua.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.Location = new System.Drawing.Point(730, 303);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(101, 37);
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
            this.bt_them.Location = new System.Drawing.Point(482, 303);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(101, 37);
            this.bt_them.TabIndex = 22;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // rdb_nghiviec
            // 
            this.rdb_nghiviec.AutoSize = true;
            this.rdb_nghiviec.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nghiviec.Location = new System.Drawing.Point(1018, 243);
            this.rdb_nghiviec.Name = "rdb_nghiviec";
            this.rdb_nghiviec.Size = new System.Drawing.Size(105, 27);
            this.rdb_nghiviec.TabIndex = 21;
            this.rdb_nghiviec.Text = "Nghỉ Việc";
            this.rdb_nghiviec.UseVisualStyleBackColor = true;
            // 
            // rdb_danglam
            // 
            this.rdb_danglam.AutoSize = true;
            this.rdb_danglam.Checked = true;
            this.rdb_danglam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_danglam.Location = new System.Drawing.Point(873, 243);
            this.rdb_danglam.Name = "rdb_danglam";
            this.rdb_danglam.Size = new System.Drawing.Size(109, 27);
            this.rdb_danglam.TabIndex = 20;
            this.rdb_danglam.TabStop = true;
            this.rdb_danglam.Text = "Đang Làm";
            this.rdb_danglam.UseVisualStyleBackColor = true;
            // 
            // comboBox_vaitro
            // 
            this.comboBox_vaitro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_vaitro.FormattingEnabled = true;
            this.comboBox_vaitro.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.comboBox_vaitro.Location = new System.Drawing.Point(320, 151);
            this.comboBox_vaitro.Name = "comboBox_vaitro";
            this.comboBox_vaitro.Size = new System.Drawing.Size(193, 31);
            this.comboBox_vaitro.TabIndex = 17;
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ngaysinh.Location = new System.Drawing.Point(851, 145);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(263, 30);
            this.tb_ngaysinh.TabIndex = 16;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dienthoai.Location = new System.Drawing.Point(851, 98);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(263, 30);
            this.tb_dienthoai.TabIndex = 15;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diachi.Location = new System.Drawing.Point(851, 50);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(263, 30);
            this.tb_diachi.TabIndex = 14;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_matkhau.Location = new System.Drawing.Point(320, 236);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(263, 30);
            this.tb_matkhau.TabIndex = 13;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(320, 190);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(263, 30);
            this.tb_email.TabIndex = 12;
            // 
            // tb_tennv
            // 
            this.tb_tennv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tennv.Location = new System.Drawing.Point(320, 98);
            this.tb_tennv.Name = "tb_tennv";
            this.tb_tennv.Size = new System.Drawing.Size(263, 30);
            this.tb_tennv.TabIndex = 11;
            // 
            // tb_manv
            // 
            this.tb_manv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_manv.Location = new System.Drawing.Point(320, 53);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(263, 30);
            this.tb_manv.TabIndex = 10;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_trangthai.Location = new System.Drawing.Point(730, 243);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(90, 23);
            this.lb_trangthai.TabIndex = 9;
            this.lb_trangthai.Text = "Trạng Thái";
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gioitinh.Location = new System.Drawing.Point(730, 197);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(78, 23);
            this.lb_gioitinh.TabIndex = 8;
            this.lb_gioitinh.Text = "Giới Tính";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaysinh.Location = new System.Drawing.Point(730, 152);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(89, 23);
            this.lb_ngaysinh.TabIndex = 7;
            this.lb_ngaysinh.Text = "Ngày Sinh";
            // 
            // lb_dienthoai
            // 
            this.lb_dienthoai.AutoSize = true;
            this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dienthoai.Location = new System.Drawing.Point(730, 105);
            this.lb_dienthoai.Name = "lb_dienthoai";
            this.lb_dienthoai.Size = new System.Drawing.Size(92, 23);
            this.lb_dienthoai.TabIndex = 6;
            this.lb_dienthoai.Text = "Điện Thoại";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_diachi.Location = new System.Drawing.Point(730, 57);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(65, 23);
            this.lb_diachi.TabIndex = 5;
            this.lb_diachi.Text = "Địa Chỉ";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(148, 197);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(51, 23);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Email";
            // 
            // lb_vaitro
            // 
            this.lb_vaitro.AutoSize = true;
            this.lb_vaitro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_vaitro.Location = new System.Drawing.Point(148, 152);
            this.lb_vaitro.Name = "lb_vaitro";
            this.lb_vaitro.Size = new System.Drawing.Size(62, 23);
            this.lb_vaitro.TabIndex = 3;
            this.lb_vaitro.Text = "Vai Trò";
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_matkhau.Location = new System.Drawing.Point(148, 243);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(85, 23);
            this.lb_matkhau.TabIndex = 2;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tennv.Location = new System.Drawing.Point(148, 105);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(122, 23);
            this.lb_tennv.TabIndex = 1;
            this.lb_tennv.Text = "Tên Nhân Viên";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_manv.Location = new System.Drawing.Point(148, 57);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(121, 23);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã Nhân Viên";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 903);
            this.Controls.Add(this.panel3);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.panel3.ResumeLayout(false);
            this.groupBox_thongtin.ResumeLayout(false);
            this.groupBox_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_thietlap.ResumeLayout(false);
            this.groupBox_thietlap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private GroupBox groupBox_thongtin;
        private GroupBox groupBox_thietlap;
        private Label lb_email;
        private Label lb_vaitro;
        private Label lb_matkhau;
        private Label lb_tennv;
        private Label lb_manv;
        private TextBox tb_dienthoai;
        private TextBox tb_diachi;
        private TextBox tb_matkhau;
        private TextBox tb_email;
        private TextBox tb_tennv;
        private TextBox tb_manv;
        private Label lb_trangthai;
        private Label lb_gioitinh;
        private Label lb_ngaysinh;
        private Label lb_dienthoai;
        private Label lb_diachi;
        private TextBox tb_ngaysinh;
        private ComboBox comboBox_vaitro;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label lb_loctrangthai;
        private ComboBox comboBox1;
        private Label lb_locvaitro;
        private Button bt_sua;
        private Button bt_them;
        private RadioButton rdb_nghiviec;
        private RadioButton rdb_danglam;
        private RadioButton rdb_nu;
        private RadioButton rdb_nam;
        private Panel panel1;
    }
}