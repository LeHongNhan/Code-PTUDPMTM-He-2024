namespace B05_ModuleDangNhap
{
    partial class frmQLManHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLManHinh));
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            this.qLNguoiDung = new B05_ModuleDangNhap.QLNguoiDung();
            this.dM_ManHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ManHinhTableAdapter = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.DM_ManHinhTableAdapter();
            this.tableAdapterManager = new B05_ModuleDangNhap.QLNguoiDungTableAdapters.TableAdapterManager();
            this.dM_ManHinhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dM_ManHinhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dM_ManHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).BeginInit();
            this.dM_ManHinhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qLNguoiDung
            // 
            this.qLNguoiDung.DataSetName = "QLNguoiDung";
            this.qLNguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_ManHinhBindingSource
            // 
            this.dM_ManHinhBindingSource.DataMember = "DM_ManHinh";
            this.dM_ManHinhBindingSource.DataSource = this.qLNguoiDung;
            // 
            // dM_ManHinhTableAdapter
            // 
            this.dM_ManHinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = this.dM_ManHinhTableAdapter;
            this.tableAdapterManager.QL_NguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = B05_ModuleDangNhap.QLNguoiDungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_ManHinhBindingNavigator
            // 
            this.dM_ManHinhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dM_ManHinhBindingNavigator.BindingSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dM_ManHinhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dM_ManHinhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dM_ManHinhBindingNavigatorSaveItem});
            this.dM_ManHinhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dM_ManHinhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dM_ManHinhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dM_ManHinhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dM_ManHinhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dM_ManHinhBindingNavigator.Name = "dM_ManHinhBindingNavigator";
            this.dM_ManHinhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dM_ManHinhBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.dM_ManHinhBindingNavigator.TabIndex = 0;
            this.dM_ManHinhBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dM_ManHinhBindingNavigatorSaveItem
            // 
            this.dM_ManHinhBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dM_ManHinhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dM_ManHinhBindingNavigatorSaveItem.Image")));
            this.dM_ManHinhBindingNavigatorSaveItem.Name = "dM_ManHinhBindingNavigatorSaveItem";
            this.dM_ManHinhBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dM_ManHinhBindingNavigatorSaveItem.Text = "Save Data";
            this.dM_ManHinhBindingNavigatorSaveItem.Click += new System.EventHandler(this.dM_ManHinhBindingNavigatorSaveItem_Click);
            // 
            // dM_ManHinhDataGridView
            // 
            this.dM_ManHinhDataGridView.AutoGenerateColumns = false;
            this.dM_ManHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dM_ManHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dM_ManHinhDataGridView.DataSource = this.dM_ManHinhBindingSource;
            this.dM_ManHinhDataGridView.Location = new System.Drawing.Point(12, 130);
            this.dM_ManHinhDataGridView.Name = "dM_ManHinhDataGridView";
            this.dM_ManHinhDataGridView.Size = new System.Drawing.Size(300, 220);
            this.dM_ManHinhDataGridView.TabIndex = 1;
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
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(35, 60);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(74, 13);
            maManHinhLabel.TabIndex = 2;
            maManHinhLabel.Text = "Ma Man Hinh:";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Location = new System.Drawing.Point(119, 57);
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.maManHinhTextBox.TabIndex = 3;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(35, 86);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(78, 13);
            tenManHinhLabel.TabIndex = 4;
            tenManHinhLabel.Text = "Ten Man Hinh:";
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dM_ManHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Location = new System.Drawing.Point(119, 83);
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenManHinhTextBox.TabIndex = 5;
            // 
            // QLManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 371);
            this.Controls.Add(maManHinhLabel);
            this.Controls.Add(this.maManHinhTextBox);
            this.Controls.Add(tenManHinhLabel);
            this.Controls.Add(this.tenManHinhTextBox);
            this.Controls.Add(this.dM_ManHinhDataGridView);
            this.Controls.Add(this.dM_ManHinhBindingNavigator);
            this.Name = "QLManHinh";
            this.Text = "QLManHinh";
            this.Load += new System.EventHandler(this.QLManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhBindingNavigator)).EndInit();
            this.dM_ManHinhBindingNavigator.ResumeLayout(false);
            this.dM_ManHinhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dM_ManHinhDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLNguoiDung qLNguoiDung;
        private System.Windows.Forms.BindingSource dM_ManHinhBindingSource;
        private QLNguoiDungTableAdapters.DM_ManHinhTableAdapter dM_ManHinhTableAdapter;
        private QLNguoiDungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dM_ManHinhBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dM_ManHinhBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dM_ManHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
    }
}