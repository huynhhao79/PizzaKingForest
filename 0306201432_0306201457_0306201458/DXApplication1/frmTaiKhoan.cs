using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace DXApplication1
{
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
        DangNhapBUS dangnhapBUS = new DangNhapBUS();
        HardCode cod = new HardCode();
        string str1, str2;
        public string strMANV
        {
            get { return str1; }
            set { str1 = value; }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            gctTK.DataSource = taikhoanBUS.LayDSTK();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmThemNhanVien ThemNhanVien = new frmThemNhanVien();
            ThemNhanVien.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void gctTK_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNV.Enabled = false;
            txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
            txtTenTK.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TK").ToString();
            cboQuyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quyen").ToString();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn tài khoản cần sửa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (str1 == txtMaNV.Text)
            {
                MessageBox.Show(cod.TK_Exit, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiKhoanDTO TK = new TaiKhoanDTO()
            {
                MaNV=txtMaNV.Text,
                TK = txtTenTK.Text,
                Quyen = cboQuyen.Text,
            };
            if (taikhoanBUS.SuaTK(TK))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gctTK.DataSource = null;
                gctTK.DataSource = taikhoanBUS.LayDSTK();
                return;
            }
            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }        
        }

        private void btnLamMoiTK_Click(object sender, EventArgs e)
        {
            gctTK.DataSource = null;
            gctTK.DataSource = taikhoanBUS.LayDSTK();
            txtMaNV.Text = string.Empty;
            txtTenTK.Text = string.Empty;
            cboQuyen.ResetText();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn tài khoản cần xóa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiKhoanDTO TK = new TaiKhoanDTO()
            {
                MaNV = txtMaNV.Text,
            };
            if (str1 == txtMaNV.Text)
            {
                MessageBox.Show(cod.TK_Exit, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa tài khoản {0}?", txtTenTK.Text), cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
            if (taikhoanBUS.XoaTK(TK))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiTK_Click(sender, e);
                return;
            }
            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
        }
    }
}