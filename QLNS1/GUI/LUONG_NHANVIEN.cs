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
    public partial class LUONG_NHANVIEN : UserControl
    {
        DATA.linqDataContext linq = new DATA.linqDataContext();
        public LUONG_NHANVIEN()
        {
            InitializeComponent();
        }
        private static LUONG_NHANVIEN _instance;
        public static LUONG_NHANVIEN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LUONG_NHANVIEN();
                return _instance;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem.Focus();
            }
            else
            {
                dataGridViewLuongNV.DataSource = linq.TIMLUONG_NV(GUI.Main_NV.manv, txtTimKiem.Text);
            }
        }

        private void LUONG_NHANVIEN_Load(object sender, EventArgs e)
        {
            dataGridViewLuongNV.DataSource = linq.XEMLUONG_NV(GUI.Main_NV.manv);
        }
    }
}
