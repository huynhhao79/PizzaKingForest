using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        KingForestEntities kftkEntities = new KingForestEntities();
        public List<TaiKhoanDTO> LayDSTK()
        {
            return kftkEntities.TAIKHOANs.Where(u => u.TrangThai == 1).Select(u => new TaiKhoanDTO { MaNV=u.MaNV, TK = u.TK, Quyen = u.Quyen }).ToList();
        }
        public bool ThemTK(TaiKhoanDTO themTK)
        {
            try
            {
                TAIKHOAN addtk = new TAIKHOAN
                {
                    MaNV = themTK.MaNV,
                    TK = themTK.TK,
                    MK = themTK.MK,
                    Quyen = themTK.Quyen,
                    TrangThai = 1
                };
                kftkEntities.TAIKHOANs.Add(addtk);
                kftkEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaTK(TaiKhoanDTO TK)
        {
            TAIKHOAN suaTK = kftkEntities.TAIKHOANs.SingleOrDefault(u => u.MaNV == TK.MaNV && u.TrangThai == 1);
            NHANVIEN suaTK2 = kftkEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == TK.MaNV && u.TrangThai == 1);
            if (suaTK == null)
            {
                return false;
            }
            else
            {
                suaTK.TK = TK.TK;
                suaTK.Quyen = TK.Quyen;
                suaTK2.ChucVu = TK.Quyen;
                kftkEntities.SaveChanges();
                return true;
            }            
        }
        public bool XoaTK(TaiKhoanDTO TK)
        {
            TAIKHOAN XoaTK = kftkEntities.TAIKHOANs.SingleOrDefault(u => u.MaNV == TK.MaNV && u.TrangThai == 1);
            NHANVIEN XoaTK2 = kftkEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == TK.MaNV && u.TrangThai == 1);
            if (XoaTK == null || XoaTK2 == null)
            {
                return false;
            }
            else
            {
                XoaTK.TrangThai = 0;
                XoaTK2.TrangThai = 0;
                kftkEntities.SaveChanges();
                return true;
            }                      
        }
    }
}
