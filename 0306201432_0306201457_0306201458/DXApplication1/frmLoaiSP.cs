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
    public partial class frmLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        LoaiSanPhamBUS loaisanphamBUS = new LoaiSanPhamBUS();
        SanPhamBUS sanphamBUS = new SanPhamBUS();
        HardCode cons = new HardCode();
        string str, str2;

        public string strMANV
        {
            get { return str; }
            set { str = value; }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            if (str2 !=cons.PER)
            {
                btnXoaLSP.Enabled = btnThemLSP.Enabled = btnSuaLoaiSP.Enabled = false;
            }
            gctLSP.DataSource = loaisanphamBUS.LayDSLoaiSP();
            txtMaLSP.Enabled = false;
            txtMaLSP.Text = string.Format("LSP{0}", (loaisanphamBUS.DemDSLSP().Count + 1).ToString("00"));
        }

        private void btnThoatLSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            if (txtTenLSP.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!loaisanphamBUS.TrungTen(txtTenLSP.Text))
            {
                MessageBox.Show("Tên loại sản phẩm bị trùng! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiSanPhamDTO lsp = new LoaiSanPhamDTO()
            {
                MaLoaiSP = txtMaLSP.Text,
                TenLoaiSP = txtTenLSP.Text
            };
            if (loaisanphamBUS.Them(lsp))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiLSP_Click(sender, e);
                gctLSP.DataSource = null;
                gctLSP.DataSource = loaisanphamBUS.LayDSLoaiSP();
                return;
            }
            else
            {
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            if (txtTenLSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!loaisanphamBUS.TrungTen(txtTenLSP.Text))
            {
                MessageBox.Show("Tên loại sản phẩm bị trùng! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiSanPhamDTO lsp = new LoaiSanPhamDTO()
            {
                MaLoaiSP = txtMaLSP.Text,
                TenLoaiSP = txtTenLSP.Text
            };
            if (loaisanphamBUS.sua(lsp))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gctLSP.DataSource = null;
                gctLSP.DataSource = loaisanphamBUS.LayDSLoaiSP();
                return;
            }
            else
            {
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            if (txtTenLSP.Text.Trim().Length == 0)
            {
                MessageBox.Show(cons.INFO, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoaiSanPhamDTO lsp = new LoaiSanPhamDTO()
            {
                MaLoaiSP = txtMaLSP.Text
            };
            if (sanphamBUS.KtraLSP(txtMaLSP.Text).Count > 0) 
            {
                MessageBox.Show("Loại sản phẩm đang được sử dụng", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa loại sản phẩm {0}?", txtMaLSP.Text), cons.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;

            if (loaisanphamBUS.Xoa(lsp))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiLSP_Click(sender, e);
                gctLSP.DataSource = null;
                gctLSP.DataSource = loaisanphamBUS.LayDSLoaiSP();
                return;
            }
            else
            {
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoiLSP_Click(object sender, EventArgs e)
        {
            txtMaLSP.Text = string.Empty;
            txtTenLSP.Text = string.Empty;
            txtMaLSP.Text = string.Format("LSP{0}", (loaisanphamBUS.DemDSLSP().Count + 1).ToString("00"));
        }

        private void gctLSP_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaLSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLoaiSP").ToString();
            txtTenLSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenLoaiSP").ToString();
        }

       

       
    }
}