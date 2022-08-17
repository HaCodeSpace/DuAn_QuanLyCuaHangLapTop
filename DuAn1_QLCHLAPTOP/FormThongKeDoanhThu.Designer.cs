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
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            this.cbx_thang = new System.Windows.Forms.ComboBox();
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
            this.bt_guibaocao.Location = new System.Drawing.Point(998, 518);
            this.bt_guibaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_guibaocao.Name = "bt_guibaocao";
            this.bt_guibaocao.Size = new System.Drawing.Size(132, 28);
            this.bt_guibaocao.TabIndex = 47;
            this.bt_guibaocao.Text = "Gửi Báo Cáo";
            this.bt_guibaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_guibaocao.UseVisualStyleBackColor = false;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nam.Location = new System.Drawing.Point(36, 58);
            this.rdb_nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(57, 23);
            this.rdb_nam.TabIndex = 46;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Năm";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // cbx_nam
            // 
            this.cbx_nam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Location = new System.Drawing.Point(167, 55);
            this.cbx_nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(169, 27);
            this.cbx_nam.TabIndex = 42;
            this.cbx_nam.SelectedIndexChanged += new System.EventHandler(this.cbx_nam_SelectedIndexChanged);
            // 
            // cbx_thang
            // 
            this.cbx_thang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_thang.FormattingEnabled = true;
            this.cbx_thang.Location = new System.Drawing.Point(167, 96);
            this.cbx_thang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_thang.Name = "cbx_thang";
            this.cbx_thang.Size = new System.Drawing.Size(169, 27);
            this.cbx_thang.TabIndex = 41;
            this.cbx_thang.SelectedIndexChanged += new System.EventHandler(this.cbx_thang_SelectedIndexChanged);
            // 
            // rdb_thang
            // 
            this.rdb_thang.AutoSize = true;
            this.rdb_thang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_thang.Location = new System.Drawing.Point(36, 99);
            this.rdb_thang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_thang.Name = "rdb_thang";
            this.rdb_thang.Size = new System.Drawing.Size(66, 23);
            this.rdb_thang.TabIndex = 45;
            this.rdb_thang.TabStop = true;
            this.rdb_thang.Text = "Tháng";
            this.rdb_thang.UseVisualStyleBackColor = true;
            // 
            // rdb_tatca
            // 
            this.rdb_tatca.AutoSize = true;
            this.rdb_tatca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_tatca.Location = new System.Drawing.Point(36, 22);
            this.rdb_tatca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_tatca.Name = "rdb_tatca";
            this.rdb_tatca.Size = new System.Drawing.Size(67, 23);
            this.rdb_tatca.TabIndex = 44;
            this.rdb_tatca.TabStop = true;
            this.rdb_tatca.Text = "Tất Cả";
            this.rdb_tatca.UseVisualStyleBackColor = true;
            this.rdb_tatca.CheckedChanged += new System.EventHandler(this.rdb_tatca_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 363);
            this.dataGridView1.TabIndex = 43;
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.bt_guibaocao);
            this.Controls.Add(this.rdb_nam);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.cbx_thang);
            this.Controls.Add(this.rdb_thang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdb_tatca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_guibaocao;
        private RadioButton rdb_nam;
        private ComboBox cbx_nam;
        private ComboBox cbx_thang;
        private RadioButton rdb_thang;
        private RadioButton rdb_tatca;
        private DataGridView dataGridView1;
    }
}