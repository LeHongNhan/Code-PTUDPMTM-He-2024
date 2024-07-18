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
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
            CauHinh = new XuLyDangNhap();
            cboServer.DropDown += cboServer_DropDown;
            cboDataBase.DropDown += cboDataBase_DropDown;
            btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cboServer.Text, txtUsername.Text, txtPassword.Text,cboDataBase.Text);
            Program.frmDN.Show();
            this.Close();
        }

        void cboServer_DropDown(object sender, EventArgs e)
        {
            DataTable dtServers = CauHinh.GetServerName();
            dtServers.Columns.Add("CombinedName", typeof(string), "ServerName + '\\' + ISNULL(InstanceName, '')");
            cboServer.DataSource = dtServers;
            cboServer.DisplayMember = "CombinedName";
        }
        XuLyDangNhap CauHinh;
        void cboDataBase_DropDown(object sender, EventArgs e)
        {
            cboDataBase.DataSource = CauHinh.GetDBName(cboServer.Text, txtUsername.Text, txtPassword.Text);
            cboDataBase.DisplayMember = "name";
        }
    }
}
