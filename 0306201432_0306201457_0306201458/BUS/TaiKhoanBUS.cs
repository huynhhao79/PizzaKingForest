using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taikhoanDAO = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDSTK()
        {
            return taikhoanDAO.LayDSTK();
        }
        public bool ThemTK(TaiKhoanDTO themTK)
        {
            return taikhoanDAO.ThemTK(themTK);
        }
        public bool SuaTK(TaiKhoanDTO TK)
        {
            return taikhoanDAO.SuaTK(TK);
        }
        public bool XoaTK(TaiKhoanDTO TK)
        {
            return taikhoanDAO.XoaTK(TK);
        }
        public bool TrungTenTK(TaiKhoanDTO tenTK)
        {
            TaiKhoanDTO trungtk = taikhoanDAO.LayDSTK().SingleOrDefault(u => u.TK == tenTK.TK);
            if (trungtk == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
