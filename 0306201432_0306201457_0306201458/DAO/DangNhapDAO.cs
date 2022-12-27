using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DangNhapDAO
    {
        KingForestEntities DangNhapEntity = new KingForestEntities();
        HardCode cons = new HardCode();
        public List<TaiKhoanDTO> KtraDangNhap(TaiKhoanDTO TKDTO)
        {
            return DangNhapEntity.TAIKHOANs.Where(u => u.TrangThai == TKDTO.TrangThai)
                .Where(u => u.MK == TKDTO.MK).Where(u => u.TK == TKDTO.TK)
                .Select(u => new TaiKhoanDTO { TK = u.TK, MK = u.MK }).ToList();
        }
        public List<TaiKhoanDTO> KtraQuyen(string str1, string str2)
        {
            return DangNhapEntity.TAIKHOANs.Where(u => u.TrangThai == 1 && u.TK == str1 && u.MK == str2)
                .Select(u => new TaiKhoanDTO { MaNV = u.MaNV, Quyen = u.Quyen }).ToList();
        }
     
    }
}
