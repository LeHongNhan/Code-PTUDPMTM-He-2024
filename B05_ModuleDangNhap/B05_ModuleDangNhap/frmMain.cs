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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormClosed += frmMain_FormClosed;
        }

        void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmDN.Show();
        }

        private void itemNguoidung_Click(object sender, EventArgs e)
        {
            frmQLNguoiDung form = new frmQLNguoiDung();
            form.MdiParent = this;
            form.Show();
        }



        private void itemNhomND_Click(object sender, EventArgs e)
        {
            frmQLNhomNguoiDung form = new frmQLNhomNguoiDung();
            form.MdiParent = this;
            form.Show();
        }

        private void itemManHinh_Click(object sender, EventArgs e)
        {
            frmQLManHinh form = new frmQLManHinh();
            form.MdiParent = this;
            form.Show();
        }

    }
}
