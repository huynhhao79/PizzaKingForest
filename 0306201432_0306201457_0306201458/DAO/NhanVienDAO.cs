using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NhanVienDAO
    {
        KingForestEntities kfnvEntities = new KingForestEntities();
        string _con = @"Data Source=huynhhaopc;Initial Catalog=KingForest;Integrated Security=True";
        public List<NhanVienDTO> LayDSNV()
        {
            return kfnvEntities.NHANVIENs.Where(u => u.TrangThai == 1).Select(u => new NhanVienDTO { MaNV = u.MaNV, HoTenLotNV = u.HoTenLotNV, TenNV = u.TenNV, Phai = u.Phai, NgaySinh = u.NgaySinh.Value, ChucVu = u.ChucVu, DChi = u.DChi, SDT = u.SDT, Email = u.Email, CCCD = u.CCCD,AnhThe = u.AnhThe}).ToList();
        }
        public List<NhanVienDTO> DemDSNV()
        {
            return kfnvEntities.NHANVIENs.Select(u => new NhanVienDTO { MaNV = u.MaNV }).ToList();
        }

        public List<NhanVienDTO>LayTenNV_Ngay(DateTime NgayLap)
        {
            List<NhanVienDTO> ltrNV = new List<NhanVienDTO>();
            SqlConnection conn = new SqlConnection(_con);
            conn.Open();


            string a = "  SELECT HOTENLOTNV, TENNV FROM NHANVIEN NV, HOADON HD WHERE NV.MANV = HD.MANV AND year(HD.NgayLapHD) = {0} and MONTH(HD.NgayLapHD) = {1} and day(hd.NgayLapHD) = {2} AND HD.TRANGTHAI = 1";
            string sql = string.Format(a, NgayLap.Year,NgayLap.Month,NgayLap.Day);

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVienDTO _NV = new NhanVienDTO
                    {
                       HoTenLotNV = reader.GetString(0),
                       TenNV = reader.GetString(1)
                    };
                    ltrNV.Add(_NV);
                }
            }
            conn.Close();
            return ltrNV;
        }
        public List<NhanVienDTO> LayTenNV_HD()
        {
            List<NhanVienDTO> ltrNV = new List<NhanVienDTO>();
            SqlConnection conn = new SqlConnection(_con);
            conn.Open();


            string sql = "  SELECT HOTENLOTNV, TENNV FROM NHANVIEN NV, HOADON HD WHERE NV.MANV = HD.MANV AND HD.TRANGTHAI = 1";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVienDTO _NV = new NhanVienDTO
                    {
                        HoTenLotNV = reader.GetString(0),
                        TenNV = reader.GetString(1)
                    };
                    ltrNV.Add(_NV);
                }
            }
            conn.Close();
            return ltrNV;
        }


       
        public bool ThemNV(NhanVienDTO themNV)
        {
            try
            {
                NHANVIEN addnv = new NHANVIEN
                {
                    MaNV = themNV.MaNV,
                    HoTenLotNV = themNV.HoTenLotNV,
                    TenNV = themNV.TenNV,
                    Phai = themNV.Phai,
                    AnhThe = themNV.AnhThe,
                    NgaySinh = themNV.NgaySinh,
                    ChucVu = themNV.ChucVu,
                    DChi = themNV.DChi,
                    SDT = themNV.SDT,
                    Email = themNV.Email,
                    CCCD = themNV.CCCD,
                    TrangThai = 1
                };
                kfnvEntities.NHANVIENs.Add(addnv);
                kfnvEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SuaNV(NhanVienDTO NV)
        {
            TAIKHOAN suaNV = kfnvEntities.TAIKHOANs.SingleOrDefault(u => u.MaNV == NV.MaNV && u.TrangThai == 1);
            NHANVIEN suaNV2 = kfnvEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == NV.MaNV && u.TrangThai == 1);
            if (suaNV2 == null)
            {
                return false;
            }
            else
            {
                suaNV2.HoTenLotNV = NV.HoTenLotNV;
                suaNV2.TenNV = NV.TenNV;
                suaNV2.Phai = NV.Phai;
                suaNV2.AnhThe = NV.AnhThe;
                suaNV2.NgaySinh = NV.NgaySinh;
                suaNV2.ChucVu = NV.ChucVu;
                suaNV.Quyen = NV.ChucVu;
                suaNV2.DChi = NV.DChi;
                suaNV2.Email = NV.Email;
                suaNV2.SDT = NV.SDT;
                suaNV2.CCCD = NV.CCCD;
                kfnvEntities.SaveChanges();
                return true;
            }
        }
        public bool XoaNV(NhanVienDTO NV)
        {
            TAIKHOAN XoaNV = kfnvEntities.TAIKHOANs.SingleOrDefault(u => u.MaNV == NV.MaNV && u.TrangThai == 1);
            NHANVIEN XoaNV2 = kfnvEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == NV.MaNV && u.TrangThai == 1);
            if (XoaNV == null || XoaNV2 == null)
            {
                return false;
            }
            else
            {
                XoaNV.TrangThai = 0;
                XoaNV2.TrangThai = 0;
                kfnvEntities.SaveChanges();
                return true;
            }
        }
    }
}
