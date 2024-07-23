namespace B05_ModuleDangNhap
{
    partial class PhanQuyen
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNguoiDung = new B05_ModuleDangNhap.QLNguoiDung();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.TableAdapterManager();
            this.qL_PhanQuyenTableAdapter = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.QL_PhanQuyenTableAdapter();
            this.qLPhanQuyen_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhanQuyen_DKTableAdapter = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.QLPhanQuyen_DKTableAdapter();
            this.fill_dkToolStrip = new System.Windows.Forms.ToolStrip();
            this.maNhomNDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maNhomNDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_dkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.qLPhanQuyen_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen_DKBindingSource)).BeginInit();
            this.fill_dkToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen_DKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qL_NhomNguoiDungDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm người dùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qLPhanQuyen_DKDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(409, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 316);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách quyền chức năng";
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.qLNguoiDung;
            // 
            // qLNguoiDung
            // 
            this.qLNguoiDung.DataSetName = "QLNguoiDung";
            this.qLNguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_PhanQuyenBindingSource
            // 
            this.qL_PhanQuyenBindingSource.DataMember = "QL_PhanQuyen";
            this.qL_PhanQuyenBindingSource.DataSource = this.qLNguoiDung;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDung_DKTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = this.qL_PhanQuyenTableAdapter;
            this.tableAdapterManager.UpdateOrder = B05_ModuleDangNhap.QLNguoiDungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_PhanQuyenTableAdapter
            // 
            this.qL_PhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // qLPhanQuyen_DKBindingSource
            // 
            this.qLPhanQuyen_DKBindingSource.DataMember = "QLPhanQuyen_DK";
            this.qLPhanQuyen_DKBindingSource.DataSource = this.qLNguoiDung;
            // 
            // qLPhanQuyen_DKTableAdapter
            // 
            this.qLPhanQuyen_DKTableAdapter.ClearBeforeFill = true;
            // 
            // fill_dkToolStrip
            // 
            this.fill_dkToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maNhomNDToolStripLabel,
            this.maNhomNDToolStripTextBox,
            this.fill_dkToolStripButton});
            this.fill_dkToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fill_dkToolStrip.Name = "fill_dkToolStrip";
            this.fill_dkToolStrip.Size = new System.Drawing.Size(795, 25);
            this.fill_dkToolStrip.TabIndex = 1;
            this.fill_dkToolStrip.Text = "fill_dkToolStrip";
            // 
            // maNhomNDToolStripLabel
            // 
            this.maNhomNDToolStripLabel.Name = "maNhomNDToolStripLabel";
            this.maNhomNDToolStripLabel.Size = new System.Drawing.Size(78, 22);
            this.maNhomNDToolStripLabel.Text = "MaNhomND:";
            // 
            // maNhomNDToolStripTextBox
            // 
            this.maNhomNDToolStripTextBox.Name = "maNhomNDToolStripTextBox";
            this.maNhomNDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fill_dkToolStripButton
            // 
            this.fill_dkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_dkToolStripButton.Name = "fill_dkToolStripButton";
            this.fill_dkToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.fill_dkToolStripButton.Text = "Fill_dk";
            this.fill_dkToolStripButton.Click += new System.EventHandler(this.fill_dkToolStripButton_Click);
            // 
            // qLPhanQuyen_DKDataGridView
            // 
            this.qLPhanQuyen_DKDataGridView.AutoGenerateColumns = false;
            this.qLPhanQuyen_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qLPhanQuyen_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qLPhanQuyen_DKDataGridView.DataSource = this.qLPhanQuyen_DKBindingSource;
            this.qLPhanQuyen_DKDataGridView.Location = new System.Drawing.Point(6, 19);
            this.qLPhanQuyen_DKDataGridView.Name = "qLPhanQuyen_DKDataGridView";
            this.qLPhanQuyen_DKDataGridView.Size = new System.Drawing.Size(345, 220);
            this.qLPhanQuyen_DKDataGridView.TabIndex = 0;
            this.qLPhanQuyen_DKDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qLPhanQuyen_DKDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_NhomNguoiDungDataGridView
            // 
            this.qL_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.qL_NhomNguoiDungDataGridView.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(6, 19);
            this.qL_NhomNguoiDungDataGridView.Name = "qL_NhomNguoiDungDataGridView";
            this.qL_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(300, 220);
            this.qL_NhomNguoiDungDataGridView.TabIndex = 0;
            this.qL_NhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn5.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 431);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.fill_dkToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen_DKBindingSource)).EndInit();
            this.fill_dkToolStrip.ResumeLayout(false);
            this.fill_dkToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhanQuyen_DKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLNguoiDung qLNguoiDung;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private QLNguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private QLNguoiDungTableAdapters.TableAdapterManager tableAdapterManager;
        private QLNguoiDungTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private System.Windows.Forms.BindingSource qLPhanQuyen_DKBindingSource;
        private QLNguoiDungTableAdapters.QLPhanQuyen_DKTableAdapter qLPhanQuyen_DKTableAdapter;
        private System.Windows.Forms.ToolStrip fill_dkToolStrip;
        private System.Windows.Forms.ToolStripLabel maNhomNDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maNhomNDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_dkToolStripButton;
        private System.Windows.Forms.DataGridView qL_NhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView qLPhanQuyen_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnLuu;
    }
}