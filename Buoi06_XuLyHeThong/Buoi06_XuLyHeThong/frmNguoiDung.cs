﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_XuLyHeThong
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLND);

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLND.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.qLND.QL_NguoiDung);

        }
    }
}
