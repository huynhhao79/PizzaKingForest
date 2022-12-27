
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;


namespace DXApplication1
{
    
       
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        string str, str2;
        HardCode cod = new HardCode();
        public string strMANV
        {
            get { return str; }
            set { str = value;  }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }

       
        public frmTrangChu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void aceTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan TaiKhoan = new frmTaiKhoan();
            TaiKhoan.strMANV = str;
            TaiKhoan.strQuyen = str2;
            TaiKhoan.MdiParent = this;
            TaiKhoan.WindowState = FormWindowState.Maximized;
            TaiKhoan.Show();
        }

        private void aceThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
            Application.Exit();
        }

        private void aceNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien NhanVien = new frmNhanVien();
            NhanVien.strMANV = str;
            NhanVien.strQuyen = str2;
            NhanVien.MdiParent = this;
            NhanVien.WindowState = FormWindowState.Maximized;
            NhanVien.Show();
        }

        private void aceDonHang_Click(object sender, EventArgs e)
        {
            frmDonHang DonHang = new frmDonHang();
            DonHang.strMANV = str;
            DonHang.strQuyen = str2;
            DonHang.MdiParent = this;
            DonHang.WindowState = FormWindowState.Maximized;
            DonHang.Show();
        }


        private void aceSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham SanPham = new frmSanPham();
            SanPham.strMANV = str;
            SanPham.strQuyen = str2;
            SanPham.MdiParent = this;
            SanPham.WindowState = FormWindowState.Maximized;
            SanPham.Show();
        }

        private void aceHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon HoaDon = new frmHoaDon();
            HoaDon.strMANV = str;
            HoaDon.strQuyen = str2;
            HoaDon.MdiParent = this;
            HoaDon.WindowState = FormWindowState.Maximized;
            HoaDon.Show();
        }

        private void aceBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BCTK = new frmBaoCaoThongKe();
            BCTK.MdiParent = this;
            BCTK.WindowState = FormWindowState.Maximized;
            BCTK.Show();
        }

        private void aceLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSP LoaiSP = new frmLoaiSP();
            LoaiSP.strMANV = str;
            LoaiSP.strQuyen = str2;
            LoaiSP.MdiParent = this;
            LoaiSP.WindowState = FormWindowState.Maximized;
            LoaiSP.Show();
        }

        private void aceKhuyenMai_Click(object sender, EventArgs e)
        {
            frmKhuyenMai KhuyenMai = new frmKhuyenMai();
            KhuyenMai.strMANV = str;
            KhuyenMai.strQuyen = str2;
            KhuyenMai.MdiParent = this;
            KhuyenMai.WindowState = FormWindowState.Maximized;
            KhuyenMai.Show();
        }

        private void aceDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đăng xuất?", cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
            frmDangNhap DangNhap = new frmDangNhap();
            this.Hide();
            DangNhap.ShowDialog();
            
        }

        public void frmTrangChu_Load(object sender, EventArgs e)
        {

            if (str2 != "Admin")
            {
                aceBaoCaoThongKe.Visible = aceNhanVien.Visible = aceTaiKhoan.Visible = false;
            }
            
        }
        private const int WM_NCLBUTTONDBLCLK = 0x00A3; //Tắt double click title 
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }

        // Phím tắt 
        private void frmTrangChu_KeyUp(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode.Equals(Keys.F1))
            {
                aceDonHang_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F2))
            {
                aceNhanVien_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F3))
            {
                aceTaiKhoan_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F4))
            {
                aceSanPham_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F5))
            {
                aceLoaiSP_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F6))
            {
                aceKhuyenMai_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F7))
            {
                aceHoaDon_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F8))
            {
                aceBaoCaoThongKe_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F12))
            {
                aceDangXuat_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                aceThoat_Click(null, null);
            }

        }
    }
}
