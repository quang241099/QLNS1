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
    public partial class UserQLNV_Admin : UserControl
    {
        linqDataContext db = new linqDataContext(); 
        public UserQLNV_Admin()
        {
            InitializeComponent();
            LoadData();
        }

        private static UserQLNV_Admin _instance;

        public static UserQLNV_Admin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserQLNV_Admin();
                return _instance;
            }
        }
        void LoadData()
        {
            dataGridViewNV.DataSource = from u in db.DanhMucNhanViens
                                        select new
                                        {
                                            MaNhanVien = u.MaNhanVien,
                                            MaChucVu = u.MaChucVu,
                                            Email = u.Email,
                                            HoTen = u.HoTen,
                                            MaPB = u.MaPhongBan,
                                            CMND = u.SoCMND,
                                            NgaySinh = u.NgaySinh,
                                            MaTD = u.MaHinhThucTuyenDung,
                                            SDT = u.SDT,
                                            QueQuan = u.QueQuan,
                                            NoiLamViec = u.NoiLamViec,
                                            GioiTinh = u.GioiTinh,
                                            NoiO = u.NoiO,
                                            TrinhDo = u.TrinhDo,
                                            NoiSinh = u.NoiSinh

                                        };
        }
      

        private void dataGridViewNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            int a = dataGridViewNV.RowCount;
            DanhMucNhanVien nv = new DanhMucNhanVien();

            if (i >= 0)
            {
                DataGridViewRow row = dataGridViewNV.Rows[i];
                textMaNV1.Text = row.Cells["MaNhanVien"].Value.ToString();
                textMaCV1.Text = row.Cells["MaChucVu"].Value.ToString();
                textMaPB1.Text = row.Cells["MaPhongBan"].Value.ToString();
                textHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                textGioiTinh1.Text = row.Cells["GioiTinh"].Value.ToString();
                textQueQuan1.Text = row.Cells["QueQuan"].Value.ToString();
                textNoiLamViec.Text = row.Cells["NoiLamViec"].Value.ToString();
                textTrinhDo1.Text = row.Cells["TrinhDo"].Value.ToString();
                textSDT1.Text = row.Cells["SDT"].Value.ToString();
                textEmail.Text = row.Cells["Email"].Value.ToString();
                textCMND.Text = row.Cells["SoCMND"].Value.ToString();
                textNoiO.Text = row.Cells["NoiO"].Value.ToString();
                textNoiSinh.Text = row.Cells["NoiSinh"].Value.ToString();
                textMaTD1.Text = row.Cells["MaHinhThucTuyenDung"].Value.ToString();

                dataGridViewHD.DataSource = from u in db.HopDongs
                                            where u.MaNhanVien == textMaNV1.Text
                                            select new
                                            {
                                                MaNV = u.MaNhanVien,
                                                MaHopDong = u.MaHD,
                                                Luong = u.LuongHD,
                                                NgayBatDau = u.NgayBatDau,
                                                NgayKetThuc = u.NgayKetThuc
                                            };
            }
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DanhMucNhanVien tb = new DanhMucNhanVien();
            tb = db.DanhMucNhanViens.Where(s => s.MaNhanVien == textMaNV1.Text).Single();
            tb.MaChucVu = textMaCV1.Text;
            tb.MaPhongBan = textMaPB1.Text;
            tb.HoTen = textHoTen.Text;
            tb.NgaySinh = dtNgaySinh.Value;
            tb.GioiTinh = textGioiTinh1.Text;
            tb.QueQuan = textQueQuan1.Text;
            tb.NoiLamViec = textNoiLamViec.Text;
            tb.TrinhDo = textTrinhDo1.Text;
            tb.SDT = textSDT1.Text;
            tb.Email = textEmail.Text;
            tb.SoCMND = textCMND.Text;
            tb.NoiO = textNoiO.Text;
            tb.NoiSinh = textNoiSinh.Text;
            tb.MaHinhThucTuyenDung = textMaTD1.Text;
            db.SubmitChanges();
            LoadData();

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DanhMucNhanVien tb = new DanhMucNhanVien();
            tb = db.DanhMucNhanViens.Where(s => s.MaNhanVien == textMaNV1.Text).Single();
            db.DanhMucNhanViens.DeleteOnSubmit(tb);
            db.SubmitChanges();
            LoadData();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            textCMND.Text = "";
            textEmail.Text = "";
            textGioiTinh1.Text = "";
            textHoTen.Text = "";
            textMaCV1.Text = "";
            textMaNV1.Text = "";
            textMaPB1.Text = "";
            textMaTD1.Text = "";
            textNoiLamViec.Text = "";
            textNoiO.Text = "";
            textNoiSinh.Text = "";
            textQueQuan1.Text = "";
            textSDT1.Text = "";
            textTrinhDo1.Text = "";
            dtNgaySinh.Value = Convert.ToDateTime("1111/1/11");
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DanhMucNhanVien tb = new DanhMucNhanVien();
            tb.MaNhanVien = textMaNV1.Text;
            tb.MaPhongBan = textMaPB1.Text;
            tb.MaChucVu = textMaCV1.Text;
            tb.MaHinhThucTuyenDung = textMaTD1.Text;
            tb.HoTen = textHoTen.Text;
            tb.GioiTinh = textGioiTinh1.Text;
            tb.NgaySinh = dtNgaySinh.Value;
            tb.QueQuan = textQueQuan1.Text;
            tb.SoCMND = textCMND.Text;
            tb.SDT = textSDT1.Text;
            tb.TrinhDo = textTrinhDo1.Text;
            tb.NoiLamViec = textNoiLamViec.Text;
            tb.NoiO = textNoiO.Text;
            tb.NoiSinh = textNoiSinh.Text;
            tb.Email = textEmail.Text;
            db.DanhMucNhanViens.InsertOnSubmit(tb);
            db.SubmitChanges();
            LoadData();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                dataGridViewNV.DataSource = db.TIMNHANVIEN_ADMIN(txtSearch.Text);
            }
        }

     }

}
