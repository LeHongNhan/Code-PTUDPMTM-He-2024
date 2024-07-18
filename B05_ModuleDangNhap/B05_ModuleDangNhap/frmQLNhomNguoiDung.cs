﻿using System;
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
    public partial class frmQLNhomNguoiDung : Form
    {
        public frmQLNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNguoiDung);

        }

        private void frmQLNhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.qLNguoiDung.QL_NhomNguoiDung);

        }
    }
}
