namespace UC_DongHo
{
    partial class DongHoDemNguoc
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeTextBox1 = new CustomComponent.TimeTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.Location = new System.Drawing.Point(18, 14);
            this.timeTextBox1.Mask = "00:00:00";
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox1.TabIndex = 0;
            this.timeTextBox1.ValidatingType = typeof(System.TimeSpan);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(18, 43);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DongHoDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.timeTextBox1);
            this.Name = "DongHoDemNguoc";
            this.Size = new System.Drawing.Size(173, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComponent.TimeTextBox timeTextBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
    }
}
