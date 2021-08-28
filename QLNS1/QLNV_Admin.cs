using DevExpress.Utils.Extensions;
using QLNS1.DATA;
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
    public partial class QLNV_Admin : Form
    {
        linqDataContext db = new linqDataContext();

        public QLNV_Admin()
        {
            InitializeComponent();
            LoadData();

        }

        void LoadData()
        {
            dataGridViewNV.DataSource = from u in db.DanhMucNhanViens
                                        select new
                                        {
                                            MaNhanVien = u.MaNhanVien,
                                            HoTen = u.HoTen,
                                            NgaySinh = u.NgaySinh,
                                            QueQuan = u.QueQuan,
                                            GioiTinh = u.GioiTinh,
                                            TrinhDo = u.TrinhDo,
                                            SDT = u.SDT
                                        };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int a = dataGridViewNV.RowCount;
            if (i >= 0)
            {
                DataGridViewRow row = dataGridViewNV.Rows[i];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                txtQQ.Text = row.Cells[3].Value.ToString();
                txtGT.Text = row.Cells[4].Value.ToString();
                txtTD.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int a = dataGridViewHD.RowCount;
            try
            {

                string manv = dataGridViewNV.SelectedCells[0].OwningRow.Cells["MaNhanVien"].Value.ToString();
                //db.DanhMucNhanViens.Find(manv);
                DanhMucNhanVien dt = (DanhMucNhanVien)(from u in db.DanhMucNhanViens
                                                       where u.MaNhanVien == manv
                                                       select manv==u.MaNhanVien);

                if (txtMaNV.Text == dt.MaNhanVien)
                {
                    dt.HoTen = txtHoTen.Text;
                    dt.NgaySinh = dtNgaySinh.Value;
                    dt.QueQuan = txtQQ.Text;
                    dt.GioiTinh = txtGT.Text;
                    dt.TrinhDo = txtTD.Text;
                    dt.SDT = txtSDT.Text;
                    db.SaveChanges();

                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sai dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Sai Mã Nhân Viên Hoặc Thiếu Thông Tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
