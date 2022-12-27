using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace DXApplication1
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {    
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.KeyPreview = true;
        }
        private HardCode cons = new HardCode();

        private DangNhapBUS DNBUS = new DangNhapBUS();

        private List<TaiKhoanDTO> lst = new List<TaiKhoanDTO>();

        frmTrangChu trangChu = new frmTrangChu();

        NhanVienBUS nhanvienBUS = new NhanVienBUS();
     
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show(cons.Mes_Null, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiKhoanDTO TK = new TaiKhoanDTO
            {
                TK = txtTaiKhoan.Text,
                MK = txtMatKhau.Text,
                TrangThai = cons.IsExit
            };
            lst = DNBUS.KtraDangNhap(TK);
            if (lst.Count() == 0)
            {
                MessageBox.Show(cons.MesFail_Login, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<NhanVienDTO> NVDTO = new List<NhanVienDTO>();
                List<TaiKhoanDTO> TKDTO = new List<TaiKhoanDTO>();
               
                TKDTO = DNBUS.KtraQuyen(txtTaiKhoan.Text, txtMatKhau.Text);
                trangChu.strQuyen = TKDTO[0].Quyen.ToString();
                trangChu.strMANV = TKDTO[0].MaNV.ToString();
                NVDTO = nhanvienBUS.LayTenNV(TKDTO[0].MaNV.ToString());
                MessageBox.Show(string.Format(cons.Wellcome,NVDTO[0].HoTenLotNV,NVDTO[0].TenNV), cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                trangChu.ShowDialog(); 
               
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.Properties.PasswordChar = '\0'; 
            txtMatKhau.Properties.UseSystemPasswordChar = false;
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void frmDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    btnDangNhap_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btnThoat_Click(null, null);
                }
        }

       
    }
}