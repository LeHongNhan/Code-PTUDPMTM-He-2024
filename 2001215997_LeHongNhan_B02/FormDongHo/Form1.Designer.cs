namespace FormDongHo
{
    partial class Form1
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
            this.dongHoDemNguoc1 = new UC_DongHo.DongHoDemNguoc();
            this.SuspendLayout();
            // 
            // dongHoDemNguoc1
            // 
            this.dongHoDemNguoc1.Location = new System.Drawing.Point(117, 63);
            this.dongHoDemNguoc1.Name = "dongHoDemNguoc1";
            this.dongHoDemNguoc1.Size = new System.Drawing.Size(173, 79);
            this.dongHoDemNguoc1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dongHoDemNguoc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_DongHo.DongHoDemNguoc dongHoDemNguoc1;
    }
}

