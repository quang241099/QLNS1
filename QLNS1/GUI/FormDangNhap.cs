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
using System.Data.SqlClient;
using MoreLinq;



namespace QLNS1
{
    public partial class FormDangNhap : Form
    {
        linqDataContext db = new linqDataContext();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }
       
       

        public void login()
        {
            string quyen = "";
            string t1 = txtTK.Text;
            string t2 = txtMK.Text;
            if(txtTK.Text=="")
            {
                MessageBox.Show("Chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();

            }
            if(txtMK.Text=="")
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
            }
            else
            {
                var quyen1 = from a in db.DANGNHAP(txtTK.Text, txtMK.Text) select a;
                foreach(var item in quyen1)
                {
                    quyen = item.QUYEN;
                }
                
            }
            if (quyen == "admin")
            {
                GUI.Main_Admin admin = new GUI.Main_Admin();
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin.ShowDialog();
                this.Close();

            }
            if (quyen == "NhanVien")
            {
                GUI.Main_NV NV = new GUI.Main_NV();
                GUI.Main_NV.manv = txtTK.Text;
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NV.ShowDialog();
                this.Close();

            }
            if(quyen == "")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
  
        }
    }
}
