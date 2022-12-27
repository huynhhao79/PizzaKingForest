namespace DXApplication1
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDonHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLoaiSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhuyenMai = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceBaoCaoThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.dfcTrangChu = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowDrop = true;
            this.accordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.aceDangXuat,
            this.aceThoat,
            this.accordionControlSeparator1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsHamburgerMenu.HighlightRootElements = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.Size = new System.Drawing.Size(250, 567);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDonHang,
            this.aceNhanVien,
            this.aceTaiKhoan,
            this.aceSanPham,
            this.aceLoaiSP,
            this.aceKhuyenMai,
            this.aceHoaDon,
            this.aceBaoCaoThongKe});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Chức năng";
            // 
            // aceDonHang
            // 
            this.aceDonHang.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceDonHang.Appearance.Default.Options.UseFont = true;
            this.aceDonHang.Expanded = true;
            this.aceDonHang.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text)});
            this.aceDonHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDonHang.ImageOptions.Image")));
            this.aceDonHang.Name = "aceDonHang";
            this.aceDonHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDonHang.Text = "Đơn hàng (F1)";
            this.aceDonHang.Click += new System.EventHandler(this.aceDonHang_Click);
            // 
            // aceNhanVien
            // 
            this.aceNhanVien.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceNhanVien.Appearance.Default.Options.UseFont = true;
            this.aceNhanVien.Expanded = true;
            this.aceNhanVien.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.aceNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceNhanVien.ImageOptions.Image")));
            this.aceNhanVien.Name = "aceNhanVien";
            this.aceNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceNhanVien.Text = "Nhân viên (F2)";
            this.aceNhanVien.Click += new System.EventHandler(this.aceNhanVien_Click);
            // 
            // aceTaiKhoan
            // 
            this.aceTaiKhoan.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceTaiKhoan.Appearance.Default.Options.UseFont = true;
            this.aceTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceTaiKhoan.ImageOptions.Image")));
            this.aceTaiKhoan.Name = "aceTaiKhoan";
            this.aceTaiKhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTaiKhoan.Text = "Tài khoản (F3)";
            this.aceTaiKhoan.Click += new System.EventHandler(this.aceTaiKhoan_Click);
            // 
            // aceSanPham
            // 
            this.aceSanPham.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceSanPham.Appearance.Default.Options.UseFont = true;
            this.aceSanPham.ImageOptions.Image = global::DXApplication1.Properties.Resources.Martz90_Circle_Addon2_Pizza;
            this.aceSanPham.Name = "aceSanPham";
            this.aceSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSanPham.Text = "Sản phẩm (F4)";
            this.aceSanPham.Click += new System.EventHandler(this.aceSanPham_Click);
            // 
            // aceLoaiSP
            // 
            this.aceLoaiSP.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceLoaiSP.Appearance.Default.Options.UseFont = true;
            this.aceLoaiSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceLoaiSP.ImageOptions.Image")));
            this.aceLoaiSP.Name = "aceLoaiSP";
            this.aceLoaiSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLoaiSP.Text = "Loại sản phẩm (F5)";
            this.aceLoaiSP.Click += new System.EventHandler(this.aceLoaiSP_Click);
            // 
            // aceKhuyenMai
            // 
            this.aceKhuyenMai.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceKhuyenMai.Appearance.Default.Options.UseFont = true;
            this.aceKhuyenMai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceKhuyenMai.ImageOptions.Image")));
            this.aceKhuyenMai.Name = "aceKhuyenMai";
            this.aceKhuyenMai.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhuyenMai.Text = "Khuyến mãi (F6)";
            this.aceKhuyenMai.Click += new System.EventHandler(this.aceKhuyenMai_Click);
            // 
            // aceHoaDon
            // 
            this.aceHoaDon.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceHoaDon.Appearance.Default.Options.UseFont = true;
            this.aceHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceHoaDon.ImageOptions.Image")));
            this.aceHoaDon.Name = "aceHoaDon";
            this.aceHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHoaDon.Text = "Hóa đơn (F7)";
            this.aceHoaDon.Click += new System.EventHandler(this.aceHoaDon_Click);
            // 
            // aceBaoCaoThongKe
            // 
            this.aceBaoCaoThongKe.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceBaoCaoThongKe.Appearance.Default.Options.UseFont = true;
            this.aceBaoCaoThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceBaoCaoThongKe.ImageOptions.Image")));
            this.aceBaoCaoThongKe.Name = "aceBaoCaoThongKe";
            this.aceBaoCaoThongKe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceBaoCaoThongKe.Text = "Báo cáo-Thống kê (F8)";
            this.aceBaoCaoThongKe.Click += new System.EventHandler(this.aceBaoCaoThongKe_Click);
            // 
            // aceDangXuat
            // 
            this.aceDangXuat.Appearance.Default.BackColor = System.Drawing.Color.Transparent;
            this.aceDangXuat.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceDangXuat.Appearance.Default.Options.UseBackColor = true;
            this.aceDangXuat.Appearance.Default.Options.UseFont = true;
            this.aceDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDangXuat.ImageOptions.Image")));
            this.aceDangXuat.Name = "aceDangXuat";
            this.aceDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDangXuat.Text = "Đăng Xuất (F12)";
            this.aceDangXuat.Click += new System.EventHandler(this.aceDangXuat_Click);
            // 
            // aceThoat
            // 
            this.aceThoat.Appearance.Default.BackColor = System.Drawing.Color.Transparent;
            this.aceThoat.Appearance.Default.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceThoat.Appearance.Default.Options.UseBackColor = true;
            this.aceThoat.Appearance.Default.Options.UseFont = true;
            this.aceThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThoat.ImageOptions.Image")));
            this.aceThoat.Name = "aceThoat";
            this.aceThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThoat.Text = "Thoát (ESC)";
            this.aceThoat.Click += new System.EventHandler(this.aceThoat_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // dfcTrangChu
            // 
            this.dfcTrangChu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.dfcTrangChu.Appearance.Options.UseBackColor = true;
            this.dfcTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dfcTrangChu.BackgroundImage")));
            this.dfcTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dfcTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfcTrangChu.Location = new System.Drawing.Point(0, 0);
            this.dfcTrangChu.Name = "dfcTrangChu";
            this.dfcTrangChu.Size = new System.Drawing.Size(942, 567);
            this.dfcTrangChu.TabIndex = 3;
            this.dfcTrangChu.Visible = false;
            // 
            // frmTrangChu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(942, 567);
            this.ControlBox = false;
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.dfcTrangChu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::DXApplication1.Properties.Resources.Sonya_Swarm_Pizza;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza King Forest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTrangChu_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceBaoCaoThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDonHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThoat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhuyenMai;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLoaiSP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer dfcTrangChu;
    }
}

