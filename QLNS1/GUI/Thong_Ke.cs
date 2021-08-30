using DevExpress.XtraCharts;
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
     public partial class Thong_Ke : DevExpress.XtraEditors.XtraUserControl
     {
          DATA.linqDataContext linq = new DATA.linqDataContext();
          private static Thong_Ke _instance;
          public static Thong_Ke Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new Thong_Ke();
                    return _instance;
               }
          }
          public Thong_Ke()
          {
               InitializeComponent();
          }

          private void btnTK_Click(object sender, EventArgs e)
          {
               if (cbxTK.Text == "Bảo hiểm")
               {
                    int i = 0;
                    var dsnv = linq.TKBaoHiem().ToList()
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
                                 Tên_bảo_hiểm = p.ten
                            }).ToList();
                    dgvTK.DataSource = dsnv;

                    Series series1 = new Series("1", ViewType.Pie);
                    var dt = from p in linq.TiLeBaoHiem() select p;
                    List<NhanVien> list = new List<NhanVien>();

                    foreach (var item in dt)
                    {
                         NhanVien nv = new NhanVien
                         {
                              GiaTri = Convert.ToDouble(item.TiLe.ToString()),
                              ThuocTinh = item.ten.ToString().Trim()
                         };
                         list.Add(nv);
                    }

                    chartTK.Series.Clear();
                    chartTK.DataSource = list;

                    chartTK.Series.Add(series1);
                    series1.ArgumentDataMember = "ThuocTinh";
                    series1.ValueDataMembers.AddRange("GiaTri");
                    series1.Label.TextPattern = "{A}: {VP:P}";
                    chartTK.PaletteName = "Metro";
                    chartTK.AppearanceNameSerializable = "Nature Colors";
                    //chartTK.Size = new System.Drawing.Size(1167, 304);
                    DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                    chartTK.Titles.Clear();
                    title.Text = "Thống kê bảo hiểm";
                    chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });

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

                    chartTK.Series.Clear();
                    Series series1 = new Series("1", ViewType.Pie);
                    var dt = from p in linq.TiLeChucVu() select p;
                    List<NhanVien> list = new List<NhanVien>();

                    foreach (var item in dt)
                    {
                         NhanVien nv = new NhanVien
                         {
                              GiaTri = Convert.ToDouble(item.TiLe.ToString()),
                              ThuocTinh = item.ten.ToString().Trim()
                         };
                         list.Add(nv);
                    }


                    chartTK.DataSource = list;

                    chartTK.Series.Add(series1);
                    series1.ArgumentDataMember = "ThuocTinh";
                    series1.ValueDataMembers.AddRange("GiaTri");
                    series1.Label.TextPattern = "{A}: {VP:P}";
                    chartTK.PaletteName = "Red Violet";
                    chartTK.AppearanceNameSerializable = "Nature Colors";
                    //chartTK.Size = new System.Drawing.Size(1167, 304);
                    DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                    chartTK.Titles.Clear();
                    title.Text = "Thống kê chức vụ";
                    chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
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
                    chartTK.Series.Clear();
                    Series series1 = new Series("1", ViewType.Pie);
                    var dt = from p in linq.TiLePhongBan() select p;
                    List<NhanVien> list = new List<NhanVien>();

                    foreach (var item in dt)
                    {
                         NhanVien nv = new NhanVien
                         {
                              GiaTri = Convert.ToDouble(item.TiLe.ToString()),
                              ThuocTinh = item.ten.ToString().Trim()
                         };
                         list.Add(nv);
                    }

                    chartTK.DataSource = list;

                    chartTK.Series.Add(series1);
                    series1.ArgumentDataMember = "ThuocTinh";
                    series1.ValueDataMembers.AddRange("GiaTri");
                    series1.Label.TextPattern = "{A}: {VP:P}";
                    chartTK.PaletteName = "Flow";
                    chartTK.AppearanceNameSerializable = "Nature Colors";
                    //chartTK.Size = new System.Drawing.Size(1167, 304);
                    DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                    chartTK.Titles.Clear();
                    title.Text = "Thống kê phòng ban";
                    chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
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
                    chartTK.Series.Clear();
                    Series series1 = new Series("1", ViewType.Pie);
                    var dt = from p in linq.TiLeTrinhDoNV() select p;
                    List<NhanVien> list = new List<NhanVien>();

                    foreach (var item in dt)
                    {
                         NhanVien nv = new NhanVien
                         {
                              GiaTri = Convert.ToDouble(item.TiLe.ToString()),
                              ThuocTinh = item.trinhdo.ToString().Trim()
                         };
                         list.Add(nv);
                    }

                    chartTK.DataSource = list;

                    chartTK.Series.Add(series1);
                    series1.ArgumentDataMember = "ThuocTinh";
                    series1.ValueDataMembers.AddRange("GiaTri");
                    series1.Label.TextPattern = "{A}: {VP:P}";
                    chartTK.PaletteName = "Module";
                    chartTK.AppearanceNameSerializable = "Nature Colors";
                    //chartTK.Size = new System.Drawing.Size(1167, 304);
                    DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                    chartTK.Titles.Clear();
                    title.Text = "Thống kê trình độ";
                    chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
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

                    chartTK.Series.Clear();
                    Series series1 = new Series("1", ViewType.Pie);
                    var dt = from p in linq.TyLeKTKL() select p;
                    List<NhanVien> list = new List<NhanVien>();

                    foreach (var item in dt)
                    {
                         NhanVien nv = new NhanVien
                         {
                              GiaTri = Convert.ToDouble(item.TiLe.ToString()),
                              ThuocTinh = item.ten.ToString().Trim()
                         };
                         list.Add(nv);
                    }

                    chartTK.DataSource = list;

                    chartTK.Series.Add(series1);
                    series1.ArgumentDataMember = "ThuocTinh";
                    series1.ValueDataMembers.AddRange("GiaTri");
                    series1.Label.TextPattern = "{A}: {VP:P}";
                    chartTK.PaletteName = "Blue II";
                    chartTK.AppearanceNameSerializable = "Nature Colors";
                    //chartTK.Size = new System.Drawing.Size(1167, 304);
                    DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                    chartTK.Titles.Clear();
                    title.Text = "Thống kê khen thưởng kỷ luật";
                    chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });

               }

          }
          public class NhanVien
          {
               public string ThuocTinh { set; get; }
               public double GiaTri { set; get; }
          }
     }
     
}
