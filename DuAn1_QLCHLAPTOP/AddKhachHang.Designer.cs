namespace Presentation
{
    partial class AddKhachHang
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
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgListview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListview)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(139, 56);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(329, 27);
            this.tb_timkiem.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgListview
            // 
            this.dtgListview.AllowUserToAddRows = false;
            this.dtgListview.AllowUserToDeleteRows = false;
            this.dtgListview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListview.Location = new System.Drawing.Point(48, 108);
            this.dtgListview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListview.MultiSelect = false;
            this.dtgListview.Name = "dtgListview";
            this.dtgListview.ReadOnly = true;
            this.dtgListview.RowHeadersWidth = 51;
            this.dtgListview.RowTemplate.Height = 25;
            this.dtgListview.Size = new System.Drawing.Size(623, 323);
            this.dtgListview.TabIndex = 2;
            this.dtgListview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListview_CellContentClick);
            this.dtgListview.DoubleClick += new System.EventHandler(this.dtgListview_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgListview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_timkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKhachHang";
            this.Load += new System.EventHandler(this.AddKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_timkiem;
        private Button button1;
        private DataGridView dtgListview;
        private Button button2;
    }
}