namespace Presentation
{
    partial class FormHoaDon
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
            this.groupBox_hoadonchitiet = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.BtnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dtghoadonct = new System.Windows.Forms.DataGridView();
            this.groupBox_hoadon = new System.Windows.Forms.GroupBox();
            this.dtghoadon = new System.Windows.Forms.DataGridView();
            this.cbx_locgiaohang = new System.Windows.Forms.ComboBox();
            this.cbx_locthanhtoan = new System.Windows.Forms.ComboBox();
            this.cbx_LocTrangthai = new System.Windows.Forms.ComboBox();
            this.lb_hinhthucgiaohang = new System.Windows.Forms.Label();
            this.lb_hinhthuctt = new System.Windows.Forms.Label();
            this.label_trangthai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox_hoadonchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghoadonct)).BeginInit();
            this.groupBox_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_hoadonchitiet);
            this.panel1.Controls.Add(this.groupBox_hoadon);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 659);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_hoadonchitiet
            // 
            this.groupBox_hoadonchitiet.Controls.Add(this.btnIn);
            this.groupBox_hoadonchitiet.Controls.Add(this.BtnPDF);
            this.groupBox_hoadonchitiet.Controls.Add(this.btnExcel);
            this.groupBox_hoadonchitiet.Controls.Add(this.dtghoadonct);
            this.groupBox_hoadonchitiet.Location = new System.Drawing.Point(9, 401);
            this.groupBox_hoadonchitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_hoadonchitiet.Name = "groupBox_hoadonchitiet";
            this.groupBox_hoadonchitiet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_hoadonchitiet.Size = new System.Drawing.Size(1165, 242);
            this.groupBox_hoadonchitiet.TabIndex = 1;
            this.groupBox_hoadonchitiet.TabStop = false;
            this.groupBox_hoadonchitiet.Text = "Hóa Đơn Chi Tiết";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1073, 80);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // BtnPDF
            // 
            this.BtnPDF.Location = new System.Drawing.Point(1073, 51);
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.Size = new System.Drawing.Size(86, 23);
            this.BtnPDF.TabIndex = 2;
            this.BtnPDF.Text = "PDF";
            this.BtnPDF.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1073, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(86, 23);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dtghoadonct
            // 
            this.dtghoadonct.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtghoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghoadonct.Location = new System.Drawing.Point(15, 22);
            this.dtghoadonct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtghoadonct.Name = "dtghoadonct";
            this.dtghoadonct.RowHeadersWidth = 51;
            this.dtghoadonct.RowTemplate.Height = 29;
            this.dtghoadonct.Size = new System.Drawing.Size(1052, 212);
            this.dtghoadonct.TabIndex = 0;
            // 
            // groupBox_hoadon
            // 
            this.groupBox_hoadon.Controls.Add(this.dtghoadon);
            this.groupBox_hoadon.Controls.Add(this.cbx_locgiaohang);
            this.groupBox_hoadon.Controls.Add(this.cbx_locthanhtoan);
            this.groupBox_hoadon.Controls.Add(this.cbx_LocTrangthai);
            this.groupBox_hoadon.Controls.Add(this.lb_hinhthucgiaohang);
            this.groupBox_hoadon.Controls.Add(this.lb_hinhthuctt);
            this.groupBox_hoadon.Controls.Add(this.label_trangthai);
            this.groupBox_hoadon.Controls.Add(this.textBox1);
            this.groupBox_hoadon.Controls.Add(this.lb_timkiem);
            this.groupBox_hoadon.Location = new System.Drawing.Point(9, 8);
            this.groupBox_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_hoadon.Name = "groupBox_hoadon";
            this.groupBox_hoadon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_hoadon.Size = new System.Drawing.Size(1165, 374);
            this.groupBox_hoadon.TabIndex = 0;
            this.groupBox_hoadon.TabStop = false;
            this.groupBox_hoadon.Text = "Hóa Đơn";
            // 
            // dtghoadon
            // 
            this.dtghoadon.AllowUserToAddRows = false;
            this.dtghoadon.AllowUserToDeleteRows = false;
            this.dtghoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtghoadon.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtghoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghoadon.Location = new System.Drawing.Point(15, 149);
            this.dtghoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtghoadon.MultiSelect = false;
            this.dtghoadon.Name = "dtghoadon";
            this.dtghoadon.ReadOnly = true;
            this.dtghoadon.RowHeadersWidth = 51;
            this.dtghoadon.RowTemplate.Height = 29;
            this.dtghoadon.Size = new System.Drawing.Size(1144, 212);
            this.dtghoadon.TabIndex = 1;
            this.dtghoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghoadon_CellClick);
            // 
            // cbx_locgiaohang
            // 
            this.cbx_locgiaohang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_locgiaohang.FormattingEnabled = true;
            this.cbx_locgiaohang.Items.AddRange(new object[] {
            "Bán Trực Tiếp",
            "Bán Online",
            "None"});
            this.cbx_locgiaohang.Location = new System.Drawing.Point(990, 75);
            this.cbx_locgiaohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_locgiaohang.Name = "cbx_locgiaohang";
            this.cbx_locgiaohang.Size = new System.Drawing.Size(169, 27);
            this.cbx_locgiaohang.TabIndex = 31;
            this.cbx_locgiaohang.SelectedIndexChanged += new System.EventHandler(this.cbx_locgiaohang_SelectedIndexChanged);
            // 
            // cbx_locthanhtoan
            // 
            this.cbx_locthanhtoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_locthanhtoan.FormattingEnabled = true;
            this.cbx_locthanhtoan.Items.AddRange(new object[] {
            "Tiền Mặt",
            "Banking",
            "None"});
            this.cbx_locthanhtoan.Location = new System.Drawing.Point(581, 75);
            this.cbx_locthanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_locthanhtoan.Name = "cbx_locthanhtoan";
            this.cbx_locthanhtoan.Size = new System.Drawing.Size(169, 27);
            this.cbx_locthanhtoan.TabIndex = 30;
            this.cbx_locthanhtoan.SelectedIndexChanged += new System.EventHandler(this.cbx_locthanhtoan_SelectedIndexChanged);
            // 
            // cbx_LocTrangthai
            // 
            this.cbx_LocTrangthai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_LocTrangthai.FormattingEnabled = true;
            this.cbx_LocTrangthai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chờ thanh toán",
            "None"});
            this.cbx_LocTrangthai.Location = new System.Drawing.Point(190, 75);
            this.cbx_LocTrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_LocTrangthai.Name = "cbx_LocTrangthai";
            this.cbx_LocTrangthai.Size = new System.Drawing.Size(169, 27);
            this.cbx_LocTrangthai.TabIndex = 29;
            this.cbx_LocTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbx_LocTrangthai_SelectedIndexChanged);
            // 
            // lb_hinhthucgiaohang
            // 
            this.lb_hinhthucgiaohang.AutoSize = true;
            this.lb_hinhthucgiaohang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_hinhthucgiaohang.Location = new System.Drawing.Point(814, 81);
            this.lb_hinhthucgiaohang.Name = "lb_hinhthucgiaohang";
            this.lb_hinhthucgiaohang.Size = new System.Drawing.Size(145, 19);
            this.lb_hinhthucgiaohang.TabIndex = 28;
            this.lb_hinhthucgiaohang.Text = "Hình Thức Giao Hàng";
            // 
            // lb_hinhthuctt
            // 
            this.lb_hinhthuctt.AutoSize = true;
            this.lb_hinhthuctt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_hinhthuctt.Location = new System.Drawing.Point(399, 81);
            this.lb_hinhthuctt.Name = "lb_hinhthuctt";
            this.lb_hinhthuctt.Size = new System.Drawing.Size(152, 19);
            this.lb_hinhthuctt.TabIndex = 27;
            this.lb_hinhthuctt.Text = "Hình Thức Thanh Toán";
            // 
            // label_trangthai
            // 
            this.label_trangthai.AutoSize = true;
            this.label_trangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_trangthai.Location = new System.Drawing.Point(15, 81);
            this.label_trangthai.Name = "label_trangthai";
            this.label_trangthai.Size = new System.Drawing.Size(152, 19);
            this.label_trangthai.TabIndex = 26;
            this.label_trangthai.Text = "Trạng Thái Thanh Toán";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(334, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm Kiếm Theo Mã";
            this.textBox1.Size = new System.Drawing.Size(416, 27);
            this.textBox1.TabIndex = 25;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_timkiem.Location = new System.Drawing.Point(128, 30);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(129, 19);
            this.lb_timkiem.TabIndex = 1;
            this.lb_timkiem.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox_hoadonchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtghoadonct)).EndInit();
            this.groupBox_hoadon.ResumeLayout(false);
            this.groupBox_hoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtghoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox_hoadon;
        private GroupBox groupBox_hoadonchitiet;
        private DataGridView dtghoadonct;
        private Label lb_timkiem;
        private TextBox textBox1;
        private Label lb_hinhthucgiaohang;
        private Label lb_hinhthuctt;
        private Label label_trangthai;
        private DataGridView dtghoadon;
        private ComboBox cbx_locgiaohang;
        private ComboBox cbx_locthanhtoan;
        private ComboBox cbx_LocTrangthai;
        private Button btnIn;
        private Button BtnPDF;
        private Button btnExcel;
    }
}