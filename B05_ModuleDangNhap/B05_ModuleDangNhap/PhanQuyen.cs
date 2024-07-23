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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
            btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
//            this.qL_GetPhanQuyenTableAdapter.Fill(this.dataSet1.QL_GetPhanQuyen,
//qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());
//        }
//        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender,
//        EventArgs e)
//        {
//            LoadDataCondition();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string _NhomNguoiDung = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (DataGridViewRow item in qLPhanQuyen_DKDataGridView.Rows)
            {
                if
                (qLPhanQuyen_DKDataGridView.KiemTraKhoaChinhPhanQuyen(_NhomNguoiDung, item.Cells[0].Value.ToString()) == null)
                {
                    try
                    {
                        qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                        item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        qL_PhanQuyenTableAdapter.Insert(_NhomNguoiDung,
                        item.Cells[0].Value.ToString(), false);
                    }
                }
                else
                {
                    qL_PhanQuyenTableAdapter.UpdateQuery((item.Cells[2] == null) ? false
                    : (bool)(item.Cells[2].Value), _NhomNguoiDung, item.Cells[0].Value.ToString());
                }
            }

        }

        private void qL_NhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNguoiDung);

        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_PhanQuyen' table. You can move, or remove it, as needed.
            this.qL_PhanQuyenTableAdapter.Fill(this.qLNguoiDung.QL_PhanQuyen);
            // TODO: This line of code loads data into the 'qLNguoiDung.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.qLNguoiDung.QL_NhomNguoiDung);

        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qLPhanQuyen_DKTableAdapter.Fill_dk(this.qLNguoiDung.QLPhanQuyen_DK, maNhomNDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void qL_NhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            string maNhomND = qL_NhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (maNhomND!=null)
            {
                try
                {
                    this.qLPhanQuyen_DKTableAdapter.Fill_dk(this.qLNguoiDung.QLPhanQuyen_DK, maNhomND);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void qLPhanQuyen_DKDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
