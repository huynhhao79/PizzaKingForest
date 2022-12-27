using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiSanPhamBUS
    {
        private  LoaiSanPhamDAO loaisanphamDAO = new LoaiSanPhamDAO();
        public List<LoaiSanPhamDTO> LayDSLoaiSP()
        {
            return loaisanphamDAO.LayDSLoaiSP();
        }
        public List<LoaiSanPhamDTO> DemDSLSP()
        {
            return loaisanphamDAO.DemDSLSP();
        }
        public bool Them(LoaiSanPhamDTO loaisp)
        {
            return loaisanphamDAO.Them(loaisp);
        }
        public bool sua(LoaiSanPhamDTO sualsp)
        {
            return loaisanphamDAO.sua(sualsp);
        }
        public bool Xoa(LoaiSanPhamDTO xoa)
        {
            return loaisanphamDAO.Xoa(xoa);
        }
        public bool TrungTen(string ten)
        {
            return loaisanphamDAO.TrungTen(ten);
        }
       
    }
}
