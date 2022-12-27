namespace DXApplication1
{
    partial class frmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuyenMai));
            this.txtMaKM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSuaKhuyenMai = new DevExpress.XtraEditors.SimpleButton();
            this.gctKM = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaGiam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKM = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKM = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaGiam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtoNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.dtoNgayKT = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKM
            // 
            this.txtMaKM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaKM.Location = new System.Drawing.Point(179, 118);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.Properties.Appearance.Options.UseFont = true;
            this.txtMaKM.Size = new System.Drawing.Size(241, 28);
            this.txtMaKM.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 19);
            this.labelControl1.TabIndex = 115;
            this.labelControl1.Text = "Mã khuyến mãi";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnSuaKhuyenMai);
            this.groupControl1.Controls.Add(this.gctKM);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnXoaKM);
            this.groupControl1.Controls.Add(this.btnThemKM);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.txtGiaGiam);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMaKM);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtoNgayBD);
            this.groupControl1.Controls.Add(this.dtoNgayKT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1023, 523);
            this.groupControl1.TabIndex = 117;
            this.groupControl1.Text = "Thông tin khuyến mãi";
            // 
            // btnSuaKhuyenMai
            // 
            this.btnSuaKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSuaKhuyenMai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhuyenMai.Appearance.Options.UseFont = true;
            this.btnSuaKhuyenMai.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSuaKhuyenMai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaKhuyenMai.ImageOptions.SvgImage")));
            this.btnSuaKhuyenMai.Location = new System.Drawing.Point(179, 273);
            this.btnSuaKhuyenMai.Name = "btnSuaKhuyenMai";
            this.btnSuaKhuyenMai.Size = new System.Drawing.Size(94, 40);
            this.btnSuaKhuyenMai.TabIndex = 7;
            this.btnSuaKhuyenMai.ToolTip = "Sửa thông tin";
            this.btnSuaKhuyenMai.Click += new System.EventHandler(this.btnSuaKhuyenMai_Click);
            // 
            // gctKM
            // 
            this.gctKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gctKM.Location = new System.Drawing.Point(442, 27);
            this.gctKM.LookAndFeel.SkinName = "Office 2007 Pink";
            this.gctKM.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gctKM.MainView = this.gridView1;
            this.gctKM.Name = "gctKM";
            this.gctKM.Size = new System.Drawing.Size(579, 494);
            this.gctKM.TabIndex = 11;
            this.gctKM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gctKM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gctKM_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKM,
            this.colNgayBD,
            this.colNgayKT,
            this.colSL,
            this.colGiaGiam});
            this.gridView1.GridControl = this.gctKM;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaKM
            // 
            this.colMaKM.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaKM.AppearanceCell.Options.UseFont = true;
            this.colMaKM.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaKM.AppearanceHeader.Options.UseFont = true;
            this.colMaKM.Caption = "Mã khuyến mãi";
            this.colMaKM.FieldName = "MaKM";
            this.colMaKM.Name = "colMaKM";
            this.colMaKM.Visible = true;
            this.colMaKM.VisibleIndex = 0;
            this.colMaKM.Width = 133;
            // 
            // colNgayBD
            // 
            this.colNgayBD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayBD.AppearanceCell.Options.UseFont = true;
            this.colNgayBD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayBD.AppearanceHeader.Options.UseFont = true;
            this.colNgayBD.Caption = "Ngày bắt đầu";
            this.colNgayBD.FieldName = "NgayBD";
            this.colNgayBD.Name = "colNgayBD";
            this.colNgayBD.Visible = true;
            this.colNgayBD.VisibleIndex = 1;
            this.colNgayBD.Width = 95;
            // 
            // colNgayKT
            // 
            this.colNgayKT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayKT.AppearanceCell.Options.UseFont = true;
            this.colNgayKT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayKT.AppearanceHeader.Options.UseFont = true;
            this.colNgayKT.Caption = "Ngày kết thúc";
            this.colNgayKT.FieldName = "NgayKT";
            this.colNgayKT.Name = "colNgayKT";
            this.colNgayKT.Visible = true;
            this.colNgayKT.VisibleIndex = 2;
            this.colNgayKT.Width = 124;
            // 
            // colSL
            // 
            this.colSL.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSL.AppearanceCell.Options.UseFont = true;
            this.colSL.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSL.AppearanceHeader.Options.UseFont = true;
            this.colSL.Caption = "Số lượng";
            this.colSL.FieldName = "SoLuong";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 3;
            this.colSL.Width = 81;
            // 
            // colGiaGiam
            // 
            this.colGiaGiam.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiaGiam.AppearanceCell.Options.UseFont = true;
            this.colGiaGiam.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiaGiam.AppearanceHeader.Options.UseFont = true;
            this.colGiaGiam.Caption = "Giá giảm";
            this.colGiaGiam.FieldName = "GiaGiam";
            this.colGiaGiam.Name = "colGiaGiam";
            this.colGiaGiam.Visible = true;
            this.colGiaGiam.VisibleIndex = 4;
            this.colGiaGiam.Width = 98;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(233, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "simpleButton2";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaKM
            // 
            this.btnXoaKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaKM.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKM.Appearance.Options.UseFont = true;
            this.btnXoaKM.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoaKM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKM.ImageOptions.SvgImage")));
            this.btnXoaKM.Location = new System.Drawing.Point(133, 362);
            this.btnXoaKM.Name = "btnXoaKM";
            this.btnXoaKM.Size = new System.Drawing.Size(94, 39);
            this.btnXoaKM.TabIndex = 9;
            this.btnXoaKM.ToolTip = "Xóa";
            this.btnXoaKM.Click += new System.EventHandler(this.btnXoaKM_Click);
            // 
            // btnThemKM
            // 
            this.btnThemKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemKM.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKM.Appearance.Options.UseFont = true;
            this.btnThemKM.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemKM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKM.ImageOptions.SvgImage")));
            this.btnThemKM.Location = new System.Drawing.Point(57, 273);
            this.btnThemKM.Name = "btnThemKM";
            this.btnThemKM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemKM.Size = new System.Drawing.Size(94, 39);
            this.btnThemKM.TabIndex = 6;
            this.btnThemKM.ToolTip = "Thêm khuyến mãi";
            this.btnThemKM.Click += new System.EventHandler(this.btnThemKM_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Location = new System.Drawing.Point(292, 273);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 39);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.ToolTip = "Làm trống trường nhập liệu";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtGiaGiam
            // 
            this.txtGiaGiam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaGiam.Location = new System.Drawing.Point(179, 346);
            this.txtGiaGiam.Name = "txtGiaGiam";
            this.txtGiaGiam.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGiam.Properties.Appearance.Options.UseFont = true;
            this.txtGiaGiam.Size = new System.Drawing.Size(241, 28);
            this.txtGiaGiam.TabIndex = 4;
            this.txtGiaGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaGiam_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(57, 350);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 19);
            this.labelControl5.TabIndex = 123;
            this.labelControl5.Text = "Giá giảm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(179, 284);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(241, 28);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(57, 288);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 19);
            this.labelControl4.TabIndex = 121;
            this.labelControl4.Text = "Số lượng";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(57, 230);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 19);
            this.labelControl3.TabIndex = 118;
            this.labelControl3.Text = "Ngày kết thúc";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 19);
            this.labelControl2.TabIndex = 117;
            this.labelControl2.Text = "Ngày bắt đầu";
            // 
            // dtoNgayBD
            // 
            this.dtoNgayBD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtoNgayBD.EditValue = null;
            this.dtoNgayBD.Location = new System.Drawing.Point(179, 172);
            this.dtoNgayBD.Name = "dtoNgayBD";
            this.dtoNgayBD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtoNgayBD.Properties.Appearance.Options.UseFont = true;
            this.dtoNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoNgayBD.Properties.DisplayFormat.FormatString = "";
            this.dtoNgayBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoNgayBD.Properties.EditFormat.FormatString = "";
            this.dtoNgayBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoNgayBD.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtoNgayBD.Properties.MaskSettings.Set("mask", "d");
            this.dtoNgayBD.Size = new System.Drawing.Size(241, 28);
            this.dtoNgayBD.TabIndex = 1;
            // 
            // dtoNgayKT
            // 
            this.dtoNgayKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtoNgayKT.EditValue = null;
            this.dtoNgayKT.Location = new System.Drawing.Point(179, 226);
            this.dtoNgayKT.Name = "dtoNgayKT";
            this.dtoNgayKT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtoNgayKT.Properties.Appearance.Options.UseFont = true;
            this.dtoNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoNgayKT.Properties.DisplayFormat.FormatString = "";
            this.dtoNgayKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoNgayKT.Properties.EditFormat.FormatString = "";
            this.dtoNgayKT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoNgayKT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtoNgayKT.Properties.MaskSettings.Set("mask", "d");
            this.dtoNgayKT.Size = new System.Drawing.Size(241, 28);
            this.dtoNgayKT.TabIndex = 2;
            // 
            // frmKhuyenMai
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 523);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmKhuyenMai.IconOptions.Image")));
            this.Name = "frmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khuyến mãi";
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoNgayKT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaKM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtGiaGiam;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gctKM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKM;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKT;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaGiam;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaKM;
        private DevExpress.XtraEditors.SimpleButton btnThemKM;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnSuaKhuyenMai;
        private DevExpress.XtraEditors.DateEdit dtoNgayBD;
        private DevExpress.XtraEditors.DateEdit dtoNgayKT;

    }
}