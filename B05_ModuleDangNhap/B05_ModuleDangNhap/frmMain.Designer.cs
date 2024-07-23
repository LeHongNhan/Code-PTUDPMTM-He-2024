namespace B05_ModuleDangNhap
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNhomND = new System.Windows.Forms.ToolStripMenuItem();
            this.itemManHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngVàoNhóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemPhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNguoidung,
            this.itemNhomND,
            this.itemManHinh,
            this.thêmNgườiDùngVàoNhóToolStripMenuItem,
            this.itemPhanQuyen});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // itemNguoidung
            // 
            this.itemNguoidung.Name = "itemNguoidung";
            this.itemNguoidung.Size = new System.Drawing.Size(218, 22);
            this.itemNguoidung.Text = "Người dùng";
            this.itemNguoidung.Click += new System.EventHandler(this.itemNguoidung_Click);
            // 
            // itemNhomND
            // 
            this.itemNhomND.Name = "itemNhomND";
            this.itemNhomND.Size = new System.Drawing.Size(218, 22);
            this.itemNhomND.Text = "Nhóm người dùng";
            this.itemNhomND.Click += new System.EventHandler(this.itemNhomND_Click);
            // 
            // itemManHinh
            // 
            this.itemManHinh.Name = "itemManHinh";
            this.itemManHinh.Size = new System.Drawing.Size(218, 22);
            this.itemManHinh.Text = "Màn hình";
            this.itemManHinh.Click += new System.EventHandler(this.itemManHinh_Click);
            // 
            // thêmNgườiDùngVàoNhóToolStripMenuItem
            // 
            this.thêmNgườiDùngVàoNhóToolStripMenuItem.Name = "thêmNgườiDùngVàoNhóToolStripMenuItem";
            this.thêmNgườiDùngVàoNhóToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thêmNgườiDùngVàoNhóToolStripMenuItem.Text = "Thêm người dùng vào nhó,";
            this.thêmNgườiDùngVàoNhóToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngVàoNhóToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Trạng thái";
            // 
            // itemPhanQuyen
            // 
            this.itemPhanQuyen.Name = "itemPhanQuyen";
            this.itemPhanQuyen.Size = new System.Drawing.Size(218, 22);
            this.itemPhanQuyen.Text = "phan quyen";
            this.itemPhanQuyen.Click += new System.EventHandler(this.itemPhanQuyen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 364);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemNguoidung;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem itemNhomND;
        private System.Windows.Forms.ToolStripMenuItem itemManHinh;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngVàoNhóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPhanQuyen;
    }
}