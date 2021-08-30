using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS1.GUI
{
     public partial class ThongKe : DevExpress.XtraEditors.XtraForm
     {
          DATA.linqDataContext linq = new DATA.linqDataContext();
          public ThongKe()
          {
               InitializeComponent();
          }

          private void ThongKe_Load(object sender, EventArgs e)
          {

          }

          private void btnTK_Click(object sender, EventArgs e)
          {
               if (cbxTK.Text == "Bảo hiểm")
               {
                    int i = 0;
                    var dsnv = linq.TKBaoHiem().ToList()
                            .Select (p=> new
                            {
                                 STT = ++i,
                                 Mã_nhân_viên = p.MaNhanVien,
                                 Họ_tên = p.HoTen,
                                 Ngày_sinh = p.NgaySinh,
                                 Quê_quán = p.QueQuan,
                                 Giới_tính = p.GioiTinh,
                                 Mã_HTTD = p.MaHinhThucTuyenDung,
                                 Mã_chức_vụ = p.MaChucVu,
                                 Mã_phòng_ban = p.MaPhongBan,
                                 Nơi_làm_việc = p.NoiLamViec,
                                 Số_CMND = p.SoCMND,
                                 Trình_độ = p.TrinhDo,
                                 SĐT = p.sdt,
                                 Email = p.Email,
                                 Nơi_ở = p.NoiO,
                                 Nơi_sinh = p.NoiSinh,
                                 Tên_bảo_hiểm = p.ten
                            }).ToList();
                    dgvTK.DataSource = dsnv;
               }
               if (cbxTK.Text == "Chức vụ")
               {
                    int i = 0;
                    var dsnv = linq.TKChucVu().ToList()
                            .Select(p => new
                            {
                                 STT = ++i,
                                 Mã_nhân_viên = p.MaNhanVien,
                                 Họ_tên = p.HoTen,
                                 Ngày_sinh = p.NgaySinh,
                                 Quê_quán = p.QueQuan,
                                 Giới_tính = p.GioiTinh,
                                 Mã_HTTD = p.MaHinhThucTuyenDung,
                                 Mã_chức_vụ = p.MaChucVu,
                                 Mã_phòng_ban = p.MaPhongBan,
                                 Nơi_làm_việc = p.NoiLamViec,
                                 Số_CMND = p.SoCMND,
                                 Trình_độ = p.TrinhDo,
                                 SĐT = p.sdt,
                                 Email = p.Email,
                                 Nơi_ở = p.NoiO,
                                 Nơi_sinh = p.NoiSinh,
                                 Tên_chức_vụ = p.ten
                            }).ToList();
                    dgvTK.DataSource = dsnv;
               }
               if (cbxTK.Text == "Phòng ban")
               {
                    int i = 0;
                    var dsnv = linq.TKPhongBan().ToList()
                            .Select(p => new
                            {
                                 STT = ++i,
                                 Mã_nhân_viên = p.MaNhanVien,
                                 Họ_tên = p.HoTen,
                                 Ngày_sinh = p.NgaySinh,
                                 Quê_quán = p.QueQuan,
                                 Giới_tính = p.GioiTinh,
                                 Mã_HTTD = p.MaHinhThucTuyenDung,
                                 Mã_chức_vụ = p.MaChucVu,
                                 Mã_phòng_ban = p.MaPhongBan,
                                 Nơi_làm_việc = p.NoiLamViec,
                                 Số_CMND = p.SoCMND,
                                 Trình_độ = p.TrinhDo,
                                 SĐT = p.sdt,
                                 Email = p.Email,
                                 Nơi_ở = p.NoiO,
                                 Nơi_sinh = p.NoiSinh,
                                 Tên_phòng_ban = p.ten
                            }).ToList();
                    dgvTK.DataSource = dsnv;
               }
               if (cbxTK.Text == "Trình độ")
               {
                    int i = 0;
                    var dsnv = linq.TKTrinhDo().ToList()
                            .Select(p => new
                            {
                                 STT = ++i,
                                 Mã_nhân_viên = p.MaNhanVien,
                                 Họ_tên = p.HoTen,
                                 Ngày_sinh = p.NgaySinh,
                                 Quê_quán = p.QueQuan,
                                 Giới_tính = p.GioiTinh,
                                 Mã_HTTD = p.MaHinhThucTuyenDung,
                                 Mã_chức_vụ = p.MaChucVu,
                                 Mã_phòng_ban = p.MaPhongBan,
                                 Nơi_làm_việc = p.NoiLamViec,
                                 Số_CMND = p.SoCMND,
                                 Trình_độ = p.TrinhDo,
                                 SĐT = p.SDT,
                                 Email = p.Email,
                                 Nơi_ở = p.NoiO,
                                 Nơi_sinh = p.NoiSinh
                            }).ToList();
                    dgvTK.DataSource = dsnv;
               }
               if (cbxTK.Text == "Khen thưởng kỉ luật")
               {
                    int i = 0;
                    var dsnv = linq.TKKTKL().ToList()
                            .Select(p => new
                            {
                                 STT = ++i,
                                 Mã_nhân_viên = p.MaNhanVien,
                                 Họ_tên = p.HoTen,
                                 Ngày_sinh = p.NgaySinh,
                                 Quê_quán = p.QueQuan,
                                 Giới_tính = p.GioiTinh,
                                 Mã_HTTD = p.MaHinhThucTuyenDung,
                                 Mã_chức_vụ = p.MaChucVu,
                                 Mã_phòng_ban = p.MaPhongBan,
                                 Nơi_làm_việc = p.NoiLamViec,
                                 Số_CMND = p.SoCMND,
                                 Trình_độ = p.TrinhDo,
                                 SĐT = p.sdt,
                                 Email = p.Email,
                                 Nơi_ở = p.NoiO,
                                 Nơi_sinh = p.NoiSinh,
                                 Hình_thức_KTKL = p.ten
                            }).ToList();
                    dgvTK.DataSource = dsnv;
               }

          }

     }
          
     
}