using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DangNhapBUS
    {
        private DangNhapDAO DNDAO = new DangNhapDAO();
        public List<TaiKhoanDTO> KtraDangNhap(TaiKhoanDTO TKDTO)
        {
            return DNDAO.KtraDangNhap(TKDTO);
        }
        public List<TaiKhoanDTO> KtraQuyen(string str1, string str2)
        {
            return DNDAO.KtraQuyen(str1, str2);
        }
     
    }
}
