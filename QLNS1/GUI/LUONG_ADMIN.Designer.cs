
namespace QLNS1.GUI
{
    partial class LUONG_ADMIN
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
               this.btnTimKiem = new System.Windows.Forms.Button();
               this.txtTimKiem = new System.Windows.Forms.TextBox();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnBaoCao = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.btnSua = new System.Windows.Forms.Button();
               this.btnThem = new System.Windows.Forms.Button();
               this.txtTienBH = new System.Windows.Forms.TextBox();
               this.txtThangNam = new System.Windows.Forms.TextBox();
               this.txtNgayCong = new System.Windows.Forms.TextBox();
               this.txtLuongHD = new System.Windows.Forms.TextBox();
               this.txtMaNV = new System.Windows.Forms.TextBox();
               this.txtMaLuong = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.dataGridViewLuong = new System.Windows.Forms.DataGridView();
               this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.LuongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.SoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TienBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).BeginInit();
               this.SuspendLayout();
               // 
               // btnTimKiem
               // 
               this.btnTimKiem.Location = new System.Drawing.Point(710, 21);
               this.btnTimKiem.Name = "btnTimKiem";
               this.btnTimKiem.Size = new System.Drawing.Size(111, 31);
               this.btnTimKiem.TabIndex = 24;
               this.btnTimKiem.Text = "Tìm kiếm";
               this.btnTimKiem.UseVisualStyleBackColor = true;
               this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
               // 
               // txtTimKiem
               // 
               this.txtTimKiem.Location = new System.Drawing.Point(384, 21);
               this.txtTimKiem.Multiline = true;
               this.txtTimKiem.Name = "txtTimKiem";
               this.txtTimKiem.Size = new System.Drawing.Size(297, 31);
               this.txtTimKiem.TabIndex = 23;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.btnBaoCao);
               this.groupBox1.Controls.Add(this.btnLuu);
               this.groupBox1.Controls.Add(this.btnXoa);
               this.groupBox1.Controls.Add(this.btnSua);
               this.groupBox1.Controls.Add(this.btnThem);
               this.groupBox1.Controls.Add(this.txtTienBH);
               this.groupBox1.Controls.Add(this.txtThangNam);
               this.groupBox1.Controls.Add(this.txtNgayCong);
               this.groupBox1.Controls.Add(this.txtLuongHD);
               this.groupBox1.Controls.Add(this.txtMaNV);
               this.groupBox1.Controls.Add(this.txtMaLuong);
               this.groupBox1.Controls.Add(this.label6);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label3);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Location = new System.Drawing.Point(1182, 86);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(364, 561);
               this.groupBox1.TabIndex = 22;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin lương nhân viên";
               // 
               // btnBaoCao
               // 
               this.btnBaoCao.Location = new System.Drawing.Point(124, 507);
               this.btnBaoCao.Name = "btnBaoCao";
               this.btnBaoCao.Size = new System.Drawing.Size(119, 35);
               this.btnBaoCao.TabIndex = 17;
               this.btnBaoCao.Text = "Báo cáo";
               this.btnBaoCao.UseVisualStyleBackColor = true;
               this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
               // 
               // btnLuu
               // 
               this.btnLuu.Location = new System.Drawing.Point(146, 445);
               this.btnLuu.Name = "btnLuu";
               this.btnLuu.Size = new System.Drawing.Size(75, 31);
               this.btnLuu.TabIndex = 16;
               this.btnLuu.Text = "Lưu";
               this.btnLuu.UseVisualStyleBackColor = true;
               this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
               // 
               // btnXoa
               // 
               this.btnXoa.Location = new System.Drawing.Point(271, 387);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(75, 31);
               this.btnXoa.TabIndex = 15;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.UseVisualStyleBackColor = true;
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnSua
               // 
               this.btnSua.Location = new System.Drawing.Point(146, 387);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(75, 31);
               this.btnSua.TabIndex = 14;
               this.btnSua.Text = "Sửa";
               this.btnSua.UseVisualStyleBackColor = true;
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // btnThem
               // 
               this.btnThem.Location = new System.Drawing.Point(22, 387);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(75, 31);
               this.btnThem.TabIndex = 13;
               this.btnThem.Text = "Thêm";
               this.btnThem.UseVisualStyleBackColor = true;
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // txtTienBH
               // 
               this.txtTienBH.Location = new System.Drawing.Point(135, 311);
               this.txtTienBH.Name = "txtTienBH";
               this.txtTienBH.Size = new System.Drawing.Size(177, 22);
               this.txtTienBH.TabIndex = 12;
               // 
               // txtThangNam
               // 
               this.txtThangNam.Location = new System.Drawing.Point(135, 249);
               this.txtThangNam.Name = "txtThangNam";
               this.txtThangNam.Size = new System.Drawing.Size(177, 22);
               this.txtThangNam.TabIndex = 11;
               // 
               // txtNgayCong
               // 
               this.txtNgayCong.Location = new System.Drawing.Point(135, 199);
               this.txtNgayCong.Name = "txtNgayCong";
               this.txtNgayCong.Size = new System.Drawing.Size(177, 22);
               this.txtNgayCong.TabIndex = 10;
               // 
               // txtLuongHD
               // 
               this.txtLuongHD.Location = new System.Drawing.Point(135, 141);
               this.txtLuongHD.Name = "txtLuongHD";
               this.txtLuongHD.Size = new System.Drawing.Size(177, 22);
               this.txtLuongHD.TabIndex = 9;
               // 
               // txtMaNV
               // 
               this.txtMaNV.Location = new System.Drawing.Point(135, 87);
               this.txtMaNV.Name = "txtMaNV";
               this.txtMaNV.Size = new System.Drawing.Size(177, 22);
               this.txtMaNV.TabIndex = 8;
               // 
               // txtMaLuong
               // 
               this.txtMaLuong.Location = new System.Drawing.Point(135, 26);
               this.txtMaLuong.Name = "txtMaLuong";
               this.txtMaLuong.Size = new System.Drawing.Size(177, 22);
               this.txtMaLuong.TabIndex = 7;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(17, 311);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(98, 17);
               this.label6.TabIndex = 6;
               this.label6.Text = "Tiền bảo hiểm";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(13, 254);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(84, 17);
               this.label5.TabIndex = 5;
               this.label5.Text = "Tháng năm:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(18, 202);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(99, 17);
               this.label4.TabIndex = 4;
               this.label4.Text = "Số ngày công:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(13, 141);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(116, 17);
               this.label3.TabIndex = 3;
               this.label3.Text = "Lương hợp đồng:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(18, 92);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(97, 17);
               this.label2.TabIndex = 2;
               this.label2.Text = "Mã nhân viên:";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(18, 26);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(70, 17);
               this.label1.TabIndex = 1;
               this.label1.Text = "Mã lương:";
               // 
               // dataGridViewLuong
               // 
               this.dataGridViewLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridViewLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuong,
            this.MaNhanVien,
            this.LuongHD,
            this.SoNgayCong,
            this.ThangNam,
            this.TienBH});
               this.dataGridViewLuong.Location = new System.Drawing.Point(94, 85);
               this.dataGridViewLuong.Name = "dataGridViewLuong";
               this.dataGridViewLuong.RowHeadersWidth = 51;
               this.dataGridViewLuong.RowTemplate.Height = 24;
               this.dataGridViewLuong.Size = new System.Drawing.Size(1082, 562);
               this.dataGridViewLuong.TabIndex = 21;
               this.dataGridViewLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLuong_CellClick);
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
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(227, 28);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(142, 17);
               this.labelControl1.TabIndex = 25;
               this.labelControl1.Text = "Nhập tháng hoặc năm:";
               // 
               // LUONG_ADMIN
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.btnTimKiem);
               this.Controls.Add(this.txtTimKiem);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.dataGridViewLuong);
               this.Name = "LUONG_ADMIN";
               this.Size = new System.Drawing.Size(1549, 681);
               this.Load += new System.EventHandler(this.LUONG_ADMIN_Load);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLuong)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTienBH;
        private System.Windows.Forms.TextBox txtThangNam;
        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.TextBox txtLuongHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienBH;
          private System.Windows.Forms.Button btnBaoCao;
          private DevExpress.XtraEditors.LabelControl labelControl1;
     }
}
