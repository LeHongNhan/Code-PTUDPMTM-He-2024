using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeHongNhan_B01
{
    public partial class MaTran : Form
    {
        public MaTran()
        {
            InitializeComponent();
        }
       
        public static bool checkO = false;
        

        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            int hang = 0;
            int cot = 0;
            if (!int.TryParse(txtHang.Text, out hang) || !int.TryParse(txtCot.Text, out cot))
            {
                MessageBox.Show("Xem lại hàng, cột");
            }
            if (hang > 50 || cot > 50)
            {
                MessageBox.Show("Cấp ma trận không được lớn hơn 50");
            }
            xuLyMatran xl = new xuLyMatran(hang, cot);
            xl.phatSinhOCo(progressBar1,pnlBanCo, hang, cot);

        }

        private void txtHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MaTran_Load(object sender, EventArgs e)
        {

        }
    }
}
