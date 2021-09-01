using DevExpress.XtraReports.UI;
using QLNS1.GUI;
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
    public partial class DanhMuc_AD : UserControl
    {
        public DanhMuc_AD()
        {
            InitializeComponent();
        }
        string trangthai = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();
        private void txtThem_CV_Click(object sender, EventArgs e)
        {

        }
        private void DanhMuc_AD_Load(object sender, EventArgs e)
        {
                dataGridViewPhongBan.DataSource = linq.XEMPB_ADMIN();
                dataGridViewChucVu.DataSource = linq.XEM_DM_CV_ADMIN();    
                dataGridViewBaoHiem.DataSource = linq.XEM_DM_BH_ADMIN();
                dataGridViewKTKL.DataSource = linq.XEM_DM_KTKL_ADMIN();
        }

        void ReLoad_CV()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtPhuCap.Text = "";
        }

        void ReLoad_KTKL()
        {
            txtMaKTKL.Text = "";
            txtTenKTKL.Text = "";
            txtSoTien.Text = "";
        }

        void ReLoad_PB()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtSDT.Text = "";
        }

        void ReLoad_BH()
        {
            txtMaBH.Text = "";
            txtTenBH.Text = "";
            txtTiLeBH.Text = "";
        }

        public bool Checkcontrol_CV()
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhuCap.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhuCap.Focus();
                return false;
            }          
      
            return true;
        }

        public bool Checkcontrol_KTKL()
        {
            if (string.IsNullOrWhiteSpace(txtMaKTKL.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khen thưởng kỷ luật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKTKL.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenKTKL.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên quyết định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKTKL.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return false;
            }

            return true;
        }

        public bool Checkcontrol_PB()
        {
            if (string.IsNullOrWhiteSpace(txtMaPB.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPB.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }

            return true;
        }

        public bool Checkcontrol_BH()
        {
            if (string.IsNullOrWhiteSpace(txtMaBH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bảo hiểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaBH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenBH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bảo hiểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenBH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTiLeBH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tỉ lệ bảo hiểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiLeBH.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_CV_Click(object sender, EventArgs e)
        {
            ReLoad_CV();
            txtMaCV.Enabled = true;
            trangthai = "thêm_cv";          
        }

        
        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            trangthai = "sửa_cv";         
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOACV_ADMIN(txtMaCV.Text);
                ReLoad_CV();
                DanhMuc_AD_Load(sender, e);
            }
        }

        private void btnLuuCV_Click(object sender, EventArgs e)
        {
            if (Checkcontrol_CV())
            {
                if (trangthai == "thêm_cv")
                {
                    try
                    {
                        linq.THEMCV_ADMIN(txtMaCV.Text, txtTenCV.Text, Int32.Parse(txtPhuCap.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa_cv")
                {
                    try
                    {
                        linq.SUACV_ADMIN(txtMaCV.Text, txtTenCV.Text, Int32.Parse(txtPhuCap.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            DanhMuc_AD_Load(sender, e);
            txtMaCV.Enabled = false;
        }

        private void dataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dataGridViewPhongBan.Rows[index].Cells["MaPhongBan"].Value.ToString();
                txtTenPB.Text = dataGridViewPhongBan.Rows[index].Cells["TenPhongBan"].Value.ToString();
                txtSDT.Text = dataGridViewPhongBan.Rows[index].Cells["DienThoai"].Value.ToString();
            }
        }

        private void dataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaCV.Text = dataGridViewChucVu.Rows[index].Cells["MaChucVu"].Value.ToString();
                txtTenCV.Text = dataGridViewChucVu.Rows[index].Cells["TenCV"].Value.ToString();
                txtPhuCap.Text = dataGridViewChucVu.Rows[index].Cells["PhuCap"].Value.ToString();
            }

        }

        private void dataGridViewBaoHiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaBH.Text = dataGridViewBaoHiem.Rows[index].Cells["MaBaoHiem"].Value.ToString();
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
                txtTenKTKL.Text = dataGridViewKTKL.Rows[index].Cells["TenQD"].Value.ToString();
                txtSoTien.Text = dataGridViewKTKL.Rows[index].Cells["SoTien"].Value.ToString();
            }
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            ReLoad_PB();
            txtMaPB.Enabled = true;       
            trangthai = "thêm_pb";           
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            trangthai = "sửa_pb";
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOAPB_ADMIN(txtMaCV.Text);
                ReLoad_PB();
                DanhMuc_AD_Load(sender, e);
            }
        }

        private void btnLuuPB_Click(object sender, EventArgs e)
        {
            if (Checkcontrol_PB())
            {
                if (trangthai == "thêm_pb")
                {
                    try
                    {
                        linq.THEM_DM_PB_ADMIN(txtMaPB.Text, txtTenPB.Text, Int32.Parse(txtSDT.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa_pb")
                {
                    try
                    {
                        linq.SUAPB_ADMIN(txtMaPB.Text, txtTenPB.Text, Int32.Parse(txtSDT.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            DanhMuc_AD_Load(sender, e);
            txtMaPB.Enabled = false;
        }

        private void btnThemBH_Click(object sender, EventArgs e)
        {
            ReLoad_BH();
            txtMaBH.Enabled = true;
            trangthai = "thêm_bh";
        }

        private void btnSuaBH_Click(object sender, EventArgs e)
        {
            trangthai = "sửa_bh";
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOABH_ADMIN(txtMaBH.Text);
                ReLoad_BH();
                DanhMuc_AD_Load(sender, e);
            }
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
        {
            if (Checkcontrol_BH())
            {
                if (trangthai == "thêm_BH")
                {
                    try
                    {
                        linq.THEMBH_ADMIN(txtMaBH.Text, txtTenBH.Text, Int32.Parse(txtTiLeBH.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa_bh")
                {
                    try
                    {
                        linq.SUABH_ADMIN(txtMaBH.Text, txtTenBH.Text, Int32.Parse(txtTiLeBH.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            DanhMuc_AD_Load(sender, e);
            txtMaBH.Enabled = false;
        }

        private void btnThemKTKL_Click(object sender, EventArgs e)
        {
            ReLoad_KTKL();
            txtMaBH.Enabled = true;
            trangthai = "thêm_ktkl";
        }

        private void btnSuaKTKL_Click(object sender, EventArgs e)
        {
            trangthai = "sửa_ktkl";
        }

        private void btnXoaKTKL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOAKTKL_ADMIN(txtMaBH.Text);
                ReLoad_KTKL();
                DanhMuc_AD_Load(sender, e);
            }
        }

        private void btnLuuKTKL_Click(object sender, EventArgs e)
        {
            if (Checkcontrol_KTKL())
            {
                if (trangthai == "thêm_ktkl")
                {
                    try
                    {
                        linq.THEMKTKL_ADMIN(txtMaKTKL.Text, txtTenKTKL.Text, Int32.Parse(txtSoTien.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa_ktkl")
                {
                    try
                    {
                        linq.SUAKTKL_ADMIN(txtMaKTKL.Text, txtTenKTKL.Text, Int32.Parse(txtSoTien.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            DanhMuc_AD_Load(sender, e);
            txtMaKTKL.Enabled = false;
        }

          private void btnBC_Click(object sender, EventArgs e)
          {
               var dt = linq.BaoCaoNhanSu().ToList();
               BaoCaoNhanSu2 reportNS = new BaoCaoNhanSu2();
               reportNS.DataSource = dt;
               reportNS.ShowPreviewDialog();
          }

          private void btnBCKTKL_Click(object sender, EventArgs e)
          {
               var dt = linq.BaoCaoKTKL().ToList();
               BaoCaoKTKL reportKTKL = new BaoCaoKTKL();
               reportKTKL.DataSource = dt;
               reportKTKL.ShowPreviewDialog();
          }
     }
}
