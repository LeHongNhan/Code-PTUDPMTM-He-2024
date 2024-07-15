using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomComponent;

namespace UC_DongHo
{
    public partial class DongHoDemNguoc: UserControl
    {
        private DongHo dongHo;
        public DongHoDemNguoc()
        {
            InitializeComponent();
            btnRun.Click += new EventHandler(btnRun_Click);
            timer1.Tick += new EventHandler(timer1_Tick);
            dongHo = new DongHo();
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {

                var (hours, minutes, seconds) = timeTextBox1.GetTime();
                dongHo.gio = hours;
                dongHo.phut = minutes;
                dongHo.giay = seconds;
                timer1.Start();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dongHo.demNguoc();
            capNhatTimeTextBox();
        }

        private void capNhatTimeTextBox()
        {
            timeTextBox1.Text = $"{dongHo.gio:00}:{dongHo.phut:00}:{dongHo.giay:00}";
        }
    }
}
