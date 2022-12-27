using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoadonDAO = new HoaDonDAO();
        public List<HoaDonDTO> LayDSHD()
        {
            return hoadonDAO.LayDSHD().Where(u=>u.TrangThai == 1).ToList();
        }
        public List<HoaDonDTO> DemDSHD()
        {
            return hoadonDAO.LayDSHD();
        }
        public bool ThemHD(HoaDonDTO hd)
        {
            return hoadonDAO.ThemHD(hd);
        }
        public bool XoaHD(HoaDonDTO xoahd)
        {
            return hoadonDAO.XoaHD(xoahd);
        }
        public List<HoaDonDTO> LayDSHD_NV(NhanVienDTO NV)
        {
            return hoadonDAO.LayDSHD_NV(NV);
        }
        public List<HoaDonDTO> LayDSHD_Ngay(DateTime NgayLap)
        {
            return hoadonDAO.LayDSHD_Ngay(NgayLap);
        }
        public List<HoaDonDTO> LayDSHD_SP(SanPhamDTO SP)
        {
            return hoadonDAO.LayDSHD_SP(SP);
        }
        public List<HoaDonDTO> LayDSHD_LSP(LoaiSanPhamDTO LSP)
        {
            return hoadonDAO.LayDSHD_LSP(LSP);
        }
        public List<HoaDonDTO> LayDSHD_MAHD(string MAHD)
        {
            return hoadonDAO.LayDSHD().Where(u => u.MaHD == MAHD).ToList();
        }
    }
}
