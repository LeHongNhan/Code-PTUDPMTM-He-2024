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
    public partial class frmQLManHinh : Form
    {
        public frmQLManHinh()
        {
            InitializeComponent();
        }

        private void dM_ManHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_ManHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNguoiDung);

        }

        private void QLManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNguoiDung.DM_ManHinh' table. You can move, or remove it, as needed.
            this.dM_ManHinhTableAdapter.Fill(this.qLNguoiDung.DM_ManHinh);

        }
    }
}
