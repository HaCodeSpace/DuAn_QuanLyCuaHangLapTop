namespace Presentation
{
    partial class FormThongKeDoanhThu
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
            this.bt_guibaocao = new System.Windows.Forms.Button();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdb_thang = new System.Windows.Forms.RadioButton();
            this.rdb_tatca = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_guibaocao
            // 
            this.bt_guibaocao.BackColor = System.Drawing.Color.Yellow;
            this.bt_guibaocao.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_guibaocao.ForeColor = System.Drawing.Color.Black;
            this.bt_guibaocao.Image = global::Presentation.Properties.Resources.tap;
            this.bt_guibaocao.Location = new System.Drawing.Point(1140, 690);
            this.bt_guibaocao.Name = "bt_guibaocao";
            this.bt_guibaocao.Size = new System.Drawing.Size(151, 37);
            this.bt_guibaocao.TabIndex = 47;
            this.bt_guibaocao.Text = "Gửi Báo Cáo";
            this.bt_guibaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_guibaocao.UseVisualStyleBackColor = false;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nam.Location = new System.Drawing.Point(41, 77);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(68, 27);
            this.rdb_nam.TabIndex = 46;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Năm";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2022",
            "2023"});
            this.comboBox2.Location = new System.Drawing.Point(191, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 31);
            this.comboBox2.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.comboBox1.Location = new System.Drawing.Point(191, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 31);
            this.comboBox1.TabIndex = 41;
            // 
            // rdb_thang
            // 
            this.rdb_thang.AutoSize = true;
            this.rdb_thang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_thang.Location = new System.Drawing.Point(41, 132);
            this.rdb_thang.Name = "rdb_thang";
            this.rdb_thang.Size = new System.Drawing.Size(79, 27);
            this.rdb_thang.TabIndex = 45;
            this.rdb_thang.TabStop = true;
            this.rdb_thang.Text = "Tháng";
            this.rdb_thang.UseVisualStyleBackColor = true;
            // 
            // rdb_tatca
            // 
            this.rdb_tatca.AutoSize = true;
            this.rdb_tatca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_tatca.Location = new System.Drawing.Point(41, 30);
            this.rdb_tatca.Name = "rdb_tatca";
            this.rdb_tatca.Size = new System.Drawing.Size(80, 27);
            this.rdb_tatca.TabIndex = 44;
            this.rdb_tatca.TabStop = true;
            this.rdb_tatca.Text = "Tất Cả";
            this.rdb_tatca.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 484);
            this.dataGridView1.TabIndex = 43;
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 1020);
            this.Controls.Add(this.bt_guibaocao);
            this.Controls.Add(this.rdb_nam);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdb_thang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdb_tatca);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_guibaocao;
        private RadioButton rdb_nam;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RadioButton rdb_thang;
        private RadioButton rdb_tatca;
        private DataGridView dataGridView1;
    }
}