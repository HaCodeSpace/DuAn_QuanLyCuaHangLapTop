namespace Presentation
{
    partial class FormSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_thietlap = new System.Windows.Forms.GroupBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_mausac = new System.Windows.Forms.Label();
            this.lb_dongsp = new System.Windows.Forms.Label();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.comboBox_dongsp = new System.Windows.Forms.ComboBox();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.tb_gianhap = new System.Windows.Forms.TextBox();
            this.lb_gianhap = new System.Windows.Forms.Label();
            this.lb_giaban = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.groupBox_thongtin = new System.Windows.Forms.GroupBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_mau = new System.Windows.Forms.ComboBox();
            this.lb_mau = new System.Windows.Forms.Label();
            this.lb_dongsanpham = new System.Windows.Forms.Label();
            this.comboBox_dongspTTSP = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_thietlap.SuspendLayout();
            this.groupBox_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 51);
            this.label1.TabIndex = 0;
            // 
            // groupBox_thietlap
            // 
            this.groupBox_thietlap.Controls.Add(this.tb_soluong);
            this.groupBox_thietlap.Controls.Add(this.btnclear);
            this.groupBox_thietlap.Controls.Add(this.panel2);
            this.groupBox_thietlap.Controls.Add(this.tb_ghichu);
            this.groupBox_thietlap.Controls.Add(this.lb_ghichu);
            this.groupBox_thietlap.Controls.Add(this.lb_mausac);
            this.groupBox_thietlap.Controls.Add(this.lb_dongsp);
            this.groupBox_thietlap.Controls.Add(this.tb_tensp);
            this.groupBox_thietlap.Controls.Add(this.bt_sua);
            this.groupBox_thietlap.Controls.Add(this.bt_them);
            this.groupBox_thietlap.Controls.Add(this.comboBox_dongsp);
            this.groupBox_thietlap.Controls.Add(this.tb_giaban);
            this.groupBox_thietlap.Controls.Add(this.tb_gianhap);
            this.groupBox_thietlap.Controls.Add(this.lb_gianhap);
            this.groupBox_thietlap.Controls.Add(this.lb_giaban);
            this.groupBox_thietlap.Controls.Add(this.lb_tensp);
            this.groupBox_thietlap.Location = new System.Drawing.Point(3, 13);
            this.groupBox_thietlap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_thietlap.Name = "groupBox_thietlap";
            this.groupBox_thietlap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_thietlap.Size = new System.Drawing.Size(1165, 333);
            this.groupBox_thietlap.TabIndex = 1;
            this.groupBox_thietlap.TabStop = false;
            this.groupBox_thietlap.Text = "Thiết Lập Thông Tin Sản Phẩm";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_soluong.Location = new System.Drawing.Point(196, 187);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(231, 26);
            this.tb_soluong.TabIndex = 32;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Image = global::Presentation.Properties.Resources.refresh;
            this.btnclear.Location = new System.Drawing.Point(54, 274);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(83, 39);
            this.btnclear.TabIndex = 31;
            this.btnclear.Text = "Clear";
            this.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(431, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 292);
            this.panel2.TabIndex = 30;
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ghichu.Location = new System.Drawing.Point(196, 231);
            this.tb_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(231, 26);
            this.tb_ghichu.TabIndex = 29;
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ghichu.Location = new System.Drawing.Point(40, 236);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(60, 19);
            this.lb_ghichu.TabIndex = 27;
            this.lb_ghichu.Text = "Ghi Chú";
            // 
            // lb_mausac
            // 
            this.lb_mausac.AutoSize = true;
            this.lb_mausac.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mausac.Location = new System.Drawing.Point(40, 194);
            this.lb_mausac.Name = "lb_mausac";
            this.lb_mausac.Size = new System.Drawing.Size(67, 19);
            this.lb_mausac.TabIndex = 26;
            this.lb_mausac.Text = "Số lượng";
            // 
            // lb_dongsp
            // 
            this.lb_dongsp.AutoSize = true;
            this.lb_dongsp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dongsp.Location = new System.Drawing.Point(40, 68);
            this.lb_dongsp.Name = "lb_dongsp";
            this.lb_dongsp.Size = new System.Drawing.Size(109, 19);
            this.lb_dongsp.TabIndex = 25;
            this.lb_dongsp.Text = "Dòng Sản Phẩm";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tensp.Location = new System.Drawing.Point(196, 20);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(231, 26);
            this.tb_tensp.TabIndex = 24;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Yellow;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.Color.Black;
            this.bt_sua.Image = global::Presentation.Properties.Resources.maintenance;
            this.bt_sua.Location = new System.Drawing.Point(343, 274);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(83, 39);
            this.bt_sua.TabIndex = 23;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Yellow;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Image = global::Presentation.Properties.Resources.add;
            this.bt_them.Location = new System.Drawing.Point(196, 274);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(83, 39);
            this.bt_them.TabIndex = 22;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // comboBox_dongsp
            // 
            this.comboBox_dongsp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_dongsp.FormattingEnabled = true;
            this.comboBox_dongsp.Items.AddRange(new object[] {
            "Laptop",
            "Bàn Phím",
            "Chuột"});
            this.comboBox_dongsp.Location = new System.Drawing.Point(196, 62);
            this.comboBox_dongsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_dongsp.Name = "comboBox_dongsp";
            this.comboBox_dongsp.Size = new System.Drawing.Size(231, 27);
            this.comboBox_dongsp.TabIndex = 17;
            this.comboBox_dongsp.SelectedIndexChanged += new System.EventHandler(this.comboBox_dongsp_SelectedIndexChanged);
            // 
            // tb_giaban
            // 
            this.tb_giaban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_giaban.Location = new System.Drawing.Point(196, 147);
            this.tb_giaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.PlaceholderText = "                                           VND";
            this.tb_giaban.Size = new System.Drawing.Size(231, 26);
            this.tb_giaban.TabIndex = 13;
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_gianhap.Location = new System.Drawing.Point(196, 108);
            this.tb_gianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.PlaceholderText = "                                           VND";
            this.tb_gianhap.Size = new System.Drawing.Size(231, 26);
            this.tb_gianhap.TabIndex = 12;
            // 
            // lb_gianhap
            // 
            this.lb_gianhap.AutoSize = true;
            this.lb_gianhap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gianhap.Location = new System.Drawing.Point(40, 113);
            this.lb_gianhap.Name = "lb_gianhap";
            this.lb_gianhap.Size = new System.Drawing.Size(68, 19);
            this.lb_gianhap.TabIndex = 4;
            this.lb_gianhap.Text = "Giá Nhập";
            // 
            // lb_giaban
            // 
            this.lb_giaban.AutoSize = true;
            this.lb_giaban.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_giaban.Location = new System.Drawing.Point(40, 153);
            this.lb_giaban.Name = "lb_giaban";
            this.lb_giaban.Size = new System.Drawing.Size(57, 19);
            this.lb_giaban.TabIndex = 2;
            this.lb_giaban.Text = "Giá Bán";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tensp.Location = new System.Drawing.Point(40, 25);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(97, 19);
            this.lb_tensp.TabIndex = 1;
            this.lb_tensp.Text = "Tên Sản Phẩm";
            // 
            // groupBox_thongtin
            // 
            this.groupBox_thongtin.Controls.Add(this.tb_timkiem);
            this.groupBox_thongtin.Controls.Add(this.dataGridView1);
            this.groupBox_thongtin.Controls.Add(this.comboBox_mau);
            this.groupBox_thongtin.Controls.Add(this.lb_mau);
            this.groupBox_thongtin.Controls.Add(this.lb_dongsanpham);
            this.groupBox_thongtin.Controls.Add(this.comboBox_dongspTTSP);
            this.groupBox_thongtin.Location = new System.Drawing.Point(3, 365);
            this.groupBox_thongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_thongtin.Name = "groupBox_thongtin";
            this.groupBox_thongtin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_thongtin.Size = new System.Drawing.Size(1165, 286);
            this.groupBox_thongtin.TabIndex = 2;
            this.groupBox_thongtin.TabStop = false;
            this.groupBox_thongtin.Text = "Thông Tin Sản Phẩm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_timkiem.Location = new System.Drawing.Point(882, 41);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.PlaceholderText = "Tìm Kiếm Theo Tên Sản Phẩm";
            this.tb_timkiem.Size = new System.Drawing.Size(239, 24);
            this.tb_timkiem.TabIndex = 24;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 194);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_mau
            // 
            this.comboBox_mau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_mau.FormattingEnabled = true;
            this.comboBox_mau.Items.AddRange(new object[] {
            "100.000 - 300.000",
            "300.000 - 500.000",
            "500.000 - 1.000.000",
            "1.000.000 - 2.000.000",
            "2.000.000 ->"});
            this.comboBox_mau.Location = new System.Drawing.Point(510, 41);
            this.comboBox_mau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_mau.Name = "comboBox_mau";
            this.comboBox_mau.Size = new System.Drawing.Size(169, 27);
            this.comboBox_mau.TabIndex = 26;
            this.comboBox_mau.SelectedIndexChanged += new System.EventHandler(this.comboBox_mau_SelectedIndexChanged);
            // 
            // lb_mau
            // 
            this.lb_mau.AutoSize = true;
            this.lb_mau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mau.Location = new System.Drawing.Point(469, 44);
            this.lb_mau.Name = "lb_mau";
            this.lb_mau.Size = new System.Drawing.Size(35, 21);
            this.lb_mau.TabIndex = 24;
            this.lb_mau.Text = "Giá";
            // 
            // lb_dongsanpham
            // 
            this.lb_dongsanpham.AutoSize = true;
            this.lb_dongsanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dongsanpham.Location = new System.Drawing.Point(35, 44);
            this.lb_dongsanpham.Name = "lb_dongsanpham";
            this.lb_dongsanpham.Size = new System.Drawing.Size(132, 21);
            this.lb_dongsanpham.TabIndex = 25;
            this.lb_dongsanpham.Text = "Dòng Sản Phẩm";
            // 
            // comboBox_dongspTTSP
            // 
            this.comboBox_dongspTTSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_dongspTTSP.FormattingEnabled = true;
            this.comboBox_dongspTTSP.Items.AddRange(new object[] {
            "Laptop",
            "Bàn Phím",
            "Chuột"});
            this.comboBox_dongspTTSP.Location = new System.Drawing.Point(173, 41);
            this.comboBox_dongspTTSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_dongspTTSP.Name = "comboBox_dongspTTSP";
            this.comboBox_dongspTTSP.Size = new System.Drawing.Size(169, 27);
            this.comboBox_dongspTTSP.TabIndex = 24;
            this.comboBox_dongspTTSP.SelectedIndexChanged += new System.EventHandler(this.comboBox_dongspTTSP_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_thongtin);
            this.panel1.Controls.Add(this.groupBox_thietlap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 659);
            this.panel1.TabIndex = 1;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.groupBox_thietlap.ResumeLayout(false);
            this.groupBox_thietlap.PerformLayout();
            this.groupBox_thongtin.ResumeLayout(false);
            this.groupBox_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox_thietlap;
        private TextBox tb_soluong;
        private Button btnclear;
        private Panel panel2;
        private TextBox tb_ghichu;
        private Label lb_ghichu;
        private Label lb_mausac;
        private Label lb_dongsp;
        private TextBox tb_tensp;
        private Button bt_sua;
        private Button bt_them;
        private ComboBox comboBox_dongsp;
        private TextBox tb_giaban;
        private TextBox tb_gianhap;
        private Label lb_gianhap;
        private Label lb_giaban;
        private Label lb_tensp;
        private GroupBox groupBox_thongtin;
        private TextBox tb_timkiem;
        private DataGridView dataGridView1;
        private ComboBox comboBox_mau;
        private Label lb_mau;
        private Label lb_dongsanpham;
        private ComboBox comboBox_dongspTTSP;
        private Panel panel1;
    }
}