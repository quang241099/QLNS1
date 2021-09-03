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
    public partial class UserQLNV_NV : UserControl
    {
        linqDataContext db = new linqDataContext();
        
        public UserQLNV_NV()
        {
            InitializeComponent();
            Load();
        }

        private static UserQLNV_NV _instance;
        public static UserQLNV_NV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserQLNV_NV();
                return _instance;
            }
        }

        public DanhMucNhanVien DanhMucNhanVien { get; private set; }

        void Load()
        {
            DanhMucNhanVien nv = new DanhMucNhanVien();
            nv = db.DanhMucNhanViens.Where(s => s.MaNhanVien == GUI.Main_NV.manv ).Single();
            
                textCMND.Text = nv.SoCMND;
                textCV.Text = nv.MaChucVu;
                textEmail.Text = nv.Email;
                textGioiTinh.Text = nv.GioiTinh;
                textHoTen.Text = nv.HoTen;
                textMaNV1.Text = nv.MaNhanVien;
                textMaPB.Text = nv.MaPhongBan;
                textMaTD.Text = nv.MaHinhThucTuyenDung;
                textNgaySinh.Text = nv.NgaySinh.ToString();
                textNoiLamViec.Text = nv.NoiLamViec;
                textNoiO.Text = nv.NoiO;
                textNoiSinh.Text = nv.NoiSinh;
                textQueQuan1.Text = nv.QueQuan;
                textSDT1.Text = nv.SDT;
                textTrinhDo1.Text = nv.TrinhDo;

            dataGridViewHD.DataSource = from u in db.HopDongs
                                        where u.MaNhanVien == nv.MaNhanVien
                                        select new
                                        {
                                            
                                            MaHopDong = u.MaHD,
                                            Luong = u.LuongHD,
                                            NgayBatDau= u.NgayBatDau,
                                            NgayKetThuc = u.NgayKetThuc

                                        };


        }
      
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textNoiO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
