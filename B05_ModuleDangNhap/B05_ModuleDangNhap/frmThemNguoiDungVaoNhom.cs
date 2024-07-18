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
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNguoiDung);

        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNguoiDung);

        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.qLNguoiDung.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.qLNguoiDung.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.qLNguoiDung.QL_NguoiDung);

        }



        private void qL_NguoiDungNhomNguoiDung_DKComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }


        void loadCBOx()
        {
            if (qL_NhomNguoiDungComboBox.SelectedIndex >= 0)
            {
                try
                {
                    this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill_DK(this.qLNguoiDung.QL_NguoiDungNhomNguoiDung_DK, qL_NhomNguoiDungComboBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBOx();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //b1
            string tenDN = qL_NguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            string maNhomND = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
            int? kt = qL_NguoiDungNhomNguoiDungTableAdapter.KTKhoaChinh(tenDN, maNhomND);
            if (kt >0)
            {
                MessageBox.Show("trung khoa chinh");
                return;
            }
            //b2
            qL_NguoiDungNhomNguoiDungTableAdapter.Insert(tenDN, maNhomND, string.Empty);
            MessageBox.Show("Thanh cong");
            loadCBOx();
        }
    }
}
