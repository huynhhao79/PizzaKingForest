using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DXApplication1
{
    public partial class frmDonHang : DevExpress.XtraEditors.XtraForm
    {
        frmHoaDon frmHD = new frmHoaDon();
        LoaiSanPhamBUS loaisanphamBUS = new LoaiSanPhamBUS();
        SanPhamBUS sanphamBUS = new SanPhamBUS();
        KhuyenMaiBUS khuyemmaiBUS = new KhuyenMaiBUS();
        HoaDonBUS hoadonBUS = new HoaDonBUS();
        DangNhapBUS dangnhapBUS = new DangNhapBUS();
        CTHoaDonBUS cthoadonBUS = new CTHoaDonBUS();
        HardCode cod = new HardCode();
        decimal debanh, kichco,  khuyenmai,tongtienall;
        int soluong,j;
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
        public frmDonHang()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            lueLoaiSP.Properties.DataSource = loaisanphamBUS.LayDSLoaiSP();
            lueLoaiSP.Properties.DisplayMember = cod.LSPDISPLAY;
            lueLoaiSP.Properties.ValueMember = cod.LSPVALUE;
            lueLoaiSP.Properties.PopulateColumns();
            lueLoaiSP.Properties.Columns[0].Visible = false;
            lueLoaiSP.Properties.Columns[2].Visible = false;
            lueLoaiSP.Properties.Columns[1].Caption = "Loại sản phẩm";

            lueMaKM.Properties.DataSource = khuyemmaiBUS.LayDSKM_DH();
            lueMaKM.Properties.DisplayMember = cod.KMDISPLAY;
            lueMaKM.Properties.ValueMember = cod.KMVALUE;
            lueMaKM.Properties.PopulateColumns();
            lueMaKM.Properties.Columns[1].Visible = false;
            lueMaKM.Properties.Columns[2].Visible = false;
            lueMaKM.Properties.Columns[3].Visible = false;
            lueMaKM.Properties.Columns[5].Visible = false;
            lueMaKM.Properties.Columns[0].Caption = "Mã khuyến mãi";
            lueMaKM.Properties.Columns[4].Caption = "Giá giảm";

            dgvTTDH.ClearSelection();
        }

        private void lueLoaiSP_EditValueChanged(object sender, EventArgs e)
        {
            if (lueLoaiSP.Text != string.Empty)
            {
                lueTenSP.Properties.DataSource = sanphamBUS.LayDSTenSP(lueLoaiSP.EditValue.ToString());
                lueTenSP.Properties.DisplayMember = cod.SPDISPLAY;
                lueTenSP.Properties.ValueMember = cod.SPVALUE;
                lueTenSP.Properties.PopulateColumns();
                lueTenSP.Properties.Columns[0].Visible = false;
                lueTenSP.Properties.Columns[2].Visible = false;
                lueTenSP.Properties.Columns[3].Visible = false;
                lueTenSP.Properties.Columns[4].Visible = false;
                lueTenSP.Properties.Columns[5].Visible = false;
                lueTenSP.Properties.Columns[6].Visible = false;
                lueTenSP.Properties.Columns[7].Visible = false;
                lueTenSP.Properties.Columns[8].Visible = false;
                lueTenSP.Properties.Columns[1].Caption = "Tên sản phẩm";

            }
            else return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (lueLoaiSP.Text.Trim().Length == 0 || lueTenSP.Text.Trim().Length == 0 || cboDeBanh.Text.Trim().Length == 0 || cboKichCo.Text.Trim().Length == 0)
            {
                MessageBox.Show(cod.INFO,cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(spiSoLuong.Text) == 0)
            {
                MessageBox.Show(cod.CANTITATE, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                tongtienall = ((debanh + kichco + Convert.ToDecimal(txtDonGia.Text)) * soluong) - khuyenmai;
                dgvTTDH.AutoGenerateColumns = false;
                LoadDataGridview();
                btnLamMoi_Click(sender, e);
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception f)
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void lueTenSP_EditValueChanged(object sender, EventArgs e)
        {
            if (lueTenSP.Text != string.Empty)
            {
                List<SanPhamDTO> str = sanphamBUS.LayAnhSP(lueTenSP.EditValue.ToString());
                picSP.Image = Image.FromFile(string.Format("{0}", str[0].AnhSP.ToString()));

                txtDonGia.DataBindings.Clear();
                txtDonGia.DataBindings.Add("Text", lueTenSP.Properties.DataSource, "DonGia");
            }
            else
                return;
        }

        private void lueMaKM_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMaKM.Text != string.Empty)
            {
                khuyenmai = Convert.ToDecimal(lueMaKM.EditValue.ToString());
            }
            else
            {
                khuyenmai = 0;
            }
        }

        private void spiSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (spiSoLuong.Text != string.Empty && int.Parse(spiSoLuong.Text) > 0)
            {
                 soluong =int.Parse(spiSoLuong.Text);
            }
            else
                return;
        }
        void LoadDataGridview()
        {
            dgvTTDH.Rows.Add(lueTenSP.Text, lueLoaiSP.Text, cboDeBanh.Text, cboKichCo.Text, spiSoLuong.Text, txtDonGia.Text, lueMaKM.Text, tongtienall, sanphamBUS.LayAnhSP(lueTenSP.EditValue.ToString())[0].AnhSP.ToString());
        }

        private void dgvTTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
                return;
            if (e.RowIndex >= -1 && (e.RowIndex < dgvTTDH.Rows.Count) && e.RowIndex != -1)
            {
                lueTenSP.Text = dgvTTDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                lueLoaiSP.Text = dgvTTDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboDeBanh.Text = dgvTTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboKichCo.Text = dgvTTDH.Rows[e.RowIndex].Cells[3].Value.ToString();
                spiSoLuong.Text = dgvTTDH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDonGia.Text = dgvTTDH.Rows[e.RowIndex].Cells[5].Value.ToString();
                lueMaKM.Text = dgvTTDH.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDonGiaSauKM.Text = dgvTTDH.Rows[e.RowIndex].Cells[7].Value.ToString();
                picSP.Image = Image.FromFile(dgvTTDH.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvTTDH.SelectedRows.Count<=0)
                {
                    MessageBox.Show("Bạn chưa chọn thông tin đơn hàng !", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa đơn hàng?", cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No) return;
                foreach (DataGridViewRow item in this.dgvTTDH.SelectedRows)
                {
                    dgvTTDH.Rows.RemoveAt(item.Index);
                }

               
                btnLamMoi_Click(sender, e);
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            catch (Exception g)
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lueLoaiSP.Text = string.Empty;
            lueTenSP.Text = string.Empty;
            cboDeBanh.Text = string.Empty;
            cboKichCo.Text = string.Empty;
            lueMaKM.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtDonGiaSauKM.Text = string.Empty;
            picSP.Image = null;
            spiSoLuong.EditValue = "0";
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int selectedRow = 0;
            selectedRow = dgvTTDH.CurrentRow.Index;
            if (selectedRow < 0)
            {
                MessageBox.Show(cod.NON_PR, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                tongtienall = ((debanh + kichco + Convert.ToDecimal(txtDonGia.Text)) * soluong) - khuyenmai;

                dgvTTDH.AutoGenerateColumns = false;
                dgvTTDH.Rows[selectedRow].SetValues(lueTenSP.Text, lueLoaiSP.Text, cboDeBanh.Text, cboKichCo.Text, spiSoLuong.Text, txtDonGia.Text, lueMaKM.Text, tongtienall);
                btnLamMoi_Click(sender, e);
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception exit)
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            decimal tongtien = 0, tong = 0;
            
                for(int i = 0 ; i < dgvTTDH.RowCount ; i++)
                {
                    tong = Convert.ToDecimal(dgvTTDH.Rows[i].Cells[7].Value.ToString());
                    tongtien = tongtien + tong;
                }
                tongtien = tongtien + tongtien * Convert.ToDecimal(0.07);

                DialogResult dlr = MessageBox.Show("Bạn muốn thêm hóa đơn này?", cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No) return;

            HoaDonDTO addhd = new HoaDonDTO()
            {
                MaHD = string.Format("HD{0}", (hoadonBUS.DemDSHD().Count + 1).ToString("000")),
                MaNV = str1,
                NgayLapHD = DateTime.Now.Date,
                Tong = Convert.ToDecimal(tongtien.ToString())
            };
            if (hoadonBUS.ThemHD(addhd))
            {
                MessageBox.Show(string.Format(cod.ADD_HD_SUC, (hoadonBUS.DemDSHD().Count).ToString("000")), cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show(cod.ADD_HD_FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            for (j = 0; j < dgvTTDH.Rows.Count; j++)
            {
                CTHoaDonDTO addCTHD = new CTHoaDonDTO()
                {
                    MaHD = addhd.MaHD,
                    MaSP = Convert.ToString(sanphamBUS.LayDSMaSP(dgvTTDH.Rows[j].Cells[0].Value.ToString())[0].MaSP.ToString()),
                    TenSP = dgvTTDH.Rows[j].Cells[0].Value.ToString(),
                    SoLuong = int.Parse(dgvTTDH.Rows[j].Cells[4].Value.ToString()),
                    DonGia = Convert.ToDecimal(dgvTTDH.Rows[j].Cells[5].Value.ToString()),
                    Tong = Convert.ToDecimal(dgvTTDH.Rows[j].Cells[7].Value.ToString())
                };
                if (cthoadonBUS.ThemCTHD(addCTHD)) { }
                else
                {
                    MessageBox.Show(cod.ADD_CTHD_FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            }
            dgvTTDH.Rows.Clear();
            frmHD.ShowDialog();
        }

        private void cboDeBanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lueLoaiSP.Text == string.Empty || lueTenSP.Text == string.Empty)
                return;
            else
            {
                if (txtDonGia.Text == string.Empty)
                    return;
                else
                {
                    if (cboDeBanh.SelectedIndex == 0)
                    {
                        debanh = 10000;
                    }
                    if (cboDeBanh.SelectedIndex == 1)
                    {
                        debanh = 20000;
                    }
                    if (cboDeBanh.SelectedIndex == 2)
                    {
                        debanh = 30000;
                    }
                }
            }
            
        }
        private void cboKichCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lueLoaiSP.Text == string.Empty || lueTenSP.Text == string.Empty)
                return;
            else
            {
                if (txtDonGia.Text == string.Empty)
                    return;
                else
                {
                    if (cboKichCo.SelectedIndex == 0)
                    {
                        kichco = 10000;
                    }
                    if (cboKichCo.SelectedIndex == 1)
                    {
                        kichco = 15000;
                    }
                    if (cboKichCo.SelectedIndex == 2)
                    {
                        kichco = 20000;
                    }                  
                }
            }
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

