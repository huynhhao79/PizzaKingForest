namespace DXApplication1
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gctTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTK = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoiTK = new DevExpress.XtraEditors.SimpleButton();
            this.cboQuyen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.gctTK);
            this.groupControl1.Controls.Add(this.btnSuaTK);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXoaTK);
            this.groupControl1.Controls.Add(this.btnThemTK);
            this.groupControl1.Controls.Add(this.btnLamMoiTK);
            this.groupControl1.Controls.Add(this.cboQuyen);
            this.groupControl1.Controls.Add(this.txtTenTK);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(932, 547);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin tài khoản";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaNV.Location = new System.Drawing.Point(375, 69);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.Tag = "";
            this.txtMaNV.Size = new System.Drawing.Size(259, 28);
            this.txtMaNV.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(230, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 19);
            this.labelControl2.TabIndex = 124;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // gctTK
            // 
            this.gctTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctTK.Location = new System.Drawing.Point(2, 368);
            this.gctTK.MainView = this.gridView1;
            this.gctTK.Name = "gctTK";
            this.gctTK.Size = new System.Drawing.Size(928, 177);
            this.gctTK.TabIndex = 8;
            this.gctTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gctTK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gctTK_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTK,
            this.colQuyen,
            this.colMaNV});
            this.gridView1.GridControl = this.gctTK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTK
            // 
            this.colTK.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTK.AppearanceCell.Options.UseFont = true;
            this.colTK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTK.AppearanceHeader.Options.UseFont = true;
            this.colTK.Caption = "Tài khoản";
            this.colTK.FieldName = "TK";
            this.colTK.Name = "colTK";
            this.colTK.Visible = true;
            this.colTK.VisibleIndex = 1;
            // 
            // colQuyen
            // 
            this.colQuyen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuyen.AppearanceCell.Options.UseFont = true;
            this.colQuyen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuyen.AppearanceHeader.Options.UseFont = true;
            this.colQuyen.Caption = "Quyền";
            this.colQuyen.FieldName = "Quyen";
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Visible = true;
            this.colQuyen.VisibleIndex = 2;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colMaNV.AppearanceCell.Options.UseFont = true;
            this.colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuaTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.Appearance.Options.UseFont = true;
            this.btnSuaTK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSuaTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaTK.ImageOptions.SvgImage")));
            this.btnSuaTK.Location = new System.Drawing.Point(268, 187);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(94, 40);
            this.btnSuaTK.TabIndex = 4;
            this.btnSuaTK.ToolTip = "Sửa tài khoản";
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(752, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 39);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "simpleButton2";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Appearance.Options.UseFont = true;
            this.btnXoaTK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoaTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTK.ImageOptions.SvgImage")));
            this.btnXoaTK.Location = new System.Drawing.Point(408, 187);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(94, 39);
            this.btnXoaTK.TabIndex = 5;
            this.btnXoaTK.ToolTip = "Xóa tài khoản";
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThemTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Appearance.Options.UseFont = true;
            this.btnThemTK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemTK.ImageOptions.SvgImage")));
            this.btnThemTK.Location = new System.Drawing.Point(65, 186);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemTK.Size = new System.Drawing.Size(94, 40);
            this.btnThemTK.TabIndex = 3;
            this.btnThemTK.ToolTip = "Thêm tài khoản";
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnLamMoiTK
            // 
            this.btnLamMoiTK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLamMoiTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTK.Appearance.Options.UseFont = true;
            this.btnLamMoiTK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoiTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiTK.ImageOptions.SvgImage")));
            this.btnLamMoiTK.Location = new System.Drawing.Point(540, 188);
            this.btnLamMoiTK.Name = "btnLamMoiTK";
            this.btnLamMoiTK.Size = new System.Drawing.Size(94, 39);
            this.btnLamMoiTK.TabIndex = 6;
            this.btnLamMoiTK.ToolTip = "Làm trống trường nhập liệu";
            this.btnLamMoiTK.Click += new System.EventHandler(this.btnLamMoiTK_Click);
            // 
            // cboQuyen
            // 
            this.cboQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboQuyen.EditValue = "Admin";
            this.cboQuyen.Location = new System.Drawing.Point(375, 166);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuyen.Properties.Appearance.Options.UseFont = true;
            this.cboQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuyen.Properties.DropDownRows = 2;
            this.cboQuyen.Properties.Items.AddRange(new object[] {
            "Admin",
            "NhanVien"});
            this.cboQuyen.Size = new System.Drawing.Size(259, 28);
            this.cboQuyen.TabIndex = 2;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTenTK.EditValue = "";
            this.txtTenTK.Location = new System.Drawing.Point(375, 117);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Properties.Appearance.Options.UseFont = true;
            this.txtTenTK.Size = new System.Drawing.Size(259, 28);
            this.txtTenTK.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(230, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 19);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "Quyền";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(230, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 19);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Tên tài khoản";
            // 
            // frmTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 547);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmTaiKhoan.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboQuyen;
        private DevExpress.XtraGrid.GridControl gctTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTK;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyen;
        private DevExpress.XtraEditors.SimpleButton btnSuaTK;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaTK;
        private DevExpress.XtraEditors.SimpleButton btnThemTK;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiTK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}