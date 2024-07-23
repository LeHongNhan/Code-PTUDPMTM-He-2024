using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B05_ModuleDangNhap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmDangNhap frmDN;
        public static frmMain mainForm;
        public static frmCauHinh cauhinh;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new frmDangNhap();
            mainForm = new frmMain();
            Application.Run(mainForm);
        }
    }
}
