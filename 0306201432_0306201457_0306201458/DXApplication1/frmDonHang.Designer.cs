namespace DXApplication1
{
    partial class frmDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.picSP = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lueMaKM = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lueTenSP = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDonGiaSauKM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueLoaiSP = new DevExpress.XtraEditors.LookUpEdit();
            this.spiSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cboKichCo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboDeBanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvTTDH = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnhSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaSauKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKichCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDeBanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXacNhan.Location = new System.Drawing.Point(240, 584);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(94, 39);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.ToolTip = "Lập hóa đơn";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(420, 584);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 39);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "btnThoat";
            this.btnThoat.ToolTip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Location = new System.Drawing.Point(267, 608);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 39);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.ToolTip = "Làm trống các trường nhập liệu";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinhSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Appearance.Options.UseFont = true;
            this.btnChinhSua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChinhSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChinhSua.ImageOptions.SvgImage")));
            this.btnChinhSua.Location = new System.Drawing.Point(267, 594);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(94, 40);
            this.btnChinhSua.TabIndex = 10;
            this.btnChinhSua.ToolTip = "Sửa thông tin đơn hàng";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(52, 594);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.Size = new System.Drawing.Size(94, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.ToolTip = "Thêm đơn hàng";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(52, 608);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.ToolTip = "Xóa đơn hàng";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // picSP
            // 
            this.picSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSP.Location = new System.Drawing.Point(103, 41);
            this.picSP.Name = "picSP";
            this.picSP.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picSP.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picSP.Size = new System.Drawing.Size(208, 138);
            this.picSP.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 198);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Loại sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 243);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 19);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Tên sản phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 290);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 19);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Đế bánh";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 332);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 19);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Kích cỡ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(30, 384);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 19);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Số lượng";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.lueMaKM);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.lueTenSP);
            this.groupControl1.Controls.Add(this.txtDonGiaSauKM);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.picSP);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnChinhSua);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.lueLoaiSP);
            this.groupControl1.Controls.Add(this.spiSoLuong);
            this.groupControl1.Controls.Add(this.cboKichCo);
            this.groupControl1.Controls.Add(this.cboDeBanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 659);
            this.groupControl1.TabIndex = 57;
            this.groupControl1.Text = "Thông tin sản phẩm";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lueMaKM
            // 
            this.lueMaKM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lueMaKM.Location = new System.Drawing.Point(168, 477);
            this.lueMaKM.Name = "lueMaKM";
            this.lueMaKM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueMaKM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMaKM.Properties.Appearance.Options.UseFont = true;
            this.lueMaKM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaKM.Properties.NullText = "";
            this.lueMaKM.Properties.PopupSizeable = false;
            this.lueMaKM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMaKM.Size = new System.Drawing.Size(220, 26);
            this.lueMaKM.TabIndex = 7;
            this.lueMaKM.EditValueChanged += new System.EventHandler(this.lueMaKM_EditValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(168, 427);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(220, 26);
            this.txtDonGia.TabIndex = 6;
            // 
            // lueTenSP
            // 
            this.lueTenSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lueTenSP.Location = new System.Drawing.Point(168, 240);
            this.lueTenSP.Name = "lueTenSP";
            this.lueTenSP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueTenSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTenSP.Properties.Appearance.Options.UseFont = true;
            this.lueTenSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenSP.Properties.NullText = "";
            this.lueTenSP.Properties.PopupSizeable = false;
            this.lueTenSP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTenSP.Size = new System.Drawing.Size(220, 26);
            this.lueTenSP.TabIndex = 2;
            this.lueTenSP.EditValueChanged += new System.EventHandler(this.lueTenSP_EditValueChanged);
            // 
            // txtDonGiaSauKM
            // 
            this.txtDonGiaSauKM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDonGiaSauKM.Enabled = false;
            this.txtDonGiaSauKM.Location = new System.Drawing.Point(168, 528);
            this.txtDonGiaSauKM.Name = "txtDonGiaSauKM";
            this.txtDonGiaSauKM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaSauKM.Properties.Appearance.Options.UseFont = true;
            this.txtDonGiaSauKM.Size = new System.Drawing.Size(220, 26);
            this.txtDonGiaSauKM.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(30, 430);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 19);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Đơn giá ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 531);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 19);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Đơn giá tổng";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(30, 480);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 19);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Mã khyến mãi";
            // 
            // lueLoaiSP
            // 
            this.lueLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lueLoaiSP.Location = new System.Drawing.Point(168, 195);
            this.lueLoaiSP.Name = "lueLoaiSP";
            this.lueLoaiSP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lueLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiSP.Properties.NullText = "";
            this.lueLoaiSP.Properties.PopupSizeable = false;
            this.lueLoaiSP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLoaiSP.Size = new System.Drawing.Size(220, 26);
            this.lueLoaiSP.TabIndex = 1;
            this.lueLoaiSP.EditValueChanged += new System.EventHandler(this.lueLoaiSP_EditValueChanged);
            // 
            // spiSoLuong
            // 
            this.spiSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.spiSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiSoLuong.Location = new System.Drawing.Point(168, 381);
            this.spiSoLuong.Name = "spiSoLuong";
            this.spiSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spiSoLuong.Properties.Appearance.Options.UseFont = true;
            this.spiSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiSoLuong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spiSoLuong.Properties.IsFloatValue = false;
            this.spiSoLuong.Properties.MaskSettings.Set("mask", "N00");
            this.spiSoLuong.Properties.MaxValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spiSoLuong.Size = new System.Drawing.Size(220, 26);
            this.spiSoLuong.TabIndex = 5;
            this.spiSoLuong.EditValueChanged += new System.EventHandler(this.spiSoLuong_EditValueChanged);
            // 
            // cboKichCo
            // 
            this.cboKichCo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboKichCo.Location = new System.Drawing.Point(168, 329);
            this.cboKichCo.Name = "cboKichCo";
            this.cboKichCo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboKichCo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKichCo.Properties.Appearance.Options.UseFont = true;
            this.cboKichCo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKichCo.Properties.Items.AddRange(new object[] {
            "S  (10.000)",
            "M  (15.000)",
            "L  (20.000)"});
            this.cboKichCo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboKichCo.Size = new System.Drawing.Size(220, 26);
            this.cboKichCo.TabIndex = 4;
            this.cboKichCo.SelectedIndexChanged += new System.EventHandler(this.cboKichCo_SelectedIndexChanged);
            // 
            // cboDeBanh
            // 
            this.cboDeBanh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboDeBanh.Location = new System.Drawing.Point(168, 287);
            this.cboDeBanh.Name = "cboDeBanh";
            this.cboDeBanh.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboDeBanh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeBanh.Properties.Appearance.Options.UseFont = true;
            this.cboDeBanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDeBanh.Properties.DropDownRows = 3;
            this.cboDeBanh.Properties.Items.AddRange(new object[] {
            "Mỏng  (10.000)",
            "Vừa  (20.000)",
            "Dày  (25.000)"});
            this.cboDeBanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDeBanh.Size = new System.Drawing.Size(220, 26);
            this.cboDeBanh.TabIndex = 3;
            this.cboDeBanh.SelectedIndexChanged += new System.EventHandler(this.cboDeBanh_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.btnThoat);
            this.groupControl2.Controls.Add(this.btnXacNhan);
            this.groupControl2.Controls.Add(this.dgvTTDH);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(420, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(747, 659);
            this.groupControl2.TabIndex = 58;
            this.groupControl2.Text = "Thông tin đơn hàng";
            // 
            // dgvTTDH
            // 
            this.dgvTTDH.AllowUserToAddRows = false;
            this.dgvTTDH.AllowUserToDeleteRows = false;
            this.dgvTTDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTDH.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTTDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colLoaiSP,
            this.colDB,
            this.colKichCo,
            this.colSL,
            this.colDonGia,
            this.colMaKM,
            this.colDonGiaTong,
            this.colAnhSP});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTDH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTTDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTDH.Location = new System.Drawing.Point(2, 27);
            this.dgvTTDH.MultiSelect = false;
            this.dgvTTDH.Name = "dgvTTDH";
            this.dgvTTDH.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTDH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTTDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTDH.Size = new System.Drawing.Size(743, 630);
            this.dgvTTDH.TabIndex = 13;
            this.dgvTTDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTDH_CellClick);
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.HeaderText = "Loại SP";
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.ReadOnly = true;
            // 
            // colDB
            // 
            this.colDB.HeaderText = "Đế bánh";
            this.colDB.Name = "colDB";
            this.colDB.ReadOnly = true;
            // 
            // colKichCo
            // 
            this.colKichCo.HeaderText = "Kích cỡ";
            this.colKichCo.Name = "colKichCo";
            this.colKichCo.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colMaKM
            // 
            this.colMaKM.HeaderText = "Mã KM";
            this.colMaKM.Name = "colMaKM";
            this.colMaKM.ReadOnly = true;
            // 
            // colDonGiaTong
            // 
            this.colDonGiaTong.HeaderText = "Đơn giá tổng";
            this.colDonGiaTong.Name = "colDonGiaTong";
            this.colDonGiaTong.ReadOnly = true;
            // 
            // colAnhSP
            // 
            this.colAnhSP.HeaderText = "AnhSP";
            this.colAnhSP.Name = "colAnhSP";
            this.colAnhSP.ReadOnly = true;
            this.colAnhSP.Visible = false;
            // 
            // frmDonHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 659);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDonHang.IconOptions.LargeImage")));
            this.Name = "frmDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaSauKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKichCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDeBanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnChinhSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.PictureEdit picSP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtDonGiaSauKM;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiSP;
        private DevExpress.XtraEditors.LookUpEdit lueTenSP;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LookUpEdit lueMaKM;
        private System.Windows.Forms.DataGridView dgvTTDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnhSP;
        private DevExpress.XtraEditors.SpinEdit spiSoLuong;
        private DevExpress.XtraEditors.ComboBoxEdit cboKichCo;
        private DevExpress.XtraEditors.ComboBoxEdit cboDeBanh;

    }
}



