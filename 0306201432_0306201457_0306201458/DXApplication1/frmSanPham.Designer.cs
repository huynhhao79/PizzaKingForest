namespace DXApplication1
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gctSP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnhSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSuaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoiSP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemAnhSP = new DevExpress.XtraEditors.SimpleButton();
            this.picAnhSP = new DevExpress.XtraEditors.PictureEdit();
            this.lueLoaiSP = new DevExpress.XtraEditors.LookUpEdit();
            this.ofdFile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSP.Properties)).BeginInit();
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
            this.groupControl1.Controls.Add(this.txtMaSP);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.gctSP);
            this.groupControl1.Controls.Add(this.btnSuaSP);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXoaSP);
            this.groupControl1.Controls.Add(this.btnThemSP);
            this.groupControl1.Controls.Add(this.btnLamMoiSP);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtMoTa);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTenSP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnThemAnhSP);
            this.groupControl1.Controls.Add(this.picAnhSP);
            this.groupControl1.Controls.Add(this.lueLoaiSP);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1111, 517);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(381, 45);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaSP.Size = new System.Drawing.Size(259, 28);
            this.txtMaSP.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(248, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 19);
            this.labelControl3.TabIndex = 119;
            this.labelControl3.Text = "Mã sản phẩm";
            // 
            // gctSP
            // 
            this.gctSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctSP.Location = new System.Drawing.Point(0, 271);
            this.gctSP.MainView = this.gridView1;
            this.gctSP.Name = "gctSP";
            this.gctSP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gctSP.Size = new System.Drawing.Size(1111, 246);
            this.gctSP.TabIndex = 13;
            this.gctSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gctSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gctSP_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSP,
            this.colMaLSP,
            this.colMoTa,
            this.colDonGia,
            this.colMaSP,
            this.colAnhSP});
            this.gridView1.GridControl = this.gctSP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenSP
            // 
            this.colTenSP.AccessibleName = "TenSP";
            this.colTenSP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.AppearanceCell.Options.UseFont = true;
            this.colTenSP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.AppearanceHeader.Options.UseFont = true;
            this.colTenSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSP.Caption = "Tên sản phẩm";
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 220;
            // 
            // colMaLSP
            // 
            this.colMaLSP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLSP.AppearanceCell.Options.UseFont = true;
            this.colMaLSP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLSP.AppearanceHeader.Options.UseFont = true;
            this.colMaLSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLSP.Caption = "Loại sản phẩm";
            this.colMaLSP.FieldName = "MaLoaiSP";
            this.colMaLSP.Name = "colMaLSP";
            this.colMaLSP.Visible = true;
            this.colMaLSP.VisibleIndex = 2;
            this.colMaLSP.Width = 184;
            // 
            // colMoTa
            // 
            this.colMoTa.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMoTa.AppearanceCell.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMoTa.AppearanceHeader.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMoTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 3;
            this.colMoTa.Width = 367;
            // 
            // colDonGia
            // 
            this.colDonGia.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDonGia.AppearanceCell.Options.UseFont = true;
            this.colDonGia.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDonGia.AppearanceHeader.Options.UseFont = true;
            this.colDonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.colDonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 4;
            this.colDonGia.Width = 193;
            // 
            // colMaSP
            // 
            this.colMaSP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSP.AppearanceCell.Options.UseFont = true;
            this.colMaSP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSP.AppearanceHeader.Options.UseFont = true;
            this.colMaSP.Caption = "Mã sản phẩm";
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 120;
            // 
            // colAnhSP
            // 
            this.colAnhSP.Caption = "AnhSP";
            this.colAnhSP.FieldName = "AnhSP";
            this.colAnhSP.Name = "colAnhSP";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Appearance.Options.UseFont = true;
            this.btnSuaSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSuaSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaSP.ImageOptions.SvgImage")));
            this.btnSuaSP.Location = new System.Drawing.Point(405, 210);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(94, 40);
            this.btnSuaSP.TabIndex = 9;
            this.btnSuaSP.ToolTip = "Sửa thông tin sản phẩm";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(944, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 39);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "btnThoatSP";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Appearance.Options.UseFont = true;
            this.btnXoaSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoaSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaSP.ImageOptions.SvgImage")));
            this.btnXoaSP.Location = new System.Drawing.Point(581, 209);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(94, 39);
            this.btnXoaSP.TabIndex = 10;
            this.btnXoaSP.ToolTip = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Appearance.Options.UseFont = true;
            this.btnThemSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemSP.ImageOptions.SvgImage")));
            this.btnThemSP.Location = new System.Drawing.Point(227, 209);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemSP.Size = new System.Drawing.Size(94, 40);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.ToolTip = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiSP.Appearance.Options.UseFont = true;
            this.btnLamMoiSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoiSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiSP.ImageOptions.SvgImage")));
            this.btnLamMoiSP.Location = new System.Drawing.Point(767, 210);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(94, 39);
            this.btnLamMoiSP.TabIndex = 11;
            this.btnLamMoiSP.ToolTip = "Làm trống trường nhập liệu";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(683, 98);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 109;
            this.labelControl8.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(794, 94);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(259, 28);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(794, 45);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Size = new System.Drawing.Size(259, 28);
            this.txtMoTa.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(683, 49);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 19);
            this.labelControl6.TabIndex = 105;
            this.labelControl6.Text = "Mô tả";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(248, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 19);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Loại sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(381, 94);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenSP.Size = new System.Drawing.Size(259, 28);
            this.txtTenSP.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(248, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 19);
            this.labelControl1.TabIndex = 97;
            this.labelControl1.Text = "Tên sản phẩm";
            // 
            // btnThemAnhSP
            // 
            this.btnThemAnhSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnhSP.Appearance.Options.UseFont = true;
            this.btnThemAnhSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemAnhSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemAnhSP.ImageOptions.SvgImage")));
            this.btnThemAnhSP.Location = new System.Drawing.Point(50, 209);
            this.btnThemAnhSP.Name = "btnThemAnhSP";
            this.btnThemAnhSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemAnhSP.Size = new System.Drawing.Size(94, 40);
            this.btnThemAnhSP.TabIndex = 7;
            this.btnThemAnhSP.ToolTip = "Thêm ảnh";
            this.btnThemAnhSP.Click += new System.EventHandler(this.btnThemAnhSP_Click);
            // 
            // picAnhSP
            // 
            this.picAnhSP.Location = new System.Drawing.Point(12, 43);
            this.picAnhSP.Name = "picAnhSP";
            this.picAnhSP.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnhSP.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnhSP.Size = new System.Drawing.Size(174, 148);
            this.picAnhSP.TabIndex = 6;
            // 
            // lueLoaiSP
            // 
            this.lueLoaiSP.Location = new System.Drawing.Point(381, 146);
            this.lueLoaiSP.Name = "lueLoaiSP";
            this.lueLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiSP.Properties.NullText = "";
            this.lueLoaiSP.Properties.PopupSizeable = false;
            this.lueLoaiSP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLoaiSP.Size = new System.Drawing.Size(259, 28);
            this.lueLoaiSP.TabIndex = 5;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "xtraOpenFileDialog1";
            // 
            // frmSanPham
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 517);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmSanPham.IconOptions.Image")));
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnThemAnhSP;
        private DevExpress.XtraEditors.PictureEdit picAnhSP;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSuaSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiSP;
        private DevExpress.XtraGrid.GridControl gctSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiSP;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofdFile;
        private DevExpress.XtraGrid.Columns.GridColumn colAnhSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;

    }
}