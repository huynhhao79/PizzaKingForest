using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class LoaiSanPhamDAO
    {

        string _con = @"Data Source=DESKTOP-1IH4FH5\SQLEXPRESS;Initial Catalog=KingForest;Integrated Security=True";

        KingForestEntities kflspEntities = new KingForestEntities();
        public List<LoaiSanPhamDTO> LayDSLoaiSP()
        {
            return kflspEntities.LOAISANPHAMs.Where(u => u.TrangThai == 1).Select(u => new LoaiSanPhamDTO {  MaLoaiSP=u.MaLoaiSP,TenLoaiSP = u.TenLoaiSP }).ToList();
        }
        public List<LoaiSanPhamDTO> DemDSLSP()
        {
            return kflspEntities.LOAISANPHAMs.Select(u => new LoaiSanPhamDTO { MaLoaiSP = u.MaLoaiSP }).ToList();
        }
        public bool Them(LoaiSanPhamDTO loaisp)
        {
            try
            {
                LOAISANPHAM LoaiSP = new LOAISANPHAM
                {
                   MaLoaiSP = loaisp.MaLoaiSP,
                   TenLoaiSP = loaisp.TenLoaiSP,
                   TrangThai = 1
                };
                kflspEntities.LOAISANPHAMs.Add(LoaiSP);
                kflspEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool sua(LoaiSanPhamDTO sualsp)
        {
            LOAISANPHAM sualoaisp = kflspEntities.LOAISANPHAMs.SingleOrDefault(u => u.MaLoaiSP == sualsp.MaLoaiSP);
            if (sualoaisp == null)
            {
                return false;
            }
            else
            {
                sualoaisp.TenLoaiSP = sualsp.TenLoaiSP;
                kflspEntities.SaveChanges();
                return true;
            }
        }
        public bool Xoa(LoaiSanPhamDTO xoa)
        {
            LOAISANPHAM xoaLSP = kflspEntities.LOAISANPHAMs.SingleOrDefault(u => u.MaLoaiSP == xoa.MaLoaiSP);
            if (xoaLSP == null)
            {
                return false;
            }
            else
            {
                    xoaLSP.TrangThai = 0;
                    kflspEntities.SaveChanges();
                    return true;     
            }
        }
        public bool TrungTen(string ten)
        {
            LOAISANPHAM kt = kflspEntities.LOAISANPHAMs.Where(u=> u.TrangThai == 1).SingleOrDefault(u => u.TenLoaiSP == ten);
            if (kt == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
