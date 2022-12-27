using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public string MaKM { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public int SoLuong { get; set; }
        public Decimal GiaGiam { get; set; }
        public int TrangThai { get; set; }
    }
}
