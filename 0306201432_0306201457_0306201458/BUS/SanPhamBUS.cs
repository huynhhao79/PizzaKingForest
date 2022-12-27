using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanphamDAO = new SanPhamDAO();
        public List<SanPhamDTO> LayDSSP()
        {
            return sanphamDAO.LayDSSP();
        }
        public List<SanPhamDTO> DemDSSP()
        {
            return sanphamDAO.DemDSSP();
        }
        public List<SanPhamDTO> LayDSTenSP(string maloaisp)
        {
            return sanphamDAO.LayDSTenSP(maloaisp);
        }
        public List<SanPhamDTO> LayAnhSP(string masp)
        {
            return sanphamDAO.LayAnhSP(masp);
        }
        public List<SanPhamDTO> LayDSMaSP(string TenSP)
        {
            return sanphamDAO.LayDSMaSP(TenSP);
        }
        public List<SanPhamDTO> KtraLSP(string malsp)
        {
            return sanphamDAO.KtraLSP(malsp);
        }
        public bool ThemSP(SanPhamDTO themSP)
        {
            return sanphamDAO.ThemSP(themSP);
        }
        public bool SuaSP(SanPhamDTO SP)
        {
            return sanphamDAO.SuaSP(SP);
        }
        public bool XoaSP(SanPhamDTO SP)
        {
            return sanphamDAO.XoaSP(SP);
        }
    }
}
