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
using BUS;
using DTO;
namespace DXApplication1
{
    public partial class frmBaoCaoThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();

            cboNV.DataSource = NVBUS.LayDSNV();
            cboNV.DisplayMember = cod.NVDISPLAY;
            cboNV.ValueMember = cod.NVVALUE;

            cboLSP.DataSource = LSPBUS.LayDSLoaiSP();
            cboLSP.DisplayMember = cod.LSPDISPLAY;
            cboLSP.ValueMember = cod.LSPVALUE;

            cboSP.DataSource = SPBUS.LayDSSP();
            cboSP.ValueMember = cod.SPVALUE;
            cboSP.DisplayMember = cod.SPDISPLAY;
            dtpNgay.Text = DateTime.Now.Date.ToString();

            this.KeyPreview = true;
        }

        private HardCode cod = new HardCode();

        HoaDonBUS HDBUS = new HoaDonBUS();

        NhanVienBUS NVBUS = new NhanVienBUS();

        SanPhamBUS SPBUS = new SanPhamBUS();

        LoaiSanPhamBUS LSPBUS = new LoaiSanPhamBUS();

        private void btnThoatBCTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            gctBCTK.DataSource = HDBUS.LayDSHD();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.TatCaHD();
                frm.ShowDialog();
            }
            if (radNV.Checked)
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.HDTheoNV((NhanVienDTO)cboNV.SelectedItem);
                frm.ShowDialog();
            }
            if (radNgay.Checked)
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.HDTheoNgay(dtpNgay.Value);
                frm.ShowDialog();
            }
            if (radSP.Checked)
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.HDTheoSP((SanPhamDTO)cboSP.SelectedItem);
                frm.ShowDialog();
            }
            if (radLSP.Checked)
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.HDTheoLSP((LoaiSanPhamDTO)cboLSP.SelectedItem);
                frm.ShowDialog();
            }
        }

        private void frmBaoCaoThongKe_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    btnXem_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.E))
                {
                    btnThoatBCTK_Click(null, null);
                }
            }
        }

    }
}