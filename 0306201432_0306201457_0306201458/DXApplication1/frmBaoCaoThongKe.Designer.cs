namespace DXApplication1
{
    partial class frmBaoCaoThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoThongKe));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboLSP = new System.Windows.Forms.ComboBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.radLSP = new System.Windows.Forms.RadioButton();
            this.radSP = new System.Windows.Forms.RadioButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.radNV = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatBCTK = new DevExpress.XtraEditors.SimpleButton();
            this.gctBCTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctBCTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Red;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cboLSP);
            this.groupControl1.Controls.Add(this.cboSP);
            this.groupControl1.Controls.Add(this.radLSP);
            this.groupControl1.Controls.Add(this.radSP);
            this.groupControl1.Controls.Add(this.dtpNgay);
            this.groupControl1.Controls.Add(this.radNgay);
            this.groupControl1.Controls.Add(this.cboNV);
            this.groupControl1.Controls.Add(this.radNV);
            this.groupControl1.Controls.Add(this.radTatCa);
            this.groupControl1.Controls.Add(this.btnXem);
            this.groupControl1.Controls.Add(this.btnThoatBCTK);
            this.groupControl1.Location = new System.Drawing.Point(-1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(359, 540);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Báo cáo thống kê";
            // 
            // cboLSP
            // 
            this.cboLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLSP.FormattingEnabled = true;
            this.cboLSP.Location = new System.Drawing.Point(119, 319);
            this.cboLSP.Name = "cboLSP";
            this.cboLSP.Size = new System.Drawing.Size(145, 27);
            this.cboLSP.TabIndex = 8;
            // 
            // cboSP
            // 
            this.cboSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(119, 274);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(145, 27);
            this.cboSP.TabIndex = 6;
            // 
            // radLSP
            // 
            this.radLSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLSP.AutoSize = true;
            this.radLSP.BackColor = System.Drawing.Color.Transparent;
            this.radLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLSP.Location = new System.Drawing.Point(38, 320);
            this.radLSP.Name = "radLSP";
            this.radLSP.Size = new System.Drawing.Size(124, 23);
            this.radLSP.TabIndex = 7;
            this.radLSP.Text = "Loại sản phẩm";
            this.radLSP.UseVisualStyleBackColor = false;
            // 
            // radSP
            // 
            this.radSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSP.AutoSize = true;
            this.radSP.BackColor = System.Drawing.Color.Transparent;
            this.radSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radSP.Location = new System.Drawing.Point(38, 275);
            this.radSP.Name = "radSP";
            this.radSP.Size = new System.Drawing.Size(92, 23);
            this.radSP.TabIndex = 5;
            this.radSP.Text = "Sản phẩm";
            this.radSP.UseVisualStyleBackColor = false;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgay.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(119, 223);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(145, 26);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.Value = new System.DateTime(2022, 7, 25, 0, 0, 0, 0);
            // 
            // radNgay
            // 
            this.radNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radNgay.AutoSize = true;
            this.radNgay.BackColor = System.Drawing.Color.Transparent;
            this.radNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNgay.Location = new System.Drawing.Point(38, 227);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(63, 23);
            this.radNgay.TabIndex = 3;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = false;
            // 
            // cboNV
            // 
            this.cboNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(119, 169);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(145, 27);
            this.cboNV.TabIndex = 2;
            // 
            // radNV
            // 
            this.radNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radNV.AutoSize = true;
            this.radNV.BackColor = System.Drawing.Color.Transparent;
            this.radNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNV.Location = new System.Drawing.Point(38, 173);
            this.radNV.Name = "radNV";
            this.radNV.Size = new System.Drawing.Size(95, 23);
            this.radNV.TabIndex = 1;
            this.radNV.Text = "Nhân viên";
            this.radNV.UseVisualStyleBackColor = false;
            // 
            // radTatCa
            // 
            this.radTatCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTatCa.AutoSize = true;
            this.radTatCa.BackColor = System.Drawing.Color.Transparent;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radTatCa.Location = new System.Drawing.Point(38, 122);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(73, 23);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = false;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXem.ImageOptions.SvgImage")));
            this.btnXem.Location = new System.Drawing.Point(104, 352);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(94, 39);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "simpleButton1";
            this.btnXem.ToolTip = "Xem báo cáo (Ctrl+S)";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoatBCTK
            // 
            this.btnThoatBCTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatBCTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBCTK.Appearance.Options.UseFont = true;
            this.btnThoatBCTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBCTK.ImageOptions.Image")));
            this.btnThoatBCTK.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoatBCTK.Location = new System.Drawing.Point(170, 352);
            this.btnThoatBCTK.Name = "btnThoatBCTK";
            this.btnThoatBCTK.Size = new System.Drawing.Size(94, 39);
            this.btnThoatBCTK.TabIndex = 10;
            this.btnThoatBCTK.ToolTip = "Thoát (Ctrl+E)";
            this.btnThoatBCTK.Click += new System.EventHandler(this.btnThoatBCTK_Click);
            // 
            // gctBCTK
            // 
            this.gctBCTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gctBCTK.Location = new System.Drawing.Point(355, 0);
            this.gctBCTK.LookAndFeel.SkinName = "Office 2007 Pink";
            this.gctBCTK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gctBCTK.MainView = this.gridView1;
            this.gctBCTK.Name = "gctBCTK";
            this.gctBCTK.Size = new System.Drawing.Size(583, 540);
            this.gctBCTK.TabIndex = 1;
            this.gctBCTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5});
            this.gridView1.GridControl = this.gctBCTK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Thông tin hóa đơn";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã hóa đơn";
            this.gridColumn1.FieldName = "MaHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 106;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MaNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 111;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Ngày lập ";
            this.gridColumn3.FieldName = "NgayLapHD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 97;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Tổng";
            this.gridColumn5.FieldName = "Tong";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 84;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.FieldName = "Mã hóa đơn";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.FieldName = "Tên nhân viên";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.FieldName = "Ngày lập";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn9.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.FieldName = "Ghi chú";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.FieldName = "Tổng";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // frmBaoCaoThongKe
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.ControlBox = false;
            this.Controls.Add(this.gctBCTK);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmBaoCaoThongKe.IconOptions.LargeImage")));
            this.Name = "frmBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo - thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmBaoCaoThongKe_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctBCTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnThoatBCTK;
        private DevExpress.XtraGrid.GridControl gctBCTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.ComboBox cboLSP;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.RadioButton radLSP;
        private System.Windows.Forms.RadioButton radSP;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.RadioButton radNV;
        private System.Windows.Forms.RadioButton radTatCa;

    }
}