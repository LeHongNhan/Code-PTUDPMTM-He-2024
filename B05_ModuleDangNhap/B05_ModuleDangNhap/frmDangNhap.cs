using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B05_ModuleDangNhap
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            btnDangNhap.Click += btnDangNhap_Click;
        }
        XuLyDangNhap CauHinh;
        void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblTenDangNhap.Text.ToLower());
                this.txtTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblMatKhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            CauHinh = new XuLyDangNhap();
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        private void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtTenDangNhap.Text, txtMatKhau.Text);
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblTenDangNhap.Text + " Hoặc " + lblMatKhau.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new frmMain();
            }
            this.Visible = false;
            Program.mainForm.Show();
        }

        LoginResult result;
        private void ProcessConfig()
        {
            if (Program.cauhinh == null || Program.cauhinh.IsDisposed)
            {
                Program.cauhinh = new frmCauHinh();
            }
            this.Visible = false;
            Program.cauhinh.Show();
        }

    }
}

