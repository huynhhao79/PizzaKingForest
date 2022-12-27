using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenmaiDAO = new KhuyenMaiDAO();
        public List<KhuyenMaiDTO> LayDSKM()
        {
            return khuyenmaiDAO.LayDSKM().Where(u => u.NgayKT > DateTime.Now ).ToList();
        }
        public List<KhuyenMaiDTO> LayDSKM_DH()
        {
            return khuyenmaiDAO.LayDSKM_DH();
        }
        public bool Them(KhuyenMaiDTO khuyenmai2)
        {
            return khuyenmaiDAO.Them(khuyenmai2);
        }
        public bool sua(KhuyenMaiDTO khuyenmai2)
        {
            return khuyenmaiDAO.sua(khuyenmai2);
        }
        public bool XoaKM(KhuyenMaiDTO khuyenmai2)
        {
            return khuyenmaiDAO.XoaKM(khuyenmai2);
        }
        

        public List<KhuyenMaiDTO> DemDSKM()
        {
            return khuyenmaiDAO.DemDSKM();
        }
    }
}
