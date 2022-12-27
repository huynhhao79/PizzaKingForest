using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhuyenMaiDAO
    {
        KingForestEntities kfkmEntities = new KingForestEntities();
        public List<KhuyenMaiDTO> LayDSKM()
        {
            return kfkmEntities.KHUYENMAIs.Where(u => u.TrangThai == 1).Select(u => new KhuyenMaiDTO { MaKM = u.MaKM, NgayBD = u.NgayBD.Value, NgayKT = u.NgayKT.Value, SoLuong = u.SoLuong.Value, GiaGiam = u.GiaGiam.Value }).ToList();
        }
        public List<KhuyenMaiDTO> DemDSKM()
        {
            return kfkmEntities.KHUYENMAIs.Select(u => new KhuyenMaiDTO { MaKM = u.MaKM }).ToList();
        }
        public List<KhuyenMaiDTO> LayDSKM_DH()
        {
            return kfkmEntities.KHUYENMAIs.Where(u => u.TrangThai == 1 && u.NgayBD <= DateTime.Now && u.NgayKT > DateTime.Now).Select(u => new KhuyenMaiDTO { MaKM = u.MaKM, NgayBD = u.NgayBD.Value, NgayKT = u.NgayKT.Value, SoLuong = u.SoLuong.Value, GiaGiam = u.GiaGiam.Value }).ToList();
        }
        public bool Them(KhuyenMaiDTO khuyenmai)
        {
            try
            {
                KHUYENMAI khuyenmai1 = new KHUYENMAI
                {
                    MaKM = khuyenmai.MaKM,
                    NgayBD = khuyenmai.NgayBD,
                    NgayKT = khuyenmai.NgayKT,
                    SoLuong = khuyenmai.SoLuong,
                    GiaGiam = khuyenmai.GiaGiam,
                    TrangThai = 1
                };
                kfkmEntities.KHUYENMAIs.Add(khuyenmai1);
                kfkmEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool sua(KhuyenMaiDTO suakm)
        {
            KHUYENMAI suakhuyenmai = kfkmEntities.KHUYENMAIs.SingleOrDefault(u => u.MaKM == suakm.MaKM);
            if (suakhuyenmai == null)
            {
                return false;
            }
            else
            {
                suakhuyenmai.NgayBD = suakm.NgayBD;
                suakhuyenmai.NgayKT = suakm.NgayKT;
                suakhuyenmai.SoLuong = suakm.SoLuong;
                suakhuyenmai.GiaGiam = suakm.GiaGiam;
                kfkmEntities.SaveChanges();
                return true;
            }
             
        }
        public bool XoaKM(KhuyenMaiDTO km)
        {
            KHUYENMAI xoakhuyenmai = kfkmEntities.KHUYENMAIs.SingleOrDefault(u => u.MaKM == km.MaKM);

            if (xoakhuyenmai == null)
            {
                return false;
            }
            xoakhuyenmai.TrangThai = 0;
            kfkmEntities.SaveChanges();
            return true;
        }
      
    }
}
