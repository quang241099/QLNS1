
namespace QLNS1.GUI
{
    partial class LUONG_NHANVIEN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLuongNV = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLuongNV
            // 
            this.dataGridViewLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuong,
            this.MaNhanVien,
            this.LuongHD,
            this.SoNgayCong,
            this.ThangNam,
            this.TienBH});
            this.dataGridViewLuongNV.Location = new System.Drawing.Point(33, 122);
            this.dataGridViewLuongNV.Name = "dataGridViewLuongNV";
            this.dataGridViewLuongNV.RowHeadersWidth = 51;
            this.dataGridViewLuongNV.RowTemplate.Height = 24;
            this.dataGridViewLuongNV.Size = new System.Drawing.Size(1333, 448);
            this.dataGridViewLuongNV.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(471, 50);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(275, 42);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(752, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 42);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập tháng hoặc năm:";
            // 
            // MaLuong
            // 
            this.MaLuong.DataPropertyName = "MaLuong";
            this.MaLuong.HeaderText = "Mã lương";
            this.MaLuong.MinimumWidth = 6;
            this.MaLuong.Name = "MaLuong";
            this.MaLuong.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // LuongHD
            // 
            this.LuongHD.DataPropertyName = "LuongHD";
            this.LuongHD.HeaderText = "Lương hợp đồng";
            this.LuongHD.MinimumWidth = 6;
            this.LuongHD.Name = "LuongHD";
            this.LuongHD.Width = 125;
            // 
            // SoNgayCong
            // 
            this.SoNgayCong.DataPropertyName = "SoNgayCong";
            this.SoNgayCong.HeaderText = "Số ngày công";
            this.SoNgayCong.MinimumWidth = 6;
            this.SoNgayCong.Name = "SoNgayCong";
            this.SoNgayCong.Width = 125;
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Tháng năm";
            this.ThangNam.MinimumWidth = 6;
            this.ThangNam.Name = "ThangNam";
            this.ThangNam.Width = 125;
            // 
            // TienBH
            // 
            this.TienBH.DataPropertyName = "TienBH";
            this.TienBH.HeaderText = "Tiền bảo hiểm";
            this.TienBH.MinimumWidth = 6;
            this.TienBH.Name = "TienBH";
            this.TienBH.Width = 125;
            // 
            // LUONG_NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGridViewLuongNV);
            this.Name = "LUONG_NHANVIEN";
            this.Size = new System.Drawing.Size(1414, 603);
            this.Load += new System.EventHandler(this.LUONG_NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuongNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLuongNV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienBH;
        private System.Windows.Forms.Label label1;
    }
}
