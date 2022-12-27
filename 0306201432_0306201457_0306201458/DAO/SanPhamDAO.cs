using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class SanPhamDAO
    {
        KingForestEntities kfspEntities = new KingForestEntities();
        LoaiSanPhamDAO loaisanphamDAO = new LoaiSanPhamDAO();
        public List<SanPhamDTO> LayDSSP()
        {
            return kfspEntities.SANPHAMs.Where(u => u.TrangThai == 1).Select(u => new SanPhamDTO { MaSP = u.MaSP, TenSP = u.TenSP, MaLoaiSP =u.MaLoaiSP, AnhSP =u.AnhSP, MoTa = u.MoTa, DonGia = u.DonGia.Value}).ToList();
        }
        public List<SanPhamDTO> DemDSSP()
        {
            return kfspEntities.SANPHAMs.Select(u => new SanPhamDTO { MaSP = u.MaSP, TenSP = u.TenSP, MaLoaiSP = u.MaLoaiSP, AnhSP = u.AnhSP, MoTa = u.MoTa, DonGia = u.DonGia.Value }).ToList();
        }
        public List<SanPhamDTO> LayDSTenSP(string maloaisp)
        {
            return kfspEntities.SANPHAMs.Where(u => u.MaLoaiSP == maloaisp && u.TrangThai==1).Select(u => new SanPhamDTO { MaSP = u.MaSP, TenSP = u.TenSP, MaLoaiSP = u.MaLoaiSP, DeBanh = u.DeBanh, KichCo = u.KichCo, MoTa = u.MoTa, DonGia = u.DonGia.Value }).ToList();
        }
        public List<SanPhamDTO> LayAnhSP(string masp)
        {
            return kfspEntities.SANPHAMs.Where(u => u.TrangThai == 1 && u.MaSP == masp).Select(u => new SanPhamDTO { AnhSP = u.AnhSP }).ToList();
        }
        public List<SanPhamDTO> LayDSMaSP(string TenSP)
        {
            return kfspEntities.SANPHAMs.Where(u => u.TenSP == TenSP && u.TrangThai == 1).Select(u => new SanPhamDTO { MaSP = u.MaSP}).ToList();
        }
        public List<SanPhamDTO> KtraLSP(string malsp)
        {
            return kfspEntities.SANPHAMs.Where(u => u.TrangThai == 1 && u.MaLoaiSP == malsp).Select(u => new SanPhamDTO { MaSP = u.MaSP }).ToList();
        }
        public bool ThemSP(SanPhamDTO themSP)
        {
            try
            {
                SANPHAM addsp = new SANPHAM
                {
                    MaSP = themSP.MaSP,
                    TenSP = themSP.TenSP,
                    MaLoaiSP = themSP.MaLoaiSP,
                    DeBanh = null,
                    KichCo = null,
                    MoTa = themSP.MoTa,
                    AnhSP = themSP.AnhSP,
                    DonGia = themSP.DonGia,
                    TrangThai = 1
                };
                kfspEntities.SANPHAMs.Add(addsp);
                kfspEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaSP(SanPhamDTO SP)
        {
            SANPHAM suaSP = kfspEntities.SANPHAMs.SingleOrDefault(u => u.MaSP == SP.MaSP && u.TrangThai == 1);
            if (suaSP == null)
            {
                return false;
            }
            else
            {
                suaSP.TenSP = SP.TenSP;
                suaSP.MaLoaiSP = SP.MaLoaiSP;
                suaSP.MoTa = SP.MoTa;
                suaSP.DonGia = SP.DonGia;
                suaSP.AnhSP = SP.AnhSP;
                kfspEntities.SaveChanges();
                return true;
            }
        }
        public bool XoaSP(SanPhamDTO SP)
        {
            SANPHAM xoaSP = kfspEntities.SANPHAMs.SingleOrDefault(u => u.MaSP == SP.MaSP && u.TrangThai == 1);
            if (xoaSP == null)
            {
                return false;
            }
            else
            {
                xoaSP.TrangThai = 0;
                kfspEntities.SaveChanges();
                return true;
            }
        }
    }
}
