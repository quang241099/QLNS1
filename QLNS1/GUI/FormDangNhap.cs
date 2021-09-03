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
        DataTable dt = new DataTable();
        public FormDangNhap()
        {
            InitializeComponent();
            dt = Bang();
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
       
        public DataTable Bang()
        {
            DataTable data = new DataTable();
            data =db.dangnhap1().ToDataTable();
            DataTable danhsach = new DataTable();
            danhsach.Columns.Add("MaNhanVien");
            danhsach.Columns.Add("MatKhau");
            danhsach.Columns.Add("Quyen");
            DataRow admin = danhsach.NewRow();
            admin["MaNhanVien"] = admin["MatKhau"] = admin["Quyen"] = "admin";
            danhsach.Rows.Add(admin);
            for(int i=0;i<data.Rows.Count;i++)
            {
                DataRow row = danhsach.NewRow();
                row["MaNhanVien"] = data.Rows[i]["MaNhanVien"].ToString();
                row["MatKhau"] = data.Rows[i]["SDT"].ToString();
                row["Quyen"] = "NhanVien";
                danhsach.Rows.Add(row);
            }
            return danhsach;
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
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    string s1 = dt.Rows[i]["MaNhanVien"].ToString();
                    string s2 = dt.Rows[i]["MatKhau"].ToString();
                    if(t1.Trim() == s1.Trim() && t2.Trim() == s2.Trim())
                    {
                        quyen = dt.Rows[i]["Quyen"].ToString();
                        break;
                    }
                    if(i== dt.Rows.Count-1)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTK.Focus();
                        this.txtTK.SelectAll();
                        break;
                    }
                }
                
            }
            if (quyen == "admin")
            {
                GUI.Main_Admin admin = new GUI.Main_Admin();
                admin.ShowDialog();
                this.Close();

            }
            if (quyen == "NhanVien")
            {
                GUI.Main_NV NV = new GUI.Main_NV();
                GUI.Main_NV.manv = txtTK.Text;
                NV.ShowDialog();
                this.Close();

            }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
  
        }
    }
}
