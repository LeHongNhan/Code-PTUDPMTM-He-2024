namespace LeHongNhan_B01
{
    partial class MaTran:Form
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
            this.btnPhatSinh = new System.Windows.Forms.Button();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPhatSinh
            // 
            this.btnPhatSinh.Location = new System.Drawing.Point(94, 11);
            this.btnPhatSinh.Name = "btnPhatSinh";
            this.btnPhatSinh.Size = new System.Drawing.Size(64, 23);
            this.btnPhatSinh.TabIndex = 0;
            this.btnPhatSinh.Text = "button1";
            this.btnPhatSinh.UseVisualStyleBackColor = true;
            this.btnPhatSinh.Click += new System.EventHandler(this.btnPhatSinh_Click);
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(12, 12);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(35, 20);
            this.txtHang.TabIndex = 1;
            this.txtHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHang_KeyPress);
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(53, 12);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(35, 20);
            this.txtCot.TabIndex = 1;
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBanCo.Location = new System.Drawing.Point(12, 39);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(414, 317);
            this.pnlBanCo.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 362);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // MaTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 409);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.btnPhatSinh);
            this.Name = "MaTran";
            this.Text = "MaTran";
            this.Load += new System.EventHandler(this.MaTran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhatSinh;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}