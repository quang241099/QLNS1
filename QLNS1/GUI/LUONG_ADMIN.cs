using DevExpress.XtraReports.UI;
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
    public partial class LUONG_ADMIN : UserControl
    {
        public LUONG_ADMIN()
        {
            InitializeComponent();
            dataGridViewLuong.AllowUserToAddRows = false;
        }
        private static LUONG_ADMIN _instance;
        public static LUONG_ADMIN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LUONG_ADMIN();
                return _instance;
            }
        }
        string trangthai = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();

        private void btnThem_Click(object sender, EventArgs e)
        {
            refresh();
            txtMaLuong.Enabled = true;
            txtMaNV.Enabled = true;
            trangthai = "thêm";

        }

        private void LUONG_ADMIN_Load(object sender, EventArgs e)
        {
            dataGridViewLuong.DataSource = linq.XEMLUONG_ADMIN();
        }

        private void dataGridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewLuong.Rows.Count)
            {
                txtMaLuong.Text = dataGridViewLuong.Rows[index].Cells["MaLuong"].Value.ToString();
                txtMaNV.Text = dataGridViewLuong.Rows[index].Cells["MaNhanVien"].Value.ToString();
                txtLuongHD.Text = dataGridViewLuong.Rows[index].Cells["LuongHD"].Value.ToString();
                txtNgayCong.Text = dataGridViewLuong.Rows[index].Cells["SoNgayCong"].Value.ToString();
                txtThangNam.Text = dataGridViewLuong.Rows[index].Cells["ThangNam"].Value.ToString();
                txtTienBH.Text = dataGridViewLuong.Rows[index].Cells["TienBH"].Value.ToString();
            }
        }
        void refresh()
        {
            txtMaLuong.Text = "";
            txtMaNV.Text = "";
            txtLuongHD.Text = "";
            txtNgayCong.Text = "";
            txtThangNam.Text = "";
            txtTienBH.Text = "";
        }
        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMaLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLuongHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuongHD.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNgayCong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số ngày công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayCong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtThangNam.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThangNam.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTienBH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiền bảo hiểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTienBH.Focus();
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "sửa";
            txtMaLuong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOALUONG_ADMIN(txtMaLuong.Text);
                refresh();
                LUONG_ADMIN_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {
                if (trangthai == "thêm")
                {
                    try
                    {
                        linq.THEMLUONG_ADMIN(txtMaLuong.Text, txtMaNV.Text, Int32.Parse(txtLuongHD.Text), Int32.Parse(txtNgayCong.Text), txtThangNam.Text, Int32.Parse(txtTienBH.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa")
                {
                    try
                    {
                        linq.SUALUONG_ADMIN(txtMaLuong.Text, txtMaNV.Text, Int32.Parse(txtLuongHD.Text), Int32.Parse(txtNgayCong.Text), txtThangNam.Text, Int32.Parse(txtTienBH.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            LUONG_ADMIN_Load(sender, e);
            txtMaLuong.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            refresh();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem.Focus();
            }
            else
            {
                dataGridViewLuong.DataSource = linq.TIMLUONG_ADMIN(txtTimKiem.Text);
            }

        }

          private void btnBaoCao_Click(object sender, EventArgs e)
          {
               var dt = linq.BaoCaoLuong().ToList();
               BaoCaoLuong reportLuong = new BaoCaoLuong();
               reportLuong.DataSource = dt;
               reportLuong.ShowPreviewDialog();
          }

     }
}
