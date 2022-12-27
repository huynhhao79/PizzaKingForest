namespace DXApplication1
{
    partial class frmLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSP));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLSP = new DevExpress.XtraEditors.TextEdit();
            this.btnThoatLSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaLSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoiLSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.gctLSP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTLSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLSP = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(204, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 19);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Tên loại sản phẩm";
            // 
            // txtTenLSP
            // 
            this.txtTenLSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLSP.Location = new System.Drawing.Point(365, 146);
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenLSP.Size = new System.Drawing.Size(259, 30);
            this.txtTenLSP.TabIndex = 1;
            // 
            // btnThoatLSP
            // 
            this.btnThoatLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatLSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLSP.Appearance.Options.UseFont = true;
            this.btnThoatLSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatLSP.ImageOptions.Image")));
            this.btnThoatLSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoatLSP.Location = new System.Drawing.Point(697, 56);
            this.btnThoatLSP.Name = "btnThoatLSP";
            this.btnThoatLSP.Size = new System.Drawing.Size(94, 40);
            this.btnThoatLSP.TabIndex = 6;
            this.btnThoatLSP.Text = "btnThoatLSP";
            this.btnThoatLSP.ToolTip = "Thoát";
            this.btnThoatLSP.Click += new System.EventHandler(this.btnThoatLSP_Click);
            // 
            // btnXoaLSP
            // 
            this.btnXoaLSP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoaLSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLSP.Appearance.Options.UseFont = true;
            this.btnXoaLSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoaLSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaLSP.ImageOptions.SvgImage")));
            this.btnXoaLSP.Location = new System.Drawing.Point(374, 56);
            this.btnXoaLSP.Name = "btnXoaLSP";
            this.btnXoaLSP.Size = new System.Drawing.Size(94, 40);
            this.btnXoaLSP.TabIndex = 4;
            this.btnXoaLSP.ToolTip = "Xóa loại sản phẩm";
            this.btnXoaLSP.Click += new System.EventHandler(this.btnXoaLSP_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemLSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLSP.Appearance.Options.UseFont = true;
            this.btnThemLSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThemLSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemLSP.ImageOptions.SvgImage")));
            this.btnThemLSP.Location = new System.Drawing.Point(48, 56);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemLSP.Size = new System.Drawing.Size(94, 40);
            this.btnThemLSP.TabIndex = 2;
            this.btnThemLSP.ToolTip = "Thêm loại sản phẩm";
            this.btnThemLSP.Click += new System.EventHandler(this.btnThemLSP_Click);
            // 
            // btnLamMoiLSP
            // 
            this.btnLamMoiLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiLSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiLSP.Appearance.Options.UseFont = true;
            this.btnLamMoiLSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLamMoiLSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoiLSP.ImageOptions.SvgImage")));
            this.btnLamMoiLSP.Location = new System.Drawing.Point(462, 56);
            this.btnLamMoiLSP.Name = "btnLamMoiLSP";
            this.btnLamMoiLSP.Size = new System.Drawing.Size(94, 40);
            this.btnLamMoiLSP.TabIndex = 5;
            this.btnLamMoiLSP.ToolTip = "Làm rổng trường nhập liệu";
            this.btnLamMoiLSP.Click += new System.EventHandler(this.btnLamMoiLSP_Click);
            // 
            // btnSuaLoaiSP
            // 
            this.btnSuaLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaLoaiSP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiSP.Appearance.Options.UseFont = true;
            this.btnSuaLoaiSP.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSuaLoaiSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaLoaiSP.ImageOptions.SvgImage")));
            this.btnSuaLoaiSP.Location = new System.Drawing.Point(290, 56);
            this.btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            this.btnSuaLoaiSP.Size = new System.Drawing.Size(94, 40);
            this.btnSuaLoaiSP.TabIndex = 3;
            this.btnSuaLoaiSP.ToolTip = "Sửa thông tin loại sản phẩm";
            this.btnSuaLoaiSP.Click += new System.EventHandler(this.btnSuaLoaiSP_Click);
            // 
            // gctLSP
            // 
            this.gctLSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctLSP.Location = new System.Drawing.Point(0, 182);
            this.gctLSP.LookAndFeel.SkinName = "Office 2007 Pink";
            this.gctLSP.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gctLSP.MainView = this.gridView1;
            this.gctLSP.Name = "gctLSP";
            this.gctLSP.Size = new System.Drawing.Size(835, 330);
            this.gctLSP.TabIndex = 7;
            this.gctLSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gctLSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gctLSP_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTLSP,
            this.colMaLSP});
            this.gridView1.GridControl = this.gctLSP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTLSP
            // 
            this.colTLSP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTLSP.AppearanceCell.Options.UseFont = true;
            this.colTLSP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTLSP.AppearanceHeader.Options.UseFont = true;
            this.colTLSP.Caption = "Loại sản phẩm";
            this.colTLSP.FieldName = "TenLoaiSP";
            this.colTLSP.Name = "colTLSP";
            this.colTLSP.Visible = true;
            this.colTLSP.VisibleIndex = 1;
            // 
            // colMaLSP
            // 
            this.colMaLSP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLSP.AppearanceCell.Options.UseFont = true;
            this.colMaLSP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaLSP.AppearanceHeader.Options.UseFont = true;
            this.colMaLSP.Caption = "Mã loại sản phẩm";
            this.colMaLSP.FieldName = "MaLoaiSP";
            this.colMaLSP.Name = "colMaLSP";
            this.colMaLSP.Visible = true;
            this.colMaLSP.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(204, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "Mã loại sản phẩm";
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaLSP.Location = new System.Drawing.Point(365, 82);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaLSP.Size = new System.Drawing.Size(259, 30);
            this.txtMaLSP.TabIndex = 0;
            // 
            // frmLoaiSP
            // 
            this.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gctLSP);
            this.Controls.Add(this.btnSuaLoaiSP);
            this.Controls.Add(this.btnThoatLSP);
            this.Controls.Add(this.btnXoaLSP);
            this.Controls.Add(this.btnThemLSP);
            this.Controls.Add(this.btnLamMoiLSP);
            this.Controls.Add(this.txtTenLSP);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMaLSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLoaiSP.IconOptions.Image")));
            this.Name = "frmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLSP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenLSP;
        private DevExpress.XtraEditors.SimpleButton btnThoatLSP;
        private DevExpress.XtraEditors.SimpleButton btnXoaLSP;
        private DevExpress.XtraEditors.SimpleButton btnThemLSP;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiLSP;
        private DevExpress.XtraEditors.SimpleButton btnSuaLoaiSP;
        private DevExpress.XtraGrid.GridControl gctLSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTLSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaLSP;

    }
}