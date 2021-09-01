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
    public partial class QuanLyNhanVien : Form
    {
        linqDataContext db = new  linqDataContext();

        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
            
        }

        void LoadData()
        {                                   //db.DanhMucNhanViens.Select(p => p); test LInq
            dataGridViewNV.DataSource = from u in db.DanhMucNhanViens
                                        where u.GioiTinh=="nam"
                                        orderby u.MaChucVu
                                        select u;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
