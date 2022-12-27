using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTHoaDonDAO
    {
        KingForestEntities qlcthdEntities = new KingForestEntities();
        HardCode cons = new HardCode();
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            return qlcthdEntities.CT_HOADON.Where(u => u.TrangThai == cons.IsExit).
                Select(u => new CTHoaDonDTO { MaHD = u.MaHD, MaSP = u.MaSP, TenSP = u.TenSP, SoLuong = u.SoLuong.Value, 
                    DonGia = u.DonGia.Value, Thue = u.Thue.Value, Tong = u.Tong.Value }).ToList();
        }
        public bool ThemCTHD(CTHoaDonDTO cthd)
        {
            try
            {
                CT_HOADON addcthd = new CT_HOADON
                {
                    MaHD = cthd.MaHD,
                    MaSP =cthd.MaSP,
                    TenSP = cthd.TenSP,
                    SoLuong = cthd.SoLuong,
                    DonGia =cthd.DonGia,
                    Thue = 7,
                    Tong = cthd.Tong,
                    TrangThai = cons.IsExit
                };
                qlcthdEntities.CT_HOADON.Add(addcthd);
                qlcthdEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<CTHoaDonDTO> LayDSCTHD_HD(string MAHD)
        {
            return qlcthdEntities.CT_HOADON.Where(u => u.TrangThai == cons.IsExit && u.MaHD == MAHD).
                Select(u => new CTHoaDonDTO
                {
                    MaHD = u.MaHD,
                    MaSP = u.MaSP,
                    TenSP = u.TenSP,
                    SoLuong = u.SoLuong.Value,
                    DonGia = u.DonGia.Value,
                    Thue = u.Thue.Value,
                    Tong = u.Tong.Value
                }).ToList();
        }
    }
}
