using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class HoaDonDAO
    {
        KingForestEntities qlhdEntities = new KingForestEntities();
        HardCode cons = new HardCode();
        string _con = @"Data Source=huynhhaopc;Initial Catalog=KingForest;Integrated Security=True";

        public List<HoaDonDTO> LayDSHD()
        {
            return qlhdEntities.HOADONs.Select(u => new HoaDonDTO { MaHD = u.MaHD, MaNV = u.MaNV, NgayLapHD = u.NgayLapHD.Value, Tong = u.Tong.Value,TrangThai = u.TrangThai.Value }).ToList();  
        }
        public bool ThemHD(HoaDonDTO hd)
        {
            try
            {
                HOADON addhd = new HOADON
                {
                    MaHD = hd.MaHD,
                    MaNV = hd.MaNV,
                    NgayLapHD = hd.NgayLapHD,
                    Tong = hd.Tong,
                    TrangThai = 1
                };
                qlhdEntities.HOADONs.Add(addhd);
                qlhdEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaHD(HoaDonDTO Xoahd)
        {
            HOADON XoaHD = qlhdEntities.HOADONs.SingleOrDefault(u => u.MaHD== Xoahd.MaHD && u.TrangThai == 1); 
            if (XoaHD == null )
            {
                return false;
            }
            else
            {
                XoaHD.TrangThai = 0;
                SqlConnection conn = new SqlConnection(_con);
                conn.Open();


                string a = "UPDATE CT_HOADON SET TRANGTHAI = 0 WHERE MAHD = @mahd";

                SqlCommand cmd = new SqlCommand(a, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", Xoahd.MaHD));
                cmd.ExecuteNonQuery();
                conn.Close();
                qlhdEntities.SaveChanges();
                return true;
            }                 
        }
            public List<HoaDonDTO> LayDSHD_NV(NhanVienDTO NV)
        {
            return qlhdEntities.HOADONs.Where(u => u.TrangThai == 1 && u.MaNV == NV.MaNV ).Select(u => new HoaDonDTO 
            { MaHD = u.MaHD, MaNV = u.MaNV, NgayLapHD = u.NgayLapHD.Value, Tong = u.Tong.Value }).ToList();

        }
        public List<HoaDonDTO> LayDSHD_Ngay(DateTime NgayLap)
        {
            return qlhdEntities.HOADONs.Where(u => u.TrangThai == 1 && u.NgayLapHD == NgayLap).Select(u => new HoaDonDTO { MaHD = u.MaHD, MaNV = u.MaNV, NgayLapHD = u.NgayLapHD.Value, Tong = u.Tong.Value }).ToList();

        }
        public List<HoaDonDTO> LayDSHD_SP(SanPhamDTO SP)
        {
            List<HoaDonDTO> ltrHD = new List<HoaDonDTO>();
            SqlConnection conn = new SqlConnection(_con);
            conn.Open();


            string a = "SELECT HD.MAHD, HD.MANV, HD.NgayLapHD, HD.TONG FROM HOADON HD,SANPHAM SP, CT_HOADON CT  WHERE HD.MAHD = CT.MAHD AND SP.MASP = CT.MASP AND SP.MASP = @MASP AND HD.TRANGTHAI = 1";

            SqlCommand cmd = new SqlCommand(a, conn);
            cmd.Parameters.Add(new SqlParameter("@MASP", SP.MaSP));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HoaDonDTO _HD = new HoaDonDTO
                    {
                        MaHD = reader.GetString(0),
                        MaNV = reader.GetString(1),
                        NgayLapHD = reader.GetDateTime(2),
                        Tong = reader.GetDecimal(3)
                    };
                    ltrHD.Add(_HD);
                }
            }
            conn.Close();
            return ltrHD;
        }
        public List<HoaDonDTO> LayDSHD_LSP(LoaiSanPhamDTO LSP)
        {
            List<HoaDonDTO> ltrHD = new List<HoaDonDTO>();
            SqlConnection conn = new SqlConnection(_con);
            conn.Open();


            string a = "SELECT HD.MAHD, HD.MANV, HD.NgayLapHD, HD.TONG  FROM HOADON HD,LOAISANPHAM LSP, CT_HOADON CT , SANPHAM SP WHERE HD.MAHD = CT.MAHD AND LSP.MaLoaiSP = SP.MaLoaiSP AND SP.MASP = CT.MASP AND LSP.MaLoaiSP = @MALSP AND HD.TRANGTHAI = 1";

            SqlCommand cmd = new SqlCommand(a, conn);
            cmd.Parameters.Add(new SqlParameter("@MALSP", LSP.MaLoaiSP));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HoaDonDTO _HD = new HoaDonDTO
                    {
                        MaHD = reader.GetString(0),
                        MaNV = reader.GetString(1),
                        NgayLapHD = reader.GetDateTime(2),
                        Tong = reader.GetDecimal(3)
                    };
                    ltrHD.Add(_HD);
                }
            }
            conn.Close();
            return ltrHD;
        }
    }
}
