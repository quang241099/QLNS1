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
                textMaNV1.Text = row.Cells[0].Value.ToString();
                textMaCV1.Text = row.Cells[1].Value.ToString();
                textMaPB1.Text = row.Cells[4].Value.ToString();
                textHoTen.Text = row.Cells[3].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                textGioiTinh1.Text = row.Cells[11].Value.ToString();
                textQueQuan1.Text = row.Cells[9].Value.ToString();
                textNoiLamViec.Text = row.Cells[10].Value.ToString();
                textTrinhDo1.Text = row.Cells[13].Value.ToString();
                textSDT1.Text = row.Cells[8].Value.ToString();
                textEmail.Text = row.Cells[2].Value.ToString();
                textCMND.Text = row.Cells[5].Value.ToString();
                textNoiO.Text = row.Cells[12].Value.ToString();
                textNoiSinh.Text = row.Cells[14].Value.ToString();
                textMaTD1.Text = row.Cells[7].Value.ToString();



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


                //var mahd = from u in db.DanhMucNhanViens
                //           from h in db.HopDongs
                //           where u.MaNhanVien == h.MaNhanVien
                //           select h.MaHD;
                //textMaHD.Text = mahd.ToString();

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

            //tb = db.Danhmucnhanviens.where(s => s.manhanvien == txtmanv.text).single();
            //tb.hoten = txthoten.text;
            //tb.ngaysinh = dtngaysinh.value;
            //tb.quequan = txtqq.text;
            //tb.gioitinh = txtgt.text;
            //tb.trinhdo = txttd.text;
            //tb.sdt = txtsdt.text;
            //db.submitchanges();
            //loaddata();


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

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }

}
