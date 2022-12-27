namespace DXApplication1
{
    partial class frmNhanVien
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
            DevExpress.XtraGrid.Columns.GridColumn colMaNV;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCCCD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gctNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTenLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemAnhNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoiNV = new DevExpress.XtraEditors.SimpleButton();
            this.cboChucVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTenLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.picAnhNV = new DevExpress.XtraEditors.PictureEdit();
            this.detNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.ofdFile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colMaNV
            // 
            colMaNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            colMaNV.AppearanceCell.Options.UseFont = true;
            colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            colMaNV.AppearanceHeader.Options.UseFont = true;
            colMaNV.AppearanceHeader.Options.UseTextOptions = true;
            colMaNV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMaNV.Caption = "Mã NV";
            colMaNV.FieldName = "MaNV";
            colMaNV.Name = "colMaNV";
            colMaNV.Visible = true;
            colMaNV.VisibleIndex = 0;
            colMaNV.Width = 68;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtCCCD);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.gctNhanVien);
            this.groupControl1.Controls.Add(this.btnThemAnhNV);
            this.groupControl1.Controls.Add(this.btnSuaNV);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXoaNV);
            this.groupControl1.Controls.Add(this.btnThemNV);
            this.groupControl1.Controls.Add(this.btnLamMoiNV);
            this.groupControl1.Controls.Add(this.cboChucVu);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cboGioiTinh);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTenNV);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHoTenLot);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.picAnhNV);
            this.groupControl1.Controls.Add(this.detNgaySinh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1018, 592);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin nhân viên";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCCD.Location = new System.Drawing.Point(707, 186);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Properties.Appearance.Options.UseFont = true;
            this.txtCCCD.Properties.MaxLength = 12;
            this.txtCCCD.Size = new System.Drawing.Size(259, 28);
            this.txtCCCD.TabIndex = 8;
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(608, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 19);
            this.labelControl3.TabIndex = 95;
            this.labelControl3.Text = "CCCD";
            // 
            // gctNhanVien
            // 
            this.gctNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gctNhanVien.Location = new System.Drawing.Point(2, 295);
            this.gctNhanVien.MainView = this.gridView1;
            this.gctNhanVien.Name = "gctNhanVien";
            this.gctNhanVien.Size = new System.Drawing.Size(1014, 295);
            this.gctNhanVien.TabIndex = 18;
            this.gctNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gctNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gctNhanVien_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colMaNV,
            this.colHoTenLot,
            this.colTen,
            this.colPhai,
            this.colNgaySinh,
            this.colChucVu,
            this.colDiaChi,
            this.colSDT,
            this.colEmail,
            this.colCCCD,
            this.colAnhNV});
            this.gridView1.GridControl = this.gctNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHoTenLot
            // 
            this.colHoTenLot.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colHoTenLot.AppearanceCell.Options.UseFont = true;
            this.colHoTenLot.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colHoTenLot.AppearanceHeader.Options.UseFont = true;
            this.colHoTenLot.AppearanceHeader.Options.UseTextOptions = true;
            this.colHoTenLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoTenLot.Caption = "Họ tên lót";
            this.colHoTenLot.FieldName = "HoTenLotNV";
            this.colHoTenLot.Name = "colHoTenLot";
            this.colHoTenLot.Visible = true;
            this.colHoTenLot.VisibleIndex = 1;
            this.colHoTenLot.Width = 85;
            // 
            // colTen
            // 
            this.colTen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colTen.AppearanceCell.Options.UseFont = true;
            this.colTen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colTen.AppearanceHeader.Options.UseFont = true;
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "TenNV";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 65;
            // 
            // colPhai
            // 
            this.colPhai.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colPhai.AppearanceCell.Options.UseFont = true;
            this.colPhai.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colPhai.AppearanceHeader.Options.UseFont = true;
            this.colPhai.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhai.Caption = "Phái";
            this.colPhai.FieldName = "Phai";
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 65;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colNgaySinh.AppearanceCell.Options.UseFont = true;
            this.colNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.colNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.Caption = "Ngày sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 4;
            // 
            // colChucVu
            // 
            this.colChucVu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colChucVu.AppearanceCell.Options.UseFont = true;
            this.colChucVu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colChucVu.AppearanceHeader.Options.UseFont = true;
            this.colChucVu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChucVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChucVu.Caption = "Chức vụ";
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 5;
            this.colChucVu.Width = 63;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colDiaChi.AppearanceCell.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 6;
            this.colDiaChi.Width = 63;
            // 
            // colSDT
            // 
            this.colSDT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colSDT.AppearanceCell.Options.UseFont = true;
            this.colSDT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colSDT.AppearanceHeader.Options.UseFont = true;
            this.colSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 7;
            this.colSDT.Width = 63;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            this.colEmail.Width = 63;
            // 
            // colCCCD
            // 
            this.colCCCD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colCCCD.AppearanceCell.Options.UseFont = true;
            this.colCCCD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.colCCCD.AppearanceHeader.Options.UseFont = true;
            this.colCCCD.AppearanceHeader.Options.UseTextOptions = true;
            this.colCCCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCCCD.Caption = "CCCD";
            this.colCCCD.FieldName = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.Visible = true;
            this.colCCCD.VisibleIndex = 9;
            this.colCCCD.Width = 73;
            // 
            // colAnhNV
            // 
            this.colAnhNV.Caption = "Ảnh NV";
            this.colAnhNV.FieldName = "AnhThe";
            this.colAnhNV.Name = "colAnhNV";
            // 
            // btnThemAnhNV
            // 
            this.btnThemAnhNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnhNV.Appearance.Options.UseFont = true;
            this.btnThemAnhNV.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemAnhNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemAnhNV.ImageOptions.SvgImage")));
            this.btnThemAnhNV.Location = new System.Drawing.Point(34, 227);
            this.btnThemAnhNV.Name = "btnThemAnhNV";
            this.btnThemAnhNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemAnhNV.Size = new System.Drawing.Size(94, 40);
            this.btnThemAnhNV.TabIndex = 12;
            this.btnThemAnhNV.ToolTip = "Thêm ảnh";
            this.btnThemAnhNV.Click += new System.EventHandler(this.btnThemAnhNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Appearance.Options.UseFont = true;
            this.btnSuaNV.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSuaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNV.ImageOptions.SvgImage")));
            this.btnSuaNV.Location = new System.Drawing.Point(271, 205);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(94, 40);
            this.btnSuaNV.TabIndex = 14;
            this.btnSuaNV.ToolTip = "Sửa thông tin nhân viên";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(862, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 40);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "simpleButton2";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Appearance.Options.UseFont = true;
            this.btnXoaNV.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNV.ImageOptions.SvgImage")));
            this.btnXoaNV.Location = new System.Drawing.Point(463, 205);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(94, 40);
            this.btnXoaNV.TabIndex = 15;
            this.btnXoaNV.ToolTip = "Xóa thông tin nhân viên";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Appearance.Options.UseFont = true;
            this.btnThemNV.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNV.ImageOptions.SvgImage")));
            this.btnThemNV.Location = new System.Drawing.Point(67, 205);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemNV.Size = new System.Drawing.Size(94, 40);
            this.btnThemNV.TabIndex = 13;
            this.btnThemNV.ToolTip = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiNV.Appearance.Options.UseFont = true;
            this.btnLamMoiNV.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiNV.ImageOptions.SvgImage")));
            this.btnLamMoiNV.Location = new System.Drawing.Point(651, 205);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(94, 40);
            this.btnLamMoiNV.TabIndex = 16;
            this.btnLamMoiNV.ToolTip = "Cập nhật";
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucVu.Location = new System.Drawing.Point(707, 234);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.Properties.Appearance.Options.UseFont = true;
            this.cboChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChucVu.Properties.DropDownRows = 2;
            this.cboChucVu.Properties.Items.AddRange(new object[] {
            "NhanVien",
            "Admin"});
            this.cboChucVu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboChucVu.Size = new System.Drawing.Size(259, 28);
            this.cboChucVu.TabIndex = 10;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(608, 238);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 19);
            this.labelControl10.TabIndex = 87;
            this.labelControl10.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(707, 137);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.MaxLength = 10;
            this.txtSDT.Size = new System.Drawing.Size(259, 28);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(608, 141);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 19);
            this.labelControl9.TabIndex = 85;
            this.labelControl9.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(707, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(259, 28);
            this.txtEmail.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(608, 93);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 19);
            this.labelControl8.TabIndex = 83;
            this.labelControl8.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(707, 42);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.MaxLength = 50;
            this.txtDiaChi.Size = new System.Drawing.Size(259, 28);
            this.txtDiaChi.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(608, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 19);
            this.labelControl7.TabIndex = 81;
            this.labelControl7.Text = "Địa chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(215, 238);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 19);
            this.labelControl6.TabIndex = 78;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Location = new System.Drawing.Point(342, 186);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.cboGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Properties.DropDownRows = 3;
            this.cboGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboGioiTinh.Size = new System.Drawing.Size(259, 28);
            this.cboGioiTinh.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(215, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 19);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Giới tính";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(342, 139);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Properties.MaxLength = 30;
            this.txtTenNV.Size = new System.Drawing.Size(259, 28);
            this.txtTenNV.TabIndex = 5;
            this.txtTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNV_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(215, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 19);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Tên nhân viên";
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(342, 91);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenLot.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenLot.Properties.MaxLength = 30;
            this.txtHoTenLot.Size = new System.Drawing.Size(259, 28);
            this.txtHoTenLot.TabIndex = 3;
            this.txtHoTenLot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenLot_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(215, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 19);
            this.labelControl2.TabIndex = 72;
            this.labelControl2.Text = "Họ tên lót";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(342, 43);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(259, 28);
            this.txtMaNV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(215, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 19);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // picAnhNV
            // 
            this.picAnhNV.Location = new System.Drawing.Point(12, 47);
            this.picAnhNV.Name = "picAnhNV";
            this.picAnhNV.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnhNV.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picAnhNV.Size = new System.Drawing.Size(139, 165);
            this.picAnhNV.TabIndex = 11;
            // 
            // detNgaySinh
            // 
            this.detNgaySinh.EditValue = null;
            this.detNgaySinh.Location = new System.Drawing.Point(342, 234);
            this.detNgaySinh.Name = "detNgaySinh";
            this.detNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.detNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.detNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detNgaySinh.Properties.MaskSettings.Set("mask", "d");
            this.detNgaySinh.Properties.MaxLength = 30;
            this.detNgaySinh.Properties.MaxValue = new System.DateTime(2022, 7, 11, 0, 0, 0, 0);
            this.detNgaySinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.detNgaySinh.Size = new System.Drawing.Size(259, 28);
            this.detNgaySinh.TabIndex = 9;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "xtraOpenFileDialog1";
            // 
            // frmNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 592);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmNhanVien.IconOptions.LargeImage")));
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit picAnhNV;
        private DevExpress.XtraEditors.ComboBoxEdit cboGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHoTenLot;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboChucVu;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gctNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnThemAnhNV;
        private DevExpress.XtraEditors.SimpleButton btnSuaNV;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaNV;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenLot;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCD;
        private DevExpress.XtraGrid.Columns.GridColumn colAnhNV;
        private DevExpress.XtraEditors.TextEdit txtCCCD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofdFile;
        private DevExpress.XtraEditors.DateEdit detNgaySinh;

    }
}