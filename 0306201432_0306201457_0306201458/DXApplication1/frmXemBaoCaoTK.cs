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
using Microsoft.Reporting.WinForms;
namespace DXApplication1
{
    public partial class frmXemBaoCaoTK : Form
    {
        public frmXemBaoCaoTK()
        {
            InitializeComponent();
        }
        HoaDonBUS HDBUS = new HoaDonBUS();
        CTHoaDonBUS CTHD = new CTHoaDonBUS();
        NhanVienBUS NVBUS = new NhanVienBUS();
        HoaDonDTO HDDTO = new HoaDonDTO();
        public void TatCaHD()
        {
            List<HoaDonDTO> lstHD = HDBUS.LayDSHD();

            List<NhanVienDTO> lstNV = NVBUS.LayTenNV_HD();

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptTatCa.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsNV", lstNV));
            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHD", lstHD));

            this.rpvBaoCao.RefreshReport();
        }
        public void HDTheoNV(NhanVienDTO NV)
        {
            List<HoaDonDTO> lstHD = HDBUS.LayDSHD_NV(NV);

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptHD_NV.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHD", lstHD));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paTenNV"), NV.HoTenLotNV + " " + NV.TenNV));

            this.rpvBaoCao.RefreshReport();
        }

        public void HDTheoNgay(DateTime ngaylap)
        {
            List<HoaDonDTO> lstHD = HDBUS.LayDSHD_Ngay(ngaylap);

            List<NhanVienDTO> lstNV = NVBUS.LayTenNV_Ngay(ngaylap);

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptTheoNgay.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHD", lstHD));

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsNV", lstNV));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paNgayLap"), ngaylap.ToString()));

            this.rpvBaoCao.RefreshReport();
        }
        public void HDTheoSP(SanPhamDTO SP)
        {
            List<HoaDonDTO> lstHD = HDBUS.LayDSHD_SP(SP);

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptSanPham.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHD", lstHD));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paTenSP"), SP.TenSP));

            this.rpvBaoCao.RefreshReport();
        }
        public void HDTheoLSP(LoaiSanPhamDTO LSP)
        {
            List<HoaDonDTO> lstHD = HDBUS.LayDSHD_LSP(LSP);

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptLoaiSP.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsHD", lstHD));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paTenLSP"), LSP.TenLoaiSP));

            this.rpvBaoCao.RefreshReport();
        }
        public void InHD(string MAHD)
        {
            List<CTHoaDonDTO> lstCTHD = CTHD.LayDSCTHD_HD(MAHD);

            List<HoaDonDTO> HD = HDBUS.LayDSHD_MAHD(MAHD);

            List<NhanVienDTO> NV = NVBUS.LayTenNV(HD[0].MaNV);

            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DXApplication1.rptInHD.rdlc";

            this.rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("dsCTHD", lstCTHD));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paMaHD"), HD[0].MaHD));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paNV"), NV[0].HoTenLotNV +" "+ NV[0].TenNV));

            this.rpvBaoCao.LocalReport.SetParameters(new ReportParameter(("paNgayLap"), HD[0].NgayLapHD.ToString()));

            this.rpvBaoCao.RefreshReport();
        }
        
    }
}
