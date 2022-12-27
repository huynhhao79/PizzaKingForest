using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLoaiSP { get; set; }
        public string DeBanh { get; set; }
        public string MoTa { get; set; }
        public string KichCo { get; set; }
        public string AnhSP { get; set; }
        public Decimal DonGia { get; set; }
        public int TrangThai { get; set; }
    }
}
