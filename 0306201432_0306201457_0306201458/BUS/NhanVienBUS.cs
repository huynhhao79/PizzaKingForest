using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanvienDAO = new NhanVienDAO();
        public List<NhanVienDTO> LayDSNV()
        {
            return nhanvienDAO.LayDSNV();
        }
        public List<NhanVienDTO> LayTenNV(string MANV)
        {
            return nhanvienDAO.LayDSNV().Where(u => u.MaNV == MANV).ToList();
        }
        public bool ThemNV(NhanVienDTO themNV)
        {
            return nhanvienDAO.ThemNV(themNV);
        }
        public List<NhanVienDTO> DemDSNV()
        {
            return nhanvienDAO.DemDSNV();
        }
        public bool SuaNV(NhanVienDTO NV)
        {
            return nhanvienDAO.SuaNV(NV);
        }
        public bool XoaNV(NhanVienDTO NV)
        {
            return nhanvienDAO.XoaNV(NV);
        }
        public List<NhanVienDTO>LayTenNV_Ngay(DateTime Ngay)
        {
            return nhanvienDAO.LayTenNV_Ngay(Ngay);
        }
        public List<NhanVienDTO> LayTenNV_HD()
        {
            return nhanvienDAO.LayTenNV_HD();
        }

    }
}
