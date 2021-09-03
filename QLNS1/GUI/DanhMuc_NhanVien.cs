using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS1
{
    public partial class DanhMuc_NhanVien : UserControl
    {
        public DanhMuc_NhanVien()
        {
            InitializeComponent();
        }

        string MaNhanVien = "";
        

        DATA.linqDataContext linq = new DATA.linqDataContext();

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DanhMuc_NhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewChucVu.DataSource = linq.XEMCV_NHANVIEN(GUI.Main_NV.manv);
            dataGridViewPhongBan.DataSource = linq.XEMPB_NHANVIEN(GUI.Main_NV.manv);
            dataGridViewBaoHiem.DataSource = linq.XEMBH_NHANVIEN(GUI.Main_NV.manv);
            dataGridViewKTKL.DataSource = linq.XEMKTKL_NHANVIEN(GUI.Main_NV.manv);
        }

        private void dataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaCV.Text = dataGridViewChucVu.Rows[index].Cells["MaChucVu"].Value.ToString();
                txtTenCV.Text = dataGridViewChucVu.Rows[index].Cells["Ten"].Value.ToString();
                txtPhuCap.Text = dataGridViewChucVu.Rows[index].Cells["PhuCap"].Value.ToString();
            }
        }

        private void dataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dataGridViewPhongBan.Rows[index].Cells["MaPhongBan"].Value.ToString();
                txtTenPB.Text = dataGridViewPhongBan.Rows[index].Cells["TenPhongBan"].Value.ToString();
                txtSDT.Text = dataGridViewPhongBan.Rows[index].Cells["SoDT"].Value.ToString();
            }
        }

        private void dataGridViewBaoHiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaBH.Text = dataGridViewBaoHiem.Rows[index].Cells["MaBH"].Value.ToString();
                txtTenBH.Text = dataGridViewBaoHiem.Rows[index].Cells["TenBH"].Value.ToString();
                txtTiLeBH.Text = dataGridViewBaoHiem.Rows[index].Cells["TiLeBH"].Value.ToString();
            }
        }

        private void dataGridViewKTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaKTKL.Text = dataGridViewKTKL.Rows[index].Cells["MaKTKL"].Value.ToString();
                txtTenQD.Text = dataGridViewKTKL.Rows[index].Cells["TenQD"].Value.ToString();
                txtSoTien.Text = dataGridViewKTKL.Rows[index].Cells["SoTien"].Value.ToString();
            }
        }

     }
}
